
namespace Управление_базой_данных
{
    partial class DirectorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.DirectorStaffFormOpenButton = new System.Windows.Forms.Button();
            this.DirectorStaffFormEditOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(210, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(116, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Вы вошли в качестве директора";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginLabel.Location = new System.Drawing.Point(306, 65);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(75, 29);
            this.loginLabel.TabIndex = 6;
            this.loginLabel.Text = "Login";
            // 
            // DirectorStaffFormOpenButton
            // 
            this.DirectorStaffFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DirectorStaffFormOpenButton.Location = new System.Drawing.Point(194, 269);
            this.DirectorStaffFormOpenButton.Name = "DirectorStaffFormOpenButton";
            this.DirectorStaffFormOpenButton.Size = new System.Drawing.Size(220, 95);
            this.DirectorStaffFormOpenButton.TabIndex = 10;
            this.DirectorStaffFormOpenButton.Text = "Просмотр Сотрудников";
            this.DirectorStaffFormOpenButton.UseVisualStyleBackColor = true;
            this.DirectorStaffFormOpenButton.Click += new System.EventHandler(this.DirectorStaffForm_Click);
            // 
            // DirectorStaffFormEditOpenButton
            // 
            this.DirectorStaffFormEditOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DirectorStaffFormEditOpenButton.Location = new System.Drawing.Point(194, 136);
            this.DirectorStaffFormEditOpenButton.Name = "DirectorStaffFormEditOpenButton";
            this.DirectorStaffFormEditOpenButton.Size = new System.Drawing.Size(220, 95);
            this.DirectorStaffFormEditOpenButton.TabIndex = 11;
            this.DirectorStaffFormEditOpenButton.Text = "Редактирование Сотрудников";
            this.DirectorStaffFormEditOpenButton.UseVisualStyleBackColor = true;
            this.DirectorStaffFormEditOpenButton.Click += new System.EventHandler(this.DirectorStaffFormEditOpenButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 422);
            this.Controls.Add(this.DirectorStaffFormEditOpenButton);
            this.Controls.Add(this.DirectorStaffFormOpenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginLabel);
            this.Name = "DirectorForm";
            this.Text = "Директор";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button DirectorStaffFormOpenButton;
        private System.Windows.Forms.Button DirectorStaffFormEditOpenButton;
    }
}