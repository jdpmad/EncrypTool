
namespace EncrypTool
{
    partial class CipherSelectionForm
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
            this.c_l_cifras = new System.Windows.Forms.ListBox();
            this.c_l_instrucao = new System.Windows.Forms.Label();
            this.c_b_confirmar = new System.Windows.Forms.Button();
            this.c_l_descricao1 = new System.Windows.Forms.Label();
            this.c_l_imagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_l_cifras
            // 
            this.c_l_cifras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_l_cifras.FormattingEnabled = true;
            this.c_l_cifras.ItemHeight = 25;
            this.c_l_cifras.Items.AddRange(new object[] {
            "    Cifra de César",
            "      Código Tap",
            "    Código Morse"});
            this.c_l_cifras.Location = new System.Drawing.Point(336, 96);
            this.c_l_cifras.Name = "c_l_cifras";
            this.c_l_cifras.Size = new System.Drawing.Size(189, 79);
            this.c_l_cifras.TabIndex = 0;
            this.c_l_cifras.SelectedIndexChanged += new System.EventHandler(this.c_l_cifras_SelectedIndexChanged);
            // 
            // c_l_instrucao
            // 
            this.c_l_instrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_l_instrucao.Location = new System.Drawing.Point(346, 64);
            this.c_l_instrucao.Name = "c_l_instrucao";
            this.c_l_instrucao.Size = new System.Drawing.Size(168, 23);
            this.c_l_instrucao.TabIndex = 11;
            this.c_l_instrucao.Text = "Escolhe a tua cifra:";
            this.c_l_instrucao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c_b_confirmar
            // 
            this.c_b_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_b_confirmar.BackColor = System.Drawing.Color.White;
            this.c_b_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.c_b_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_b_confirmar.ForeColor = System.Drawing.Color.Green;
            this.c_b_confirmar.Location = new System.Drawing.Point(365, 376);
            this.c_b_confirmar.Name = "c_b_confirmar";
            this.c_b_confirmar.Size = new System.Drawing.Size(131, 40);
            this.c_b_confirmar.TabIndex = 1;
            this.c_b_confirmar.Text = "Confirmar";
            this.c_b_confirmar.UseVisualStyleBackColor = false;
            this.c_b_confirmar.Click += new System.EventHandler(this.c_b_confirmar_Click);
            // 
            // c_l_descricao1
            // 
            this.c_l_descricao1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_l_descricao1.AutoSize = true;
            this.c_l_descricao1.BackColor = System.Drawing.Color.White;
            this.c_l_descricao1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_l_descricao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_l_descricao1.Location = new System.Drawing.Point(457, 248);
            this.c_l_descricao1.MaximumSize = new System.Drawing.Size(305, 126);
            this.c_l_descricao1.Name = "c_l_descricao1";
            this.c_l_descricao1.Size = new System.Drawing.Size(56, 22);
            this.c_l_descricao1.TabIndex = 14;
            this.c_l_descricao1.Text = "desc1";
            this.c_l_descricao1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c_l_imagem
            // 
            this.c_l_imagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c_l_imagem.BackColor = System.Drawing.Color.Transparent;
            this.c_l_imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c_l_imagem.Image = global::EncrypTool.Properties.Resources.caesar_cipher;
            this.c_l_imagem.Location = new System.Drawing.Point(56, 203);
            this.c_l_imagem.Name = "c_l_imagem";
            this.c_l_imagem.Size = new System.Drawing.Size(345, 146);
            this.c_l_imagem.TabIndex = 12;
            // 
            // CipherSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(860, 457);
            this.ControlBox = false;
            this.Controls.Add(this.c_l_descricao1);
            this.Controls.Add(this.c_b_confirmar);
            this.Controls.Add(this.c_l_imagem);
            this.Controls.Add(this.c_l_instrucao);
            this.Controls.Add(this.c_l_cifras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CipherSelectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Cifras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label c_l_instrucao;
        private System.Windows.Forms.Label c_l_imagem;
        private System.Windows.Forms.Button c_b_confirmar;
        private System.Windows.Forms.Label c_l_descricao1;
        public System.Windows.Forms.ListBox c_l_cifras;
    }
}