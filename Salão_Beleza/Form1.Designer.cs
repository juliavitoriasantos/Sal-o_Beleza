namespace Salão_Beleza
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Cabelo = new System.Windows.Forms.ComboBox();
            this.Unhas = new System.Windows.Forms.ComboBox();
            this.Maquiagem = new System.Windows.Forms.ComboBox();
            this.Informações = new System.Windows.Forms.ComboBox();
            this.Cabelot = new System.Windows.Forms.Label();
            this.unhat = new System.Windows.Forms.Label();
            this.maquiagemt = new System.Windows.Forms.Label();
            this.sobret = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Cadastro = new System.Windows.Forms.Button();
            this.depilaçãot = new System.Windows.Forms.Label();
            this.Cíliost = new System.Windows.Forms.Label();
            this.sobrancelhat = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cabelo
            // 
            this.Cabelo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cabelo.ForeColor = System.Drawing.SystemColors.Window;
            this.Cabelo.FormattingEnabled = true;
            this.Cabelo.Items.AddRange(new object[] {
            "Corte",
            "Hidratação",
            "Progressiva",
            "Botox",
            "Penteado",
            "Coloração",
            "Nenhum"});
            this.Cabelo.Location = new System.Drawing.Point(3, 16);
            this.Cabelo.Name = "Cabelo";
            this.Cabelo.Size = new System.Drawing.Size(121, 21);
            this.Cabelo.TabIndex = 8;
            // 
            // Unhas
            // 
            this.Unhas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Unhas.ForeColor = System.Drawing.SystemColors.Window;
            this.Unhas.FormattingEnabled = true;
            this.Unhas.Items.AddRange(new object[] {
            "Unhas de Gel",
            "Com Desenhos",
            "Com Adesivos",
            "Francesinha",
            "Clássica",
            "Nenhum"});
            this.Unhas.Location = new System.Drawing.Point(3, 56);
            this.Unhas.Name = "Unhas";
            this.Unhas.Size = new System.Drawing.Size(121, 21);
            this.Unhas.TabIndex = 9;
            // 
            // Maquiagem
            // 
            this.Maquiagem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Maquiagem.ForeColor = System.Drawing.SystemColors.Window;
            this.Maquiagem.FormattingEnabled = true;
            this.Maquiagem.Items.AddRange(new object[] {
            "Natural",
            "Básica",
            "Glam",
            "Artística",
            "Nenhum"});
            this.Maquiagem.Location = new System.Drawing.Point(3, 96);
            this.Maquiagem.Name = "Maquiagem";
            this.Maquiagem.Size = new System.Drawing.Size(121, 21);
            this.Maquiagem.TabIndex = 10;
            // 
            // Informações
            // 
            this.Informações.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Informações.ForeColor = System.Drawing.SystemColors.Window;
            this.Informações.FormattingEnabled = true;
            this.Informações.Items.AddRange(new object[] {
            "Sobre o salão",
            "Telefone para contato"});
            this.Informações.Location = new System.Drawing.Point(3, 256);
            this.Informações.Name = "Informações";
            this.Informações.Size = new System.Drawing.Size(121, 21);
            this.Informações.TabIndex = 11;
            // 
            // Cabelot
            // 
            this.Cabelot.AutoSize = true;
            this.Cabelot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Cabelot.Location = new System.Drawing.Point(3, 0);
            this.Cabelot.Name = "Cabelot";
            this.Cabelot.Size = new System.Drawing.Size(136, 13);
            this.Cabelot.TabIndex = 19;
            this.Cabelot.Text = "Cabelo                                ";
            // 
            // unhat
            // 
            this.unhat.AutoSize = true;
            this.unhat.Location = new System.Drawing.Point(3, 40);
            this.unhat.Name = "unhat";
            this.unhat.Size = new System.Drawing.Size(128, 13);
            this.unhat.TabIndex = 20;
            this.unhat.Text = "Unhas                              ";
            // 
            // maquiagemt
            // 
            this.maquiagemt.AutoSize = true;
            this.maquiagemt.Location = new System.Drawing.Point(3, 80);
            this.maquiagemt.Name = "maquiagemt";
            this.maquiagemt.Size = new System.Drawing.Size(134, 13);
            this.maquiagemt.TabIndex = 21;
            this.maquiagemt.Text = "Maquiagem                        ";
            // 
            // sobret
            // 
            this.sobret.AutoSize = true;
            this.sobret.Location = new System.Drawing.Point(3, 240);
            this.sobret.Name = "sobret";
            this.sobret.Size = new System.Drawing.Size(89, 13);
            this.sobret.TabIndex = 22;
            this.sobret.Text = "Mais informações";
            // 
            // Cadastro
            // 
            this.Cadastro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cadastro.Location = new System.Drawing.Point(335, 212);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Size = new System.Drawing.Size(156, 47);
            this.Cadastro.TabIndex = 23;
            this.Cadastro.Text = "PAGAR";
            this.Cadastro.UseVisualStyleBackColor = false;
            // 
            // depilaçãot
            // 
            this.depilaçãot.AutoSize = true;
            this.depilaçãot.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.depilaçãot.Location = new System.Drawing.Point(3, 120);
            this.depilaçãot.Name = "depilaçãot";
            this.depilaçãot.Size = new System.Drawing.Size(86, 13);
            this.depilaçãot.TabIndex = 24;
            this.depilaçãot.Text = "Depilação Facial";
            this.depilaçãot.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Cíliost
            // 
            this.Cíliost.AutoSize = true;
            this.Cíliost.Location = new System.Drawing.Point(3, 160);
            this.Cíliost.Name = "Cíliost";
            this.Cíliost.Size = new System.Drawing.Size(135, 13);
            this.Cíliost.TabIndex = 25;
            this.Cíliost.Text = "Cílios                                  ";
            // 
            // sobrancelhat
            // 
            this.sobrancelhat.AutoSize = true;
            this.sobrancelhat.Location = new System.Drawing.Point(3, 200);
            this.sobrancelhat.Name = "sobrancelhat";
            this.sobrancelhat.Size = new System.Drawing.Size(72, 13);
            this.sobrancelhat.TabIndex = 26;
            this.sobrancelhat.Text = "Sobrancelhas";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buço",
            "Queixo",
            "Sobrancelhas",
            "Laterais do Rosto"});
            this.comboBox1.Location = new System.Drawing.Point(3, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Extensão",
            "Alongamento"});
            this.comboBox2.Location = new System.Drawing.Point(3, 176);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 28;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.comboBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Design de sobrancelha",
            "Design com henna",
            "Maquiagem definitiva",
            "Micropigmentação",
            "Coloração"});
            this.comboBox3.Location = new System.Drawing.Point(3, 216);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 29;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Cabelot);
            this.flowLayoutPanel1.Controls.Add(this.Cabelo);
            this.flowLayoutPanel1.Controls.Add(this.unhat);
            this.flowLayoutPanel1.Controls.Add(this.Unhas);
            this.flowLayoutPanel1.Controls.Add(this.maquiagemt);
            this.flowLayoutPanel1.Controls.Add(this.Maquiagem);
            this.flowLayoutPanel1.Controls.Add(this.depilaçãot);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Controls.Add(this.Cíliost);
            this.flowLayoutPanel1.Controls.Add(this.comboBox2);
            this.flowLayoutPanel1.Controls.Add(this.sobrancelhat);
            this.flowLayoutPanel1.Controls.Add(this.comboBox3);
            this.flowLayoutPanel1.Controls.Add(this.sobret);
            this.flowLayoutPanel1.Controls.Add(this.Informações);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(544, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(145, 284);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.textBox4);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.textBox6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(128, 172);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 122);
            this.flowLayoutPanel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Digite seu nome completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Digite seu número de telefone:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Digite seu e-mail:           ";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 94);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Cadastro);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox Cabelo;
        private System.Windows.Forms.ComboBox Unhas;
        private System.Windows.Forms.ComboBox Maquiagem;
        private System.Windows.Forms.ComboBox Informações;
        private System.Windows.Forms.Label Cabelot;
        private System.Windows.Forms.Label unhat;
        private System.Windows.Forms.Label maquiagemt;
        private System.Windows.Forms.Label sobret;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Cadastro;
        private System.Windows.Forms.Label depilaçãot;
        private System.Windows.Forms.Label Cíliost;
        private System.Windows.Forms.Label sobrancelhat;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}

