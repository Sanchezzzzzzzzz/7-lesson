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
        if(minn>summ) summ=minn;
    }
    Console.Write($"Минимальная сумма среди строк: {minn}");
    Console.WriteLine();
}
int[,] array1 = new int[7, 3];
MakeArray(array1);
PrintArray(array1);
MinSumLine(array1);

