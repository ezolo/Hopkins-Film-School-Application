namespace Zolotarev_4
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.filmImage = new System.Windows.Forms.PictureBox();
            this.filmSchoolLabel = new System.Windows.Forms.Label();
            this.dateSelection = new System.Windows.Forms.MaskedTextBox();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.registrantInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.dobTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.registrationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.registrationTotal = new System.Windows.Forms.Label();
            this.totalPriceofRegistrationLabel = new System.Windows.Forms.Label();
            this.pricesForClassTypes = new System.Windows.Forms.Label();
            this.pricesForClassesLabel = new System.Windows.Forms.Label();
            this.numbOfClasses = new System.Windows.Forms.Label();
            this.numberOfClassesLabel = new System.Windows.Forms.Label();
            this.availableClassesLabel = new System.Windows.Forms.Label();
            this.classesListBox = new System.Windows.Forms.ListBox();
            this.animationButton = new System.Windows.Forms.RadioButton();
            this.liveActionButton = new System.Windows.Forms.RadioButton();
            this.typesOfClassesLabel = new System.Windows.Forms.Label();
            this.paymentTypeLabel = new System.Windows.Forms.Label();
            this.cashButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptRequestedLabel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmImage)).BeginInit();
            this.registrantInfoGroupBox.SuspendLayout();
            this.registrationInfoGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // filmImage
            // 
            this.filmImage.Image = ((System.Drawing.Image)(resources.GetObject("filmImage.Image")));
            this.filmImage.Location = new System.Drawing.Point(275, 12);
            this.filmImage.Name = "filmImage";
            this.filmImage.Size = new System.Drawing.Size(240, 158);
            this.filmImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filmImage.TabIndex = 0;
            this.filmImage.TabStop = false;
            // 
            // filmSchoolLabel
            // 
            this.filmSchoolLabel.AutoSize = true;
            this.filmSchoolLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filmSchoolLabel.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmSchoolLabel.Location = new System.Drawing.Point(246, 173);
            this.filmSchoolLabel.Name = "filmSchoolLabel";
            this.filmSchoolLabel.Size = new System.Drawing.Size(286, 39);
            this.filmSchoolLabel.TabIndex = 1;
            this.filmSchoolLabel.Text = "Hopkin\'s Film School";
            // 
            // dateSelection
            // 
            this.dateSelection.Location = new System.Drawing.Point(417, 225);
            this.dateSelection.Mask = "00/00/0000";
            this.dateSelection.Name = "dateSelection";
            this.dateSelection.Size = new System.Drawing.Size(100, 26);
            this.dateSelection.TabIndex = 1;
            this.dateSelection.ValidatingType = typeof(System.DateTime);
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.AutoSize = true;
            this.registrationDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationDateLabel.Location = new System.Drawing.Point(255, 227);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(154, 22);
            this.registrationDateLabel.TabIndex = 3;
            this.registrationDateLabel.Text = "Registration Date:";
            // 
            // registrantInfoGroupBox
            // 
            this.registrantInfoGroupBox.Controls.Add(this.statusComboBox);
            this.registrantInfoGroupBox.Controls.Add(this.statusLabel);
            this.registrantInfoGroupBox.Controls.Add(this.dobTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.emailTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.registrantInfoGroupBox.Controls.Add(this.dobLabel);
            this.registrantInfoGroupBox.Controls.Add(this.emailLabel);
            this.registrantInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.registrantInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.registrantInfoGroupBox.Location = new System.Drawing.Point(12, 273);
            this.registrantInfoGroupBox.Name = "registrantInfoGroupBox";
            this.registrantInfoGroupBox.Size = new System.Drawing.Size(748, 93);
            this.registrantInfoGroupBox.TabIndex = 4;
            this.registrantInfoGroupBox.TabStop = false;
            this.registrantInfoGroupBox.Text = "Registrant Information";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(383, 56);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(139, 28);
            this.statusComboBox.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(217, 59);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(156, 20);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "Status of Registrant:";
            // 
            // dobTextBox
            // 
            this.dobTextBox.Location = new System.Drawing.Point(111, 56);
            this.dobTextBox.Mask = "00/00/0000";
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(100, 26);
            this.dobTextBox.TabIndex = 5;
            this.dobTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(570, 19);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(172, 26);
            this.emailTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(313, 19);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(130, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(102, 19);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(109, 26);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(6, 59);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(103, 20);
            this.dobLabel.TabIndex = 3;
            this.dobLabel.Text = "Date of Birth:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(449, 22);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(115, 20);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email Address:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(217, 22);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 22);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // registrationInfoGroupBox
            // 
            this.registrationInfoGroupBox.Controls.Add(this.registrationTotal);
            this.registrationInfoGroupBox.Controls.Add(this.totalPriceofRegistrationLabel);
            this.registrationInfoGroupBox.Controls.Add(this.pricesForClassTypes);
            this.registrationInfoGroupBox.Controls.Add(this.pricesForClassesLabel);
            this.registrationInfoGroupBox.Controls.Add(this.numbOfClasses);
            this.registrationInfoGroupBox.Controls.Add(this.numberOfClassesLabel);
            this.registrationInfoGroupBox.Controls.Add(this.availableClassesLabel);
            this.registrationInfoGroupBox.Controls.Add(this.classesListBox);
            this.registrationInfoGroupBox.Controls.Add(this.animationButton);
            this.registrationInfoGroupBox.Controls.Add(this.liveActionButton);
            this.registrationInfoGroupBox.Controls.Add(this.typesOfClassesLabel);
            this.registrationInfoGroupBox.Location = new System.Drawing.Point(12, 372);
            this.registrationInfoGroupBox.Name = "registrationInfoGroupBox";
            this.registrationInfoGroupBox.Size = new System.Drawing.Size(748, 128);
            this.registrationInfoGroupBox.TabIndex = 5;
            this.registrationInfoGroupBox.TabStop = false;
            this.registrationInfoGroupBox.Text = "Registration Information";
            // 
            // registrationTotal
            // 
            this.registrationTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registrationTotal.Location = new System.Drawing.Point(656, 86);
            this.registrationTotal.Name = "registrationTotal";
            this.registrationTotal.Size = new System.Drawing.Size(72, 22);
            this.registrationTotal.TabIndex = 10;
            this.registrationTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalPriceofRegistrationLabel
            // 
            this.totalPriceofRegistrationLabel.AutoSize = true;
            this.totalPriceofRegistrationLabel.Location = new System.Drawing.Point(455, 88);
            this.totalPriceofRegistrationLabel.Name = "totalPriceofRegistrationLabel";
            this.totalPriceofRegistrationLabel.Size = new System.Drawing.Size(195, 20);
            this.totalPriceofRegistrationLabel.TabIndex = 9;
            this.totalPriceofRegistrationLabel.Text = "Total Price of Registration:";
            // 
            // pricesForClassTypes
            // 
            this.pricesForClassTypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pricesForClassTypes.Location = new System.Drawing.Point(617, 59);
            this.pricesForClassTypes.Name = "pricesForClassTypes";
            this.pricesForClassTypes.Size = new System.Drawing.Size(67, 21);
            this.pricesForClassTypes.TabIndex = 8;
            this.pricesForClassTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pricesForClassesLabel
            // 
            this.pricesForClassesLabel.AutoSize = true;
            this.pricesForClassesLabel.Location = new System.Drawing.Point(455, 59);
            this.pricesForClassesLabel.Name = "pricesForClassesLabel";
            this.pricesForClassesLabel.Size = new System.Drawing.Size(156, 20);
            this.pricesForClassesLabel.TabIndex = 7;
            this.pricesForClassesLabel.Text = "Price per Class Type:";
            // 
            // numbOfClasses
            // 
            this.numbOfClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numbOfClasses.Location = new System.Drawing.Point(675, 32);
            this.numbOfClasses.Name = "numbOfClasses";
            this.numbOfClasses.Size = new System.Drawing.Size(22, 21);
            this.numbOfClasses.TabIndex = 6;
            this.numbOfClasses.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.numbOfClasses.Click += new System.EventHandler(this.numbOfClasses_Click);
            // 
            // numberOfClassesLabel
            // 
            this.numberOfClassesLabel.AutoSize = true;
            this.numberOfClassesLabel.Location = new System.Drawing.Point(455, 32);
            this.numberOfClassesLabel.Name = "numberOfClassesLabel";
            this.numberOfClassesLabel.Size = new System.Drawing.Size(214, 20);
            this.numberOfClassesLabel.TabIndex = 5;
            this.numberOfClassesLabel.Text = "Number of Classes Selected:";
            // 
            // availableClassesLabel
            // 
            this.availableClassesLabel.Location = new System.Drawing.Point(139, 32);
            this.availableClassesLabel.Name = "availableClassesLabel";
            this.availableClassesLabel.Size = new System.Drawing.Size(104, 84);
            this.availableClassesLabel.TabIndex = 4;
            // 
            // classesListBox
            // 
            this.classesListBox.FormattingEnabled = true;
            this.classesListBox.ItemHeight = 20;
            this.classesListBox.Location = new System.Drawing.Point(249, 28);
            this.classesListBox.Name = "classesListBox";
            this.classesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.classesListBox.Size = new System.Drawing.Size(200, 84);
            this.classesListBox.Sorted = true;
            this.classesListBox.TabIndex = 8;
            this.classesListBox.SelectedIndexChanged += new System.EventHandler(this.classesListBox_SelectedIndexChanged);
            // 
            // animationButton
            // 
            this.animationButton.AutoSize = true;
            this.animationButton.Location = new System.Drawing.Point(10, 88);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(105, 24);
            this.animationButton.TabIndex = 2;
            this.animationButton.Text = "Animation";
            this.animationButton.UseVisualStyleBackColor = true;
            this.animationButton.CheckedChanged += new System.EventHandler(this.animationButton_CheckedChanged);
            // 
            // liveActionButton
            // 
            this.liveActionButton.AutoSize = true;
            this.liveActionButton.Checked = true;
            this.liveActionButton.Location = new System.Drawing.Point(10, 55);
            this.liveActionButton.Name = "liveActionButton";
            this.liveActionButton.Size = new System.Drawing.Size(111, 24);
            this.liveActionButton.TabIndex = 7;
            this.liveActionButton.TabStop = true;
            this.liveActionButton.Text = "Live Action";
            this.liveActionButton.UseVisualStyleBackColor = true;
            this.liveActionButton.CheckedChanged += new System.EventHandler(this.liveActionButton_CheckedChanged);
            // 
            // typesOfClassesLabel
            // 
            this.typesOfClassesLabel.AutoSize = true;
            this.typesOfClassesLabel.Location = new System.Drawing.Point(6, 32);
            this.typesOfClassesLabel.Name = "typesOfClassesLabel";
            this.typesOfClassesLabel.Size = new System.Drawing.Size(108, 20);
            this.typesOfClassesLabel.TabIndex = 0;
            this.typesOfClassesLabel.Text = "Type of Class:";
            // 
            // paymentTypeLabel
            // 
            this.paymentTypeLabel.AutoSize = true;
            this.paymentTypeLabel.Location = new System.Drawing.Point(262, 503);
            this.paymentTypeLabel.Name = "paymentTypeLabel";
            this.paymentTypeLabel.Size = new System.Drawing.Size(113, 20);
            this.paymentTypeLabel.TabIndex = 6;
            this.paymentTypeLabel.Text = "Payment Type:";
            // 
            // cashButton
            // 
            this.cashButton.AutoSize = true;
            this.cashButton.Checked = true;
            this.cashButton.Location = new System.Drawing.Point(376, 501);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(71, 24);
            this.cashButton.TabIndex = 9;
            this.cashButton.TabStop = true;
            this.cashButton.Text = "Cash";
            this.cashButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.AutoSize = true;
            this.checkButton.Location = new System.Drawing.Point(453, 501);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(79, 24);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "Click for more things to do with saving, clearing,and exiting form";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.ToolTipText = "Saves/Displays Form";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.clearToolStripMenuItem.Text = "&Clear";
            this.clearToolStripMenuItem.ToolTipText = "Clears form";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(215, 34);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.ToolTipText = "Exits program";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.ToolTipText = "Click for more information about the program";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.ToolTipText = "More information on project";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // receiptRequestedLabel
            // 
            this.receiptRequestedLabel.AutoSize = true;
            this.receiptRequestedLabel.Location = new System.Drawing.Point(287, 531);
            this.receiptRequestedLabel.Name = "receiptRequestedLabel";
            this.receiptRequestedLabel.Size = new System.Drawing.Size(216, 24);
            this.receiptRequestedLabel.TabIndex = 10;
            this.receiptRequestedLabel.Text = "Email Receipt Requested";
            this.receiptRequestedLabel.UseVisualStyleBackColor = true;
            this.receiptRequestedLabel.CheckedChanged += new System.EventHandler(this.receiptRequestedLabel_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 565);
            this.Controls.Add(this.receiptRequestedLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.paymentTypeLabel);
            this.Controls.Add(this.registrationInfoGroupBox);
            this.Controls.Add(this.registrantInfoGroupBox);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.dateSelection);
            this.Controls.Add(this.filmSchoolLabel);
            this.Controls.Add(this.filmImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmImage)).EndInit();
            this.registrantInfoGroupBox.ResumeLayout(false);
            this.registrantInfoGroupBox.PerformLayout();
            this.registrationInfoGroupBox.ResumeLayout(false);
            this.registrationInfoGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filmImage;
        private System.Windows.Forms.Label filmSchoolLabel;
        private System.Windows.Forms.MaskedTextBox dateSelection;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.GroupBox registrantInfoGroupBox;
        private System.Windows.Forms.GroupBox registrationInfoGroupBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.MaskedTextBox dobTextBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RadioButton animationButton;
        private System.Windows.Forms.RadioButton liveActionButton;
        private System.Windows.Forms.Label typesOfClassesLabel;
        private System.Windows.Forms.Label registrationTotal;
        private System.Windows.Forms.Label totalPriceofRegistrationLabel;
        private System.Windows.Forms.Label pricesForClassTypes;
        private System.Windows.Forms.Label pricesForClassesLabel;
        private System.Windows.Forms.Label numbOfClasses;
        private System.Windows.Forms.Label numberOfClassesLabel;
        private System.Windows.Forms.Label availableClassesLabel;
        private System.Windows.Forms.ListBox classesListBox;
        private System.Windows.Forms.Label paymentTypeLabel;
        private System.Windows.Forms.RadioButton cashButton;
        private System.Windows.Forms.RadioButton checkButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox receiptRequestedLabel;
    }
}

