﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Calcular
        {
            float soma, media, valor;
            soma = 0;

            foreach (Control controle in this.Controls)
            {
                if(controle is TextBox) 
                {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }

            }
        }
    }
}
