using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window
{
    class CommonClass
    {
        /// <summary>
        /// 实现随机数验证码
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public String RandomNum(int n)
        {
            //定义一个包括数字、大写英文字母和小写英文字母字符串
            String strchar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            //将 strchar 字符串转化为数组
            //String.Split 方法返回包括此实例中的子字符串（由指定Char数组的元素分隔）的String 数组
            String[] VcArray = strchar.Split(',');
            String VNum = "";
            //记录上次的随机数、尽量避免产生几个相同的随机数
            int temp = 1;
            //采用一个简单的算法以保证生成随机数的不同
            Random rand = new Random();
            for (int i = 1; i < n + 1; i++)
            {
                if (temp != -1)
                {
                    //umchecked 关键字用于取消整型算术运算转换的溢出检查
                    //DateTime.Ticks 属性获取表示此实例的日期和时间的刻度数
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                //Randow.Next 方法返回一个小于所指定最大值的非负数随机数
                int t = rand.Next(61);
                if (temp != -1 && temp == t)
                {
                    return RandomNum(n);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;//返回生成的随机数
        }
    }
}
