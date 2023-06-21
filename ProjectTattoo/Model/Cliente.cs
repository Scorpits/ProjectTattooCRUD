using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTattoo.Model {
    public class Cliente {
        private int id;
        private string nome;
        private string endereco;
        private string cep;
        private string bairro;
        private string cidade;
        private string telefone;
        private string horario;
        private string tatuagem;
        // CONSTRUTOR
        public Cliente() {
            this.id = 0;
            nome = endereco = cep = bairro = cidade = telefone = horario = tatuagem = "";
        }
        // PROPRIEDADES
        public int Id {
            get { return id; }
            set { id = value; }
        }
        public string Nome {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Cep {
            get { return cep; }
            set { cep = value; }
        }
        public string Bairro {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Telefone {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Horario {
            get { return horario; }
            set { horario = value; }
        }
        public string Tatuagem {
            get { return tatuagem; }
            set { tatuagem = value; }
        }
    }
}
