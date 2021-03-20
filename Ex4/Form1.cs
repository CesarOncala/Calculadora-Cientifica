using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            textBox1.Focus();
            textBox1.Select();


        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
             textBox1.Focus();
            textBox1.Select();
            try
            {
                Dados.n2 = double.Parse(textBox1.Text);

                
               
                    textBox1.Text = Gerente(Dados.o, Dados.n1, Dados.n2).ToString();
                    textBox2.Text = "";    
 

            }
            catch (Exception)
            {

                MessageBox.Show("Isso não é permitido");
            }



        }

        public double Gerente(OperaçõesMat o, double n1, double n2)
        {
                if (o.calc(n1,n2) != -99)
                {
                    return o.calc(n1, n2);
                }
                else
                {
                   MessageBox.Show("Não é possivel dividir por zero");     
                }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            textBox2.Text += "1";
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonsoma_Click(object sender, EventArgs e)
        {
            textBox2.Text += " + ";
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.o = new Soma();
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }

        }
        public void seila()
        {
            textBox2.Text += "5";
            textBox1.Text += "5";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            seila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
            textBox1.Text += "2";
        }

        private void Form1_Load(object sender, KeyEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
            textBox1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
            textBox1.Text += "0";
        }

        private void buttonVirg_Click(object sender, EventArgs e)
        {
            textBox2.Text += ",";
            textBox1.Text += ",";
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            textBox2.Text += " * ";
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.o = new Multiplica();
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }

        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            textBox2.Text += " - ";
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.o = new Subtrai();
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }

        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            textBox2.Text += " / ";
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.o = new Divide();
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");


            }

        }

        private void buttonelev_Click(object sender, EventArgs e)
        {
            textBox2.Text += " ^ ";
            textBox1.Focus();
            textBox1.Select();
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.o = new Eleva();
                textBox1.Text = "";
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }

        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            textBox2.Text += " √ ";
            textBox1.Focus();
            textBox1.Select();
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.n2 = 0;
                Dados.o = new Raiz();
                textBox1.Text = "";
                textBox1.Text = Gerente(Dados.o, Dados.n1, Dados.n2).ToString();
            }
            catch (Exception)
            {

                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length-1, 1);
            }
            catch (Exception)
            {

               
            }
           
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Select();
            textBox2.Text += " % ";
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                Dados.o = new Porcentagem();
                textBox1.Text = "";
                textBox1.Text = Gerente(Dados.o, Dados.n1, Dados.n2).ToString();
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Select();
            if (textBox1.Text[0] == '-')
            {
                textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length-1, 1);
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1, 1);
            }
            else
            {
                textBox2.Text = textBox1.Text.Insert(0, "-");
                textBox1.Text = textBox1.Text.Insert(0, "-");
            }


        }

        private void Button13_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Select();
            textBox2.Text += " Mod ";
            try
            {
                Dados.n1 = double.Parse(textBox1.Text);
                textBox1.Text = "";
                Dados.o = new Modulo();
            }
            catch (Exception)
            {
                textBox2.Text = "";
                MessageBox.Show("Digite um número primeiro");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
        private void textBox1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad5) button5.PerformClick();
            if (e.KeyCode == Keys.NumPad6) button6.PerformClick();
            if (e.KeyCode == Keys.NumPad4) button4.PerformClick();
            if (e.KeyCode == Keys.NumPad3) button3.PerformClick();
            if (e.KeyCode == Keys.NumPad2) button2.PerformClick();
            if (e.KeyCode == Keys.NumPad1) button1.PerformClick();
            if (e.KeyCode == Keys.NumPad7) button7.PerformClick();
            if (e.KeyCode == Keys.NumPad8) button9.PerformClick();
            if (e.KeyCode == Keys.NumPad9) button8.PerformClick();
            if (e.KeyCode == Keys.Add) buttonsoma.PerformClick();
            if (e.KeyCode == Keys.Subtract) buttonsub.PerformClick();
            if (e.KeyCode == Keys.Divide) buttondiv.PerformClick();
            if (e.KeyCode == Keys.Multiply) buttonmul.PerformClick();
            if (e.KeyCode == Keys.Back) button10.PerformClick();
            if (e.KeyCode == Keys.Enter) buttonIgual.PerformClick();
            if (e.KeyCode == Keys.Oemcomma) buttonVirg.PerformClick();
            if (e.KeyCode == Keys.Delete) button14.PerformClick();
            if (e.KeyCode == Keys.NumPad0) button0.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
