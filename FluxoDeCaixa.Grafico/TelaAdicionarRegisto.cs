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
    public partial class TelaAdicionarRegisto : Form
    {
        public Registro RegistroSelecionado { get; set; }
        public TelaAdicionarRegisto()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            if(Int64.TryParse(tbId.Text, out long value))
            {
                registro.Id = value;
            }
            else
            {
                registro.Id = -1;
            }
            registro.Descricao = tbDescricao.Text;
            registro.Valor = (float)Convert.ToDouble(tbValor.Text);

            Validacao validacao;
            if(RegistroSelecionado == null)
            {
                validacao = Program.Gerenciador.AdicionarRegistro(registro);
            }
            else
            {
                validacao = Program.Gerenciador.AlterarRegistro(registro);
            }
            if (!validacao.Valido)
            {
                String MensagemValidacao = "";
                foreach(var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    MensagemValidacao += msg;
                    MensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(MensagemValidacao);
            }
            else
            {
                MessageBox.Show("Registro salvo com sucesso");
            }
            this.Close();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
