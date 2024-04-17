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
            this.journalTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewJournal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // journalComboBox
            // 
            this.journalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.journalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalComboBox.FormattingEnabled = true;
            this.journalComboBox.Items.AddRange(new object[] {
            "party",
            "members",
            "cities",
            "hq"});
            this.journalComboBox.Location = new System.Drawing.Point(289, 74);
            this.journalComboBox.Name = "journalComboBox";
            this.journalComboBox.Size = new System.Drawing.Size(277, 33);
            this.journalComboBox.TabIndex = 0;
            this.journalComboBox.SelectedIndexChanged += new System.EventHandler(this.journalComboBox_SelectedIndexChanged);
            // 
            // journalTextBox
            // 
            this.journalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalTextBox.Location = new System.Drawing.Point(48, 78);
            this.journalTextBox.Name = "journalTextBox";
            this.journalTextBox.ReadOnly = true;
            this.journalTextBox.Size = new System.Drawing.Size(215, 26);
            this.journalTextBox.TabIndex = 1;
            this.journalTextBox.Text = "Выберите справочник";
            // 
            // dataGridViewJournal
            // 
            this.dataGridViewJournal.AllowUserToAddRows = false;
            this.dataGridViewJournal.AllowUserToDeleteRows = false;
            this.dataGridViewJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJournal.Location = new System.Drawing.Point(12, 279);
            this.dataGridViewJournal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewJournal.Name = "dataGridViewJournal";
            this.dataGridViewJournal.ReadOnly = true;
            this.dataGridViewJournal.RowHeadersWidth = 51;
            this.dataGridViewJournal.RowTemplate.Height = 24;
            this.dataGridViewJournal.Size = new System.Drawing.Size(33, 36);
            this.dataGridViewJournal.TabIndex = 15;
            this.dataGridViewJournal.Visible = false;
            // 
            // journalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.dataGridViewJournal);
            this.Controls.Add(this.journalTextBox);
            this.Controls.Add(this.journalComboBox);
            this.Name = "journalForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJournal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox journalComboBox;
        private System.Windows.Forms.TextBox journalTextBox;
        private System.Windows.Forms.DataGridView dataGridViewJournal;
    }
}