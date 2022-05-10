namespace delta
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
            this.button1 = new System.Windows.Forms.Button();
            this.abox = new System.Windows.Forms.TextBox();
            this.bbox = new System.Windows.Forms.TextBox();
            this.cbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doduj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.x1Box = new System.Windows.Forms.TextBox();
            this.x2Box = new System.Windows.Forms.TextBox();
            this.waw = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "licz delte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // abox
            // 
            this.abox.Location = new System.Drawing.Point(27, 178);
            this.abox.Name = "abox";
            this.abox.Size = new System.Drawing.Size(41, 23);
            this.abox.TabIndex = 1;
            // 
            // bbox
            // 
            this.bbox.Location = new System.Drawing.Point(114, 178);
            this.bbox.Name = "bbox";
            this.bbox.Size = new System.Drawing.Size(46, 23);
            this.bbox.TabIndex = 2;
            this.bbox.TextChanged += new System.EventHandler(this.bbox_TextChanged);
            // 
            // cbox
            // 
            this.cbox.Location = new System.Drawing.Point(196, 178);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(47, 23);
            this.cbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "c";
            // 
            // doduj
            // 
            this.doduj.Location = new System.Drawing.Point(555, 179);
            this.doduj.Name = "doduj";
            this.doduj.ReadOnly = true;
            this.doduj.Size = new System.Drawing.Size(206, 23);
            this.doduj.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "b^2-4ac - wzór delty";
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(266, 178);
            this.wynik.Name = "wynik";
            this.wynik.ReadOnly = true;
            this.wynik.Size = new System.Drawing.Size(95, 23);
            this.wynik.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "wynik delty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "x1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "x2";
            // 
            // x1Box
            // 
            this.x1Box.Location = new System.Drawing.Point(114, 351);
            this.x1Box.Name = "x1Box";
            this.x1Box.ReadOnly = true;
            this.x1Box.Size = new System.Drawing.Size(79, 23);
            this.x1Box.TabIndex = 13;
            // 
            // x2Box
            // 
            this.x2Box.Location = new System.Drawing.Point(346, 350);
            this.x2Box.Name = "x2Box";
            this.x2Box.ReadOnly = true;
            this.x2Box.Size = new System.Drawing.Size(86, 23);
            this.x2Box.TabIndex = 14;
            // 
            // waw
            // 
            this.waw.AutoSize = true;
            this.waw.Location = new System.Drawing.Point(74, 184);
            this.waw.Name = "waw";
            this.waw.Size = new System.Drawing.Size(27, 15);
            this.waw.TabIndex = 15;
            this.waw.Text = "x^2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(166, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "x +";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.waw);
            this.Controls.Add(this.x2Box);
            this.Controls.Add(this.x1Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doduj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.bbox);
            this.Controls.Add(this.abox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox abox;
        private TextBox bbox;
        private TextBox cbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox doduj;
        private Label label4;
        private TextBox wynik;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox x1Box;
        private TextBox x2Box;
        private Label waw;
        private Label label8;
        private Label label9;
    }
}