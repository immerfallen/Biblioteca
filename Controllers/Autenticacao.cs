using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;

namespace Biblioteca.Controllers
{
    public class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/Home/Login");
            }
        }

        public static bool verificaLoginSenha(string login, string senha, Controller controller)
        {
            using (BibliotecaContext bc = new BibliotecaContext())
            {
                verificaSeUsuarioAdminExiste(bc);

                senha = Criptografo.TextoCriptografado(senha);

                IQueryable<Usuario> UsuarioEncontrado = bc.usuarios.Where(u => u.login == login && u.senha == senha);
                List<Usuario> ListaUsuarioEncontrado = UsuarioEncontrado.ToList();
                if(ListaUsuarioEncontrado.Count == 0)
                {
                    return false;
                }
                else
                {
                    controller.HttpContext.Session.SetString("login", ListaUsuarioEncontrado[0].login);
                    controller.HttpContext.Session.SetString("Nome", ListaUsuarioEncontrado[0].login);
                    controller.HttpContext.Session.SetString("Tipo", ListaUsuarioEncontrado[0].login);
                    return true;
                }
            }
        }
    }
}