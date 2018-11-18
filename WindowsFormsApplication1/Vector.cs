using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Vector
    {
        private int[] array;
        private static Vector instance = null;
        Vector()
        {
        }
        public static Vector getInstance()
        {
            if(instance == null)
            {
                instance = new Vector();
            }
            return instance;
        }
        public void addOrd(int val)
        {
            this.array[array.Length] = val;
            Array.Sort(array);
        }
        public int[] getArray()
        {
            return this.array;
        }
    }
}
