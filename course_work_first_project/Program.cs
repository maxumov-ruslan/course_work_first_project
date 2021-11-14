using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Map map = new Map();
            map.Create_Map();


        start:
            Console.Clear();
            Console.WriteLine("1 : Идти в бой");
            Console.WriteLine("2 : Инвентарь");
            Console.WriteLine("3 : Карта");
            Console.WriteLine("4 : Кузница");
            Console.WriteLine("5 : Выход");
          
            ConsoleKey key = GetButton();

            Console.Clear();
            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        Location location = new Location();
                        location.GetLocation(map.Get_current_location());
                        
                        Console.WriteLine("Нажмите enter для продолжения");
                        Console.ReadLine();
                        goto start;
                    }
                case ConsoleKey.D2:
                    {
                        
                        Fight.gg.inventory.GetAllItems();

                        Console.WriteLine("Нажмите enter для продолжения");
                        Console.ReadLine();
                        goto start;
                    }

                case ConsoleKey.D3:
                    {
                        //map.Create_Map();
                        map.Start_Location();

                        ConsoleKeyInfo keyInfo = Console.ReadKey();
                        map.Select_Location(keyInfo);
      
                        Console.WriteLine("Нажмите enter для продолжения");
                        Console.ReadLine();
                        goto start;

                    }
                
                case ConsoleKey.D4:
                    {
                        Blacksmith_shop blacksmith_Shop = new Blacksmith_shop();
                        blacksmith_Shop.Menu();
                        //Console.WriteLine("Нажмите enter для продолжения");
                        //Console.ReadLine();
                        goto start;
                    }
                    
                case ConsoleKey.D5:
                    {

                        Environment.Exit(0);
                    }
                    break;


                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }
        }
        public static ConsoleKey GetButton()
        {
            var button = Console.ReadKey(true).Key;
            return button;
        }
        
        

    }
        

}


