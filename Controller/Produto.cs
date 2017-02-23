namespace Windows_PDV.Controller {
    public class Produto {
        /// <summary>
        /// ID de produto.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Código do produto.
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        public string Descricao { get; set; }

        /// <summary>
        /// ID do fornecedor.
        /// </summary>
        public int FornecedorID { get; set; }

        /// <summary>
        /// Nome da empresa do fornecedor.
        /// </summary>
        public string Fornecedor { get; set; }

        /// <summary>
        /// Nome do fabricante.
        /// </summary>
        public string Fabricante { get; set; }

        /// <summary>
        /// Preço de Custo.
        /// </summary>
        public decimal PrecoCusto { get; set; }

        /// <summary>
        /// Preço de Venda.
        /// </summary>
        public decimal PrecoVenda { get; set; }

        /// <summary>
        /// Margem de Lucro.
        /// </summary>
        public int MargemLucro { get; set; }

        /// <summary>
        /// Estoque atual
        /// </summary>
        public int Estoque { get; set; }

        /// <summary>
        /// Estoque mínimo.
        /// </summary>
        public int EstoqueMinimo { get; set; }

        /// <summary>
        /// Construtor.
        /// </summary>
        public Produto() {
            Codigo = string.Empty;
            Descricao = string.Empty;
            Fabricante = string.Empty;
            Fornecedor = string.Empty;
        }

        public Produto(Produto produto) {
            Codigo = produto.Codigo;
            Descricao = produto.Descricao;
            FornecedorID = produto.FornecedorID;
            Fabricante = produto.Fabricante;
            PrecoCusto = produto.PrecoCusto;
            PrecoVenda = produto.PrecoVenda;
            MargemLucro = produto.MargemLucro;
            Estoque = produto.Estoque;
            EstoqueMinimo = produto.EstoqueMinimo;
        }

        /// <summary>
        /// Calcula a margem de lucro.
        /// </summary>
        public void CalcularMargemDeLucro() {
            //MargemLucro
        }

        /// <summary>
        /// Calcula o preço de venda.
        /// </summary>
        public void CalcularPrecoDeVenda() {
            //PrecoVenda 
        }

    }
}
