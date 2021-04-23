using Microsoft.Data.Sqlite;
using System;
using System.IO;

namespace AppKiosco.Controllers
{
    class SQLiteService
    {
        private string DB_PATH = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.ToString() + "\\db\\" + "app_kiosco.sqlite";

        public string InsertPay(models.Payment payment) {
            string result = "";
            try {
                string query = "INSERT INTO payments (customer, account, debt, paid, date) ";
                query = query + " VALUES (";
                query = query + "'" + payment.customer + "', '" + payment.account + "',";
                query = query + payment.debt + ", " + payment.paid + ", '" + payment.date + "');";

                SqliteConnection sqlite = new SqliteConnection("Filename = " + DB_PATH);
                sqlite.Open();
                SqliteCommand cmd = sqlite.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                sqlite.Close();

                result = "OK";
            }catch (Exception e) {
                result = e.Message;
            }

            return result;
        }
    }
}
