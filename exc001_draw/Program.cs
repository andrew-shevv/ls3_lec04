// draw :)

void FillArray(int[,] array){
    for (int x = 0; x < array.GetLength(0); x++){
        for (int y = 0; y < array.GetLength(1); y++){
            if (x == 0 || x == array.GetLength(0) - 1 || y == 0 || y == array.GetLength(1) - 1){
                array[x, y] = 1;
            }
            else if (x == array.GetLength(0) / 2 || y == array.GetLength(1) / 2){
                array[x, y] = 1;
            }
        }
    }
}

void PrintArray(int[,] array){
    for (int x = 0; x < array.GetLength(0); x++){
        for (int y = 0; y < array.GetLength(1); y++){
            Console.Write($"{array[x, y]} ");
        }
        Console.WriteLine();
    }
}

int[,] paint = new int[25, 25];

void FillIn(int x, int y){
    if (paint[x, y] == 0){
        paint[x, y] = 1;
        FillIn(x - 1, y);
        FillIn(x, y - 1);
        FillIn(x + 1, y);
        FillIn(x, y + 1);
    }
}


FillArray(paint);
FillIn(1, 1);
PrintArray(paint);