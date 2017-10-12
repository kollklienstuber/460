namespace Homework3
{
    //A simple singly linked node class.  This implementation comes from
   /* 
        ----------------------------
        -- -- Koll Klienstuber -- --
        ----------------------------
    */
    class Node
    {

        public Node NextNode
        {
            get { return nextNodeToProccess; }
            set { nextNodeToProccess = value; }
        }

        object data; 
        Node nextNodeToProccess;

        public object Data
        {
            get { return data; }
            set { data = value; }
        }


        public Node(object data, Node NodeNext)
        {
            this.data = data;
            this.nextNodeToProccess = NodeNext;
        }
    


    }
}
