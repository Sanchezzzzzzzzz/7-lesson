﻿void MakeArray(int[,] matrix){
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
            Console.Write($"Массив выглядит так: {matrix[i, j]}");
        }
    }
    Console.WriteLine();
}
int[,] array = new int[4, 5];
MakeArray(array);
PrintArray(array);
SortLine(array);
PrintArray(array);