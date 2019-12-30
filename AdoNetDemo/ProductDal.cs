using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    class ProductDal
    {
        SqlConnection _sqlConnection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true"); // BAĞLANTI NESNESİ OLUŞTURDUK
        public List<Product> GetAll()
        {
            // AÇIK BAĞLANTI, TEKRAR AÇILIRSA SIKINTI ÇIKAR O YÜZDEN KONTROL EDİYORUZ
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", _sqlConnection); // (Sorgu,GönderilecekBağlantı)
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = Convert.ToString(sqlDataReader["Name"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"])
                };
                products.Add(product);
            }


            sqlDataReader.Close();
            _sqlConnection.Close();

            return products;
        }        

        public DataTable GetAll2()
        {
            // AÇIK BAĞLANTI, TEKRAR AÇILIRSA SIKINTI ÇIKAR O YÜZDEN KONTROL EDİYORUZ
            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products",_sqlConnection); // (Sorgu,GönderilecekBağlantı)

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader); // DOLDURMA İŞLEMİ

            sqlDataReader.Close();
            _sqlConnection.Close();

            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products VALUES(@name,@unitPrice,@stockAmount)",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name",product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Products SET Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount WHERE Id=@id",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id",product.Id);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Products WHERE Id=@id",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id",id);

            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        private void ConnectionControl()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }
    }
}
