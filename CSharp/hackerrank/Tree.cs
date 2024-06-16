using System.Xml.Linq;

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

        public void PreorderTraversal(Tree root)
        {
            if(root is null)
            {
                return;
            }
            Console.Write($"{ root.Value} ");

            PreorderTraversal(root.Left);
            PreorderTraversal(root.Right);
        }
    }
}
