namespace CRUD_CONSOLE
{
    public class ConexaoSQLite
    {
        public string StringConexaoSQLite()
        {
            string strConexao = @"Data Source=./Database/dbcrudconsole.db3; Version=3;";
            return strConexao;
        }        
    }    
}