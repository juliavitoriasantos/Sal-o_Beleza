﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salão_Beleza
{
    public partial class Tela_pagamento : Form
    {
        public Tela_pagamento()
        {
            InitializeComponent();
        }

        private void Tela_pagamento_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_pagamento_Click(object sender, EventArgs e)
        {
            Tela_AP Tela_pagamento = new Tela_AP();
            Tela_pagamento.ShowDialog();

        }
    }
}
