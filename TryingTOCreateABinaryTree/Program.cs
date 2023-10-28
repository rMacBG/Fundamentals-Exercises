namespace TryingTOCreateABinaryTree
{
    public class Node 
    {
        public int value;
        public Node left;
        public Node right;

    }

    public class Tree
    {
        public void AddNode(ref Node root, int key)
        {
            Node newNode = new Node();
            newNode.value = key;
            newNode.left = newNode.right = null;
            if (root == null)
                root = newNode;
            else
            {
                if (key < root.value)
                    AddNode(ref root.left, key);
                else
                    AddNode(ref root.right, key);
            }
        }
        public void AddNodeNR(ref Node root, int key)
        {
            Node newNode = new Node();

            newNode.value = key;
            newNode.left = newNode.right = null;
            if(root == null)
                root = newNode;
            else
            {
                Node prior = root;
                Node next;
                if(key < prior.value)
                    next = prior.left;
                else
                    next = prior.right;
                while(next != null)
                {
                    prior = next;
                    if(key < prior.value)
                        next = prior.left;
                    else
                        next = prior.right;
                }
                if (key < prior.value)
                    prior.left = newNode;
                else prior.right = newNode;
                
            }
        }   
        public void PrintTree(Node root)
        {
            if(root.left != null)
                PrintTree(root.left);
            Console.Write("{0} ", root.value);
            if(root.right != null)
                PrintTree(root.right);

        }
        public bool SearchNode(Node root, int key)
        {
            Node temp = root;
            while (temp != null)
            {
                if (temp.value == key)
                    return true;
                else if (key < temp.value)
                    temp = temp.left;
                else
                    temp = temp.right;
            }
            return false;
        }
        public Node FindMinRight(Node root)
        {
            Node result = root.right;
            while (result.left != null)
                result = result.left;
            return result;
            
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>();
            Random rnd = new Random();
            int[] arr = new int[30];
            for (int i = 0; i < 30; i++)
            {
                n.Add(rnd.Next(1, 100));
            }
            Node root = null;
            Tree t = new Tree();
            for (int i = 0; i < arr.Length; i++)
                t.AddNodeNR(ref root, n.Count);
            t.PrintTree(root);
            Console.WriteLine();
           // t.RemoveNode(ref root, 6);
            t.PrintTree(root);
            Console.WriteLine();

        }
    }
}