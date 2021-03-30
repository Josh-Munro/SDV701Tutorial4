namespace ArtGallery.WinForm
{
    partial class MainForm
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
            this.valueLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.artistList = new System.Windows.Forms.ListBox();
            this.galleryNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            this.valueLabel.Location = new System.Drawing.Point(87, 221);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(68, 16);
            this.valueLabel.TabIndex = 13;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(17, 221);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 16);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Total Value";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(164, 211);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(80, 32);
            this.quitButton.TabIndex = 11;
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(164, 67);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 32);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(164, 29);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 32);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(17, 13);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 16);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Artists";
            // 
            // artistList
            // 
            this.artistList.Location = new System.Drawing.Point(17, 29);
            this.artistList.Name = "artistList";
            this.artistList.Size = new System.Drawing.Size(136, 173);
            this.artistList.TabIndex = 7;
            this.artistList.DoubleClick += new System.EventHandler(this.artistList_DoubleClick);
            // 
            // galleryNameButton
            // 
            this.galleryNameButton.Location = new System.Drawing.Point(164, 170);
            this.galleryNameButton.Name = "galleryNameButton";
            this.galleryNameButton.Size = new System.Drawing.Size(80, 32);
            this.galleryNameButton.TabIndex = 14;
            this.galleryNameButton.Text = "Gal. Name";
            this.galleryNameButton.Click += new System.EventHandler(this.galleryNameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 253);
            this.Controls.Add(this.galleryNameButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.artistList);
            this.Name = "MainForm";
            this.Text = "Gallery (v3 C)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label valueLabel;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button quitButton;
        internal System.Windows.Forms.Button deleteButton;
        internal System.Windows.Forms.Button addButton;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ListBox artistList;
        internal System.Windows.Forms.Button galleryNameButton;
    }
}

