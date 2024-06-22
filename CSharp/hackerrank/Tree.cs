namespace hackerrank
{
    public class Tree
    {
        public Tree Left { get; set; }
        public Tree Right { get; set; }
        public int Value { get; set; }

        public Tree(int Value)
        {
            this.Value = Value;
        }

        /*
        Complete the  function in the editor below, which has  parameter: a pointer to the root of a binary tree.
        It must print the values in the tree's preorder traversal as a single line of space-separated values.
       */
        public void PreorderTraversal(Tree root)
        {
            if (root is null)
            {
                return;
            }
            Console.Write($"{root.Value} ");

            PreorderTraversal(root.Left);
            PreorderTraversal(root.Right);
        }
    }
}
