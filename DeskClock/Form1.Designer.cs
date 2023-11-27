
namespace DeskClock
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置字体属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置主题颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看天气信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看当前城市天气信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看其他城市天气信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.置顶其他程序窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("宋体", 58.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 97);
            this.label1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label2.Font = new System.Drawing.Font("宋体", 58.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 97);
            this.label2.TabIndex = 1;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置字体属性ToolStripMenuItem,
            this.设置主题颜色ToolStripMenuItem,
            this.查看天气信息ToolStripMenuItem,
            this.置顶其他程序窗口ToolStripMenuItem,
            this.关闭程序ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 152);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 设置字体属性ToolStripMenuItem
            // 
            this.设置字体属性ToolStripMenuItem.Name = "设置字体属性ToolStripMenuItem";
            this.设置字体属性ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.设置字体属性ToolStripMenuItem.Text = "设置字体属性";
            this.设置字体属性ToolStripMenuItem.Click += new System.EventHandler(this.设置字体属性ToolStripMenuItem_Click);
            // 
            // 设置主题颜色ToolStripMenuItem
            // 
            this.设置主题颜色ToolStripMenuItem.Name = "设置主题颜色ToolStripMenuItem";
            this.设置主题颜色ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.设置主题颜色ToolStripMenuItem.Text = "设置主题颜色";
            this.设置主题颜色ToolStripMenuItem.Click += new System.EventHandler(this.设置主题颜色ToolStripMenuItem_Click);
            // 
            // 查看天气信息ToolStripMenuItem
            // 
            this.查看天气信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看当前城市天气信息ToolStripMenuItem,
            this.查看其他城市天气信息ToolStripMenuItem});
            this.查看天气信息ToolStripMenuItem.Name = "查看天气信息ToolStripMenuItem";
            this.查看天气信息ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.查看天气信息ToolStripMenuItem.Text = "查看天气信息";
            // 
            // 查看当前城市天气信息ToolStripMenuItem
            // 
            this.查看当前城市天气信息ToolStripMenuItem.Name = "查看当前城市天气信息ToolStripMenuItem";
            this.查看当前城市天气信息ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.查看当前城市天气信息ToolStripMenuItem.Text = "查看当前城市天气信息";
            this.查看当前城市天气信息ToolStripMenuItem.Click += new System.EventHandler(this.查看当前城市天气信息ToolStripMenuItem_Click);
            // 
            // 查看其他城市天气信息ToolStripMenuItem
            // 
            this.查看其他城市天气信息ToolStripMenuItem.Name = "查看其他城市天气信息ToolStripMenuItem";
            this.查看其他城市天气信息ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.查看其他城市天气信息ToolStripMenuItem.Text = "查看其他城市天气信息";
            this.查看其他城市天气信息ToolStripMenuItem.Click += new System.EventHandler(this.查看其他城市天气信息ToolStripMenuItem_Click);
            // 
            // 置顶其他程序窗口ToolStripMenuItem
            // 
            this.置顶其他程序窗口ToolStripMenuItem.Name = "置顶其他程序窗口ToolStripMenuItem";
            this.置顶其他程序窗口ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.置顶其他程序窗口ToolStripMenuItem.Text = "截图工具";
            this.置顶其他程序窗口ToolStripMenuItem.Click += new System.EventHandler(this.置顶其他程序窗口ToolStripMenuItem_Click);
            // 
            // 关闭程序ToolStripMenuItem
            // 
            this.关闭程序ToolStripMenuItem.Name = "关闭程序ToolStripMenuItem";
            this.关闭程序ToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.关闭程序ToolStripMenuItem.Text = "关闭程序";
            this.关闭程序ToolStripMenuItem.Click += new System.EventHandler(this.关闭程序ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 183);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置字体属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭程序ToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 设置主题颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看天气信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看当前城市天气信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看其他城市天气信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 置顶其他程序窗口ToolStripMenuItem;
    }
}

