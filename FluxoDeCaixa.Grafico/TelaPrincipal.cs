using FluxoDeCaixa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FluxoDeCaixa.Grafico
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void AbreTelaInclusaoAlteracao(Registro registroSelecionado)
        {
            TelaAdicionarRegisto tela = new TelaAdicionarRegisto();
            tela.RegistroSelecionado = registroSelecionado;
            tela.FormClosed += Tela_FormClosed;
            tela.Show();
        }
        private void Tela_FormClosed(object sender, FormClosedEventArgs e)
        {
            CarregarRegistros();
        }
        private void CarregarRegistros()
        {
            dgRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgRegistros.MultiSelect = false;
            dgRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRegistros.AutoGenerateColumns = false;
            List<Registro> clientes = Program.Gerenciador.TodosOsRegistros();
            dgRegistros.DataSource = clientes;
        }
        private bool VerificarSelecao()
        {
            if(dgRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
                return false;
            }
            return true;
        }
        private void btAdicionarRegistro_Click(object sender, EventArgs e)
        {
            AbreTelaInclusaoAlteracao(null);
        }

        private void btAlterarRegistro_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                Registro registroSelecionado = (Registro)dgRegistros.SelectedRows[0].DataBoundItem;
                AbreTelaInclusaoAlteracao(registroSelecionado);
            }
        }

        private void btRemoverRegistro_Click(object sender, EventArgs e)
        {
            if (VerificarSelecao())
            {
                DialogResult resultado = MessageBox.Show("Tem certeza?", "Quer remover?", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    Registro registroSelecionado = (Registro)dgRegistros.SelectedRows[0].DataBoundItem;
                    var validacao = Program.Gerenciador.RemoverRegistro(registroSelecionado);
                    if (validacao.Valido)
                    {
                        MessageBox.Show("Registro removido");
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao remover registro");
                    }
                    CarregarRegistros();
                }
            }
        }

        private void tbRegistros_Selected(object sender, TabControlEventArgs e)
        {
            CarregarRegistros();
        }
    }
}
