namespace ArtGallery.WinForm
{
    partial class PaintingForm
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
            this.type = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(97, 171);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(96, 20);
            this.type.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(9, 174);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(56, 23);
            this.Label6.TabIndex = 50;
            this.Label6.Text = "Type";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(97, 139);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(96, 20);
            this.height.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(9, 142);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 23);
            this.Label5.TabIndex = 48;
            this.Label5.Text = "Height";
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(97, 107);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(96, 20);
            this.width.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(9, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 23);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "Width";
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(352, 213);
            this.Controls.Add(this.width);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.height);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.type);
            this.Name = "PaintingForm";
            this.Text = "Painting";
            this.Controls.SetChildIndex(this.type, 0);
            this.Controls.SetChildIndex(this.Label6, 0);
            this.Controls.SetChildIndex(this.height, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.width, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox type;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox height;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox width;
        internal System.Windows.Forms.Label Label4;
    }
}
