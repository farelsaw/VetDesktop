
namespace Veterenary
{
    partial class ServForm
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
            this.ServPanel = new System.Windows.Forms.Panel();
            this.ServLabel = new System.Windows.Forms.Label();
            this.DGServices = new System.Windows.Forms.DataGridView();
            this.ServNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServNameTB = new System.Windows.Forms.TextBox();
            this.ServPriceTB = new System.Windows.Forms.TextBox();
            this.ServAddButton = new System.Windows.Forms.Button();
            this.ServAlterButton = new System.Windows.Forms.Button();
            this.ServDelButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGServices)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServPanel
            // 
            this.ServPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ServPanel.Controls.Add(this.ServDelButton);
            this.ServPanel.Controls.Add(this.ServAlterButton);
            this.ServPanel.Controls.Add(this.ServAddButton);
            this.ServPanel.Controls.Add(this.ServPriceTB);
            this.ServPanel.Controls.Add(this.ServNameTB);
            this.ServPanel.Controls.Add(this.label1);
            this.ServPanel.Controls.Add(this.ServNameLabel);
            this.ServPanel.Controls.Add(this.DGServices);
            this.ServPanel.Controls.Add(this.ServLabel);
            this.ServPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServPanel.Location = new System.Drawing.Point(12, 27);
            this.ServPanel.Name = "ServPanel";
            this.ServPanel.Size = new System.Drawing.Size(393, 425);
            this.ServPanel.TabIndex = 0;
            // 
            // ServLabel
            // 
            this.ServLabel.AutoSize = true;
            this.ServLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServLabel.Location = new System.Drawing.Point(3, 0);
            this.ServLabel.Name = "ServLabel";
            this.ServLabel.Size = new System.Drawing.Size(63, 21);
            this.ServLabel.TabIndex = 0;
            this.ServLabel.Text = "Услуги";
            // 
            // DGServices
            // 
            this.DGServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGServices.Location = new System.Drawing.Point(7, 24);
            this.DGServices.Name = "DGServices";
            this.DGServices.Size = new System.Drawing.Size(380, 244);
            this.DGServices.TabIndex = 1;
            // 
            // ServNameLabel
            // 
            this.ServNameLabel.AutoSize = true;
            this.ServNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServNameLabel.Location = new System.Drawing.Point(13, 280);
            this.ServNameLabel.Name = "ServNameLabel";
            this.ServNameLabel.Size = new System.Drawing.Size(78, 20);
            this.ServNameLabel.TabIndex = 2;
            this.ServNameLabel.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(45, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цена";
            // 
            // ServNameTB
            // 
            this.ServNameTB.Location = new System.Drawing.Point(97, 279);
            this.ServNameTB.Name = "ServNameTB";
            this.ServNameTB.Size = new System.Drawing.Size(245, 25);
            this.ServNameTB.TabIndex = 4;
            // 
            // ServPriceTB
            // 
            this.ServPriceTB.Location = new System.Drawing.Point(97, 310);
            this.ServPriceTB.Name = "ServPriceTB";
            this.ServPriceTB.Size = new System.Drawing.Size(100, 25);
            this.ServPriceTB.TabIndex = 5;
            // 
            // ServAddButton
            // 
            this.ServAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServAddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServAddButton.Location = new System.Drawing.Point(7, 350);
            this.ServAddButton.Name = "ServAddButton";
            this.ServAddButton.Size = new System.Drawing.Size(190, 29);
            this.ServAddButton.TabIndex = 6;
            this.ServAddButton.Text = "Добавить";
            this.ServAddButton.UseVisualStyleBackColor = true;
            this.ServAddButton.Click += new System.EventHandler(this.ServAddButton_Click);
            // 
            // ServAlterButton
            // 
            this.ServAlterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServAlterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServAlterButton.Location = new System.Drawing.Point(203, 350);
            this.ServAlterButton.Name = "ServAlterButton";
            this.ServAlterButton.Size = new System.Drawing.Size(179, 29);
            this.ServAlterButton.TabIndex = 7;
            this.ServAlterButton.Text = "Изменить";
            this.ServAlterButton.UseVisualStyleBackColor = true;
            this.ServAlterButton.Click += new System.EventHandler(this.ServAlterButton_Click);
            // 
            // ServDelButton
            // 
            this.ServDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServDelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServDelButton.Location = new System.Drawing.Point(203, 385);
            this.ServDelButton.Name = "ServDelButton";
            this.ServDelButton.Size = new System.Drawing.Size(179, 29);
            this.ServDelButton.TabIndex = 8;
            this.ServDelButton.Text = "Удалить";
            this.ServDelButton.UseVisualStyleBackColor = true;
            this.ServDelButton.Click += new System.EventHandler(this.ServDelButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItem.Text = "Назад";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ServForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(416, 461);
            this.Controls.Add(this.ServPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ServForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServForm_FormClosing);
            this.ServPanel.ResumeLayout(false);
            this.ServPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGServices)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ServPanel;
        private System.Windows.Forms.Label ServLabel;
        private System.Windows.Forms.DataGridView DGServices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ServNameLabel;
        private System.Windows.Forms.Button ServAddButton;
        private System.Windows.Forms.TextBox ServPriceTB;
        private System.Windows.Forms.TextBox ServNameTB;
        private System.Windows.Forms.Button ServAlterButton;
        private System.Windows.Forms.Button ServDelButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}