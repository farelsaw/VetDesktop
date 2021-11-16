
namespace Veterenary
{
    partial class VisitForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisitPanel = new System.Windows.Forms.Panel();
            this.VisitAddButton = new System.Windows.Forms.Button();
            this.DGVisits = new System.Windows.Forms.DataGridView();
            this.VisitLabel = new System.Windows.Forms.Label();
            this.PetPanel = new System.Windows.Forms.Panel();
            this.DGPets = new System.Windows.Forms.DataGridView();
            this.PetLabel = new System.Windows.Forms.Label();
            this.VisServPanel = new System.Windows.Forms.Panel();
            this.VisServDelButton = new System.Windows.Forms.Button();
            this.DGVisServs = new System.Windows.Forms.DataGridView();
            this.VisServLabel = new System.Windows.Forms.Label();
            this.ServPanel = new System.Windows.Forms.Panel();
            this.ServLabel = new System.Windows.Forms.Label();
            this.DGServices = new System.Windows.Forms.DataGridView();
            this.VisServAddButton = new System.Windows.Forms.Button();
            this.VisitDelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.VisitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisits)).BeginInit();
            this.PetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPets)).BeginInit();
            this.VisServPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisServs)).BeginInit();
            this.ServPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGServices)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItem.Text = "Назад";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // VisitPanel
            // 
            this.VisitPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.VisitPanel.Controls.Add(this.VisitDelButton);
            this.VisitPanel.Controls.Add(this.VisitAddButton);
            this.VisitPanel.Controls.Add(this.DGVisits);
            this.VisitPanel.Controls.Add(this.VisitLabel);
            this.VisitPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitPanel.Location = new System.Drawing.Point(12, 27);
            this.VisitPanel.Name = "VisitPanel";
            this.VisitPanel.Size = new System.Drawing.Size(571, 262);
            this.VisitPanel.TabIndex = 1;
            // 
            // VisitAddButton
            // 
            this.VisitAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitAddButton.Location = new System.Drawing.Point(7, 228);
            this.VisitAddButton.Name = "VisitAddButton";
            this.VisitAddButton.Size = new System.Drawing.Size(141, 28);
            this.VisitAddButton.TabIndex = 2;
            this.VisitAddButton.Text = "Добавить визит";
            this.VisitAddButton.UseVisualStyleBackColor = true;
            this.VisitAddButton.Click += new System.EventHandler(this.VisitAddButton_Click);
            // 
            // DGVisits
            // 
            this.DGVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVisits.Location = new System.Drawing.Point(7, 23);
            this.DGVisits.Name = "DGVisits";
            this.DGVisits.Size = new System.Drawing.Size(557, 199);
            this.DGVisits.TabIndex = 1;
            this.DGVisits.Click += new System.EventHandler(this.DGVisits_Click);
            // 
            // VisitLabel
            // 
            this.VisitLabel.AutoSize = true;
            this.VisitLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisitLabel.Location = new System.Drawing.Point(3, 0);
            this.VisitLabel.Name = "VisitLabel";
            this.VisitLabel.Size = new System.Drawing.Size(63, 20);
            this.VisitLabel.TabIndex = 0;
            this.VisitLabel.Text = "Визиты";
            // 
            // PetPanel
            // 
            this.PetPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.PetPanel.Controls.Add(this.DGPets);
            this.PetPanel.Controls.Add(this.PetLabel);
            this.PetPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetPanel.Location = new System.Drawing.Point(589, 27);
            this.PetPanel.Name = "PetPanel";
            this.PetPanel.Size = new System.Drawing.Size(387, 262);
            this.PetPanel.TabIndex = 2;
            // 
            // DGPets
            // 
            this.DGPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPets.Location = new System.Drawing.Point(7, 23);
            this.DGPets.Name = "DGPets";
            this.DGPets.Size = new System.Drawing.Size(373, 231);
            this.DGPets.TabIndex = 1;
            // 
            // PetLabel
            // 
            this.PetLabel.AutoSize = true;
            this.PetLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetLabel.Location = new System.Drawing.Point(3, 0);
            this.PetLabel.Name = "PetLabel";
            this.PetLabel.Size = new System.Drawing.Size(87, 20);
            this.PetLabel.TabIndex = 0;
            this.PetLabel.Text = "Животные";
            // 
            // VisServPanel
            // 
            this.VisServPanel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.VisServPanel.Controls.Add(this.VisServDelButton);
            this.VisServPanel.Controls.Add(this.DGVisServs);
            this.VisServPanel.Controls.Add(this.VisServLabel);
            this.VisServPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisServPanel.Location = new System.Drawing.Point(12, 295);
            this.VisServPanel.Name = "VisServPanel";
            this.VisServPanel.Size = new System.Drawing.Size(330, 303);
            this.VisServPanel.TabIndex = 3;
            // 
            // VisServDelButton
            // 
            this.VisServDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisServDelButton.Location = new System.Drawing.Point(7, 271);
            this.VisServDelButton.Name = "VisServDelButton";
            this.VisServDelButton.Size = new System.Drawing.Size(173, 28);
            this.VisServDelButton.TabIndex = 3;
            this.VisServDelButton.Text = "Удалить услугу из визита";
            this.VisServDelButton.UseVisualStyleBackColor = true;
            this.VisServDelButton.Click += new System.EventHandler(this.VisServDelButton_Click);
            // 
            // DGVisServs
            // 
            this.DGVisServs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVisServs.Location = new System.Drawing.Point(7, 23);
            this.DGVisServs.Name = "DGVisServs";
            this.DGVisServs.Size = new System.Drawing.Size(315, 243);
            this.DGVisServs.TabIndex = 1;
            // 
            // VisServLabel
            // 
            this.VisServLabel.AutoSize = true;
            this.VisServLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VisServLabel.Location = new System.Drawing.Point(3, 0);
            this.VisServLabel.Name = "VisServLabel";
            this.VisServLabel.Size = new System.Drawing.Size(109, 20);
            this.VisServLabel.TabIndex = 0;
            this.VisServLabel.Text = "Услуги визита";
            // 
            // ServPanel
            // 
            this.ServPanel.BackColor = System.Drawing.Color.Pink;
            this.ServPanel.Controls.Add(this.VisServAddButton);
            this.ServPanel.Controls.Add(this.DGServices);
            this.ServPanel.Controls.Add(this.ServLabel);
            this.ServPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServPanel.Location = new System.Drawing.Point(348, 295);
            this.ServPanel.Name = "ServPanel";
            this.ServPanel.Size = new System.Drawing.Size(395, 303);
            this.ServPanel.TabIndex = 4;
            // 
            // ServLabel
            // 
            this.ServLabel.AutoSize = true;
            this.ServLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServLabel.Location = new System.Drawing.Point(3, 3);
            this.ServLabel.Name = "ServLabel";
            this.ServLabel.Size = new System.Drawing.Size(56, 20);
            this.ServLabel.TabIndex = 0;
            this.ServLabel.Text = "Услуги";
            // 
            // DGServices
            // 
            this.DGServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGServices.Location = new System.Drawing.Point(7, 26);
            this.DGServices.Name = "DGServices";
            this.DGServices.Size = new System.Drawing.Size(380, 240);
            this.DGServices.TabIndex = 1;
            // 
            // VisServAddButton
            // 
            this.VisServAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisServAddButton.Location = new System.Drawing.Point(7, 271);
            this.VisServAddButton.Name = "VisServAddButton";
            this.VisServAddButton.Size = new System.Drawing.Size(173, 28);
            this.VisServAddButton.TabIndex = 4;
            this.VisServAddButton.Text = "Добавить услугу в визит";
            this.VisServAddButton.UseVisualStyleBackColor = true;
            this.VisServAddButton.Click += new System.EventHandler(this.VisServAddButton_Click);
            // 
            // VisitDelButton
            // 
            this.VisitDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisitDelButton.Location = new System.Drawing.Point(154, 228);
            this.VisitDelButton.Name = "VisitDelButton";
            this.VisitDelButton.Size = new System.Drawing.Size(141, 28);
            this.VisitDelButton.TabIndex = 3;
            this.VisitDelButton.Text = "Удалить визит";
            this.VisitDelButton.UseVisualStyleBackColor = true;
            this.VisitDelButton.Click += new System.EventHandler(this.VisitDelButton_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(985, 610);
            this.Controls.Add(this.ServPanel);
            this.Controls.Add(this.VisServPanel);
            this.Controls.Add(this.PetPanel);
            this.Controls.Add(this.VisitPanel);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisitForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisitForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.VisitPanel.ResumeLayout(false);
            this.VisitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisits)).EndInit();
            this.PetPanel.ResumeLayout(false);
            this.PetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPets)).EndInit();
            this.VisServPanel.ResumeLayout(false);
            this.VisServPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVisServs)).EndInit();
            this.ServPanel.ResumeLayout(false);
            this.ServPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Panel VisitPanel;
        private System.Windows.Forms.Label VisitLabel;
        private System.Windows.Forms.DataGridView DGVisits;
        private System.Windows.Forms.Button VisitAddButton;
        private System.Windows.Forms.Panel PetPanel;
        private System.Windows.Forms.DataGridView DGPets;
        private System.Windows.Forms.Label PetLabel;
        private System.Windows.Forms.Panel VisServPanel;
        private System.Windows.Forms.Label VisServLabel;
        private System.Windows.Forms.DataGridView DGVisServs;
        private System.Windows.Forms.Button VisServDelButton;
        private System.Windows.Forms.Panel ServPanel;
        private System.Windows.Forms.DataGridView DGServices;
        private System.Windows.Forms.Label ServLabel;
        private System.Windows.Forms.Button VisServAddButton;
        private System.Windows.Forms.Button VisitDelButton;
    }
}