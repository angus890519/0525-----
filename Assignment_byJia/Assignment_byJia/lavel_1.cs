using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_byJia
{
    public partial class lavel_1 : UserControl
    {
        int game_num=0;
        int Winning_and_losing=0;
        public lavel_1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            if (Winning_and_losing ==0)
            {
                int rand_buffer1, rand_buffer2;//增益效果機率

                //初始化
                status1.Text = " ";
                status2.Text = " ";
                buffer1_pic.Visible = false;
                buffer2_pic.Visible = false;
                //初始化

                string rand_str1, rand_str2;
                int rand_num1, rand_num2;

                Random random = new Random();

                game_num += 1;
                game_num_text.Text = ("第" + game_num + "局");  //顯示第幾局

                rand_num1 = random.Next(1, 7);  //產生亂數
                rand_num2 = random.Next(1, 7);
                rand_str1 = rand_num1.ToString();//數字轉字串
                rand_str2 = rand_num2.ToString();
                rand_buffer1 = random.Next(0, 100);//增益效果機率100分之一
                rand_buffer2 = random.Next(0, 100);
                if (rand_buffer1 == 5)                //增益效果
                {
                    buffer1_pic.Visible = true;
                }
                if (rand_buffer2 == 5)
                {
                    buffer2_pic.Visible = true;
                }




                output_1.Text = rand_str1; //輸出
                output_2.Text = rand_str2;
                if (rand_num1 > rand_num2)     //遊戲玩法
                {
                    result_textbox1.Text = "winner";
                    result_textbox2.Text = "loser";
                    if (bloodbar2.Value >= 0)
                    {
                        if (bloodbar2.Value - ((rand_num1 - rand_num2) * 10) < 0)
                        {
                            output_2.Text = "over";
                            result1_label.Text = "獲勝!!!";
                            result2_label.Text = "落敗!!!";
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            bloodbar2.Value = 0;
                            Winning_and_losing = 1;

                        }
                        else
                        {
                            if (buffer1_pic.Visible == true)
                            {
                                if (bloodbar2.Value > (rand_num1 - rand_num2) * 10 * 2)
                                {
                                    bloodbar2.Value -= ((rand_num1 - rand_num2) * 10 * 2);
                                    status2.Text = ("-" + (rand_num1 - rand_num2) * 10 * 2);
                                }
                                else
                                {
                                    output_2.Text = "over";
                                    result1_label.Text = "獲勝!!!";
                                    result2_label.Text = "落敗!!!";
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    Winning_and_losing = 1;
                                    bloodbar2.Value = 0;
                                }

                            }
                            else
                            {
                                bloodbar2.Value -= ((rand_num1 - rand_num2) * 10);
                                status2.Text = ("-" + (rand_num1 - rand_num2) * 10);
                            }

                        }

                    }

                }
                else if (rand_num1 < rand_num2)
                {
                    result_textbox1.Text = "loser";
                    result_textbox2.Text = "winner";
                    if (bloodbar1.Value >= 0)
                    {
                        if (bloodbar1.Value - ((rand_num2 - rand_num1) * 10) < 0)
                        {
                            output_1.Text = "over";
                            result1_label.Text = "落敗!!!";
                            result2_label.Text = "獲勝!!!";
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            bloodbar1.Value = 0;
                            Winning_and_losing = 1;
                        }
                        else
                        {
                            if (buffer2_pic.Visible == true)
                            {
                                if (bloodbar1.Value > (rand_num2 - rand_num1) * 10 * 2)
                                {
                                    bloodbar1.Value -= ((rand_num2 - rand_num1) * 10 * 2);
                                    status1.Text = ("-" + (rand_num2 - rand_num1) * 10 * 2);

                                }
                                else
                                {
                                    output_1.Text = "over";
                                    result1_label.Text = "落敗!!!";
                                    result2_label.Text = "獲勝!!!";
                                    pictureBox1.Visible = false;
                                    pictureBox2.Visible = false;
                                    Winning_and_losing = 1;
                                    bloodbar1.Value = 0;


                                }

                            }
                            else
                            {
                                bloodbar1.Value -= ((rand_num2 - rand_num1) * 10);
                                status1.Text = ("-" + (rand_num2 - rand_num1) * 10);
                            }

                        }

                    }

                }
                else
                {
                    result_textbox1.Text = "平手";
                    result_textbox2.Text = "平手";
                    if (bloodbar1.Value < bloodbar1.Maximum - 20)
                    {
                        if (buffer1_pic.Visible == true)
                        {
                            bloodbar1.Value += 50;
                            status1.Text = ("+50");
                        }
                        else
                        {
                            bloodbar1.Value += 20;
                            status1.Text = ("+20");
                        }

                    }

                    if (bloodbar2.Value < bloodbar2.Maximum - 20)
                    {
                        if (buffer2_pic.Visible == true)
                        {
                            bloodbar2.Value += 50;
                            status2.Text = ("+50");
                        }
                        else
                        {
                            bloodbar2.Value += 20;
                            status2.Text = ("+20");
                        }

                    }

                }



            }

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Output_1_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void Result_textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            
        }

        private void Bloodbar1_Click(object sender, EventArgs e)
        {

        }

        private void Output_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buffer1_pic_Click(object sender, EventArgs e)
        {

        }

        private void Buffer2_pic_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ReStart_but_Click(object sender, EventArgs e)
        {
            bloodbar1.Value = bloodbar1.Maximum;
            bloodbar2.Value = bloodbar2.Maximum;
            Winning_and_losing = 0;
            status1.Text = " ";
            status2.Text = " ";
            buffer1_pic.Visible = false;
            buffer2_pic.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            game_num_text.Text = "  ";
            game_num = 0;
            output_1.Text = " ";
            output_2.Text = " ";
            result_textbox1.Text = " ";
            result_textbox2 .Text= " ";
            result1_label.Text = " ";
            result2_label.Text = " ";


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
