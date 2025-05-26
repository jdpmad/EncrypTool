
namespace EncrypTool
{
    partial class ConversionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_b_desencriptar = new System.Windows.Forms.Button();
            this.t_t_convertido = new System.Windows.Forms.TextBox();
            this.t_t_input = new System.Windows.Forms.TextBox();
            this.t_t_imagem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_l_cAlphabet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_b_limpar = new System.Windows.Forms.Button();
            this.t_b_encriptar = new System.Windows.Forms.Button();
            this.t_b_lerFic = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.t_b_salvarFic = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.t_b_copiar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_b_desencriptar
            // 
            this.t_b_desencriptar.BackColor = System.Drawing.Color.White;
            this.t_b_desencriptar.Enabled = false;
            this.t_b_desencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t_b_desencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_b_desencriptar.Location = new System.Drawing.Point(363, 104);
            this.t_b_desencriptar.Name = "t_b_desencriptar";
            this.t_b_desencriptar.Size = new System.Drawing.Size(134, 46);
            this.t_b_desencriptar.TabIndex = 2;
            this.t_b_desencriptar.Text = "Desencriptar";
            this.t_b_desencriptar.UseVisualStyleBackColor = false;
            this.t_b_desencriptar.Click += new System.EventHandler(this.t_b_desencriptar_Click);
            // 
            // t_t_convertido
            // 
            this.t_t_convertido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_t_convertido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_t_convertido.Location = new System.Drawing.Point(520, 16);
            this.t_t_convertido.Multiline = true;
            this.t_t_convertido.Name = "t_t_convertido";
            this.t_t_convertido.ReadOnly = true;
            this.t_t_convertido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_t_convertido.Size = new System.Drawing.Size(256, 216);
            this.t_t_convertido.TabIndex = 5;
            this.t_t_convertido.TabStop = false;
            // 
            // t_t_input
            // 
            this.t_t_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_t_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_t_input.Location = new System.Drawing.Point(80, 16);
            this.t_t_input.Multiline = true;
            this.t_t_input.Name = "t_t_input";
            this.t_t_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_t_input.Size = new System.Drawing.Size(256, 216);
            this.t_t_input.TabIndex = 0;
            this.t_t_input.TextChanged += new System.EventHandler(this.t_t_input_TextChanged);
            // 
            // t_t_imagem
            // 
            this.t_t_imagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_t_imagem.Image = global::EncrypTool.Properties.Resources.morse_code;
            this.t_t_imagem.Location = new System.Drawing.Point(214, 277);
            this.t_t_imagem.Name = "t_t_imagem";
            this.t_t_imagem.Size = new System.Drawing.Size(432, 170);
            this.t_t_imagem.TabIndex = 7;
            this.t_t_imagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = global::EncrypTool.Properties.Resources.arrow;
            this.label5.Location = new System.Drawing.Point(280, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 56);
            this.label5.TabIndex = 18;
            this.label5.Tag = "";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::EncrypTool.Properties.Resources.arrow;
            this.label3.Location = new System.Drawing.Point(480, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 56);
            this.label3.TabIndex = 17;
            this.label3.Tag = "";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::EncrypTool.Properties.Resources.arrow;
            this.label4.Location = new System.Drawing.Point(380, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 56);
            this.label4.TabIndex = 16;
            this.label4.Tag = "";
            this.label4.Visible = false;
            // 
            // t_l_cAlphabet
            // 
            this.t_l_cAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_l_cAlphabet.Location = new System.Drawing.Point(194, 397);
            this.t_l_cAlphabet.Name = "t_l_cAlphabet";
            this.t_l_cAlphabet.Size = new System.Drawing.Size(472, 23);
            this.t_l_cAlphabet.TabIndex = 15;
            this.t_l_cAlphabet.Tag = "";
            this.t_l_cAlphabet.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            this.t_l_cAlphabet.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 23);
            this.label2.TabIndex = 14;
            this.label2.Tag = "";
            this.label2.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            this.label2.Visible = false;
            // 
            // t_b_limpar
            // 
            this.t_b_limpar.BackColor = System.Drawing.Color.White;
            this.t_b_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t_b_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_b_limpar.Location = new System.Drawing.Point(363, 160);
            this.t_b_limpar.Name = "t_b_limpar";
            this.t_b_limpar.Size = new System.Drawing.Size(134, 46);
            this.t_b_limpar.TabIndex = 3;
            this.t_b_limpar.Text = "Limpar";
            this.t_b_limpar.UseVisualStyleBackColor = false;
            this.t_b_limpar.Click += new System.EventHandler(this.t_b_limpar_Click);
            // 
            // t_b_encriptar
            // 
            this.t_b_encriptar.BackColor = System.Drawing.Color.White;
            this.t_b_encriptar.Enabled = false;
            this.t_b_encriptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t_b_encriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_b_encriptar.Location = new System.Drawing.Point(363, 48);
            this.t_b_encriptar.Name = "t_b_encriptar";
            this.t_b_encriptar.Size = new System.Drawing.Size(134, 46);
            this.t_b_encriptar.TabIndex = 1;
            this.t_b_encriptar.Text = "Encriptar";
            this.t_b_encriptar.UseVisualStyleBackColor = false;
            this.t_b_encriptar.Click += new System.EventHandler(this.t_b_encriptar_Click);
            // 
            // t_b_lerFic
            // 
            this.t_b_lerFic.BackColor = System.Drawing.Color.White;
            this.t_b_lerFic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t_b_lerFic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_b_lerFic.Location = new System.Drawing.Point(80, 240);
            this.t_b_lerFic.Name = "t_b_lerFic";
            this.t_b_lerFic.Size = new System.Drawing.Size(118, 32);
            this.t_b_lerFic.TabIndex = 4;
            this.t_b_lerFic.Text = "Ler ficheiro";
            this.t_b_lerFic.UseVisualStyleBackColor = false;
            this.t_b_lerFic.Click += new System.EventHandler(this.t_b_lerFic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Ficheiros de texto (*.txt)|*.txt";
            this.openFileDialog1.Title = "Selecionar ficheiro";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // t_b_salvarFic
            // 
            this.t_b_salvarFic.BackColor = System.Drawing.Color.White;
            this.t_b_salvarFic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t_b_salvarFic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_b_salvarFic.Location = new System.Drawing.Point(656, 240);
            this.t_b_salvarFic.Name = "t_b_salvarFic";
            this.t_b_salvarFic.Size = new System.Drawing.Size(118, 32);
            this.t_b_salvarFic.TabIndex = 7;
            this.t_b_salvarFic.Text = "Guardar";
            this.t_b_salvarFic.UseVisualStyleBackColor = false;
            this.t_b_salvarFic.Click += new System.EventHandler(this.t_b_salvarFic_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "Nome_Ficheiro";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Salvar em ficheiro";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // t_b_copiar
            // 
            this.t_b_copiar.BackColor = System.Drawing.Color.White;
            this.t_b_copiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.t_b_copiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_b_copiar.Location = new System.Drawing.Point(520, 240);
            this.t_b_copiar.Name = "t_b_copiar";
            this.t_b_copiar.Size = new System.Drawing.Size(118, 32);
            this.t_b_copiar.TabIndex = 6;
            this.t_b_copiar.Text = "Copiar";
            this.t_b_copiar.UseVisualStyleBackColor = false;
            this.t_b_copiar.Click += new System.EventHandler(this.t_b_copiar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(216, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Colar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 457);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_b_copiar);
            this.Controls.Add(this.t_b_salvarFic);
            this.Controls.Add(this.t_b_lerFic);
            this.Controls.Add(this.t_b_encriptar);
            this.Controls.Add(this.t_b_limpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_l_cAlphabet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_t_imagem);
            this.Controls.Add(this.t_b_desencriptar);
            this.Controls.Add(this.t_t_convertido);
            this.Controls.Add(this.t_t_input);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConversionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox t_t_convertido;
        public System.Windows.Forms.TextBox t_t_input;
        public System.Windows.Forms.Label t_t_imagem;
        public System.Windows.Forms.Button t_b_desencriptar;
        public System.Windows.Forms.Label t_l_cAlphabet;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button t_b_limpar;
        public System.Windows.Forms.Button t_b_encriptar;
        public System.Windows.Forms.Button t_b_lerFic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Button t_b_salvarFic;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.Button t_b_copiar;
        public System.Windows.Forms.Button button1;
    }
}