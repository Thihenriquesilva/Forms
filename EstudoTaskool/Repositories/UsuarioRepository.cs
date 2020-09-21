using EstudoTaskool.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoTaskool.Repositories
{
    public class UsuarioRepository
    {
        public UsuarioRepository()
        {

        }

        public List<Usuario> buscarTodos()
        {
            //return usuarios;            
            using (TaskoolEntities ent = new TaskoolEntities())
            {
                return ent.Usuario.ToList();
            }

        }

        public void adicionar(Usuario usuario)
        {
            //usuario.Codigo = contador;
            //usuarios.Add(usuario);
            //contador++;

            using (TaskoolEntities ent = new TaskoolEntities())
            {
                ent.Usuario.Add(usuario);
                ent.SaveChanges();
            }
        }

        public void editar(Usuario usuario)
        {
            //pegar o objeto da lista
            //Usuario u = usuarios.Find(x => x.Codigo == usuario.Codigo);

            //Usuario u2;
            //foreach (Usuario x in usuarios)
            //{
            //    if (x.codigo == usuario.codigo)
            //    {
            //        u2 = x;
            //    }
            //}

            // pegar a posição deste objeto na lista
            //int posicao = usuarios.IndexOf(u);

            //alterar o objeto na lista
            //usuarios[posicao] = usuario;

            using(TaskoolEntities ent = new TaskoolEntities())
            {
                Usuario u = ent.Usuario.FirstOrDefault(x => x.Codigo == usuario.Codigo);


                if(u != null)
                {
                    u.Nome = usuario.Nome;
                    u.Email = usuario.Email;
                    u.Senha = usuario.Senha;
                    u.Telefone = usuario.Telefone;
                    u.Username = usuario.Username;
                    ent.SaveChanges();
                }
            }
        }

        public void deletar(int codigo)
        {
            // pegar o usuário na lista
            //Usuario usuario = usuarios.Find(x => x.Codigo == codigo);

            // deletar o usuário da lista
            //usuarios.Remove(usuario);

            using(TaskoolEntities ent = new TaskoolEntities())
            {
                Usuario usuario = ent.Usuario.First(x => x.Codigo == codigo);

                if(usuario != null)
                {
                    ent.Usuario.Remove(usuario);
                    ent.SaveChanges();
                }
            }

        }
    }
}
