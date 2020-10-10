using System;
using System.Data;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class ProductBusiness
    {
        DataAccessSqlServer sqlServer = new DataAccessSqlServer();
        
        public DataTable LoadUnitType()
        {
            sqlServer.ParametersClear();
            DataTable dataTable = sqlServer.QueryExecute(CommandType.StoredProcedure, "spStockUnitTypeListAll");

            return dataTable;
        }

        public int Create(Product product)
        {
            try
            {
                sqlServer.ParametersClear();

                sqlServer.ParameterAdd("barcode", product.Barcode);
                sqlServer.ParameterAdd("description", product.Description);
                sqlServer.ParameterAdd("unit_type", product.UnitType.Id);
                sqlServer.ParameterAdd("minimum_quantity", product.MinimumQuantity);
                sqlServer.ParameterAdd("maximum_quantity", product.MaximumQuantity);
                sqlServer.ParameterAdd("current_quantity", product.CurrentQuantity);
                sqlServer.ParameterAdd("unit_cost", product.UnitCost);
                sqlServer.ParameterAdd("percentage_profit", product.PercentageProfit);
                sqlServer.ParameterAdd("sale_price", product.SalePrice);

                string productId = sqlServer.PersistenceExecute(CommandType.StoredProcedure, "spStockProductCreate").ToString();

                return Convert.ToInt32(productId);
            }catch(Exception error)
            {
                throw error;
            }
        }

        public DataTable Load()
        {
            sqlServer.ParametersClear();
            DataTable dataTable = sqlServer.QueryExecute(CommandType.StoredProcedure, "spStockProductListAll");

            return dataTable;
        }

        public int Update(Product product)
        {
            try
            {
                sqlServer.ParametersClear();

                sqlServer.ParameterAdd("id", product.Id);
                sqlServer.ParameterAdd("barcode", product.Barcode);
                sqlServer.ParameterAdd("description", product.Description);
                sqlServer.ParameterAdd("unit_type", product.UnitType.Id);
                sqlServer.ParameterAdd("minimum_quantity", product.MinimumQuantity);
                sqlServer.ParameterAdd("maximum_quantity", product.MaximumQuantity);
                sqlServer.ParameterAdd("current_quantity", product.CurrentQuantity);
                sqlServer.ParameterAdd("unit_cost", product.UnitCost);
                sqlServer.ParameterAdd("percentage_profit", product.PercentageProfit);
                sqlServer.ParameterAdd("sale_price", product.SalePrice);
                sqlServer.ParameterAdd("active", product.Active);

                string productId = sqlServer.PersistenceExecute(CommandType.StoredProcedure, "spStockProductUpdate").ToString();

                return Convert.ToInt32(productId);
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
