namespace FrenteDeLoja.View.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.linkTrocar = new System.Windows.Forms.LinkLabel();
            this.linkEsqueci = new System.Windows.Forms.LinkLabel();
            this.lblHoraAgora = new System.Windows.Forms.Label();
            this.lblDataAgora = new System.Windows.Forms.Label();
            this.lblTextoHora = new System.Windows.Forms.Label();
            this.lblTextoData = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // linkTrocar
            // 
            this.linkTrocar.AutoSize = true;
            this.linkTrocar.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkTrocar.Location = new System.Drawing.Point(423, 122);
            this.linkTrocar.Name = "linkTrocar";
            this.linkTrocar.Size = new System.Drawing.Size(72, 13);
            this.linkTrocar.TabIndex = 29;
            this.linkTrocar.TabStop = true;
            this.linkTrocar.Text = "Trocar Senha";
            // 
            // linkEsqueci
            // 
            this.linkEsqueci.AutoSize = true;
            this.linkEsqueci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkEsqueci.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkEsqueci.Location = new System.Drawing.Point(285, 122);
            this.linkEsqueci.Name = "linkEsqueci";
            this.linkEsqueci.Size = new System.Drawing.Size(88, 13);
            this.linkEsqueci.TabIndex = 28;
            this.linkEsqueci.TabStop = true;
            this.linkEsqueci.Text = "Esqueci a Senha";
            this.linkEsqueci.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoraAgora
            // 
            this.lblHoraAgora.AutoSize = true;
            this.lblHoraAgora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHoraAgora.Location = new System.Drawing.Point(322, 213);
            this.lblHoraAgora.Name = "lblHoraAgora";
            this.lblHoraAgora.Size = new System.Drawing.Size(38, 13);
            this.lblHoraAgora.TabIndex = 27;
            this.lblHoraAgora.Text = "label4";
            // 
            // lblDataAgora
            // 
            this.lblDataAgora.AutoSize = true;
            this.lblDataAgora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAgora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDataAgora.Location = new System.Drawing.Point(322, 236);
            this.lblDataAgora.Name = "lblDataAgora";
            this.lblDataAgora.Size = new System.Drawing.Size(38, 13);
            this.lblDataAgora.TabIndex = 26;
            this.lblDataAgora.Text = "label3";
            // 
            // lblTextoHora
            // 
            this.lblTextoHora.AutoSize = true;
            this.lblTextoHora.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTextoHora.Location = new System.Drawing.Point(287, 213);
            this.lblTextoHora.Name = "lblTextoHora";
            this.lblTextoHora.Size = new System.Drawing.Size(35, 13);
            this.lblTextoHora.TabIndex = 25;
            this.lblTextoHora.Text = "Hora:";
            // 
            // lblTextoData
            // 
            this.lblTextoData.AutoSize = true;
            this.lblTextoData.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTextoData.Location = new System.Drawing.Point(287, 236);
            this.lblTextoData.Name = "lblTextoData";
            this.lblTextoData.Size = new System.Drawing.Size(37, 13);
            this.lblTextoData.TabIndex = 24;
            this.lblTextoData.Text = "Data: ";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(395, 78);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 17;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(395, 33);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 16;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSenha.Location = new System.Drawing.Point(321, 78);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(60, 20);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(321, 33);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "Usuário:";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FrenteDeLoja.Properties.Resources.Untitled_4;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(253, 224);
            this.picLogo.TabIndex = 30;
            this.picLogo.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSair.Image = global::FrenteDeLoja.Properties.Resources.x_mark_3_241;
            this.btnSair.Location = new System.Drawing.Point(426, 156);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 39);
            this.btnSair.TabIndex = 19;
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.Image = global::FrenteDeLoja.Properties.Resources.check_mark_8_24;
            this.btnLogin.Location = new System.Drawing.Point(298, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // picSenha
            // 
            this.picSenha.Image = global::FrenteDeLoja.Properties.Resources.padlock_24;
            this.picSenha.Location = new System.Drawing.Point(288, 70);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(27, 28);
            this.picSenha.TabIndex = 23;
            this.picSenha.TabStop = false;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = global::FrenteDeLoja.Properties.Resources.contacts_24;
            this.picUsuario.Location = new System.Drawing.Point(288, 25);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(27, 28);
            this.picUsuario.TabIndex = 22;
            this.picUsuario.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(523, 258);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.linkTrocar);
            this.Controls.Add(this.linkEsqueci);
            this.Controls.Add(this.lblHoraAgora);
            this.Controls.Add(this.lblDataAgora);
            this.Controls.Add(this.lblTextoHora);
            this.Controls.Add(this.lblTextoData);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picSenha);
            this.Controls.Add(this.picUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picLogo;
        public System.Windows.Forms.LinkLabel linkTrocar;
        public System.Windows.Forms.LinkLabel linkEsqueci;
        public System.Windows.Forms.Label lblHoraAgora;
        public System.Windows.Forms.Label lblDataAgora;
        public System.Windows.Forms.Label lblTextoHora;
        public System.Windows.Forms.Label lblTextoData;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.PictureBox picSenha;
        public System.Windows.Forms.PictureBox picUsuario;
        public System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.Label lblUsuario;
    }
}