using System.Text;
using System.Security.Cryptography;

namespace Windows_PDV.Controller {
    public static class Hash {

        /// <summary>
        /// Retorna um hash a partir dos dados fornecidos.
        /// </summary>
        /// <param name="data">dados a serem computados</param>
        /// <returns></returns>
        public static string Compute(string data) {
            var sha = new SHA256Managed();
            var hash = new StringBuilder();
            byte[] buffer = sha.ComputeHash(Encoding.ASCII.GetBytes(data));
         
            foreach (var bytes in buffer) {
                hash.Append(bytes.ToString("x2"));
            }

            return hash.ToString();
        }
    }
}


