
namespace Veterenary
{
    partial class DocFrom
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
            this.DocCAlterButton = new System.Windows.Forms.Button();
            this.DocDelButton = new System.Windows.Forms.Button();
            this.DocDAlterButton = new System.Windows.Forms.Button();
            this.DocAddBotton = new System.Windows.Forms.Button();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.SecondNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LogLabel = new System.Windows.Forms.Label();
            this.SNLabel = new System.Windows.Forms.Label();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.DGDoctors = new System.Windows.Forms.DataGridView();
            this.DocLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CatDelButton = new System.Windows.Forms.Button();
            this.CatAlterButton = new System.Windows.Forms.Button();
            this.CatAddButton = new System.Windows.Forms.Button();
            this.CatNameTB = new System.Windows.Forms.TextBox();
            this.CatNumTB = new System.Windows.Forms.TextBox();
            this.CatNameLabel = new System.Windows.Forms.Label();
            this.CatNumLabel = new System.Windows.Forms.Label();
            this.DGCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DocPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDoctors)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategories)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocPanel
            // 
            this.DocPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DocPanel.Controls.Add(this.DocCAlterButton);
            this.DocPanel.Controls.Add(this.DocDelButton);
            this.DocPanel.Controls.Add(this.DocDAlterButton);
            this.DocPanel.Controls.Add(this.DocAddBotton);
            this.DocPanel.Controls.Add(this.PassTB);
            this.DocPanel.Controls.Add(this.LoginTB);
            this.DocPanel.Controls.Add(this.SecondNameTB);
            this.DocPanel.Controls.Add(this.FirstNameTB);
            this.DocPanel.Controls.Add(this.LastNameTB);
            this.DocPanel.Controls.Add(this.PassLabel);
            this.DocPanel.Controls.Add(this.LogLabel);
            this.DocPanel.Controls.Add(this.SNLabel);
            this.DocPanel.Controls.Add(this.FNLabel);
            this.DocPanel.Controls.Add(this.LNLabel);
            this.DocPanel.Controls.Add(this.DGDoctors);
            this.DocPanel.Controls.Add(this.DocLabel);
            this.DocPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocPanel.Location = new System.Drawing.Point(12, 27);
            this.DocPanel.Name = "DocPanel";
            this.DocPanel.Size = new System.Drawing.Size(614, 388);
            this.DocPanel.TabIndex = 0;
            // 
            // DocCAlterButton
            // 
            this.DocCAlterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocCAlterButton.Location = new System.Drawing.Point(297, 294);
            this.DocCAlterButton.Name = "DocCAlterButton";
            this.DocCAlterButton.Size = new System.Drawing.Size(152, 24);
            this.DocCAlterButton.TabIndex = 15;
            this.DocCAlterButton.Text = "Изменить категорию";
            this.DocCAlterButton.UseVisualStyleBackColor = true;
            this.DocCAlterButton.Click += new System.EventHandler(this.DocCAlterButton_Click);
            // 
            // DocDelButton
            // 
            this.DocDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocDelButton.Location = new System.Drawing.Point(297, 325);
            this.DocDelButton.Name = "DocDelButton";
            this.DocDelButton.Size = new System.Drawing.Size(152, 25);
            this.DocDelButton.TabIndex = 14;
            this.DocDelButton.Text = "Удалить";
            this.DocDelButton.UseVisualStyleBackColor = true;
            this.DocDelButton.Click += new System.EventHandler(this.DocDelButton_Click);
            // 
            // DocDAlterButton
            // 
            this.DocDAlterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocDAlterButton.Location = new System.Drawing.Point(297, 262);
            this.DocDAlterButton.Name = "DocDAlterButton";
            this.DocDAlterButton.Size = new System.Drawing.Size(152, 24);
            this.DocDAlterButton.TabIndex = 13;
            this.DocDAlterButton.Text = "Изменить данные";
            this.DocDAlterButton.UseVisualStyleBackColor = true;
            this.DocDAlterButton.Click += new System.EventHandler(this.DocDAlterButton_Click);
            // 
            // DocAddBotton
            // 
            this.DocAddBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocAddBotton.Location = new System.Drawing.Point(297, 231);
            this.DocAddBotton.Name = "DocAddBotton";
            this.DocAddBotton.Size = new System.Drawing.Size(152, 25);
            this.DocAddBotton.TabIndex = 12;
            this.DocAddBotton.Text = "Добавить";
            this.DocAddBotton.UseVisualStyleBackColor = true;
            this.DocAddBotton.Click += new System.EventHandler(this.DocAddBotton_Click);
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(97, 355);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(170, 25);
            this.PassTB.TabIndex = 11;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(97, 324);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(170, 25);
            this.LoginTB.TabIndex = 10;
            // 
            // SecondNameTB
            // 
            this.SecondNameTB.Location = new System.Drawing.Point(97, 293);
            this.SecondNameTB.Name = "SecondNameTB";
            this.SecondNameTB.Size = new System.Drawing.Size(170, 25);
            this.SecondNameTB.TabIndex = 9;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(97, 262);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(170, 25);
            this.FirstNameTB.TabIndex = 8;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(97, 231);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(170, 25);
            this.LastNameTB.TabIndex = 7;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(28, 356);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(63, 20);
            this.PassLabel.TabIndex = 6;
            this.PassLabel.Text = "Пароль";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLabel.Location = new System.Drawing.Point(38, 325);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(53, 20);
            this.LogLabel.TabIndex = 5;
            this.LogLabel.Text = "Логин";
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNLabel.Location = new System.Drawing.Point(15, 294);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(76, 20);
            this.SNLabel.TabIndex = 4;
            this.SNLabel.Text = "Отчетсво";
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNLabel.Location = new System.Drawing.Point(49, 263);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(42, 20);
            this.FNLabel.TabIndex = 3;
            this.FNLabel.Text = "Имя";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNLabel.Location = new System.Drawing.Point(13, 232);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(78, 20);
            this.LNLabel.TabIndex = 2;
            this.LNLabel.Text = "Фамилия";
            // 
            // DGDoctors
            // 
            this.DGDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDoctors.GridColor = System.Drawing.SystemColors.Control;
            this.DGDoctors.Location = new System.Drawing.Point(7, 24);
            this.DGDoctors.Name = "DGDoctors";
            this.DGDoctors.Size = new System.Drawing.Size(600, 195);
            this.DGDoctors.TabIndex = 1;
            // 
            // DocLabel
            // 
            this.DocLabel.AutoSize = true;
            this.DocLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DocLabel.Location = new System.Drawing.Point(3, 0);
            this.DocLabel.Name = "DocLabel";
            this.DocLabel.Size = new System.Drawing.Size(128, 21);
            this.DocLabel.TabIndex = 0;
            this.DocLabel.Text = "Список врачей";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.CatDelButton);
            this.panel1.Controls.Add(this.CatAlterButton);
            this.panel1.Controls.Add(this.CatAddButton);
            this.panel1.Controls.Add(this.CatNameTB);
            this.panel1.Controls.Add(this.CatNumTB);
            this.panel1.Controls.Add(this.CatNameLabel);
            this.panel1.Controls.Add(this.CatNumLabel);
            this.panel1.Controls.Add(this.DGCategories);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(634, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 388);
            this.panel1.TabIndex = 1;
            // 
            // CatDelButton
            // 
            this.CatDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatDelButton.Location = new System.Drawing.Point(16, 352);
            this.CatDelButton.Name = "CatDelButton";
            this.CatDelButton.Size = new System.Drawing.Size(148, 25);
            this.CatDelButton.TabIndex = 8;
            this.CatDelButton.Text = "Удалить";
            this.CatDelButton.UseVisualStyleBackColor = true;
            this.CatDelButton.Click += new System.EventHandler(this.CatDelButton_Click);
            // 
            // CatAlterButton
            // 
            this.CatAlterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatAlterButton.Location = new System.Drawing.Point(170, 321);
            this.CatAlterButton.Name = "CatAlterButton";
            this.CatAlterButton.Size = new System.Drawing.Size(148, 25);
            this.CatAlterButton.TabIndex = 7;
            this.CatAlterButton.Text = "Изменить";
            this.CatAlterButton.UseVisualStyleBackColor = true;
            this.CatAlterButton.Click += new System.EventHandler(this.CatAlterButton_Click);
            // 
            // CatAddButton
            // 
            this.CatAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CatAddButton.Location = new System.Drawing.Point(16, 321);
            this.CatAddButton.Name = "CatAddButton";
            this.CatAddButton.Size = new System.Drawing.Size(148, 25);
            this.CatAddButton.TabIndex = 6;
            this.CatAddButton.Text = "Добавить";
            this.CatAddButton.UseVisualStyleBackColor = true;
            this.CatAddButton.Click += new System.EventHandler(this.CatAddButton_Click);
            // 
            // CatNameTB
            // 
            this.CatNameTB.Location = new System.Drawing.Point(154, 246);
            this.CatNameTB.Name = "CatNameTB";
            this.CatNameTB.Size = new System.Drawing.Size(173, 25);
            this.CatNameTB.TabIndex = 5;
            // 
            // CatNumTB
            // 
            this.CatNumTB.Location = new System.Drawing.Point(154, 277);
            this.CatNumTB.Name = "CatNumTB";
            this.CatNumTB.Size = new System.Drawing.Size(173, 25);
            this.CatNumTB.TabIndex = 4;
            // 
            // CatNameLabel
            // 
            this.CatNameLabel.AutoSize = true;
            this.CatNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatNameLabel.Location = new System.Drawing.Point(64, 247);
            this.CatNameLabel.Name = "CatNameLabel";
            this.CatNameLabel.Size = new System.Drawing.Size(84, 20);
            this.CatNameLabel.TabIndex = 3;
            this.CatNameLabel.Text = "Категория";
            // 
            // CatNumLabel
            // 
            this.CatNumLabel.AutoSize = true;
            this.CatNumLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CatNumLabel.Location = new System.Drawing.Point(13, 278);
            this.CatNumLabel.Name = "CatNumLabel";
            this.CatNumLabel.Size = new System.Drawing.Size(135, 20);
            this.CatNumLabel.TabIndex = 2;
            this.CatNumLabel.Text = "Номер категории";
            // 
            // DGCategories
            // 
            this.DGCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCategories.Location = new System.Drawing.Point(7, 24);
            this.DGCategories.Name = "DGCategories";
            this.DGCategories.Size = new System.Drawing.Size(320, 212);
            this.DGCategories.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Категории врачей";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.ToolStripMenuItem.Text = "Назад";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // DocFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(980, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DocPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DocFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocFrom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DocFrom_FormClosing);
            this.DocPanel.ResumeLayout(false);
            this.DocPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGDoctors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCategories)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DocPanel;
        private System.Windows.Forms.Label DocLabel;
        private System.Windows.Forms.DataGridView DGDoctors;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox SecondNameTB;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label SNLabel;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Button DocDelButton;
        private System.Windows.Forms.Button DocDAlterButton;
        private System.Windows.Forms.Button DocAddBotton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CatDelButton;
        private System.Windows.Forms.Button CatAlterButton;
        private System.Windows.Forms.Button CatAddButton;
        private System.Windows.Forms.TextBox CatNameTB;
        private System.Windows.Forms.TextBox CatNumTB;
        private System.Windows.Forms.Label CatNameLabel;
        private System.Windows.Forms.Label CatNumLabel;
        private System.Windows.Forms.Button DocCAlterButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
    }
}