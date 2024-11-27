namespace Salão_Beleza
{
    partial class Tela_Cadastro
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
            this.components = new System.ComponentModel.Container();
            this.txbCad = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txbCadCode = new System.Windows.Forms.TextBox();
            this.txbTelefone = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.tblCad = new System.Windows.Forms.Label();
            this.lalCadCod = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCad
            // 
            this.txbCad.Location = new System.Drawing.Point(142, 32);
            this.txbCad.Name = "txbCad";
            this.txbCad.Size = new System.Drawing.Size(248, 20);
            this.txbCad.TabIndex = 0;
            this.txbCad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txbCadCode
            // 
            this.txbCadCode.Location = new System.Drawing.Point(142, 100);
            this.txbCadCode.Name = "txbCadCode";
            this.txbCadCode.Size = new System.Drawing.Size(248, 20);
            this.txbCadCode.TabIndex = 2;
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(142, 161);
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(248, 20);
            this.txbTelefone.TabIndex = 3;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(142, 224);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(248, 20);
            this.txbEmail.TabIndex = 4;
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(142, 293);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(248, 20);
            this.txbPassword.TabIndex = 5;
            // 
            // tblCad
            // 
            this.tblCad.AutoSize = true;
            this.tblCad.Location = new System.Drawing.Point(74, 35);
            this.tblCad.Name = "tblCad";
            this.tblCad.Size = new System.Drawing.Size(35, 13);
            this.tblCad.TabIndex = 6;
            this.tblCad.Text = "Nome";
            this.tblCad.Click += new System.EventHandler(this.label1_Click);
            // 
            // lalCadCod
            // 
            this.lalCadCod.AutoSize = true;
            this.lalCadCod.Location = new System.Drawing.Point(73, 100);
            this.lalCadCod.Name = "lalCadCod";
            this.lalCadCod.Size = new System.Drawing.Size(40, 13);
            this.lalCadCod.TabIndex = 7;
            this.lalCadCod.Text = "Código";
            this.lalCadCod.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(74, 168);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(73, 231);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(74, 296);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(500, 81);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(500, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lalCadCod);
            this.Controls.Add(this.tblCad);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbTelefone);
            this.Controls.Add(this.txbCadCode);
            this.Controls.Add(this.txbCad);
            this.Name = "Tela_Cadastro";
            this.Text = "Tela_Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCad;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txbCadCode;
        private System.Windows.Forms.TextBox txbTelefone;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label tblCad;
        private System.Windows.Forms.Label lalCadCod;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
    }
}