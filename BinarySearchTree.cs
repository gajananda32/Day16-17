﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeUc3
{

    //creating generic class
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        //parent Tree
        public T NodeData { get; set; }
        //left data
        public BinarySearchTree<T> Left { get; set; }
        //right data
        public BinarySearchTree<T> Right { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.Left = null;
            this.Right = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;
        //method for inserting the data
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.Left == null)
                {
                    this.Left = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.Left.Insert(item);
                }
            }
            else
            {
                if (this.Right == null)
                {
                    this.Right = new BinarySearchTree<T>(item);
                }
                else
                {
                    this.Right.Insert(item);
                }
            }
        }
        //method for displaying the data
        public void Display()
        {
            if (this.Left != null)
            {
                this.leftCount++;
                this.Left.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.Right != null)
            {
                this.rightCount++;
                this.Right.Display();
            }
        }
        //creating method for size 
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
        //method for checking element is present or not
        public bool IfExits(T element,BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("current element is {0} in BinarySearchTree", node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExits(element, node.Left);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                IfExits(element, node.Right);
            }
            return result;
        }
    }
}
