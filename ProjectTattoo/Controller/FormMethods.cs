using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectTattoo.View;

namespace ProjectTattoo.Controller {
    public class FormMethods {
        private Form viewForm;
        public FormMethods(Form x) {
            viewForm = x;
        }
        // metodo para apenas abrir um outro form
        public void OpenOtherForm(int top, int left) {
            viewForm.StartPosition = FormStartPosition.Manual;
            viewForm.Top = top;
            viewForm.Left = left;
            viewForm.Show();
        }
        // Codigo para checar se o form ja esta aberto e nao deixar abrir outro igual ou mais de 1
        public void CheckOpenForm(ref bool isOpen) {
            if (viewForm is MenuCadastrar || viewForm is MenuConsulta)
                foreach (Form f in Application.OpenForms) {
                    if (f.Text == "Cadastrar Clientes") {
                        isOpen = true;
                        f.BringToFront();
                        break;
                    }
                    if (f.Text == "Consultar Clientes") {
                        isOpen = true;
                        f.BringToFront();
                        break;
                    }
                }
        }
    }
}
