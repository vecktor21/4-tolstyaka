﻿
namespace Управление_базой_данных
{
    partial class DirectorStaffForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorStaffForm));
            this.bakeryDBDataSet = new Управление_базой_данных.BakeryDBDataSet();
            this.staffForDirectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffForDirectorTableAdapter = new Управление_базой_данных.BakeryDBDataSetTableAdapters.staffForDirectorTableAdapter();
            this.tableAdapterManager = new Управление_базой_данных.BakeryDBDataSetTableAdapters.TableAdapterManager();
            this.staffForDirectorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.staffForDirectorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.staffForDirectorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffForDirectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffForDirectorBindingNavigator)).BeginInit();
            this.staffForDirectorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffForDirectorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bakeryDBDataSet
            // 
            this.bakeryDBDataSet.DataSetName = "BakeryDBDataSet";
            this.bakeryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffForDirectorBindingSource
            // 
            this.staffForDirectorBindingSource.DataMember = "staffForDirector";
            this.staffForDirectorBindingSource.DataSource = this.bakeryDBDataSet;
            // 
            // staffForDirectorTableAdapter
            // 
            this.staffForDirectorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CakesTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Управление_базой_данных.BakeryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // staffForDirectorBindingNavigator
            // 
            this.staffForDirectorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.staffForDirectorBindingNavigator.BindingSource = this.staffForDirectorBindingSource;
            this.staffForDirectorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staffForDirectorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.staffForDirectorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.staffForDirectorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.staffForDirectorBindingNavigatorSaveItem});
            this.staffForDirectorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.staffForDirectorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staffForDirectorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staffForDirectorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staffForDirectorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staffForDirectorBindingNavigator.Name = "staffForDirectorBindingNavigator";
            this.staffForDirectorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staffForDirectorBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.staffForDirectorBindingNavigator.TabIndex = 0;
            this.staffForDirectorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // staffForDirectorBindingNavigatorSaveItem
            // 
            this.staffForDirectorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staffForDirectorBindingNavigatorSaveItem.Enabled = false;
            this.staffForDirectorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("staffForDirectorBindingNavigatorSaveItem.Image")));
            this.staffForDirectorBindingNavigatorSaveItem.Name = "staffForDirectorBindingNavigatorSaveItem";
            this.staffForDirectorBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.staffForDirectorBindingNavigatorSaveItem.Text = "Сохранить данные";
            // 
            // staffForDirectorDataGridView
            // 
            this.staffForDirectorDataGridView.AutoGenerateColumns = false;
            this.staffForDirectorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffForDirectorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.staffForDirectorDataGridView.DataSource = this.staffForDirectorBindingSource;
            this.staffForDirectorDataGridView.Location = new System.Drawing.Point(12, 49);
            this.staffForDirectorDataGridView.Name = "staffForDirectorDataGridView";
            this.staffForDirectorDataGridView.RowHeadersWidth = 51;
            this.staffForDirectorDataGridView.RowTemplate.Height = 24;
            this.staffForDirectorDataGridView.Size = new System.Drawing.Size(625, 348);
            this.staffForDirectorDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn2.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Зарплата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // DirectorStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.staffForDirectorDataGridView);
            this.Controls.Add(this.staffForDirectorBindingNavigator);
            this.Name = "DirectorStaffForm";
            this.Text = "Просмотр сотрудников";
            this.Load += new System.EventHandler(this.DirectorStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffForDirectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffForDirectorBindingNavigator)).EndInit();
            this.staffForDirectorBindingNavigator.ResumeLayout(false);
            this.staffForDirectorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffForDirectorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BakeryDBDataSet bakeryDBDataSet;
        private System.Windows.Forms.BindingSource staffForDirectorBindingSource;
        private BakeryDBDataSetTableAdapters.staffForDirectorTableAdapter staffForDirectorTableAdapter;
        private BakeryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staffForDirectorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton staffForDirectorBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView staffForDirectorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}