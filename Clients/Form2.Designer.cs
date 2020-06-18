namespace Clients
{
    partial class Form2
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
            this.backButton1 = new System.Windows.Forms.Button();
            this.employeeNametextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton1 = new System.Windows.Forms.Button();
            this.informationTextBox2 = new System.Windows.Forms.TextBox();
            this.procentTextBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateTextBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton1
            // 
            this.backButton1.BackColor = System.Drawing.SystemColors.Window;
            this.backButton1.Location = new System.Drawing.Point(241, 22);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(75, 23);
            this.backButton1.TabIndex = 0;
            this.backButton1.Text = "Назад";
            this.backButton1.UseVisualStyleBackColor = false;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // employeeNametextBox1
            // 
            this.employeeNametextBox1.Location = new System.Drawing.Point(12, 25);
            this.employeeNametextBox1.Name = "employeeNametextBox1";
            this.employeeNametextBox1.Size = new System.Drawing.Size(142, 20);
            this.employeeNametextBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введитте имя работника";
            // 
            // searchButton1
            // 
            this.searchButton1.BackColor = System.Drawing.SystemColors.Window;
            this.searchButton1.Location = new System.Drawing.Point(160, 22);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(75, 23);
            this.searchButton1.TabIndex = 4;
            this.searchButton1.Text = "Поиск";
            this.searchButton1.UseVisualStyleBackColor = false;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // informationTextBox2
            // 
            this.informationTextBox2.Location = new System.Drawing.Point(12, 122);
            this.informationTextBox2.Multiline = true;
            this.informationTextBox2.Name = "informationTextBox2";
            this.informationTextBox2.ReadOnly = true;
            this.informationTextBox2.Size = new System.Drawing.Size(296, 141);
            this.informationTextBox2.TabIndex = 5;
            // 
            // procentTextBox3
            // 
            this.procentTextBox3.Location = new System.Drawing.Point(12, 82);
            this.procentTextBox3.Name = "procentTextBox3";
            this.procentTextBox3.Size = new System.Drawing.Size(142, 20);
            this.procentTextBox3.TabIndex = 6;
            this.procentTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.procentTextBox3_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Процент от общей приьбыли";
            // 
            // DateTextBox4
            // 
            this.DateTextBox4.Location = new System.Drawing.Point(160, 82);
            this.DateTextBox4.Name = "DateTextBox4";
            this.DateTextBox4.Size = new System.Drawing.Size(156, 20);
            this.DateTextBox4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Число";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 275);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTextBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.procentTextBox3);
            this.Controls.Add(this.informationTextBox2);
            this.Controls.Add(this.searchButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeNametextBox1);
            this.Controls.Add(this.backButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Учет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.TextBox employeeNametextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton1;
        private System.Windows.Forms.TextBox informationTextBox2;
        private System.Windows.Forms.TextBox procentTextBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateTextBox4;
        private System.Windows.Forms.Label label3;
    }
}