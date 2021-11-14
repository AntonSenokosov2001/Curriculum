
namespace Curriculum.WinUI
{
    partial class DepartmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartmentID,
            this.DepartmentNumber,
            this.DepartmentName});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(823, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // DepartmentID
            // 
            this.DepartmentID.HeaderText = "ID";
            this.DepartmentID.MinimumWidth = 6;
            this.DepartmentID.Name = "DepartmentID";
            this.DepartmentID.Width = 125;
            // 
            // DepartmentNumber
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.DepartmentNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.DepartmentNumber.HeaderText = "Номер кафедри";
            this.DepartmentNumber.MinimumWidth = 6;
            this.DepartmentNumber.Name = "DepartmentNumber";
            this.DepartmentNumber.Width = 125;
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DepartmentName.HeaderText = "Назва кафедри";
            this.DepartmentName.MinimumWidth = 6;
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Width = 131;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Додати нову кафедру";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(869, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Редагувати кафедру";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(869, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Видалити кафедру";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}