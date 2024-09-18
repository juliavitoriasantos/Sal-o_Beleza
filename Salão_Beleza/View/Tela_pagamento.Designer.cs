namespace Salão_Beleza
{
    partial class Tela_pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_pagamento));
            this.lbl_pagamento = new System.Windows.Forms.Label();
            this.cbx_pagamento = new System.Windows.Forms.ComboBox();
            this.mc_data = new System.Windows.Forms.MonthCalendar();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.cbx_horario = new System.Windows.Forms.ComboBox();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.btn_pagamento = new System.Windows.Forms.Button();
            this.ptb_agradecimento = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_agradecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pagamento
            // 
            this.lbl_pagamento.AutoSize = true;
            this.lbl_pagamento.Location = new System.Drawing.Point(1341, 155);
            this.lbl_pagamento.Name = "lbl_pagamento";
            this.lbl_pagamento.Size = new System.Drawing.Size(171, 13);
            this.lbl_pagamento.TabIndex = 0;
            this.lbl_pagamento.Text = "Escolha uma forma de pagamento:";
            // 
            // cbx_pagamento
            // 
            this.cbx_pagamento.FormattingEnabled = true;
            this.cbx_pagamento.Items.AddRange(new object[] {
            "Cartão de Débito",
            "Cartão de Crédito",
            "Pix"});
            this.cbx_pagamento.Location = new System.Drawing.Point(1359, 223);
            this.cbx_pagamento.Name = "cbx_pagamento";
            this.cbx_pagamento.Size = new System.Drawing.Size(121, 21);
            this.cbx_pagamento.TabIndex = 1;
            // 
            // mc_data
            // 
            this.mc_data.Location = new System.Drawing.Point(16, 66);
            this.mc_data.Name = "mc_data";
            this.mc_data.TabIndex = 2;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(44, 34);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(165, 13);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "Escolha o dia de sua preferência:";
            this.lbl_data.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(35, 254);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(183, 13);
            this.lbl_horario.TabIndex = 6;
            this.lbl_horario.Text = "Escolha o horário de sua preferência:";
            // 
            // cbx_horario
            // 
            this.cbx_horario.FormattingEnabled = true;
            this.cbx_horario.Items.AddRange(new object[] {
            "Manhã",
            "Tarde",
            "Noite"});
            this.cbx_horario.Location = new System.Drawing.Point(66, 290);
            this.cbx_horario.Name = "cbx_horario";
            this.cbx_horario.Size = new System.Drawing.Size(121, 21);
            this.cbx_horario.TabIndex = 5;
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_data.Controls.Add(this.lbl_data);
            this.pnl_data.Controls.Add(this.cbx_horario);
            this.pnl_data.Controls.Add(this.lbl_horario);
            this.pnl_data.Controls.Add(this.mc_data);
            this.pnl_data.Location = new System.Drawing.Point(779, 63);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(257, 431);
            this.pnl_data.TabIndex = 7;
            // 
            // btn_pagamento
            // 
            this.btn_pagamento.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_pagamento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pagamento.Location = new System.Drawing.Point(1289, 302);
            this.btn_pagamento.Name = "btn_pagamento";
            this.btn_pagamento.Size = new System.Drawing.Size(273, 78);
            this.btn_pagamento.TabIndex = 8;
            this.btn_pagamento.Text = "Pagar";
            this.btn_pagamento.UseVisualStyleBackColor = false;
            this.btn_pagamento.Click += new System.EventHandler(this.btn_pagamento_Click);
            // 
            // ptb_agradecimento
            // 
            this.ptb_agradecimento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptb_agradecimento.BackgroundImage")));
            this.ptb_agradecimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptb_agradecimento.Location = new System.Drawing.Point(743, 500);
            this.ptb_agradecimento.Name = "ptb_agradecimento";
            this.ptb_agradecimento.Size = new System.Drawing.Size(918, 559);
            this.ptb_agradecimento.TabIndex = 9;
            this.ptb_agradecimento.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 184);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(248, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 182);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(54, 386);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 169);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(248, 386);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(170, 210);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(63, 550);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(187, 183);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(248, 591);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(207, 206);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(88, 730);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(162, 182);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(93, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(362, 187);
            this.pictureBox8.TabIndex = 18;
            this.pictureBox8.TabStop = false;
            // 
            // Tela_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1788, 1061);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ptb_agradecimento);
            this.Controls.Add(this.btn_pagamento);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.cbx_pagamento);
            this.Controls.Add(this.lbl_pagamento);
            this.Name = "Tela_pagamento";
            this.Text = "Tela_pagamento";
            this.Load += new System.EventHandler(this.Tela_pagamento_Load);
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_agradecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pagamento;
        private System.Windows.Forms.ComboBox cbx_pagamento;
        private System.Windows.Forms.MonthCalendar mc_data;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.ComboBox cbx_horario;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.Button btn_pagamento;
        private System.Windows.Forms.PictureBox ptb_agradecimento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}