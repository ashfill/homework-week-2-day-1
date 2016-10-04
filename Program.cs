using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_day_one_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Home myhome = new Home(10);
            myhome.Numberofwalls = 10;
            int wallquestion = myhome.Numberofwalls;
            Console.WriteLine("the house has {0} walls", myhome.Numberofwalls);

            Home myhouse = new Home(6);
            myhouse.Numberofrooms = 6;
            int roomquestion = myhouse.Numberofrooms;
            Console.WriteLine("the house has {0} rooms", myhouse.Numberofrooms);

            clothes myclothes = new clothes(12);
            myclothes.Numberofshirts = 12;
            int shirtquestion = myclothes.Numberofshirts;
            Console.WriteLine("I have {0} shirts", myclothes.Numberofshirts);

            clothes mycollection = new clothes(10);
            mycollection.Numberofpants = 10;
            int pantsquestion = mycollection.Numberofpants;
            Console.WriteLine("I have {0} pairs of pants", mycollection.Numberofpants);

            Shoes myshoes = new Shoes(3);
            myshoes.Numberofsneakers = 3;
            int sneakersquestion = myshoes.Numberofsneakers;
            Console.WriteLine("I have {0} pairs of sneakers", myshoes.Numberofsneakers);

            Shoes myfootwear = new Shoes(2);
            myfootwear.Numberofslippers = 1;
            int slippersquestion = myfootwear.Numberofslippers;
            Console.WriteLine("I have {0} pairs of slippers", myfootwear.Numberofslippers);
            Console.ReadLine();

        }
    }
}
