using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterenary.DB
{
    class DBConnect
    {
        private static DBConnect instance;

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=admin;database=mydb");

        public void openConnection()
        {
            if (instance.connection.State == System.Data.ConnectionState.Closed)
                instance.connection.Open();
        }

        public void closeConection()
        {
            if (instance.connection.State == System.Data.ConnectionState.Open)
                instance.connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return instance.connection;
        }

        public static DBConnect GetInstance()
        {
            if (instance == null) { instance = new DBConnect(); }
            return instance;
        }
    }
    class DBAuth
    {
        private DBConnect db = DBConnect.GetInstance();

        private DataTable table = new DataTable();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public DataTable Auth(string login, string pass)
        {
            MySqlCommand command = new MySqlCommand($"select doctors.id, concat(`doctors`.`last_name`,' ',`doctors`.`first_name`,' ',`doctors`.`second_name`) as fio from doctors where doctors.login = @ul and doctors.password = @up", db.GetConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }

    class DBGet
    {
        private DBConnect db = DBConnect.GetInstance();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public DataTable GetDoctors()
        {
            MySqlCommand command = new MySqlCommand("select * from v_doctors",db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetCategories()
        {
            MySqlCommand command = new MySqlCommand("select * from v_categories", db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetServices()
        {
            MySqlCommand command = new MySqlCommand("select * from v_services", db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int GetCatDoctorCount(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_catdoctors where ID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0]["COUNT"]);
        }
        public DataTable GetOwners()
        {
            MySqlCommand command = new MySqlCommand("select * from v_owners", db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int GetDocVisitCount(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_docvisits where ID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0]["COUNT"]);
        }

        public int GetServVisitsCount(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_servvisits where ID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0]["COUNT"]);
        }

        public int GetOwnerPetsCount(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_ownerpets where ID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0]["COUNT"]);
        }

        public DataTable GetOwnerPets(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_pets where PID = @id",db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetPets()
        {
            MySqlCommand command = new MySqlCommand("select * from v_pets", db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public int GetPetVisits(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_petvisits where ID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0]["COUNT"]);
        }

        public DataTable GetVac()
        {
            MySqlCommand command = new MySqlCommand("select * from v_vaccinations", db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetPetVac(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_vaccinations where PID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetVisits(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_visits where DOC_ID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetVisServs(int id)
        {
            MySqlCommand command = new MySqlCommand("select * from v_visitservices where VID = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable GetHolVisServs()
        {
            MySqlCommand command = new MySqlCommand("select * from v_visitservices where VID = 0", db.GetConnection());
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }

    class DBAdd
    {
        private DBConnect db = DBConnect.GetInstance();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public void CatAdd(string numb, string name, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into categories (cat_level, cat_name) values (@numb, @name)", db.GetConnection());
            command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = numb;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void DocAdd(string[] str, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into doctors (last_name, first_name, second_name, login, password, category_id) values (@last_name, @first_name, @second_name, @login, @password, @cat_id)", db.GetConnection());
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = str[0];
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = str[1];
            command.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = str[2];
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = str[3];
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = str[4];
            command.Parameters.Add("@cat_id", MySqlDbType.VarChar).Value = str[5];

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void ServAdd(string name, string price, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into services (service_name, price) values (@name, @price)", db.GetConnection());
            command.Parameters.Add("@name",MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = price;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void OwnerAdd(string[] str, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into owners (last_name, first_name, second_name, contact_number) values (@last_name, @first_name, @second_name, @number)", db.GetConnection());
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = str[0];
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = str[1];
            command.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = str[2];
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = str[3];

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void PetAdd(string[] str, int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into pets (name, pet_type, owner_id) values (@name, @type, @pid)", db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = str[0];
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = str[1];
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void VacAdd(string[] str, int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into vaccinations (pet_id, vac_type, vac_date) values (@pid, @type, @date)", db.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = str[0];
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = str[1];
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void VisitAdd(string[] str, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into visits (visit_date, doctor_id, pet_id, total_sum) values (@date, @did, @pid, 0)", db.GetConnection());
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = str[0];
            command.Parameters.Add("@did", MySqlDbType.VarChar).Value = str[1];
            command.Parameters.Add("@pid", MySqlDbType.VarChar).Value = str[2];

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void ServVisAdd(int[] i, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("insert into visitservices (visit_id, service_id) values (@vid, @sid)", db.GetConnection());
            command.Parameters.Add("@vid", MySqlDbType.VarChar).Value = i[0];
            command.Parameters.Add("@sid", MySqlDbType.VarChar).Value = i[1];

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlCommand command1 = new MySqlCommand("update visits set total_sum = @sum where visits.id = @id", db.GetConnection());
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = i[0];
            command1.Parameters.Add("@sum", MySqlDbType.VarChar).Value = i[2];
            DataTable table1 = new DataTable();

            adapter.SelectCommand = command1;
            adapter.Fill(table1);
        }
    }

    class DBAlter
    {
        private DBConnect db = DBConnect.GetInstance();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public void CatAlter(string[] s, int id, DataTable table)
        {
            StringBuilder param = new StringBuilder();
            string com;

            if (s[0] != "")
            {
                if (param.ToString() != "") { param.Append(", cat_level = @numb"); }
                else { param.Append("cat_level = @numb"); }
            }
            if (s[1] != "")
            {
                if (param.ToString() != "") { param.Append(", cat_name = @name"); }
                else { param.Append("cat_name = @name"); }
            }

            com = $"update categories set {param} where categories.id = @id";

            MySqlCommand command = new MySqlCommand(com, db.GetConnection());

            command.Parameters.Add("@numb", MySqlDbType.VarChar).Value = s[0];
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = s[1];
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void DocDAlter(string[] s, int id, DataTable table)
        {
            StringBuilder param = new StringBuilder();
            string com;

            if (s[0] != "")
            {
                if (param.ToString() != "") { param.Append(", last_name = @last_name"); }
                else { param.Append("last_name = @last_name"); }
            }
            if (s[1] != "")
            {
                if (param.ToString() != "") { param.Append(", first_name = @first_name"); }
                else { param.Append("first_name = @first_name"); }
            }
            if (s[2] != "")
            {
                if (param.ToString() != "") { param.Append(", second_name = @second_name"); }
                else { param.Append("second_name = @second_name"); }
            }
            if (s[3] != "")
            {
                if (param.ToString() != "") { param.Append(", login = @login"); }
                else { param.Append("login = @login"); }
            }
            if (s[4] != "")
            {
                if (param.ToString() != "") { param.Append(", password = @pass"); }
                else { param.Append("password = @pass"); }
            }

            com = $"update doctors set {param} where doctors.id = @id";

            MySqlCommand command = new MySqlCommand(com, db.GetConnection());
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = s[0];
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = s[1];
            command.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = s[2];
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = s[3];
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = s[4];
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void DocCAlter(int id, int cid, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("update doctors set doctors.category_id = @cid where doctors.id = @id", db.GetConnection());
            command.Parameters.Add("@cid", MySqlDbType.VarChar).Value = cid;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void ServAlter(string[] s, int id, DataTable table)
        {
            StringBuilder param = new StringBuilder();
            string com;

            if (s[0] != "")
            {
                if (param.ToString() != "") { param.Append(", service_name = @name"); }
                else { param.Append("service_name = @name"); }
            }
            if (s[1] != "")
            {
                if (param.ToString() != "") { param.Append(", price = @price"); }
                else { param.Append("price = @price"); }
            }

            com = $"update services set {param} where services.id = @id";

            MySqlCommand command = new MySqlCommand(com, db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = s[0];
            command.Parameters.Add("@price", MySqlDbType.VarChar).Value = s[1];
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void OwnerAlter(string[] s, int id, DataTable table)
        {
            StringBuilder param = new StringBuilder();
            string com;

            if (s[0] != "")
            {
                if (param.ToString() != "") { param.Append(", last_name = @last_name"); }
                else { param.Append("last_name = @last_name"); }
            }
            if (s[1] != "")
            {
                if (param.ToString() != "") { param.Append(", first_name = @first_name"); }
                else { param.Append("first_name = @first_name"); }
            }
            if (s[2] != "")
            {
                if (param.ToString() != "") { param.Append(", second_name = @second_name"); }
                else { param.Append("second_name = @second_name"); }
            }
            if (s[3] != "")
            {
                if (param.ToString() != "") { param.Append(", contact_number = @number"); }
                else { param.Append("contact_number = @number"); }
            }

            com = $"update owners set {param} where owners.id = @id";

            MySqlCommand command = new MySqlCommand(com, db.GetConnection());
            command.Parameters.Add("@last_name", MySqlDbType.VarChar).Value = s[0];
            command.Parameters.Add("@first_name", MySqlDbType.VarChar).Value = s[1];
            command.Parameters.Add("@second_name", MySqlDbType.VarChar).Value = s[2];
            command.Parameters.Add("@number", MySqlDbType.VarChar).Value = s[3];
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void PetAlter(string[] s, int id, DataTable table)
        {
            StringBuilder param = new StringBuilder();
            string com;

            if (s[0] != "")
            {
                if (param.ToString() != "") { param.Append(", name = @name"); }
                else { param.Append("name = @name"); }
            }
            if (s[1] != "")
            {
                if (param.ToString() != "") { param.Append(", pet_type = @type"); }
                else { param.Append("pet_type = @type"); }
            }
            com = $"update pets set {param} where pets.id = @id";

            MySqlCommand command = new MySqlCommand(com, db.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = s[0];
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = s[1];
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
        
        public void VacAlter(string[] s, int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("update vaccinations set vac_date = @date, vac_type = @type where vaccinations.id = @id", db.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = s[0];
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = s[1];
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
    }

    class DBDell
    {
        private DBConnect db = DBConnect.GetInstance();

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        public void CatDel(int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from categories where categories.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void DocDel(int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from doctors where doctors.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void ServDel(int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from services where services.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }
        
        public void OwnerDel(int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from owners where owners.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void PetDel(int id, DataTable table)
        {
            MySqlCommand command1 = new MySqlCommand("delete from vaccinations where vaccinations.pet_id = @id", db.GetConnection());
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table1 = new DataTable();

            adapter.SelectCommand = command1;
            adapter.Fill(table1);

            MySqlCommand command = new MySqlCommand("delete from pets where pets.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void VacDel(int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from vaccinations where vaccinations.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);
        }

        public void ServVisDel(int[] i, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from visitservices where visitservices.id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = i[1];

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlCommand command1 = new MySqlCommand("update visits set total_sum = @sum where visits.id = @id", db.GetConnection());
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = i[0];
            command1.Parameters.Add("@sum", MySqlDbType.VarChar).Value = i[2];
            DataTable table1 = new DataTable();

            adapter.SelectCommand = command1;
            adapter.Fill(table1);
        }

        public void VisDel(int id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("delete from visitservices where visitservices.visit_id = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            MySqlCommand command1 = new MySqlCommand("delete from visits where visits.id = @id", db.GetConnection());
            command1.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            DataTable table1 = new DataTable();

            adapter.SelectCommand = command1;
            adapter.Fill(table1);
        }
    }
}
