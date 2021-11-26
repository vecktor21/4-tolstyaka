
namespace Управление_базой_данных
{
    partial class ExDirectorForm
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
            this.ExDirectorStaffFormEditOpenButton = new System.Windows.Forms.Button();
            this.DirectorStaffFormOpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExDirectorStaffFormEditOpenButton
            // 
            this.ExDirectorStaffFormEditOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ExDirectorStaffFormEditOpenButton.Location = new System.Drawing.Point(282, 161);
            this.ExDirectorStaffFormEditOpenButton.Name = "ExDirectorStaffFormEditOpenButton";
            this.ExDirectorStaffFormEditOpenButton.Size = new System.Drawing.Size(220, 95);
            this.ExDirectorStaffFormEditOpenButton.TabIndex = 16;
            this.ExDirectorStaffFormEditOpenButton.Text = "Редактирование Сотрудников";
            this.ExDirectorStaffFormEditOpenButton.UseVisualStyleBackColor = true;
            this.ExDirectorStaffFormEditOpenButton.Click += new System.EventHandler(this.ExDirectorStaffFormEditOpenButton_Click);
            // 
            // DirectorStaffFormOpenButton
            // 
            this.DirectorStaffFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DirectorStaffFormOpenButton.Location = new System.Drawing.Point(282, 294);
            this.DirectorStaffFormOpenButton.Name = "DirectorStaffFormOpenButton";
            this.DirectorStaffFormOpenButton.Size = new System.Drawing.Size(220, 95);
            this.DirectorStaffFormOpenButton.TabIndex = 15;
            this.DirectorStaffFormOpenButton.Text = "Просмотр Сотрудников";
            this.DirectorStaffFormOpenButton.UseVisualStyleBackColor = true;
            this.DirectorStaffFormOpenButton.Click += new System.EventHandler(this.StaffFormOpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(299, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Логин:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginLabel.Location = new System.Drawing.Point(395, 112);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(75, 29);
            this.loginLabel.TabIndex = 12;
            this.loginLabel.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(130, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Вы вошли в качестве Заместителя директора";
            // 
            // ExDirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExDirectorStaffFormEditOpenButton);
            this.Controls.Add(this.DirectorStaffFormOpenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Name = "ExDirectorForm";
            this.Text = "Заместитель директора";
            this.Load += new System.EventHandler(this.FinanceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExDirectorStaffFormEditOpenButton;
        private System.Windows.Forms.Button DirectorStaffFormOpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label3;
    }
}