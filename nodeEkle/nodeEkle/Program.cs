using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodeEkle
{
    internal class Program
    {
        class tree
        {
            public int value;
            public tree right;
            public tree left;
        }
        static tree nodeEkle(tree node, int value)
        {
            tree tmp = new tree();
            tmp.value = value;

            if (node == null)
            {
                node = tmp;
                return node;
            }

            if (node.value < value)
            {
                if (node.right == null)
                    node.right = tmp;
                else
                    nodeEkle(node.right, value);
            }

            if (node.value > value)
            {
                if (node.left == null)
                    node.left = tmp;
                else
                    nodeEkle(node.left, value);
            }

            return node;
        }
        static void Main(string[] args)
        {
            tree node = null; // ağacımızı tanımladık

            // binary ağaç olarak eklemeler
            node = nodeEkle(node, 9);
            node = nodeEkle(node, 7);
            node = nodeEkle(node, 8);
            node = nodeEkle(node, 6);
            node = nodeEkle(node, 12);
            node = nodeEkle(node, 15);
            node = nodeEkle(node, 11);

        }
    }
}
