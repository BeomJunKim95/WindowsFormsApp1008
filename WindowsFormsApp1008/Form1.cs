using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1008
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label1.Text = "200";
			progressBar1.Value = 100;
			timer1.Interval = 100;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//timer1.Enabled = true;
			timer1.Start(); // 둘중하나만 줘도 됨
			//progressBar1.Value = 70;
		}


		private void button2_Click(object sender, EventArgs e)
		{
			timer1.Stop();
			//.Value = 30;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (progressBar1.Value < 10) // value가 minimum범위 밖으로 내려가서 예외가 나오는 걸 방지
			{
				progressBar1.Value = 0;
				timer1.Stop();
			}
			else
				progressBar1.Value -= 10;
			//progressBar1.Value = progressBar1.Value - 10;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			timer1.Start();
		}

		//private void textBox1_KeyDown(object sender, KeyEventArgs e)
		//{

		//}
		//KeyDown은 유니코드라 더 많은걸 할수있음
		//KeyDown은 ctrl , shift, alt 등 복합키도 가능
		// 단축키 복합키 등을 쓸때는 KeyDown이 맞음( ex. 게임등 복잡한 키를 눌러야할때)
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == /*Keys.Enter*/13)
			{
				timer1.Stop();
				//정답체크
				if (label4.Text == textBox1.Text)
				{
					//점수 올려준다
				}
				else
				{
					//기회를 빼준다
				}
				//문제를 다시출제
			}
		}
		//KeyPress는 아스키코드로 표현할수 없는건 못함
		//타자연습게임처럼 단순히 키가 눌렷냐 안눌렸냐 따질때는 KeyPress도 깔끔하게 쓸수있다
	}
}
