using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace классы
{
    class matrix
    {
        int row;
        int col;
        double[,] array;
        public matrix(double[,] array)
        {
            this.row = array.GetLength(0);
            this.col = array.GetLength(1);
            this.array = array;
        }
        // +
      

        public void plus_other_matrix(double [,] array2)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] += array2[i,j]; 
                }
            }
        }
        // * на число
        public void proizv_on_num(double num)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] *= num;
                }
            }
        }
        // show
        public void show()
        {
            Console.WriteLine("\nShow: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.WriteLine($"{array[i, j]:f2} ");
                }
            }
        }
        // * на матрицу это по желанию, но оно там с памяттью чет проблема вроде как
        //public void proizv_matric(double [,] matrix_)
        //{
        //    double C;
        //    int index_j = 0;
        //    for (int i = 0; i < row; i++)
        //    {
        //        C = 0; // Зануляю
        //        for (int j = 0; j < col; j++)
        //        {
        //            index_j++;
        //            C += (array[i, j] * matrix_[i, j]);
        //        }
        //        array[i, index_j] = C;
        //    }
        //}
    }
}
