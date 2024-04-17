namespace lab8
{
    partial class dataForm
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
            this.dataComboBox = new System.Windows.Forms.ComboBox();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataComboBox
            // 
            this.dataComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataComboBox.FormattingEnabled = true;
            this.dataComboBox.Items.AddRange(new object[] {
            "event",
            "member_in_event"});
            this.dataComboBox.Location = new System.Drawing.Point(287, 69);
            this.dataComboBox.Name = "dataComboBox";
            this.dataComboBox.Size = new System.Drawing.Size(280, 33);
            this.dataComboBox.TabIndex = 0;
            this.dataComboBox.SelectedIndexChanged += new System.EventHandler(this.dataComboBox_SelectedIndexChanged);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataTextBox.Location = new System.Drawing.Point(71, 73);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ReadOnly = true;
            this.dataTextBox.Size = new System.Drawing.Size(180, 26);
            this.dataTextBox.TabIndex = 1;
            this.dataTextBox.Text = "Выберите данные";
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(12, 263);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(33, 36);
            this.dataGridViewData.TabIndex = 16;
            this.dataGridViewData.Visible = false;
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.dataComboBox);
            this.Name = "dataForm";
            this.Text = "Оперативные данные";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox dataComboBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.DataGridView dataGridViewData;
    }
}