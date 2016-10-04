using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_day_one_homework
{
    public class clothes
    {
        private int numberofshirts;
        private int numberofshorts;
        private int numberofsocks;
        private int numberofpants;
        private int numberofhoodies;

        public clothes(int amountofshirts)
        {
            numberofshirts = amountofshirts;
        }

        public int Numberofshirts
        {
            get
            {
                return numberofshirts;
            }

            set
            {
                numberofshirts = value;
            }
        }

        public int Numberofshorts
        {
            get
            {
                return numberofshorts;
            }

            set
            {
                numberofshorts = value;
            }
        }

        public int Numberofsocks
        {
            get
            {
                return numberofsocks;
            }

            set
            {
                numberofsocks = value;
            }
        }

        public int Numberofpants
        {
            get
            {
                return numberofpants;
            }

            set
            {
                numberofpants = value;
            }
        }
    }
}
