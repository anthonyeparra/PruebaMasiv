using Dapper;
using MySql.Data.MySqlClient;
using PruebaMasiv.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMasiv.Repositories
{
    public class SalesTableRepository : ISalesTableRepository
    {

        private MySQLConfiguration _connectionString;
        public SalesTableRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public async Task<string> InsertSales(SalesTableModel saleTable)
        {
            string message = "No se pudo la venta";
            var db = dbConnection();
            float convertPercentaje = 100;
            float percentaje = GetDiscountByConsole(saleTable.Console).Result;
            float resultado = percentaje / convertPercentaje;
            float resultDiscount = saleTable.Value * resultado;
            float discount = saleTable.Value - resultDiscount;
            string sql = @"INSERT INTO sales_table (console,value,discount) VALUES (@console,@value,@discount)";
            var result = await db.ExecuteAsync(sql, new { saleTable.Console, saleTable.Value, discount });
            if (result > 0)
            {
                message = "Valor a cobrar Cliente es:" + discount ;
            }
            return message;
        }

        public async Task<float> GetDiscountByConsole(string console)
        {
            var db = dbConnection();
            string sql = String.Format(@"SELECT  dl.discounts FROM discount_list dl WHERE dl.console LIKE '%{0}%'", console);
            return await db.QueryFirstAsync<float>(sql, new { });
        }

        public Task<float> GetDiscountSales()
        {
            var db = dbConnection();
            string sql = @"SELECT SUM(st.discount) as SumDiscount FROM sales_table st";
            var resultSql = db.QueryFirstAsync<float>(sql, new { });
            float discountSales = resultSql.Result;
            return Task.FromResult(discountSales);
        }
    }
}
