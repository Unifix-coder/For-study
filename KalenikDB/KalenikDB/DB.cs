using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//директория необходимая для работы с MySQL
using MySql.Data.MySqlClient;

namespace KalenikDB
{
    //Класс для открытия и закрытия соединения с бд 
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;user=root;password=12Q24F45Gbluerose;database=mydb");

        //Две похожих функции для открытия и закрытия соединения с условием проверки открытости/закрытости соединения
        public void openDBConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeDBConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        //Возвращение объекта connection
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
