
using System.Security.Cryptography;
using System.Text;

namespace Biblioteca.Models
{
    public static class Criptografo
    {
        public static string TextoCriptografado(string textoClaro)
        {
            MD5 md5Hasher =  MD5.Create();
            

            byte[] By = Encoding.Default.GetBytes(textoClaro);
            byte[] bytesCriptografado = md5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();

            foreach (byte b in bytesCriptografado)
            {
                string debugB = b.ToString("x2");
                SB.Append(debugB);
            }
            return SB.ToString();            
        }

    }
}
