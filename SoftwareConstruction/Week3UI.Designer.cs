namespace SoftwareConstructionUI
{
    partial class Week3UI
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
            controlBox = new GroupBox();
            btnCallMethod = new Button();
            label1 = new Label();
            cboMethod = new ComboBox();
            inputBox = new GroupBox();
            btnAddNumber = new Button();
            cboConstructor = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            btnConstructor = new Button();
            lblArrayValues = new Label();
            nudFirstNumber = new NumericUpDown();
            nudSecondNumber = new NumericUpDown();
            txtResult = new TextBox();
            outputBox = new GroupBox();
            label4 = new Label();
            Lbl_H1 = new Label();
            controlBox.SuspendLayout();
            inputBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFirstNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSecondNumber).BeginInit();
            outputBox.SuspendLayout();
            SuspendLayout();
            // 
            // controlBox
            // 
            controlBox.Controls.Add(btnCallMethod);
            controlBox.Controls.Add(label1);
            controlBox.Controls.Add(cboMethod);
            controlBox.Location = new Point(13, 501);
            controlBox.Margin = new Padding(4, 3, 4, 3);
            controlBox.Name = "controlBox";
            controlBox.Padding = new Padding(4, 3, 4, 3);
            controlBox.Size = new Size(958, 299);
            controlBox.TabIndex = 19;
            controlBox.TabStop = false;
            // 
            // btnCallMethod
            // 
            btnCallMethod.BackColor = Color.Gray;
            btnCallMethod.Enabled = false;
            btnCallMethod.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCallMethod.Location = new Point(8, 116);
            btnCallMethod.Margin = new Padding(4, 3, 4, 3);
            btnCallMethod.Name = "btnCallMethod";
            btnCallMethod.Size = new Size(140, 37);
            btnCallMethod.TabIndex = 16;
            btnCallMethod.Text = "Call Method";
            btnCallMethod.UseVisualStyleBackColor = false;
            btnCallMethod.Click += btnCallMethod_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 1;
            label1.Text = "Methods";
            // 
            // cboMethod
            // 
            cboMethod.Enabled = false;
            cboMethod.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMethod.FormattingEnabled = true;
            cboMethod.Items.AddRange(new object[] { "Method to return max number", "Method to test equality", "Method to calculate and return GCD", "Method to return number of elements", "Method to sum all elements in the array", "Method to return array average", "Method to return string representation of the array" });
            cboMethod.Location = new Point(12, 62);
            cboMethod.Margin = new Padding(4, 3, 4, 3);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(383, 29);
            cboMethod.TabIndex = 0;
            cboMethod.Text = "Select method";
            cboMethod.SelectedIndexChanged += cboMethod_SelectedIndexChanged;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(btnAddNumber);
            inputBox.Controls.Add(cboConstructor);
            inputBox.Controls.Add(label3);
            inputBox.Controls.Add(label2);
            inputBox.Controls.Add(btnConstructor);
            inputBox.Controls.Add(lblArrayValues);
            inputBox.Controls.Add(nudFirstNumber);
            inputBox.Controls.Add(nudSecondNumber);
            inputBox.Location = new Point(13, 76);
            inputBox.Margin = new Padding(4, 3, 4, 3);
            inputBox.Name = "inputBox";
            inputBox.Padding = new Padding(4, 3, 4, 3);
            inputBox.Size = new Size(451, 345);
            inputBox.TabIndex = 18;
            inputBox.TabStop = false;
            // 
            // btnAddNumber
            // 
            btnAddNumber.BackColor = Color.PaleGreen;
            btnAddNumber.Enabled = false;
            btnAddNumber.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNumber.Location = new Point(182, 128);
            btnAddNumber.Margin = new Padding(4, 3, 4, 3);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(140, 37);
            btnAddNumber.TabIndex = 18;
            btnAddNumber.Text = "Add";
            btnAddNumber.UseVisualStyleBackColor = false;
            btnAddNumber.Click += btnAddNumber_Click;
            // 
            // cboConstructor
            // 
            cboConstructor.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboConstructor.FormattingEnabled = true;
            cboConstructor.Items.AddRange(new object[] { "Constructor-1, Zeroise array - specify size (Index Number)", "Constructor-2, Specify array of values" });
            cboConstructor.Location = new Point(8, 205);
            cboConstructor.Margin = new Padding(4, 3, 4, 3);
            cboConstructor.Name = "cboConstructor";
            cboConstructor.Size = new Size(432, 29);
            cboConstructor.TabIndex = 17;
            cboConstructor.Text = "Select constructor";
            cboConstructor.SelectedIndexChanged += cboConstructor_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(182, 58);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 16;
            label3.Text = "Input 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 58);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 15;
            label2.Text = "Input 1";
            // 
            // btnConstructor
            // 
            btnConstructor.BackColor = Color.PaleGreen;
            btnConstructor.Enabled = false;
            btnConstructor.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConstructor.Location = new Point(8, 252);
            btnConstructor.Margin = new Padding(4, 3, 4, 3);
            btnConstructor.Name = "btnConstructor";
            btnConstructor.Size = new Size(140, 37);
            btnConstructor.TabIndex = 14;
            btnConstructor.Text = "Constructor";
            btnConstructor.UseVisualStyleBackColor = false;
            btnConstructor.Click += btnConstructor_Click;
            // 
            // lblArrayValues
            // 
            lblArrayValues.AutoSize = true;
            lblArrayValues.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArrayValues.Location = new Point(8, 19);
            lblArrayValues.Margin = new Padding(4, 0, 4, 0);
            lblArrayValues.Name = "lblArrayValues";
            lblArrayValues.Size = new Size(187, 25);
            lblArrayValues.TabIndex = 10;
            lblArrayValues.Text = "Task 1 - Constructor";
            // 
            // nudFirstNumber
            // 
            nudFirstNumber.Enabled = false;
            nudFirstNumber.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudFirstNumber.Location = new Point(8, 85);
            nudFirstNumber.Margin = new Padding(4, 3, 4, 3);
            nudFirstNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudFirstNumber.Name = "nudFirstNumber";
            nudFirstNumber.RightToLeft = RightToLeft.No;
            nudFirstNumber.Size = new Size(140, 29);
            nudFirstNumber.TabIndex = 8;
            nudFirstNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // nudSecondNumber
            // 
            nudSecondNumber.Enabled = false;
            nudSecondNumber.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudSecondNumber.Location = new Point(182, 85);
            nudSecondNumber.Margin = new Padding(4, 3, 4, 3);
            nudSecondNumber.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudSecondNumber.Name = "nudSecondNumber";
            nudSecondNumber.Size = new Size(140, 29);
            nudSecondNumber.TabIndex = 9;
            nudSecondNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            txtResult.BackColor = SystemColors.InactiveCaptionText;
            txtResult.BorderStyle = BorderStyle.None;
            txtResult.Cursor = Cursors.IBeam;
            txtResult.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.ForeColor = Color.LimeGreen;
            txtResult.Location = new Point(29, 58);
            txtResult.Margin = new Padding(4, 3, 4, 3);
            txtResult.MaximumSize = new Size(425, 265);
            txtResult.MinimumSize = new Size(425, 265);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(425, 265);
            txtResult.TabIndex = 0;
            // 
            // outputBox
            // 
            outputBox.BackColor = Color.Transparent;
            outputBox.Controls.Add(label4);
            outputBox.Controls.Add(txtResult);
            outputBox.FlatStyle = FlatStyle.Flat;
            outputBox.Location = new Point(490, 76);
            outputBox.Margin = new Padding(4, 3, 4, 3);
            outputBox.Name = "outputBox";
            outputBox.Padding = new Padding(4, 3, 4, 3);
            outputBox.Size = new Size(481, 345);
            outputBox.TabIndex = 20;
            outputBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 16);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 19;
            label4.Text = "Terminal";
            // 
            // Lbl_H1
            // 
            Lbl_H1.AutoSize = true;
            Lbl_H1.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_H1.Location = new Point(13, 24);
            Lbl_H1.Margin = new Padding(4, 0, 4, 0);
            Lbl_H1.Name = "Lbl_H1";
            Lbl_H1.Size = new Size(263, 32);
            Lbl_H1.TabIndex = 17;
            Lbl_H1.Text = "Week 3: Git and GitHub";
            // 
            // Week3UI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 1120);
            Controls.Add(controlBox);
            Controls.Add(inputBox);
            Controls.Add(outputBox);
            Controls.Add(Lbl_H1);
            Name = "Week3UI";
            Text = "Week3UI";
            controlBox.ResumeLayout(false);
            controlBox.PerformLayout();
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudFirstNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSecondNumber).EndInit();
            outputBox.ResumeLayout(false);
            outputBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox controlBox;
        private Button btnCallMethod;
        private Label label1;
        private ComboBox cboMethod;
        private GroupBox inputBox;
        private Button btnConstructor;
        private Label lblArrayValues;
        private NumericUpDown nudFirstNumber;
        private TextBox txtResult;
        private GroupBox outputBox;
        private Label Lbl_H1;
        private Label label2;
        private ComboBox cboConstructor;
        private Label label3;
        private Button btnAddNumber;
        private NumericUpDown nudSecondNumber;
        private Label label4;
    }
}