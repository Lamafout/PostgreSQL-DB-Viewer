
namespace postgr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connectButton = new System.Windows.Forms.Button();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DBTextBox = new System.Windows.Forms.TextBox();
            this.selectButton = new System.Windows.Forms.Button();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aboutMeButton = new System.Windows.Forms.Button();
            this.journalsButton = new System.Windows.Forms.Button();
            this.operationsButton = new System.Windows.Forms.Button();
            this.blackBoxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.connectButton.Location = new System.Drawing.Point(529, 293);
            this.connectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(175, 53);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(180, 216);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(112, 26);
            this.hostTextBox.TabIndex = 1;
            this.hostTextBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(299, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(299, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(180, 251);
            this.portTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(112, 26);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "5432";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(648, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "user";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(529, 214);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(112, 26);
            this.userTextBox.TabIndex = 5;
            this.userTextBox.Text = "postgres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(648, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "pass";
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(529, 249);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(112, 26);
            this.passTextBox.TabIndex = 7;
            this.passTextBox.Text = "1234";
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(299, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "DB";
            // 
            // DBTextBox
            // 
            this.DBTextBox.Location = new System.Drawing.Point(180, 293);
            this.DBTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DBTextBox.Name = "DBTextBox";
            this.DBTextBox.Size = new System.Drawing.Size(112, 26);
            this.DBTextBox.TabIndex = 9;
            this.DBTextBox.Text = "polit_party_new\r\n";
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.selectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.selectButton.Location = new System.Drawing.Point(12, 3);
            this.selectButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(175, 61);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "Отобразить таблицу";
            this.selectButton.UseVisualStyleBackColor = false;
            this.selectButton.Click += new System.EventHandler(this.selectClick);
            // 
            // tableTextBox
            // 
            this.tableTextBox.Location = new System.Drawing.Point(16, 92);
            this.tableTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.Size = new System.Drawing.Size(112, 26);
            this.tableTextBox.TabIndex = 12;
            this.tableTextBox.Text = "party";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Название таблицы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 363);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(33, 36);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // aboutMeButton
            // 
            this.aboutMeButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.aboutMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aboutMeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.aboutMeButton.Location = new System.Drawing.Point(759, 3);
            this.aboutMeButton.Name = "aboutMeButton";
            this.aboutMeButton.Size = new System.Drawing.Size(112, 61);
            this.aboutMeButton.TabIndex = 15;
            this.aboutMeButton.Text = "Об авторе";
            this.aboutMeButton.UseVisualStyleBackColor = false;
            this.aboutMeButton.Click += new System.EventHandler(this.aboutClick);
            // 
            // journalsButton
            // 
            this.journalsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.journalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.journalsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.journalsButton.Location = new System.Drawing.Point(476, 3);
            this.journalsButton.Name = "journalsButton";
            this.journalsButton.Size = new System.Drawing.Size(229, 61);
            this.journalsButton.TabIndex = 16;
            this.journalsButton.Text = "Показать справочные данные";
            this.journalsButton.UseVisualStyleBackColor = false;
            this.journalsButton.Click += new System.EventHandler(this.journalsButton_Click);
            // 
            // operationsButton
            // 
            this.operationsButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.operationsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operationsButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.operationsButton.Location = new System.Drawing.Point(476, 75);
            this.operationsButton.Name = "operationsButton";
            this.operationsButton.Size = new System.Drawing.Size(229, 61);
            this.operationsButton.TabIndex = 17;
            this.operationsButton.Text = "Показать оперативные данные";
            this.operationsButton.UseVisualStyleBackColor = false;
            this.operationsButton.Click += new System.EventHandler(this.operationsButton_Click);
            // 
            // blackBoxButton
            // 
            this.blackBoxButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.blackBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blackBoxButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.blackBoxButton.Location = new System.Drawing.Point(247, 3);
            this.blackBoxButton.Name = "blackBoxButton";
            this.blackBoxButton.Size = new System.Drawing.Size(170, 61);
            this.blackBoxButton.TabIndex = 18;
            this.blackBoxButton.Text = "Отобразить чёрный ящик";
            this.blackBoxButton.UseVisualStyleBackColor = false;
            this.blackBoxButton.Click += new System.EventHandler(this.blackBoxButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 408);
            this.Controls.Add(this.blackBoxButton);
            this.Controls.Add(this.operationsButton);
            this.Controls.Add(this.journalsButton);
            this.Controls.Add(this.aboutMeButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableTextBox);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DBTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.connectButton);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "PG Connect";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DBTextBox;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button aboutMeButton;
        private System.Windows.Forms.Button journalsButton;
        private System.Windows.Forms.Button operationsButton;
        private System.Windows.Forms.Button blackBoxButton;
    }
}

