namespace Windows_PDV.Controller {
    public class Person {
        /// <summary>
        /// ID de usuário.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Nível de acesso.
        /// </summary>
        public short Acesso { get; set; }
         
        /// <summary>
        /// Nome real de usuário.
        /// </summary>
        public string Name { get; set; }
 
        /// <summary>
        /// Conta de usuário.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Construtor.
        /// </summary>
        public Person() {
            Name = string.Empty;
            User = string.Empty;
         
        }
    }
}
