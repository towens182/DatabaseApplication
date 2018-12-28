using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace Music_Store
{
    public class DBconnection
    {
        private string connectionStr = ""; //DB connection string
        MySqlConnection cnn;
        string path = @""; //Path to log file on local

        public DBconnection()
        {
            cnn = new MySqlConnection(connectionStr);
            cnn.Open();
            // MessageBox.Show("Connection Success");
        }

        ~DBconnection() { cnn.Close(); }

        public void AddEmployee(string last, string first, string address, int phone, string dob,
            string department, double wage, string store, string job)
        {
            string[] location = store.Split(new string[] { ", " }, StringSplitOptions.None);

            MySqlCommand comm = cnn.CreateCommand();
            comm.CommandText = "INSERT INTO music_store.employee(last_name, first_name, address, phone_number, DOB, department_name, wage, store_id, job_title, hire_date) " +
                "VALUES(?last_name, ?first_name, ?address, ?phone_number, ?DOB, ?department_name, ?wage, ?store_id, ?job_title, ?hire_date)";

            comm.Parameters.AddWithValue("@last_name", last);
            comm.Parameters.AddWithValue("@first_name", first);
            comm.Parameters.AddWithValue("@address", address);
            comm.Parameters.AddWithValue("@phone_number", phone);
            comm.Parameters.AddWithValue("@DOB", dob);
            comm.Parameters.AddWithValue("@department_name", GetDepId(department));
            comm.Parameters.AddWithValue("@wage", wage);
            comm.Parameters.AddWithValue("@store_id", GetStoreID(location[0], location[1]));
            comm.Parameters.AddWithValue("@job_title", GetJobId(job));
            comm.Parameters.AddWithValue("@hire_date", DateTime.Now.ToString("yyyy-MM-dd"));
            File.AppendAllText(path, comm.CommandText + Environment.NewLine);
            comm.ExecuteNonQuery();
        }

        public DataTable SearchInstruments(string conditions)
        {
            String comm = "SELECT make as Make, model as Model, type as Type, color as Color, name as Department, price as Price FROM music_store.instrument INNER JOIN department ON department_name = id_department";

            comm = comm + " " + conditions;

            File.AppendAllText(path, comm+Environment.NewLine);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            return dtRecord;
        }

        public DataTable ViewEmployees()
        {
            String comm = "SELECT employee_id as ID, first_name as First, last_name as Last, address as Address, employee.phone_number as Phone, DOB, department.name as Department," +
                "wage as Wage, jobs.name as Job, store.city as City, store.state as State from employee INNER JOIN department ON department_name=id_department INNER JOIN jobs ON job_title=idjobs INNER JOIN store ON employee.store_id=store.store_id ORDER BY id;";
            File.AppendAllText(path, comm + Environment.NewLine);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            return dtRecord;
        }

        public int GetStoreID(string city, string state)
        {
            int store_id = 0;

            String comm = "SELECT store_id from music_store.store WHERE store.city ="
                + "\"" + city + "\"" + "&& store.state = \"" + state + "\";";
            File.AppendAllText(path, comm+Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    store_id = Int32.Parse(reader.GetString("store_id"));
                }
            }
            return store_id;
        }

        public int GetDepId(string department)
        {
            int dep_id = 0;

            String comm = "SELECT id_department from music_store.department WHERE department.name=";

            comm = comm + "\"" + department + "\"";
            File.AppendAllText(path, comm+Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dep_id = Int32.Parse(reader.GetString("id_department"));
                }
            }
            return dep_id;

        }

        public int GetJobId(string name)
        {
            int job_id = 0;

            String comm = "SELECT idjobs from music_store.jobs WHERE jobs.name=";

            comm = comm + "\"" + name + "\"";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    job_id = Int32.Parse(reader.GetString("idjobs"));
                }
            }
            return job_id;
        }

        public void FillDepartmentName(ComboBox myComboBox, List<string> list)
        {
            String comm = "SELECT name from music_store.department";
            File.AppendAllText(path, comm+Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    myComboBox.Items.Add(reader.GetString("name"));
                }
            }
        }

        public void FillDepartmentInstrumentPage(ComboBox myComboBox, List<string> list)
        {
            String comm = "SELECT name from music_store.department WHERE department.name !='HR' AND department.name !='Maintenance' AND department.name !='Management';";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    myComboBox.Items.Add(reader.GetString("name"));
                }
            }
        }

        public void FillJobTitles(ComboBox myComboBox, List<string> list)
        {
            String comm = "SELECT name from music_store.jobs";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    myComboBox.Items.Add(reader.GetString("name"));
                }
            }
        }

        public void FillStores(ComboBox myComboBox, List<string> list)
        {
            String comm = "SELECT city, state from music_store.store";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    string location = "";
                    location = location + reader.GetString("city");
                    location = location + ", ";
                    location = location + reader.GetString("state");
                    myComboBox.Items.Add(location);
                }
            }
        }

        public void FillColors(ComboBox myComboBox, List<string> list)
        {
            String comm = "SELECT DISTINCT color from music_store.instrument ORDER BY color";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    myComboBox.Items.Add(reader.GetString("color"));
                }
            }
        }

        public int FillPrice()
        {
            int price = 0;
            String comm = "SELECT max(price) as price from music_store.instrument";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    price = Int32.Parse((reader.GetString("price")));
                }
            }
            return price;
        }

        public void DeleteEmployee(string id)
        {
            String comm = "DELETE FROM employee WHERE employee_id =" + id + ";";
            File.AppendAllText(path, comm +Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;

            cmd.ExecuteNonQuery();
        }

        public void UpdateEmployee(string conditions, string id)
        {
            if (conditions == null)
            {
                return;
            }
            string comm = "UPDATE employee " + conditions + " WHERE employee_id= \"" + id + "\";";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;

            cmd.ExecuteNonQuery();
        }

        public DataSet GetEmployeeInfo(string id)
        {
            DataSet ds = new DataSet();

            String comm = "SELECT employee_id as ID, first_name as First, last_name as Last, address as Address, employee.phone_number as Phone, DOB, department.name as Department," +
                "wage as Wage, jobs.name as Job, store.city as City, store.state as State, hire_date as Hire, dob as DOB from employee INNER JOIN department ON department_name=id_department INNER JOIN jobs ON job_title=idjobs" +
                " INNER JOIN store ON employee.store_id=store.store_id WHERE employee_id=\"" + id + "\";";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            sqlDataAdap.Fill(ds);

            return ds;
        }
        
        public DataSet GetStoreDetails(int id)
        {
            DataSet ds = new DataSet();

            String comm = "SELECT store.store_id, city, state, store.phone_number, first_name, last_name, avg(wage) as avgWage, " +
                "(SELECT count(*) from employee where store.store_id = employee.store_id) as numEmp, " +
                "(SELECT round(avg(datediff(Now(), hire_date)) / 365, 2)) as avgTenure FROM music_store.store " +
                "INNER JOIN employee on store.manager = employee.employee_id WHERE store.store_id =\"" + id + "\";";
            File.AppendAllText(path, comm + Environment.NewLine);

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            sqlDataAdap.Fill(ds);

            return ds;
        }

        public String GetInstrumentSoldName(String id)
        {
            String instrumentName = "No Sales";
            String comm = "SELECT max(instrument.price), instrument.make, instrument.model FROM sale INNER JOIN sale_item ON sale.transaction_number = sale_item.transaction_number INNER JOIN instrument ON sale_item.id_instrument = instrument.id INNER JOIN store ON sale.store_id = store.store_id Where store.store_id =\"" + id + "\";";
            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            using (var reader = cmd.ExecuteReader())
            {
                //Iterate through the rows and add it to the combobox's items
                while (reader.Read())
                {
                    if (!reader.IsDBNull(2))
                    {
                        instrumentName = reader.GetString("make") + " " + reader.GetString("model");
                    }
                }
            }
            return instrumentName;
        }

        public DataSet GetTopEmployeeDetails(String id)
        {
            DataSet ds = new DataSet();
            String comm = "SELECT max(t.count) as count, t.last_name, t.first_name from(SELECT count(sale.transaction_number) as count, employee.last_name, employee.first_name, sale.transaction_number, employee.store_id FROM employee INNER JOIN sale ON sale.employee_id = employee.employee_id INNER JOIN store on employee.store_id = store.store_id WHERE store.store_id =" + id + " GROUP BY employee.employee_id) as t";

            File.AppendAllText(path, comm + Environment.NewLine);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = this.cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comm;
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            sqlDataAdap.Fill(ds);

            return ds;
        }
    }
}
