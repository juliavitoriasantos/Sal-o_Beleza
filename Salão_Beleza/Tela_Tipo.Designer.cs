namespace Salão_Beleza
{
    partial class Tela_Tipo
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
            this.lblnome = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.cbbstatus = new System.Windows.Forms.ComboBox();
            this.txbnome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(108, 57);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(35, 13);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome";
            this.lblnome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(114, 57);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 1;
            this.lblstatus.Text = "Status";
            // 
            // cbbstatus
            // 
            this.cbbstatus.FormattingEnabled = true;
            this.cbbstatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbbstatus.Location = new System.Drawing.Point(74, 111);
            this.cbbstatus.Name = "cbbstatus";
            this.cbbstatus.Size = new System.Drawing.Size(121, 21);
            this.cbbstatus.TabIndex = 2;
            // 
            // txbnome
            // 
            this.txbnome.Location = new System.Drawing.Point(75, 112);
            this.txbnome.Name = "txbnome";
            this.txbnome.Size = new System.Drawing.Size(100, 20);
            this.txbnome.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblnome);
            this.panel1.Controls.Add(this.txbnome);
            this.panel1.Location = new System.Drawing.Point(133, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 209);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cbbstatus);
            this.panel2.Controls.Add(this.lblstatus);
            this.panel2.Location = new System.Drawing.Point(414, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 209);
            this.panel2.TabIndex = 5;
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncadastrar.Location = new System.Drawing.Point(347, 354);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(135, 36);
            this.btncadastrar.TabIndex = 6;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // Tela_Tipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Tela_Tipo";
            this.Text = "Tela_Tipo";
            this.Load += new System.EventHandler(this.Tela_Tipo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.ComboBox cbbstatus;
        private System.Windows.Forms.TextBox txbnome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncadastrar;
    }
}