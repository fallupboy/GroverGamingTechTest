namespace EmployeeDirectory
{
    partial class AddEmployeeForm
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
            buttonAdd = new Button();
            nameTextBox = new TextBox();
            jobTypeTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            formValidationLabel = new Label();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAdd.Location = new Point(342, 146);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(114, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameTextBox.Location = new Point(159, 39);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 1;
            // 
            // jobTypeTextBox
            // 
            jobTypeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            jobTypeTextBox.Location = new Point(159, 77);
            jobTypeTextBox.MaxLength = 50;
            jobTypeTextBox.Name = "jobTypeTextBox";
            jobTypeTextBox.Size = new Size(200, 27);
            jobTypeTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Location = new Point(104, 42);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(86, 80);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 4;
            label2.Text = "Job Type";
            // 
            // formValidationLabel
            // 
            formValidationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            formValidationLabel.AutoSize = true;
            formValidationLabel.ForeColor = Color.Red;
            formValidationLabel.Location = new Point(159, 121);
            formValidationLabel.Name = "formValidationLabel";
            formValidationLabel.Size = new Size(159, 20);
            formValidationLabel.TabIndex = 6;
            formValidationLabel.Text = "Please fill out the form";
            formValidationLabel.Visible = false;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 198);
            Controls.Add(formValidationLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(jobTypeTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(buttonAdd);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAdd;
        private TextBox nameTextBox;
        private TextBox jobTypeTextBox;
        private Label label1;
        private Label label2;
        private Label formValidationLabel;
    }
}