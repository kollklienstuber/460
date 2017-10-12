namespace Calculator
{

    class LinkedStack : IStackADT
    {
        private Node topNode;
        
        public LinkedStack()
        {
            topNode = null;
        }

        public object Peek()
        {
            return IsEmpty() ? null : TopNode.Data;
        }


        public bool IsEmpty()
        {
            return this.TopNode == null;
        }

        public Node TopNode
        {
            get { return topNode; }
            set { topNode = value; }
        }


        public void Clear()
        {
            this.TopNode = null;
        }



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


    }

}
