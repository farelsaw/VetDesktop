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
    public partial class ServForm : Form
    {
        public MainForm MF { get; set; }
        private DBGet dbGet = new DBGet();
        private DBAdd dbAdd = new DBAdd();
        private DBAlter dbAlter = new DBAlter();
        private DBDell dbDell = new DBDell();
        public ServForm()
        {
            InitializeComponent();
            DGServices.DataSource = dbGet.GetServices();
            DGServices.Columns[0].Visible = false;
            DGServices.Columns[1].Width = 230;
            DGServices.Columns[2].Width = 80;
        }

        private void ServForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ServAddButton_Click(object sender, EventArgs e)
        {
            if (ServNameTB.Text != "" && ServPriceTB.Text != "")
            {
                dbAdd.ServAdd(ServNameTB.Text, ServPriceTB.Text, (DataTable)DGServices.DataSource);
                DGServices.DataSource = dbGet.GetServices();
                MessageBox.Show($"Добавлена услуга '{ServNameTB.Text}'.","Сообщение");
                ServNameTB.Clear();
                ServPriceTB.Clear();
            }
            else { MessageBox.Show("Не все данные введены!", "Ошибка"); }
        }

        private void ServAlterButton_Click(object sender, EventArgs e)
        {
            if (DGServices.Rows.Count != 0)
            {
                string id = DGServices[0, DGServices.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (ServNameTB.Text != "" || ServPriceTB.Text != "")
                    {
                        string[] s = new string[2] { ServNameTB.Text, ServPriceTB.Text };
                        dbAlter.ServAlter(s, Convert.ToInt32(id), (DataTable)DGServices.DataSource);
                        DGServices.DataSource = dbGet.GetServices();
                        MessageBox.Show($"Изменена услуга '{DGServices[1, DGServices.CurrentRow.Index].Value.ToString()}'.", "Сообщение");
                        ServNameTB.Clear();
                        ServPriceTB.Clear();
                    }
                    else { MessageBox.Show("Не введено значение для изменения!", "Ошибка"); }
                }
            }
        }

        private void ServDelButton_Click(object sender, EventArgs e)
        {
            if (DGServices.Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGServices[0, DGServices.CurrentRow.Index].Value.ToString());
                string name = DGServices[1, DGServices.CurrentRow.Index].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (dbGet.GetServVisitsCount(id) == 0)
                    {
                        dbDell.ServDel(id, (DataTable)DGServices.DataSource);
                        DGServices.DataSource = dbGet.GetServices();
                        MessageBox.Show($"Удалена услуга '{name}'!", "Сообщение");
                    }
                    else { MessageBox.Show("Невозможно удалить услугу, которая была проведена в визитах!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет услуг для удаления!", "Ошибка"); }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MF.Show();
        }
    }
}
