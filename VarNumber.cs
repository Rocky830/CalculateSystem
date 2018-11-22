using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    class VarNumber
    {
        /// <summary>
        /// 变量初始化
        /// </summary>
        public VarNumber()
        {
            inNum = 0;
            outNum = 0;
            midNum = 0;
            methodSymbo = 0;
        }

        private double _inNum;
        private double _outNum;
        private double _midNum;
        private int _methodSymbo;
        public double inNum { get { return _inNum; } set { _inNum = value; } }
        public double outNum { get { return _outNum; } set { _outNum = value; } }
        public double midNum { get { return _midNum; } set { _midNum = value; } }
        public int methodSymbo { get { return _methodSymbo; } set { _methodSymbo = value; } }

        /// <summary>
        /// 输入字符 0
        /// </summary>
        /// <returns></returns>
        public string  Char_0()
        {
            return "0";
        }
        /// <summary>
        /// 输入字符 1
        /// </summary>
        /// <returns></returns>
        public string Char_1()
        {
            return "1";
        }
        /// <summary>
        /// 输入字符 2
        /// </summary>
        /// <returns></returns>
        public string Char_2()
        {
            return "2";
        }
        /// <summary>
        /// 输入字符 3
        /// </summary>
        /// <returns></returns>
        public string Char_3()
        {
            return "3";
        }
        /// <summary>
        /// 输入字符 4
        /// </summary>
        /// <returns></returns>
        public string Char_4()
        {
            return "4";
        }
        /// <summary>
        /// 输入字符 5
        /// </summary>
        /// <returns></returns>
        public string Char_5()
        {
            return "5";
        }
        /// <summary>
        /// 输入字符 6
        /// </summary>
        /// <returns></returns>
        public string Char_6()
        {
            return "6";
        }
        /// <summary>
        /// 输入字符 7
        /// </summary>
        /// <returns></returns>
        public string Char_7()
        {
            return "7";
        }
        /// <summary>
        /// 输入字符 8
        /// </summary>
        /// <returns></returns>
        public string Char_8()
        {
            return "8";
        }
        /// <summary>
        /// 输入字符 9
        /// </summary>
        /// <returns></returns>
        public string Char_9()
        {
            return "9";
        }
        /// <summary>
        /// 输入字符 .
        /// </summary>
        /// <returns></returns>
        public string Char_Point()
        {
            return ".";
        }
        /// <summary>
        /// 输入字符 -
        /// </summary>
        /// <returns></returns>
        public string Char_Sub()
        {
            return "-";
        }

        /// <summary>
        /// 数字字符串正负转换
        /// </summary>
        /// <param name="inNum"></param>
        public void StringInvert(ref string stringNum)
        {
            string str = stringNum.Substring(0, 1);
            if (str == "-")
            {
                stringNum = stringNum.Substring(1, stringNum.Length -1);
            }
        }

        /// <summary>
        /// 数字字符串向左删除一个字符
        /// </summary>
        /// <param name="stringNum"></param>
        public void StringUndoStep(ref string stringNum)
        {
            if (stringNum.Length >0)
            {
                stringNum = stringNum.Substring(0, stringNum.Length - 1);
            }
        }






    }
}
