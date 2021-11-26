
namespace Управление_базой_данных
{
    partial class StaffForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.StaffFormOpenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(220, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Вы вошли в качестве сотрудника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(305, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Логин:";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginLabel.Location = new System.Drawing.Point(401, 105);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(75, 29);
            this.loginLabel.TabIndex = 19;
            this.loginLabel.Text = "Login";
            // 
            // StaffFormOpenButton
            // 
            this.StaffFormOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.StaffFormOpenButton.Location = new System.Drawing.Point(293, 215);
            this.StaffFormOpenButton.Name = "StaffFormOpenButton";
            this.StaffFormOpenButton.Size = new System.Drawing.Size(220, 95);
            this.StaffFormOpenButton.TabIndex = 21;
            this.StaffFormOpenButton.Text = "Просмотр Сотрудников";
            this.StaffFormOpenButton.UseVisualStyleBackColor = true;
            this.StaffFormOpenButton.Click += new System.EventHandler(this.StaffFormOpenButton_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffFormOpenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.label3);
            this.Name = "StaffForm";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button StaffFormOpenButton;
    }
}