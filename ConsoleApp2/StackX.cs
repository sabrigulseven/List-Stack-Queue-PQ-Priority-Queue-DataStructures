using Proje2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class StackX
    {
        private int maxSize;
        private Musteri[] stackArray;
        private int top;
        public StackX(int s)
        {
            this.maxSize = s;
            this.stackArray = new Musteri[this.maxSize];
            this.top = -1;
        }

        public void push(Musteri j)
        {
            this.stackArray[++top] = j;
        }

        public Musteri pop()
        {
            return this.stackArray[top--];
        }

        public Musteri peek()
        {
            return this.stackArray[this.top];
        }

        public bool isEmpty()
        {
            return (this.top == -1);
        }

        public bool isFull()
        {
            return (this.top
                        == (this.maxSize - 1));
        }
    }
}
