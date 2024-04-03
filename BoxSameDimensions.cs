using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1generics
{
    internal class BoxSameDimensions : EqualityComparer<Box>
    {
        public override bool Equals(Box B1, Box B2)
        {
           if(B1.Height == B2.Height && B1.Width == B2.Width && B1.Length == B2.Length)
           {
                return true;
           }
           else
           {
                return false;
           }
        }

        public override int GetHashCode(Box b)
        {
            return b.GetHashCode();
        }
    }
}
