using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTattoo.Controller;
using ProjectTattoo.View;

namespace ProjectTattoo {
    public partial class MainMenu : Form {
        #region Declaracao de objetos que serao usados
        MenuCadastrar menuCadastro;
        MenuConsulta menuConsulta;
        FormMethods met;
        #endregion
        public MainMenu() {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e) {
            //comando de codigos que irao puxar a nova janela que sera de cadastro de clientes
            #region INSTACIACAO
            menuCadastro = new MenuCadastrar();
            met = new FormMethods(menuCadastro);
            #endregion
            bool isOpen = false;
            met.CheckOpenForm(ref isOpen);
            // checando se form esta aberto, caso nao esteja, abrir um form
            if (!isOpen) {
                met.OpenOtherForm(this.Top, this.Left);
            }
        }

        private void bt_consultar_cliente_Click(object sender, EventArgs e) {
            #region INSTANCIACAO
            menuConsulta = new MenuConsulta();
            met = new FormMethods(menuConsulta);
            #endregion
            bool isOpen = false;
            met.CheckOpenForm(ref isOpen);
            // checando se esta aberto
            if (!isOpen) {
                met.OpenOtherForm(this.Top, this.Left);
            }
        }

        private void bt_sair_Click(object sender, EventArgs e) {
            // ricardo
            Application.Exit();
        }
    }
}
