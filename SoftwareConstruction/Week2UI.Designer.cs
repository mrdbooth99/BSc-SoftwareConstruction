namespace SoftwareConstructionUI
{
    partial class Week2UI
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
            this.lblNumberEntry = new System.Windows.Forms.Label();
            this.nudSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.nudFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.Lbl_H1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.btnConstructor = new System.Windows.Forms.Button();
            this.controlBox = new System.Windows.Forms.GroupBox();
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.outputBox = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstNumber)).BeginInit();
            this.inputBox.SuspendLayout();
            this.controlBox.SuspendLayout();
            this.outputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberEntry
            // 
            this.lblNumberEntry.AutoSize = true;
            this.lblNumberEntry.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberEntry.Location = new System.Drawing.Point(6, 25);
            this.lblNumberEntry.Name = "lblNumberEntry";
            this.lblNumberEntry.Size = new System.Drawing.Size(107, 21);
            this.lblNumberEntry.TabIndex = 10;
            this.lblNumberEntry.Text = "Number input";
            // 
            // nudSecondNumber
            // 
            this.nudSecondNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSecondNumber.Location = new System.Drawing.Point(156, 58);
            this.nudSecondNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSecondNumber.Name = "nudSecondNumber";
            this.nudSecondNumber.Size = new System.Drawing.Size(120, 29);
            this.nudSecondNumber.TabIndex = 9;
            this.nudSecondNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudFirstNumber
            // 
            this.nudFirstNumber.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFirstNumber.Location = new System.Drawing.Point(9, 58);
            this.nudFirstNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudFirstNumber.Name = "nudFirstNumber";
            this.nudFirstNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudFirstNumber.Size = new System.Drawing.Size(120, 29);
            this.nudFirstNumber.TabIndex = 8;
            this.nudFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Lbl_H1
            // 
            this.Lbl_H1.AutoSize = true;
            this.Lbl_H1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_H1.Location = new System.Drawing.Point(24, 27);
            this.Lbl_H1.Name = "Lbl_H1";
            this.Lbl_H1.Size = new System.Drawing.Size(262, 32);
            this.Lbl_H1.TabIndex = 7;
            this.Lbl_H1.Text = "Week 2: OOP Concepts";
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.btnConstructor);
            this.inputBox.Controls.Add(this.lblNumberEntry);
            this.inputBox.Controls.Add(this.nudFirstNumber);
            this.inputBox.Controls.Add(this.nudSecondNumber);
            this.inputBox.Location = new System.Drawing.Point(30, 91);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(359, 259);
            this.inputBox.TabIndex = 14;
            this.inputBox.TabStop = false;
            // 
            // btnConstructor
            // 
            this.btnConstructor.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConstructor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnConstructor.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstructor.Location = new System.Drawing.Point(9, 112);
            this.btnConstructor.Name = "btnConstructor";
            this.btnConstructor.Size = new System.Drawing.Size(120, 32);
            this.btnConstructor.TabIndex = 14;
            this.btnConstructor.Text = "Constructor";
            this.btnConstructor.UseVisualStyleBackColor = false;
            this.btnConstructor.Click += new System.EventHandler(this.BtnConstructor_Click);
            // 
            // controlBox
            // 
            this.controlBox.Controls.Add(this.btnCallMethod);
            this.controlBox.Controls.Add(this.label1);
            this.controlBox.Controls.Add(this.cboMethod);
            this.controlBox.Location = new System.Drawing.Point(30, 356);
            this.controlBox.Name = "controlBox";
            this.controlBox.Size = new System.Drawing.Size(755, 259);
            this.controlBox.TabIndex = 15;
            this.controlBox.TabStop = false;
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.BackColor = System.Drawing.Color.Gray;
            this.btnCallMethod.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCallMethod.Enabled = false;
            this.btnCallMethod.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallMethod.Location = new System.Drawing.Point(10, 124);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(120, 32);
            this.btnCallMethod.TabIndex = 16;
            this.btnCallMethod.Text = "Call Method";
            this.btnCallMethod.UseVisualStyleBackColor = false;
            this.btnCallMethod.Click += new System.EventHandler(this.BtnCallMethod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Method";
            // 
            // cboMethod
            // 
            this.cboMethod.Enabled = false;
            this.cboMethod.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Items.AddRange(new object[] {
            "Method to return 1st Number",
            "Method to return 2nd Number",
            "Method to return larger of the two numbers",
            "Method to test equality",
            "Method to calculate and return GCD",
            "Method to add to numbers",
            "Method to return string"});
            this.cboMethod.Location = new System.Drawing.Point(10, 54);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(400, 29);
            this.cboMethod.TabIndex = 0;
            this.cboMethod.Text = "Select method";
            this.cboMethod.SelectedIndexChanged += new System.EventHandler(this.CboMethod_OnChange);
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.White;
            this.outputBox.Controls.Add(this.txtResult);
            this.outputBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputBox.Location = new System.Drawing.Point(431, 91);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(354, 259);
            this.outputBox.TabIndex = 16;
            this.outputBox.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtResult.Location = new System.Drawing.Point(16, 16);
            this.txtResult.MaximumSize = new System.Drawing.Size(325, 230);
            this.txtResult.MinimumSize = new System.Drawing.Size(325, 230);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(325, 230);
            this.txtResult.TabIndex = 0;
            // 
            // Week2UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 657);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.controlBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.Lbl_H1);
            this.Name = "Week2UI";
            this.Text = "Week_2";
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFirstNumber)).EndInit();
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.controlBox.ResumeLayout(false);
            this.controlBox.PerformLayout();
            this.outputBox.ResumeLayout(false);
            this.outputBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberEntry;
        private System.Windows.Forms.NumericUpDown nudSecondNumber;
        private System.Windows.Forms.NumericUpDown nudFirstNumber;
        private System.Windows.Forms.Label Lbl_H1;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.GroupBox controlBox;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.GroupBox outputBox;
        private System.Windows.Forms.Button btnConstructor;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCallMethod;
    }


}
