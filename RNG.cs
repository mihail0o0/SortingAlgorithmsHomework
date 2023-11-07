using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiZaSortiranje
{
    internal class RNG
    {
        public static RNG? instance;

        public RNG()
        {
            
        }


        public static RNG GetInstance()
        {
            if(instance == null)
            {
                instance = new RNG();
            }

            return instance;
        }


        public Int16[] createArray(int count, Int16 limit)
        {
            Int16[] array = new Int16[count];

            for(int i = 0; i < count; i++)
            {
                array[i] = Convert.ToInt16(new Random().Next(0, limit));
            }

            return array;
        }
    }
}