using System.Text;

namespace Task1
{
    internal class Program
    {

        public class queue<T>
        {
            int _size;
            int head;
            int tail;
            int elements_counter;
            T[] data;

            public queue(){
                _size = 1000;
                data = new T[_size];
            }
            public queue(int size)
            {
                _size = size;
                data = new T[size];
            }
            public bool isFull()
            {
                return (elements_counter == _size);
            }
            public bool isEmpty()
            {
                return (elements_counter == 0);
            }
            public void enqueue(T number)
            {
                if (!isFull())
                {
                    data[tail++] = number;
                    if (tail == _size) tail = 0;
                    elements_counter++;
                }
                else
                    throw new Exception("Queue is full");
            }
            public T dequeue()
            {
                if (!isEmpty())
                {
                    T result = data[head];
                    head++;
                    if (head == _size)
                    {
                        head = 0;
                    }
                    elements_counter--;
                    return result;
                }
                else
                {
                    throw new Exception("Queue is empty");
                }
            }

            public override string ToString()
            {
                StringBuilder datastr = new StringBuilder();
                for(int i= head; i < tail; i++)
                {
                    datastr.Append(data[i]);
                    datastr.Append(',');
                }
                return datastr.ToString();
            }
        }




        static void Main(string[] args)
        {
            queue<string> q = new queue<string>(120);
            q.enqueue("1");
            q.enqueue("2");
            q.enqueue("3");
            q.enqueue("Ahmed");
            Console.WriteLine(q.dequeue());
            Console.WriteLine(q);
        }
    }
}
