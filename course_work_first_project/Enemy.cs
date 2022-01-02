

namespace course_work_first_project
{
     class Enemy:Player
    {
        private string name;
        private string name_of_resource;

        public Enemy(string name, string name_of_resource, int damage, int health)
        {
            this.name = name;
            this.name_of_resource = name_of_resource;
            this.damage = damage;
            this.health = health;   
        }
        public void Set_name(string name)
        {
            this.name = name;
        }
        public string Get_name()
        {
            return name;
        }
        public void Set_name_of_resource(string name_of_resource)
        {
            this.name_of_resource = name_of_resource;
        }
        public string Get_name_of_resource()
        {
            return name_of_resource;
        }
        

    }

}
