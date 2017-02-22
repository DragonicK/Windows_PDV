using System;

namespace Windows_PDV.Controller {
    public struct Fornecedor {
        /// <summary>
        /// ID de fornecedor.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Código do fornecedor.
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Nome da empresa.
        /// </summary>
        public string Empresa { get; set; }

        /// <summary>
        /// Endereço.
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Bairro.
        /// </summary>
        public string Bairro { get; set; }

        /// <summary>
        /// Cidade.
        /// </summary>
        public string Cidade { get; set; }

        /// <summary>
        /// Estado.
        /// </summary>
        public string Estado { get; set; }

        /// <summary>
        /// CEP.
        /// </summary>
        public string CEP { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        public string Telefone { get; set; }

        /// <summary>
        /// CPNJ.
        /// </summary>
        public string CNPJ { get; set; }

        /// <summary>
        /// Inscrição Estadual.
        /// </summary>
        public string IE { get; set; }

        /// <summary>
        /// Data de cadastro.
        /// </summary>
        public DateTime DataCadastro { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Construtor.
        /// </summary>
        /// <param name="fornecedor"></param>
        public Fornecedor(Fornecedor fornecedor) {
            ID = fornecedor.ID;
            Codigo = fornecedor.Codigo;
            Empresa = fornecedor.Empresa;
            Endereco = fornecedor.Endereco;
            Bairro = fornecedor.Bairro;
            Cidade = fornecedor.Cidade;
            Estado = fornecedor.Estado;
            CEP = fornecedor.CEP;
            Telefone = fornecedor.Telefone;
            CNPJ = fornecedor.CNPJ;
            IE = fornecedor.IE;
            DataCadastro = fornecedor.DataCadastro;
            Email = fornecedor.Email;
        }
    }
}
