namespace Prueba3Alejandro
{
    public partial class Form1 : Form
    {
        double plazo, plazo2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double codigo, valor, interes, cuota, p;
            String Tp;
            if (treeView1.SelectedNode.Text == "")
            {
                MessageBox.Show("Seleccione una rama");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, Digite el tipo de bien");
                comboBox1.Focus();
            }
            else if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("No se aceptan espacios, Digite el valor del bien");
                maskedTextBox1.Focus();
            }
            else
            {


                if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
                {
                    comboBox2.Enabled = true;
                    comboBox3.Enabled = false;

                    Tp = Convert.ToString(comboBox1.Text);
                    if (Tp == "Nuevo")
                    {
                        valor = Convert.ToDouble(maskedTextBox1.Text);
                        if (valor < 5000 || valor > 250000)
                        {
                            MessageBox.Show("Rango entre 5,000 a 250,000");
                            maskedTextBox1.Text = "";
                            maskedTextBox1.Focus();
                        }
                        else
                        {
                            if (comboBox2.Text == ""){

                                MessageBox.Show("No se aceptan vacios, digite su plazo de vehiculo");
                                comboBox2.Text = "";
                                comboBox2.Focus();
                            }
                            else
                            {
                                plazo = Convert.ToDouble(comboBox2.Text);

                                interes = 1.25 * plazo;
                                valor = valor * (interes / 100);
                                cuota = valor / plazo;
                                textBox1.Text = cuota.ToString("0.00");
                            }

                           
                        }
                    }
                    else if (Tp == "Usado")
                    {
                        valor = Convert.ToDouble(maskedTextBox1.Text);
                        if (valor < 5000 || valor > 250000)
                        {
                            MessageBox.Show("Rango entre 5,000 a 250,000");
                            maskedTextBox1.Text = "";
                            maskedTextBox1.Focus();
                        }
                        else
                        {
                            if (comboBox2.Text == "")
                            {

                                MessageBox.Show("No se aceptan vacios, digite su plazo de vehiculo");
                                comboBox2.Text = "";
                                comboBox2.Focus();
                            }
                            else
                            {
                                plazo = Convert.ToDouble(comboBox2.Text);
                                interes = 1.5 * plazo;
                                valor = valor * (interes / 100);
                                cuota = valor / plazo;
                                textBox1.Text = cuota.ToString("0.00");
                            }
                            
                        }
                    }
                }
                else if (treeView1.SelectedNode.Text.Equals("Vivienda"))
                {
                    comboBox3.Enabled = true;
                    comboBox2.Enabled = false;
                    
                    Tp = Convert.ToString(comboBox1.Text);
                    if (Tp == "Nuevo")
                    {
                        valor = Convert.ToDouble(maskedTextBox1.Text);
                        if (valor < 5000 || valor > 250000)
                        {
                            MessageBox.Show("Rango entre 5,000 a 250,000");
                            maskedTextBox1.Text = "";
                            maskedTextBox1.Focus();
                        }
                        else
                        {
                            if (comboBox3.Text == "")
                            {

                                MessageBox.Show("No se aceptan vacios, digite su plazo de vivienda");
                                comboBox3.Text = "";
                                comboBox3.Focus();
                            }
                            else
                            {
                                plazo2 = Convert.ToDouble(comboBox3.Text);
                                interes = 1 * plazo2;
                                valor = valor * (interes / 100);
                                cuota = valor / plazo2;
                                textBox1.Text = cuota.ToString("0.00");
                            }
                           
                        }
                    }
                    else if (Tp == "Usado")
                    {
                        valor = Convert.ToDouble(maskedTextBox1.Text);
                        if (valor < 5000 || valor > 250000)
                        {
                            MessageBox.Show("Rango entre 5,000 a 250,000");
                            maskedTextBox1.Text = "";
                            maskedTextBox1.Focus();
                        }
                        else
                        {
                            if (comboBox3.Text == "")
                            {

                                MessageBox.Show("No se aceptan vacios, digite su plazo de vivienda");
                                comboBox3.Text = "";
                                comboBox3.Focus();
                            }
                            else
                            {
                                plazo2 = Convert.ToDouble(comboBox3.Text);
                                cuota = valor / plazo2;
                                interes = cuota * 2;
                                cuota = cuota + interes;
                                textBox1.Text = cuota.ToString("0.00");
                            }
                            
                        }
                    }

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text.Equals("Vehiculo"))
            {   
                comboBox3.Text = "";
                comboBox2.Enabled = true;
                label3.Enabled = true;
                comboBox3.Enabled = false;
                label5.Enabled= false;
            }
            else if (treeView1.SelectedNode.Text.Equals("Vivienda"))
            {
                comboBox2.Text = "";
                comboBox3.Enabled = true;
                label5.Enabled = true;
                comboBox2.Enabled = false;
                label3.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double columna, fila;
            if (textBox1.Text == "")
            {
                MessageBox.Show("No se puede agregar sin antes cacular la cuota");
            }
            else
            {
                /* plazo = Convert.ToDouble(comboBox2.Text);
                 double n = 0;
                 fila = plazo +1; columna = 6;
                 data.ColumnCount = columna;
                 data.RowCount = fila;
                 data[0, 1].Value = IngI;
                 for (int i = 0; i < data.ColumnCount; i++)
                 {
                     data[i, 0].Value = "Año " + (i);
                 }
                 data[0, 1].Value = IngI;



                 for (int i = 1; i < data.ColumnCount; i++)
                 {
                     data[i, 2].Value = Ingr;
                     Ingr = (Ingr * 0.10) + Ingr;
                 }

                 for (int n = 1; n < data.ColumnCount; n++)
                 {
                     data[n, 3].Value = Egre;
                     Egre = (Egre * 0.10) + Egre;

                 }
                 h = Ing * 12;
                 g = Egr * 12;
                 for (int l = 1; l < data.ColumnCount; l++)
                 {
                     Ut = h - g;
                     data[l, 4].Value = Ut;
                     h = (h * 0.10) + h;
                     g = (g * 0.10) + g;


                 }
                 h = Ing * 12;
                 g = Egr * 12;
                 for (int m = 1; m < data.ColumnCount; m++)
                 {

                     Ut = h - g;
                     h = (h * 0.10) + h;
                     g = (g * 0.10) + g;
                     imp = Ut * 0.30;
                     data[m, 5].Value = imp;

                 }
             }

             for (int s=0; s < data.Rows.Count; s++)
                 {
                     data.Rows[s].Cells[0].Value = (s+1);
                     data.Rows[s].Cells[0].Value = (s + 1);
                     data.row.Cells[1].Value = textBox6.Text;
                     data.row.Cells[2].Value = textBox2.Text;
                     data.row.Cells[3].Value = textBox3.Text;
                 }

                 data.row.Cells[0].Value = n + 1;
                 data.row.Cells[1].Value = textBox6.Text;
                 data.row.Cells[2].Value = textBox2.Text;
                 data.row.Cells[3].Value = textBox3.Text;
                 row.Cells[4].Value = textBox4.Text;
                 row.Cells[5].Value = textBox5.Text;
                 row.Cells[6].Value = maskedTextBox1.Text;

                 data.Rows.Add(row);
                 textBox1.Text = "";
                 maskedTextBox1.Text = "";
                 textBox2.Text = "";
                 textBox3.Text = "";
                 textBox4.Text = "";
                 textBox5.Text = "";
                 textBox6.Text = "";
                 maskedTextBox1.Focus();



                 }*/
            }
        }
    } }
