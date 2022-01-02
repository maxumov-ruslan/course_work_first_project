

namespace course_work_first_project
{
        class Item 
        {
            private string name;
            private int id;
            private int count;
        
        public Item()
        {

        }
        public Item(string name, int id, int count = 0)
            {
                this.name = name;
                this.id = id;
                this.count = count;
            }


            public void Set_name(string name)
            {
                this.name = name;
            }
            public string Get_name()
            {
                return name;
            }
            public void Set_id(int id)
            {
                this.id = id;
            }
            public int Get_id()
            {
                return id;
            }
            public void Set_count(int count)
            {
                this.count = count;
            }
            public int Get_count()
            {
                return count;
            }

      

    }
}

