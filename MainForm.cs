using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            number = new VarMumber();
            method = new ComputeMethod();
            display = new ProcessDisplay();
        }

        VarMumber number;
        ComputeMethod method;
        ProcessDisplay display;


        #region 数字输入       

        private void butNum0_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_0(number.inString);
            number.inString = number.Char_0("0");
        }

        private void butNum1_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_1(number.inString);
            number.inString = number.Char_0("1");
        }

        private void butNum2_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_2(number.inString);
            number.inString = number.Char_0("2");
        }

        private void butNum3_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_3(number.inString);
            number.inString = number.Char_0("3");
        }

        private void butNum4_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_4(number.inString);
            number.inString = number.Char_0("4");
        }

        private void butNum5_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_5(number.inString);
            number.inString = number.Char_0("5");
        }

        private void butNum6_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_6(number.inString);
            number.inString = number.Char_0("6");
        }

        private void butNum7_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_7(number.inString);
            number.inString = number.Char_0("7");
        }

        private void butNum8_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_8(number.inString);
            number.inString = number.Char_0("8");
        }

        private void butNum9_Click(object sender, EventArgs e)
        {
            number.inString = number.Char_9(number.inString);
            number.inString = number.Char_0("9");
        }

        private void butNumPoint_Click(object sender, EventArgs e)
        {
            if (number.inString.IndexOf('.') == -1)
            {
                number.inString = number.Char_Point(number.inString);
                number.inString = number.Char_0(".");
            }
        }

        //实现方法有待探讨
        private void butSgn_Click(object sender, EventArgs e)
        {
            number.inString = number.StringSgn(number.inString);
        }

        #endregion


        //************************删除 、 清除错误 、 清除***************************
        private void butUndo_Click(object sender, EventArgs e)
        {
            number.inString = number.StringUndoStep(number.inString);
        }

        private void butClearError_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            number.outNum = 0;
            number.inString = "";
            number.methodSymbo = 0;
            method.listNum = null;
            rtxDisplay.Text += "---------------------------\n";
        }


        #region 数学运算符       

        private void butSymboAdd_Click(object sender, EventArgs e)
        {
            if (number.methodSymbo != 0)     //已输入运算符号
            {
                if (number.inString != "")
                {
                    number.outNum = method.ComputeMethodSelect(number.methodSymbo, number.inString, number.outNum);
                    number.methodSymbo = 0;
                }
            }
            else
            {
                if (number.inString != "")
                {
                    number.outNum = Convert.ToDouble(number.inString);
                }
                number.methodSymbo = 1;
            }
            number.inString = "";
        }

        private void butSymboSub_Click(object sender, EventArgs e)
        {
            if (number.methodSymbo != 0)
            {
                if (number.inString != "")
                {
                    number.outNum = method.ComputeMethodSelect(number.methodSymbo, number.inString, number.outNum);
                    number.methodSymbo = 0;
                }
            }
            else
            {
                if (number.inString != "")
                    number.outNum = Convert.ToDouble(number.inString);
                number.methodSymbo = 2;
            }
            number.inString = "";
        }


        private void butSymboMul_Click(object sender, EventArgs e)
        {
            if (number.methodSymbo != 0)
            {
                if (number.inString != "")
                {
                    number.outNum = method.ComputeMethodSelect(number.methodSymbo, number.inString, number.outNum);
                    number.methodSymbo = 0;
                }
            }
            else
            {
                if (number.inString != "")
                    number.outNum = Convert.ToDouble(number.inString);
                number.methodSymbo = 3;
            }
            number.inString = "";

        }

        private void butSymboDiv_Click(object sender, EventArgs e)
        {
            if (number.methodSymbo != 0)
            {
                if (number.inString != "")
                {
                    number.outNum = method.ComputeMethodSelect(number.methodSymbo, number.inString, number.outNum);
                    number.methodSymbo = 0;
                }
            }
            else
            {
                if (number.inString != "")
                    number.outNum = Convert.ToDouble(number.inString);
                number.methodSymbo = 4;
            }
            number.inString = "";
        }


        #endregion


        //计算并结果显示
        private void butResult_Click(object sender, EventArgs e)
        {
            if (number.methodSymbo != 0)
            {
                if (number.inString != "")
                {
                    number.outNum = method.ComputeMethodSelect(number.methodSymbo, number.inString, number.outNum);
                    number.methodSymbo = 0;
                }
            }
            else
            {
                if (number.inString != "")
                    number.outNum = Convert.ToDouble(number.inString);
                //number.methodSymbo = 1;
            }
            number.inString = "";
            //display.WriteResultToTextbox(txbResultDisplay, number.outNum.ToString());
            Clear();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                display.WriteResultAddToRichTextBox(rtxDisplay, i.ToString());
            }




        }
    }

}
