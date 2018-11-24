using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateSystem
{
    class ProcessDisplay
    {

        /// <summary>
        /// 写入数字进控件显示
        /// </summary>
        /// <param name="txb"></param>
        /// <param name="numberString"></param>
        public void WriteNumberToTextbox(TextBox txb, string numberString)
        {
            txb.Text += numberString;
        }

        /// <summary>
        /// 写入运算符号进控件显示
        /// </summary>
        /// <param name="txb"></param>
        /// <param name="methodString"></param>
        public void WriteMethodToTextbox(TextBox txb, string methodString)
        {
            txb.Text += methodString;
        }

        /// <summary>
        /// 写入结果进控件显示
        /// </summary>
        /// <param name="txb"></param>
        /// <param name="contentString"></param>
        public void WriteResultToTextbox(TextBox txb, string resultString)
        {
            txb.Text = txb.Text + "=" + resultString + "\r\n";
        }


    }
}
