using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(UsuarioModel usuario)
        {

            listaUsuarios.Add(usuario);

            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarUsuario(UsuarioModel usuario)
        {

            listaUsuarios.Where(n => n.Codigo == usuario.Codigo)
                         .Select(s =>
                         {
                             s.Nome = usuario.Nome;
                             s.Sobrenome = usuario.Sobrenome;
                             s.Email = usuario.Email;
                             s.Phone = usuario.Phone;
                             s.Birthday = usuario.Birthday;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{codigo}")]
        public string ExcluirUsuario(int codigo)
        {

            UsuarioModel usuario = listaUsuarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .First();

            listaUsuarios.Remove(usuario);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{codigo}")]
        public UsuarioModel ConsultarUsuarioPorCodigo(int codigo)
        {

            UsuarioModel usuario = listaUsuarios.Where(n => n.Codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return usuario;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<UsuarioModel> ConsultarUsuarios()
        {
            return listaUsuarios;
        }
    }
}
