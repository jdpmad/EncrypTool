using System;
using System.Threading;
using System.Windows.Forms;

namespace EncrypTool
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
        }
        ConversionForm convForm; //para criar uma variável do tipo do form
        CaesarShiftForm caesarSForm;
        CipherSelectionForm cifSelForm;
        MainMenuForm mMForm;
        WMPLib.WindowsMediaPlayer wMPlayer = new WMPLib.WindowsMediaPlayer(); //criar uma variável do tipo windows media player (para a música)

        public void LayoutForm_Load(object sender, EventArgs e)
        {
            L_b_casa.Hide(); //esconder o botão casa
            l_b_voltar.Hide(); //esconder o botão de voltar atrás
            wMPlayer.URL = Application.StartupPath.Replace("\\bin\\Debug", "\\Resources\\menuLoop.mp3"); //local da música a ser tocada
            wMPlayer.settings.volume = 15; //volume (de 0-100)
            wMPlayer.settings.setMode("loop", true); //definir o loop da música

            Thread.Sleep(1500); //esperar que a música carregue para sincronizar a abertura do programa com o início da música 

            convForm = new ConversionForm();
            convForm.MdiParent = this;
            convForm.Show();

            caesarSForm = new CaesarShiftForm();
            caesarSForm.MdiParent = this;
            caesarSForm.tF = convForm;
            caesarSForm.Show();

            cifSelForm = new CipherSelectionForm();
            cifSelForm.MdiParent = this;
            cifSelForm.tF = convForm;
            cifSelForm.Show();
            
            mMForm = new MainMenuForm();
            mMForm.MdiParent = this;
            mMForm.Show();
            mMForm.lF = this; //definir a variável layoutForm no form do menu inicial para controlar o botão da casa
            Variables.currentForm = "MainMenuForm"; //definir qual é o form em que o utilizador está (para resolver bugs)
        }

        private void b_som_Click(object sender, EventArgs e)
        {
            tabFix(); //executar a função
            if (Variables.som == 0) //se estiver mutado (variável a 0)
            {
                Variables.som = 1; //alterar a variável do som
                l_b_som.Image = Properties.Resources.button_unmute; //mudar a imagem
                wMPlayer.settings.mute = false; //desmutar
                goto stop; //sair da função
            }
            else
            {
                Variables.som = 0;
                l_b_som.Image = Properties.Resources.button_mute;
                wMPlayer.settings.mute = true;
                goto stop;
            }
        stop:; //ponto de teletransporte para sair da função
        }

        private void c_b_casa_Click(object sender, EventArgs e)
        {
            L_b_casa.Enabled = false; //desativar o botão de casa (porque se vai para o menu inicial)
            l_b_voltar.Enabled = false; //desativar o botão de voltar atrás (porque se vai para o menu inicial)
            L_b_casa.Hide(); //esconder o botão de casa
            l_b_voltar.Hide(); //esconder o botão de voltar atrás

            convForm.t_t_input.Clear();
            convForm.t_t_convertido.Clear();
            convForm.t_t_imagem.Text = "";

            cifSelForm.c_l_cifras.SelectedIndex = 0;
            caesarSForm.c_n_rotacao.Value = 0;

            FormCollection frm = Application.OpenForms; //criar variável de coleção de forms que, neste caso, engloba os forms abertos

            foreach (Form f in frm) //para cada form na coleção
            {
                if (f.Name == "MainMenuForm") //se tiver o nome MainMenu
                {
                    tabFix();
                    f.BringToFront(); //trazer para a frente o form MainMenu
                    Variables.currentForm = "MainMenuForm";
                }
            }           
        }

        private void tabFix() //para resolver um problema com o tab e os botões (ao clicar no tab, o último form aparecia)
        {
            if (Variables.currentForm == "MainMenuForm") //se o form atual for o menu principal
            {
                mMForm.b_iniciar.Focus(); //focar o primeito botão do form
            }
            if (Variables.currentForm == "CipherSelectionForm")
            {
                cifSelForm.c_l_cifras.Focus();
            }
            if (Variables.currentForm == "CaesarShiftForm")
            {
                caesarSForm.c_n_rotacao.Focus();
            }
            if (Variables.currentForm == "ConversionForm")
            {
                convForm.t_t_input.Focus();
            }
        }

        private void l_b_voltar_Click(object sender, EventArgs e)
        {
            FormCollection frm = Application.OpenForms;
            
            foreach (Form f in frm)
            {                            
                if (Variables.currentForm == "ConversionForm")
                {
                    if (Variables.cifra == "César")
                    {
                        if (f.Name == "CaesarShiftForm")
                        {
                            convForm.t_t_input.Clear();
                            convForm.t_t_convertido.Clear();
                            convForm.t_t_imagem.Text = "";

                            tabFix();
                            f.BringToFront();
                            Variables.currentForm = "CaesarShiftForm";
                            return;
                        }
                    }
                    else
                    {
                        if (f.Name == "CipherSelectionForm")
                        {
                            convForm.t_t_input.Clear();
                            convForm.t_t_convertido.Clear();
                            convForm.t_t_imagem.Text = "";

                            tabFix();
                            f.BringToFront();
                            Variables.currentForm = "CipherSelectionForm";
                            return;
                        }
                    }
                }

                if (Variables.currentForm == "CaesarShiftForm")
                {
                    if (f.Name == "CipherSelectionForm")
                    {
                        caesarSForm.c_n_rotacao.Value = 0;

                        tabFix();
                        f.BringToFront();
                        Variables.currentForm = "CipherSelectionForm";
                        return;
                    }
                }

                if (Variables.currentForm == "CipherSelectionForm") //se estiver no form cifra, voltar para o menu principal
                {
                    if (f.Name == "MainMenuForm")
                    {
                        cifSelForm.c_l_cifras.SelectedIndex = 0; //repor as definições padrão do form atual

                        L_b_casa.Enabled = false; //esconder os botões porque se vai para o menu principal
                        l_b_voltar.Enabled = false;
                        L_b_casa.Hide();
                        l_b_voltar.Hide();

                        tabFix();
                        f.BringToFront();
                        Variables.currentForm = "MainMenuForm";
                        return; //sai do método
                    }
                }
            }
        }
    }
}
