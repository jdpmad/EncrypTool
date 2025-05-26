using System;
using System.Drawing;
using System.Windows.Forms;

namespace EncrypTool
{
    public partial class CipherSelectionForm : Form
    {
        public CipherSelectionForm()
        {
            InitializeComponent();
        }

        public ConversionForm tF;

        private void c_l_cifras_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_b_confirmar.Enabled = true; //ativar o botão de confirmar assi que o utilizador interage com o form

            if (c_l_cifras.SelectedItem.ToString() == "    Cifra de César") //se o intem selecionado for a cifra de césar
            {
                Variables.cifra = "César"; //alterar uma variável necessária no último form
                c_l_descricao1.Text = "Tipo de cifra na qual cada letra do texto é substituída pela correspondente no alfabeto deslocado abaixo."; //alterar a descrição da cifra
                c_l_imagem.Image = Properties.Resources.caesar_cipher; //carregar e substituir a imagem
                c_l_imagem.Size = new Size(345, 146); //alterar o tamanho da label
                c_l_imagem.Location = new Point(56, 203); //mudar a posição com fins de enquadramento 
            }

            if (c_l_cifras.SelectedItem.ToString() == "      Código Tap")
            {
                Variables.cifra = "Tap";
                c_l_descricao1.Text = "Tipo de cifra em que se usa uma grelha 5x5 para atribuir dois números (linha e coluna) a cada letra.";
                c_l_imagem.Image = Properties.Resources.tap_code;
                c_l_imagem.Size = new Size(223, 146);
                c_l_imagem.Location = new Point(178, 203);
            }

            if (c_l_cifras.SelectedItem.ToString() == "    Código Morse")
            {
                Variables.cifra = "Morse";
                c_l_descricao1.Text = "Sistema de codificação que utiliza pontos e traços para corresponder a cada número ou letra do alfabeto.";
                c_l_imagem.Image = Properties.Resources.morse_code;
                c_l_imagem.Size = new Size(301, 146);
                c_l_imagem.Location = new Point(100, 203);
            }
        }

        private void Cifras_Load(object sender, EventArgs e)
        {
            c_l_cifras.SelectedIndex = 0; //ao carregar, definir o index para o primeiro da lista
        }

        private void c_b_confirmar_Click(object sender, EventArgs e)
        {
            FormCollection frm = Application.OpenForms;

            PreLoad();

            if (Variables.cifra == "César")
            {
                foreach (Form f in frm)
                {
                    if (f.Name == "CaesarShiftForm")
                    {
                        c_l_cifras.Focus();
                        f.BringToFront();
                        Variables.currentForm = "CaesarShiftForm";
                    }
                }
            }
            else
            {
                foreach (Form f in frm)
                {
                    if (f.Name == "ConversionForm")
                    {
                        c_l_cifras.Focus();
                        f.BringToFront();
                        Variables.currentForm = "ConversionForm";
                    }
                }
            }
        }

        private void PreLoad()
        {
            if (Variables.cifra == "Tap")
            {
                tF.label2.Visible = false; //esconder o alfabeto original (label)
                tF.label3.Visible = false; //esconder a seta 1
                tF.label4.Visible = false; //esconder a seta 2
                tF.label5.Visible = false; //esconder a seta 3
                tF.t_l_cAlphabet.Text = ""; //limpar o texto
                tF.t_l_cAlphabet.Visible = false; //esconder o alfabeto de césar (label)
                tF.t_t_imagem.Image = Properties.Resources.tap_code; //mostrar a imagem da cifra tap
            }
            if (Variables.cifra == "Morse")
            {
                tF.label2.Visible = false;
                tF.label3.Visible = false;
                tF.label4.Visible = false;
                tF.label5.Visible = false;
                tF.t_l_cAlphabet.Text = "";
                tF.t_l_cAlphabet.Visible = false;
                tF.t_t_imagem.Image = Properties.Resources.morse_code;
            }
        }
    }
}
