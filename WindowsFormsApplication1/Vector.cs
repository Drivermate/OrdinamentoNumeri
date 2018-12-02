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
        private List<int> l = new List<int>();
        private static Vector instance = null;
        Vector()
        {
            array = new int[0];
        }
        public void clear()
        {
            this.l.Clear();
        }
        public static Vector getInstance()
        {
            if (instance == null)
            {
                instance = new Vector();
            }
            return instance;
        }
        public void addOrd(int val)
        {
            l.Add(val);
            this.array = l.ToArray();
            Array.Sort(array);
        }
        public int[] getArray()
        {
            return this.array;
        }
    }
}