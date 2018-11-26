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
        public void WriteNumberAddToTextbox(TextBox txb, string numberString)
        {
            //txb.Text += numberString;
            txb.AppendText(numberString);
        }

        /// <summary>
        /// 写入运算符号进控件显示
        /// </summary>
        /// <param name="txb"></param>
        /// <param name="methodString"></param>
        public void WriteMethodAddToTextbox(TextBox txb, string methodString)
        {
            txb.AppendText(methodString);
        }

        /// <summary>
        /// 写入结果进控件显示
        /// </summary>
        /// <param name="txb"></param>
        /// <param name="contentString"></param>
        public void WriteResultAddToTextbox(TextBox txb, string resultString)
        {
            txb.AppendText( "=" + resultString + "\r\n");
        }


        public void WriteDelToTextbox(TextBox txb)
        {
            string str = txb.Lines[txb.Lines.Length - 1];
        }





    }
}
