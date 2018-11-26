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

            varMumber = new VarMumber();
            computeMethod = new ComputeMethod();
            processDisplay = new ProcessDisplay();
        }

        VarMumber varMumber;
        ComputeMethod computeMethod;
        ProcessDisplay processDisplay;


        #region 数字输入       

        private void butNum0_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_0(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "0");
        }

        private void butNum1_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_1(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "1");
        }

        private void butNum2_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_2(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "2");
        }

        private void butNum3_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_3(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "3");
        }

        private void butNum4_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_4(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "4");
        }

        private void butNum5_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_5(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "5");
        }

        private void butNum6_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_6(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "6");
        }

        private void butNum7_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_7(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "7");
        }

        private void butNum8_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_8(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "8");
        }

        private void butNum9_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_9(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, "9");
        }

        private void butNumPoint_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_Point(varMumber.inString);
            processDisplay.WriteNumberAddToTextbox(txbResultDisplay, ".");
        }

        private void butSgn_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.StringSgn(varMumber.inString);
        }
        #endregion


        //************************删除 、 清除错误 、 清除***************************
        private void butUndo_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.StringUndoStep(varMumber.inString);
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
            //varMumber.inNum = 0;
            //varMumber.midNum = 0;
            varMumber.outNum = 0;
            varMumber.inString = "";
            varMumber.methodSymbo = 0;
            //txbResultDisplay.Text = "";
            //txbResultDisplay.Text += Environment.NewLine;
        }


        #region 数学运算符       

        private void butSymboAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (varMumber.methodSymbo != 0)     //已输入运算符号
                {
                    if (varMumber.inString != "")
                    {
                        varMumber.outNum = computeMethod.ComputeMethodSelect(varMumber.methodSymbo, varMumber.inString, varMumber.outNum);
                        varMumber.methodSymbo = 0;
                    }
                }
                else
                {
                    if (varMumber.inString != "")
                    {
                        varMumber.outNum = Convert.ToDouble(varMumber.inString);

                        //processDisplay.WriteNumberToTextbox(txbResultDisplay, varMumber.inString);
                        //processDisplay.WriteMethodToTextbox(txbResultDisplay, "+");
                    }
                    varMumber.methodSymbo = 1;
                    processDisplay.WriteMethodAddToTextbox(txbResultDisplay, "+");

                }
                varMumber.inString = "";
            }
            catch (Exception)
            {
                throw;
            }
            textBox1.Text = varMumber.outNum.ToString();
        }

        private void butSymboSub_Click(object sender, EventArgs e)
        {
            try
            {
                if (varMumber.methodSymbo != 0)
                {
                    if (varMumber.inString != "")
                    {
                        varMumber.outNum = computeMethod.ComputeMethodSelect(varMumber.methodSymbo, varMumber.inString, varMumber.outNum);
                        varMumber.methodSymbo = 0;
                    }
                }
                else
                {
                    if (varMumber.inString != "")
                        varMumber.outNum = Convert.ToDouble(varMumber.inString);
                    varMumber.methodSymbo = 2;
                }
                varMumber.inString = "";
            }
            catch (Exception)
            {
                throw;
            }
            txbResultDisplay.Text = varMumber.outNum.ToString();
        }

        private void butSymboMul_Click(object sender, EventArgs e)
        {
            try
            {
                if (varMumber.methodSymbo != 0)
                {
                    if (varMumber.inString != "")
                    {
                        varMumber.outNum = computeMethod.ComputeMethodSelect(varMumber.methodSymbo, varMumber.inString, varMumber.outNum);
                        varMumber.methodSymbo = 0;
                    }
                }
                else
                {
                    if (varMumber.inString != "")
                        varMumber.outNum = Convert.ToDouble(varMumber.inString);
                    varMumber.methodSymbo = 3;
                }
                varMumber.inString = "";
            }
            catch (Exception)
            {
                throw;
            }
            txbResultDisplay.Text = varMumber.outNum.ToString();
        }

        private void butSymboDiv_Click(object sender, EventArgs e)
        {
            try
            {
                if (varMumber.methodSymbo != 0)
                {
                    if (varMumber.inString != "")
                    {
                        varMumber.outNum = computeMethod.ComputeMethodSelect(varMumber.methodSymbo, varMumber.inString, varMumber.outNum);
                        varMumber.methodSymbo = 0;
                    }
                }
                else
                {
                    if (varMumber.inString != "")
                        varMumber.outNum = Convert.ToDouble(varMumber.inString);
                    varMumber.methodSymbo = 4;
                }
                varMumber.inString = "";
            }
            catch (Exception)
            {
                throw;
            }
            txbResultDisplay.Text = varMumber.outNum.ToString();
        }

        #endregion


        //计算并结果显示
        private void butResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (varMumber.methodSymbo != 0)
                {
                    if (varMumber.inString != "")
                    {
                        varMumber.outNum = computeMethod.ComputeMethodSelect(varMumber.methodSymbo, varMumber.inString, varMumber.outNum);
                        varMumber.methodSymbo = 0;
                        processDisplay.WriteResultAddToTextbox(txbResultDisplay, varMumber.outNum.ToString ());
                    }
                }
                else
                {
                    if (varMumber.inString != "")
                        varMumber.outNum = Convert.ToDouble(varMumber.inString);
                    //varMumber.methodSymbo = 1;
                }
                varMumber.inString = "";
            }
            catch (Exception)
            {
                throw;
            }

            //processDisplay.WriteResultToTextbox(txbResultDisplay, varMumber.outNum.ToString());
            Clear();

        }


    }
}
