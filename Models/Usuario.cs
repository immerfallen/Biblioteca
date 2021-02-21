using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca.Models
{
    public class Usuario
    {
        public static int ADMIN = 0;
        public static int PADRAO = 1;

        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public int tipo { get; set; }
    }
}
