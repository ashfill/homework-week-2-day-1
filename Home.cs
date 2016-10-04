using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_day_one_homework
{
    public class Home
    {
        private int numberofwindows;
        private int numberofdoors;
        private int numberofrooms;
        private int numberofwalls;
        private bool hasroof;

        public Home( int amountofwalls)
        {
            numberofwalls = amountofwalls;
        }
        public int Numberofwindows
        {
            get
            {
                return numberofwindows;
            }
            set
            {
                if (value < 2)
                {
                    numberofwindows = 2;
                }
                else
                {
                    numberofwindows = value;
                }
            }
        }

        public int Numberofdoors
        {
            get
            {
                return numberofdoors;
            }

            set
            {
                numberofdoors = value;
            }
        }

        public int Numberofrooms
        {
            get
            {
                return numberofrooms;
            }

            set
            {
                numberofrooms = value;
            }
        }

        public int Numberofwalls
        {
            get
            {
                return numberofwalls;
            }

            set
            {
                numberofwalls = value;
            }
        }

        public bool Hasroof
        {
            get
            {
                return hasroof;
            }
            set
            {
                hasroof = value;
            }
        }
    }
        

        }
    

