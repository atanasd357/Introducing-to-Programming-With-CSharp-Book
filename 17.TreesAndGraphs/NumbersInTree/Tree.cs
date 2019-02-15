using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInTree
{
    public class Tree<T>
    {
        private TreeNode<T> root;
        private int countEncounters = 0;
        private int countLeafs = 0;
        private int countInnerPeaks = 0;

        public Tree(T value)
        {
            this.root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children) 
            {
                this.root.AddChild(child.root);
            }
        }

        public int FindEncounters(T value)
        {
            FindNumberOfEncounters(this.root, value, this.countEncounters);
            int numberOfEncounters = countEncounters;
            countEncounters = 0;

            return numberOfEncounters;
        }

        private void FindNumberOfEncounters(TreeNode<T> root, T value, int countEncounters)
        {
            
            if (this.root.Value.Equals(value))
            {
                this.countEncounters++;
            }

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                if (child.Value.Equals(value))
                {
                    this.countEncounters++;
                }

                FindNumberOfEncounters(child, value, this.countEncounters);
            }
        }

        public void FindRootsWithNumberOfPeaks(int numberOfPeaksForSearch)
        {
            PrintRootsWithGivenNumber(this.root, numberOfPeaksForSearch);         
        }

        private void PrintRootsWithGivenNumber(TreeNode<T> root, int numberOfPeaksForSearch)
        {
            if (root.ChildrenCount == numberOfPeaksForSearch)
            {
                Console.WriteLine("{0}", root.Value);
            }

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintRootsWithGivenNumber(child, numberOfPeaksForSearch);
            }
        }

        public void FindNumberOfLeafAndInnerPeaks()
        {
            PrintNumberOfLeafAndInnerPeaks(this.root, this.countLeafs, this.countInnerPeaks);
            Console.WriteLine("The number of leafs is: {0}", this.countLeafs);
            Console.WriteLine("The number of inner peaks is: {0}", this.countInnerPeaks);
            this.countLeafs = 0;
            this.countInnerPeaks = 0;
        }

        private void PrintNumberOfLeafAndInnerPeaks(TreeNode<T> root, int countLeafs, int countInnerPeaks)
        
        {
            if (root.ChildrenCount == 0)
            {
                this.countLeafs++;
            }
            else if (root.ChildrenCount > 0 && root.HasParent == true)
            {
                this.countInnerPeaks++;
            }

            TreeNode<T> child = null;

            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintNumberOfLeafAndInnerPeaks(child, this.countLeafs, this.countInnerPeaks);
            }
        }
    }
}
