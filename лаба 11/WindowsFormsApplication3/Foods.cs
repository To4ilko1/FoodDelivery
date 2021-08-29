using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication3
{
    class Foods
    {
        List<Food> allFoods;
        public Foods()
        {
            allFoods = new List<Food>();
            allFoods = readFoods();
        }
        public List<Food> readFoods()
        {
            List<Food> spisok = new List<Food>();
            foreach (string line in File.ReadLines(@"Foods.txt", Encoding.UTF8))
            {
                string[] Food = line.Split(new string[] { "-||-" }, StringSplitOptions.None);
                Food temp = new Food(Food);
                spisok.Add(temp);
            }
            return spisok;
        }
        //public void addFood(Food food)
        //{
        //    allFoods.Add(food);
        //}
        //public void delFood(Food p)
        //{
        //    allFoods.Remove(p);
        //}
        public Food findByID(int ID)
        {
            return allFoods.Find(x => x.ID == ID);
        }
        public Food findByName(string str)
        {
            return allFoods.Find(x => x.name == str);
        }
        public List<Food> getFood()
        {
            return allFoods;
        }
        public void saveFoods()
        {
            StreamWriter afile = new StreamWriter("Foods.txt", false, Encoding.UTF8);
            foreach (Food p in allFoods)
            {
                afile.WriteLine("{0}-||-{1}-||-{2}", p.ID, p.price, p.name);
            }
            afile.Close();
        }
        //public void ReplaceFood(Food b)
        //{
        //    int index = allFoods.FindIndex(x => x.ID == b.ID);
        //    allFoods[index] = b;
        //}
        //public Food getPrev(int ID)
        //{
        //    int index = allFoods.FindIndex(x => x.ID == ID);
        //    if (index > 0)
        //    {
        //        return allFoods[index - 1];
        //    }
        //    return allFoods[0];
        //}
        //public Food getNext(int ID)
        //{
        //    int index = allFoods.FindIndex(x => x.ID == ID);
        //    if (index < allFoods.Count - 1)
        //    {
        //        return allFoods[index + 1];
        //    }
        //    return allFoods[index];
        //}
    }
    class Food
    {
        public int ID;
        public int price;
        public string name;
        public string comment_f;
        public int kol;// в класс заказ добавить лист блюда
        public Food(int I)
        {
            this.ID = I;
        }
        public Food(int ID, int price,int kol,string comment_f)
        {
            this.ID = ID;
            this.price = price;
            this.kol = kol;
            this.comment_f = comment_f;
        }
        public Food(string[] Food)
        {
            this.ID = Int32.Parse(Food[0]);
            this.price = Int32.Parse(Food[1]);
            this.name = Food[2];
        }
    }
}
