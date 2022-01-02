


namespace course_work_first_project
{
    class Player
    {
        protected int damage ;
        protected int health ;
        private int max_damage = 4;
        private int max_health=20;
        private int level_damage = 1;
        private int level_health =1;
        private int max_level_damage = 3;
        private int max_level_health = 3;

        public Inventory inventory;

        public Player()
        {
            inventory = new Inventory();

            inventory.AddItem(new Item("Хитин"  , 1 , 0));
            inventory.AddItem(new Item("Шкура"  , 2 , 0));
            inventory.AddItem(new Item("Клык"   , 3 , 0));
            inventory.AddItem(new Item("Жало"   , 4 , 0));
        }
       

        public void Set_damage(int damage)
        {
            this.damage = damage;
        }
        public int Get_damage()
        {
            return damage;
        }
        public void Set_health(int health)
        {
            this.health = health;
        }
        public int Get_health()
        {
            return health;
        }
        public void Set_max_damage(int max_damage)
        {
            this.max_damage = max_damage;
        }
        public int Get_max_damage()
        {
            return max_damage;
        }
        public void Set_max_health(int max_health)
        {
            this.max_health = max_health;
        }
        public int Get_max_health()
        {
            return max_health;
        }
        public void Set_level_damage(int level_damage)
        {
            this.level_damage = level_damage;
        }
        public int Get_level_damage()
        {
            return level_damage;
        }
        public void Set_level_health(int level_health)
        {
            this.level_health = level_health;
        }
        public int Get_level_health()
        {
            return level_health;
        }
        public int Get_max_level_damage()
        {
            return max_level_damage;
        }
        public int Get_max_level_health()
        {
            return max_level_health;
        }
    }
    
}
    
    
