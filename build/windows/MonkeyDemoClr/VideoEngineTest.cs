using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monkey_demo_clr
{
    public partial class VideoEngineTest : Form
    {
        public VideoEngineTest()
        {
            InitializeComponent();
        }

		private void VideoEngineTest_Load(object sender, EventArgs e)
		{
			
		}

		private void Init_btn_Click(object sender, EventArgs e)
		{
			SdkProxy.Instance().Init();
		}

		private void Run_btn_Click(object sender, EventArgs e)
		{

		}
	}
}
