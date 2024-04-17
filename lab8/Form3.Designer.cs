namespace lab8
{
    partial class journalForm
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
            this.journalComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // journalComboBox
            // 
            this.journalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.journalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalComboBox.FormattingEnabled = true;
            this.journalComboBox.Items.AddRange(new object[] {
            "party",
            "members",
            "cities",
            "hq"});
            this.journalComboBox.Location = new System.Drawing.Point(75, 74);
            this.journalComboBox.Name = "journalComboBox";
            this.journalComboBox.Size = new System.Drawing.Size(203, 33);
            this.journalComboBox.TabIndex = 0;
            this.journalComboBox.SelectedIndexChanged += new System.EventHandler(this.journalComboBox_SelectedIndexChanged);
            // 
            // journalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.journalComboBox);
            this.Name = "journalForm";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox journalComboBox;
    }
}