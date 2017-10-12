using System;

namespace HW3
{
    
    public interface IStackADT
    {
        
        
        Object Push(Object newItem);

        Object Pop();

        Object Peek();

      
        bool IsEmpty();

       
        void Clear();
    }
}
