using FluxoDeCaixa.Models;
using FluxoDeCaixa.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxoDeCaixa
{
    public class Gerenciador
    {
        private Banco banco = new Banco();
        
        public Validacao AdicionarRegistro(Registro registroAdicionado)
        {
            Validacao validacao = new Validacao();
            if (registroAdicionado.Id < 0)
            {
                validacao.Mensagens.Add("Id", "O indenfiticador deve constituir apenas números positivos");
            }
            //verifica se já tem alguma mensagem de erro e se tiver pula essa verificação
            if (this.banco.Registros.Where(c => c.Id == registroAdicionado.Id).Any() && validacao.Mensagens.Count == 0)
            {
                validacao.Mensagens.Add("Id", "Já existe um cliente com esse código");
            }

            if (String.IsNullOrEmpty(registroAdicionado.Descricao))
            {
                validacao.Mensagens.Add("Descrição", "O campo descrição não pode ser nulo ou vazio");
            }
            if (String.IsNullOrEmpty(registroAdicionado.Data.ToLongDateString()))
            {
                validacao.Mensagens.Add("Data", "O campo data não pode ser nulo ou vazio");
            }
            if (String.IsNullOrEmpty(registroAdicionado.Valor.ToString()))
            {
                validacao.Mensagens.Add("Valor", "O valor não pode ser nulo ou vazio");
            }

            if (validacao.Valido)
            {
                this.banco.Registros.Add(registroAdicionado);
                this.banco.SaveChanges();
            }

            return validacao;
        }
        public Validacao RemoverRegistro(Registro registro)
        {
            Validacao validacao = new Validacao();
            banco.Registros.Remove(registro);
            banco.SaveChanges();
            return validacao;
        }
        public Validacao AlterarRegistro(Registro registroAlterado)
        {
            Validacao validacao = new Validacao();
            Registro registroBanco = BuscaRegistroPorId(registroAlterado.Id);
            registroBanco.Descricao = registroAlterado.Descricao;
            registroBanco.Valor = registroAlterado.Valor;
            this.banco.SaveChanges();
            return validacao;

        }
        public Registro BuscaRegistroPorId(long Id)
        {
            return this.banco.Registros.Where(r => r.Id == Id).FirstOrDefault();
        }
        public List<Registro> TodosOsRegistros()
        {
            return this.banco.Registros.ToList();
        }
    }
}
