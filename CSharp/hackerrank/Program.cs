namespace hackerrank
{
    public class Program
    {     
        static void Main()
        {
          //Problem: Contacts
          //var no = new Trie(null);
          //var resultado = no.contacts();
          //resultado.ForEach(x => Console.WriteLine(x));

          //----------------------------------------------------

          //Problem: Tree: Preorder Traversal
            var tree = new Tree(1);
            tree.Left = new Tree(2);
            tree.Right = new Tree(3);
            tree.Left.Left = new Tree(4);
            tree.Left.Right = new Tree(5);
            tree.Right.Right = new Tree(6);

            tree.PreorderTraversal(tree);
        }
    }
}