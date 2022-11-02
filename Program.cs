using BinarySearchTreeUc3;
//Main method
BinarySearchTree<int> b = new BinarySearchTree<int>(56);
b.Insert(30);
b.Insert(70);
b.Insert(22);
b.Insert(40);
b.Insert(60);
b.Insert(95);
b.Insert(11);
b.Insert(65);
b.Insert(3);
b.Insert(16);
b.Insert(63);
b.Insert(67);
b.Display();
b.GetSize();
bool result = b.IfExits(63, b);
Console.WriteLine(result);

