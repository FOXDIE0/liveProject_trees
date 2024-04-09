using System;
namespace n_ary_node
{
	internal class NaryNode<T>
	{
		internal T Value { get; set; }
		internal List<NaryNode<T>> Children;

		// constructor
		internal NaryNode(T value)
		{
			Value = value;
			Children = new List<NaryNode<T>>();
		}

		// add a child node
		internal void AddChild(NaryNode<T> newNode)
		{
			Children.Add(newNode);
		}

		// override ToString for viewing nodes
		public override string ToString()
		{
			string val = string.Format("{0}: ", Value);
			if (Children.Count > 0)
			{
				foreach (NaryNode<T> child in Children)
				{
					val += string.Format("{0} ", child.Value);
				}
			}

			return val;
		}
	}
}

