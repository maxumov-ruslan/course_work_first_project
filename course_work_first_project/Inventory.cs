using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_first_project
{

    class Inventory
    {
        public List<Item> items = new List<Item>();
        public void AddItem(Item item)
        {
            if (items.Count > 0)
                for (int i = 0; i < items.Count; i++)
                {
                    if (item.Get_id() == items[i].Get_id())
                    {
                        items[i].Set_count(items[i].Get_count() + item.Get_count());
                        break;
                    }
                    else if (i == items.Count - 1)
                    {
                        items.Add(item);
                        break;
                    }
                }
            else
            {
                items.Add(item);
            }
        }
        public void Delete_Item_for_health( int count_resource_for_upgrade,int increase)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Get_id() == 1 && items[i].Get_count() >= count_resource_for_upgrade)
                {
                    items[i].Set_count(items[i].Get_count() - count_resource_for_upgrade);
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (items[j].Get_id() == 2 && items[j].Get_count() >= count_resource_for_upgrade)
                        {
                            items[j].Set_count(items[j].Get_count() - count_resource_for_upgrade);
                            Fight.gg.Set_max_health(Fight.gg.Get_max_health() + increase);
                           
                        }
                       
                    }
                }
            }
           
        }
        public void Delete_Item_for_damage(int count_resource_for_upgrade, int increase)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Get_id() == 3 && items[i].Get_count() >= count_resource_for_upgrade)
                {
                    items[i].Set_count(items[i].Get_count() - count_resource_for_upgrade);
                    for (int j = 0; j < items.Count; j++)
                    {
                        if (items[j].Get_id() == 4 && items[j].Get_count() >= count_resource_for_upgrade)
                        {
                            items[j].Set_count(items[j].Get_count() - count_resource_for_upgrade);
                            Fight.gg.Set_max_damage(Fight.gg.Get_max_damage() + increase);
                            
                        }
                        
                    }
                }
                
            }

        }


        public void GetAllItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i} : {items[i].Get_name()} \t количество : {items[i].Get_count()}");
            }
        }
       




    }
}