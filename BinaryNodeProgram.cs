using binary_node1;

// create nodes
BinaryNode<string> rootNode = new BinaryNode<string> ("test");
BinaryNode<string> nodeA = new BinaryNode<string>("A");
BinaryNode<string> nodeB = new BinaryNode<string>("B");
BinaryNode<string> nodeC = new BinaryNode<string>("C");
BinaryNode<string> nodeD = new BinaryNode<string>("D");
BinaryNode<string> nodeE = new BinaryNode<string>("E");
BinaryNode<string> nodeF = new BinaryNode<string>("F");

// add children to nodes
rootNode.AddLeft(nodeA);
rootNode.AddRight(nodeB);
nodeA.AddLeft(nodeC);
nodeA.AddRight(nodeD);
nodeB.AddRight(nodeE);
nodeE.AddLeft(nodeF);

// print nodes
Console.WriteLine(rootNode.ToString());
Console.WriteLine(nodeA.ToString());
Console.WriteLine(nodeB.ToString());
Console.WriteLine(nodeC.ToString());
Console.WriteLine(nodeD.ToString());
Console.WriteLine(nodeE.ToString());
Console.WriteLine(nodeF.ToString());





