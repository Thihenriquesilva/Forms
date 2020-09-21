using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Abre uma caixa com os botões Ok e Cancelar
            //Verifico se ele aperta em OK 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Abro a imagem selecionada no PictureBox
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Limpa a imagem
            if(pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada, por favor adicione uma.");
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
           if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //fecha o aplicativo
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Se o usuario selecionar check box Esticar
            //Altera a propriedade SizeMode
            //Do PictureBox para "Stretch".
            //Se o usuario desmarcar o check box 
            //A propriedade SizeMode volta ao normal;

            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
