using Proje2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class QueueX
    {
        private int maxSize;
        private Musteri[] queArray;
        private int front;
        private int rear;
        private int nItems;
        public QueueX(int s)
        {
            this.maxSize = s;
            this.queArray = new Musteri[this.maxSize];
            this.front = 0;
            this.rear = -1;
            this.nItems = 0;
        }

        public void insert(Musteri j)
        {
            if ((this.rear == (this.maxSize - 1)))

            {
                this.rear = -1;
            }

            this.queArray[++rear] = j;
            this.nItems++;
        }
        public Musteri remove()
        {
            Musteri temp = this.queArray[front++];
            if ((this.front == this.maxSize))
            {
                this.front = 0;
            }

            this.nItems--;
            return temp;
        }
        public Musteri peekFront()
        {
            return this.queArray[this.front];
        }

        public bool isEmpty()
        {
            return (this.nItems == 0);
        }

        public bool isFull()
        {
            return (this.nItems == this.maxSize);
        }

        public int size()
        {
            return this.nItems;
        }
    }
}
