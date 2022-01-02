using System;


namespace course_work_first_project
{
    class Blacksmith_shop
    {
        public void Menu()
        {
        Select:
            Console.Clear();
            Console.WriteLine("1 : Улучшить урон");
            Console.WriteLine("2 : Улучшить броню");
            Console.WriteLine("3 : Выйти из кузницы");
            ConsoleKey key = GetButton();

            Console.Clear();
            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        if (Fight.gg.Get_level_damage()<Fight.gg.Get_max_level_damage())
                        {
                            Fight.gg.inventory.Delete_Item_for_damage(2, 5);
                            Fight.gg.Set_level_damage(Fight.gg.Get_level_damage() + 1);
                            
                        }
                        else
                        {
                            Console.WriteLine("У вас максимальный уровень");
                            
                        }
                        Console.WriteLine("Нажмите кнопку для продолжения");
                        Console.ReadLine();
                        goto Select;
                    }
                case ConsoleKey.D2:
                    {
                        if (Fight.gg.Get_level_health() < Fight.gg.Get_max_level_health())
                        {
                            Fight.gg.inventory.Delete_Item_for_health(2, 5);
                            Fight.gg.Set_level_health(Fight.gg.Get_level_health() + 1);
                            
                        }
                        else
                        {
                            Console.WriteLine("У вас максимальный уровень");

                        }
                       

                        Console.WriteLine("Нажмите кнопку для продолжения");
                        Console.ReadLine();
                        goto Select;
                    }
                case ConsoleKey.D3:
                    {

                        break;
                    }



                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }
        }
    

       
        
        private ConsoleKey GetButton()
        {
            var button = Console.ReadKey(true).Key;
            return button;
        }

    }
}
