namespace ArtGallery.WinForm
{
    partial class WorkForm
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
            this.value = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.creation = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(97, 81);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(96, 20);
            this.value.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(9, 84);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Value  $";
            // 
            // creation
            // 
            this.creation.Location = new System.Drawing.Point(97, 49);
            this.creation.Name = "creation";
            this.creation.Size = new System.Drawing.Size(96, 20);
            this.creation.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(9, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "Creation Date";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(97, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(96, 20);
            this.name.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(9, 20);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 40;
            this.Label3.Text = "Name";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(225, 44);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(104, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(225, 12);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(104, 23);
            this.okButton.TabIndex = 20;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 245);
            this.Controls.Add(this.value);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.creation);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox value;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox creation;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox name;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button cancelButton;
        internal System.Windows.Forms.Button okButton;
    }
}