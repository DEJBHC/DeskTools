using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace DeskClock
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str=this.textBox1.Text;
            //我们的接口
            string url = "https://api.seniverse.com/v3/weather/daily.json?key=SVClIxjogZsYK2D2u&location="+str+"&language=zh-Hans&unit=c&start=-1&days=15";

            //将接口传入，这个HttpUitls的类，有兴趣可以研究下，也可以直接用就可以，不用管如何实现。
            string getJson = HttpUitls.Get(url);

            //这个需要引入Newtonsoft.Json这个DLL并using
            //传入我们的实体类还有需要解析的JSON字符串这样就OK了。然后就可以通过实体类使用数据了。
            Root rt = JsonConvert.DeserializeObject<Root>(getJson);
       

            //这样就可以取出json数据里面的值
            MessageBox.Show(rt.results[0].location.name + "市天气情况", "天气信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show(rt.results[0].daily[i].date + "天气\n白天：" + rt.results[0].daily[i].text_day + "\n晚上：" + rt.results[0].daily[i].text_night + "\n气温：[" + rt.results[0].daily[i].low + "," + rt.results[0].daily[i].high + "]\n降水量：" + rt.results[0].daily[i].rainfall + "mm\n降水概率：" + rt.results[0].daily[i].precip + "%\n风向：" + rt.results[0].daily[i].wind_direction + "\n风速：" + rt.results[0].daily[i].wind_speed + "km/h\n风力等级：" + rt.results[0].daily[i].wind_scale + "\n相对湿度：" + rt.results[0].daily[i].humidity + "%", "天气信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
