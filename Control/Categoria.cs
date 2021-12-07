using System.Data.SQLite;
namespace CRUD_CONSOLE
{
    public class Categorias
    {
        public void ListarCategorias()
        {
            ConexaoSQLite conexaoSQLite = new ConexaoSQLite();
            using(SQLiteConnection sqLiteConn = new SQLiteConnection(conexaoSQLite.StringConexaoSQLite()))
            {
                sqLiteConn.Open();
                string sSQL = "select * from categorias";
                SQLiteCommand cmd = new SQLiteCommand(sSQL, sqLiteConn);
                using(SQLiteDataReader dr = cmd.ExecuteReader())

                while(dr.Read())
                {
                    Console.WriteLine($"ID: {dr["id"]} Nome: {dr["nome"]}");
                }
            }            
        } 

        public void IncluirCategoria( int id, string? nome)
        {
            ConexaoSQLite conexaoSQLite = new ConexaoSQLite();
            using(SQLiteConnection sqLiteConn = new SQLiteConnection(conexaoSQLite.StringConexaoSQLite()))
            {
                sqLiteConn.Open();
                string sSQL = "insert into categorias(id, nome) values(@id, @nome)";
                SQLiteCommand cmd = new SQLiteCommand(sSQL, sqLiteConn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome",nome);
                cmd.ExecuteNonQuery();
            }    
        }

        public void ExcluirCategoria(int id)
        {
            ConexaoSQLite conexaoSQLite = new ConexaoSQLite();
            using(SQLiteConnection sQLiteConnection = new SQLiteConnection(conexaoSQLite.StringConexaoSQLite()))
            {
                sQLiteConnection.Open();
                string sSQL = "delete from categorias where id =@id";
                SQLiteCommand cmd = new SQLiteCommand(sSQL,sQLiteConnection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }       
    }
}