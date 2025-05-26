
namespace EncrypTool
{
    partial class CaesarShiftForm
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
            this.c_b_confirmar = new System.Windows.Forms.Button();
            this.c_l_cAlphabet = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_n_rotacao = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c_n_rotacao)).BeginInit();
            this.SuspendLayout();
            // 
            // c_b_confirmar
            // 
            this.c_b_confirmar.BackColor = System.Drawing.Color.White;
            this.c_b_confirmar.Enabled = false;
            this.c_b_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_b_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_b_confirmar.ForeColor = System.Drawing.Color.Green;
            this.c_b_confirmar.Location = new System.Drawing.Point(382, 336);
            this.c_b_confirmar.Name = "c_b_confirmar";
            this.c_b_confirmar.Size = new System.Drawing.Size(97, 36);
            this.c_b_confirmar.TabIndex = 1;
            this.c_b_confirmar.Text = "Confirmar";
            this.c_b_confirmar.UseVisualStyleBackColor = false;
            this.c_b_confirmar.Click += new System.EventHandler(this.c_b_confirmar_Click);
            // 
            // c_l_cAlphabet
            // 
            this.c_l_cAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_l_cAlphabet.Location = new System.Drawing.Point(194, 288);
            this.c_l_cAlphabet.Name = "c_l_cAlphabet";
            this.c_l_cAlphabet.Size = new System.Drawing.Size(472, 23);
            this.c_l_cAlphabet.TabIndex = 9;
            this.c_l_cAlphabet.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
            // 
            // c_n_rotacao
            // 
            this.c_n_rotacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_n_rotacao.Location = new System.Drawing.Point(365, 128);
            this.c_n_rotacao.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.c_n_rotacao.Name = "c_n_rotacao";
            this.c_n_rotacao.Size = new System.Drawing.Size(131, 27);
            this.c_n_rotacao.TabIndex = 0;
            this.c_n_rotacao.ValueChanged += new System.EventHandler(this.t_n_rotacao_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Escolhe o número de rotações do alfabeto:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Image = global::EncrypTool.Properties.Resources.arrow;
            this.label4.Location = new System.Drawing.Point(380, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 56);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = global::EncrypTool.Properties.Resources.arrow;
            this.label3.Location = new System.Drawing.Point(496, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 56);
            this.label3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Image = global::EncrypTool.Properties.Resources.arrow;
            this.label5.Location = new System.Drawing.Point(264, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 56);
            this.label5.TabIndex = 13;
            // 
            // CésarAlfabeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 457);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_b_confirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.c_l_cAlphabet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.c_n_rotacao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaesarShiftForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.c_n_rotacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button c_b_confirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown c_n_rotacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label c_l_cAlphabet;
    }
}