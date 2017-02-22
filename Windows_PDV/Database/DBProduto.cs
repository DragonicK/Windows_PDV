using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Windows_PDV.Controller;

namespace Windows_PDV.Database {
    public class DBProduto {
        /// <summary>
        /// Verifica se o código já existe no banco.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool ExisteProduto(string codigo) {
            var query = $"SELECT id FROM produto WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var read = reader.Read();

            reader.Close();
            Configuration2.Connection.CloseConnection();

            return read;
        }

        /// <summary>
        /// Deleta o produto.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static int DeletarProduto(string codigo) {
            var query = $"DELETE FROM produto WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return value;
        }

        /// <summary>
        /// Deleta todos os produtos.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static int DeletarProdutos() {
            var query = $"DELETE FROM produto";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return value;
        }

        /// <summary>
        /// Insere o novo produto
        /// </summary>
        /// <param name="produto"></param>
        /// <returns></returns>
        public static bool InserirProduto(Produto produto) {
             var query = new StringBuilder();
            query.Append("INSERT INTO produto");
            query.Append("(codigo, descricao, codigo_fornecedor, fabricante, preco_custo, preco_venda, margem_lucro, estoque_atual, estoque_minimo)");
            query.Append($" VALUES ('{produto.Codigo}', '{produto.Descricao}', '{produto.FornecedorID}', ");
            query.Append($"'{produto.Fabricante}', '{produto.PrecoCusto}', '{produto.PrecoVenda}', '{produto.MargemLucro}', ");
            query.Append($"'{produto.Estoque}', '{produto.EstoqueMinimo}')");

            var cmd = new MySqlCommand(query.ToString(), Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return Convert.ToBoolean(value);
        }

        /// Atualiza as informações do produto
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        public static bool AtualizarProduto(Produto produto, string codigo_velho) {
            var query = new StringBuilder();
            query.Append("UPDATE produto SET ");
            query.Append($"codigo='{produto.Codigo}', ");
            query.Append($"descricao ='{produto.Descricao}', ");
            query.Append($"codigo_fornecedor ='{produto.FornecedorID}', ");
            query.Append($"fabricante ='{produto.Fabricante}', ");
            query.Append($"preco_custo ='{produto.PrecoCusto}', ");
            query.Append($"preco_venda ='{produto.PrecoVenda}', ");
            query.Append($"margem_lucro ='{produto.MargemLucro}', ");
            query.Append($"estoque_atual ='{produto.Estoque}', ");
            query.Append($"estoque_minimo ='{produto.EstoqueMinimo}'");
            query.Append($" WHERE codigo='{codigo_velho}'");

            var cmd = new MySqlCommand(query.ToString(), Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var result = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return Convert.ToBoolean(result);
        }

        /// <summary>
        /// Carrega o fornecedor.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static Produto CarregarProduto(string codigo) {
            var query = $"SELECT * from produto WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            reader.Read();

            var produto = new Produto();
            produto.ID = (int)reader["id"];
            produto.Codigo = (string)reader["codigo"];
            produto.Descricao = (string)reader["descricao"];

            if (reader["codigo_fornecedor"] == DBNull.Value) {
                produto.FornecedorID = 1;
            }
            else {
                produto.FornecedorID = Convert.ToInt32(reader["codigo_fornecedor"]);
            }

            produto.Fabricante = (string)reader["fabricante"];
            produto.PrecoCusto = Convert.ToDecimal(reader["preco_custo"]);
            produto.PrecoVenda = Convert.ToDecimal(reader["preco_venda"]);
            produto.MargemLucro = Convert.ToInt32(reader["margem_lucro"]);
            produto.Estoque = Convert.ToInt32(reader["estoque_atual"]);
            produto.EstoqueMinimo = Convert.ToInt32(reader["estoque_minimo"]);

            reader.Close();

            return produto;
        }

        /// <summary>
        /// Lista todos os produtos.
        /// </summary>
        /// <returns></returns>
        public static List<Produto> CarregarProdutos() {
            var query = $"SELECT * from produto INNER JOIN fornecedor ON produto.codigo_fornecedor = fornecedor.id";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var produto = new Produto();
            var list = new List<Produto>();

            while (reader.Read()) {
                produto.ID = (int)reader["id"];
                produto.Codigo = (string)reader["codigo"];
                produto.Descricao = (string)reader["descricao"];

                if (reader["codigo_fornecedor"] == DBNull.Value) {
                    produto.FornecedorID = 1;
                }
                else {
                    produto.FornecedorID = Convert.ToInt32(reader["codigo_fornecedor"]);
                }

                produto.Fornecedor = (string)reader["empresa"];
                produto.Fabricante = (string)reader["fabricante"];
                produto.PrecoCusto = Convert.ToDecimal(reader["preco_custo"]);
                produto.PrecoVenda = Convert.ToDecimal(reader["preco_venda"]);
                produto.MargemLucro = Convert.ToInt32(reader["margem_lucro"]);
                produto.Estoque = Convert.ToInt32(reader["estoque_atual"]);
                produto.EstoqueMinimo = Convert.ToInt32(reader["estoque_minimo"]);

                list.Add(produto);
                produto = new Produto();
            }

            reader.Close();
            return list;
        }

        /// <summary>
        /// Atualiza para nenhum fornecedor quand algum fornecedor é deletado.
        /// </summary>
        /// <param name="fornecedorID"></param>
        /// <returns></returns>
        public static int AtualizarFornecedor(int fornecedorID) {
            var query = $"UPDATE produto SET codigo_fornecedor='1' WHERE codigo_fornecedor='{fornecedorID}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var result = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return result;
        }

        /// <summary>
        /// Retorna a quantidade de produtos.
        /// </summary>
        /// <returns></returns>
        public static int QuantidadeProduto() {
            var query = "SELECT COUNT(id) FROM produto";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteScalar();

            Configuration2.Connection.CloseConnection();

            return Convert.ToInt32(value);
        }
    }
}
