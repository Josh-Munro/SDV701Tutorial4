namespace ArtGallery.WinForm
{
    partial class SculptureForm
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
            this.material = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // material
            // 
            this.material.Location = new System.Drawing.Point(97, 139);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(96, 20);
            this.material.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(9, 142);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 16);
            this.Label5.TabIndex = 56;
            this.Label5.Text = "Material";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(97, 107);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(96, 20);
            this.weight.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(9, 110);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 16);
            this.Label4.TabIndex = 54;
            this.Label4.Text = "Weight";
            // 
            // SculptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(352, 181);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.material);
            this.Name = "SculptureForm";
            this.Text = "Sculpture";
            this.Controls.SetChildIndex(this.material, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.weight, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox material;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox weight;
        internal System.Windows.Forms.Label Label4;
    }
}
