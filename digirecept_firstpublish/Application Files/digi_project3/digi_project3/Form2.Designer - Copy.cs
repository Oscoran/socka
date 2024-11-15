namespace digi_project3
{
    partial class Form2
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
            System.Windows.Forms.Label textLabel;
            System.Windows.Forms.Label ingridientsLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.descriptionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.descriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new digi_project3.Database1DataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.descriptionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ingridientsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.descriptionTableAdapter = new digi_project3.Database1DataSetTableAdapters.descriptionTableAdapter();
            this.tableAdapterManager = new digi_project3.Database1DataSetTableAdapters.TableAdapterManager();
            this.import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.clear = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            textLabel = new System.Windows.Forms.Label();
            ingridientsLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingNavigator)).BeginInit();
            this.descriptionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionDataGridView)).BeginInit();
            this.searchByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Location = new System.Drawing.Point(625, 154);
            textLabel.Name = "textLabel";
            textLabel.Size = new System.Drawing.Size(39, 20);
            textLabel.TabIndex = 2;
            textLabel.Text = "text:";
            // 
            // ingridientsLabel
            // 
            ingridientsLabel.AutoSize = true;
            ingridientsLabel.Location = new System.Drawing.Point(625, 32);
            ingridientsLabel.Name = "ingridientsLabel";
            ingridientsLabel.Size = new System.Drawing.Size(85, 20);
            ingridientsLabel.TabIndex = 7;
            ingridientsLabel.Text = "ingridients:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(107, 591);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(56, 20);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "image:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(107, 272);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 20);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(279, 272);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id:";
            // 
            // descriptionBindingNavigator
            // 
            this.descriptionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.descriptionBindingNavigator.BindingSource = this.descriptionBindingSource;
            this.descriptionBindingNavigator.CountItem = null;
            this.descriptionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.descriptionBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.descriptionBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.descriptionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.descriptionBindingNavigatorSaveItem});
            this.descriptionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.descriptionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.descriptionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.descriptionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.descriptionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.descriptionBindingNavigator.Name = "descriptionBindingNavigator";
            this.descriptionBindingNavigator.PositionItem = null;
            this.descriptionBindingNavigator.Size = new System.Drawing.Size(1222, 33);
            this.descriptionBindingNavigator.TabIndex = 0;
            this.descriptionBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // descriptionBindingSource
            // 
            this.descriptionBindingSource.DataMember = "description";
            this.descriptionBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // descriptionBindingNavigatorSaveItem
            // 
            this.descriptionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.descriptionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("descriptionBindingNavigatorSaveItem.Image")));
            this.descriptionBindingNavigatorSaveItem.Name = "descriptionBindingNavigatorSaveItem";
            this.descriptionBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.descriptionBindingNavigatorSaveItem.Text = "Save Data";
            this.descriptionBindingNavigatorSaveItem.Click += new System.EventHandler(this.descriptionBindingNavigatorSaveItem_Click);
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "text", true));
            this.textRichTextBox.Location = new System.Drawing.Point(629, 177);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(573, 478);
            this.textRichTextBox.TabIndex = 3;
            this.textRichTextBox.Text = "";
            // 
            // ingridientsRichTextBox
            // 
            this.ingridientsRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "ingridients", true));
            this.ingridientsRichTextBox.Location = new System.Drawing.Point(629, 55);
            this.ingridientsRichTextBox.Name = "ingridientsRichTextBox";
            this.ingridientsRichTextBox.Size = new System.Drawing.Size(573, 84);
            this.ingridientsRichTextBox.TabIndex = 8;
            this.ingridientsRichTextBox.Text = "";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.descriptionBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(111, 301);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(514, 287);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 9;
            this.imagePictureBox.TabStop = false;
            // 
            // descriptionDataGridView
            // 
            this.descriptionDataGridView.AutoGenerateColumns = false;
            this.descriptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.descriptionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4});
            this.descriptionDataGridView.DataSource = this.descriptionBindingSource;
            this.descriptionDataGridView.Location = new System.Drawing.Point(109, 43);
            this.descriptionDataGridView.Name = "descriptionDataGridView";
            this.descriptionDataGridView.RowHeadersWidth = 62;
            this.descriptionDataGridView.RowTemplate.Height = 28;
            this.descriptionDataGridView.Size = new System.Drawing.Size(514, 220);
            this.descriptionDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn4.HeaderText = "name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // searchByToolStrip
            // 
            this.searchByToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.searchByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.searchByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.searchByToolStripButton,
            this.toolStripButton1});
            this.searchByToolStrip.Location = new System.Drawing.Point(0, 33);
            this.searchByToolStrip.Name = "searchByToolStrip";
            this.searchByToolStrip.Size = new System.Drawing.Size(89, 656);
            this.searchByToolStrip.TabIndex = 11;
            this.searchByToolStrip.Text = "searchByToolStrip";
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(84, 25);
            this.nameToolStripLabel.Text = "name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(80, 31);
            // 
            // searchByToolStripButton
            // 
            this.searchByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchByToolStripButton.Name = "searchByToolStripButton";
            this.searchByToolStripButton.Size = new System.Drawing.Size(84, 29);
            this.searchByToolStripButton.Text = "SearchBy";
            this.searchByToolStripButton.Click += new System.EventHandler(this.searchByToolStripButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(166, 269);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 26);
            this.nameTextBox.TabIndex = 12;
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.descriptionBindingSource, "Id", true));
            this.idLabel1.Location = new System.Drawing.Point(312, 272);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 13;
            this.idLabel1.Text = "label1";
            // 
            // descriptionTableAdapter
            // 
            this.descriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.descriptionTableAdapter = this.descriptionTableAdapter;
            this.tableAdapterManager.UpdateOrder = digi_project3.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(170, 591);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(75, 31);
            this.import.TabIndex = 14;
            this.import.Text = "import";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(252, 591);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 31);
            this.clear.TabIndex = 15;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(84, 29);
            this.toolStripButton1.Text = "Print";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1222, 689);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.import);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.searchByToolStrip);
            this.Controls.Add(this.descriptionDataGridView);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(ingridientsLabel);
            this.Controls.Add(this.ingridientsRichTextBox);
            this.Controls.Add(textLabel);
            this.Controls.Add(this.textRichTextBox);
            this.Controls.Add(this.descriptionBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingNavigator)).EndInit();
            this.descriptionBindingNavigator.ResumeLayout(false);
            this.descriptionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionDataGridView)).EndInit();
            this.searchByToolStrip.ResumeLayout(false);
            this.searchByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource descriptionBindingSource;
        private Database1DataSetTableAdapters.descriptionTableAdapter descriptionTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator descriptionBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton descriptionBindingNavigatorSaveItem;
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.RichTextBox ingridientsRichTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.DataGridView descriptionDataGridView;
        private System.Windows.Forms.ToolStrip searchByToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchByToolStripButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}