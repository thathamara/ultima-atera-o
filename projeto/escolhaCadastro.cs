﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeprojetoInt
{
    public partial class escolhaCadastro : Form
    {
        public escolhaCadastro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Beneficiado bNF = new Beneficiado();

            bNF.Show();

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_exibir angel = new btn_exibir();

            angel.Show();

            this.Close();
        }
    }
}