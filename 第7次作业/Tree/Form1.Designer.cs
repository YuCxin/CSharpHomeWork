namespace Tree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTh1 = new System.Windows.Forms.TextBox();
            this.txtTh2 = new System.Windows.Forms.TextBox();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Controls.Add(this.cbxColor);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.txtLength);
            this.panel1.Controls.Add(this.txtPer2);
            this.panel1.Controls.Add(this.txtPer1);
            this.panel1.Controls.Add(this.txtTh2);
            this.panel1.Controls.Add(this.txtTh1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(496, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 406);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 406);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "分支角度1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "分支角度2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "分支长度比1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "分支长度比2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "主干长度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "深度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "画笔颜色";
            // 
            // txtTh1
            // 
            this.txtTh1.Location = new System.Drawing.Point(117, 47);
            this.txtTh1.Name = "txtTh1";
            this.txtTh1.Size = new System.Drawing.Size(100, 21);
            this.txtTh1.TabIndex = 7;
            // 
            // txtTh2
            // 
            this.txtTh2.Location = new System.Drawing.Point(117, 87);
            this.txtTh2.Name = "txtTh2";
            this.txtTh2.Size = new System.Drawing.Size(100, 21);
            this.txtTh2.TabIndex = 8;
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(117, 127);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(100, 21);
            this.txtPer1.TabIndex = 9;
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(117, 167);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(100, 21);
            this.txtPer2.TabIndex = 10;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(117, 207);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 21);
            this.txtLength.TabIndex = 11;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(117, 247);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 21);
            this.txtN.TabIndex = 12;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Location = new System.Drawing.Point(117, 287);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(100, 20);
            this.cbxColor.TabIndex = 13;
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(88, 341);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 14;
            this.btnDraw.Text = "绘画";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 406);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.TextBox txtTh2;
        private System.Windows.Forms.TextBox txtTh1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}

