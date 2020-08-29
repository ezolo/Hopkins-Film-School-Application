namespace Zolotarev_4
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.filmTwoImage = new System.Windows.Forms.PictureBox();
            this.copyrightDate = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.filmTwoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // filmTwoImage
            // 
            this.filmTwoImage.Image = ((System.Drawing.Image)(resources.GetObject("filmTwoImage.Image")));
            this.filmTwoImage.Location = new System.Drawing.Point(275, 12);
            this.filmTwoImage.Name = "filmTwoImage";
            this.filmTwoImage.Size = new System.Drawing.Size(240, 158);
            this.filmTwoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filmTwoImage.TabIndex = 0;
            this.filmTwoImage.TabStop = false;
            // 
            // copyrightDate
            // 
            this.copyrightDate.AutoSize = true;
            this.copyrightDate.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightDate.Location = new System.Drawing.Point(350, 210);
            this.copyrightDate.Name = "copyrightDate";
            this.copyrightDate.Size = new System.Drawing.Size(95, 37);
            this.copyrightDate.TabIndex = 1;
            this.copyrightDate.Text = "2020";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(290, 173);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(205, 37);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Eva Zolotarev";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closeButton.ForeColor = System.Drawing.Color.Transparent;
            this.closeButton.Location = new System.Drawing.Point(333, 259);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(125, 40);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Cl&ose";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Closes the Form";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 323);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.copyrightDate);
            this.Controls.Add(this.filmTwoImage);
            this.Name = "AboutForm";
            this.Text = "About Form";
            ((System.ComponentModel.ISupportInitialize)(this.filmTwoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox filmTwoImage;
        private System.Windows.Forms.Label copyrightDate;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}