using System;

public class CustomStack<T>
{
	private T[] data;
	private int top;
	private int capacity;
	public CustomStack(int capacity)
	{
		top = -1;
		data = new T[capacity];
		this.capacity = capacity;
	}
	public void Push(T val)
	{
		if (top >= capacity - 1) 
		{
            throw new InvalidOperationException("Stack overflow!");
        }
		data[++top] = val;
	}
	public T Pop()
	{
		if (IsEmpty())
		{
            throw new InvalidOperationException("Stack underflow!");
        }
		return data[top--];
	}
	public T Peek()
	{
		if(IsEmpty())
		{
            throw new InvalidOperationException("Stack empty!");
        }
		return data[top];
	}
	public bool IsEmpty()
	{
		return top == -1;
	}
}
