using System;
using System.Data;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class SaleBusiness
    {
        DataAccessSqlServer sqlServer = new DataAccessSqlServer();

        public int Create(Sale sale)
        {
            try
            {
                sqlServer.ParametersClear();
                sqlServer.ParameterAdd("id_user", sale.User.Id);
                sqlServer.ParameterAdd("total_sale", sale.Total);
                sqlServer.ParameterAdd("discount", sale.Discount);

                string saleId = sqlServer.PersistenceExecute(CommandType.StoredProcedure, "spSalesHistoryCreate").ToString();

                foreach (Product product in sale.Products)
                {
                    sqlServer.ParametersClear();
                    sqlServer.ParameterAdd("id_sale", saleId);
                    sqlServer.ParameterAdd("id_product", product.Id);
                    sqlServer.ParameterAdd("quantity", product.Quantity);
                    sqlServer.ParameterAdd("price", product.SalePrice);
                    sqlServer.ParameterAdd("id_user", sale.User.Id);

                    sqlServer.PersistenceExecute(CommandType.StoredProcedure, "spSalesItemsCreate").ToString();
                }


                return Convert.ToInt32(saleId);
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DataTable HistorySearch(string Description, DateTime DateAt, DateTime DateFrom, bool Action)
        {
            sqlServer.ParametersClear();
            sqlServer.ParameterAdd("description_product", Description);
            sqlServer.ParameterAdd("dateAt", DateAt);
            sqlServer.ParameterAdd("dateFrom", DateFrom);
            sqlServer.ParameterAdd("action", Action);

            DataTable dataTable = sqlServer.QueryExecute(CommandType.StoredProcedure, "spStockHistoryList");

            return dataTable;
        }
    }
}
