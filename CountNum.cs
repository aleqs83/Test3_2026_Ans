using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3_2026_Ans
{
    class CountNum
    {
        private int num;
        private int count;

        public CountNum(int num, int count)
        {
            this.num = num;
            this.count = count;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }
        public int GetNum()
        {
           return this.num;
        }
        public void SetCount(int count)
        {
            this.count = count;
        }
        public int GetCount()
        {
            return this.count;
        }
        public override string ToString()
        {
            return $"[ num:{this.num} , count:{this.count} ]";
        }


    }
}
