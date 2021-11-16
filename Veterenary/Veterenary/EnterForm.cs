using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterenary.DB;

namespace Veterenary
{
    public partial class EnterForm : Form
    {
        public MainForm MF { get; set; } 
        public EnterForm()
        {
            InitializeComponent();
        }

        private void EnterBotton_Click(object sender, EventArgs e)
        {
            string login = LoginTB.Text;
            string pass = PassTB.Text;

            if (login == "admin" && pass == "admin")
            {
                AuthUser.id = 0;
                if (MF == null) { MF = new MainForm(); }
                MF.Text = "Администратор";
                MF.EF = this;
                MF.MFRefresh();
                MF.Show();
                this.LoginTB.Clear();
                this.PassTB.Clear();
                this.Hide();
            }
            else
            {
                DBAuth da = new DBAuth();
                DataTable table = da.Auth(login, pass);
                if (Convert.ToInt32(table.Rows.Count) != 0)
                {
                    AuthUser.id = Convert.ToInt32(table.Rows[0]["id"]);
                    if (MF == null) { MF = new MainForm(); }
                    MF.Text = Convert.ToString(table.Rows[0]["fio"]);
                    MF.EF = this;
                    MF.MFRefresh();
                    MF.Show();
                    this.LoginTB.Clear();
                    this.PassTB.Clear();
                    this.Hide();
                }
                else { MessageBox.Show("Неверно введён логин и/или пароль!", "Ошибка"); }
            }
        }
    }
}
