namespace Task56_57_winforms
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
            Start = new Button();
            Stop = new Button();
            openFileDialog1 = new OpenFileDialog();
            Choose = new Button();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(50, 60);
            Start.Name = "Start";
            Start.Size = new Size(110, 29);
            Start.TabIndex = 0;
            Start.Text = "Прослушать";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(50, 115);
            Stop.Name = "Stop";
            Stop.Size = new Size(110, 29);
            Stop.TabIndex = 1;
            Stop.Text = "Остановить";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Choose
            // 
            Choose.Location = new Point(50, 171);
            Choose.Name = "Choose";
            Choose.Size = new Size(110, 29);
            Choose.TabIndex = 2;
            Choose.Text = "Выбрать";
            Choose.UseVisualStyleBackColor = true;
            Choose.Click += Choose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 295);
            Controls.Add(Choose);
            Controls.Add(Stop);
            Controls.Add(Start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Start;
        private Button Stop;
        private OpenFileDialog openFileDialog1;
        private Button Choose;
    }
}
