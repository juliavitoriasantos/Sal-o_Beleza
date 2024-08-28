namespace Salão_Beleza
{
    partial class Tela_login
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
            this.pnllog = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.lboLog = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pnllog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnllog
            // 
            this.pnllog.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnllog.Controls.Add(this.btnEntrar);
            this.pnllog.Controls.Add(this.lboLog);
            this.pnllog.Controls.Add(this.txbSenha);
            this.pnllog.Controls.Add(this.txbUser);
            this.pnllog.Controls.Add(this.lblSenha);
            this.pnllog.Controls.Add(this.lblUser);
            this.pnllog.Location = new System.Drawing.Point(278, 12);
            this.pnllog.Name = "pnllog";
            this.pnllog.Size = new System.Drawing.Size(223, 403);
            this.pnllog.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUser.Location = new System.Drawing.Point(39, 157);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(141, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Digite seu nome de usuário: ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(39, 246);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Digite sua senha: ";
            this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(42, 188);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(144, 20);
            this.txbUser.TabIndex = 2;
            this.txbUser.TextChanged += new System.EventHandler(this.txbUser_TextChanged);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(42, 287);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(144, 20);
            this.txbSenha.TabIndex = 3;
            // 
            // lboLog
            // 
            this.lboLog.AutoSize = true;
            this.lboLog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lboLog.Location = new System.Drawing.Point(91, 70);
            this.lboLog.Name = "lboLog";
            this.lboLog.Size = new System.Drawing.Size(40, 13);
            this.lboLog.TabIndex = 4;
            this.lboLog.Text = "LOGIN";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEntrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEntrar.Location = new System.Drawing.Point(60, 328);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(109, 46);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // Tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnllog);
            this.Name = "Tela_login";
            this.Text = "Tela_login";
            this.TransparencyKey = System.Drawing.Color.MediumBlue;
            this.pnllog.ResumeLayout(false);
            this.pnllog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnllog;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label lboLog;
        private System.Windows.Forms.Button btnEntrar;
    }
}