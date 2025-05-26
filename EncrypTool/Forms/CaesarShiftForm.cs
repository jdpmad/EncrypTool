using System;
using System.Windows.Forms;

namespace EncrypTool
{
    public partial class CaesarShiftForm : Form
    {
        public ConversionForm tF;
        public CaesarShiftForm()
        {
            InitializeComponent();
        }

        private void t_n_rotacao_ValueChanged(object sender, EventArgs e)
        {
            Caesar caesar = new Caesar(int.Parse(c_n_rotacao.Value.ToString()));
            c_l_cAlphabet.Text = caesar.Encrypt("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");

            if (c_n_rotacao.Value != 0) //se for diferente de 0
            {
                c_b_confirmar.Enabled = true; //ativar o botão de confirmar
            }
            else
            {
                c_b_confirmar.Enabled = false; //desativar o botão de confirmar
            }
        }

        private void c_b_confirmar_Click(object sender, EventArgs e)
        {
            Variables.caesarShift = int.Parse(c_n_rotacao.Value.ToString());
            Caesar caesar = new Caesar(int.Parse(c_n_rotacao.Value.ToString()));
            c_l_cAlphabet.Text = caesar.Encrypt("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");

            tF.t_t_imagem.Image = null; //esconder a label de imagem usada para apresentar as tabelas das outras cifras
            tF.label2.Visible = true; //mostrar o alfabeto original (label)
            tF.label3.Visible = true; //mostrar a seta 1
            tF.label4.Visible = true; //mostrar a seta 2
            tF.label5.Visible = true; //mostrar a seta 3
            tF.t_l_cAlphabet.Visible = true; //mostrar o alfabeto de césar (label)
            tF.t_l_cAlphabet.Text = c_l_cAlphabet.Text;

            FormCollection frm = Application.OpenForms;

            foreach (Form f in frm)
            {
                if (f.Name == "ConversionForm")
                {
                    c_n_rotacao.Focus();
                    f.BringToFront();
                    Variables.currentForm = "ConversionForm";
                }
            }
        }
    }
}
