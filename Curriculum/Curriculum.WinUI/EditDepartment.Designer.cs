
namespace Curriculum.WinUI
{
    partial class EditDepartment
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
            this.label3 = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.NewNameDep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewNumDep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearNum = new System.Windows.Forms.Button();
            this.ClearName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(256, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Тільки цифри";
            this.label3.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(179, 198);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(271, 45);
            this.EditButton.TabIndex = 10;
            this.EditButton.Text = "Зберегти зміни";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // NewNameDep
            // 
            this.NewNameDep.Location = new System.Drawing.Point(256, 142);
            this.NewNameDep.Name = "NewNameDep";
            this.NewNameDep.Size = new System.Drawing.Size(194, 27);
            this.NewNameDep.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Нова назва кафедри";
            // 
            // NewNumDep
            // 
            this.NewNumDep.Location = new System.Drawing.Point(256, 86);
            this.NewNumDep.Name = "NewNumDep";
            this.NewNumDep.Size = new System.Drawing.Size(194, 27);
            this.NewNumDep.TabIndex = 7;
            this.NewNumDep.TextChanged += new System.EventHandler(this.NewNumDep_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Новий номер кафедри";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(187, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Змініть необхідні поля";
            // 
            // ClearNum
            // 
            this.ClearNum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearNum.Location = new System.Drawing.Point(456, 84);
            this.ClearNum.Name = "ClearNum";
            this.ClearNum.Size = new System.Drawing.Size(139, 29);
            this.ClearNum.TabIndex = 14;
            this.ClearNum.Text = "Очистити поле";
            this.ClearNum.UseVisualStyleBackColor = true;
            this.ClearNum.Click += new System.EventHandler(this.ClearNum_Click);
            // 
            // ClearName
            // 
            this.ClearName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearName.Location = new System.Drawing.Point(456, 141);
            this.ClearName.Name = "ClearName";
            this.ClearName.Size = new System.Drawing.Size(139, 29);
            this.ClearName.TabIndex = 15;
            this.ClearName.Text = "Очистити поле";
            this.ClearName.UseVisualStyleBackColor = true;
            this.ClearName.Click += new System.EventHandler(this.ClearName_Click);
            // 
            // EditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 310);
            this.Controls.Add(this.ClearName);
            this.Controls.Add(this.ClearNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.NewNameDep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewNumDep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагування даних кафедри №";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.TextBox NewNameDep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewNumDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearNum;
        private System.Windows.Forms.Button ClearName;
    }
}