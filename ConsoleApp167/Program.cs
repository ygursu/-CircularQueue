using System;

struct CircularQueue
{
    private int[] items;

    private int FRONT;
    private int REAR;

    private int MAX;
    private int COUNT;

    public CircularQueue(int size)
    {
        items = new int[size];
        FRONT = 0;
        REAR = -1;
        MAX = size;
        COUNT = 0;
    }

    public void InsertItem(int item)
    {
        if (COUNT == MAX)
        {
            Console.WriteLine("Queue Overflow");
            return;
        }
        else
        {
            REAR = (REAR + 1) % MAX;
            items[REAR] = item;

            COUNT++;
        }
    }

    public void DeleteItem()
    {
        if (COUNT == 0)
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            Console.WriteLine("deleted element is: " + items[FRONT]);

            FRONT = (FRONT + 1) % MAX;

            COUNT--;
        }
    }

    public void PrintCircularQueue()
    {
        int i = 0;
        int j = 0;

        if (COUNT == 0)
        {
            Console.WriteLine("Queue is Empty");
            return;
        }
        else
        {
            for (i = FRONT; j < COUNT;)
            {
                Console.WriteLine("\tItem[" + (i + 1) + "]: " + items[i]);

                i = (i + 1) % MAX;
                j++;

            }
        }
    }
}

class Demo
{
    static void Main()
    {
        CircularQueue Q = new CircularQueue(5);

        Q.InsertItem(101);
        Q.InsertItem(202);
        Q.InsertItem(302);
        Q.InsertItem(406);
        Q.InsertItem(534);

        Console.WriteLine("Circular Queue Items are : ");
        Q.PrintCircularQueue();

        Q.DeleteItem();
        Q.DeleteItem();

        Q.InsertItem(786);

        Console.WriteLine("Circular Queue Items are : ");
        Q.PrintCircularQueue();
    }
}