using PruebaMasiv.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaMasiv.Repositories
{
    public interface ISalesTableRepository
    {
        Task<float> GetDiscountByConsole(string console);
        Task<float> GetDiscountSales();
        Task<string> InsertSales(SalesTableModel saleTable);
    }
}
