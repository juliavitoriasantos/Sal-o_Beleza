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
            this.cbx_cabelo = new System.Windows.Forms.ComboBox();
            this.cbx_unhas = new System.Windows.Forms.ComboBox();
            this.cbx_maquiagem = new System.Windows.Forms.ComboBox();
            this.lbl_cabelo = new System.Windows.Forms.Label();
            this.lbl_unha = new System.Windows.Forms.Label();
            this.lbl_maquiagem = new System.Windows.Forms.Label();
            this.lbl_informaoes = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.lbl_depilação = new System.Windows.Forms.Label();
            this.lbl_cilios = new System.Windows.Forms.Label();
            this.lbl_sobrancelha = new System.Windows.Forms.Label();
            this.cbx_depilacao = new System.Windows.Forms.ComboBox();
            this.cbx_cilios = new System.Windows.Forms.ComboBox();
            this.cbx_sobrancelha = new System.Windows.Forms.ComboBox();
            this.pnl_escolhas = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_informaacoes = new System.Windows.Forms.Label();
            this.lbl_informacoes2 = new System.Windows.Forms.Label();
            this.pnl_cadastro = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txb_numero = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.pnl_escolhas.SuspendLayout();
            this.pnl_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_cabelo
            // 
            this.cbx_cabelo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_cabelo.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_cabelo.FormattingEnabled = true;
            this.cbx_cabelo.Items.AddRange(new object[] {
            "Corte-R$35,00",
            "Hidratação-R$90,00",
            "Progressiva-R$200,00",
            "Botox-R$100,00",
            "Penteado-R$250,00",
            "Luzes-R$300,00",
            "Coloração-R$60,00",
            "Nenhum"});
            this.cbx_cabelo.Location = new System.Drawing.Point(3, 16);
            this.cbx_cabelo.Name = "cbx_cabelo";
            this.cbx_cabelo.Size = new System.Drawing.Size(121, 21);
            this.cbx_cabelo.TabIndex = 8;
            // 
            // cbx_unhas
            // 
            this.cbx_unhas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_unhas.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_unhas.FormattingEnabled = true;
            this.cbx_unhas.Items.AddRange(new object[] {
            "Unhas de Gel-R$130,00",
            "Com Desenhos-R$120,00",
            "Com Adesivos-R$20,00",
            "Francesinha-R$30,00",
            "Clássica-R$45,00",
            "Nenhum"});
            this.cbx_unhas.Location = new System.Drawing.Point(3, 56);
            this.cbx_unhas.Name = "cbx_unhas";
            this.cbx_unhas.Size = new System.Drawing.Size(121, 21);
            this.cbx_unhas.TabIndex = 9;
            // 
            // cbx_maquiagem
            // 
            this.cbx_maquiagem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_maquiagem.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_maquiagem.FormattingEnabled = true;
            this.cbx_maquiagem.Items.AddRange(new object[] {
            "Natural-R$100,00",
            "Básica-R$100,00",
            "Glam-R$250,00",
            "Artística-R$300,00",
            "Nenhum"});
            this.cbx_maquiagem.Location = new System.Drawing.Point(3, 96);
            this.cbx_maquiagem.Name = "cbx_maquiagem";
            this.cbx_maquiagem.Size = new System.Drawing.Size(121, 21);
            this.cbx_maquiagem.TabIndex = 10;
            // 
            // lbl_cabelo
            // 
            this.lbl_cabelo.AutoSize = true;
            this.lbl_cabelo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_cabelo.Location = new System.Drawing.Point(3, 0);
            this.lbl_cabelo.Name = "lbl_cabelo";
            this.lbl_cabelo.Size = new System.Drawing.Size(136, 13);
            this.lbl_cabelo.TabIndex = 19;
            this.lbl_cabelo.Text = "Cabelo                                ";
            // 
            // lbl_unha
            // 
            this.lbl_unha.AutoSize = true;
            this.lbl_unha.Location = new System.Drawing.Point(3, 40);
            this.lbl_unha.Name = "lbl_unha";
            this.lbl_unha.Size = new System.Drawing.Size(128, 13);
            this.lbl_unha.TabIndex = 20;
            this.lbl_unha.Text = "Unhas                              ";
            // 
            // lbl_maquiagem
            // 
            this.lbl_maquiagem.AutoSize = true;
            this.lbl_maquiagem.Location = new System.Drawing.Point(3, 80);
            this.lbl_maquiagem.Name = "lbl_maquiagem";
            this.lbl_maquiagem.Size = new System.Drawing.Size(134, 13);
            this.lbl_maquiagem.TabIndex = 21;
            this.lbl_maquiagem.Text = "Maquiagem                        ";
            // 
            // lbl_informaoes
            // 
            this.lbl_informaoes.AutoSize = true;
            this.lbl_informaoes.Location = new System.Drawing.Point(3, 240);
            this.lbl_informaoes.Name = "lbl_informaoes";
            this.lbl_informaoes.Size = new System.Drawing.Size(191, 26);
            this.lbl_informaoes.TabIndex = 22;
            this.lbl_informaoes.Text = "Mais informações:                                                             ";
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_pagar.Location = new System.Drawing.Point(863, 429);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(156, 47);
            this.btn_pagar.TabIndex = 23;
            this.btn_pagar.Text = "PAGAR";
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click_1);
            // 
            // lbl_depilação
            // 
            this.lbl_depilação.AutoSize = true;
            this.lbl_depilação.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_depilação.Location = new System.Drawing.Point(3, 120);
            this.lbl_depilação.Name = "lbl_depilação";
            this.lbl_depilação.Size = new System.Drawing.Size(86, 13);
            this.lbl_depilação.TabIndex = 24;
            this.lbl_depilação.Text = "Depilação Facial";
            this.lbl_depilação.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_cilios
            // 
            this.lbl_cilios.AutoSize = true;
            this.lbl_cilios.Location = new System.Drawing.Point(3, 160);
            this.lbl_cilios.Name = "lbl_cilios";
            this.lbl_cilios.Size = new System.Drawing.Size(135, 13);
            this.lbl_cilios.TabIndex = 25;
            this.lbl_cilios.Text = "Cílios                                  ";
            this.lbl_cilios.Click += new System.EventHandler(this.Cíliost_Click);
            // 
            // lbl_sobrancelha
            // 
            this.lbl_sobrancelha.AutoSize = true;
            this.lbl_sobrancelha.Location = new System.Drawing.Point(3, 200);
            this.lbl_sobrancelha.Name = "lbl_sobrancelha";
            this.lbl_sobrancelha.Size = new System.Drawing.Size(72, 13);
            this.lbl_sobrancelha.TabIndex = 26;
            this.lbl_sobrancelha.Text = "Sobrancelhas";
            // 
            // cbx_depilacao
            // 
            this.cbx_depilacao.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_depilacao.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_depilacao.FormattingEnabled = true;
            this.cbx_depilacao.Items.AddRange(new object[] {
            "Buço-R$15,00",
            "Queixo-R$15,00",
            "Laterais do Rosto-R$20,00",
            "Nenhum"});
            this.cbx_depilacao.Location = new System.Drawing.Point(3, 136);
            this.cbx_depilacao.Name = "cbx_depilacao";
            this.cbx_depilacao.Size = new System.Drawing.Size(121, 21);
            this.cbx_depilacao.TabIndex = 27;
            // 
            // cbx_cilios
            // 
            this.cbx_cilios.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_cilios.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_cilios.FormattingEnabled = true;
            this.cbx_cilios.Items.AddRange(new object[] {
            "Extensão-R$250,00",
            "Alongamento-R$300,00",
            "Nenhum"});
            this.cbx_cilios.Location = new System.Drawing.Point(3, 176);
            this.cbx_cilios.Name = "cbx_cilios";
            this.cbx_cilios.Size = new System.Drawing.Size(121, 21);
            this.cbx_cilios.TabIndex = 28;
            // 
            // cbx_sobrancelha
            // 
            this.cbx_sobrancelha.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_sobrancelha.ForeColor = System.Drawing.SystemColors.Window;
            this.cbx_sobrancelha.FormattingEnabled = true;
            this.cbx_sobrancelha.Items.AddRange(new object[] {
            "Design de sobrancelha-R$30",
            "Design com henna-R$200",
            "Maquiagem definitiva-R$550,00",
            "Micropigmentação-R$500,00",
            "Coloração-R$50,00",
            "Nenhum"});
            this.cbx_sobrancelha.Location = new System.Drawing.Point(3, 216);
            this.cbx_sobrancelha.Name = "cbx_sobrancelha";
            this.cbx_sobrancelha.Size = new System.Drawing.Size(121, 21);
            this.cbx_sobrancelha.TabIndex = 29;
            // 
            // pnl_escolhas
            // 
            this.pnl_escolhas.Controls.Add(this.lbl_cabelo);
            this.pnl_escolhas.Controls.Add(this.cbx_cabelo);
            this.pnl_escolhas.Controls.Add(this.lbl_unha);
            this.pnl_escolhas.Controls.Add(this.cbx_unhas);
            this.pnl_escolhas.Controls.Add(this.lbl_maquiagem);
            this.pnl_escolhas.Controls.Add(this.cbx_maquiagem);
            this.pnl_escolhas.Controls.Add(this.lbl_depilação);
            this.pnl_escolhas.Controls.Add(this.cbx_depilacao);
            this.pnl_escolhas.Controls.Add(this.lbl_cilios);
            this.pnl_escolhas.Controls.Add(this.cbx_cilios);
            this.pnl_escolhas.Controls.Add(this.lbl_sobrancelha);
            this.pnl_escolhas.Controls.Add(this.cbx_sobrancelha);
            this.pnl_escolhas.Controls.Add(this.lbl_informaoes);
            this.pnl_escolhas.Controls.Add(this.lbl_informaacoes);
            this.pnl_escolhas.Controls.Add(this.lbl_informacoes2);
            this.pnl_escolhas.Location = new System.Drawing.Point(1190, 296);
            this.pnl_escolhas.Name = "pnl_escolhas";
            this.pnl_escolhas.Size = new System.Drawing.Size(199, 308);
            this.pnl_escolhas.TabIndex = 30;
            // 
            // lbl_informaacoes
            // 
            this.lbl_informaacoes.AutoSize = true;
            this.lbl_informaacoes.Location = new System.Drawing.Point(3, 266);
            this.lbl_informaacoes.Name = "lbl_informaacoes";
            this.lbl_informaacoes.Size = new System.Drawing.Size(193, 13);
            this.lbl_informaacoes.TabIndex = 30;
            this.lbl_informaacoes.Text = "Telefone para contato: (12) 997872016";
            this.lbl_informaacoes.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lbl_informacoes2
            // 
            this.lbl_informacoes2.AutoSize = true;
            this.lbl_informacoes2.Location = new System.Drawing.Point(3, 279);
            this.lbl_informacoes2.Name = "lbl_informacoes2";
            this.lbl_informacoes2.Size = new System.Drawing.Size(132, 13);
            this.lbl_informacoes2.TabIndex = 31;
            this.lbl_informacoes2.Text = "E-mail: vitoria.j@gmail.com";
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Controls.Add(this.lbl_nome);
            this.pnl_cadastro.Controls.Add(this.txb_nome);
            this.pnl_cadastro.Controls.Add(this.lbl_numero);
            this.pnl_cadastro.Controls.Add(this.txb_numero);
            this.pnl_cadastro.Controls.Add(this.lbl_email);
            this.pnl_cadastro.Controls.Add(this.txb_email);
            this.pnl_cadastro.Location = new System.Drawing.Point(537, 389);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(163, 122);
            this.pnl_cadastro.TabIndex = 31;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_nome.Location = new System.Drawing.Point(3, 0);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(132, 13);
            this.lbl_nome.TabIndex = 19;
            this.lbl_nome.Text = "Digite seu nome completo:";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(3, 16);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(100, 20);
            this.txb_nome.TabIndex = 29;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(3, 39);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(151, 13);
            this.lbl_numero.TabIndex = 21;
            this.lbl_numero.Text = "Digite seu número de telefone:";
            // 
            // txb_numero
            // 
            this.txb_numero.Location = new System.Drawing.Point(3, 55);
            this.txb_numero.Name = "txb_numero";
            this.txb_numero.Size = new System.Drawing.Size(100, 20);
            this.txb_numero.TabIndex = 34;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbl_email.Location = new System.Drawing.Point(3, 78);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(120, 13);
            this.lbl_email.TabIndex = 36;
            this.lbl_email.Text = "Digite seu e-mail:           ";
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(3, 94);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(100, 20);
            this.txb_email.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.pnl_escolhas);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.pnl_cadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_escolhas.ResumeLayout(false);
            this.pnl_escolhas.PerformLayout();
            this.pnl_cadastro.ResumeLayout(false);
            this.pnl_cadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbx_cabelo;
        private System.Windows.Forms.ComboBox cbx_unhas;
        private System.Windows.Forms.ComboBox cbx_maquiagem;
        private System.Windows.Forms.Label lbl_cabelo;
        private System.Windows.Forms.Label lbl_unha;
        private System.Windows.Forms.Label lbl_maquiagem;
        private System.Windows.Forms.Label lbl_informaoes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label lbl_depilação;
        private System.Windows.Forms.Label lbl_cilios;
        private System.Windows.Forms.Label lbl_sobrancelha;
        private System.Windows.Forms.ComboBox cbx_depilacao;
        private System.Windows.Forms.ComboBox cbx_cilios;
        private System.Windows.Forms.ComboBox cbx_sobrancelha;
        private System.Windows.Forms.FlowLayoutPanel pnl_escolhas;
        private System.Windows.Forms.FlowLayoutPanel pnl_cadastro;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_numero;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label lbl_informaacoes;
        private System.Windows.Forms.Label lbl_informacoes2;
    }
}

