using Pharmacy_Management.utils.connections;
using Pharmacy_Management.utils.contexts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Pharmacy_Management.auth
{
    public class NewId
    {
        private static SqlConnection dbConnection = new SqlConnection(DbConfigs.connectionString);

        public static string company = "Comp-";
        public static string employee = "Emp-";
        public static string medicine = "Med-";
        public static string roles = "Role-";
        public static string login = "LG_new-";
        public static string bill = "Bill-";
        public static string sales = "Sale-";

        static int emp_num = MyAppContext.empIdNum;
        static int comp_num = MyAppContext.compIdNum;
        static int med_num = MyAppContext.medIdNum;
        static int role_num = MyAppContext.roleIdNum;
        static int log_num = MyAppContext.loginIdNum;
        static int bill_num = 1;
        static int sale_num = MyAppContext.saleId;


        public static int getLastId(string query, string column_name)
        {
            try
            {
                dbConnection.Open();
                SqlCommand command = new SqlCommand(query, dbConnection);
                SqlDataReader reader = command.ExecuteReader();

                List<int> ids = new List<int>();

                while (reader.Read())
                {
                    string saleId = reader[column_name].ToString();
                    string[] parts = saleId.Split('-');
                    if (parts.Length > 1)
                    {
                        int lastIdPart = Convert.ToInt32(parts[1]);
                        ids.Add(lastIdPart);
                    }
                }

                dbConnection.Close();

                if (ids.Count > 0)
                {
                    // Sort the IDs in descending order
                    ids.Sort();
                    ids.Reverse();

                    // Return the largest ID
                    return ids[0];
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred while getting the last ID: " + ex.Message);
                return -1;
            }
            finally
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                    dbConnection.Close();
            }
        }

        public static string UniqueId(string inp)
        {
            if (inp == company)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(comp_num++);
                Console.WriteLine(newIdString);

                // Return the id
                return newIdString;
            }
            else if (inp == employee)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(emp_num++);
                Console.WriteLine(newIdString);

                // Return the id
                return newIdString;
            }
            else if (inp == medicine)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(med_num++);
                Console.WriteLine(newIdString);

                // Return the id
                return newIdString;
            }
            else if (inp == roles)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(role_num++);
                Console.WriteLine(newIdString);

                // Return the id
                return newIdString;
            }
            else if (inp == login)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(log_num++);
                Console.WriteLine(newIdString);

                // Return the id
                return newIdString;
            }
            else if (inp == bill)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(bill_num++);
                Console.WriteLine(newIdString);

                // Return the id
                return newIdString;
            }
            else if (inp == sales)
            {
                // Convert the UUID to a string representation
                string newIdString = inp + Convert.ToString(sale_num++);

                // Update the saleId in MyAppContext
                MyAppContext.saleId = sale_num;

                // Return the id
                return newIdString;
            }
            else
            {
                return string.Empty;
            }
        }

        //public static string UniqueId(string inp)
        //{
        //    int incrementedId = -1;
        //    string prefix = "";

        //    switch (inp)
        //    {
        //        case "Comp":
        //            incrementedId = ++MyAppContext.compIdNum;
        //            prefix = "Comp-";
        //            break;
        //        case "Emp":
        //            incrementedId = ++MyAppContext.empIdNum;
        //            prefix = "Emp-";
        //            break;
        //        case "Med":
        //            incrementedId = ++MyAppContext.medIdNum;
        //            prefix = "Med-";
        //            break;
        //        case "Role":
        //            incrementedId = ++MyAppContext.roleIdNum;
        //            prefix = "Role-";
        //            break;
        //        case "LG_new":
        //            incrementedId = ++MyAppContext.loginIdNum;
        //            prefix = "LG_new-";
        //            break;
        //        case "Bill":
        //            incrementedId = ++MyAppContext.billIdNum;
        //            prefix = "Bill-";
        //            break;
        //        case "Sale":
        //            incrementedId = ++MyAppContext.saleId;
        //            prefix = "Sale-";
        //            break;
        //    }

        //    if (incrementedId != -1)
        //    {
        //        string newIdString = prefix + Convert.ToString(incrementedId);
        //        Console.WriteLine(newIdString);
        //        return newIdString;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input for ID generation.");
        //        return string.Empty;
        //    }
        //}
    }
}
