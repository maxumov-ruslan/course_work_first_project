

namespace course_work_first_project
{
    class Game
    {
        public void GetLocation(int number)
        {
            switch (number)
            {
                case 1:

                        Beach beach = new Beach();
                        beach.Beach_game();

                        break;
            
                case 2:
                 
                        Forest forest = new Forest();
                        forest.Forest_game();

                        break;
                
                case 3:
                   
                        Mountains mountains = new Mountains();
                        mountains.Mountains_game();

                        break;
                    
                case 4:
                        Mine mine = new Mine();
                        mine.Mine_game();

                    break;
                case 5:
                        Boss boss = new Boss();
                        boss.Boss_game();

                        break;

                default:
                    
                    break;
            }
        }
    }
}
