using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    class VarMumber 
    {
        /// <summary>
        /// 变量初始化
        /// </summary>
        public VarMumber()
        {
            inString = "";
            inNum = 0;
            outNum = 0;
            midNum = 0;
            methodSymbo = 0;
        }

        private string _inString;
        private double _inNum;
        private double _outNum;
        private double _midNum;
        private int _methodSymbo;
        public string inString { get { return _inString; } set { _inString = value; } }
        public double inNum { get { return _inNum; } set { _inNum = value; } }
        public double outNum { get { return _outNum; } set { _outNum = value; } }
        public double midNum { get { return _midNum; } set { _midNum = value; } }
        public int methodSymbo { get { return _methodSymbo; } set { _methodSymbo = value; } }

        #region 数字输入

        /// <summary>
        /// 输入字符 0
        /// </summary>
        /// <param name="inString"></param>
        public string Char_0(string inString)
        {
            inString += "0";
            return inString;
        }
        /// <summary>
        /// 输入字符 1
        /// </summary>
        /// <param name="inString"></param>
        public string Char_1(string inString)
        {
            inString += "1";
            return inString;
        }
        /// <summary>
        /// 输入字符 2
        /// </summary>
        /// <param name="inString"></param>
        public string Char_2(string inString)
        {
            inString += "2";
            return inString;
        }
        /// <summary>
        /// 输入字符 3
        /// </summary>
        /// <param name="inString"></param>
        public string Char_3(string inString)
        {
            inString += "3";
            return inString;
        }
        /// <summary>
        /// 输入字符 4
        /// </summary>
        /// <param name="inString"></param>
        public string Char_4(string inString)
        {
            inString += "4";
            return inString;
        }
        /// <summary>
        /// 输入字符 5
        /// </summary>
        /// <param name="inString"></param>
        public string Char_5(string inString)
        {
            inString += "5";
            return inString;
        }
        /// <summary>
        /// 输入字符 6
        /// </summary>
        /// <param name="inString"></param>
        public string Char_6(string inString)
        {
            inString += "6";
            return inString;
        }
        /// <summary>
        /// 输入字符 7
        /// </summary>
        /// <param name="inString"></param>
        public string Char_7(string inString)
        {
            inString += "7";
            return inString;
        }
        /// <summary>
        /// 输入字符 8
        /// </summary>
        /// <param name="inString"></param>
        public string Char_8(string inString)
        {
            inString += "8";
            return inString;
        }
        /// <summary>
        /// 输入字符 9
        /// </summary>
        /// <param name="inString"></param>
        public string Char_9(string inString)
        {
            inString += "9";
            return inString;
        }
        /// <summary>
        /// 输入字符 .
        /// </summary>
        /// <param name="inString"></param>
        public string Char_Point(string inString)
        {
            if (inString.Length > 0)
            {
                if (inString.IndexOf('.') == -1)
                    inString = "0.";
            }
            else
                inString += '0';
            return inString;
        }

        /// <summary>
        /// 数字字符串正负转换
        /// </summary>
        /// <param name="inString"></param>
        public string StringSgn(string inString)
        {
            if (inString != "0" && inString.Length > 0)
            {
                string str = inString.Substring(0, 1);
                if (str == "-")
                    inString = inString.Substring(1, inString.Length - 1);  //去掉负号              
                else
                    inString = inString.Insert(0, "-"); //添加负号
            }
            return inString;
        }
        
        #endregion
        
        /// <summary>
        /// 数字字符串向左删除一个字符
        /// </summary>
        /// <param name="inString"></param>
        public string StringUndoStep(string inString)
        {
            string str = inString.Substring(0, 1);
            if (str == "-")
            {
                if (inString.Length > 1)
                    inString = inString.Substring(0, inString.Length - 1);
            }
            else
            {
                if (inString.Length > 0)
                    inString = inString.Substring(0, inString.Length - 1);
            }
            return inString;
        }

        /// <summary>
        /// 写入TextBox控件
        /// </summary>
        /// <param name="txb">控件名</param>
        /// <param name="inString">写入内容</param>
        public void WriteToTextbox(TextBox txb,string inString)
        {

        }




    }
}
