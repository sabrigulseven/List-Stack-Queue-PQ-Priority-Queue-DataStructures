using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje2
{
    class PQInc
    {
        private List<Musteri> queArray;
        public PQInc(int s)
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
            Musteri minTemp = queArray[0];
            foreach (Musteri musteri in queArray)
            {
                if (musteri.UrunSayisi < minTemp.UrunSayisi)
                {
                    minTemp = musteri;
                }
            }
            queArray.Remove(minTemp);
            return minTemp;
        }
    }
}