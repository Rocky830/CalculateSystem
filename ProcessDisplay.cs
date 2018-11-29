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
        /// <param name="rtx"></param>
        /// <param name="numberString"></param>
        public void WriteNumberAddToRichTextBox(RichTextBox rtx, string numberString)
        {
            rtx.Text += numberString;
        }

        /// <summary>
        /// 写入运算符号进控件显示
        /// </summary>
        /// <param name="rtx"></param>
        /// <param name="methodString"></param>
        public void WriteMethodAddToRichTextBox(RichTextBox rtx, string methodString)
        {
            rtx.Text += methodString;
        }

        /// <summary>
        /// 写入结果进控件显示
        /// </summary>
        /// <param name="rtx"></param>
        /// <param name="contentString"></param>
        public void WriteResultAddToRichTextBox(RichTextBox rtx, string resultString)
        {
            rtx.Text += " = " + resultString + "\n" + "---------------------------\n";
        }


        //public void WriteDelToTextbox(ListBox txb)
        //{

        //}





    }
}
