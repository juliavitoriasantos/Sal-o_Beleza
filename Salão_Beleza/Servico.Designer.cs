namespace Salão_Beleza
{
    partial class Servico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnsalvar);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblpreco);
            this.panel1.Controls.Add(this.lbldescricao);
            this.panel1.Controls.Add(this.lbltipo);
            this.panel1.Location = new System.Drawing.Point(471, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 170);
            this.panel1.TabIndex = 0;
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(180, 135);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 6;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Corte",
            "Hidratação",
            "Progressiva",
            "Botox",
            "Penteado",
            "Luzes",
            "Coloração",
            "Nenhum",
            "Unhas de Gel",
            "Com Desenhos",
            "Com Adesivos",
            "Francesinha",
            "Clássica",
            "Natural",
            "Básica",
            "Glam",
            "Artística",
            "Buço",
            "Queixo",
            "Laterais do Rosto",
            "Extensão",
            "Alongamento",
            "Design de sobrancelha",
            "Design com henna",
            "Maquiagem definitiva",
            "Micropigmentação",
            "Coloração"});
            this.comboBox3.Location = new System.Drawing.Point(109, 58);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "35,00",
            "90,00",
            "200,00",
            "100,00",
            "250,00",
            "300,00",
            "60,00",
            "130,00",
            "120,00",
            "20,00",
            "30,00",
            "45,00",
            "100,00",
            "100,00",
            "250,00",
            "300,00",
            "15,00",
            "15,00",
            "20,00",
            "250,00",
            "300,00",
            "30",
            "200",
            "550,00",
            "500,00",
            "50,00"});
            this.comboBox2.Location = new System.Drawing.Point(109, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cabelo",
            "Unhas",
            "Mauiagem",
            "Depilação Facial",
            "Cílios",
            "Sobrancelhas"});
            this.comboBox1.Location = new System.Drawing.Point(109, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.UseWaitCursor = true;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(31, 94);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(35, 13);
            this.lblpreco.TabIndex = 2;
            this.lblpreco.Text = "Preço";
            this.lblpreco.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(31, 61);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(55, 13);
            this.lbldescricao.TabIndex = 1;
            this.lbldescricao.Text = "Descrição";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbltipo.Location = new System.Drawing.Point(31, 24);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(28, 13);
            this.lbltipo.TabIndex = 0;
            this.lbltipo.Text = "Tipo";
            this.lbltipo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Servico";
            this.Text = "Servico";
            this.Load += new System.EventHandler(this.Servico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Button btnsalvar;
    }
}