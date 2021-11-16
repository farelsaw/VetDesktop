using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterenary
{
    public partial class MainForm : Form
    {
        public EnterForm EF { get; set; }
        public DocFrom DF { get; set; }
        public ServForm SF { get; set; }
        public PetsForm AF { get; set; }
        public VisitForm VF { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.MFRefresh();
        }

        public void MFRefresh()
        {
            if (AuthUser.id == 0)
            {
                this.DoctorPB.Visible = true;
                this.DocButton.Visible = true;
                this.ServicePB.Visible = true;
                this.ServiceButton.Visible = true;
                this.VisitPB.Visible = false;
                this.VisitButton.Visible = false;
                this.AnimalPB.Visible = false;
                this.AnimalButton.Visible = false;
            }
            else
            {
                this.VisitPB.Visible = true;
                this.VisitButton.Visible = true;
                this.AnimalPB.Visible = true;
                this.AnimalButton.Visible = true;
                this.DoctorPB.Visible = false;
                this.DocButton.Visible = false;
                this.ServicePB.Visible = false;
                this.ServiceButton.Visible = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EF.Show();
        }

        private void DocButton_Click(object sender, EventArgs e)
        {
            if (DF == null) { DF = new DocFrom(); }
            DF.MF = this;
            DF.Text = this.Text;
            DF.Show();
            this.Hide();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            if (SF == null) { SF = new ServForm(); }
            SF.MF = this;
            SF.Text = this.Text;
            SF.Show();
            this.Hide();
        }

        private void AnimalButton_Click(object sender, EventArgs e)
        {
            if (AF == null) { AF = new PetsForm(); }
            AF.MF = this;
            AF.Text = this.Text;
            AF.Show();
            this.Hide();
        }

        private void VisitButton_Click(object sender, EventArgs e)
        {
            if (VF == null) { VF = new VisitForm(); }
            VF.MF = this;
            VF.Text = this.Text;
            VF.Show();
            VF.VisitRefresh();
            this.Hide();
        }
    }
}
