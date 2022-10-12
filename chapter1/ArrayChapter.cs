using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace luohao_data_structure_cs.chapter1
{
    internal class ArrayChapter
    {
        public void print()
        {
            int[] elems = new int[] { 2, 2, 1 };
            Console.WriteLine(singleNumber(elems));
            elems = new int[] { 4, 1, 2, 1, 2 };
            Console.WriteLine(Test1(elems));
        }
        /*
         * 给定一个非空整数数组，除了某个元素只出现一次以外，其余每个元素均出现两次。找出那个只出现了一次的元素。
         * 你的算法应该具有线性时间复杂度。 你可以不使用额外空间来实现吗？
         * 输入: [2,2,1]
         * 输出: 1
         * 
         * 输入: [4,1,2,1,2]
         * 输出: 4
         */
        public int Test1(int[] elems)
        {
            int result = int.MaxValue;
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for(int index = 0; index < elems.Length; index++)
            {
                int curKey = elems[index];
                if (!hashMap.ContainsKey(curKey))
                {
                    hashMap.Add(curKey, 0);
                }
                hashMap[curKey] += 1;
            }
            foreach (int key in hashMap.Keys)
            {
                if (hashMap[key] == 1)
                {
                    result = key;
                }
            }
            return result;
        }

        /*
         * 任何数和0做异或运算，结果仍然是原来的数，即 a⊕0=a。
         * 任何数和其自身做异或运算，结果是 0，即 a⊕a=0。
         * 异或运算满足交换律和结合律，即 a⊕b⊕a=b⊕a⊕a=b⊕(a⊕a)=b⊕0=b。
         */
        public int singleNumber(int[] nums)
        {
            int ret = 0;
            foreach (int num in nums)
            {
                ret ^= num;
            }
            return ret;
        }
    }
}