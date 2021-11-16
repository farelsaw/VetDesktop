
namespace Veterenary
{
    partial class PetsForm
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
            this.OwnerPanel = new System.Windows.Forms.Panel();
            this.OwDelButton = new System.Windows.Forms.Button();
            this.OwAlterBotton = new System.Windows.Forms.Button();
            this.OwAddButton = new System.Windows.Forms.Button();
            this.TelTB = new System.Windows.Forms.TextBox();
            this.TelLabel = new System.Windows.Forms.Label();
            this.SecondNameTB = new System.Windows.Forms.TextBox();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.SNLabel = new System.Windows.Forms.Label();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LBLabel = new System.Windows.Forms.Label();
            this.DGOwners = new System.Windows.Forms.DataGridView();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PetPanel = new System.Windows.Forms.Panel();
            this.AllPetsLabel = new System.Windows.Forms.Label();
            this.PetDelButton = new System.Windows.Forms.Button();
            this.PetAlterButton = new System.Windows.Forms.Button();
            this.PetAddButton = new System.Windows.Forms.Button();
            this.PetTypeTB = new System.Windows.Forms.TextBox();
            this.PetNameTB = new System.Windows.Forms.TextBox();
            this.PetTypeLabel = new System.Windows.Forms.Label();
            this.PetNameLabel = new System.Windows.Forms.Label();
            this.DGPets = new System.Windows.Forms.DataGridView();
            this.PetsLabel = new System.Windows.Forms.Label();
            this.VacPanel = new System.Windows.Forms.Panel();
            this.VacLabel = new System.Windows.Forms.Label();
            this.DGVac = new System.Windows.Forms.DataGridView();
            this.VacTypeLabel = new System.Windows.Forms.Label();
            this.VacTypeTB = new System.Windows.Forms.TextBox();
            this.VacAddButton = new System.Windows.Forms.Button();
            this.VacAlterButton = new System.Windows.Forms.Button();
            this.VacDelButton = new System.Windows.Forms.Button();
            this.OwnerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGOwners)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPets)).BeginInit();
            this.VacPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVac)).BeginInit();
            this.SuspendLayout();
            // 
            // OwnerPanel
            // 
            this.OwnerPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.OwnerPanel.Controls.Add(this.OwDelButton);
            this.OwnerPanel.Controls.Add(this.OwAlterBotton);
            this.OwnerPanel.Controls.Add(this.OwAddButton);
            this.OwnerPanel.Controls.Add(this.TelTB);
            this.OwnerPanel.Controls.Add(this.TelLabel);
            this.OwnerPanel.Controls.Add(this.SecondNameTB);
            this.OwnerPanel.Controls.Add(this.FirstNameTB);
            this.OwnerPanel.Controls.Add(this.LastNameTB);
            this.OwnerPanel.Controls.Add(this.SNLabel);
            this.OwnerPanel.Controls.Add(this.FNLabel);
            this.OwnerPanel.Controls.Add(this.LBLabel);
            this.OwnerPanel.Controls.Add(this.DGOwners);
            this.OwnerPanel.Controls.Add(this.OwnerLabel);
            this.OwnerPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerPanel.Location = new System.Drawing.Point(12, 27);
            this.OwnerPanel.Name = "OwnerPanel";
            this.OwnerPanel.Size = new System.Drawing.Size(425, 481);
            this.OwnerPanel.TabIndex = 0;
            // 
            // OwDelButton
            // 
            this.OwDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OwDelButton.Location = new System.Drawing.Point(208, 440);
            this.OwDelButton.Name = "OwDelButton";
            this.OwDelButton.Size = new System.Drawing.Size(159, 27);
            this.OwDelButton.TabIndex = 12;
            this.OwDelButton.Text = "Удалить";
            this.OwDelButton.UseVisualStyleBackColor = true;
            this.OwDelButton.Click += new System.EventHandler(this.OwDelButton_Click);
            // 
            // OwAlterBotton
            // 
            this.OwAlterBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OwAlterBotton.Location = new System.Drawing.Point(208, 408);
            this.OwAlterBotton.Name = "OwAlterBotton";
            this.OwAlterBotton.Size = new System.Drawing.Size(159, 26);
            this.OwAlterBotton.TabIndex = 11;
            this.OwAlterBotton.Text = "Изменить";
            this.OwAlterBotton.UseVisualStyleBackColor = true;
            this.OwAlterBotton.Click += new System.EventHandler(this.OwAlterBotton_Click);
            // 
            // OwAddButton
            // 
            this.OwAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OwAddButton.Location = new System.Drawing.Point(43, 408);
            this.OwAddButton.Name = "OwAddButton";
            this.OwAddButton.Size = new System.Drawing.Size(159, 26);
            this.OwAddButton.TabIndex = 10;
            this.OwAddButton.Text = "Добавить";
            this.OwAddButton.UseVisualStyleBackColor = true;
            this.OwAddButton.Click += new System.EventHandler(this.OwAddButton_Click);
            // 
            // TelTB
            // 
            this.TelTB.Location = new System.Drawing.Point(183, 367);
            this.TelTB.Name = "TelTB";
            this.TelTB.Size = new System.Drawing.Size(184, 25);
            this.TelTB.TabIndex = 9;
            // 
            // TelLabel
            // 
            this.TelLabel.AutoSize = true;
            this.TelLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelLabel.Location = new System.Drawing.Point(14, 368);
            this.TelLabel.Name = "TelLabel";
            this.TelLabel.Size = new System.Drawing.Size(163, 20);
            this.TelLabel.TabIndex = 8;
            this.TelLabel.Text = "Контактный телефон";
            // 
            // SecondNameTB
            // 
            this.SecondNameTB.Location = new System.Drawing.Point(183, 336);
            this.SecondNameTB.Name = "SecondNameTB";
            this.SecondNameTB.Size = new System.Drawing.Size(184, 25);
            this.SecondNameTB.TabIndex = 7;
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(183, 305);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(184, 25);
            this.FirstNameTB.TabIndex = 6;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(183, 274);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(184, 25);
            this.LastNameTB.TabIndex = 5;
            // 
            // SNLabel
            // 
            this.SNLabel.AutoSize = true;
            this.SNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SNLabel.Location = new System.Drawing.Point(101, 337);
            this.SNLabel.Name = "SNLabel";
            this.SNLabel.Size = new System.Drawing.Size(76, 20);
            this.SNLabel.TabIndex = 4;
            this.SNLabel.Text = "Отчество";
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FNLabel.Location = new System.Drawing.Point(135, 306);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(42, 20);
            this.FNLabel.TabIndex = 3;
            this.FNLabel.Text = "Имя";
            // 
            // LBLabel
            // 
            this.LBLabel.AutoSize = true;
            this.LBLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBLabel.Location = new System.Drawing.Point(99, 275);
            this.LBLabel.Name = "LBLabel";
            this.LBLabel.Size = new System.Drawing.Size(78, 20);
            this.LBLabel.TabIndex = 2;
            this.LBLabel.Text = "Фамилия";
            // 
            // DGOwners
            // 
            this.DGOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGOwners.Location = new System.Drawing.Point(7, 23);
            this.DGOwners.Name = "DGOwners";
            this.DGOwners.Size = new System.Drawing.Size(410, 240);
            this.DGOwners.TabIndex = 1;
            this.DGOwners.Click += new System.EventHandler(this.DGOwners_Click);
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnerLabel.Location = new System.Drawing.Point(3, 0);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(69, 20);
            this.OwnerLabel.TabIndex = 0;
            this.OwnerLabel.Text = "Хозяева";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 24);
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
            // PetPanel
            // 
            this.PetPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.PetPanel.Controls.Add(this.AllPetsLabel);
            this.PetPanel.Controls.Add(this.PetDelButton);
            this.PetPanel.Controls.Add(this.PetAlterButton);
            this.PetPanel.Controls.Add(this.PetAddButton);
            this.PetPanel.Controls.Add(this.PetTypeTB);
            this.PetPanel.Controls.Add(this.PetNameTB);
            this.PetPanel.Controls.Add(this.PetTypeLabel);
            this.PetPanel.Controls.Add(this.PetNameLabel);
            this.PetPanel.Controls.Add(this.DGPets);
            this.PetPanel.Controls.Add(this.PetsLabel);
            this.PetPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetPanel.Location = new System.Drawing.Point(443, 27);
            this.PetPanel.Name = "PetPanel";
            this.PetPanel.Size = new System.Drawing.Size(388, 481);
            this.PetPanel.TabIndex = 2;
            // 
            // AllPetsLabel
            // 
            this.AllPetsLabel.AutoSize = true;
            this.AllPetsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllPetsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllPetsLabel.Location = new System.Drawing.Point(212, 0);
            this.AllPetsLabel.Name = "AllPetsLabel";
            this.AllPetsLabel.Size = new System.Drawing.Size(168, 17);
            this.AllPetsLabel.TabIndex = 14;
            this.AllPetsLabel.Text = "Общий список животных";
            this.AllPetsLabel.Click += new System.EventHandler(this.AllPetsLabel_Click);
            // 
            // PetDelButton
            // 
            this.PetDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PetDelButton.Location = new System.Drawing.Point(193, 441);
            this.PetDelButton.Name = "PetDelButton";
            this.PetDelButton.Size = new System.Drawing.Size(159, 26);
            this.PetDelButton.TabIndex = 13;
            this.PetDelButton.Text = "Удалить";
            this.PetDelButton.UseVisualStyleBackColor = true;
            this.PetDelButton.Click += new System.EventHandler(this.PetDelButton_Click);
            // 
            // PetAlterButton
            // 
            this.PetAlterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PetAlterButton.Location = new System.Drawing.Point(193, 409);
            this.PetAlterButton.Name = "PetAlterButton";
            this.PetAlterButton.Size = new System.Drawing.Size(159, 26);
            this.PetAlterButton.TabIndex = 12;
            this.PetAlterButton.Text = "Изменить";
            this.PetAlterButton.UseVisualStyleBackColor = true;
            this.PetAlterButton.Click += new System.EventHandler(this.PetAlterButton_Click);
            // 
            // PetAddButton
            // 
            this.PetAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PetAddButton.Location = new System.Drawing.Point(28, 409);
            this.PetAddButton.Name = "PetAddButton";
            this.PetAddButton.Size = new System.Drawing.Size(159, 26);
            this.PetAddButton.TabIndex = 11;
            this.PetAddButton.Text = "Добавить";
            this.PetAddButton.UseVisualStyleBackColor = true;
            this.PetAddButton.Click += new System.EventHandler(this.PetAddButton_Click);
            // 
            // PetTypeTB
            // 
            this.PetTypeTB.Location = new System.Drawing.Point(158, 367);
            this.PetTypeTB.Name = "PetTypeTB";
            this.PetTypeTB.Size = new System.Drawing.Size(184, 25);
            this.PetTypeTB.TabIndex = 7;
            // 
            // PetNameTB
            // 
            this.PetNameTB.Location = new System.Drawing.Point(158, 335);
            this.PetNameTB.Name = "PetNameTB";
            this.PetNameTB.Size = new System.Drawing.Size(184, 25);
            this.PetNameTB.TabIndex = 6;
            // 
            // PetTypeLabel
            // 
            this.PetTypeLabel.AutoSize = true;
            this.PetTypeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetTypeLabel.Location = new System.Drawing.Point(33, 368);
            this.PetTypeLabel.Name = "PetTypeLabel";
            this.PetTypeLabel.Size = new System.Drawing.Size(119, 20);
            this.PetTypeLabel.TabIndex = 4;
            this.PetTypeLabel.Text = "Тип животного";
            // 
            // PetNameLabel
            // 
            this.PetNameLabel.AutoSize = true;
            this.PetNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetNameLabel.Location = new System.Drawing.Point(26, 336);
            this.PetNameLabel.Name = "PetNameLabel";
            this.PetNameLabel.Size = new System.Drawing.Size(126, 20);
            this.PetNameLabel.TabIndex = 3;
            this.PetNameLabel.Text = "Имя животного";
            // 
            // DGPets
            // 
            this.DGPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPets.Location = new System.Drawing.Point(7, 23);
            this.DGPets.Name = "DGPets";
            this.DGPets.Size = new System.Drawing.Size(373, 300);
            this.DGPets.TabIndex = 1;
            this.DGPets.Click += new System.EventHandler(this.DGPets_Click);
            // 
            // PetsLabel
            // 
            this.PetsLabel.AutoSize = true;
            this.PetsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PetsLabel.Location = new System.Drawing.Point(3, 0);
            this.PetsLabel.Name = "PetsLabel";
            this.PetsLabel.Size = new System.Drawing.Size(87, 20);
            this.PetsLabel.TabIndex = 0;
            this.PetsLabel.Text = "Животные";
            // 
            // VacPanel
            // 
            this.VacPanel.BackColor = System.Drawing.Color.LightGreen;
            this.VacPanel.Controls.Add(this.VacDelButton);
            this.VacPanel.Controls.Add(this.VacAlterButton);
            this.VacPanel.Controls.Add(this.VacAddButton);
            this.VacPanel.Controls.Add(this.VacTypeTB);
            this.VacPanel.Controls.Add(this.VacTypeLabel);
            this.VacPanel.Controls.Add(this.DGVac);
            this.VacPanel.Controls.Add(this.VacLabel);
            this.VacPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacPanel.Location = new System.Drawing.Point(837, 27);
            this.VacPanel.Name = "VacPanel";
            this.VacPanel.Size = new System.Drawing.Size(355, 480);
            this.VacPanel.TabIndex = 3;
            // 
            // VacLabel
            // 
            this.VacLabel.AutoSize = true;
            this.VacLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacLabel.Location = new System.Drawing.Point(3, 0);
            this.VacLabel.Name = "VacLabel";
            this.VacLabel.Size = new System.Drawing.Size(99, 20);
            this.VacLabel.TabIndex = 0;
            this.VacLabel.Text = "Вакцинация";
            // 
            // DGVac
            // 
            this.DGVac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVac.Location = new System.Drawing.Point(7, 23);
            this.DGVac.Name = "DGVac";
            this.DGVac.Size = new System.Drawing.Size(340, 300);
            this.DGVac.TabIndex = 1;
            // 
            // VacTypeLabel
            // 
            this.VacTypeLabel.AutoSize = true;
            this.VacTypeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VacTypeLabel.Location = new System.Drawing.Point(17, 337);
            this.VacTypeLabel.Name = "VacTypeLabel";
            this.VacTypeLabel.Size = new System.Drawing.Size(128, 20);
            this.VacTypeLabel.TabIndex = 4;
            this.VacTypeLabel.Text = "Тип вакцинации";
            // 
            // VacTypeTB
            // 
            this.VacTypeTB.Location = new System.Drawing.Point(151, 336);
            this.VacTypeTB.Name = "VacTypeTB";
            this.VacTypeTB.Size = new System.Drawing.Size(184, 25);
            this.VacTypeTB.TabIndex = 7;
            // 
            // VacAddButton
            // 
            this.VacAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VacAddButton.Location = new System.Drawing.Point(21, 381);
            this.VacAddButton.Name = "VacAddButton";
            this.VacAddButton.Size = new System.Drawing.Size(153, 26);
            this.VacAddButton.TabIndex = 12;
            this.VacAddButton.Text = "Добавить";
            this.VacAddButton.UseVisualStyleBackColor = true;
            this.VacAddButton.Click += new System.EventHandler(this.VacAddButton_Click);
            // 
            // VacAlterButton
            // 
            this.VacAlterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VacAlterButton.Location = new System.Drawing.Point(182, 381);
            this.VacAlterButton.Name = "VacAlterButton";
            this.VacAlterButton.Size = new System.Drawing.Size(153, 26);
            this.VacAlterButton.TabIndex = 13;
            this.VacAlterButton.Text = "Изменить";
            this.VacAlterButton.UseVisualStyleBackColor = true;
            this.VacAlterButton.Click += new System.EventHandler(this.VacAlterButton_Click);
            // 
            // VacDelButton
            // 
            this.VacDelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VacDelButton.Location = new System.Drawing.Point(182, 413);
            this.VacDelButton.Name = "VacDelButton";
            this.VacDelButton.Size = new System.Drawing.Size(153, 26);
            this.VacDelButton.TabIndex = 14;
            this.VacDelButton.Text = "Удалить";
            this.VacDelButton.UseVisualStyleBackColor = true;
            this.VacDelButton.Click += new System.EventHandler(this.VacDelButton_Click);
            // 
            // PetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1202, 519);
            this.Controls.Add(this.VacPanel);
            this.Controls.Add(this.PetPanel);
            this.Controls.Add(this.OwnerPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PetsForm_FormClosing);
            this.OwnerPanel.ResumeLayout(false);
            this.OwnerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGOwners)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PetPanel.ResumeLayout(false);
            this.PetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPets)).EndInit();
            this.VacPanel.ResumeLayout(false);
            this.VacPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel OwnerPanel;
        private System.Windows.Forms.Label OwnerLabel;
        private System.Windows.Forms.DataGridView DGOwners;
        private System.Windows.Forms.Label LBLabel;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label SNLabel;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.TextBox SecondNameTB;
        private System.Windows.Forms.TextBox TelTB;
        private System.Windows.Forms.Label TelLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.Button OwAddButton;
        private System.Windows.Forms.Button OwDelButton;
        private System.Windows.Forms.Button OwAlterBotton;
        private System.Windows.Forms.Panel PetPanel;
        private System.Windows.Forms.DataGridView DGPets;
        private System.Windows.Forms.Label PetsLabel;
        private System.Windows.Forms.Button PetAddButton;
        private System.Windows.Forms.TextBox PetTypeTB;
        private System.Windows.Forms.TextBox PetNameTB;
        private System.Windows.Forms.Label PetTypeLabel;
        private System.Windows.Forms.Label PetNameLabel;
        private System.Windows.Forms.Button PetAlterButton;
        private System.Windows.Forms.Button PetDelButton;
        private System.Windows.Forms.Label AllPetsLabel;
        private System.Windows.Forms.Panel VacPanel;
        private System.Windows.Forms.DataGridView DGVac;
        private System.Windows.Forms.Label VacLabel;
        private System.Windows.Forms.Button VacAddButton;
        private System.Windows.Forms.TextBox VacTypeTB;
        private System.Windows.Forms.Label VacTypeLabel;
        private System.Windows.Forms.Button VacAlterButton;
        private System.Windows.Forms.Button VacDelButton;
    }
}