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
    }
}
