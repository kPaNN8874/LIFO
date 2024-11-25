using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LIFO
{
    internal class UMatrix : AbsMatrix,IMatrixOperations
    {
        
        public void Add(AbsMatrix addMatrix)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++) 
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++) 
                {
                    this[rowIndex, columnIndex] += addMatrix[rowIndex, columnIndex];               
                }
            }
        }

        public bool Equals(AbsMatrix other)
        {
            bool isEqual = true;
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++) 
                {
                    if (this[rowIndex,columnIndex] != other[rowIndex, columnIndex])
                    {
                        return false;
                    }
                }

            }
            return isEqual;
        }

        public void Fill(double value)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value;
                }
            }
        }

        public void FillRandomFloat(double start, double end)
        {
            Random rnd = new();
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = (float)(rnd.NextDouble()*(end-start)+start);
                }
            }
        }

        public void FillRandomInt(int start, int end)
        {
            Random rnd = new();
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            { 
                for(int columnIndex = 0;columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = rnd.Next(start,end);
                }
            }
        }

        public void RotateToDown()
        {
            throw new NotImplementedException();
        }

        public void RotateToLeft()
        {
            for (int rowIndex=0;rowIndex < RowCount;rowIndex++ )
            {
                double temp = this[rowIndex, 0];
                for (int columnIndex=1; columnIndex<ColumnCount;columnIndex++)
                {
                    this[rowIndex, columnIndex - 1] = this[rowIndex, columnIndex];
                }
                this[rowIndex,ColumnCount-1] = temp;
            }
        }

        public void RotateToTop()
        {
            throw new NotImplementedException();
        }

        public void RotatetToRight()
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                double temp = this[rowIndex, 0];
                for (int columnIndex = -1; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex +1] = this[rowIndex, columnIndex];
                }
                this[rowIndex, ColumnCount + 1] = temp;
            }
        }

        public void Sub(AbsMatrix subMatrix)
        {
            throw new NotImplementedException();
        }
    }
}
        