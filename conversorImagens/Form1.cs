using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversorImagens
{
    public partial class Form1 : Form
    {
        //trabalha com pixels de imagens
        Bitmap bmp;
        const string stringConexao = "Data Source = BatCaverna\\SQLEXPRESS; initial catalog = ImagensArray; user Id = sa; pwd = gorgonzola@132;";

        SqlConnection conn = new SqlConnection(stringConexao);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Tb_Produtos  WHERE Nome = @Nome",conn);

            SqlParameter nome = new SqlParameter("Nome", SqlDbType.VarChar);

            nome.Value = txt_Nome.Text;

            cmd.Parameters.Add(nome);

            try
            {
                conn.Open();

                SqlDataReader rdr = cmd.ExecuteReader();

                rdr.Read();

                if (rdr.HasRows)
                {
                    txt_Nome.Text = rdr[1].ToString();
                    byte[] imagem = (byte[])rdr[2];

                    if (imagem == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(imagem);



                        pictureBox1.Image = Image.FromStream(ms); 
                    }
                }

                conn.Close();
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
        }

        private void btn_SelecionarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string nome = openFileDialog1.FileName;

                bmp = new Bitmap(nome);

                pictureBox1.Image = bmp;

            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            MemoryStream memory = new MemoryStream();

            bmp.Save(memory,ImageFormat.Bmp);

            byte[] foto = memory.ToArray();

           

            SqlCommand cmd = new SqlCommand("INSERT INTO Tb_Produtos (Nome,Imagem) VALUES (@Nome,@Imagem)",conn);

            SqlParameter nome = new SqlParameter("@Nome", SqlDbType.VarChar);

            SqlParameter imagem = new SqlParameter("@Imagem", SqlDbType.Binary);

            nome.Value = txt_Nome.Text;
            imagem.Value = foto;

            cmd.Parameters.Add(nome);
            cmd.Parameters.Add(imagem);

            try
            {
                conn.Open();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Usuário salvo com sucesso");

                txt_Nome.Text = "";
                pictureBox1.Image = null;
            }
            catch (Exception E)
            {

                MessageBox.Show(E.Message);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
