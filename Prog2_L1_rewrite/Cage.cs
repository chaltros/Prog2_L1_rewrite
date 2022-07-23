using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Prog2_L1_rewrite;

namespace Prog2_L1
{
    internal class Cage
    {
        private Animal[] zoo;

        public Animal[] Zoo
        {
            get { return zoo; }
            set { zoo = value; }
        }

        Animal TextToData(string text)
        {
            Animal result;
            string[] array = text.Split(' ');
            result = new Animal(array[0], array[1], int.Parse(array[2]), array[3]);
            return result;
        }

        bool Fill(string[] inputText)
        {
            bool result = false;
            if (zoo[zoo.Length - 1] != null)
            {
                int counter = 0;
                for (int i = 0; i < zoo.Length; i++)
                {
                   zoo[i] = TextToData(inputText[counter++]);  
                }
                result = true;
            }
            return result;
        }

        bool Delete(ref Animal[] zoo, string TextAnimal)
        {
            bool back = false;
            Animal[] temp = new Animal[zoo.Length - 1];
            int counter = 0;
            for (int i = 0; i < zoo.Length; i++)
            {
                if (zoo[i].Name != TextAnimal){temp[counter++] = zoo[i];}
                else{back = true;}
                zoo = temp;
            }
            return back;
        }
        public int RaceCount(string faj, int sorszam) // enummal van már máshogyan kell csinálni
        {
            int back = 0;
            Animal[] act = zoo;

            foreach (Animal i in act)
            {
                foreach (string j in i.Faj)
                {
                    if (j == faj)
                    {
                        back++;
                    }
                }
            }

            return back;
        }

    }
}
