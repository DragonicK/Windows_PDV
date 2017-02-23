using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Windows_PDV.Controller;

namespace Windows_PDV.Database {
    public class DBFornecedor {
        /// <summary>
        /// Verifica se o código já existe no banco.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool ExisteFornecedor(string codigo) {
            var query = $"SELECT id FROM fornecedor WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var read = reader.Read();

            reader.Close();
            Configuration2.Connection.CloseConnection();

            return read;
        }

        /// <summary>
        /// Retorna o ID do fornecedor.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static int FornecedorID(string codigo) {
            var query = $"SELECT id FROM fornecedor WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            reader.Read();

            var result = (int)reader["id"];

            reader.Close();
            Configuration2.Connection.CloseConnection();

            return result;
        }

        /// <summary>
        /// Deleta o fornecedor.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool DeletarFornecedor(string codigo) {
            var query = $"DELETE from fornecedor WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return Convert.ToBoolean(value);
        }

        /// <summary>
        /// Deleta todos os fornecedores.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static int DeletarFornecedores() {
            var query = $"DELETE from fornecedor WHERE codigo !='none'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return value;
        }

        /// <summary>
        /// Insere o novo fornecedor
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        public static bool InserirFornecedor(Fornecedor fornecedor) {
            var query = new StringBuilder();
            query.Append("INSERT INTO fornecedor");
            query.Append("(codigo, empresa, endereco, bairro, cidade, estado, cep, telefone, cnpj, ie, data_cadastro, email)");
            query.Append($" VALUES ('{fornecedor.Codigo}', '{fornecedor.Empresa}', '{fornecedor.Endereco}', '{fornecedor.Bairro}', ");
            query.Append($"'{fornecedor.Cidade}', '{fornecedor.Estado}', '{fornecedor.CEP}', '{fornecedor.Telefone}', '{fornecedor.CNPJ}', ");
            query.Append($"'{fornecedor.IE}', '{fornecedor.DataCadastro.ToString("yyyy/M/d hh:mm:ss")}', '{fornecedor.Email}')");

            var cmd = new MySqlCommand(query.ToString(), Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteNonQuery();

            Configuration2.Connection.CloseConnection();

            return Convert.ToBoolean(value);
        }

        /// <summary>
        /// Atualiza as informações do fornecedor
        /// </summary>
        /// <param name="fornecedor"></param>
        /// <returns></returns>
        public static bool AtualizarFornecedor(Fornecedor fornecedor, string codigo_velho) {
            var query = new StringBuilder();
            query.Append("UPDATE fornecedor SET ");
            query.Append($"codigo='{fornecedor.Codigo}', ");
            query.Append($"empresa ='{fornecedor.Empresa}', ");
            query.Append($"endereco ='{fornecedor.Endereco}', ");
            query.Append($"bairro ='{fornecedor.Bairro}', ");
            query.Append($"cidade ='{fornecedor.Cidade}', ");
            query.Append($"estado ='{fornecedor.Estado}', ");
            query.Append($"cep ='{fornecedor.CEP}', ");
            query.Append($"telefone ='{fornecedor.Telefone}', ");
            query.Append($"cnpj ='{fornecedor.CNPJ}', ");
            query.Append($"ie ='{fornecedor.IE}', ");
            query.Append($"data_cadastro ='{fornecedor.DataCadastro.ToString("yyyy/M/d hh:mm:ss")}', ");
            query.Append($"email ='{fornecedor.Email}'");
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
        public static Fornecedor CarregarFornecedor(string codigo) {
            var query = $"SELECT * from fornecedor WHERE codigo='{codigo}'";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            reader.Read();

            var fornecedor = new Fornecedor();
            fornecedor.Codigo = (string)reader["codigo"];
            fornecedor.Empresa = (string)reader["empresa"];
            fornecedor.Endereco = (string)reader["endereco"];
            fornecedor.Bairro = (string)reader["bairro"];
            fornecedor.Cidade = (string)reader["cidade"];
            fornecedor.Estado = (string)reader["estado"];
            fornecedor.CEP = (string)reader["cep"];
            fornecedor.Telefone = (string)reader["telefone"];
            fornecedor.CNPJ = (string)reader["cnpj"];
            fornecedor.IE = (string)reader["ie"];
            fornecedor.DataCadastro = Convert.ToDateTime(reader["data_cadastro"]);
            fornecedor.Email = (string)reader["email"];

            reader.Close();

            Configuration2.Connection.CloseConnection();

            return fornecedor;
        }

        /// <summary>
        /// Lista todos os fornecedores.
        /// </summary>
        /// <returns></returns>
        public static List<Fornecedor> CarregarFornecedores(bool semfornecedor) {
            var query = $"SELECT * from fornecedor";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var reader = cmd.ExecuteReader();
            var fornecedor = new Fornecedor();
            var list = new List<Fornecedor>();

            while(reader.Read()) {
                if (semfornecedor) {
                    if ((string)reader["codigo"] == "none") { continue; }
                }           

                fornecedor.ID = (int)reader["id"];
                fornecedor.Codigo = (string)reader["codigo"];
                fornecedor.Empresa = (string)reader["empresa"];
                fornecedor.Endereco = (string)reader["endereco"];
                fornecedor.Bairro = (string)reader["bairro"];
                fornecedor.Cidade = (string)reader["cidade"];
                fornecedor.Estado = (string)reader["estado"];
                fornecedor.CEP = (string)reader["cep"];
                fornecedor.Telefone = (string)reader["telefone"];
                fornecedor.CNPJ = (string)reader["cnpj"];
                fornecedor.IE = (string)reader["ie"];
                fornecedor.DataCadastro = Convert.ToDateTime(reader["data_cadastro"]);
                fornecedor.Email = (string)reader["email"];

                list.Add(fornecedor);
                fornecedor = new Fornecedor();
            }

            reader.Close();

            Configuration2.Connection.CloseConnection();

            return list;                 
        }

        /// <summary>
        /// Retorna a quantidade de fornecedores.
        /// </summary>
        /// <returns></returns>
        public static int QuantidadeFornecedor() {
            var query = $"SELECT COUNT(id) from fornecedor";
            var cmd = new MySqlCommand(query, Configuration2.Connection.Connection);

            Configuration2.Connection.OpenConnection();

            var value = cmd.ExecuteScalar();

            Configuration2.Connection.CloseConnection();

            // menos 1 pois já há um registro inserido como "sem fornecedor"
            return Convert.ToInt32(value) - 1;
        }
    }
}
