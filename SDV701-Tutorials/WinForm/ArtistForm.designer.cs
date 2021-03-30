namespace ArtGallery.WinForm
{
    partial class ArtistForm
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.sort = new System.Windows.Forms.GroupBox();
            this.byDate = new System.Windows.Forms.RadioButton();
            this.byName = new System.Windows.Forms.RadioButton();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.workList = new System.Windows.Forms.ListBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.speciality = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.sort.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(155, 233);
            this.totalLabel.Name = "lblTotal";
            this.totalLabel.Size = new System.Drawing.Size(72, 16);
            this.totalLabel.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(75, 233);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 16);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Total Value";
            // 
            // sort
            // 
            this.sort.Controls.Add(this.byDate);
            this.sort.Controls.Add(this.byName);
            this.sort.Location = new System.Drawing.Point(99, 81);
            this.sort.Name = "optSort";
            this.sort.Size = new System.Drawing.Size(136, 48);
            this.sort.TabIndex = 25;
            this.sort.TabStop = false;
            this.sort.Text = "Sort By";
            // 
            // byDate
            // 
            this.byDate.Location = new System.Drawing.Point(80, 16);
            this.byDate.Name = "rbByDate";
            this.byDate.Size = new System.Drawing.Size(48, 24);
            this.byDate.TabIndex = 1;
            this.byDate.Text = "Date";
            this.byDate.CheckedChanged += new System.EventHandler(this.byDate_CheckedChanged);
            // 
            // rbByName
            // 
            this.byName.Location = new System.Drawing.Point(8, 16);
            this.byName.Name = "rbByName";
            this.byName.Size = new System.Drawing.Size(56, 24);
            this.byName.TabIndex = 0;
            this.byName.Text = "Name";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(171, 257);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(64, 32);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Close";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(91, 257);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(64, 32);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 257);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(64, 32);
            this.addButton.TabIndex = 22;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(11, 121);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 16);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Works";
            // 
            // workList
            // 
            this.workList.Location = new System.Drawing.Point(11, 137);
            this.workList.Name = "lstWorks";
            this.workList.Size = new System.Drawing.Size(224, 82);
            this.workList.TabIndex = 20;
            this.workList.DoubleClick += new System.EventHandler(this.workList_DoubleClick);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(75, 57);
            this.phone.Name = "txtPhone";
            this.phone.Size = new System.Drawing.Size(160, 20);
            this.phone.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(11, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 16);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Contact Ph";
            // 
            // speciality
            // 
            this.speciality.Location = new System.Drawing.Point(75, 33);
            this.speciality.Name = "txtSpeciality";
            this.speciality.Size = new System.Drawing.Size(160, 20);
            this.speciality.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(11, 33);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Speciality";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(75, 9);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(160, 20);
            this.name.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(11, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name";
            // 
            // ArtistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 299);
            this.ControlBox = false;
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.workList);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.speciality);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Label1);
            this.Name = "ArtistForm";
            this.Text = "Artist Details";
            this.sort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label totalLabel;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox sort;
        internal System.Windows.Forms.RadioButton byDate;
        internal System.Windows.Forms.RadioButton byName;
        internal System.Windows.Forms.Button closeButton;
        internal System.Windows.Forms.Button deleteButton;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox workList;
        internal System.Windows.Forms.TextBox phone;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox speciality;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label Label1;
    }
}