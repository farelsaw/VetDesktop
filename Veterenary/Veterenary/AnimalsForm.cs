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
    public partial class PetsForm : Form
    {
        public MainForm MF { get; set; }
        private DBAdd dbAdd = new DBAdd();
        private DBAlter dbAlter = new DBAlter();
        private DBDell dbDell = new DBDell();
        private DBGet dbGet = new DBGet();
        public PetsForm()
        {
            InitializeComponent();
            DGOwners.DataSource = dbGet.GetOwners();
            DGPets.DataSource = dbGet.GetPets();
            DGVac.DataSource = dbGet.GetVac();
            DGVac.Columns[0].Visible = false;
            DGVac.Columns[1].Visible = false;
            DGVac.Columns[2].Width = 120;
            DGVac.Columns[3].Width = 150;
            DGPets.Columns[0].Visible = false;
            DGPets.Columns[1].Visible = false;
            DGPets.Columns[2].Width = 170;
            DGPets.Columns[3].Width = 135;
            DGOwners.Columns[0].Visible = false;
            DGOwners.Columns[1].Width = 230;
            DGOwners.Columns[2].Width = 110;
        }

        private void PetsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MF.Show();
        }

        private void OwAddButton_Click(object sender, EventArgs e)
        {
            if (LastNameTB.Text != "" && FirstNameTB.Text != "" && TelTB.Text != "")
            {
                string[] s = new string[4] { LastNameTB.Text, FirstNameTB.Text, SecondNameTB.Text, TelTB.Text };
                dbAdd.OwnerAdd(s, (DataTable)DGOwners.DataSource);
                DGOwners.DataSource = dbGet.GetOwners();
                MessageBox.Show($"Добавлен хозяин '{LastNameTB.Text} {FirstNameTB.Text} {SecondNameTB.Text}'.", "Сообщение");
                LastNameTB.Clear();
                FirstNameTB.Clear();
                SecondNameTB.Clear();
                TelTB.Clear();
            }
            else { MessageBox.Show("Не все данные введены!", "Ошибка"); }
        }

        private void OwAlterBotton_Click(object sender, EventArgs e)
        {
            if (DGOwners.Rows.Count != 0)
            {
                string id = DGOwners[0, DGOwners.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (LastNameTB.Text != "" || FirstNameTB.Text != "" || SecondNameTB.Text != "" || TelTB.Text != "")
                    {
                        string[] s = new string[4] { LastNameTB.Text, FirstNameTB.Text, SecondNameTB.Text, TelTB.Text };
                        dbAlter.OwnerAlter(s, Convert.ToInt32(id), (DataTable)DGOwners.DataSource);
                        MessageBox.Show($"Данные хозяина '{DGOwners[1, DGOwners.CurrentRow.Index].Value.ToString()}' успешно изменены!", "Сообщение");
                        DGOwners.DataSource = dbGet.GetOwners();
                        FirstNameTB.Clear();
                        LastNameTB.Clear();
                        SecondNameTB.Clear();
                        TelTB.Clear();
                    }
                    else { MessageBox.Show("Не введено значение для изменения!", "Ошибка"); }
                }
            }
        }

        private void OwDelButton_Click(object sender, EventArgs e)
        {
            if (dbGet.GetOwners().Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGOwners[0, DGOwners.CurrentRow.Index].Value.ToString());
                string name = DGOwners[1, DGOwners.CurrentRow.Index].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (dbGet.GetOwnerPetsCount(id) == 0)
                    {
                        dbDell.OwnerDel(id, (DataTable)DGOwners.DataSource);
                        DGOwners.DataSource = dbGet.GetOwners();
                        MessageBox.Show($"Удален хозяин '{name}'!", "Сообщение");
                    }
                    else { MessageBox.Show("Невозможно удалить хозяина, у которого есть животное!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет хозяев для удаления!", "Ошибка"); }
        }

        private void DGOwners_Click(object sender, EventArgs e)
        {
            if (dbGet.GetOwners().Rows.Count != 0)
            {
                string id = DGOwners[0, DGOwners.CurrentRow.Index].Value.ToString();
                if (id != "") 
                { 
                    DGPets.DataSource = dbGet.GetOwnerPets(Convert.ToInt32(id));
                    DGVac.DataSource = dbGet.GetVac();
                }       
            }
        }

        private void PetAddButton_Click(object sender, EventArgs e)
        {
            if (dbGet.GetOwners().Rows.Count != 0)
            {
                string id = DGOwners[0, DGOwners.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (PetNameTB.Text != "" && PetTypeTB.Text != "")
                    {
                        string[] s = new string[2] { PetNameTB.Text, PetTypeTB.Text };
                        dbAdd.PetAdd(s, Convert.ToInt32(id), (DataTable)DGPets.DataSource);
                        DGOwners_Click(sender, e);
                        MessageBox.Show($"Добавлено животное '{PetNameTB.Text}'.", "Сообщение");
                        PetNameTB.Clear();
                        PetTypeTB.Clear();
                    }
                    else { MessageBox.Show("Не все данные введены!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет хозяев для добавления животного!", "Ошибка"); }
        }

        private void PetAlterButton_Click(object sender, EventArgs e)
        {
            if (DGPets.Rows.Count != 0)
            {
                string id = DGPets[0, DGOwners.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (PetNameTB.Text != "" || PetTypeTB.Text != "")
                    {
                        string[] s = new string[2] { PetNameTB.Text, PetTypeTB.Text };
                        dbAlter.PetAlter(s, Convert.ToInt32(id), (DataTable)DGOwners.DataSource);
                        MessageBox.Show($"Данные животного '{DGPets[2, DGOwners.CurrentRow.Index].Value.ToString()}' успешно изменены!", "Сообщение");
                        DGOwners_Click(sender, e);
                        PetNameTB.Clear();
                        PetTypeTB.Clear();
                    }
                    else { MessageBox.Show("Не введено значение для изменения!", "Ошибка"); }
                }
            }
        }

        private void PetDelButton_Click(object sender, EventArgs e)
        {
            if (DGPets.Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGPets[0, DGPets.CurrentRow.Index].Value.ToString());
                string name = DGPets[2, DGPets.CurrentRow.Index].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (dbGet.GetPetVisits(id) == 0)
                    {
                        dbDell.PetDel(id, (DataTable)DGOwners.DataSource);
                        DGPets.DataSource = dbGet.GetPets();
                        DGVac.DataSource = dbGet.GetVac();
                        MessageBox.Show($"Удалено животное '{name}' с данными о вакцинации!", "Сообщение");
                    }
                    else { MessageBox.Show("Невозможно удалить животного, у которого есть проведенные визиты!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет животных для удаления!", "Ошибка"); }
        }

        private void AllPetsLabel_Click(object sender, EventArgs e)
        {
            DGPets.DataSource = dbGet.GetPets();
        }

        private void VacAddButton_Click(object sender, EventArgs e)
        {
            if (DGPets.Rows.Count != 0)
            {
                string id = DGPets[0, DGPets.CurrentRow.Index].Value.ToString();
                string name = DGPets[2, DGPets.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    if (VacTypeTB.Text != "")
                    {
                        string[] s = new string[2] { VacTypeTB.Text, DateTime.Now.ToString() };
                        dbAdd.VacAdd(s, Convert.ToInt32(id), (DataTable)DGVac.DataSource);
                        DGVac.DataSource = dbGet.GetPetVac(Convert.ToInt32(id));
                        MessageBox.Show($"Добавлена вакцинация для животного '{name}'.", "Сообщение");
                        VacTypeTB.Clear();
                    }
                    else { MessageBox.Show("Не все данные введены!", "Ошибка"); }
                }
            }
            else { MessageBox.Show("Нет животного для вакцинации!", "Ошибка"); }
        }

        private void VacAlterButton_Click(object sender, EventArgs e)
        {
            if (DGVac.Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGVac[0, DGVac.CurrentRow.Index].Value.ToString());
                if (VacTypeTB.Text != "")
                {
                    string[] s = new string[2] { VacTypeTB.Text, DateTime.Now.ToString() };
                    dbAlter.VacAlter(s, Convert.ToInt32(id), (DataTable)DGVac.DataSource);
                    DGVac.DataSource = dbGet.GetPetVac(Convert.ToInt32(id));
                    MessageBox.Show("Вакцинация изменена.", "Сообщение");
                    VacTypeTB.Clear();
                }
                else { MessageBox.Show("Не все данные введены!", "Ошибка"); }
            }
            else { MessageBox.Show("Нет вакцинации для изменения!", "Ошибка"); }
        }

        private void VacDelButton_Click(object sender, EventArgs e)
        {
            if (DGVac.Rows.Count != 0)
            {
                int id = Convert.ToInt32(DGVac[0, DGVac.CurrentRow.Index].Value.ToString());
                int pid = Convert.ToInt32(DGVac[1, DGVac.CurrentRow.Index].Value.ToString());
                string name = DGPets[2, DGPets.CurrentRow.Index].Value.ToString();
                DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dbDell.VacDel(id, (DataTable)DGVac.DataSource);
                    DGVac.DataSource = dbGet.GetPetVac(pid);
                    MessageBox.Show($"Вакцинация животного '{name}' удалена.", "Сообщение");
                }
            }
            else { MessageBox.Show("Нет вакцинации для удаления!", "Ошибка"); }
        }

        private void DGPets_Click(object sender, EventArgs e)
        {
            if (dbGet.GetPets().Rows.Count != 0)
            {
                string id = DGPets[0, DGPets.CurrentRow.Index].Value.ToString();
                if (id != "") { DGVac.DataSource = dbGet.GetPetVac(Convert.ToInt32(id)); }
            }
        }
    }
}
