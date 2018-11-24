using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSystem
{
    class ComputeMethod
    {
        #region +-*/计算方法

        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="inString"></param>
        /// <param name="outNum"></param>
        public double AddMethod(string inString, double outNum)
        {
            double inNum = Convert.ToDouble(inString);
            outNum += inNum;

            return outNum;
        }

        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="inString"></param>
        /// <param name="outNum"></param>
        public double SubMethod(string inString, double outNum)
        {
            double inNum = Convert.ToDouble(inString);
            outNum -= inNum;

            return outNum;
        }

        /// <summary>
        /// 乘法
        /// </summary>
        /// <param name="inString"></param>
        /// <param name="outNum"></param>
        public double MulMethod(string inString, double outNum)
        {
            double inNum = Convert.ToDouble(inString);
            outNum *= inNum;

            return outNum;
        }

        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="inString"></param>
        /// <param name="outNum"></param>
        public double DivMethod(string inString, double outNum)
        {
            double inNum = Convert.ToDouble(inString);
            outNum /= inNum;

            if (inNum != 0)
                return outNum;
            else
                return outNum = 0;
        }

        #endregion


        /// <summary>
        /// 计算方法选择
        /// </summary>
        /// <param name="methodSymbo"></param>
        /// <param name="inString"></param>
        /// <param name="outNum"></param>
        /// <returns></returns>
        public double ComputeMethodSelect(int methodSymbo, string inString, double outNum)
        {
            switch (methodSymbo)
            {
                case 1:
                    outNum = AddMethod(inString, outNum);
                    break;
                case 2:
                    outNum = SubMethod(inString, outNum);
                    break;
                case 3:
                    outNum = MulMethod(inString, outNum);
                    break;
                case 4:
                    outNum = DivMethod(inString, outNum);
                    break;

                default:
                    break;
            }
            return outNum;
        }




    }
}
