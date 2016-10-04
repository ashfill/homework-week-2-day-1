using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_day_one_homework
{
    class Shoes
    {
        private int numberofsneakers;
        private int numberofboots;
        private int numberofslippers;
        private int numberofflipflops;
        private int numberofsandals;

        public Shoes(int amountofsneakers)
        {
            numberofsneakers = amountofsneakers;
        }

        public int Numberofsneakers
        {
            get
            {
                return numberofsneakers;
            }

            set
            {
                numberofsneakers = value;
            }
        }

        public int Numberofboots
        {
            get
            {
                return numberofboots;
            }

            set
            {
                numberofboots = value;
            }
        }

        public int Numberofslippers
        {
            get
            {
                return numberofslippers;
            }

            set
            {
                numberofslippers = value;
            }
        }

        public int Numberofflipflops
        {
            get
            {
                return numberofflipflops;
            }

            set
            {
                numberofflipflops = value;
            }
        }

        public int Numberofsandals
        {
            get
            {
                return numberofsandals;
            }

            set
            {
                numberofsandals = value;
            }
        }
    }
}
