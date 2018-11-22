using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcForm
{
    class ComputeMethod
    {
     
        /// <summary>
        /// 清除
        /// </summary>
        /// <param name="inNum"></param>
        /// <param name="outNum"></param>
        /// <param name="midNum"></param>
        /// <param name="methodSymbo"></param>
        public void Clear(ref double inNum, ref double outNum, ref double midNum,ref int methodSymbo)
        {
            inNum = 0;
            outNum = 0;
            midNum = 0;
            methodSymbo = 0;
        }

        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="inNum"></param>
        /// <param name="outNum"></param>
        public void AddMethod(double inNum, ref double outNum)
        {
            if (outNum == 0)
                outNum = inNum;
            else
                outNum += inNum;
        }

        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="inNum"></param>
        /// <param name="outNum"></param>
        public void SubMethod(double inNum, ref double outNum)
        {
            if (outNum == 0)
                outNum = inNum;
            else
                outNum += inNum;
        }

        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="inNum"></param>
        /// <param name="outNum"></param>
        public void MulMethod(double inNum, ref double outNum)
        {
            if (outNum == 0)
                outNum = inNum;
            else
                outNum += inNum;
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="inNum"></param>
        /// <param name="outNum"></param>
        public void DivMethod(double inNum, ref double outNum)
        {
            if (outNum == 0)
                outNum = inNum;
            else
                outNum += inNum;
        }

       


    }
}
