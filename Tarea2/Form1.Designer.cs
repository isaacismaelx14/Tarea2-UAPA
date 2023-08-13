namespace Tarea2
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
            tbValueOne = new TextBox();
            button1 = new Button();
            tbValueTwo = new TextBox();
            label2 = new Label();
            tbResult = new TextBox();
            label3 = new Label();
            tbOperator = new TextBox();
            lblOperator = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1";
            // 
            // tbValueOne
            // 
            tbValueOne.Location = new Point(91, 12);
            tbValueOne.Name = "tbValueOne";
            tbValueOne.Size = new Size(100, 23);
            tbValueOne.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(220, 44);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tbValueTwo
            // 
            tbValueTwo.Location = new Point(91, 41);
            tbValueTwo.Name = "tbValueTwo";
            tbValueTwo.Size = new Size(100, 23);
            tbValueTwo.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 44);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor 2";
            // 
            // tbResult
            // 
            tbResult.Location = new Point(91, 70);
            tbResult.Name = "tbResult";
            tbResult.Size = new Size(100, 23);
            tbResult.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 73);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Resultado";
            // 
            // tbOperator
            // 
            tbOperator.Location = new Point(283, 15);
            tbOperator.Name = "tbOperator";
            tbOperator.Size = new Size(64, 23);
            tbOperator.TabIndex = 8;
            // 
            // lblOperator
            // 
            lblOperator.AutoSize = true;
            lblOperator.Location = new Point(220, 18);
            lblOperator.Name = "lblOperator";
            lblOperator.Size = new Size(57, 15);
            lblOperator.TabIndex = 7;
            lblOperator.Text = "Operador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 362);
            Controls.Add(tbOperator);
            Controls.Add(lblOperator);
            Controls.Add(tbResult);
            Controls.Add(label3);
            Controls.Add(tbValueTwo);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(tbValueOne);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbValueOne;
        private Button button1;
        private TextBox tbValueTwo;
        private Label label2;
        private TextBox tbResult;
        private Label label3;
        private TextBox tbOperator;
        private Label lblOperator;
    }
}