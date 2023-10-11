namespace EmployeeDirectory
{
    partial class UpdateEmployeeForm
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
            formValidationLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            employeeJobTypeTextBox = new TextBox();
            employeeNameTextBox = new TextBox();
            buttonUpdate = new Button();
            label3 = new Label();
            employeeIdTextBox = new TextBox();
            SuspendLayout();
            // 
            // formValidationLabel
            // 
            formValidationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            formValidationLabel.AutoSize = true;
            formValidationLabel.ForeColor = Color.Red;
            formValidationLabel.Location = new Point(160, 152);
            formValidationLabel.Name = "formValidationLabel";
            formValidationLabel.Size = new Size(159, 20);
            formValidationLabel.TabIndex = 12;
            formValidationLabel.Text = "Please fill out the form";
            formValidationLabel.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(87, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 11;
            label2.Text = "Job Type";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(105, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 10;
            label1.Text = "Name";
            // 
            // employeeJobTypeTextBox
            // 
            employeeJobTypeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            employeeJobTypeTextBox.Location = new Point(160, 108);
            employeeJobTypeTextBox.MaxLength = 50;
            employeeJobTypeTextBox.Name = "employeeJobTypeTextBox";
            employeeJobTypeTextBox.Size = new Size(200, 27);
            employeeJobTypeTextBox.TabIndex = 9;
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            employeeNameTextBox.Location = new Point(160, 70);
            employeeNameTextBox.MaxLength = 50;
            employeeNameTextBox.Name = "employeeNameTextBox";
            employeeNameTextBox.Size = new Size(200, 27);
            employeeNameTextBox.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonUpdate.Location = new Point(341, 177);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(114, 40);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Location = new Point(130, 33);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 14;
            label3.Text = "ID";
            // 
            // employeeIdTextBox
            // 
            employeeIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            employeeIdTextBox.Location = new Point(160, 30);
            employeeIdTextBox.Name = "employeeIdTextBox";
            employeeIdTextBox.ReadOnly = true;
            employeeIdTextBox.Size = new Size(47, 27);
            employeeIdTextBox.TabIndex = 15;
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 229);
            Controls.Add(employeeIdTextBox);
            Controls.Add(label3);
            Controls.Add(formValidationLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(employeeJobTypeTextBox);
            Controls.Add(employeeNameTextBox);
            Controls.Add(buttonUpdate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UpdateEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Employee";
            Load += UpdateEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formValidationLabel;
        private Label label2;
        private Label label1;
        private TextBox employeeJobTypeTextBox;
        private TextBox employeeNameTextBox;
        private Button buttonUpdate;
        private Label label3;
        private TextBox employeeIdTextBox;
    }
}