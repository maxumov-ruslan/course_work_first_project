using System;


namespace course_work_first_project
{
    class Fight
    {
       
        public static Player gg = new Player();
        private bool win_or_lose;
        public void Set_win_or_lose(bool win_or_lose)
        {
            this.win_or_lose = win_or_lose;
        }
        public bool Get_win_or_lose()
        {
            return win_or_lose;
        }
        public  void Fight_Enemy(Enemy enemy_in_game)
        {
            Console.WriteLine($" На вас напал {enemy_in_game.Get_name()} с уроном {enemy_in_game.Get_damage()} и здоровьем {enemy_in_game.Get_health()}");
            Console.WriteLine("Нажмите enter ,чтобы продолжить");
            Console.ReadLine();
            Console.Clear();
            gg.Set_health(gg.Get_max_health());
            gg.Set_damage(gg.Get_max_damage());

        go:
           

            Console.WriteLine($"{enemy_in_game.Get_name()} \t {enemy_in_game.Get_health()} \t HP Урон врага \t {enemy_in_game.Get_damage()}");
            Console.WriteLine($"Вы {gg.Get_health()}  \t HP Ваш урон \t {gg.Get_damage()}");
         
            Console.WriteLine("1 : ударить");
            Console.WriteLine("2 : убежать");
            var key = Program.GetButton();
            if (key == ConsoleKey.D1)
            {
                enemy_in_game.Set_health(enemy_in_game.Get_health() - gg.Get_damage());
                gg.Set_health(gg.Get_health() - enemy_in_game.Get_damage());
            }
            else if (key == ConsoleKey.D2)
            {

                    Console.WriteLine("Вам удалось убежать");
                gg.Set_health(gg.Get_max_health());
                gg.Set_damage(gg.Get_max_damage());
                goto run;
            }
            else
            {
                Console.WriteLine("Нет такой команды");
                Console.Clear();
                goto go;
            }
            if (gg.Get_health() <= 0)
            {
                goto lose;
            }
            else if (enemy_in_game.Get_health() <= 0)
            {
                goto win;
            }
            else
            {
                Console.Clear();
                goto go;
            }



        win:
            Console.Clear();
            Console.WriteLine("вы выйграли\n");
            Set_win_or_lose(true);
            return ;
        lose:
            Set_win_or_lose(false);
            Console.WriteLine("вы проиграли\n");
            return;
        run:
            Console.Clear();
            Console.WriteLine("вы убежали\n");
            return;
        }
    }
}

