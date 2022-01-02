using System;


namespace course_work_first_project
{
    abstract class World
    {

    }
    class Location:World
    {
        protected Fight fight = new Fight();
       
    }

    class Beach : Location
    {
        public void Beach_game()
        {

            Enemy Grab = new Enemy("Краб", "хитин", 1, 5);
            fight.Fight_Enemy(Grab);

            if (fight.Get_win_or_lose()==true )
            {
                Fight.gg.inventory.AddItem((new Item("хитин", 1,1)));
            }
        }
    }
        
    
    class Forest:Location
    {
        public void Forest_game()
        {

            Fight fight = new Fight();
            Enemy Bear = new Enemy("Медведь", "шкура", 1, 5);
            fight.Fight_Enemy(Bear);

            if (fight.Get_win_or_lose() == true)
            {
                Fight.gg.inventory.AddItem((new Item("шкура", 2, 1)));
            }


        }
    }
    class Mountains: Location
    {
        public void Mountains_game()
        {

            Fight fight = new Fight();
            Enemy Tiger = new Enemy("Горный Тигр", "клык", 1, 5);
            fight.Fight_Enemy(Tiger);

            if (fight.Get_win_or_lose() == true)
            {
                Fight.gg.inventory.AddItem((new Item("клык", 3, 1)));
            }


        }
    }
    class Mine: Location
    {
        public void Mine_game()
        {

            Fight fight = new Fight();
            Enemy Skorpion = new Enemy("Скорпион", "жало", 1, 5);
            fight.Fight_Enemy(Skorpion);

            if (fight.Get_win_or_lose() == true)
            {
                Fight.gg.inventory.AddItem((new Item("жало", 4, 1)));
            }


        }
    }
    class Boss: Location
    {
        public void Boss_game()
        {

            Fight fight = new Fight();
            Enemy Boss = new Enemy("Босс", "факел", 1, 1);
            fight.Fight_Enemy(Boss);
            Console.WriteLine("Вы победили  босса ");
            
        } 
    }

    

    
}
