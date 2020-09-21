
using EstudoTaskool.Database;
using EstudoTaskool.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoTaskool.Views
{
    public partial class frmListaUsuario : Form
    {
        public frmListaUsuario()
        {
            InitializeComponent();
        }

        UsuarioRepository repository = new UsuarioRepository();

        private void frmListaUsuario_Load(object sender, EventArgs e)
        {
            //List<Usuario> usuarios = new List<Usuario>();

            List<Usuario> usuarios = repository.buscarTodos();

            //Usuario usuario = new Usuario
            //{
            //    nome = "Erik",
            //    email = "erik.vitelli@email.com",
            //    senha = "1234",
            //    telefone = "1123456789",
            //    usuario = "evitelli"
            //};

            ////usuarios.Add(usuario);

            //repository.adicionar(usuario);

            carregaLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario
            //{
            //    nome = "erik",
            //    email = "erik.vitelli@email.com",
            //    senha = "1234",
            //    telefone = "1123456789",
            //    usuario = "evitelli"
            //};

            ////usuarios.add(usuario);

            //repository.adicionar(usuario);

            new frmCadastro().ShowDialog();

            carregaLista();
        }

        private void dgvListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Recupero a linha que foi selecionada
            DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

            Usuario usuario = new Usuario
            {
                Codigo = Convert.ToInt32(linha.Cells[0].Value.ToString()),
                Nome = linha.Cells[1].Value.ToString(),
                Email = linha.Cells[2].Value.ToString(),
                Username = linha.Cells[3].Value.ToString(),
                Senha = linha.Cells[4].Value.ToString(),
                Telefone = linha.Cells[5].Value.ToString(),
            };

            new frmCadastro(usuario).ShowDialog();

            carregaLista();
            

            //List<int> num = new List<int>
            //{
            //    1,2,3
            //};
            //num[0] = 1            
            //num[1] = 2   
            //num[2] = 3
        }

        private void dgvListaUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Atenção",
                       MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning
                       );

                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];
                    int codigo = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(codigo);

                    //dgvListaUsuario.DataSource = null;
                    //dgvListaUsuario.DataSource = repository.buscarTodos();
                    carregaLista();
                } 
            }
        }

        private void carregaLista()
        {
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = repository.buscarTodos();

            contador();
        }

        private void filtroTextBox_TextChanged(object sender, EventArgs e)
        {
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = repository.buscarTodos().
                FindAll(x => 
                    x.Nome.ToUpper().Contains(filtroTextBox.Text.ToUpper()) ||
                    x.Email.ToUpper().Contains(filtroTextBox.Text.ToUpper()) ||
                    x.Username.ToUpper().Contains(filtroTextBox.Text.ToUpper())
                );

            contador();
        }

        private void contador()
        {
            // 2 itens de 10
            lblContador.Text = $"{dgvListaUsuario.RowCount} itens de {repository.buscarTodos().Count} ";
        }
    }
}
