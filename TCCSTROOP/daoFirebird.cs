using System;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace fireBirdWin
{
    /// <summary>
    /// Usa padrão Singleton para obter uma instancia do FireBird
    /// </summary>
    public class daoFireBird
    {
        private static readonly daoFireBird instanciaFireBird = new daoFireBird();

        private daoFireBird() { }

        public static daoFireBird getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {

            string connectionDataSource = "DataSource=localhost; ";
            string connectionDatabase = "Database=" + System.Environment.CurrentDirectory + "\\BancoStroop.fdb; ";
            string connectionUser = "User=sysdba; Password=masterkey";
            string conn = connectionDataSource + connectionDatabase + connectionUser;
            return new FbConnection(conn);
        }
    }
}