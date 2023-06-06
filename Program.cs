void MakeArray(int[,] matrix){
    for(int i=0; i<matrix.GetLength(0); i++){
        for(int j=0; j<matrix.GetLength(1); j++){
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void SortLine(int[,] matrix){
    for(int i=0; i<matrix.GetLength(0); i++){
        for(int c=0; c<matrix.GetLength(1); c++){
            for(int j=0; j<matrix.GetLength(1)-1; j++){
                if(matrix[i, j]>matrix[i, j+1]){
                    int temp=matrix[i, j];
                    matrix[i, j]=matrix[i, j+1];
                    matrix[i, j+1]=temp;
                }
            }
        }
    }
}
void PrintArray(int[,] matrix){
    for (int i = 0; i < matrix.GetLength(0); i++){
        for (int j = 0; j < matrix.GetLength(1); j++){
            Console.Write($"{matrix[i, j]}"+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] array = new int[4, 4];
MakeArray(array);
PrintArray(array);
SortLine(array);
PrintArray(array);
//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
void MinSumLine(int[,] matrix){
    int minn=1000;
    for (int i = 0; i < matrix.GetLength(0); i++){
        int summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++){
            summ+=matrix[i,j];
        }
        if(minn>summ) minn=summ;
    }
    Console.Write($"Минимальная сумма среди строк: {minn}");
    Console.WriteLine();
}
int[,] array1 = new int[7, 3];
MakeArray(array1);
PrintArray(array1);
MinSumLine(array1);
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void MultipMatrix(int[,] array, int[,] array1){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            int k=array[i, j]*array1[i,j];
            Console.Write($"{k}"+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
MakeArray(matrix1);
MakeArray(matrix2);
PrintArray(matrix1);
PrintArray(matrix2);
MultipMatrix(matrix1, matrix2);
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void Make3DArray(int[,,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            for(int k = 0; k < arr.GetLength(2); k++){
                arr[i,j,k] = new Random().Next(1, 10);
            }
        }
    }
}
void Print3DArrayIdx(int[,,] arr){
    for(int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            for(int k = 0; k < arr.GetLength(2); k++){
                Console.Write($"{arr[i,j,k]}{(i,j,k)}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] array3D = new int[2,2,2];
Make3DArray(array3D);
Print3DArrayIdx(array3D);



