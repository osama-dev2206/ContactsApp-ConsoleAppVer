namespace Contacts_App
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            grbMain = new GroupBox();
            pictureBox1 = new PictureBox();
            tbSearch = new TextBox();
            label1 = new Label();
            DGV = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsEdit = new ToolStripMenuItem();
            tsDelete = new ToolStripMenuItem();
            grbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grbMain
            // 
            grbMain.BackColor = Color.FromArgb(64, 64, 64);
            grbMain.Controls.Add(pictureBox1);
            grbMain.Controls.Add(tbSearch);
            grbMain.Controls.Add(label1);
            grbMain.Dock = DockStyle.Top;
            grbMain.ForeColor = Color.White;
            grbMain.Location = new Point(0, 0);
            grbMain.Margin = new Padding(3, 4, 3, 4);
            grbMain.Name = "grbMain";
            grbMain.Padding = new Padding(3, 4, 3, 4);
            grbMain.Size = new Size(964, 139);
            grbMain.TabIndex = 0;
            grbMain.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(727, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += AddContact_Click;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = SystemColors.InactiveCaption;
            tbSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbSearch.Location = new Point(296, 71);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "search using contact id";
            tbSearch.Size = new Size(405, 31);
            tbSearch.TabIndex = 4;
            tbSearch.TextAlign = HorizontalAlignment.Center;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(166, 62);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 1;
            label1.Text = "Search";
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.BackgroundColor = Color.Gray;
            DGV.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Dock = DockStyle.Fill;
            DGV.GridColor = SystemColors.Control;
            DGV.Location = new Point(0, 139);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV.RowHeadersWidth = 51;
            DGV.Size = new Size(964, 340);
            DGV.TabIndex = 1;
            DGV.SelectionChanged += DGV_SelectionChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsEdit, tsDelete });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(215, 84);
            contextMenuStrip1.ItemClicked += contextMenuStrip1_ItemClicked;
            // 
            // tsEdit
            // 
            tsEdit.Image = (Image)resources.GetObject("tsEdit.Image");
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(214, 26);
            tsEdit.Text = "Edit";
            // 
            // tsDelete
            // 
            tsDelete.Image = (Image)resources.GetObject("tsDelete.Image");
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(214, 26);
            tsDelete.Text = "Delete";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 479);
            Controls.Add(DGV);
            Controls.Add(grbMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts Management";
            Load += frmMain_Load;
            grbMain.ResumeLayout(false);
            grbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMain;
        private System.Windows.Forms.Label label1;
        private DataGridView DGV;
        private TextBox tbSearch;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tsEdit;
        private ToolStripMenuItem tsDelete;
    }
}

