/** C Sharp Interface defining a Stack.
        ----------------------------
        -- -- Koll Klienstuber -- --
        ----------------------------
 */


using System;

namespace Calculator
{
    
   	
	 // Push an item onto the top of the stack. Pushing an object that 
	 // doesn’t exist should result in an error and should not succeed.
	// Pushing an object that is not an item should result in an error.
	 // This operation returns a reference (pointer or link, but not a copy)
	 // to the item pushed so that an anonymous object can be pushed and then used.
	  <param> newItem The object to push onto the top of the stack.Should not be null</param>
	 // @return A reference to the object that was pushed, or null if newItem == null
	 //
    public interface IStackADT
    {
        /*

        */
        Object Push(Object newItem);
        /*

       */


        Object Pop();
        /*

       */


        Object Peek();

        /*

       */


        bool IsEmpty();

        /*

       */
        void Clear();
    }
}
