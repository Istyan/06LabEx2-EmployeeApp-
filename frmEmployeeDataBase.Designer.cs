namespace EmployeeApplication
{
    partial class frmEmployeeDataBase
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
            textID = new TextBox();
            textfname = new TextBox();
            textlname = new TextBox();
            textPosBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textID
            // 
            textID.Location = new Point(12, 72);
            textID.Name = "textID";
            textID.Size = new Size(212, 27);
            textID.TabIndex = 0;
            textID.TextChanged += textID_TextChanged;
            // 
            // textfname
            // 
            textfname.Location = new Point(12, 125);
            textfname.Name = "textfname";
            textfname.Size = new Size(212, 27);
            textfname.TabIndex = 1;
            // 
            // textlname
            // 
            textlname.Location = new Point(12, 177);
            textlname.Name = "textlname";
            textlname.Size = new Size(212, 27);
            textlname.TabIndex = 2;
            // 
            // textPosBox
            // 
            textPosBox.Location = new Point(12, 229);
            textPosBox.Name = "textPosBox";
            textPosBox.Size = new Size(212, 27);
            textPosBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(65, 262);
            button1.Name = "button1";
            button1.Size = new Size(113, 37);
            button1.TabIndex = 4;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(150, 27);
            label1.TabIndex = 5;
            label1.Text = "Add Employee:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 6;
            label2.Text = "Employee ID *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 7;
            label3.Text = "First Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 8;
            label4.Text = "Last Name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(71, 20);
            label5.TabIndex = 9;
            label5.Text = "Position *";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(230, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(554, 262);
            dataGridView1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(230, 9);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 11;
            label6.Text = "Employee List:";
            // 
            // frmEmployeeDataBase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 306);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textPosBox);
            Controls.Add(textlname);
            Controls.Add(textfname);
            Controls.Add(textID);
            Name = "frmEmployeeDataBase";
            Text = "Employee Database";
            Load += frmEmployeeDataBase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textID;
        private TextBox textfname;
        private TextBox textlname;
        private TextBox textPosBox;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
    }
}
