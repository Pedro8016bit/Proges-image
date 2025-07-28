using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProGEs
{
    class Usuarios
    {
        private string nome;
        private string tipo;
        private string email;
        private string senha;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public bool CriarUser()
        {
            try
            {
                if (!verificarEmail(Email))
                {
                    MessageBox.Show("E-mail inválido. Digite um e-mail válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string SenhaCriptografada = CriptografarSenha(Senha);

                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    string inserir = "insert into usuarios (nome_usuario, tipo_usuario, email, senha) value (@nome_usuario, @tipo_usuario, @email, @senha)";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@nome_usuario", Nome);
                    comando.Parameters.AddWithValue("@tipo_usuario", Tipo);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", SenhaCriptografada);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o usuário. Verifique os dados e tente novamente.", "Falha no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha ?? ""));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                        builder.Append(b.ToString("x2"));
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }
    }
}
