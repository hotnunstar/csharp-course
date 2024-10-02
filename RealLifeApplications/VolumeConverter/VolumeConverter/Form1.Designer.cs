namespace VolumeConverter
{
    partial class Form1
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
            label1 = new Label();
            amount = new TextBox();
            label2 = new Label();
            from = new ComboBox();
            to = new ComboBox();
            label3 = new Label();
            convert = new Button();
            result = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "Enter Amount:";
            // 
            // amount
            // 
            amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount.Location = new Point(138, 12);
            amount.Name = "amount";
            amount.Size = new Size(194, 29);
            amount.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 50);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 2;
            label2.Text = "From:";
            // 
            // from
            // 
            from.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            from.FormattingEnabled = true;
            from.Items.AddRange(new object[] { "Select Unit:", "Cubic meter", "Liter", "Millimeter" });
            from.Location = new Point(138, 47);
            from.Name = "from";
            from.Size = new Size(194, 29);
            from.TabIndex = 3;
            // 
            // to
            // 
            to.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            to.FormattingEnabled = true;
            to.Items.AddRange(new object[] { "Select Unit:", "Cubic meter", "Liter", "Millimeter" });
            to.Location = new Point(138, 82);
            to.Name = "to";
            to.Size = new Size(194, 29);
            to.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 85);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 4;
            label3.Text = "To:";
            // 
            // convert
            // 
            convert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            convert.Location = new Point(138, 117);
            convert.Name = "convert";
            convert.Size = new Size(194, 29);
            convert.TabIndex = 6;
            convert.Text = "Convert";
            convert.UseVisualStyleBackColor = true;
            convert.Click += convert_Click;
            // 
            // result
            // 
            result.BackColor = SystemColors.Menu;
            result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(138, 199);
            result.Name = "result";
            result.Size = new Size(194, 29);
            result.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(71, 202);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 7;
            label4.Text = "Result:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 333);
            Controls.Add(result);
            Controls.Add(label4);
            Controls.Add(convert);
            Controls.Add(to);
            Controls.Add(label3);
            Controls.Add(from);
            Controls.Add(label2);
            Controls.Add(amount);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Volume Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox amount;
        private Label label2;
        private ComboBox from;
        private ComboBox to;
        private Label label3;
        private Button convert;
        private TextBox result;
        private Label label4;
    }
}
