﻿namespace SynNotes
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.tree = new BrightIdeasSoftware.TreeListView();
      this.cName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
      this.cDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
      this.statusBar = new System.Windows.Forms.StatusStrip();
      this.btnAdd = new System.Windows.Forms.ToolStripSplitButton();
      this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
      this.cbSearch = new System.Windows.Forms.ComboBox();
      this.tagBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.scEdit = new ScintillaNET.Scintilla();
      this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
      this.statusBar.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scEdit)).BeginInit();
      this.contextMenuTray.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.BackColor = System.Drawing.Color.Gainsboro;
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
      this.splitContainer1.Panel1.Controls.Add(this.tree);
      this.splitContainer1.Panel1.Controls.Add(this.statusBar);
      this.splitContainer1.Panel1.Controls.Add(this.cbSearch);
      this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.tagBox);
      this.splitContainer1.Panel2.Controls.Add(this.label1);
      this.splitContainer1.Panel2.Controls.Add(this.scEdit);
      this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.splitContainer1.Size = new System.Drawing.Size(1014, 646);
      this.splitContainer1.SplitterDistance = 227;
      this.splitContainer1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
      this.pictureBox1.ErrorImage = null;
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
      this.pictureBox1.Size = new System.Drawing.Size(16, 26);
      this.pictureBox1.TabIndex = 5;
      this.pictureBox1.TabStop = false;
      // 
      // tree
      // 
      this.tree.AllColumns.Add(this.cName);
      this.tree.AllColumns.Add(this.cDate);
      this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tree.BackColor = System.Drawing.SystemColors.Control;
      this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tree.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cDate});
      this.tree.FullRowSelect = true;
      this.tree.HideSelection = false;
      this.tree.Location = new System.Drawing.Point(0, 30);
      this.tree.Margin = new System.Windows.Forms.Padding(0);
      this.tree.Name = "tree";
      this.tree.OwnerDraw = true;
      this.tree.ShowGroups = false;
      this.tree.Size = new System.Drawing.Size(227, 594);
      this.tree.TabIndex = 4;
      this.tree.UseCompatibleStateImageBehavior = false;
      this.tree.View = System.Windows.Forms.View.Details;
      this.tree.VirtualMode = true;
      this.tree.SelectionChanged += new System.EventHandler(this.tree_SelectionChanged);
      // 
      // cName
      // 
      this.cName.AspectName = "Name";
      this.cName.FillsFreeSpace = true;
      this.cName.Text = "Name";
      // 
      // cDate
      // 
      this.cDate.AspectName = "";
      this.cDate.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.cDate.Text = "Date";
      this.cDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.cDate.Width = 30;
      // 
      // statusBar
      // 
      this.statusBar.BackColor = System.Drawing.SystemColors.Control;
      this.statusBar.GripMargin = new System.Windows.Forms.Padding(0);
      this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.statusText});
      this.statusBar.Location = new System.Drawing.Point(0, 624);
      this.statusBar.Name = "statusBar";
      this.statusBar.ShowItemToolTips = true;
      this.statusBar.Size = new System.Drawing.Size(227, 22);
      this.statusBar.SizingGrip = false;
      this.statusBar.TabIndex = 3;
      // 
      // btnAdd
      // 
      this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnAdd.DropDownButtonWidth = 0;
      this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
      this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
      this.btnAdd.MergeIndex = -2;
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(21, 22);
      this.btnAdd.Text = "Add Note";
      this.btnAdd.ButtonClick += new System.EventHandler(this.btnAdd_ButtonClick);
      // 
      // statusText
      // 
      this.statusText.Name = "statusText";
      this.statusText.Size = new System.Drawing.Size(191, 17);
      this.statusText.Spring = true;
      this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbSearch
      // 
      this.cbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cbSearch.BackColor = System.Drawing.SystemColors.Window;
      this.cbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.cbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
      this.cbSearch.IntegralHeight = false;
      this.cbSearch.ItemHeight = 18;
      this.cbSearch.Location = new System.Drawing.Point(16, 0);
      this.cbSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
      this.cbSearch.Name = "cbSearch";
      this.cbSearch.Size = new System.Drawing.Size(211, 26);
      this.cbSearch.TabIndex = 2;
      this.cbSearch.Tag = "hint";
      this.cbSearch.Text = "Search Notes";
      this.cbSearch.Enter += new System.EventHandler(this.cbSearch_Enter);
      this.cbSearch.Leave += new System.EventHandler(this.cbSearch_Leave);
      // 
      // tagBox
      // 
      this.tagBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tagBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.tagBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.tagBox.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.tagBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tagBox.Location = new System.Drawing.Point(37, 630);
      this.tagBox.Margin = new System.Windows.Forms.Padding(0);
      this.tagBox.Name = "tagBox";
      this.tagBox.Size = new System.Drawing.Size(746, 13);
      this.tagBox.TabIndex = 1;
      this.tagBox.TextChanged += new System.EventHandler(this.tagBox_TextChanged);
      this.tagBox.Enter += new System.EventHandler(this.tagBox_Enter);
      this.tagBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tagBox_KeyDown);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.BackColor = System.Drawing.SystemColors.Window;
      this.label1.Location = new System.Drawing.Point(0, 624);
      this.label1.Margin = new System.Windows.Forms.Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(783, 22);
      this.label1.TabIndex = 2;
      this.label1.Text = "Tags:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // scEdit
      // 
      this.scEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.scEdit.AutoComplete.IsCaseSensitive = false;
      this.scEdit.AutoComplete.ListString = "";
      this.scEdit.AutoComplete.MaxHeight = 10;
      this.scEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.scEdit.Caret.CurrentLineBackgroundAlpha = 50;
      this.scEdit.Caret.CurrentLineBackgroundColor = System.Drawing.Color.GreenYellow;
      this.scEdit.Caret.HighlightCurrentLine = true;
      this.scEdit.Caret.Width = 2;
      this.scEdit.ConfigurationManager.Language = "html";
      this.scEdit.Folding.MarkerScheme = ScintillaNET.FoldMarkerScheme.Arrow;
      this.scEdit.Indentation.ShowGuides = true;
      this.scEdit.Indentation.SmartIndentType = ScintillaNET.SmartIndent.CPP;
      this.scEdit.Indentation.TabWidth = 2;
      this.scEdit.Indentation.UseTabs = false;
      this.scEdit.LineWrapping.IndentMode = ScintillaNET.LineWrappingIndentMode.Indent;
      this.scEdit.LineWrapping.IndentSize = 1;
      this.scEdit.LineWrapping.Mode = ScintillaNET.LineWrappingMode.Word;
      this.scEdit.Location = new System.Drawing.Point(0, 0);
      this.scEdit.Name = "scEdit";
      this.scEdit.Size = new System.Drawing.Size(783, 624);
      this.scEdit.Styles.BraceBad.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.BraceLight.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.CallTip.FontName = "Segoe UI\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.ControlChar.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.Default.BackColor = System.Drawing.SystemColors.Window;
      this.scEdit.Styles.Default.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.IndentGuide.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.LastPredefined.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.LineNumber.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.Styles.Max.FontName = "Verdana\0\0\0\0\0\0\0\0\0\0\0\0\0";
      this.scEdit.TabIndex = 0;
      // 
      // notifyIcon1
      // 
      this.notifyIcon1.ContextMenuStrip = this.contextMenuTray;
      this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
      this.notifyIcon1.Text = "SynNotes";
      this.notifyIcon1.Visible = true;
      this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
      // 
      // contextMenuTray
      // 
      this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
      this.contextMenuTray.Name = "contextMenuTray";
      this.contextMenuTray.Size = new System.Drawing.Size(104, 54);
      // 
      // openToolStripMenuItem1
      // 
      this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
      this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
      this.openToolStripMenuItem1.Text = "Show";
      this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 6);
      // 
      // exitToolStripMenuItem1
      // 
      this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
      this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
      this.exitToolStripMenuItem1.Text = "Exit";
      this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "add.png");
      this.imageList1.Images.SetKeyName(1, "search.png");
      this.imageList1.Images.SetKeyName(2, "settings.png");
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1014, 646);
      this.Controls.Add(this.splitContainer1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "Form1";
      this.Text = "SynNotes";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
      this.Load += new System.EventHandler(this.Form1_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.Resize += new System.EventHandler(this.Form1_Resize);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
      this.statusBar.ResumeLayout(false);
      this.statusBar.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.scEdit)).EndInit();
      this.contextMenuTray.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ScintillaNET.Scintilla scEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private BrightIdeasSoftware.TreeListView tree;
        private BrightIdeasSoftware.OLVColumn cName;
        private BrightIdeasSoftware.OLVColumn cDate;
        private System.Windows.Forms.ToolStripSplitButton btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tagBox;
    }
}

