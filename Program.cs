using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace cours
{
    class Shapes
    {
        public int Height;//высота треугольника
        public int Wight;//основание треугольника
        public int a;//сторона квадрата
        public int x;//координата абсцисс для центра
        public int y;//координата ординат для центра
        public int r;//радиус окружности
        public int z;
        public int v;
        public string c;
       
    }

    
    #region DataProvider
    class DataProvider
    {
        StreamReader mReader;
      

        public DataProvider(string file)
        {
            mReader = new StreamReader(@file);
        }

        public int rdInt()
        {
            return Convert.ToInt32(mReader.ReadLine());  
        }

        public double rdDouble()
        {
            return Convert.ToDouble(mReader.ReadLine());
        }

        public string rString()
        {
            return Convert.ToString(mReader.ReadLine());
        }
    }
    #endregion
    class ShapesDemo : Shapes
    {
        static void Main(string[] args)
        {
            try
            {   
                DataProvider filer = new DataProvider(@"E:\data.txt");
                ShapesDemo iData = new ShapesDemo();//экземпляр класса для треугольника
                ShapesDemo i1Data = new ShapesDemo();//экземлпяр класса для квадрата
                ShapesDemo i2Data = new ShapesDemo();//экземлпяр класса для окружности
                iData.Height = filer.rdInt();
                iData.Wight = filer.rdInt();
                i1Data.a = filer.rdInt();
                i2Data.x = filer.rdInt();
                i2Data.y = filer.rdInt();
                i2Data.r = filer.rdInt();
                Console.WriteLine("Высота треугольника: " + iData.Height);
                Console.WriteLine("Основание треугольника: " + iData.Wight);
                Console.WriteLine("Сторона квадрата: " + i1Data.a);
                Console.WriteLine("Координата центра окружности оси X: " + i2Data.x);
                Console.WriteLine("Координата центра окружности оси Y: " + i2Data.y);
                Console.WriteLine("Радиус окружности: " + i2Data.r);
                Console.WriteLine("Считать новую информацию с файла ?");
                string val = Console.ReadLine();
                if ((val == "da")&&(val=="да"))
                {
                    ShapesDemo i3Data = new ShapesDemo();//экземпляр для новой фигуры
                    i3Data.z = filer.rdInt();
                    i3Data.v = filer.rdInt();
                    i3Data.c = filer.rString();
                    Console.WriteLine("Параметр новой фигуры"  + " " + i3Data.z);
                    Console.WriteLine("Параметр новой фигуры" + " " + i3Data.v);
                    Console.WriteLine("Параметр новой фигуры" + " " + i3Data.c);
                }
              
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
