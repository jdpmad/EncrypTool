
namespace EncrypTool
{
    partial class LayoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayoutForm));
            this.l_b_voltar = new System.Windows.Forms.Button();
            this.L_b_casa = new System.Windows.Forms.Button();
            this.l_b_som = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_b_voltar
            // 
            this.l_b_voltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_b_voltar.BackColor = System.Drawing.SystemColors.Control;
            this.l_b_voltar.Enabled = false;
            this.l_b_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_b_voltar.Image = global::EncrypTool.Properties.Resources.arrow_2;
            this.l_b_voltar.Location = new System.Drawing.Point(8, 408);
            this.l_b_voltar.Name = "l_b_voltar";
            this.l_b_voltar.Size = new System.Drawing.Size(47, 48);
            this.l_b_voltar.TabIndex = 51;
            this.l_b_voltar.TabStop = false;
            this.l_b_voltar.Text = "\r\n";
            this.l_b_voltar.UseVisualStyleBackColor = false;
            this.l_b_voltar.Click += new System.EventHandler(this.l_b_voltar_Click);
            // 
            // L_b_casa
            // 
            this.L_b_casa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_b_casa.BackColor = System.Drawing.SystemColors.Control;
            this.L_b_casa.Enabled = false;
            this.L_b_casa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.L_b_casa.Image = global::EncrypTool.Properties.Resources.button_home;
            this.L_b_casa.Location = new System.Drawing.Point(808, 408);
            this.L_b_casa.Name = "L_b_casa";
            this.L_b_casa.Size = new System.Drawing.Size(47, 48);
            this.L_b_casa.TabIndex = 50;
            this.L_b_casa.TabStop = false;
            this.L_b_casa.Text = "\r\n";
            this.L_b_casa.UseVisualStyleBackColor = false;
            this.L_b_casa.Click += new System.EventHandler(this.c_b_casa_Click);
            // 
            // l_b_som
            // 
            this.l_b_som.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_b_som.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.l_b_som.BackColor = System.Drawing.SystemColors.Control;
            this.l_b_som.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_b_som.Image = global::EncrypTool.Properties.Resources.button_unmute;
            this.l_b_som.Location = new System.Drawing.Point(808, 8);
            this.l_b_som.Name = "l_b_som";
            this.l_b_som.Size = new System.Drawing.Size(47, 48);
            this.l_b_som.TabIndex = 52;
            this.l_b_som.TabStop = false;
            this.l_b_som.Text = "\r\n";
            this.l_b_som.UseVisualStyleBackColor = false;
            this.l_b_som.Click += new System.EventHandler(this.b_som_Click);
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.l_b_voltar);
            this.Controls.Add(this.L_b_casa);
            this.Controls.Add(this.l_b_som);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "LayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encriptador e Desencriptador";
            this.Load += new System.EventHandler(this.LayoutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button l_b_som;
        public System.Windows.Forms.Button L_b_casa;
        public System.Windows.Forms.Button l_b_voltar;
    }
}