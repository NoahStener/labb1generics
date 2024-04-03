using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1generics
{
    internal class BoxEnumerator:IEnumerator<Box>
    {
        private BoxCollection _boxcollection;
        private int _index;
        private Box currentBox;

        public BoxEnumerator(BoxCollection box)
        {
            this._boxcollection = box;
            _index = -1;
            currentBox = default(Box);
          
        }

        public Box Current { get { return currentBox; } }

        object IEnumerator.Current { get { return Current; } }

        public int Count
        {
            get { return _boxcollection.Count; }

        }

        public bool MoveNext()
        {
            _index++;

            if(_index < _boxcollection.Count)
            {
                currentBox = _boxcollection[_index];
                return true;
            }
            return false;
            
        }

        void IEnumerator.Reset()
        {
            _index = -1;
        }
        public void Dispose() 
        {

        }
    }
}
