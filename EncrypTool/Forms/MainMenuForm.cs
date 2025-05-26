using System;
using System.Windows.Forms;

namespace EncrypTool
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();            
        }

        public LayoutForm lF; //variável pública para poder ser alterada a partir de outros forms. Neste caso, esta variável permite alterar componentes do layoutForm aberto

        private void b_iniciar_Click(object sender, EventArgs e)
        {
            lF.L_b_casa.Enabled = true; //ativar o botão de casa
            lF.l_b_voltar.Enabled = true; //ativar o botão de voltar atrás
            lF.L_b_casa.Show(); //mostrar o botão de casa
            lF.l_b_voltar.Show(); //mostrar o botão de voltar atrás

            FormCollection frm = Application.OpenForms;

            foreach (Form f in frm)
            {
                if (f.Name == "CipherSelectionForm")
                {
                    b_iniciar.Focus();
                    f.BringToFront();
                    Variables.currentForm = "CipherSelectionForm";
                }
            }
        }

        private void b_sair_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }
    }
}
