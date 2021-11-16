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
    public partial class VisitForm : Form
    {
        public MainForm MF { get; set; }
        private DBAdd dbAdd = new DBAdd();
        private DBAlter dbAlter = new DBAlter();
        private DBDell dbDell = new DBDell();
        private DBGet dbGet = new DBGet();
        public VisitForm()
        {
            InitializeComponent();
            VisitRefresh();
            DGVisits.Columns[0].Visible = false;
            DGVisits.Columns[1].Visible = false;
            DGVisits.Columns[2].Visible = false;
            DGVisits.Columns[3].Width = 120;
            DGVisits.Columns[4].Width = 250;
            DGVisits.Columns[5].Width = 120;
            DGPets.Columns[0].Visible = false;
            DGPets.Columns[1].Visible = false;
            DGPets.Columns[2].Width = 170;
            DGPets.Columns[3].Width = 135;
            DGVisServs.DataSource = dbGet.GetHolVisServs();
            DGVisServs.Columns[0].Visible = false;
            DGVisServs.Columns[1].Visible = false;
            DGVisServs.Columns[2].Width = 240;
            DGVisServs.Columns[3].Visible = false;
            DGServices.DataSource = dbGet.GetServices();
            DGServices.Columns[0].Visible = false;
            DGServices.Columns[1].Width = 230;
            DGServices.Columns[2].Width = 80;
        }

        private void VisitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MF.Show();
        }

        public void VisitRefresh()
        {
            DGVisits.DataSource = dbGet.GetVisits(AuthUser.id);
            DGPets.DataSource = dbGet.GetPets();
            DGServices.DataSource = dbGet.GetServices();
        }

        private void VisitAddButton_Click(object sender, EventArgs e)
        {
            if (DGPets.Rows.Count != 0)
            {
                string pid = DGPets[0, DGPets.CurrentRow.Index].Value.ToString();
                if (pid != "")
                {
                    string[] s = new string[3] { DateTime.Now.ToString(), Convert.ToString(AuthUser.id), pid };
                    dbAdd.VisitAdd(s, (DataTable)DGVisits.DataSource);
                    MessageBox.Show("Добавлен визит.","Сообщение");
                    VisitRefresh();
                }
                else { MessageBox.Show("Не выбрано животное для визита!", "Ошибка"); }
            }
            else { MessageBox.Show("Нет животных для визита!","Ошибка"); }
        }

        private void DGVisits_Click(object sender, EventArgs e)
        {
            if (DGVisits.Rows.Count != 0)
            {
                string id = DGVisits[0, DGVisits.CurrentRow.Index].Value.ToString();
                if (id != "")
                {
                    DGVisServs.DataSource = dbGet.GetVisServs(Convert.ToInt32(id));
                }
            }
        }

        private void VisServAddButton_Click(object sender, EventArgs e)
        {
            if (DGServices.Rows.Count != 0)
            {
                string vid = DGVisits[0, DGVisits.CurrentRow.Index].Value.ToString();
                if (vid != "")
                {
                    string sid = DGServices[0, DGServices.CurrentRow.Index].Value.ToString();
                    if (sid != "")
                    {
                        int sum = Convert.ToInt32(DGVisits[5, DGVisits.CurrentRow.Index].Value.ToString()) + Convert.ToInt32(DGServices[2, DGServices.CurrentRow.Index].Value.ToString());
                        int[] i = new int[3] { Convert.ToInt32(vid), Convert.ToInt32(sid), sum };
                        dbAdd.ServVisAdd(i, (DataTable)DGVisServs.DataSource);
                        DGVisServs.DataSource = dbGet.GetVisServs(Convert.ToInt32(vid));
                        VisitRefresh();
                        MessageBox.Show($"Добавлена услуга '{DGServices[1, DGServices.CurrentRow.Index].Value.ToString()}' в визит.","Сообщение");
                    }
                }
            }
        }

        private void VisServDelButton_Click(object sender, EventArgs e)
        {
            if(DGVisServs.Rows.Count != 0)
            {
                int sum = Convert.ToInt32(DGVisits[5, DGVisits.CurrentRow.Index].Value.ToString()) - Convert.ToInt32(DGVisServs[3, DGVisServs.CurrentRow.Index].Value.ToString());
                int vid = Convert.ToInt32(DGVisits[0, DGVisits.CurrentRow.Index].Value.ToString());
                int sid = Convert.ToInt32(DGVisServs[0, DGVisServs.CurrentRow.Index].Value.ToString());
                string s = DGVisServs[2, DGVisServs.CurrentRow.Index].Value.ToString();
                int[] i = new int[3] { vid, sid, sum };
                dbDell.ServVisDel(i, (DataTable)DGVisServs.DataSource);
                DGVisServs.DataSource = dbGet.GetVisServs(Convert.ToInt32(vid));
                VisitRefresh();
                MessageBox.Show($"Удалена услуга '{s}' из визита.", "Сообщение");
            }
        }

        private void VisitDelButton_Click(object sender, EventArgs e)
        {
            if(DGVisits.Rows.Count != 0)
            {
                string id = DGVisits[0, DGVisits.CurrentRow.Index].Value.ToString();
                if(id != "")
                {
                    DialogResult result = MessageBox.Show("Вы уверены?", "Сообщение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dbDell.VisDel(Convert.ToInt32(id), (DataTable)DGVisits.DataSource);
                        MessageBox.Show("Визит удален.", "Сообщение");
                        VisitRefresh();
                    }
                }
            }
        }
    }
}
