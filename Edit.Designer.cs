namespace WinFormsLab
{
    partial class Edit
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
            OK_button = new Button();
            Cancel_button = new Button();
            label1 = new Label();
            comboBoxClass = new ComboBox();
            labelProperities1 = new Label();
            labelProperities3 = new Label();
            labelProperities2 = new Label();
            textBoxProperties1 = new TextBox();
            textBoxProperties3 = new TextBox();
            labelProperities4 = new Label();
            textBoxProperties4 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // OK_button
            // 
            OK_button.Location = new Point(59, 284);
            OK_button.Name = "OK_button";
            OK_button.Size = new Size(75, 23);
            OK_button.TabIndex = 0;
            OK_button.Text = "OK";
            OK_button.UseVisualStyleBackColor = true;
            OK_button.Click += OK_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(181, 284);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(75, 23);
            Cancel_button.TabIndex = 1;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 2;
            label1.Text = "Class:";
            // 
            // comboBoxClass
            // 
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(134, 24);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(168, 23);
            comboBoxClass.TabIndex = 3;
            comboBoxClass.SelectedIndexChanged += comboBoxClass_SelectedIndexChanged;
            // 
            // labelProperities1
            // 
            labelProperities1.AutoSize = true;
            labelProperities1.Location = new Point(35, 53);
            labelProperities1.Name = "labelProperities1";
            labelProperities1.Size = new Size(38, 15);
            labelProperities1.TabIndex = 4;
            labelProperities1.Text = "label1";
            // 
            // labelProperities3
            // 
            labelProperities3.AutoSize = true;
            labelProperities3.Location = new Point(35, 111);
            labelProperities3.Name = "labelProperities3";
            labelProperities3.Size = new Size(38, 15);
            labelProperities3.TabIndex = 5;
            labelProperities3.Text = "label3";
            // 
            // labelProperities2
            // 
            labelProperities2.AutoSize = true;
            labelProperities2.Location = new Point(35, 82);
            labelProperities2.Name = "labelProperities2";
            labelProperities2.Size = new Size(38, 15);
            labelProperities2.TabIndex = 6;
            labelProperities2.Text = "label2";
            // 
            // textBoxProperties1
            // 
            textBoxProperties1.Location = new Point(134, 53);
            textBoxProperties1.Name = "textBoxProperties1";
            textBoxProperties1.Size = new Size(168, 23);
            textBoxProperties1.TabIndex = 7;
            // 
            // textBoxProperties3
            // 
            textBoxProperties3.Location = new Point(134, 111);
            textBoxProperties3.Name = "textBoxProperties3";
            textBoxProperties3.Size = new Size(168, 23);
            textBoxProperties3.TabIndex = 9;
            // 
            // labelProperities4
            // 
            labelProperities4.AutoSize = true;
            labelProperities4.Location = new Point(35, 140);
            labelProperities4.Name = "labelProperities4";
            labelProperities4.Size = new Size(38, 15);
            labelProperities4.TabIndex = 10;
            labelProperities4.Text = "label4";
            // 
            // textBoxProperties4
            // 
            textBoxProperties4.Location = new Point(134, 140);
            textBoxProperties4.Name = "textBoxProperties4";
            textBoxProperties4.Size = new Size(168, 23);
            textBoxProperties4.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(134, 82);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(168, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 331);
            Controls.Add(numericUpDown1);
            Controls.Add(textBoxProperties4);
            Controls.Add(labelProperities4);
            Controls.Add(textBoxProperties3);
            Controls.Add(textBoxProperties1);
            Controls.Add(labelProperities2);
            Controls.Add(labelProperities3);
            Controls.Add(labelProperities1);
            Controls.Add(comboBoxClass);
            Controls.Add(label1);
            Controls.Add(Cancel_button);
            Controls.Add(OK_button);
            Name = "Edit";
            Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OK_button;
        private Button Cancel_button;
        private Label label1;
        private ComboBox comboBoxClass;
        private Label labelProperities1;
        private Label labelProperities3;
        private Label labelProperities2;
        private TextBox textBoxProperties1;
        private TextBox textBoxProperties3;
        private Label labelProperities4;
        private TextBox textBoxProperties4;
        private NumericUpDown numericUpDown1;
    }
}