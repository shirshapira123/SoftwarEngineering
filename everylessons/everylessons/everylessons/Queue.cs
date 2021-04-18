using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Queue<T>
    {
        Node<T> start;
        Node<T> last;
        public Queue()
        {
            this.start = null;
            this.last = null;
        }
        public void Insert(T info) // if the queue is empty
        {
            if (this.last == null)
            {
                this.start.SetNext(new Node<T>(info));
                this.last = this.start;
            }
            else
            {
                this.last.SetNext(new Node<T>(info)); //הוספת חוליה בסוף שרשרת
                this.last = this.last.GetNext(); //השמת משתנה לאסט ששוב יצביע לחוליה אחרונה
            }
        }
        public T Remove()
        {
            T x = this.start.GetInfo();
            this.start = this.start.GetNext();
            return x;
        }
        public T Head()
        {
            return this.start.GetInfo();
        }
        public bool IsEmpty()
        {
            return this.start == null;
        }
    }
}
