using System;

namespace Lab1322c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[,] art = make_forward(), rev;

            printPixelArt(art);

            rev = make_mirror(art);
            art = make_forward();

            printPixelArt(rev);

            printPixelArt(art, rev);

        }

        public static char[,] make_forward()
        {
            char[,] pixel = new char[4, 13];
            pixel[0, 0] = ' ';
            pixel[0, 1] = ' ';
            pixel[0, 2] = '_';
            pixel[0, 3] = '_';
            pixel[0, 4] = '_';
            pixel[0, 5] = '_';
            pixel[0, 6] = '_';
            pixel[0, 7] = '_';
            pixel[0, 8] = ' ';
            pixel[0, 9] = ' ';
            pixel[0, 10] = ' ';
            pixel[0, 11] = ' ';
            pixel[0, 12] = ' ';
            pixel[1, 0] = ' ';
            pixel[1, 1] = '/';
            pixel[1, 2] = '|';
            pixel[1, 3] = '_';
            pixel[1, 4] = '|';
            pixel[1, 5] = '|';
            pixel[1, 6] = '_';
            pixel[1, 7] = '\\';
            pixel[1, 8] = '\'';
            pixel[1, 9] = '.';
            pixel[1, 10] = '_';
            pixel[1, 11] = '_';
            pixel[1, 12] = ' ';
            pixel[2, 0] = '(';
            pixel[2, 1] = ' ';
            pixel[2, 2] = ' ';
            pixel[2, 3] = ' ';
            pixel[2, 4] = '_';
            pixel[2, 5] = ' ';
            pixel[2, 6] = ' ';
            pixel[2, 7] = ' ';
            pixel[2, 8] = ' ';
            pixel[2, 9] = '_';
            pixel[2, 10] = ' ';
            pixel[2, 11] = '_';
            pixel[2, 12] = '\\';
            pixel[3, 0] = '=';
            pixel[3, 1] = '\'';
            pixel[3, 2] = '-';
            pixel[3, 3] = '(';
            pixel[3, 4] = '_';
            pixel[3, 5] = ')';
            pixel[3, 6] = '-';
            pixel[3, 7] = '-';
            pixel[3, 8] = '(';
            pixel[3, 9] = '_';
            pixel[3, 10] = ')';
            pixel[3, 11] = '-';
            pixel[3, 12] = '\'';
            return pixel;
        }

        public static char[,] make_mirror(char[,] pixelArt)
        {
            char temp = ' ';

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    if (j == 6)
                    {
                        break;
                    }

                    switch(j)
                    {
                        case 0:
                            {
                                temp = specialMirror(pixelArt[i, 12]);
                                pixelArt[i, 12] = specialMirror(pixelArt[i, j]);
                                pixelArt[i, j] = temp;
                                break;
                            }
                        case 1:
                            {
                                temp = specialMirror(pixelArt[i, 11]);
                                pixelArt[i, 11] = specialMirror(pixelArt[i, j]);
                                pixelArt[i, j] = temp;
                                break;
                            }
                        case 2:
                            {
                                temp = specialMirror(pixelArt[i, 10]);
                                pixelArt[i, 10] = specialMirror(pixelArt[i, j]);
                                pixelArt[i, j] = temp;
                                break;
                            }
                        case 3:
                            {
                                temp = specialMirror(pixelArt[i, 9]);
                                pixelArt[i, 9] = specialMirror(pixelArt[i, j]);
                                pixelArt[i, j] = temp;
                                break;
                            }
                        case 4:
                            {
                                temp = specialMirror(pixelArt[i, 8]);
                                pixelArt[i, 8] = specialMirror(pixelArt[i, j]);
                                pixelArt[i, j] = temp;
                                break;
                            }
                        case 5:
                            {
                                temp = specialMirror(pixelArt[i, 7]);
                                pixelArt[i, 7] = specialMirror(pixelArt[i, j]);
                                pixelArt[i, j] = temp;
                                break;
                            }
                        default:
                            break;
                    }
                }
            }

            return pixelArt;
        }

        public static char specialMirror(char currentPixel)
        {
            switch (currentPixel)
            {
                case '(':
                    {
                        currentPixel = ')';
                    break;
                    }
                case ')':
                    {
                        currentPixel = '(';
                        break;
                    }
                case '\\':
                    {
                        currentPixel = '/';
                        break;
                    }
                case '/':
                    {
                        currentPixel = '\\';
                        break;
                    }
                default:
                    break;
            }

            return currentPixel;
        }

        public static void printPixelArt(char[,] pixelArt)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(pixelArt[i, j]);
                }
                Console.Write("\n");
            }
        }

        public static void printPixelArt(char[,] pixelArt, char[,] pixelArtRev)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(pixelArt[i, j]);
                }
                for (int j = 0; j < 13; j++)
                {
                    Console.Write(pixelArtRev[i, j]);
                }
                Console.Write("\n");
            }
        }
    }
}
