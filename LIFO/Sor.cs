using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{
    class Sor
    {
        //Elemek tárolása: Arraybe
        private double[] array;
        private int queuePointer = 0;

        //Sor(){} - defaault ertek -> 50 a merete
        //Sor(size) - Verem size db elem tároláára jön létre

        public Sor()
        {
            queuePointer = 0;
            array = new double[50];
        }
        public Sor(int size)
        {
            queuePointer = 0;
            array = new double[size];
        }
        //Push(elem)
        public void Push(double element)
        {
            if (array.Length > queuePointer)
            {
                array[queuePointer++] = element;
            }
           
        }
        //Pop()
        public double Pop()
        {

            if (queuePointer == 0)
            {
                throw new Exception("Empty queue error!");
            }
            return array[queuePointer--];
        }
        //Celar() - kiurites

        public void Clear()
        {
            queuePointer = 0;
        }
        //GetSize()-merete a veremnek
        public int GetSize => array.Length;
        //GetLength() - veremben levo elemek szama
        public int GetLength => queuePointer;



        //Extra:
        //Reverse() -elemek sorrendjének megforditasa
        //Sort() - Elemenk rendezese novekvo sorrenben 
    }
}
