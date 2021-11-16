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
    public partial class DocFrom : Form
    {
        public MainForm MF { get; set; }
        private DBAdd dbAdd = new DBAdd();
        private DBAlter dbAlter = new DBAlter();
        private DBDell dbDell = new DBDell();
        private DBGet dbGet = new DBGet();
        public DocFrom()
        {
            InitializeComponent();
            DGDoctors.DataSource = dbGet.GetDoctors();
            DGDoctors.Columns[0].Visible = false;
            DGDoctors.Columns[1].Width = 195;
            DGDoctors.Columns[2].Width = 195;
            DGDoctors.Columns[3].Width = 70;
            DGDoctors.Columns[4].Width = 70;
            DGCategories.DataSource = dbGet.GetCategories();
            DGCategories.Columns[0].Visible = false;
            DGCategories.Columns[1].Width = 60;
            DGCategories.Columns[2].Width = 195;
        }

        private void DocFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CatAddButton_Click(object sender, EventArgs e)
        {
            dbAdd.CatAdd(CatNumTB.Text, CatNameTB.Text, (DataTable)DGCategories.DataSource);
            DGCategories.DataSource = dbGet.GetCategories();
            MessageBox.Show($"Добавлена новая категория '{CatNameTB.Text}'!", "Сообщение");
            CatNumTB.Clear();
            CatNameTB.Clear();
        }

        private void CatAlterButton_Click(object sender, EventArgs e)
        {
            if (DGCategories.Rows.Count != 0)
            {
                string id = DGCategories[0, DGCategories.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (CatNumTB.Text != "" || CatNameTB.Text != "")
                    {
                        string[] s = new string[2] { CatNumTB.Text, CatNameTB.Text };
                        dbAlter.CatAlter(s, Convert.ToInt32(id), (DataTable)DGCategories.DataSource);
                        DGCategories.DataSource = dbGet.GetCategories();
                        MessageBox.Show($"Изменена категория '{CatNameTB.Text}'!", "Сообщение");
                        CatNumTB.Clear();
                        CatNameTB.Clear();
                    }
                }
            }
        }

        private void CatDelButton_Click(object sender, EventArgs e)
        {
            if (dbGet.GetCategories().Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGCategories[0, DGCategories.CurrentRow.Index].Value.ToString());
                string name = DGCategories[2, DGCategories.CurrentRow.Index].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (dbGet.GetCatDoctorCount(id) == 0)
                    {
                        dbDell.CatDel(id, (DataTable)DGCategories.DataSource);
                        DGCategories.DataSource = dbGet.GetCategories();
                        MessageBox.Show($"Удалена категория '{name}'!", "Сообщение");
                    }
                    else { MessageBox.Show("Невозможно удалить категорию, к которой привязаны врачи!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет категории для удаления!", "Ошибка"); }
        }

        private void DocDelButton_Click(object sender, EventArgs e)
        {
            if (dbGet.GetDoctors().Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGDoctors[0, DGDoctors.CurrentRow.Index].Value.ToString());
                string name = DGDoctors[1, DGDoctors.CurrentRow.Index].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (dbGet.GetDocVisitCount(id) == 0)
                    {
                        dbDell.DocDel(id, (DataTable)DGDoctors.DataSource);
                        DGDoctors.DataSource = dbGet.GetDoctors();
                        MessageBox.Show($"Удален врач '{name}'!", "Сообщение");
                    }
                    else { MessageBox.Show("Невозможно удалить врача, у которого проведены визиты!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет врачей для удаления!", "Ошибка"); }
        }

        private void DocAddBotton_Click(object sender, EventArgs e)
        {
            if (LastNameTB.Text != "" && FirstNameTB.Text != "" && Convert.ToInt32(dbGet.GetCategories().Rows[0]["id"]) != 0)
            {
                string[] str = new string[6] { LastNameTB.Text, FirstNameTB.Text, SecondNameTB.Text, LoginTB.Text, PassTB.Text, DGCategories[0, DGCategories.CurrentRow.Index].Value.ToString() };
                dbAdd.DocAdd(str, (DataTable)DGDoctors.DataSource);
                DGDoctors.DataSource = dbGet.GetDoctors();
                MessageBox.Show($"Добавлен врач '{LastNameTB.Text} {FirstNameTB.Text} {SecondNameTB.Text}'.", "Сообщение");
                FirstNameTB.Clear();
                LastNameTB.Clear();
                SecondNameTB.Clear();
                LoginTB.Clear();
                PassTB.Clear();
            }
            else { MessageBox.Show("Не все обязательные данные введены! Проверьте наличие Фамилии, Имени и выбранной категории.", "Ошибка"); }
        }

        private void DocDAlterButton_Click(object sender, EventArgs e)
        {
            if (DGDoctors.Rows.Count != 0)
            {
                string id = DGDoctors[0, DGDoctors.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (LastNameTB.Text != "" || FirstNameTB.Text != "" || SecondNameTB.Text != "" || LoginTB.Text != "" || PassTB.Text != "")
                    {
                        string[] s = new string[5] { LastNameTB.Text, FirstNameTB.Text, SecondNameTB.Text, LoginTB.Text, PassTB.Text };
                        dbAlter.DocDAlter(s, Convert.ToInt32(id), (DataTable)DGDoctors.DataSource);
                        MessageBox.Show($"Данные врача '{DGDoctors[1, DGDoctors.CurrentRow.Index].Value.ToString()}' успешно изменены!", "Сообщение");
                        DGDoctors.DataSource = dbGet.GetDoctors();
                        FirstNameTB.Clear();
                        LastNameTB.Clear();
                        SecondNameTB.Clear();
                        LoginTB.Clear();
                        PassTB.Clear();
                    }
                    else { MessageBox.Show("Не введено значение для изменения!", "Ошибка"); }
                }
            }

        }

        private void DocCAlterButton_Click(object sender, EventArgs e)
        {
            if (DGDoctors.Rows.Count != 0)
            {
                string id = DGDoctors[0, DGDoctors.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (Convert.ToInt32(dbGet.GetCategories().Rows[0]["id"]) != 0)
                    {
                        int cid = Convert.ToInt32(DGCategories[0, DGCategories.CurrentRow.Index].Value.ToString());
                        dbAlter.DocCAlter(Convert.ToInt32(id), cid, (DataTable)DGDoctors.DataSource);
                        MessageBox.Show($"Категория врача {DGDoctors[0, DGDoctors.CurrentRow.Index].Value.ToString()} успешно изменена!", "Сообщение");
                        DGDoctors.DataSource = dbGet.GetDoctors();
                    }
                    else { MessageBox.Show("Нет категории для выбора!", "Ошибка"); }
                }
            }
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MF.Show();
        }
    }
}
