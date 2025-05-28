namespace EncrypTool
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_iniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_sair
            // 
            this.b_sair.BackColor = System.Drawing.Color.White;
            this.b_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sair.Location = new System.Drawing.Point(292, 288);
            this.b_sair.Name = "b_sair";
            this.b_sair.Size = new System.Drawing.Size(277, 53);
            this.b_sair.TabIndex = 1;
            this.b_sair.Text = "Sair";
            this.b_sair.UseVisualStyleBackColor = false;
            this.b_sair.Click += new System.EventHandler(this.b_sair_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 67);
            this.label1.TabIndex = 3;
            this.label1.Text = "EncrypTool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Programa criado por: João Madeira e Leonor Rodrigues";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_iniciar
            // 
            this.b_iniciar.BackColor = System.Drawing.Color.White;
            this.b_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_iniciar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.b_iniciar.Location = new System.Drawing.Point(292, 224);
            this.b_iniciar.Name = "b_iniciar";
            this.b_iniciar.Size = new System.Drawing.Size(277, 53);
            this.b_iniciar.TabIndex = 0;
            this.b_iniciar.Text = "Iniciar";
            this.b_iniciar.UseVisualStyleBackColor = false;
            this.b_iniciar.Click += new System.EventHandler(this.b_iniciar_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 457);
            this.ControlBox = false;
            this.Controls.Add(this.b_iniciar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button b_iniciar;
    }
}

