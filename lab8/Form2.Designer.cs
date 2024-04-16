namespace lab8
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.socialsTextBox = new System.Windows.Forms.TextBox();
            this.aboutLabelTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Location = new System.Drawing.Point(1, 59);
            this.aboutTextBox.Margin = new System.Windows.Forms.Padding(10, 1, 1, 1);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.Size = new System.Drawing.Size(384, 288);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            // 
            // socialsTextBox
            // 
            this.socialsTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.socialsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.socialsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socialsTextBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.socialsTextBox.Location = new System.Drawing.Point(110, 378);
            this.socialsTextBox.Multiline = true;
            this.socialsTextBox.Name = "socialsTextBox";
            this.socialsTextBox.ReadOnly = true;
            this.socialsTextBox.Size = new System.Drawing.Size(159, 30);
            this.socialsTextBox.TabIndex = 1;
            this.socialsTextBox.Text = "tg: @lamafout";
            this.socialsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.socialsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // aboutLabelTextBox
            // 
            this.aboutLabelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutLabelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutLabelTextBox.Location = new System.Drawing.Point(52, 12);
            this.aboutLabelTextBox.Multiline = true;
            this.aboutLabelTextBox.Name = "aboutLabelTextBox";
            this.aboutLabelTextBox.ReadOnly = true;
            this.aboutLabelTextBox.Size = new System.Drawing.Size(278, 31);
            this.aboutLabelTextBox.TabIndex = 2;
            this.aboutLabelTextBox.Text = "PosgreSQL DB Viewer";
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.aboutLabelTextBox);
            this.Controls.Add(this.socialsTextBox);
            this.Controls.Add(this.aboutTextBox);
            this.Name = "aboutForm";
            this.Text = "Об авторе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox socialsTextBox;
        private System.Windows.Forms.TextBox aboutLabelTextBox;
    }
}