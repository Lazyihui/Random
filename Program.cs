using System;
using Raylib_cs;
public class RandomArray {
    public static void Main() {
        Raylib.InitWindow(600, 400, "Random Array");

        while(!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);


            Raylib.EndDrawing();
        }
    }

    public void R() {
        int[] array = new int[100];
        for (int i = 0; i < 100; i++) {
            array[i] = 0;
        }

        Random rand = new Random();
        Random rand4 = new Random();

        int randnum1 = rand.Next(0, 100);
        // Console.WriteLine("Random Array: " + randnum1);


        for (int i = 0; i < 30; i++) {
            Rand4(array, ref randnum1, 10);
        }

        // int next = rand4.Next(1, 5);

        // if (next == 1) {
        //     if (randnum1 + 1 < 0 && randnum1 + 1 > 100) {
        //         return;
        //     }
        //     array[randnum1 + 1] = 1;
        // } else if (next == 2) {
        //     if (randnum1 - 1 < 0 && randnum1 - 1 > 100) {
        //         return;
        //     }
        //     array[randnum1 - 1] = 2;
        // } else if (next == 3) {
        //     if (randnum1 + 10 < 0 && randnum1 + 10 > 100) {
        //         return;
        //     }
        //     array[randnum1 + 10] = 3;
        // } else if (next == 4) {
        //     if (randnum1 - 10 < 0 && randnum1 - 10 > 100) {
        //         return;
        //     }
        //     array[randnum1 - 10] = 4;
        // } else if (next == 5) {
        //     Console.Write("错误");
        // }


        // Console.WriteLine("Random Array: " + next);

        // Console.WriteLine("Random Array: " + array[randnum1]);
        Console.WriteLine();


        for (int i = 1; i <= 100; i++) {
            int tem = array[i - 1];
            Console.Write(tem);
            if (i % 10 == 0) {
                Console.WriteLine();
            } else {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }

    public static void Rand4(int[] array, ref int rand, int row) {
        array[rand] = 1;

        Random tem = new Random();
        int next = tem.Next(1, 5);
        if (next == 1) {
            if (rand + 1 >= 0 && rand + 1 < 100) {
                rand = rand + 1;
                Console.WriteLine("Random Array:1= " + rand);
                array[rand] = 1;
            }


        } else if (next == 2) {
            if (rand - 1 >= 0 && rand - 1 < 100) {
                rand = rand - 1;
                Console.WriteLine("Random Array:2= " + rand);
                array[rand] = 2;
            }


        } else if (next == 3) {

            if (rand + row >= 0 && rand + row < 100) {
                rand = rand + row;
                Console.WriteLine("Random Array:3= " + rand);
                array[rand] = 3;
                return;
            }


        } else if (next == 4) {
            if (rand - row >= 0 && rand - row < 100) {
                rand = rand - row;
                Console.WriteLine("Random Array:4=" + rand);
                array[rand] = 4;
            }


        } else {
            Console.Write("错误");
        }
    }


}
