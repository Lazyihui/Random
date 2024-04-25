using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using Raylib_cs;
public class RandomArray {
    public static void Main() {
        Raylib.InitWindow(600, 400, "Random Array");

        Random randomx = new Random();

        Random randomy = new Random();


        int randV2x = (int)randomx.Next(0, 600);

        int randV2y = (int)randomy.Next(0, 400);

        Vector2 vector2 = new Vector2(randV2x, randV2y);
        Vector2 size = new Vector2(10, 10);

        Vector2[] vector2s = new Vector2[1000];

        for (int i = 0; i < 1000; i++) {
            RandVector2(ref vector2, 10);
            vector2s[i] = vector2;
        }


        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            // Vector2 mouse = Raylib.GetMousePosition();
            for (int i = 0; i < 1000; i++) {
                Vector2 vector22 = vector2s[i];
                Raylib.DrawRectangleV(vector22, size, Color.Black);
            }

            // Raylib.DrawText("Press R to generate random array", 200, 180, 20, Color.Red);
            // 位置 长宽 颜色


            Raylib.EndDrawing();
        }
    }

    public static void RandVector2(ref Vector2 vector2, int size) {
        Random random = new Random();
        int next = random.Next(1, 5);

        if (next == 1) {
            if (vector2.X + size >= 0 && vector2.X + size < 600) {
                vector2.X = vector2.X + size;
            }

        } else if (next == 2) {
            if (vector2.X - size >= 0 && vector2.X - size < 600) {
                vector2.X = vector2.X - size;
            }
        } else if (next == 3) {
            if (vector2.Y + size >= 0 && vector2.Y + size < 400) {
                vector2.Y = vector2.Y + size;
            }
        } else if (next == 4) {
            if (vector2.Y - size >= 0 && vector2.Y - size < 400) {
                vector2.Y = vector2.Y - size;
            }
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
