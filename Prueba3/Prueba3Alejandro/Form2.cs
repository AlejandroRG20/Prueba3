using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba3Alejandro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double va, dep;
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan mensajes en blanco");
                maskedTextBox1.Focus();
            }
            else
            {
                if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
                {
                    
                    va = double.Parse(maskedTextBox1.Text);
                    if (va >= 100 && va <= 100000)
                    {
                        dep = (va / 5);
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, Rango de bien entre 100 y 10000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
                else if (treeView1.SelectedNode.Text.Equals("Edificio"))
                {
                    
                    va = double.Parse(maskedTextBox1.Text);
                    if (va >= 100 && va <= 100000)
                    {
                        dep = (va / 20);
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, Rango de bien entre 100 y 10000");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
                else if (treeView1.SelectedNode.Text.Equals("Moviliario y equipo de oficina"))
                {
                    
                    va = double.Parse(maskedTextBox1.Text);
                    if (va >= 100 && va <= 100000)
                    {
                        dep = (va / 2);
                        textBox1.Text = dep.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error, Rango de bien entre 100 y 10000", "Error");
                        maskedTextBox1.Text = "";
                        maskedTextBox1.Focus();
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
