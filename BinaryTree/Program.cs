using System;

// C# program to find largest 
// subtree sum in a given binary tree. 

public class BinaryTree
{
    public static int MaxScore = 0;

    // Structure of a tree node. 
    public class Tree
    {
        public int value;
        public Tree left;
        public Tree right;

        public Tree(int newValue)
        {
            value = newValue;
            left = null;
            right = null;
        }
    };

    /// Start search
    public static int FindMaxScore(Tree Tree) {
        
        if (Tree == null)
            return 0;

        FindSubTree(Tree);

        return MaxScore;
    }
    
    public static int FindSubTree(Tree Tree)
    {
        if (Tree == null)
            return 0;

        int left = FindSubTree(Tree.left);
        int right = FindSubTree(Tree.right);

        // check if children nodes are equal
        // if not return value just for hits node
        if (left != right)        
            return 1;

        // sum all children values and this node
        int currSum = left + right + 1;

        // check new score
        MaxScore = Math.Max(MaxScore, currSum);

        return currSum;
    }

    // Initialize Code 
    public static void Main(string[] args)
    {
   
        Tree tree = new Tree(1);
        tree.left = new Tree(2);
        tree.right = new Tree(3);
        tree.left.right = new Tree(4);
        tree.right.left = new Tree(5);
        tree.right.right = new Tree(6);
        tree.right.left.left = new Tree(7);
        tree.right.left.right = new Tree(8);
        tree.right.right.left = new Tree(9);
        tree.right.right.right = new Tree(10);
        tree.right.right.right.left = new Tree(11);

        if (tree == null)
           Console.WriteLine(0);

        Console.WriteLine(FindMaxScore(tree));
        Console.ReadLine();
    }
}