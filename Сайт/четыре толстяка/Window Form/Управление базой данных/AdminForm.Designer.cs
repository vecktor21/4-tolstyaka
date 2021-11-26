
namespace Управление_базой_данных
{
    partial class AdminForm
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
            this.editUsersButton = new System.Windows.Forms.Button();
            this.openUsersTableFormButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editUsersButton
            // 
            this.editUsersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.editUsersButton.Location = new System.Drawing.Point(149, 183);
            this.editUsersButton.Name = "editUsersButton";
            this.editUsersButton.Size = new System.Drawing.Size(175, 82);
            this.editUsersButton.TabIndex = 0;
            this.editUsersButton.Text = "Редактировать пользователей";
            this.editUsersButton.UseVisualStyleBackColor = true;
            this.editUsersButton.Click += new System.EventHandler(this.editUsersButton_Click);
            // 
            // openUsersTableFormButton
            // 
            this.openUsersTableFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.openUsersTableFormButton.Location = new System.Drawing.Point(149, 286);
            this.openUsersTableFormButton.Name = "openUsersTableFormButton";
            this.openUsersTableFormButton.Size = new System.Drawing.Size(175, 99);
            this.openUsersTableFormButton.TabIndex = 2;
            this.openUsersTableFormButton.Text = "Просмотр пользователей";
            this.openUsersTableFormButton.UseVisualStyleBackColor = true;
            this.openUsersTableFormButton.Click += new System.EventHandler(this.openUsersTableFormButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginLabel.Location = new System.Drawing.Point(240, 81);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(75, 29);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вы вошли в качестве администратора";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(144, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.openUsersTableFormButton);
            this.Controls.Add(this.editUsersButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Админ";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editUsersButton;
        private System.Windows.Forms.Button openUsersTableFormButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}