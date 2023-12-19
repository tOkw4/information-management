namespace INFORMATION_MANAGEMENT
{
    partial class STUDENTRECORD
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
            label4 = new Label();
            studentid = new TextBox();
            dataGridView1 = new DataGridView();
            addstudent = new Button();
            view = new Button();
            add = new Button();
            del = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(283, 32);
            label4.Name = "label4";
            label4.Size = new Size(227, 32);
            label4.TabIndex = 5;
            label4.Text = "STUDENT RECORD";
            // 
            // studentid
            // 
            studentid.Location = new Point(75, 174);
            studentid.Name = "studentid";
            studentid.Size = new Size(259, 23);
            studentid.TabIndex = 7;
            studentid.Text = "search";
            studentid.TextChanged += studentid_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(338, 342);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // addstudent
            // 
            addstudent.Location = new Point(75, 324);
            addstudent.Name = "addstudent";
            addstudent.Size = new Size(120, 55);
            addstudent.TabIndex = 15;
            addstudent.Text = "ADD STUDENT";
            addstudent.UseVisualStyleBackColor = true;
            addstudent.Click += addstudent_Click;
            // 
            // view
            // 
            view.Location = new Point(75, 242);
            view.Name = "view";
            view.Size = new Size(120, 55);
            view.TabIndex = 16;
            view.Text = "VIEW";
            view.UseVisualStyleBackColor = true;
            view.Click += view_Click;
            // 
            // add
            // 
            add.Location = new Point(214, 242);
            add.Name = "add";
            add.Size = new Size(120, 55);
            add.TabIndex = 17;
            add.Text = "ADD GRADE";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // del
            // 
            del.Location = new Point(214, 324);
            del.Name = "del";
            del.Size = new Size(120, 55);
            del.TabIndex = 18;
            del.Text = "DELETE STUDENT";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // STUDENTRECORD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 516);
            Controls.Add(del);
            Controls.Add(add);
            Controls.Add(view);
            Controls.Add(addstudent);
            Controls.Add(dataGridView1);
            Controls.Add(studentid);
            Controls.Add(label4);
            Name = "STUDENTRECORD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "STUDENTRECORD";
            Load += STUDENTRECORD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox studentid;
        private DataGridView dataGridView1;
        private Button addstudent;
        private Button view;
        private Button add;
        private Button del;
    }
}