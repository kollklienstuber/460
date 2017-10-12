
/* 
     ----------------------------
     -- -- Koll Klienstuber -- --
     ----------------------------
 */
namespace Homework3
{
   
    class LinkedStack : ICalculatorStackAdt
    {
        private Node topNode;

        //push and pop 
        public object Push(object newItem)
        {
            if (newItem == null)
            {
                return null;
            }
            Node newNode = new Node(newItem, TopNode);
            TopNode = newNode;
            return newItem;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                return null;
            }
            object tempTop = TopNode.Data;
            TopNode = TopNode.NextNode;
            return tempTop;
        }


        public LinkedStack()
        {
            topNode = null;
        }

        //top node
        public Node TopNode
        {
            get { return topNode; }
            set { topNode = value; }
        }

        //condiational is empty operator for peeking
        public object Peek()
        {
            return IsEmpty() ? null : TopNode.Data;
        }

        //clears top node
        public void Clear()
        {
            this.TopNode = null;
        }

        //returns top node
        public bool IsEmpty()
        {
            return this.TopNode == null;
        }



    }
}
