namespace Continuous
{
    partial class ExampleForm
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.Label();
            this.BtnAddGrade = new System.Windows.Forms.Button();
            this.lbGrades = new System.Windows.Forms.ListBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(13, 13);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(57, 17);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student";
            // 
            // txtStudent
            // 
            this.txtStudent.AutoSize = true;
            this.txtStudent.Location = new System.Drawing.Point(76, 13);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(57, 17);
            this.txtStudent.TabIndex = 1;
            this.txtStudent.Text = "Student";
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.Location = new System.Drawing.Point(275, 322);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(90, 31);
            this.BtnAddGrade.TabIndex = 2;
            this.BtnAddGrade.Text = "Add Grade";
            this.BtnAddGrade.UseVisualStyleBackColor = true;
            this.BtnAddGrade.Click += new System.EventHandler(this.BtnAddGrade_Click);
            // 
            // lbGrades
            // 
            this.lbGrades.FormattingEnabled = true;
            this.lbGrades.ItemHeight = 16;
            this.lbGrades.Location = new System.Drawing.Point(79, 40);
            this.lbGrades.Name = "lbGrades";
            this.lbGrades.Size = new System.Drawing.Size(190, 276);
            this.lbGrades.TabIndex = 3;
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(12, 40);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(55, 17);
            this.lblGrades.TabIndex = 4;
            this.lblGrades.Text = "Grades";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(79, 326);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(190, 22);
            this.txtGrade.TabIndex = 5;
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(79, 364);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(190, 31);
            this.btnCalculateAverage.TabIndex = 6;
            this.btnCalculateAverage.Text = "Calculate Average";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(275, 368);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(171, 22);
            this.txtAverage.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(371, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 31);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 407);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.btnCalculateAverage);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lbGrades);
            this.Controls.Add(this.BtnAddGrade);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.lblStudent);
            this.Name = "ExampleForm";
            this.Text = "Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label txtStudent;
        private System.Windows.Forms.Button BtnAddGrade;
        private System.Windows.Forms.ListBox lbGrades;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.Button btnClear;
    }
}

