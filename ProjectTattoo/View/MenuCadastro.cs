using ProjectTattoo.Model;
using ProjectTattoo.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTattoo.View {
    public partial class MenuCadastrar : Form {
        // shenanigans do SQL
        string connectionString = @"Server=.\sqlexpress;Database=DB_TATTOOCADASTRO;Trusted_Connection=True;";
        bool novo, noId, vazio;
        // instanciando Cliente e Controle de BD
        Cliente dados;
        ControleBD bd;
        public MenuCadastrar() {
            InitializeComponent();
            dados = new Cliente();
            bd = new ControleBD(connectionString);
        }

        private void MenuCadastrar_Load(object sender, EventArgs e) {
            // Quando carregar a janela pela primeira vez, desativar tudo e fazer o usuario escolher entre
            // atualizar cadastro ou criar um novo
            bt_busca.Enabled = true;
            txt_busca.Enabled = true;
            bt_new.Enabled = true;
            txt_ID.Enabled = true;
            bt_salvar.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_endereco.Enabled = false;
            txt_nome.Enabled = false;
            txt_tatuagem.Enabled = false;
            txt_telefone.Enabled = false;
            date_horario.Enabled = false;
            bt_salvar.BackColor = Color.FromName("ControlDarkDark");
            bt_cancel.Enabled = false;
            bt_cancel.BackColor = Color.FromName("ControlDarkDark");
            bt_busca.BackColor = Color.FromName("Control");
        }

        private void bt_new_Click(object sender, EventArgs e) {
            // ao criar um novo cadastro
            novo = true;
            bt_new.Enabled = false;
            // trocando cores para ficar linda de mais
            bt_new.BackColor = Color.FromName("ControlDarkDark");
            bt_salvar.BackColor = Color.FromName("Control");
            bt_cancel.Enabled = true;
            bt_cancel.BackColor = Color.FromName("Control");
            txt_ID.Enabled = true;
            bt_salvar.Enabled = true;
            txt_bairro.Enabled = true;
            txt_cep.Enabled = true;
            txt_cidade.Enabled = true;
            txt_endereco.Enabled = true;
            txt_nome.Enabled = true;
            txt_tatuagem.Enabled = true;
            txt_telefone.Enabled = true;
            date_horario.Enabled = true;
            txt_nome.Focus();
            bt_busca.Enabled = false;
            txt_busca.Enabled = false;
            bt_busca.BackColor = Color.FromName("ControlDarkDark");
        }

        private void bt_cancel_Click(object sender, EventArgs e) {
            txt_bairro.Text = "";
            txt_cep.Text = "";
            txt_cidade.Text = "";
            txt_endereco.Text = "";
            txt_ID.Text = "";
            txt_nome.Text = "";
            txt_tatuagem.Text = "";
            txt_telefone.Text = "";
            date_horario.Text = "";
            bt_new.Enabled = true;
            txt_ID.Enabled = true;
            bt_salvar.Enabled = false;
            txt_bairro.Enabled = false;
            txt_cep.Enabled = false;
            txt_cidade.Enabled = false;
            txt_endereco.Enabled = false;
            txt_nome.Enabled = false;
            txt_tatuagem.Enabled = false;
            txt_telefone.Enabled = false;
            date_horario.Enabled = false;
            bt_salvar.BackColor = Color.FromName("ControlDarkDark");
            bt_cancel.Enabled = false;
            bt_cancel.BackColor = Color.FromName("ControlDarkDark");
            bt_new.BackColor = Color.FromName("Control");
            bt_busca.Enabled = true;
            txt_busca.Enabled = true;
            bt_busca.BackColor = Color.FromName("Control");
        }

        private void bt_salvar_Click(object sender, EventArgs e) {
            // checando para ver se ha algum espaco vazio que o usuario esquecer de preencher
            if (txt_nome.Text.Trim() == "" || txt_endereco.Text.Trim() == "" || txt_bairro.Text.Trim() == "" || txt_cidade.Text.Trim() == "" || txt_tatuagem.Text.Trim() == "")
                vazio = true;
            else
                vazio = false;
            // parte para realizar um novo cadastro
            if (novo && !vazio) {
                dados.Cep = txt_cep.Text;
                dados.Nome = txt_nome.Text;
                dados.Endereco = txt_endereco.Text;
                dados.Bairro = txt_bairro.Text;
                dados.Cidade = txt_cidade.Text;
                dados.Telefone = txt_telefone.Text;
                dados.Horario = date_horario.Text;
                dados.Tatuagem = txt_tatuagem.Text;
                bd.cadastrarSQL(dados);
                #region Resetando os campos
                txt_bairro.Text = "";
                txt_cep.Text = "";
                txt_cidade.Text = "";
                txt_endereco.Text = "";
                txt_ID.Text = "";
                txt_nome.Text = "";
                txt_tatuagem.Text = "";
                txt_telefone.Text = "";
                date_horario.Text = "";
                bt_new.Enabled = true;
                txt_ID.Enabled = true;
                bt_salvar.Enabled = false;
                txt_bairro.Enabled = false;
                txt_cep.Enabled = false;
                txt_cidade.Enabled = false;
                txt_endereco.Enabled = false;
                txt_nome.Enabled = false;
                txt_tatuagem.Enabled = false;
                txt_telefone.Enabled = false;
                date_horario.Enabled = false;
                bt_salvar.BackColor = Color.FromName("ControlDarkDark");
                bt_cancel.Enabled = false;
                bt_cancel.BackColor = Color.FromName("ControlDarkDark");
                bt_new.BackColor = Color.FromName("Control");
                bt_busca.Enabled = true;
                txt_busca.Enabled = true;
                bt_busca.BackColor = Color.FromName("Control");
                #endregion
            //parte para realizar uma atualizacao de cadastro
            } else if (!vazio) { 
                dados.Cep = txt_cep.Text;
                dados.Nome = txt_nome.Text;
                dados.Endereco = txt_endereco.Text;
                dados.Bairro = txt_bairro.Text;
                dados.Cidade = txt_cidade.Text;
                dados.Telefone = txt_telefone.Text;
                dados.Horario = date_horario.Text;
                dados.Tatuagem = txt_tatuagem.Text;
                DialogResult dialogResult = MessageBox.Show("Deseja atualizar o cadastro?", "Atualizar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    bd.atualizarSQL(dados);
                #region Resetando os campos
                txt_bairro.Text = "";
                txt_cep.Text = "";
                txt_cidade.Text = "";
                txt_endereco.Text = "";
                txt_ID.Text = "";
                txt_nome.Text = "";
                txt_tatuagem.Text = "";
                txt_telefone.Text = "";
                date_horario.Text = "";
                bt_new.Enabled = true;
                txt_ID.Enabled = true;
                bt_salvar.Enabled = false;
                txt_bairro.Enabled = false;
                txt_cep.Enabled = false;
                txt_cidade.Enabled = false;
                txt_endereco.Enabled = false;
                txt_nome.Enabled = false;
                txt_tatuagem.Enabled = false;
                txt_telefone.Enabled = false;
                date_horario.Enabled = false;
                bt_salvar.BackColor = Color.FromName("ControlDarkDark");
                bt_cancel.Enabled = false;
                bt_cancel.BackColor = Color.FromName("ControlDarkDark");
                bt_new.BackColor = Color.FromName("Control");
                bt_busca.Enabled = true;
                txt_busca.Enabled = true;
                bt_busca.BackColor = Color.FromName("Control");
                #endregion
            } else
                // caso esteja vazio algum espaco
                MessageBox.Show("Há alguns itens vazios!", "Alerta!");
        }

        private void bt_sair_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void bt_busca_Click(object sender, EventArgs e) {
            dados = bd.buscarSQL(txt_busca.Text, ref noId);
            // essa parte faz com o que o usuario digite um ID e faz a busca
            // no sql, colocando as informacoes nos textbox para uma possivel
            // atualizacao de dados
            // colocando nos text box
            if (!noId) {
                txt_ID.Text = Convert.ToString(dados.Id);
                txt_nome.Text = dados.Nome;
                txt_endereco.Text = dados.Endereco;
                txt_cep.Text = dados.Cep;
                txt_bairro.Text = dados.Bairro;
                txt_cidade.Text = dados.Cidade;
                txt_telefone.Text = dados.Telefone;
                date_horario.Text = dados.Horario;
                txt_tatuagem.Text = dados.Tatuagem;
                //
                bt_new.Enabled = false;
                bt_new.BackColor = Color.FromName("ControlDarkDark");
                bt_salvar.BackColor = Color.FromName("Control");
                bt_cancel.Enabled = true;
                bt_cancel.BackColor = Color.FromName("Control");
                txt_ID.Enabled = true;
                bt_salvar.Enabled = true;
                txt_bairro.Enabled = true;
                txt_cep.Enabled = true;
                txt_cidade.Enabled = true;
                txt_endereco.Enabled = true;
                txt_nome.Enabled = true;
                txt_tatuagem.Enabled = true;
                txt_telefone.Enabled = true;
                date_horario.Enabled = true;
                txt_nome.Focus();
                bt_busca.Enabled = false;
                txt_busca.Enabled = false;
                bt_busca.BackColor = Color.FromName("ControlDarkDark");
                novo = false;
            } 
            else {
                MessageBox.Show("Nenhum registro foi encontrado com esse ID!");
            }
        }
    }
}
