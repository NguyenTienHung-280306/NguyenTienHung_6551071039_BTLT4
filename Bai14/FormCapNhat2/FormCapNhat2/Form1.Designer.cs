namespace FormCapNhat2
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
            txtTen = new TextBox();
            button1 = new Button();
            label1 = new Label();
            lstLopA = new ListBox();
            lstLopB = new ListBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            xoaA = new Button();
            ketthuc = new Button();
            xoaB = new Button();
            SuspendLayout();
            // 
            // txtTen
            // 
            txtTen.Location = new Point(238, 26);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(327, 27);
            txtTen.TabIndex = 0;
            txtTen.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(594, 24);
            button1.Name = "button1";
            button1.Size = new Size(120, 29);
            button1.TabIndex = 1;
            button1.Text = "Cập nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 22);
            label1.Name = "label1";
            label1.Size = new Size(91, 31);
            label1.TabIndex = 2;
            label1.Text = "Tên SV:";
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(44, 96);
            lstLopA.Name = "lstLopA";
            lstLopA.Size = new Size(269, 244);
            lstLopA.TabIndex = 3;
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(497, 96);
            lstLopB.Name = "lstLopB";
            lstLopB.Size = new Size(269, 244);
            lstLopB.TabIndex = 4;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(357, 106);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 29);
            btn1.TabIndex = 5;
            btn1.Text = ">";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(357, 168);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 29);
            btn2.TabIndex = 6;
            btn2.Text = ">>";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(357, 229);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 29);
            btn3.TabIndex = 7;
            btn3.Text = "<";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(357, 296);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 29);
            btn4.TabIndex = 8;
            btn4.Text = "<<";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // xoaA
            // 
            xoaA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xoaA.Location = new Point(93, 376);
            xoaA.Name = "xoaA";
            xoaA.Size = new Size(137, 47);
            xoaA.TabIndex = 9;
            xoaA.Text = "Xóa lớp A";
            xoaA.UseVisualStyleBackColor = true;
            xoaA.Click += xoaA_Click;
            // 
            // ketthuc
            // 
            ketthuc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ketthuc.Location = new Point(341, 376);
            ketthuc.Name = "ketthuc";
            ketthuc.Size = new Size(126, 47);
            ketthuc.TabIndex = 10;
            ketthuc.Text = "Kết Thúc";
            ketthuc.UseVisualStyleBackColor = true;
            ketthuc.Click += ketthuc_Click;
            // 
            // xoaB
            // 
            xoaB.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            xoaB.Location = new Point(568, 376);
            xoaB.Name = "xoaB";
            xoaB.Size = new Size(134, 47);
            xoaB.TabIndex = 11;
            xoaB.Text = "Xóa lớp B";
            xoaB.UseVisualStyleBackColor = true;
            xoaB.Click += xoaB_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(xoaB);
            Controls.Add(ketthuc);
            Controls.Add(xoaA);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lstLopB);
            Controls.Add(lstLopA);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtTen);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTen;
        private Button button1;
        private Label label1;
        private ListBox lstLopA;
        private ListBox lstLopB;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button xoaA;
        private Button ketthuc;
        private Button xoaB;
    }
}
