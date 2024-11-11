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
        public double Pop()
        {

            if (stackPointer == 0)
            {
                throw new Exception("Empty stack error!");
            }
           return  array[stackPointer--];
        }
    //Celar() - kiurites

        public void Clear()
        {
            stackPointer = 0;
        }
        //GetSize()-merete a veremnek
        public int GetSize => array.Length;
        //GetLength() - veremben levo elemek szama
        public int GetLength => stackPointer;
        
            
        
    //Extra:
    //Reverse() -elemek sorrendjének megforditasa
    //Sort() - Elemenk rendezese novekvo sorrenben 
    }
}
