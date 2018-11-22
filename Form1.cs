using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            varMumber = new VarMumber();
            computeMethod = new ComputeMethod();
        }

        VarMumber varMumber;
        ComputeMethod computeMethod;



        private void button1_Click(object sender, EventArgs e)
        {
            string str = "qqwqwq";
            //aaa( str);
            Console.WriteLine(str);
        }


        #region 数字输入       

        private void butNum0_Click(object sender, EventArgs e)
        {
            varMumber .inString =varMumber.Char_0(varMumber.inString);

        }

        private void butNum1_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_1(varMumber.inString);
        }

        private void butNum2_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_2(varMumber.inString);
        }

        private void butNum3_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_3(varMumber.inString);
        }

        private void butNum4_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_4(varMumber.inString);
        }

        private void butNum5_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_5(varMumber.inString);
        }

        private void butNum6_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_6(varMumber.inString);
        }

        private void butNum7_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_7(varMumber.inString);
        }

        private void butNum8_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_8(varMumber.inString);
        }

        private void butNum9_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_9(varMumber.inString);
        }

        private void butNumPoint_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.Char_Point(varMumber.inString);
        }

        private void butSgn_Click(object sender, EventArgs e)
        {
            varMumber.inString = varMumber.StringSgn(varMumber.inString);
        }
        #endregion

        #region 数学运算符       
        
        private void butSymboMul_Click(object sender, EventArgs e)
        {

        }

        private void butSymboDiv_Click(object sender, EventArgs e)
        {

        }

        private void butSymboSub_Click(object sender, EventArgs e)
        {

        }

        private void butSymboAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion


        private void butUndo_Click(object sender, EventArgs e)
        {

        }

        private void butClearError_Click(object sender, EventArgs e)
        {

        }


        private void butResult_Click(object sender, EventArgs e)
        {

        }

    }
}
