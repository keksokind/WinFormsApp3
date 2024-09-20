namespace WinFormsApp3
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
            ClassAnum = new TextBox();
            ClassCnum = new TextBox();
            ClassBnum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ClassArev = new Label();
            ClassBrev = new Label();
            ClassCrev = new Label();
            totalRev = new Label();
            Exitbtn = new Button();
            Clearbtn = new Button();
            CalcRevbtn = new Button();
            SuspendLayout();
            // 
            // ClassAnum
            // 
            ClassAnum.Location = new Point(85, 124);
            ClassAnum.Name = "ClassAnum";
            ClassAnum.Size = new Size(125, 27);
            ClassAnum.TabIndex = 0;
            // 
            // ClassCnum
            // 
            ClassCnum.Location = new Point(85, 233);
            ClassCnum.Name = "ClassCnum";
            ClassCnum.Size = new Size(125, 27);
            ClassCnum.TabIndex = 1;
            // 
            // ClassBnum
            // 
            ClassBnum.Location = new Point(85, 178);
            ClassBnum.Name = "ClassBnum";
            ClassBnum.Size = new Size(125, 27);
            ClassBnum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 3;
            label1.Text = "Tickets sold:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 53);
            label2.Name = "label2";
            label2.Size = new Size(357, 20);
            label2.TabIndex = 4;
            label2.Text = "Enter a numebr of tickets sold for each class of seats.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 5;
            label3.Text = "Class A:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Class B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 240);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 7;
            label5.Text = "Class C:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(512, 23);
            label6.Name = "label6";
            label6.Size = new Size(138, 20);
            label6.TabIndex = 8;
            label6.Text = "Revenue Generated";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 66);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 9;
            label7.Text = "Class A:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 111);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 10;
            label8.Text = "Class B:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(512, 158);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 11;
            label9.Text = "Class C:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(539, 208);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 12;
            label10.Text = "Total:";
            // 
            // ClassArev
            // 
            ClassArev.AutoSize = true;
            ClassArev.Location = new Point(592, 66);
            ClassArev.Name = "ClassArev";
            ClassArev.Size = new Size(0, 20);
            ClassArev.TabIndex = 13;
            // 
            // ClassBrev
            // 
            ClassBrev.AutoSize = true;
            ClassBrev.Location = new Point(592, 111);
            ClassBrev.Name = "ClassBrev";
            ClassBrev.Size = new Size(0, 20);
            ClassBrev.TabIndex = 14;
            // 
            // ClassCrev
            // 
            ClassCrev.AutoSize = true;
            ClassCrev.Location = new Point(592, 158);
            ClassCrev.Name = "ClassCrev";
            ClassCrev.Size = new Size(0, 20);
            ClassCrev.TabIndex = 15;
            // 
            // totalRev
            // 
            totalRev.AutoSize = true;
            totalRev.Location = new Point(592, 208);
            totalRev.Name = "totalRev";
            totalRev.Size = new Size(0, 20);
            totalRev.TabIndex = 16;
            totalRev.Click += totalRev_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.Location = new Point(472, 263);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(94, 48);
            Exitbtn.TabIndex = 17;
            Exitbtn.Text = "Exit";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.Location = new Point(347, 263);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(94, 48);
            Clearbtn.TabIndex = 18;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = true;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // CalcRevbtn
            // 
            CalcRevbtn.Location = new Point(233, 263);
            CalcRevbtn.Name = "CalcRevbtn";
            CalcRevbtn.Size = new Size(94, 48);
            CalcRevbtn.TabIndex = 19;
            CalcRevbtn.Text = "Calculate revenue";
            CalcRevbtn.UseVisualStyleBackColor = true;
            CalcRevbtn.Click += CalcRevbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 323);
            Controls.Add(CalcRevbtn);
            Controls.Add(Clearbtn);
            Controls.Add(Exitbtn);
            Controls.Add(totalRev);
            Controls.Add(ClassCrev);
            Controls.Add(ClassBrev);
            Controls.Add(ClassArev);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ClassBnum);
            Controls.Add(ClassCnum);
            Controls.Add(ClassAnum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ClassAnum;
        private TextBox ClassCnum;
        private TextBox ClassBnum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label ClassArev;
        private Label ClassBrev;
        private Label ClassCrev;
        private Label totalRev;
        private Button Exitbtn;
        private Button Clearbtn;
        private Button CalcRevbtn;
    }
}
