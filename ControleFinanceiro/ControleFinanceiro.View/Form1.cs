using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * O que é uma variael?
             * Tipos de variáveis?
             * Declarar ou emitir o tipo
            var email = "cecilia@minhaavo.com.br";
                string senha = "123456";
            */

            string email, senha;
            email = textBox1.Text;
            senha = textBox1.Text;

            MessageBox.Show($"Sr. Cecilia seu email { email} esta correto?")
            if (email.Equals("ceci@gmail.com"{ senha}.Equals("123") { 
            }

            MessageBox.Show("Ola C#!");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
