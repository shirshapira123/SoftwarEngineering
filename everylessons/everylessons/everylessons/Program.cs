using System;

namespace everylessons
{
    class Program
    {
        // exercise a
        public static void FillQueue(Queue<int>q)
        {
            int number;
            bool isContinue = true;
            Console.WriteLine("Enter a list of integer number. To finish press not integer number");
            while(isContinue)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    q.Insert(number);
                }
                catch
                {
                    isContinue = false;
                }
            }
        }
        public static Queue<string> XXX(Node<string> clientList, Node<int> priorities)
        {
            Node<string> cl_pos = clientList;
            Node<int> ps_pos = priorities;
            Queue<string> q = null;
            for (int i = 1; i <= 5; i++)
            {
                while (ps_pos != null) 
                {
                    if (ps_pos.GetInfo() == i) 
                    {
                        q.Insert(cl_pos.GetInfo());
                    }
                    ps_pos = ps_pos.GetNext();
                    cl_pos = cl_pos.GetNext();
                }
                ps_pos = priorities;
                cl_pos = clientList;
            }
            return q;           
        }
        // exercise b
        public static Queue<int> Clone(Queue<int> queue)
        {
            Queue<int> clone = new Queue<int>();
            Queue<int> pos = queue;
            while (!pos.IsEmpty())
            {
                clone.Insert(pos.Remove());
            }
            return clone;
        }

        // exercise c
        public static void OutputQueue(Queue<int> q)
        {
            Queue<int> pos = q;
            while (!pos.IsEmpty())
            {
                Console.WriteLine(pos.Remove()+", ");
            }
        }

        // exercise d
        public static bool SearchInQueue(Queue<int> q, int num)
        {
            Queue<int> pos = q;
            bool isExist = false;
            while (!pos.IsEmpty())
            {
                if(pos.Remove() == num)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        // exercise e
        public static int SumQueue(Queue<int> q)
        {
            int sum = 0;
            Queue<int> pos = q;
            while (!pos.IsEmpty())
            {
                sum += pos.Remove();
            }
            return sum;
        }

        // exercise f
        public static void SearchAndDelete(Queue<int> q, int num)
        {
            if (!SearchInQueue(q, num))
            {
                Console.WriteLine($"there is no {num} in this queue.");
            }
            else
            {
                Queue<int> pos = q;
                Queue<int> q1 = new Queue<int>();
                while (!pos.IsEmpty())
                {
                    if (pos.Remove() != num)
                    {
                        q1.Insert(num);
                    }
                }
                q = q1;
            }
        }

        // exercise g
        public static int FindMax(Queue<int> q)
        {
            Queue<int> pos = q;
            int max = 0;
            while (!pos.IsEmpty())
            {
                max = Math.Max(max, pos.Remove());
            }
            return max;
        }

        // exercise h
        public static int CountMax(Queue<int> q)
        {
            Queue<int> pos = q;
            int counter = 0;
            while (!pos.IsEmpty())
            {
                if(pos.Remove() == FindMax(q))
                {
                    counter++;
                }
            }
            return counter;
        }

        //exercise i
        public static void MultyN(Queue<int> q, int k)
        {
            Queue<int> pos = q;
            Queue<int> q1 = new Queue<int>();
            while (!pos.IsEmpty())
            {
                q1.Insert(pos.Remove() * k);
            }
            q = q1;
        }

        //exercise j
        public static bool IsSeries(Queue<int> q)
        {
            int prev = q.Head();
            int next;
            Queue<int> pos = q; 
            int distance = pos.Remove()- prev;
            while (!pos.IsEmpty())
            {
                next = pos.Remove();
                if (next - prev != distance)
                {
                    return false;
                }
                prev = next;
            }
            return true;
        }

        //exercise k
        public static bool IsSorted(Queue<int> q)
        {
            int prev = q.Head();
            int next;
            Queue<int> pos = q;
            while (!pos.IsEmpty())
            {
                next = pos.Remove();
                if (next - prev < 0)
                {
                    return false;
                }
                prev = next;
            }
            return true;
        }

        //exercise l
        public static Queue<int> Select(Node<int> list, int limit)
        {
            Node<int> pos = list;
            Queue<int> queue = new Queue<int>();
            while (pos != null)
            {
                if(pos.GetInfo() < limit)
                {
                    queue.Insert(pos.GetInfo());
                }
                pos = pos.GetNext();
            }
            return queue;
        }

        //exercise m
        public static Queue<int> FromArrayToQueue(int[] arr)
        {
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                queue.Insert(arr[i]);
            }
            return queue;
        }

        //exercise n
        public static bool EqualsQueues(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> pos1 = q1;
            Queue<int> pos2 = q2;
            while (!pos1.IsEmpty() && !pos2.IsEmpty())
            {
                if (pos1.Remove() != pos2.Remove())
                {
                    return false;
                }
            }
            if (pos1.IsEmpty() && pos2.IsEmpty())
            {
                return false;
            }
            return true;
        }

        //exercise o
        public static Queue<int> CutQueues(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> pos1 = q1;
            Queue<int> pos2 = q2;
            Queue<int> queue = new Queue<int>();
            while (!pos1.IsEmpty())
            {
                int num1 = pos1.Remove();
                while (!pos2.IsEmpty())
                {
                    int num2 = pos2.Remove();
                    if(num1 == num2)
                    {
                        if (!SearchInQueue(queue, num2))
                        {
                            queue.Insert(num2);
                        }
                    }
                }
                pos2 = q2;
            }
            return queue;
        }

        //f**k main!!
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}


//זכויות יוצרים למגניבים המדליקים