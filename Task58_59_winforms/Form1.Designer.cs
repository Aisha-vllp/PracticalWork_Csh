namespace Task58_59_winforms
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
            PickRandomData = new Button();
            txtResult = new TextBox();
            label1 = new Label();
            InputDatasTxtBox = new TextBox();
            SuspendLayout();
            // 
            // PickRandomData
            // 
            PickRandomData.Location = new Point(172, 87);
            PickRandomData.Name = "PickRandomData";
            PickRandomData.Size = new Size(94, 29);
            PickRandomData.TabIndex = 0;
            PickRandomData.Text = "Pick";
            PickRandomData.UseVisualStyleBackColor = true;
            PickRandomData.Click += PickRandomData_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(373, 89);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(95, 27);
            txtResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 92);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Result:";
            // 
            // InputDatasTxtBox
            // 
            InputDatasTxtBox.Location = new Point(22, 87);
            InputDatasTxtBox.Multiline = true;
            InputDatasTxtBox.Name = "InputDatasTxtBox";
            InputDatasTxtBox.Size = new Size(125, 190);
            InputDatasTxtBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 408);
            Controls.Add(InputDatasTxtBox);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(PickRandomData);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PickRandomData;
        private TextBox txtResult;
        private Label label1;
        private TextBox InputDatasTxtBox;
    }
}
