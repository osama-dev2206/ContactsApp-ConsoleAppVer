namespace Contacts_App
{
    partial class Add_EditContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_EditContactForm));
            pictureBox1 = new PictureBox();
            labNewForm = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            tbFirstName = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(382, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labNewForm
            // 
            labNewForm.Dock = DockStyle.Top;
            labNewForm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labNewForm.Location = new Point(0, 0);
            labNewForm.Name = "labNewForm";
            labNewForm.Size = new Size(536, 31);
            labNewForm.TabIndex = 1;
            labNewForm.Text = "Add New Contact";
            labNewForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(297, 434);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(110, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // tbFirstName
            // 
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFirstName.Location = new Point(110, 70);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.PlaceholderText = "Enter Your First Name";
            tbFirstName.Size = new Size(214, 23);
            tbFirstName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 5;
            label1.Text = "First Name ";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(110, 120);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Your Last Name";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 120);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(110, 168);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(211, 27);
            maskedTextBox1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 170);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // Add_EditContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 482);
            Controls.Add(label4);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(tbFirstName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(labNewForm);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_EditContactForm";
            Text = "Add New Contact";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labNewForm;
        private Button btnSave;
        private Button btnCancel;
        private TextBox tbFirstName;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
    }
}