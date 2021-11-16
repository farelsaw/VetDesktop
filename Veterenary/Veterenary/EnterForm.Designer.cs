
namespace Veterenary
{
    partial class EnterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.AuthLanel = new System.Windows.Forms.Label();
            this.LogLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.EnterBotton = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.AuthLanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(352, 37);
            this.TopPanel.TabIndex = 0;
            // 
            // AuthLanel
            // 
            this.AuthLanel.AutoSize = true;
            this.AuthLanel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthLanel.Location = new System.Drawing.Point(100, 0);
            this.AuthLanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AuthLanel.Name = "AuthLanel";
            this.AuthLanel.Size = new System.Drawing.Size(149, 30);
            this.AuthLanel.TabIndex = 0;
            this.AuthLanel.Text = "Авторизация";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogLabel.Location = new System.Drawing.Point(27, 52);
            this.LogLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(70, 25);
            this.LogLabel.TabIndex = 1;
            this.LogLabel.Text = "Логин";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.Location = new System.Drawing.Point(14, 86);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(83, 25);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Пароль";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(105, 52);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(224, 29);
            this.LoginTB.TabIndex = 3;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(105, 87);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(224, 29);
            this.PassTB.TabIndex = 4;
            // 
            // EnterBotton
            // 
            this.EnterBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterBotton.Location = new System.Drawing.Point(129, 131);
            this.EnterBotton.Name = "EnterBotton";
            this.EnterBotton.Size = new System.Drawing.Size(92, 31);
            this.EnterBotton.TabIndex = 5;
            this.EnterBotton.Text = "Войти";
            this.EnterBotton.UseVisualStyleBackColor = true;
            this.EnterBotton.Click += new System.EventHandler(this.EnterBotton_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(352, 175);
            this.Controls.Add(this.EnterBotton);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "EnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ВетМед";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label AuthLanel;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button EnterBotton;
    }
}

