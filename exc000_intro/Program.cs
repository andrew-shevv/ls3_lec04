// dimensional arrays

// string[,] table = new string[3, 5];

// table[1, 2] = "hi"; 

// for (int x = 0; x < table.GetLength(0); x++){
//     for (int y = 0; y < table.GetLength(1); y++){
//         Console.Write($" -{table[x, y]}- ");
//     }
//     Console.WriteLine();
// }

void FillArray(int[,] array){
    Random rand = new Random();
    for (int x = 0; x < array.GetLength(0); x++){
        for (int y = 0; y < array.GetLength(1); y++){
            array[x, y] = rand.Next(1, 10);
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

int[,] matrix = new int[3, 5];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);