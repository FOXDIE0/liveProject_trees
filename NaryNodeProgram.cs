using n_ary_node;


// create all nodes
NaryNode<string> root = new NaryNode<string>("root");
NaryNode<string> A = new NaryNode<string>("A");
NaryNode<string> B = new NaryNode<string>("B");
NaryNode<string> C = new NaryNode<string>("C");
NaryNode<string> D = new NaryNode<string>("D");
NaryNode<string> E = new NaryNode<string>("E");
NaryNode<string> F = new NaryNode<string>("F");
NaryNode<string> G = new NaryNode<string>("G");
NaryNode<string> H = new NaryNode<string>("H");
NaryNode<string> I = new NaryNode<string>("I");

// give each node the appropriate children
root.AddChild(A);
root.AddChild(B);
root.AddChild(C);
A.AddChild(D);
A.AddChild(E);
D.AddChild(G);
C.AddChild(F);
F.AddChild(H);
F.AddChild(I);

// print all nodes with children
Console.WriteLine(root.ToString());
Console.WriteLine(A.ToString());
Console.WriteLine(B.ToString());
Console.WriteLine(C.ToString());
Console.WriteLine(D.ToString());
Console.WriteLine(E.ToString());
Console.WriteLine(F.ToString());
Console.WriteLine(G.ToString());
Console.WriteLine(H.ToString());
Console.WriteLine(I.ToString());

