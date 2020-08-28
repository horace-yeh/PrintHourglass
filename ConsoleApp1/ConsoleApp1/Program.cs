using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        /// <summary>
        /// 奇數檢查
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static bool ChechSingle(int num)
        {
            return num % 2 > 0;
        }

        /// <summary>
        /// 列印沙漏圖形依照輸入數量僅能輸入奇數
        /// </summary>
        /// <param name="width"></param>
        private static void GeneHourglass(int width)
        {
            if (ChechSingle(width))
            {
                for (var i = width; i > 0; i -= 2)
                {
                    Console.WriteLine(GenLine(i, width));
                }
                if (width == 1)
                {
                    return;
                }
                for (var j = 3; j <= width; j += 2)
                {
                    Console.WriteLine(GenLine(j, width));
                }
            }
            else
            {
                Console.WriteLine("非奇數");
            }
        }

        /// <summary>
        /// 產生星號字串並置中處理
        /// </summary>
        /// <param name="startNum"></param>
        /// <param name="maxLen"></param>
        /// <returns></returns>
        private static string GenLine(int startNum, int maxLen)
        {
            var startStr = "*";
            var splaceStr = " ";
            if (startNum - maxLen == 0)
            {
                return StrDup(maxLen, startStr);
            }
            else
            {
                var spaceNum = (maxLen - startNum) / 2;
                return StrDup(spaceNum, splaceStr) + StrDup(startNum, startStr) + StrDup(spaceNum, splaceStr);
            }
        }

        private static void Main(string[] args)
        {
            var width = 11; //設定沙漏寬度
            GeneHourglass(width);
            Console.ReadLine();
        }

        /// <summary>
        /// 依照輸入的字串及重複數量產生字串
        /// </summary>
        /// <param name="num">數量</param>
        /// <param name="str">需要重複的字串</param>
        /// <returns></returns>
        private static string StrDup(int num, string str)
        {
            var temp = "";
            for (var i = 0; i < num; i++)
            {
                temp += str;
            }
            return temp;
        }
    }
}