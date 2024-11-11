using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFO
{ //elem - double
    public class Verem
    {
    //Elemek tárolása: Arraybe
        private double[] array;
        private int stackPointer = 0;

    //Verem(){} - defaault ertek -> 50 a merete
    //Verem(size) - Verem size db elem tároláára jön létre

        public Verem() 
        {
            stackPointer = 0;
            array = new double[50];
        }
        public Verem(int size) 
        {
            stackPointer = 0;
            array = new double[size];
        }
    //Push(elem)
        public void Push(double element)
        {
            if (array.Length > stackPointer)
            {
                array[stackPointer++] = element;
            }
            else {
                throw new StackOverflowException("Saját: Stack Overflow");
                  }
        }
    //Pop()
        public void Pop(double element)
        {
              if (stackPointer < 0)
            {
                array[stackPointer--] = element;
            }
              else if (stackPointer == 0)
            {
                throw new Exception("Nincs elem a stackbe");
            }
        }
    //Celar() - kiurites

        public void Clear()
        {
            stackPointer = 0;
        }
    //GetSize()-merete a veremnek
    //GetLength() - veremben levo elemek szama

    //Extra:
    //Reverse() -elemek sorrendjének megforditasa
    //Sort() - Elemenk rendezese novekvo sorrenben


    


    }
}
