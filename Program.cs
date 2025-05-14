CustomStack<int> stack = new CustomStack<int>(10);
stack.Push(87);
stack.Push(123);
stack.Push(2173);
stack.Push(22);
stack.Push(34);
stack.Push(6459);
stack.Push(7012);
stack.Push(53);
stack.Push(234);
stack.Push(4675);
stack.Pop();
stack.Push(91);

while(!stack.IsEmpty())
{
    Console.WriteLine(stack.Pop());
}
