namespace homework3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnSize = new System.Windows.Forms.ColumnHeader();
            this.tContent = new System.Windows.Forms.TextBox();
            this.details = new System.Windows.Forms.Panel();
            this.created_value = new System.Windows.Forms.Label();
            this.name_value = new System.Windows.Forms.Label();
            this.tCreated = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.reloadTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.details.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenToolStripMenuItem,
            this.miRunToolStripMenuItem,
            this.miExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // miOpenToolStripMenuItem
            // 
            this.miOpenToolStripMenuItem.Name = "miOpenToolStripMenuItem";
            this.miOpenToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.miOpenToolStripMenuItem.Text = "miOpen";
            this.miOpenToolStripMenuItem.Click += new System.EventHandler(this.miOpenToolStripMenuItem_Click);
            // 
            // miRunToolStripMenuItem
            // 
            this.miRunToolStripMenuItem.Name = "miRunToolStripMenuItem";
            this.miRunToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.miRunToolStripMenuItem.Text = "miRun";
            // 
            // miExitToolStripMenuItem
            // 
            this.miExitToolStripMenuItem.Name = "miExitToolStripMenuItem";
            this.miExitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.miExitToolStripMenuItem.Text = "miExit";
            this.miExitToolStripMenuItem.Click += new System.EventHandler(this.miExitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tContent);
            this.splitContainer1.Panel2.Controls.Add(this.details);
            this.splitContainer1.Size = new System.Drawing.Size(759, 491);
            this.splitContainer1.SplitterDistance = 288;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnSize});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Location = new System.Drawing.Point(0, 0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(288, 491);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 204;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.Width = 80;
            // 
            // tContent
            // 
            this.tContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tContent.Location = new System.Drawing.Point(2, 158);
            this.tContent.Multiline = true;
            this.tContent.Name = "tContent";
            this.tContent.Size = new System.Drawing.Size(465, 330);
            this.tContent.TabIndex = 2;
            // 
            // details
            // 
            this.details.Controls.Add(this.created_value);
            this.details.Controls.Add(this.name_value);
            this.details.Controls.Add(this.tCreated);
            this.details.Controls.Add(this.tName);
            this.details.Dock = System.Windows.Forms.DockStyle.Top;
            this.details.Location = new System.Drawing.Point(0, 0);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(467, 156);
            this.details.TabIndex = 1;
            this.details.Paint += new System.Windows.Forms.PaintEventHandler(this.details_Paint);
            // 
            // created_value
            // 
            this.created_value.AutoSize = true;
            this.created_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.created_value.Location = new System.Drawing.Point(219, 78);
            this.created_value.Name = "created_value";
            this.created_value.Size = new System.Drawing.Size(105, 21);
            this.created_value.TabIndex = 3;
            this.created_value.Text = "created_value";
            // 
            // name_value
            // 
            this.name_value.AutoSize = true;
            this.name_value.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_value.Location = new System.Drawing.Point(219, 30);
            this.name_value.Name = "name_value";
            this.name_value.Size = new System.Drawing.Size(93, 21);
            this.name_value.TabIndex = 2;
            this.name_value.Text = "name_value";
            // 
            // tCreated
            // 
            this.tCreated.AutoSize = true;
            this.tCreated.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tCreated.Location = new System.Drawing.Point(35, 71);
            this.tCreated.Name = "tCreated";
            this.tCreated.Size = new System.Drawing.Size(101, 30);
            this.tCreated.TabIndex = 1;
            this.tCreated.Text = "Created:";
            // 
            // tName
            // 
            this.tName.AutoSize = true;
            this.tName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tName.Location = new System.Drawing.Point(35, 23);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(80, 30);
            this.tName.TabIndex = 0;
            this.tName.Text = "Name:";
            // 
            // reloadTimer
            // 
            this.reloadTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 515);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.details.ResumeLayout(false);
            this.details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem miOpenToolStripMenuItem;
        private ToolStripMenuItem miRunToolStripMenuItem;
        private ToolStripMenuItem miExitToolStripMenuItem;
        private SplitContainer splitContainer1;
        private ListView listView2;
        private Panel details;
        private Label created_value;
        private Label name_value;
        private Label tCreated;
        private Label tName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ColumnHeader columnName;
        private ColumnHeader columnSize;
        private TextBox tContent;
        private System.Windows.Forms.Timer reloadTimer;
    }
}