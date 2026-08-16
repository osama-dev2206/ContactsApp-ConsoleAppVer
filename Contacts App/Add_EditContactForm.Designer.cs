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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_EditContactForm));
            pictureBox1 = new PictureBox();
            labNewFormState = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            tbFirstName = new TextBox();
            label1 = new Label();
            tbLastName = new TextBox();
            label2 = new Label();
            mtbEmail = new MaskedTextBox();
            label4 = new Label();
            label5 = new Label();
            mtbPhone = new MaskedTextBox();
            tbAddress = new TextBox();
            label3 = new Label();
            label6 = new Label();
            dtDateOfBirth = new DateTimePicker();
            label7 = new Label();
            cbCountryName = new ComboBox();
            linkLabelChangePhoto = new LinkLabel();
            LinkLabelDeletePhoto = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
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
            // labNewFormState
            // 
            labNewFormState.Dock = DockStyle.Top;
            labNewFormState.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labNewFormState.Location = new Point(0, 0);
            labNewFormState.Name = "labNewFormState";
            labNewFormState.Size = new Size(536, 31);
            labNewFormState.TabIndex = 1;
            labNewFormState.Text = "Add New Contact";
            labNewFormState.TextAlign = ContentAlignment.MiddleCenter;
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
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.BackColor = SystemColors.ActiveCaption;
            btnCancel.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(110, 434);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.TopCenter;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tbFirstName
            // 
            tbFirstName.BorderStyle = BorderStyle.None;
            tbFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbFirstName.Location = new Point(155, 70);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.PlaceholderText = "Enter Your First Name";
            tbFirstName.Size = new Size(214, 23);
            tbFirstName.TabIndex = 4;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            tbFirstName.Validating += TextBoxes_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(25, 70);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 5;
            label1.Text = "First Name ";
            // 
            // tbLastName
            // 
            tbLastName.BorderStyle = BorderStyle.None;
            tbLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbLastName.Location = new Point(149, 120);
            tbLastName.Name = "tbLastName";
            tbLastName.PlaceholderText = "Enter Your Last Name";
            tbLastName.Size = new Size(214, 23);
            tbLastName.TabIndex = 4;
            tbLastName.TextChanged += tbLastName_TextChanged;
            tbLastName.Validating += TextBoxes_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(26, 120);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // mtbEmail
            // 
            mtbEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mtbEmail.Location = new Point(151, 168);
            mtbEmail.Mask = "AAAAAAAAAA@AAaaa.com";
            mtbEmail.Name = "mtbEmail";
            mtbEmail.Size = new Size(211, 27);
            mtbEmail.TabIndex = 8;
            mtbEmail.TextChanged += mtbEmail_TextChanged;
            mtbEmail.Validating += mtbPhone_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(44, 169);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(40, 210);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 12;
            label5.Text = "Phone";
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(151, 210);
            mtbPhone.Mask = "\\(\\+\\2\\0\\)\\ 0000000000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(211, 27);
            mtbPhone.TabIndex = 13;
            mtbPhone.TextChanged += mtbPhone_TextChanged;
            mtbPhone.Validating += mtbPhone_Validating;
            // 
            // tbAddress
            // 
            tbAddress.BorderStyle = BorderStyle.None;
            tbAddress.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbAddress.Location = new Point(149, 249);
            tbAddress.Name = "tbAddress";
            tbAddress.PlaceholderText = " Enter Your Address";
            tbAddress.Size = new Size(214, 23);
            tbAddress.TabIndex = 14;
            tbAddress.TextChanged += tbAddress_TextChanged;
            tbAddress.Validating += TextBoxes_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(34, 249);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 15;
            label3.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(6, 286);
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 16;
            label6.Text = "Date Of Birth";
            // 
            // dtDateOfBirth
            // 
            dtDateOfBirth.CalendarFont = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDateOfBirth.Format = DateTimePickerFormat.Short;
            dtDateOfBirth.Location = new Point(123, 284);
            dtDateOfBirth.MinDate = new DateTime(1990, 1, 1, 0, 0, 0, 0);
            dtDateOfBirth.Name = "dtDateOfBirth";
            dtDateOfBirth.Size = new Size(266, 27);
            dtDateOfBirth.TabIndex = 17;
            dtDateOfBirth.ValueChanged += dtDateOfBirth_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(0, 340);
            label7.Name = "label7";
            label7.Size = new Size(124, 23);
            label7.TabIndex = 18;
            label7.Text = "Country Name";
            // 
            // cbCountryName
            // 
            cbCountryName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountryName.FlatStyle = FlatStyle.Popup;
            cbCountryName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbCountryName.FormattingEnabled = true;
            cbCountryName.Location = new Point(127, 335);
            cbCountryName.Name = "cbCountryName";
            cbCountryName.Size = new Size(266, 28);
            cbCountryName.Sorted = true;
            cbCountryName.TabIndex = 19;
            cbCountryName.SelectedIndexChanged += cbCountryName_SelectedIndexChanged;
            cbCountryName.Validating += cbCountryName_Validating;
            // 
            // linkLabelChangePhoto
            // 
            linkLabelChangePhoto.AutoSize = true;
            linkLabelChangePhoto.Font = new Font("SF Pro Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelChangePhoto.Location = new Point(418, 217);
            linkLabelChangePhoto.Name = "linkLabelChangePhoto";
            linkLabelChangePhoto.Size = new Size(82, 20);
            linkLabelChangePhoto.TabIndex = 20;
            linkLabelChangePhoto.TabStop = true;
            linkLabelChangePhoto.Text = "set photo";
            linkLabelChangePhoto.Visible = false;
            linkLabelChangePhoto.LinkClicked += linkLabelChangePhoto_LinkClicked;
            // 
            // LinkLabelDeletePhoto
            // 
            LinkLabelDeletePhoto.ActiveLinkColor = Color.IndianRed;
            LinkLabelDeletePhoto.AutoSize = true;
            LinkLabelDeletePhoto.Font = new Font("SF Pro Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkLabelDeletePhoto.LinkColor = Color.FromArgb(192, 0, 0);
            LinkLabelDeletePhoto.Location = new Point(412, 253);
            LinkLabelDeletePhoto.Name = "LinkLabelDeletePhoto";
            LinkLabelDeletePhoto.Size = new Size(94, 18);
            LinkLabelDeletePhoto.TabIndex = 21;
            LinkLabelDeletePhoto.TabStop = true;
            LinkLabelDeletePhoto.Text = "delete photo";
            LinkLabelDeletePhoto.Visible = false;
            LinkLabelDeletePhoto.LinkClicked += LinkLabelDeletePhoto_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Add_EditContactForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(536, 482);
            Controls.Add(LinkLabelDeletePhoto);
            Controls.Add(linkLabelChangePhoto);
            Controls.Add(cbCountryName);
            Controls.Add(label7);
            Controls.Add(dtDateOfBirth);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(tbAddress);
            Controls.Add(mtbPhone);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(mtbEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(labNewFormState);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Add_EditContactForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Contact";
            FormClosing += Add_EditContactForm_FormClosing;
            Load += Add_EditContactForm_Load;
            Validating += cbCountryName_Validating;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labNewFormState;
        private Button btnSave;
        private Button btnCancel;
        private TextBox tbFirstName;
        private Label label1;
        private TextBox tbLastName;
        private Label label2;
        private MaskedTextBox mtbEmail;
        private Label label4;
        private Label label5;
        private MaskedTextBox mtbPhone;
        private TextBox tbAddress;
        private Label label3;
        private Label label6;
        private DateTimePicker dtDateOfBirth;
        private Label label7;
        private ComboBox cbCountryName;
        private LinkLabel linkLabelChangePhoto;
        private LinkLabel LinkLabelDeletePhoto;
        private OpenFileDialog openFileDialog1;
        private ErrorProvider errorProvider1;
    }
}