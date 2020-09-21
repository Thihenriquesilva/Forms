using System;
using System.Drawing;
using System.Windows.Forms;
using System.Security;

namespace OpenFileDialogDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarArquivos_Click(object sender, EventArgs e)
        {

            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";

            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";

            DialogResult dr = this.ofd1.ShowDialog();

            if(dr == DialogResult.OK)
            {
                //Le os arquivos selecionados
                foreach (String arquivo in ofd1.FileNames)
                {
                    txtArquivos.Text += arquivo;

                    try
                    {
                        PictureBox pb = new PictureBox();
                        Image Imagem = Image.FromFile(arquivo);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //para exibir as imagens em tamanho natural 
                        //descomente as linhas abaixo e comente as duas seguintes
                        //pb.Height = loadedImage.Height;
                        //pb.Width = loadedImage.Width;
                        pb.Height = 100;
                        pb.Width = 100;
                        //atribui a imagem ao PictureBox - pb
                        pb.Image = Imagem;
                        //inclui a imagem no containter flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(pb);
                    }
                    catch(SecurityException ex)
                    {
                        // O usuário  não possui permissão para ler arquivos
                        MessageBox.Show("Erro de segurança Contate o administrador de segurança da rede.\n\n" +
                                                    "Mensagem : " + ex.Message + "\n\n" +
                                                    "Detalhes (enviar ao suporte):\n\n" + ex.StackTrace);
                    }
                    catch (Exception ex)
                    {
                        // Não pode carregar a imagem (problemas de permissão)
                        MessageBox.Show("Não é possível exibir a imagem : " + arquivo.Substring(arquivo.LastIndexOf('\\'))
                                                   + ". Você pode não ter permissão para ler o arquivo , ou " +
                                                   " ele pode estar corrompido.\n\nErro reportado : " + ex.Message);
                    }

                }
            }
        
        
        }
    }
}
