namespace WindowsApplication1
{
	partial class Form1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtFileList = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chbMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReadme = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTest.Location = new System.Drawing.Point(3, 24);
            this.btnTest.Margin = new System.Windows.Forms.Padding(4);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(104, 40);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "清空日志";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(3, 24);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(755, 259);
            this.listBox1.TabIndex = 2;
            // 
            // txtFileList
            // 
            this.txtFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFileList.Location = new System.Drawing.Point(3, 24);
            this.txtFileList.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileList.Multiline = true;
            this.txtFileList.Name = "txtFileList";
            this.txtFileList.Size = new System.Drawing.Size(755, 173);
            this.txtFileList.TabIndex = 3;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSavePath.Location = new System.Drawing.Point(3, 24);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(491, 28);
            this.txtSavePath.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.Location = new System.Drawing.Point(577, 24);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(175, 35);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "选择路径";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Location = new System.Drawing.Point(471, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(175, 40);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "开始查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chbMatchWholeWord
            // 
            this.chbMatchWholeWord.AutoSize = true;
            this.chbMatchWholeWord.Checked = true;
            this.chbMatchWholeWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbMatchWholeWord.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbMatchWholeWord.Location = new System.Drawing.Point(646, 24);
            this.chbMatchWholeWord.Name = "chbMatchWholeWord";
            this.chbMatchWholeWord.Size = new System.Drawing.Size(106, 40);
            this.chbMatchWholeWord.TabIndex = 10;
            this.chbMatchWholeWord.Text = "精确匹配";
            this.chbMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索文件清单：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(761, 168);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件保存路径：";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnReadme);
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.chbMatchWholeWord);
            this.groupBox5.Controls.Add(this.btnTest);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox5.Location = new System.Drawing.Point(3, 98);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(755, 67);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtSavePath);
            this.groupBox4.Controls.Add(this.btnSelect);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 62);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.SizeChanged += new System.EventHandler(this.groupBox4_SizeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(761, 286);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "日志：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(515, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnReadme
            // 
            this.btnReadme.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReadme.Location = new System.Drawing.Point(325, 24);
            this.btnReadme.Name = "btnReadme";
            this.btnReadme.Size = new System.Drawing.Size(146, 40);
            this.btnReadme.TabIndex = 11;
            this.btnReadme.Text = "说明";
            this.btnReadme.UseVisualStyleBackColor = true;
            this.btnReadme.Click += new System.EventHandler(this.btnReadme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 654);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "文件搜索小工具V1.3";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox txtFileList;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbMatchWholeWord;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadme;
    }
}

