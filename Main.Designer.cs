namespace WinFormsLab
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox_Sweets = new ListBox();
            Add_Button = new Button();
            Edit_Button = new Button();
            Delete_Button = new Button();
            Label_Weight = new Label();
            SuspendLayout();
            // 
            // listBox_Sweets
            // 
            listBox_Sweets.FormattingEnabled = true;
            listBox_Sweets.ItemHeight = 15;
            listBox_Sweets.Location = new Point(141, 29);
            listBox_Sweets.Name = "listBox_Sweets";
            listBox_Sweets.Size = new Size(230, 289);
            listBox_Sweets.TabIndex = 0;
            // 
            // Add_Button
            // 
            Add_Button.Location = new Point(29, 60);
            Add_Button.Name = "Add_Button";
            Add_Button.Size = new Size(75, 23);
            Add_Button.TabIndex = 1;
            Add_Button.Text = "Add";
            Add_Button.UseVisualStyleBackColor = true;
            Add_Button.Click += Add_Click;
            // 
            // Edit_Button
            // 
            Edit_Button.Location = new Point(29, 89);
            Edit_Button.Name = "Edit_Button";
            Edit_Button.Size = new Size(75, 23);
            Edit_Button.TabIndex = 2;
            Edit_Button.Text = "Edit";
            Edit_Button.UseVisualStyleBackColor = true;
            Edit_Button.Click += Edit_Click;
            // 
            // Delete_Button
            // 
            Delete_Button.Location = new Point(29, 118);
            Delete_Button.Name = "Delete_Button";
            Delete_Button.Size = new Size(75, 23);
            Delete_Button.TabIndex = 3;
            Delete_Button.Text = "Delete";
            Delete_Button.UseVisualStyleBackColor = true;
            Delete_Button.Click += Delete_Click;
            // 
            // Label_Weight
            // 
            Label_Weight.AutoSize = true;
            Label_Weight.Location = new Point(29, 350);
            Label_Weight.Name = "Label_Weight";
            Label_Weight.Size = new Size(78, 15);
            Label_Weight.TabIndex = 4;
            Label_Weight.Text = "Label_Weight";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 390);
            Controls.Add(Label_Weight);
            Controls.Add(Delete_Button);
            Controls.Add(Edit_Button);
            Controls.Add(Add_Button);
            Controls.Add(listBox_Sweets);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_Sweets;
        private Button Add_Button;
        private Button Edit_Button;
        private Button Delete_Button;
        private Label Label_Weight;
    }
}
