using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_using_CSharp
{
    public class Stack
    {
        List<object> list = new List<object>();
        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Object of type 'null' cannot be passed in to this method.");
            }
            list.Add(obj);
        }
        public object Pop() 
        {
            if(list.Count == 0)
                throw new InvalidOperationException("Cannot pop an element off an empty stack.");
            
            var item = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);

            return item;
        }
        public void Clear() 
        { 
            list.Clear();
        }


    }
}
