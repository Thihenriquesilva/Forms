using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testeMatematico
{
    public partial class Form1 : Form
    {
        //Criação de um objeto Random 
        //Que irá gerar números aleatórios

        Random aleatorio = new Random();

        //Variaveis para soma, subtração, divisão e multíplicação
        int addend1, addend2;
        int minuend, subtrahend;
        int multiplicand, multiplier;
        int dividend, divisor;

        //timer
        int timerLeft;
        public Form1()
        {
            InitializeComponent();
        }

        //Inicia o Teste ao apertar o Button "Iniciar"
        private void startButton_Click(object sender, EventArgs e)
        {
            StarTheQuiz();
            //Implementa que o 'button' não pode ser acessado quando
            // iniciamos o teste
            startButton.Enabled = false;
        }

        private void acerto_Beep(object sender, EventArgs e)
        {

            if (addend1 + addend2 == sum.Value)
            {
                SystemSounds.Beep.Play();
                //Console.Beep();
            }
        }

        private void acerto_Beep1(object sender, EventArgs e)
        {
            if (minuend - subtrahend == difference.Value)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void acerto_Beep2(object sender, EventArgs e)
        {
            if (multiplicand * multiplier == product.Value)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void acerto_Beep3(object sender, EventArgs e)
        {
            if (dividend / divisor == quotient.Value)
            {
                SystemSounds.Beep.Play();
            }
        }


        //Responsavel por gerar os numeros aleatórios
        public void StarTheQuiz()
        {
            //Gera dois numeros aleatórios 
            //Guardando-os nas variaveis 'addend1' e 'addend2'
            addend1 = aleatorio.Next(51);
            addend2 = aleatorio.Next(51);

            //Converta os dois números gerados aleatoriamente
            //em string para que eles possam ser exibidos
            //nos controles de etiqueta
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //'sum' é o nome do NumericUpDown control
            //Esta etapa garante que seu valor seja zero
            //antes de adicionar valores a ele
            sum.Value = 0;

            //Gera dois numeros aleatórios 
            //Guardando-os nas variaveis 'minuend' e 'subtrahend'

            minuend = aleatorio.Next(1, 101);
            subtrahend = aleatorio.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();

            difference.Value = 0;

            //Multiplicação
            multiplicand = aleatorio.Next(2,11);
            multiplier = aleatorio.Next(2, 11);

            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //Divisão
            divisor = aleatorio.Next(2, 11);
            int temporaryQuotient = aleatorio.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;


            //Inicializo o temporizador

            timerLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            // 'timer1' nome do componente
        }



        //Cuida to timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //Se o CheckTheAnswer() retornar True, o usuario acertou todas
                //o timer é parado
                //a mostra uma MessageBox
                //disponibiliza o botao startButton de novo
                timer1.Stop();
                MessageBox.Show("Você acertou todas as respostas!", "Parabens");
                timeLabel.BackColor = Color.Azure;
                startButton.Enabled = true;
            }
            else if (timerLeft > 0)
            {

                //Exiba o novo tempo restante
                //atualizando o Label de tempo restante.

                //cuidado com a ordem dos operadoes;
                timerLeft -= 1;
                if (timerLeft <= 5)
                    timeLabel.BackColor = Color.Red;

                timeLabel.Text = timerLeft + " seconds";
            }
            else
            {
                //se o usuário esgotou o tempo, pare o cronômetro, 
                //mostre uma MessageBox e preencha as respostas.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("Acabou o tempo você não terminou a tempo", " Desculpe '_'");
                timeLabel.BackColor = Color.Azure;
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
            
        }

     
        //Faz a seleção dos Valores dentro do Objeto NumericUpDown
        private void answer_Enter(object sender, EventArgs e)
        {
            //Especifico que o objeto é o NumericUpDown, não um objeto genérico
            NumericUpDown answerBox = sender as NumericUpDown;

            //Vejo esta nulo ou não nulo
            if(answerBox != null)
            {
                //pego todo o valor do Controle NumericUpDown
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                //Faz a seleção com base no tamanho do valor
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        /// <summary>
        ///verifique a resposta para ver se o usuário acertou tudo 
        /// </summary>
        /// <returns> True se a resposta estiver correta, false caso contrario</returns>
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
               
            else
                return false;
        }
    }
}
