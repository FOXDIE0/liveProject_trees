using System;
namespace binary_node1
{
	internal class BinaryNode<T>
	{
		internal T Value { get; set;}
		internal BinaryNode<T> LeftChild, RightChild;

		// constructor
		internal BinaryNode(T value) 
		{
			Value = value;
			LeftChild = null;
            		RightChild = null;
		}

       		// node adding functions
		internal void  AddLeft(BinaryNode<T> child)
		{
			LeftChild = child;
		}

        	internal void AddRight(BinaryNode<T> child)
        	{
            	RightChild = child;
        	}

		// override ToString
        	public override string ToString() {
			string val = string.Format("{0}", Value);
			string left, right;

			if (LeftChild == null)
			{
				left = "null";
			}
			else
			{
				left = string.Format("{0}", LeftChild.Value);
            		}

			if (RightChild == null)
			{
				right = "null";
			}
			else
			{
				right = string.Format("{0}", RightChild.Value);
			}

			return $"{Value}: {left}, {right}";

		}
    }
}

