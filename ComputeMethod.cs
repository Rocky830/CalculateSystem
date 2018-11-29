using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSystem
{
    class ComputeMethod
    {

        public ComputeMethod()
        {
            listNum = null;
        }

        private List<string> _listNum;
        public List<string> listNum { get { return _listNum; } set { _listNum = value; } }



        #region 输入缓冲

        //public List<string> AddNumber(List<string> listNum, string str)
        //{
        //    listNum.Add(str);
        //    return listNum;
        //}

        //public List<string> DelNumber(List<string> listNum)
        //{
        //    if (listNum.Count > 0)
        //        listNum.Remove(listNum.Last());
        //    else
        //        listNum.Clear();

        //    return listNum;
        //}

        //public List<string> ClearNumber(List<string> listNum)
        //{
        //    listNum.Clear();

        //    return listNum;
        //}

        #endregion
        

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

            return outNum;
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
