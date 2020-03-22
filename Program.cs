using System;

namespace ConsoleApp3
{
    class Program
    {
        private static string[,] seacomp = new string[12, 12];
        private static string[,] seaman = new string[12, 12];
        private static string[] horis = new string[] { "   ", " a ", " b ", " c ", " d ", " e ", " f ", " g ", " h ", " i ", " j ", "   " };
        private static string[] vert = new string[] { "   ", " 1 ", " 2 ", " 3 ", " 4 ", " 5 ", " 6 ", " 7 ", " 8 ", " 9 ", " 0 ", "   " };

        //Метод прорисовки поля компа
        static void StartDrawFieldComp()
        {
           
            // заголовки стовбців
            for (int j = 0; j < 12; j++)
            {
              seacomp[0, j] = horis[j];
            }
            // номера рядків
            for (int i = 0; i < 12; i++)
            {
              seacomp[i, 0] = vert[i];
            }
            // Формування полів
            //код 249 ∙         код 254 ■       ♦
            for (int i = 1; i < 12; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    seacomp[i, j] = "[∙]";
                }         
            }
            //Прорисовка полів
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    //Console.SetCursorPosition(i, j);
                    Console.Write(seacomp[i, j]);
                }
                Console.WriteLine();
            }
        }
        //Метод прорисовки поля гравця
        static void StartDrawFieldMan(ref bool flag, int x1, int y1, int x2, int y2)
        {
            // заголовки стовбців
            for (int j = 0; j < 12; j++)
            {
                seaman[0, j] = horis[j];
            }
            // номера рядків
            for (int i = 0; i < 12; i++)
            {
                seaman[i, 0] = vert[i];
            }
            // Формування полів
            //код 249 ∙         код 254 ■       ♦
            for (int i = 1; i < 12; i++)
            {
                for (int j = 1; j < 12; j++)
                {
                    seaman[i, j] = "[∙]";
                }
            }
            if (flag == true)
            {
                if (y1 == y2)
                {
                    for (int x = x1; x < x2+1; x++)
                    {
                        seaman[y1, x] = "[■]";
                    }
                }
                if (x1 == x2)
                {
                    for (int y = y1; y < y2 + 1; y++)
                    {
                        seaman[y, x1] = "[■]";
                    }
                }
            }
            //Прорисовка полів
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {                    
                    Console.Write(seaman[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {            
            bool flag = false;
            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            Console.WriteLine("__________Флот комп'ютера________");
            Console.WriteLine("_________________________________");
            StartDrawFieldComp();

            Console.WriteLine();
            Console.WriteLine("______________Ваш флот___________");
            Console.WriteLine("_________________________________");
            StartDrawFieldMan(ref flag, x1, y1, x2, y2);
//**************************************************************************************
            Console.SetCursorPosition(40, 1);
            Console.Write("Ставимо 4-х клiтинний кораблик");
            Console.SetCursorPosition(40, 2);
            Console.Write("Вкажiть координати першої клiтинки (наприклад, g4):");
            string  coord = Console.ReadLine();
            char ch1begin = coord[0];
            char ch2begin = coord[1];
            
            switch (ch1begin)
            {
                case 'a':
                    x1 = 1;
                    break;
                case 'b':
                    x1 = 2;
                    break;
                case 'c':
                    x1 = 3;
                    break;
                case 'd':
                    x1 = 4;
                    break;
                case 'e':
                    x1 = 5;
                    break;
                case 'f':
                    x1 = 6;
                    break;
                case 'g':
                    x1 = 7;
                    break;
                case 'h':
                    x1 = 8;
                    break;
                case 'i':
                    x1 = 9;
                    break;
                case 'j':
                    x1 = 10;
                    break;
            }
            y1 = Convert.ToInt32(ch2begin)-48;
  //*****************************************************************************
            Console.SetCursorPosition(40, 4);
            Console.Write("Вкажiть координати останньої клiтинки:");
            coord = Console.ReadLine();
            Console.SetCursorPosition(40, 5);
            char ch1end = coord[0];
            char ch2end = coord[1];

              switch (ch1end)
              {
                  case 'a':
                      x2 = 1;
                      break;
                  case 'b':
                      x2 = 2;
                      break;
                  case 'c':
                      x2 = 3;
                      break;
                  case 'd':
                      x2 = 4;
                      break;
                  case 'e':
                      x2 = 5;
                      break;
                  case 'f':
                      x2 = 6;
                      break;
                  case 'g':
                      x2 = 7;
                      break;
                  case 'h':
                      x2 = 8;
                      break;
                  case 'i':
                      x2 = 9;
                      break;
                  case 'j':
                      x2 = 10;
                      break;
              }
              y2 = Convert.ToInt32(ch2end)-48; 

            
            flag = true;
            Console.Clear();

            Console.WriteLine("__________Флот комп'ютера________");
            Console.WriteLine("_________________________________");
            StartDrawFieldComp();

            Console.WriteLine();
            Console.WriteLine("______________Ваш флот___________");
            Console.WriteLine("_________________________________");
            StartDrawFieldMan(ref flag, x1, y1, x2, y2);

            Console.ReadKey();        

            Console.WriteLine("Game ower");
        }
    }
}
