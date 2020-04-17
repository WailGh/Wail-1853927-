namespace Loli
{
    partial class Image
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


        private void InitializeComponent()
        {
            this.ImageLoad = new System.Windows.Forms.Button();
            this.BackBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImageLoad
            // 
            this.ImageLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImageLoad.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLoad.ForeColor = System.Drawing.Color.White;
            this.ImageLoad.Location = new System.Drawing.Point(254, 62);
            this.ImageLoad.Name = "ImageLoad";
            this.ImageLoad.Size = new System.Drawing.Size(266, 195);
            this.ImageLoad.TabIndex = 0;
            this.ImageLoad.Text = "Load an Image";
            this.ImageLoad.UseVisualStyleBackColor = false;
            this.ImageLoad.Click += new System.EventHandler(this.BackBttn_Click);
            // 
            // BackBttn
            // 
            this.BackBttn.BackColor = System.Drawing.Color.Red;
            this.BackBttn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBttn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBttn.Location = new System.Drawing.Point(293, 288);
            this.BackBttn.Name = "BackBttn";
            this.BackBttn.Size = new System.Drawing.Size(178, 45);
            this.BackBttn.TabIndex = 1;
            this.BackBttn.Text = "Back";
            this.BackBttn.UseVisualStyleBackColor = false;
            // 
            // Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loli.Properties.Resources.Wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBttn);
            this.Controls.Add(this.ImageLoad);
            this.Name = "Image";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Image_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImageLoad;
        private System.Windows.Forms.Button BackBttn;
    }
}