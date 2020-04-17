namespace Loli
{
    partial class frmRadio
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
            this.Groupped = new System.Windows.Forms.GroupBox();
            this.Yellow2 = new System.Windows.Forms.RadioButton();
            this.Blue2 = new System.Windows.Forms.RadioButton();
            this.Green2 = new System.Windows.Forms.RadioButton();
            this.Red2 = new System.Windows.Forms.RadioButton();
            this.Red3 = new System.Windows.Forms.RadioButton();
            this.Green3 = new System.Windows.Forms.RadioButton();
            this.Blue3 = new System.Windows.Forms.RadioButton();
            this.Yellow3 = new System.Windows.Forms.RadioButton();
            this.Reset = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Groupped.SuspendLayout();
            this.SuspendLayout();
            // 
            // Groupped
            // 
            this.Groupped.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Groupped.Controls.Add(this.Yellow2);
            this.Groupped.Controls.Add(this.Blue2);
            this.Groupped.Controls.Add(this.Green2);
            this.Groupped.Controls.Add(this.Red2);
            this.Groupped.Location = new System.Drawing.Point(174, 86);
            this.Groupped.Name = "Groupped";
            this.Groupped.Size = new System.Drawing.Size(155, 160);
            this.Groupped.TabIndex = 0;
            this.Groupped.TabStop = false;
            this.Groupped.Text = "Grouped Radio Buttons";
            this.Groupped.Enter += new System.EventHandler(this.Groupped_Enter);
            // 
            // Yellow2
            // 
            this.Yellow2.AutoSize = true;
            this.Yellow2.Location = new System.Drawing.Point(13, 127);
            this.Yellow2.Name = "Yellow2";
            this.Yellow2.Size = new System.Drawing.Size(56, 17);
            this.Yellow2.TabIndex = 3;
            this.Yellow2.TabStop = true;
            this.Yellow2.Text = "Yellow";
            this.Yellow2.UseVisualStyleBackColor = true;
            // 
            // Blue2
            // 
            this.Blue2.AutoSize = true;
            this.Blue2.Location = new System.Drawing.Point(13, 94);
            this.Blue2.Name = "Blue2";
            this.Blue2.Size = new System.Drawing.Size(46, 17);
            this.Blue2.TabIndex = 2;
            this.Blue2.TabStop = true;
            this.Blue2.Text = "Blue";
            this.Blue2.UseVisualStyleBackColor = true;
            // 
            // Green2
            // 
            this.Green2.AutoSize = true;
            this.Green2.Location = new System.Drawing.Point(13, 57);
            this.Green2.Name = "Green2";
            this.Green2.Size = new System.Drawing.Size(54, 17);
            this.Green2.TabIndex = 1;
            this.Green2.TabStop = true;
            this.Green2.Text = "Green";
            this.Green2.UseVisualStyleBackColor = true;
            // 
            // Red2
            // 
            this.Red2.AutoSize = true;
            this.Red2.Location = new System.Drawing.Point(14, 19);
            this.Red2.Name = "Red2";
            this.Red2.Size = new System.Drawing.Size(45, 17);
            this.Red2.TabIndex = 0;
            this.Red2.TabStop = true;
            this.Red2.Text = "Red";
            this.Red2.UseVisualStyleBackColor = true;
            this.Red2.CheckedChanged += new System.EventHandler(this.Red2_CheckedChanged_1);
            // 
            // Red3
            // 
            this.Red3.AutoSize = true;
            this.Red3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Red3.Location = new System.Drawing.Point(22, 105);
            this.Red3.Name = "Red3";
            this.Red3.Size = new System.Drawing.Size(45, 17);
            this.Red3.TabIndex = 1;
            this.Red3.TabStop = true;
            this.Red3.Text = "Red";
            this.Red3.UseVisualStyleBackColor = false;
            this.Red3.CheckedChanged += new System.EventHandler(this.Red3_CheckedChanged);
            // 
            // Green3
            // 
            this.Green3.AutoSize = true;
            this.Green3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Green3.Location = new System.Drawing.Point(22, 143);
            this.Green3.Name = "Green3";
            this.Green3.Size = new System.Drawing.Size(54, 17);
            this.Green3.TabIndex = 2;
            this.Green3.TabStop = true;
            this.Green3.Text = "Green";
            this.Green3.UseVisualStyleBackColor = false;
            this.Green3.CheckedChanged += new System.EventHandler(this.Green3_CheckedChanged);
            // 
            // Blue3
            // 
            this.Blue3.AutoSize = true;
            this.Blue3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Blue3.Location = new System.Drawing.Point(22, 180);
            this.Blue3.Name = "Blue3";
            this.Blue3.Size = new System.Drawing.Size(46, 17);
            this.Blue3.TabIndex = 3;
            this.Blue3.TabStop = true;
            this.Blue3.Text = "Blue";
            this.Blue3.UseVisualStyleBackColor = false;
            this.Blue3.CheckedChanged += new System.EventHandler(this.Blue3_CheckedChanged);
            // 
            // Yellow3
            // 
            this.Yellow3.AutoSize = true;
            this.Yellow3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Yellow3.Location = new System.Drawing.Point(22, 213);
            this.Yellow3.Name = "Yellow3";
            this.Yellow3.Size = new System.Drawing.Size(56, 17);
            this.Yellow3.TabIndex = 4;
            this.Yellow3.TabStop = true;
            this.Yellow3.Text = "Yellow";
            this.Yellow3.UseVisualStyleBackColor = false;
            this.Yellow3.CheckedChanged += new System.EventHandler(this.Yellow3_CheckedChanged);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Reset.Location = new System.Drawing.Point(71, 24);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(107, 56);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Back.Location = new System.Drawing.Point(71, 252);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(107, 58);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loli.Properties.Resources.Colors;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Yellow3);
            this.Controls.Add(this.Blue3);
            this.Controls.Add(this.Green3);
            this.Controls.Add(this.Red3);
            this.Controls.Add(this.Groupped);
            this.Name = "frmRadio";
            this.Text = "Blue";
            this.Groupped.ResumeLayout(false);
            this.Groupped.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Groupped;
        private System.Windows.Forms.RadioButton Yellow2;
        private System.Windows.Forms.RadioButton Blue2;
        private System.Windows.Forms.RadioButton Green2;
        private System.Windows.Forms.RadioButton Red2;
        private System.Windows.Forms.RadioButton Red3;
        private System.Windows.Forms.RadioButton Green3;
        private System.Windows.Forms.RadioButton Blue3;
        private System.Windows.Forms.RadioButton Yellow3;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Back;
    }
}