namespace INFORMATION_MANAGEMENT
{
    partial class ADD_STUDENT
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
            addstudentbttn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            last = new TextBox();
            first = new TextBox();
            middle = new TextBox();
            SuspendLayout();
            // 
            // addstudentbttn
            // 
            addstudentbttn.Location = new Point(139, 351);
            addstudentbttn.Name = "addstudentbttn";
            addstudentbttn.Size = new Size(120, 55);
            addstudentbttn.TabIndex = 0;
            addstudentbttn.Text = "ADD STUDENT";
            addstudentbttn.UseVisualStyleBackColor = true;
            addstudentbttn.Click += addstudentbttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 141);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 1;
            label1.Text = "LAST NAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 187);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "FIRST NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 232);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 3;
            label3.Text = "MIDDLE INITIAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 41);
            label4.Name = "label4";
            label4.Size = new Size(183, 32);
            label4.TabIndex = 4;
            label4.Text = "ADD STUDENT";
            // 
            // last
            // 
            last.Location = new Point(171, 138);
            last.Name = "last";
            last.Size = new Size(155, 23);
            last.TabIndex = 50;
            // 
            // first
            // 
            first.Location = new Point(171, 184);
            first.Name = "first";
            first.Size = new Size(155, 23);
            first.TabIndex = 50;
            // 
            // middle
            // 
            middle.Location = new Point(171, 229);
            middle.Name = "middle";
            middle.Size = new Size(155, 23);
            middle.TabIndex = 7;
            // 
            // ADD_STUDENT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(middle);
            Controls.Add(first);
            Controls.Add(last);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addstudentbttn);
            Name = "ADD_STUDENT";
            Text = "ADD_STUDENT";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addstudentbttn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox last;
        private TextBox first;
        private TextBox middle;
    }
}