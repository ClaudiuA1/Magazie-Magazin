using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Services;

namespace Tema2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        public String connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\claudiu\\Desktop\\Facultate\\An3\\II\\Tema2\\WindowsFormsApp1\\Database1.mdf;Integrated Security=True";

        [WebMethod]
        public string adaugaMagazie(String Nume, int Cantitate)
        {
            if (Cantitate < 0)
            {
                return "Adaugati cantitate validat!";
            }
            try
            {
                string sql = "insert into Magazie(NumeProdus,BucatiProdus) values (@nume,@cantitate)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@nume", Nume);
                        command.Parameters.AddWithValue("@cantitate", Cantitate);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                    }
                }

                return "Adaugare reusita!";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }
        [WebMethod]
        public string updateMagazie(String NumeProdus, int Cantitate)
        {
            try
            {
                string checkProdus = "select count (*) from Magazie where NumeProdus=@nume";
                string sql = "update Magazie set BucatiProdus=@cantitate where NumeProdus=@NumeProdus";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand commandCheck = new SqlCommand(checkProdus, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@nume", NumeProdus);
                        int check1 = (int)commandCheck.ExecuteScalar();
                        if (check1 > 0)
                        {
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@cantitate", Cantitate);
                                command.Parameters.AddWithValue("@NumeProdus", NumeProdus);


                                command.ExecuteNonQuery();
                                connection.Close();

                                return "Magazie actualizata!";
                            }
                        }
                        else
                        {
                            connection.Close();
                            return "Produsul nu exista in Magazie!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        [WebMethod]
        public string stergeMagazie(int ProdusId)
        {
            string sql = "delete from Magazie where ProdusId=@id";
            string check = "select count (*) from Magazie where ProdusId=@id";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand commandCheck = new SqlCommand(check, connection))
                    {
                        commandCheck.Parameters.AddWithValue("@id", ProdusId);
                        int check1 = (int)commandCheck.ExecuteScalar();
                        if (check1 > 0)
                        {
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@id", ProdusId);


                                command.ExecuteNonQuery();
                                connection.Close();

                                return "Produsul s-a sters din Magazie";
                            }
                        }
                        else
                        {
                            connection.Close();
                            return "Id-ul produsului nu exista in Magazie!";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        [WebMethod]
        public string plaseazaComanda(string NumeProdus, int Bucati)
        {
            try
            {
                string sql = "insert into Comenzi (NumeProdus,Cantitate, Data) values (@nume,@bucati,@data)";
                string checkProdus = "select count (*) from Magazie where NumeProdus=@nume and BucatiProdus>=@bucati";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand checkCommand = new SqlCommand(checkProdus, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@nume", NumeProdus);
                        checkCommand.Parameters.AddWithValue("@bucati", Bucati);
                        connection.Open();

                        int check = (int)checkCommand.ExecuteScalar();
                        if (check > 0)
                        {
                            int stock = 0;
                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@nume", NumeProdus);
                                command.Parameters.AddWithValue("@bucati", Bucati);
                                command.Parameters.AddWithValue("@data", DateTime.Now);

                                command.ExecuteNonQuery();
                                string update = "select BucatiProdus from Magazie where NumeProdus=@nume";
                                using (SqlCommand getCommand = new SqlCommand(update, connection))
                                {
                                    getCommand.Parameters.AddWithValue("@nume", NumeProdus);

                                    object result = getCommand.ExecuteScalar();
                                    stock = Convert.ToInt32(result);
                                }
                                updateMagazie(NumeProdus, (stock - Bucati));
                                connection.Close();
                                return "Comanda a fost plasata!";
                            }
                        }
                        else
                        {
                            connection.Close();
                            return "Stoc insuficient sau Nume produs gresit!";
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public DataTable updateMagazie(string tableName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "select * from " + tableName;
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();

                        DataTable dataTable = new DataTable();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null; 
            }
        }

    }

}
