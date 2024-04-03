using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb1generics
{
    internal class BoxCollection : ICollection<Box>
    {
        private List <Box> innerCollection;

        public BoxCollection()
        {
            innerCollection = new List<Box>();
        }

        public int Count
        {
            get { return innerCollection.Count; }

        }

        public bool IsReadOnly {get { return false;}}

        public Box this[int index]
        {
            get { return (Box)innerCollection[index]; }
            set { innerCollection[index] = value; }
        }

        public void Add(Box item)
        {
            if(!Contains(item))
            {
                innerCollection.Add(item);
            }
            else
            {
                Console.WriteLine("This item already exist");
            }
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in innerCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            for(int i = 0; i < innerCollection.Count; i++)
            {
                if (innerCollection[i].Equals(item)) 
                {
                    innerCollection.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
