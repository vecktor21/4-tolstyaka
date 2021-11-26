
namespace Управление_базой_данных
{
    partial class CakeRedactorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CakeRedactorForm));
            System.Windows.Forms.Label cakeNameLabel;
            System.Windows.Forms.Label cakeIDLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label cakeWEIGHTLabel;
            System.Windows.Forms.Label discriptionLabel;
            System.Windows.Forms.Label compositionLabel;
            this.bakeryDBDataSet = new Управление_базой_данных.BakeryDBDataSet();
            this.cakesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cakesTableAdapter = new Управление_базой_данных.BakeryDBDataSetTableAdapters.CakesTableAdapter();
            this.tableAdapterManager = new Управление_базой_данных.BakeryDBDataSetTableAdapters.TableAdapterManager();
            this.cakesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cakesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cakeNameTextBox = new System.Windows.Forms.TextBox();
            this.cakeIDTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.cakeWEIGHTTextBox = new System.Windows.Forms.TextBox();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.compositionTextBox = new System.Windows.Forms.TextBox();
            cakeNameLabel = new System.Windows.Forms.Label();
            cakeIDLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            cakeWEIGHTLabel = new System.Windows.Forms.Label();
            discriptionLabel = new System.Windows.Forms.Label();
            compositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesBindingNavigator)).BeginInit();
            this.cakesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bakeryDBDataSet
            // 
            this.bakeryDBDataSet.DataSetName = "BakeryDBDataSet";
            this.bakeryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cakesBindingSource
            // 
            this.cakesBindingSource.DataMember = "Cakes";
            this.cakesBindingSource.DataSource = this.bakeryDBDataSet;
            // 
            // cakesTableAdapter
            // 
            this.cakesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CakesTableAdapter = this.cakesTableAdapter;
            this.tableAdapterManager.PositionsTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Управление_базой_данных.BakeryDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // cakesBindingNavigator
            // 
            this.cakesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cakesBindingNavigator.BindingSource = this.cakesBindingSource;
            this.cakesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cakesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cakesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cakesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cakesBindingNavigatorSaveItem});
            this.cakesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cakesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cakesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cakesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cakesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cakesBindingNavigator.Name = "cakesBindingNavigator";
            this.cakesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cakesBindingNavigator.Size = new System.Drawing.Size(684, 27);
            this.cakesBindingNavigator.TabIndex = 0;
            this.cakesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // cakesBindingNavigatorSaveItem
            // 
            this.cakesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cakesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cakesBindingNavigatorSaveItem.Image")));
            this.cakesBindingNavigatorSaveItem.Name = "cakesBindingNavigatorSaveItem";
            this.cakesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cakesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cakesBindingNavigatorSaveItem.Click += new System.EventHandler(this.cakesBindingNavigatorSaveItem_Click);
            // 
            // cakeNameLabel
            // 
            cakeNameLabel.AutoSize = true;
            cakeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cakeNameLabel.Location = new System.Drawing.Point(145, 88);
            cakeNameLabel.Margin = new System.Windows.Forms.Padding(10);
            cakeNameLabel.Name = "cakeNameLabel";
            cakeNameLabel.Size = new System.Drawing.Size(161, 20);
            cakeNameLabel.TabIndex = 1;
            cakeNameLabel.Text = "Название товара:";
            // 
            // cakeNameTextBox
            // 
            this.cakeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cakesBindingSource, "CakeName", true));
            this.cakeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cakeNameTextBox.Location = new System.Drawing.Point(324, 85);
            this.cakeNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.cakeNameTextBox.Name = "cakeNameTextBox";
            this.cakeNameTextBox.Size = new System.Drawing.Size(208, 26);
            this.cakeNameTextBox.TabIndex = 2;
            // 
            // cakeIDLabel
            // 
            cakeIDLabel.AutoSize = true;
            cakeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cakeIDLabel.Location = new System.Drawing.Point(145, 134);
            cakeIDLabel.Margin = new System.Windows.Forms.Padding(10);
            cakeIDLabel.Name = "cakeIDLabel";
            cakeIDLabel.Size = new System.Drawing.Size(96, 20);
            cakeIDLabel.TabIndex = 3;
            cakeIDLabel.Text = "ID товара:";
            // 
            // cakeIDTextBox
            // 
            this.cakeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cakesBindingSource, "CakeID", true));
            this.cakeIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cakeIDTextBox.Location = new System.Drawing.Point(324, 131);
            this.cakeIDTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.cakeIDTextBox.Name = "cakeIDTextBox";
            this.cakeIDTextBox.Size = new System.Drawing.Size(208, 26);
            this.cakeIDTextBox.TabIndex = 4;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            priceLabel.Location = new System.Drawing.Point(145, 180);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(52, 20);
            priceLabel.TabIndex = 5;
            priceLabel.Text = "Цена";
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cakesBindingSource, "Price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceTextBox.Location = new System.Drawing.Point(324, 177);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(208, 26);
            this.priceTextBox.TabIndex = 6;
            // 
            // cakeWEIGHTLabel
            // 
            cakeWEIGHTLabel.AutoSize = true;
            cakeWEIGHTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            cakeWEIGHTLabel.Location = new System.Drawing.Point(145, 226);
            cakeWEIGHTLabel.Name = "cakeWEIGHTLabel";
            cakeWEIGHTLabel.Size = new System.Drawing.Size(45, 20);
            cakeWEIGHTLabel.TabIndex = 7;
            cakeWEIGHTLabel.Text = "Вес:";
            // 
            // cakeWEIGHTTextBox
            // 
            this.cakeWEIGHTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cakesBindingSource, "CakeWEIGHT", true));
            this.cakeWEIGHTTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cakeWEIGHTTextBox.Location = new System.Drawing.Point(324, 223);
            this.cakeWEIGHTTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.cakeWEIGHTTextBox.Name = "cakeWEIGHTTextBox";
            this.cakeWEIGHTTextBox.Size = new System.Drawing.Size(208, 26);
            this.cakeWEIGHTTextBox.TabIndex = 8;
            // 
            // discriptionLabel
            // 
            discriptionLabel.AutoSize = true;
            discriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            discriptionLabel.Location = new System.Drawing.Point(145, 272);
            discriptionLabel.Margin = new System.Windows.Forms.Padding(10);
            discriptionLabel.Name = "discriptionLabel";
            discriptionLabel.Size = new System.Drawing.Size(96, 20);
            discriptionLabel.TabIndex = 9;
            discriptionLabel.Text = "Описание:";
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cakesBindingSource, "Discription", true));
            this.discriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.discriptionTextBox.Location = new System.Drawing.Point(324, 269);
            this.discriptionTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(208, 26);
            this.discriptionTextBox.TabIndex = 10;
            // 
            // compositionLabel
            // 
            compositionLabel.AutoSize = true;
            compositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            compositionLabel.Location = new System.Drawing.Point(145, 318);
            compositionLabel.Margin = new System.Windows.Forms.Padding(10);
            compositionLabel.Name = "compositionLabel";
            compositionLabel.Size = new System.Drawing.Size(75, 20);
            compositionLabel.TabIndex = 11;
            compositionLabel.Text = "Состав:";
            // 
            // compositionTextBox
            // 
            this.compositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cakesBindingSource, "Composition", true));
            this.compositionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.compositionTextBox.Location = new System.Drawing.Point(324, 315);
            this.compositionTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.compositionTextBox.Name = "compositionTextBox";
            this.compositionTextBox.Size = new System.Drawing.Size(208, 26);
            this.compositionTextBox.TabIndex = 12;
            // 
            // CakeRedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 423);
            this.Controls.Add(compositionLabel);
            this.Controls.Add(this.compositionTextBox);
            this.Controls.Add(discriptionLabel);
            this.Controls.Add(this.discriptionTextBox);
            this.Controls.Add(cakeWEIGHTLabel);
            this.Controls.Add(this.cakeWEIGHTTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(cakeIDLabel);
            this.Controls.Add(this.cakeIDTextBox);
            this.Controls.Add(cakeNameLabel);
            this.Controls.Add(this.cakeNameTextBox);
            this.Controls.Add(this.cakesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "CakeRedactorForm";
            this.Text = "Редактирование продукции";
            this.Load += new System.EventHandler(this.CakeRedactorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cakesBindingNavigator)).EndInit();
            this.cakesBindingNavigator.ResumeLayout(false);
            this.cakesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BakeryDBDataSet bakeryDBDataSet;
        private System.Windows.Forms.BindingSource cakesBindingSource;
        private BakeryDBDataSetTableAdapters.CakesTableAdapter cakesTableAdapter;
        private BakeryDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cakesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cakesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cakeNameTextBox;
        private System.Windows.Forms.TextBox cakeIDTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox cakeWEIGHTTextBox;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.TextBox compositionTextBox;
    }
}