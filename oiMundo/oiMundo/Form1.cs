using oiMundo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Curso C# da Caelum");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int wesley = 19;
            int igor = 19;
            int renan = 22;
            double mediaIdade;

            mediaIdade = (wesley + igor + renan) / 3;

            MessageBox.Show("A média é:" + mediaIdade);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;

            MessageBox.Show("piQuebrado:" + piQuebrado);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            bool realmentePodeSacar = (saldo >= valorSaque) || (valorSaque > 0);
            if (realmentePodeSacar)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }

            bool verdadeiro = saldo > valorSaque;

            MessageBox.Show("É verdadeiro ?");
            MessageBox.Show(" " + verdadeiro);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Mue deus, você quer um abraço");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("VIP!!!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 6999.0;

            if (valorDaNotaFiscal <= 999)
            {
                MessageBox.Show("Imposto é de 2%");
            }
            else if (valorDaNotaFiscal <= 2999)
            {
                MessageBox.Show("Imposto é de 2.5%");
            }
            else if (valorDaNotaFiscal <= 6999)
            {
                MessageBox.Show("Imposto é de 2.8%");
            }
            else
            {
                MessageBox.Show("Imposto é de 3%");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //FOR

            double valorInvestido = 1000.0;

            for (int i = 1; i < 12; i++)
            {
                valorInvestido = valorInvestido * 1.01;
            }

            MessageBox.Show("o investimento rendeu " + valorInvestido);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //WHILE
            double valorInvestido = 1000.0;
            int i = 0;
            while (i <= 12)
            {
                valorInvestido = valorInvestido * 1.01;
                i += 1;
            }

            MessageBox.Show("o investimento rendeu " + valorInvestido.ToString("0.0"));

        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                MessageBox.Show(" " + i);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // guardo a informação dentro de uma variavel conta
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Thiago";
            c.saldo = 80.90;

            //mostro os valores associados a instância da Conta
            MessageBox.Show(" " + c.numero + " " + c.titular + " " + c.saldo);

            // atribuindo o metodo Saca á uma variavel

            bool deuCerto = c.Saca(50.0);

            if (deuCerto)
            {
                MessageBox.Show("O saque foi realizado com sucesso");
                MessageBox.Show("" + c.saldo);
            }
            else
            {
                MessageBox.Show("Uma pena o valor é insuficiente");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Conta contaVictor = new Conta();
            contaVictor.titular = "victor";
            contaVictor.numero = 1;
            contaVictor.saldo = 100.0;

            Conta contaJoana = new Conta();
            contaJoana.titular = "Joana";
            contaJoana.numero = 2;
            contaJoana.saldo = 120.0;

            MessageBox.Show(contaVictor.titular);
            MessageBox.Show($"{contaVictor.numero}");
            MessageBox.Show($"{contaVictor.saldo}");
            contaVictor.Saca(25.0);
            MessageBox.Show($"{contaVictor.saldo}");
            contaVictor.Deposita(40.0);
            MessageBox.Show($"{contaVictor.saldo}");

            MessageBox.Show(contaJoana.titular);
            MessageBox.Show($"{contaJoana.numero}");
            MessageBox.Show($"{contaJoana.saldo}");
            contaJoana.Saca(20.0);
            MessageBox.Show($"{contaJoana.saldo}");
            contaJoana.Deposita(100);
            MessageBox.Show($"{contaJoana.saldo}");
            contaJoana.Transfere(20.0, contaVictor);
            MessageBox.Show($"conta do Victor:{contaVictor.saldo}, conta da Joana:{contaJoana.saldo}");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Conta contaMauricio = new Conta();
            contaMauricio.numero = 1;
            contaMauricio.titular = "mauricio";
            contaMauricio.saldo = 100.0;

            Conta contaMauricio2 = new Conta();
            contaMauricio2.numero = 1;
            contaMauricio2.titular = "mauricio";
            contaMauricio2.saldo = 100.0;

            if (contaMauricio == contaMauricio2)
            {
                MessageBox.Show("As duas são iguais");
            }
            else
            {
                MessageBox.Show("As duas são diferentes");
            }

            Conta mauricio = new Conta();
            mauricio.saldo = 2000.0;

            Conta copia = mauricio;
            copia.saldo = 3000.0;

            MessageBox.Show("mauricio:" + mauricio.saldo);
            MessageBox.Show("copia" + copia.saldo);


        }

        private void btn_Click()
        {

            MessageBox.Show("Ola Mundo!");
            
        }
    }

}