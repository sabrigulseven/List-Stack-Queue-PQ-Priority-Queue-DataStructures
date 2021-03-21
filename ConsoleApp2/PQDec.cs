using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class PQDec
    {       
        private List<Musteri> queArray;
        public PQDec(int s)
        {
            this.queArray = new List<Musteri>();
        }
        public void insert(Musteri j)
        {
            queArray.Add(j);
        }
        public bool isEmpty()
        {
            if (queArray.Count == 0)
                return true;
            else
                return false;
        }
        public Musteri remove()
        {
            if (isEmpty())
                return null;
            Musteri maxTemp =queArray[0] ;
            foreach (Musteri musteri in queArray)
            {                                 
                if (musteri.UrunSayisi > maxTemp.UrunSayisi)
                {
                    maxTemp = musteri;
                }
            }
            queArray.Remove(maxTemp);
            return maxTemp;
        }
    }
}