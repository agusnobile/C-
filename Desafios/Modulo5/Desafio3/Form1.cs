﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numero1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int primerValor = int.Parse(numero1.Text);
            int segundoValor = int.Parse(numero2.Text);
            int resultadoRetorno = primerValor + segundoValor;

            resultado.Text = $"El resultado de la suma es {resultadoRetorno}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int primerValor = int.Parse(numero1.Text);
            int segundoValor = int.Parse(numero2.Text);
            int resultadoRetorno = primerValor - segundoValor;

            resultado.Text = $"El resultado de la resta es {resultadoRetorno}";
        }
        
    }
}
