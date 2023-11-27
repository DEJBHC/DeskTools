using Microsoft.Win32;
using Newtonsoft.Json;
using screenshot;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace DeskClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            this.BackColor = Color.White;
            this.label2.ContextMenuStrip = contextMenuStrip1;
            this.label2.ForeColor = Color.Yellow;
        }
        Point downPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - downPoint.X,
                    this.Location.Y + e.Y - downPoint.Y);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + System.DateTime.Now.DayOfWeek.ToString();
        }

        private void 设置字体属性ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示字体对话框
            DialogResult dr = fontDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                label2.Font = fontDialog1.Font;
            }
        }

        private void 设置主题颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //显示颜色对话框
            DialogResult dr = colorDialog1.ShowDialog();
            //如果在对话框中单击“确认”按钮，则更改文本框中的字体
            if (dr == DialogResult.OK)
            {
                label2.ForeColor = colorDialog1.Color;
            }
        }

        private void 关闭程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        private void 查看当前城市天气信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //我们的接口
            string url = "https://api.seniverse.com/v3/weather/daily.json?key=SVClIxjogZsYK2D2u&location=xuchang&language=zh-Hans&unit=c&start=-1&days=15";

            //将接口传入，这个HttpUitls的类，有兴趣可以研究下，也可以直接用就可以，不用管如何实现。
            string getJson = HttpUitls.Get(url);

            //这个需要引入Newtonsoft.Json这个DLL并using
            //传入我们的实体类还有需要解析的JSON字符串这样就OK了。然后就可以通过实体类使用数据了。
            Root rt = JsonConvert.DeserializeObject<Root>(getJson);

            //这样就可以取出json数据里面的值
            MessageBox.Show(rt.results[0].location.name + "市天气情况","天气信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(rt.results[0].daily[i].date + "\n白天：" + rt.results[0].daily[i].text_day + "\n晚上：" + rt.results[0].daily[i].text_night + "\n气温：[" + rt.results[0].daily[i].low + "," + rt.results[0].daily[i].high + "]\n降水量：" + rt.results[0].daily[i].rainfall + "mm\n降水概率：" + rt.results[0].daily[i].precip + "%\n风向：" + rt.results[0].daily[i].wind_direction + "\n风速：" + rt.results[0].daily[i].wind_speed + "km/h\n风力等级：" + rt.results[0].daily[i].wind_scale + "\n相对湿度：" + rt.results[0].daily[i].humidity + "%", "天气信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 查看其他城市天气信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void 置顶其他程序窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
                        
        }
        
        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
