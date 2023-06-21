using ProjectTattoo.Model;
using ProjectTattoo.Model.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTattoo.View {
    public partial class MenuConsulta : Form {
        string connectionString = @"Server=.\sqlexpress;Database=DB_TATTOOCADASTRO;Trusted_Connection=True;";
        ControleBD bd;
        Cliente dados;
        bool noId;
        public MenuConsulta() {
            InitializeComponent();
            bd = new ControleBD(connectionString);
            dados = new Cliente();
        }

        private void MenuConsulta_Load(object sender, EventArgs e) {
            bt_excluir.Enabled = false;
        }

        private void bt_carregarData_Click(object sender, EventArgs e) {
            bd.dataGridSQL(ref this.dataGrid);
        }

        private void bt_buscarID_Click(object sender, EventArgs e) {
            dados = bd.buscarSQL(txt_id.Text, ref noId);
            if (!noId) {
                txt_nome.Text = dados.Nome;
                txt_endereco.Text = dados.Endereco;
                txt_cep.Text = dados.Cep;
                txt_bairro.Text = dados.Bairro;
                txt_cidade.Text = dados.Cidade;
                txt_telefone.Text = dados.Telefone;
                txt_horario.Text = dados.Horario;
                txt_tatuagem.Text = dados.Tatuagem;
                txt_reallyID.Text = dados.Id.ToString();
                bt_excluir.Enabled = true;
            } 
            else
                MessageBox.Show("Nenhum registro foi encontrado com esse ID!");
        }

        private void bt_excluir_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Deseja excluir cadastro?", "ATENÇÃO!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                bd.excluirSQL(txt_id.Text);
            bt_excluir.Enabled = false;
            txt_nome.Text = "";
            txt_endereco.Text = "";
            txt_cep.Text = "";
            txt_bairro.Text = "";
            txt_cidade.Text = "";
            txt_telefone.Text = "";
            txt_horario.Text = "";
            txt_tatuagem.Text = "";
            txt_reallyID.Text = "";
        }

        private void bt_voltar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
