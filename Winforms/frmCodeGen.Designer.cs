﻿namespace CodeGenerator
{
    partial class frmCodeGen
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeGen));
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.lvTables = new System.Windows.Forms.ListView();
            this.chTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.chColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAllowNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rtbCodeResult = new System.Windows.Forms.RichTextBox();
            this.btnGenerateDataAccessLayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerateBusinessLayer = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pbMinimizeForm = new System.Windows.Forms.PictureBox();
            this.pbCloseForm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabases
            // 
            this.cbDatabases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.cbDatabases.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(61, 25);
            this.cbDatabases.Margin = new System.Windows.Forms.Padding(5);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(219, 29);
            this.cbDatabases.TabIndex = 0;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // lvTables
            // 
            this.lvTables.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTable});
            this.lvTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lvTables.FullRowSelect = true;
            this.lvTables.GridLines = true;
            this.lvTables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTables.HideSelection = false;
            this.lvTables.Location = new System.Drawing.Point(20, 72);
            this.lvTables.MultiSelect = false;
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(260, 584);
            this.lvTables.TabIndex = 2;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            this.lvTables.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvTables_ItemSelectionChanged);
            // 
            // chTable
            // 
            this.chTable.Text = " ";
            this.chTable.Width = 220;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chColumnName,
            this.chDataType,
            this.chAllowNull});
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(307, 72);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(482, 469);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chColumnName
            // 
            this.chColumnName.Text = "Column Name";
            this.chColumnName.Width = 210;
            // 
            // chDataType
            // 
            this.chDataType.Text = "Data Type";
            this.chDataType.Width = 125;
            // 
            // chAllowNull
            // 
            this.chAllowNull.Text = "Allow Null";
            this.chAllowNull.Width = 105;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empty.png");
            this.imageList1.Images.SetKeyName(1, "key.png");
            // 
            // rtbCodeResult
            // 
            this.rtbCodeResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.rtbCodeResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rtbCodeResult.Location = new System.Drawing.Point(815, 72);
            this.rtbCodeResult.Name = "rtbCodeResult";
            this.rtbCodeResult.ReadOnly = true;
            this.rtbCodeResult.Size = new System.Drawing.Size(461, 469);
            this.rtbCodeResult.TabIndex = 4;
            this.rtbCodeResult.Text = resources.GetString("rtbCodeResult.Text");
            // 
            // btnGenerateDataAccessLayer
            // 
            this.btnGenerateDataAccessLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnGenerateDataAccessLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateDataAccessLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnGenerateDataAccessLayer.Location = new System.Drawing.Point(307, 556);
            this.btnGenerateDataAccessLayer.Name = "btnGenerateDataAccessLayer";
            this.btnGenerateDataAccessLayer.Size = new System.Drawing.Size(233, 42);
            this.btnGenerateDataAccessLayer.TabIndex = 5;
            this.btnGenerateDataAccessLayer.Text = "Generate Data Access Layer";
            this.btnGenerateDataAccessLayer.UseVisualStyleBackColor = false;
            this.btnGenerateDataAccessLayer.Click += new System.EventHandler(this.btnGenerateDataAccessLayer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button2.Location = new System.Drawing.Point(556, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = ".";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ShowNotImplementedYetMessage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.Location = new System.Drawing.Point(556, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ShowNotImplementedYetMessage);
            // 
            // btnGenerateBusinessLayer
            // 
            this.btnGenerateBusinessLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnGenerateBusinessLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateBusinessLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnGenerateBusinessLayer.Location = new System.Drawing.Point(307, 614);
            this.btnGenerateBusinessLayer.Name = "btnGenerateBusinessLayer";
            this.btnGenerateBusinessLayer.Size = new System.Drawing.Size(233, 42);
            this.btnGenerateBusinessLayer.TabIndex = 5;
            this.btnGenerateBusinessLayer.Text = "Generate Business Layer";
            this.btnGenerateBusinessLayer.UseVisualStyleBackColor = false;
            this.btnGenerateBusinessLayer.Click += new System.EventHandler(this.btnGenerateBusinessLayer_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCopy.Location = new System.Drawing.Point(815, 556);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(461, 42);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button3.Location = new System.Drawing.Point(815, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(461, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ShowNotImplementedYetMessage);
            // 
            // pbMinimizeForm
            // 
            this.pbMinimizeForm.Image = global::CodeGen.Properties.Resources.minus;
            this.pbMinimizeForm.Location = new System.Drawing.Point(1199, 24);
            this.pbMinimizeForm.Name = "pbMinimizeForm";
            this.pbMinimizeForm.Size = new System.Drawing.Size(33, 30);
            this.pbMinimizeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizeForm.TabIndex = 6;
            this.pbMinimizeForm.TabStop = false;
            this.pbMinimizeForm.Click += new System.EventHandler(this.pbMinimizeForm_Click);
            // 
            // pbCloseForm
            // 
            this.pbCloseForm.Image = global::CodeGen.Properties.Resources.remove;
            this.pbCloseForm.Location = new System.Drawing.Point(1243, 24);
            this.pbCloseForm.Name = "pbCloseForm";
            this.pbCloseForm.Size = new System.Drawing.Size(33, 30);
            this.pbCloseForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCloseForm.TabIndex = 6;
            this.pbCloseForm.TabStop = false;
            this.pbCloseForm.Click += new System.EventHandler(this.pbCloseForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodeGen.Properties.Resources.DB;
            this.pictureBox1.Location = new System.Drawing.Point(20, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pbMinimizeForm_Click);
            // 
            // CodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1265, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMinimizeForm);
            this.Controls.Add(this.pbCloseForm);
            this.Controls.Add(this.btnGenerateBusinessLayer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerateDataAccessLayer);
            this.Controls.Add(this.rtbCodeResult);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lvTables);
            this.Controls.Add(this.cbDatabases);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CodeGen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeGen";
            this.Load += new System.EventHandler(this.CodeGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader chTable;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chColumnName;
        private System.Windows.Forms.ColumnHeader chDataType;
        private System.Windows.Forms.ColumnHeader chAllowNull;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox rtbCodeResult;
        private System.Windows.Forms.Button btnGenerateDataAccessLayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerateBusinessLayer;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pbCloseForm;
        private System.Windows.Forms.PictureBox pbMinimizeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}