
namespace Veterenary
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DocPanel = new System.Windows.Forms.Panel();
            this.VisitButton = new System.Windows.Forms.Button();
            this.DocButton = new System.Windows.Forms.Button();
            this.ServicePanel = new System.Windows.Forms.Panel();
            this.AnimalButton = new System.Windows.Forms.Button();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AnimalPB = new System.Windows.Forms.PictureBox();
            this.ServicePB = new System.Windows.Forms.PictureBox();
            this.VisitPB = new System.Windows.Forms.PictureBox();
            this.DoctorPB = new System.Windows.Forms.PictureBox();
            this.DocPanel.SuspendLayout();
            this.ServicePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPB)).BeginInit();
            this.SuspendLayout();
            // 
            // DocPanel
            // 
            this.DocPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DocPanel.Controls.Add(this.VisitButton);
            this.DocPanel.Controls.Add(this.DocButton);
            this.DocPanel.Controls.Add(this.VisitPB);
            this.DocPanel.Controls.Add(this.DoctorPB);
            this.DocPanel.Location = new System.Drawing.Point(12, 27);
            this.DocPanel.Name = "DocPanel";
            this.DocPanel.Size = new System.Drawing.Size(190, 160);
            this.DocPanel.TabIndex = 0;
            // 
            // VisitButton
            // 
            this.VisitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitButton.Location = new System.Drawing.Point(3, 119);
            this.VisitButton.Name = "VisitButton";
            this.VisitButton.Size = new System.Drawing.Size(184, 37);
            this.VisitButton.TabIndex = 1;
            this.VisitButton.Text = "Провести визит";
            this.VisitButton.UseVisualStyleBackColor = true;
            this.VisitButton.Click += new System.EventHandler(this.VisitButton_Click);
            // 
            // DocButton
            // 
            this.DocButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocButton.Location = new System.Drawing.Point(3, 119);
            this.DocButton.Name = "DocButton";
            this.DocButton.Size = new System.Drawing.Size(184, 37);
            this.DocButton.TabIndex = 1;
            this.DocButton.Text = "Работа с врачами";
            this.DocButton.UseVisualStyleBackColor = true;
            this.DocButton.Click += new System.EventHandler(this.DocButton_Click);
            // 
            // ServicePanel
            // 
            this.ServicePanel.BackColor = System.Drawing.Color.PeachPuff;
            this.ServicePanel.Controls.Add(this.AnimalButton);
            this.ServicePanel.Controls.Add(this.ServiceButton);
            this.ServicePanel.Controls.Add(this.AnimalPB);
            this.ServicePanel.Controls.Add(this.ServicePB);
            this.ServicePanel.Location = new System.Drawing.Point(208, 27);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(190, 160);
            this.ServicePanel.TabIndex = 1;
            // 
            // AnimalButton
            // 
            this.AnimalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimalButton.Location = new System.Drawing.Point(3, 119);
            this.AnimalButton.Name = "AnimalButton";
            this.AnimalButton.Size = new System.Drawing.Size(184, 37);
            this.AnimalButton.TabIndex = 1;
            this.AnimalButton.Text = "Животные и хозяева";
            this.AnimalButton.UseVisualStyleBackColor = true;
            this.AnimalButton.Click += new System.EventHandler(this.AnimalButton_Click);
            // 
            // ServiceButton
            // 
            this.ServiceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServiceButton.Location = new System.Drawing.Point(3, 119);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(184, 37);
            this.ServiceButton.TabIndex = 1;
            this.ServiceButton.Text = "Работа с услугами";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem1.Text = "Выйти";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // AnimalPB
            // 
            this.AnimalPB.Image = global::Veterenary.Properties.Resources.AnimalIcon;
            this.AnimalPB.Location = new System.Drawing.Point(3, 3);
            this.AnimalPB.Name = "AnimalPB";
            this.AnimalPB.Size = new System.Drawing.Size(184, 110);
            this.AnimalPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AnimalPB.TabIndex = 0;
            this.AnimalPB.TabStop = false;
            // 
            // ServicePB
            // 
            this.ServicePB.Image = global::Veterenary.Properties.Resources.ServiceIcon;
            this.ServicePB.Location = new System.Drawing.Point(3, 3);
            this.ServicePB.Name = "ServicePB";
            this.ServicePB.Size = new System.Drawing.Size(184, 110);
            this.ServicePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ServicePB.TabIndex = 0;
            this.ServicePB.TabStop = false;
            // 
            // VisitPB
            // 
            this.VisitPB.Image = global::Veterenary.Properties.Resources.VisitIcon;
            this.VisitPB.Location = new System.Drawing.Point(3, 3);
            this.VisitPB.Name = "VisitPB";
            this.VisitPB.Size = new System.Drawing.Size(184, 110);
            this.VisitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VisitPB.TabIndex = 0;
            this.VisitPB.TabStop = false;
            // 
            // DoctorPB
            // 
            this.DoctorPB.Image = global::Veterenary.Properties.Resources.DoctorIcon;
            this.DoctorPB.Location = new System.Drawing.Point(3, 3);
            this.DoctorPB.Name = "DoctorPB";
            this.DoctorPB.Size = new System.Drawing.Size(184, 110);
            this.DoctorPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoctorPB.TabIndex = 0;
            this.DoctorPB.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(412, 203);
            this.Controls.Add(this.ServicePanel);
            this.Controls.Add(this.DocPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DocPanel.ResumeLayout(false);
            this.ServicePanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnimalPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DocPanel;
        private System.Windows.Forms.PictureBox DoctorPB;
        private System.Windows.Forms.Button DocButton;
        private System.Windows.Forms.Panel ServicePanel;
        private System.Windows.Forms.PictureBox ServicePB;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.PictureBox VisitPB;
        private System.Windows.Forms.Button VisitButton;
        private System.Windows.Forms.PictureBox AnimalPB;
        private System.Windows.Forms.Button AnimalButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}