using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maquinaRefrescos
{
    public partial class Form1 : Form
    {

        MaquinaRefrescos obj1 = new MaquinaRefrescos();

        public Form1()
        {
            InitializeComponent();
        }

        private void resurtitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fanta;
            button2.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

            if (radioButton1.Checked)
                {
                obj1.cantidadCocaCola();
                label9.Text = Convert.ToString(obj1.DesStockCoca);

                }
            if (radioButton2.Checked)
            {
                obj1.cantidadFresca();
                label10.Text = Convert.ToString(obj1.DesStockFresca);
            }

            if (radioButton3.Checked)
            {
                obj1.cantidadFanta();
                label11.Text = Convert.ToString(obj1.DesStockFanta);
            }

            if (radioButton4.Checked)
            {
                obj1.cantidadSprite();
                label12.Text = Convert.ToString(obj1.DesStockSprite);
            }

            if (radioButton5.Checked)
            {
                obj1.cantidadManzanita();
                label13.Text = Convert.ToString(obj1.DesStockManzanita);
            }
                
            MessageBox.Show("Gracias por su compra!!!");
            textBox1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            obj1.Cambio = 0;
            obj1.ResultInsert = 0;
            label6.Text = Convert.ToString("$" + obj1.ResultInsert);
            label8.Text = Convert.ToString("$" + obj1.Cambio);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double validar;
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe de ingresar el dinero");
            }
            else
            {
                if (double.TryParse(textBox1.Text, out validar))
                {
                    int existenciaTotal = obj1.validarExistenciasTotales();
                    if (existenciaTotal == 1)
                    {
                        MessageBox.Show("Maquina vacia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        double insert = Convert.ToDouble(textBox1.Text);
                        obj1.Insertar = insert;
                        if (insert == 0.5 || insert == 1 || insert == 2 || insert == 5 || insert == 10)
                        {
                            obj1.metodoValidacion();
                            label6.Text = Convert.ToString("$" + obj1.ResultInsert);
                            textBox1.Text = Convert.ToString("");

                            if (obj1.ResultInsert >= obj1.Precio)
                            {
                                radioButton6.Checked = true;
                                radioButton1.Enabled = true;
                                radioButton2.Enabled = true;
                                radioButton3.Enabled = true;
                                radioButton4.Enabled = true;
                                radioButton5.Enabled = true;
                              
                                textBox1.Enabled = false;
                                button1.Enabled = false;
                                button2.Enabled = false;

                                if (obj1.DesStockCoca == 0)
                                {
                                    radioButton1.Enabled = false;
                                    radioButton1.Checked = false;
                                    
                                }

                                if (obj1.DesStockFresca == 0)
                                {
                                    radioButton2.Enabled = false;
                                    radioButton2.Checked = false;
                                }

                                if (obj1.DesStockFanta == 0)
                                {
                                    radioButton3.Enabled = false;
                                    radioButton3.Checked = false;
                                    
                                }

                                if (obj1.DesStockSprite == 0)
                                {
                                    radioButton4.Enabled = false;
                                    radioButton4.Checked = false;
                                }

                                if (obj1.DesStockManzanita == 0)
                                {
                                    radioButton5.Enabled = false;
                                    radioButton5.Checked = false;
                                }


                                MessageBox.Show("Seleccione su producto");
                                label8.Text = Convert.ToString("$" + obj1.Cambio);

                            }

                        }
                        else
                        {
                            MessageBox.Show("La maquina solo permite las monedas de $0.5  $1  $2  $5  $10", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                   

                }
                else
                {
                    MessageBox.Show("No se permiten otro tipo de carácteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.cocacola1;
            button2.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            button2.Enabled = false;
        }

        private void cocaColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int destockNuevo;
            String cantidadVentana = Microsoft.VisualBasic.Interaction.InputBox("Resurtir Refresco Coca Cola", "Resusrtir", "1");

            if (cantidadVentana.All(char.IsDigit) )
            {
                destockNuevo = Convert.ToInt32(cantidadVentana);
                obj1.DesStockCoca = obj1.DesStockCoca + destockNuevo;
                label9.Text = Convert.ToString(obj1.DesStockCoca);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {
          
        }

   

        private void fantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int destockNuevo;
            String cantidadVentana = Microsoft.VisualBasic.Interaction.InputBox("Resurtir Refresco Fanta", "Resurtir", "1");
            if (cantidadVentana.All(char.IsDigit))
            {
                destockNuevo = Convert.ToInt32(cantidadVentana);
                obj1.DesStockFanta = obj1.DesStockFanta + destockNuevo;
                label11.Text = Convert.ToString(obj1.DesStockFanta);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void frescaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int destockNuevo;
            String cantidadVentana = Microsoft.VisualBasic.Interaction.InputBox("Resurtir Refresco Fresca", "Resurtir", "1");
            if (cantidadVentana.All(char.IsDigit))
            {
                destockNuevo = Convert.ToInt32(cantidadVentana);
                obj1.DesStockFresca = obj1.DesStockFresca + destockNuevo;
                label10.Text = Convert.ToString(obj1.DesStockFresca);

            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void spriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int destockNuevo;
            String cantidadVentana = Microsoft.VisualBasic.Interaction.InputBox("Resurtir Refresco Sprite", "Resurtir", "1");
            if (cantidadVentana.All(char.IsDigit))
            {
                destockNuevo = Convert.ToInt32(cantidadVentana);
                obj1.DesStockSprite = obj1.DesStockSprite + destockNuevo;
                label12.Text = Convert.ToString(obj1.DesStockSprite);

            }
            else{
                MessageBox.Show("El valor ingresado no es numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void manzanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int destockNuevo;
            String cantidadVentana = Microsoft.VisualBasic.Interaction.InputBox("Resusrtir Refresco Manzanita", "Resurtir", "1");
            if (cantidadVentana.All(char.IsDigit))
            {
                destockNuevo = Convert.ToInt32(cantidadVentana);
                obj1.DesStockManzanita += destockNuevo;
                label13.Text = Convert.ToString(obj1.DesStockManzanita);
            }
            else
            {
                MessageBox.Show("El valor ingresado no es numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void precioRefescoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double precioNew;
            double validar;
           
            String cantidadVenta = Microsoft.VisualBasic.Interaction.InputBox("Cambiar Precio de los Refrescos", "Nuevo Precio", "4.5");
            double cant = Convert.ToDouble(cantidadVenta);
            if(cant % 0.5 == 0)
            {
                if (!(double.TryParse(cantidadVenta, out validar)) || cant <= 0)
                {
                    MessageBox.Show("El valor ingresado no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    precioNew = Convert.ToDouble(cantidadVenta);
                    obj1.Precio = precioNew;
                    label3.Text = Convert.ToString("$" + obj1.Precio);

                }
            }
            else
            {
                MessageBox.Show("Unicamente se permite decimales con 0.5", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fresca;
            button2.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.sprite;
            button2.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.manzanita;
            button2.Enabled = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
