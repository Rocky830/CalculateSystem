namespace CalculateSystem
{
    partial class MainForm
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
            this.butUndo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.标准ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.科学ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.程序员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butClearError = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butSymboMul = new System.Windows.Forms.Button();
            this.butNum9 = new System.Windows.Forms.Button();
            this.butNum8 = new System.Windows.Forms.Button();
            this.butNum7 = new System.Windows.Forms.Button();
            this.butSymboDiv = new System.Windows.Forms.Button();
            this.butNum6 = new System.Windows.Forms.Button();
            this.butNum5 = new System.Windows.Forms.Button();
            this.butNum4 = new System.Windows.Forms.Button();
            this.butSymboSub = new System.Windows.Forms.Button();
            this.butNum3 = new System.Windows.Forms.Button();
            this.butNum2 = new System.Windows.Forms.Button();
            this.butNum1 = new System.Windows.Forms.Button();
            this.butSymboAdd = new System.Windows.Forms.Button();
            this.butResult = new System.Windows.Forms.Button();
            this.butNum0 = new System.Windows.Forms.Button();
            this.butNumPoint = new System.Windows.Forms.Button();
            this.butSgn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rtxDisplay = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butUndo
            // 
            this.butUndo.Location = new System.Drawing.Point(12, 109);
            this.butUndo.Name = "butUndo";
            this.butUndo.Size = new System.Drawing.Size(48, 33);
            this.butUndo.TabIndex = 0;
            this.butUndo.Text = "←";
            this.butUndo.UseVisualStyleBackColor = true;
            this.butUndo.Click += new System.EventHandler(this.butUndo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(235, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.标准ToolStripMenuItem,
            this.科学ToolStripMenuItem,
            this.程序员ToolStripMenuItem,
            this.统计信息ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 标准ToolStripMenuItem
            // 
            this.标准ToolStripMenuItem.Name = "标准ToolStripMenuItem";
            this.标准ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.标准ToolStripMenuItem.Text = "标准";
            // 
            // 科学ToolStripMenuItem
            // 
            this.科学ToolStripMenuItem.Name = "科学ToolStripMenuItem";
            this.科学ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.科学ToolStripMenuItem.Text = "科学";
            // 
            // 程序员ToolStripMenuItem
            // 
            this.程序员ToolStripMenuItem.Name = "程序员ToolStripMenuItem";
            this.程序员ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.程序员ToolStripMenuItem.Text = "程序员";
            // 
            // 统计信息ToolStripMenuItem
            // 
            this.统计信息ToolStripMenuItem.Name = "统计信息ToolStripMenuItem";
            this.统计信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.统计信息ToolStripMenuItem.Text = "统计信息";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助ToolStripMenuItem,
            this.关于计算器ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 查看帮助ToolStripMenuItem
            // 
            this.查看帮助ToolStripMenuItem.Name = "查看帮助ToolStripMenuItem";
            this.查看帮助ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.查看帮助ToolStripMenuItem.Text = "查看帮助";
            // 
            // 关于计算器ToolStripMenuItem
            // 
            this.关于计算器ToolStripMenuItem.Name = "关于计算器ToolStripMenuItem";
            this.关于计算器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于计算器ToolStripMenuItem.Text = "关于计算器";
            // 
            // butClearError
            // 
            this.butClearError.Location = new System.Drawing.Point(66, 109);
            this.butClearError.Name = "butClearError";
            this.butClearError.Size = new System.Drawing.Size(48, 33);
            this.butClearError.TabIndex = 4;
            this.butClearError.Text = "CE";
            this.butClearError.UseVisualStyleBackColor = true;
            this.butClearError.Click += new System.EventHandler(this.butClearError_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(120, 109);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(48, 33);
            this.butClear.TabIndex = 5;
            this.butClear.Text = "C";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butSymboMul
            // 
            this.butSymboMul.Location = new System.Drawing.Point(174, 109);
            this.butSymboMul.Name = "butSymboMul";
            this.butSymboMul.Size = new System.Drawing.Size(48, 33);
            this.butSymboMul.TabIndex = 10;
            this.butSymboMul.Text = "*";
            this.butSymboMul.UseVisualStyleBackColor = true;
            this.butSymboMul.Click += new System.EventHandler(this.butSymboMul_Click);
            // 
            // butNum9
            // 
            this.butNum9.Location = new System.Drawing.Point(120, 148);
            this.butNum9.Name = "butNum9";
            this.butNum9.Size = new System.Drawing.Size(48, 33);
            this.butNum9.TabIndex = 9;
            this.butNum9.Text = "9";
            this.butNum9.UseVisualStyleBackColor = true;
            this.butNum9.Click += new System.EventHandler(this.butNum9_Click);
            // 
            // butNum8
            // 
            this.butNum8.Location = new System.Drawing.Point(66, 148);
            this.butNum8.Name = "butNum8";
            this.butNum8.Size = new System.Drawing.Size(48, 33);
            this.butNum8.TabIndex = 8;
            this.butNum8.Text = "8";
            this.butNum8.UseVisualStyleBackColor = true;
            this.butNum8.Click += new System.EventHandler(this.butNum8_Click);
            // 
            // butNum7
            // 
            this.butNum7.Location = new System.Drawing.Point(12, 148);
            this.butNum7.Name = "butNum7";
            this.butNum7.Size = new System.Drawing.Size(48, 33);
            this.butNum7.TabIndex = 7;
            this.butNum7.Text = "7";
            this.butNum7.UseVisualStyleBackColor = true;
            this.butNum7.Click += new System.EventHandler(this.butNum7_Click);
            // 
            // butSymboDiv
            // 
            this.butSymboDiv.Location = new System.Drawing.Point(174, 148);
            this.butSymboDiv.Name = "butSymboDiv";
            this.butSymboDiv.Size = new System.Drawing.Size(48, 33);
            this.butSymboDiv.TabIndex = 14;
            this.butSymboDiv.Text = "/";
            this.butSymboDiv.UseVisualStyleBackColor = true;
            this.butSymboDiv.Click += new System.EventHandler(this.butSymboDiv_Click);
            // 
            // butNum6
            // 
            this.butNum6.Location = new System.Drawing.Point(120, 187);
            this.butNum6.Name = "butNum6";
            this.butNum6.Size = new System.Drawing.Size(48, 33);
            this.butNum6.TabIndex = 13;
            this.butNum6.Text = "6";
            this.butNum6.UseVisualStyleBackColor = true;
            this.butNum6.Click += new System.EventHandler(this.butNum6_Click);
            // 
            // butNum5
            // 
            this.butNum5.Location = new System.Drawing.Point(66, 187);
            this.butNum5.Name = "butNum5";
            this.butNum5.Size = new System.Drawing.Size(48, 33);
            this.butNum5.TabIndex = 12;
            this.butNum5.Text = "5";
            this.butNum5.UseVisualStyleBackColor = true;
            this.butNum5.Click += new System.EventHandler(this.butNum5_Click);
            // 
            // butNum4
            // 
            this.butNum4.Location = new System.Drawing.Point(12, 187);
            this.butNum4.Name = "butNum4";
            this.butNum4.Size = new System.Drawing.Size(48, 33);
            this.butNum4.TabIndex = 11;
            this.butNum4.Text = "4";
            this.butNum4.UseVisualStyleBackColor = true;
            this.butNum4.Click += new System.EventHandler(this.butNum4_Click);
            // 
            // butSymboSub
            // 
            this.butSymboSub.Location = new System.Drawing.Point(174, 187);
            this.butSymboSub.Name = "butSymboSub";
            this.butSymboSub.Size = new System.Drawing.Size(48, 33);
            this.butSymboSub.TabIndex = 18;
            this.butSymboSub.Text = "-";
            this.butSymboSub.UseVisualStyleBackColor = true;
            this.butSymboSub.Click += new System.EventHandler(this.butSymboSub_Click);
            // 
            // butNum3
            // 
            this.butNum3.Location = new System.Drawing.Point(120, 226);
            this.butNum3.Name = "butNum3";
            this.butNum3.Size = new System.Drawing.Size(48, 33);
            this.butNum3.TabIndex = 17;
            this.butNum3.Text = "3";
            this.butNum3.UseVisualStyleBackColor = true;
            this.butNum3.Click += new System.EventHandler(this.butNum3_Click);
            // 
            // butNum2
            // 
            this.butNum2.Location = new System.Drawing.Point(66, 226);
            this.butNum2.Name = "butNum2";
            this.butNum2.Size = new System.Drawing.Size(48, 33);
            this.butNum2.TabIndex = 16;
            this.butNum2.Text = "2";
            this.butNum2.UseVisualStyleBackColor = true;
            this.butNum2.Click += new System.EventHandler(this.butNum2_Click);
            // 
            // butNum1
            // 
            this.butNum1.Location = new System.Drawing.Point(12, 226);
            this.butNum1.Name = "butNum1";
            this.butNum1.Size = new System.Drawing.Size(48, 33);
            this.butNum1.TabIndex = 15;
            this.butNum1.Text = "1";
            this.butNum1.UseVisualStyleBackColor = true;
            this.butNum1.Click += new System.EventHandler(this.butNum1_Click);
            // 
            // butSymboAdd
            // 
            this.butSymboAdd.Location = new System.Drawing.Point(174, 226);
            this.butSymboAdd.Name = "butSymboAdd";
            this.butSymboAdd.Size = new System.Drawing.Size(48, 33);
            this.butSymboAdd.TabIndex = 22;
            this.butSymboAdd.Text = "+";
            this.butSymboAdd.UseVisualStyleBackColor = true;
            this.butSymboAdd.Click += new System.EventHandler(this.butSymboAdd_Click);
            // 
            // butResult
            // 
            this.butResult.Location = new System.Drawing.Point(174, 265);
            this.butResult.Name = "butResult";
            this.butResult.Size = new System.Drawing.Size(48, 33);
            this.butResult.TabIndex = 21;
            this.butResult.Text = "=";
            this.butResult.UseVisualStyleBackColor = true;
            this.butResult.Click += new System.EventHandler(this.butResult_Click);
            // 
            // butNum0
            // 
            this.butNum0.Location = new System.Drawing.Point(66, 265);
            this.butNum0.Name = "butNum0";
            this.butNum0.Size = new System.Drawing.Size(48, 33);
            this.butNum0.TabIndex = 19;
            this.butNum0.Text = "0";
            this.butNum0.UseVisualStyleBackColor = true;
            this.butNum0.Click += new System.EventHandler(this.butNum0_Click);
            // 
            // butNumPoint
            // 
            this.butNumPoint.Location = new System.Drawing.Point(120, 265);
            this.butNumPoint.Name = "butNumPoint";
            this.butNumPoint.Size = new System.Drawing.Size(48, 33);
            this.butNumPoint.TabIndex = 20;
            this.butNumPoint.Text = ".";
            this.butNumPoint.UseVisualStyleBackColor = true;
            this.butNumPoint.Click += new System.EventHandler(this.butNumPoint_Click);
            // 
            // butSgn
            // 
            this.butSgn.Enabled = false;
            this.butSgn.Location = new System.Drawing.Point(12, 265);
            this.butSgn.Name = "butSgn";
            this.butSgn.Size = new System.Drawing.Size(48, 33);
            this.butSgn.TabIndex = 23;
            this.butSgn.Text = "±";
            this.butSgn.UseVisualStyleBackColor = true;
            this.butSgn.Click += new System.EventHandler(this.butSgn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 307);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 21);
            this.textBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtxDisplay
            // 
            this.rtxDisplay.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxDisplay.Location = new System.Drawing.Point(12, 28);
            this.rtxDisplay.Name = "rtxDisplay";
            this.rtxDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtxDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxDisplay.Size = new System.Drawing.Size(210, 75);
            this.rtxDisplay.TabIndex = 33;
            this.rtxDisplay.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 340);
            this.Controls.Add(this.rtxDisplay);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butSgn);
            this.Controls.Add(this.butSymboAdd);
            this.Controls.Add(this.butResult);
            this.Controls.Add(this.butNumPoint);
            this.Controls.Add(this.butNum0);
            this.Controls.Add(this.butSymboSub);
            this.Controls.Add(this.butNum3);
            this.Controls.Add(this.butNum2);
            this.Controls.Add(this.butNum1);
            this.Controls.Add(this.butSymboDiv);
            this.Controls.Add(this.butNum6);
            this.Controls.Add(this.butNum5);
            this.Controls.Add(this.butNum4);
            this.Controls.Add(this.butSymboMul);
            this.Controls.Add(this.butNum9);
            this.Controls.Add(this.butNum8);
            this.Controls.Add(this.butNum7);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butClearError);
            this.Controls.Add(this.butUndo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butUndo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 标准ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 科学ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 程序员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于计算器ToolStripMenuItem;
        private System.Windows.Forms.Button butClearError;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butSymboMul;
        private System.Windows.Forms.Button butNum9;
        private System.Windows.Forms.Button butNum8;
        private System.Windows.Forms.Button butNum7;
        private System.Windows.Forms.Button butSymboDiv;
        private System.Windows.Forms.Button butNum6;
        private System.Windows.Forms.Button butNum5;
        private System.Windows.Forms.Button butNum4;
        private System.Windows.Forms.Button butSymboSub;
        private System.Windows.Forms.Button butNum3;
        private System.Windows.Forms.Button butNum2;
        private System.Windows.Forms.Button butNum1;
        private System.Windows.Forms.Button butSymboAdd;
        private System.Windows.Forms.Button butResult;
        private System.Windows.Forms.Button butNum0;
        private System.Windows.Forms.Button butNumPoint;
        private System.Windows.Forms.Button butSgn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtxDisplay;
    }
}

