using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2_L1_rewrite
{
    enum Race
    {
        dog,panda,rabbit
    }
    internal class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool gender;
        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private int weight;
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private Race propRace;

        public Race PropRace
        {
            get { return propRace; }
            set { propRace = value; }
        }



        public Animal(string inputName, string inputGender
            ,int inputWeight, string inputRace)
        {
            this.name = inputName;

            if (inputGender == "female"){this.gender = false;}
            else{this.gender = true;}

            this.weight = inputWeight;

            switch (inputRace)
            {
                case "dog":
                    this.propRace = Race.dog;
                    break;
                case "panda":
                    this.propRace = Race.panda;
                    break;
                case "rabbit":
                    this.propRace = Race.panda;
                    break;
            }
        }

       


        }
}
