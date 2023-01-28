using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }
        private void agregar_Click(object sender, EventArgs e)
        {

            string nombre = cuadroNombre.Text;
            DateTime fecha = Convert.ToDateTime(calendario.Text);
            string estadoCivil = estado.Text;
            string sexo = "";
            bool isExtranjero = esExtranjero.Checked;
           
            foreach (Control control in this.boxSexo.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;

                    if (radio.Checked)
                    {
                        sexo = radio.Text;
                    }
                }
            }

            if (nombre == string.Empty
                || estadoCivil == string.Empty
                || sexo == string.Empty)
            {
                labelEstado.ForeColor = Color.Red;
                labelEstado.Text = "Por favor se deben completar todos los campos para agregar al alumno";
            }

            else
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = nombre;
                row.Cells[1].Value = fecha.ToString();
                row.Cells[2].Value = estadoCivil;
                row.Cells[3].Value = sexo;
                row.Cells[4].Value = (isExtranjero ? "Si" : "No");
                dataGridView1.Rows.Add(row);

                labelEstado.ForeColor = Color.Black;
                labelEstado.Text = "Carga completa!";

            }
        }


        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelEstado_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
