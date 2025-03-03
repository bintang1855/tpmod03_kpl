namespace tpmod03_103022300058
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
            button1Submit = new Button();
            textBox1Form = new TextBox();
            label1Output = new Label();
            SuspendLayout();
            // 
            // button1Submit
            // 
            button1Submit.BackColor = Color.FromArgb(255, 128, 0);
            button1Submit.Location = new Point(496, 70);
            button1Submit.Name = "button1Submit";
            button1Submit.Size = new Size(119, 45);
            button1Submit.TabIndex = 0;
            button1Submit.Text = "SUBMIT";
            button1Submit.UseVisualStyleBackColor = false;
            button1Submit.Click += button1Submit_Click;
            // 
            // textBox1Form
            // 
            textBox1Form.Location = new Point(106, 70);
            textBox1Form.Multiline = true;
            textBox1Form.Name = "textBox1Form";
            textBox1Form.Size = new Size(384, 45);
            textBox1Form.TabIndex = 1;
            textBox1Form.TextAlign = HorizontalAlignment.Center;
            // 
            // label1Output
            // 
            label1Output.BackColor = Color.FromArgb(255, 128, 0);
            label1Output.ForeColor = Color.White;
            label1Output.Location = new Point(106, 132);
            label1Output.Name = "label1Output";
            label1Output.Size = new Size(509, 47);
            label1Output.TabIndex = 2;
            label1Output.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 283);
            Controls.Add(label1Output);
            Controls.Add(textBox1Form);
            Controls.Add(button1Submit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1Submit;
        private TextBox textBox1Form;
        private Label label1Output;
    }
}
