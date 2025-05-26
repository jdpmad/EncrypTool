using System;
using System.Windows.Forms;

namespace EncrypTool
{
    public partial class ConversionForm : Form
    {
        public ConversionForm()
        {
            InitializeComponent();
        }

        private void t_t_input_TextChanged(object sender, EventArgs e)
        {
            t_b_encriptar.Enabled = true; //ativar o botão de encriptar assim que a caixa de texto da entrada não esteja vazia
            t_b_desencriptar.Enabled = true; //ativar o botão de desencriptar assim que a caixa de texto da entrada não esteja vazia 
            if (t_t_input.Text == "") //caso esteja vazia
            {
                t_b_encriptar.Enabled = false; //desativar o botão de encriptar
                t_b_desencriptar.Enabled = false; //desativar o botão de desencriptar
            }
        }

        private void t_b_limpar_Click(object sender, EventArgs e)
        {
            t_t_input.Clear(); //limpar a caixa de texto da entrada
            t_t_convertido.Clear(); //limpar a caixa de texto do resultado
            t_t_input.Focus(); //focar a caixa de texto da entrada
        }

        private void t_b_encriptar_Click(object sender, EventArgs e)
        {
            if (Variables.cifra == "César") //se a cifra escolhida for a de césar
            {
                Caesar caesar = new Caesar(Variables.caesarShift);
                t_t_convertido.Text = caesar.Encrypt(t_t_input.Text);
            }
            if (Variables.cifra == "Tap")
            {
                Tap tap = new Tap();
                t_t_convertido.Text = tap.Encrypt(t_t_input.Text);
            }
            if (Variables.cifra == "Morse")
            {
                Morse morse = new Morse();
                t_t_convertido.Text = morse.Encrypt(t_t_input.Text);
            }
            t_t_input.Focus(); //focar a caixa de texto da entrada
        }

        private void t_b_desencriptar_Click(object sender, EventArgs e)
        {
            if (Variables.cifra == "César") //se a cifra escolhida for a de césar
            {
                Caesar caesar = new Caesar(Variables.caesarShift);
                t_t_convertido.Text = caesar.Decrypt(t_t_input.Text);
            }
            if (Variables.cifra == "Tap")
            {
                Tap tap = new Tap();
                t_t_convertido.Text = tap.Decrypt(t_t_input.Text);
            }
            if (Variables.cifra == "Morse")
            {
                Morse morse = new Morse();
                t_t_convertido.Text = morse.Decrypt(t_t_input.Text);
            }
            t_t_input.Focus(); //focar a caixa de texto da entrada
        }

        private void t_b_lerFic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //mostrar diálogo de seleção de ficheiro
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Variables.inputFileLoc = openFileDialog1.FileName; //guardar o caminho todo numa variável de outro ficheiro

            t_t_input.Text = FileRW.ReadInputFile();
        }

        private void t_b_salvarFic_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FileRW.SaveOutputFile(saveFileDialog1.FileName, t_t_convertido.Text);
        }

        private void t_b_copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(t_t_convertido.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_t_input.Text = Clipboard.GetText();
        }
    }
}
    