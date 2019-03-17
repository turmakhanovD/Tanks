using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Tank
    {
        private string Name { get; set; }
        private int Armor { get; set; }
        private int Ammunition { get; set; }
        private int Mobility { get; set; }
        private int winPoints = 0;
        private Random rand= new Random();

       public Tank(string name)
        {
            rand.Next(100);
            Name = name;
            Armor=  rand.Next(100);
            Ammunition = rand.Next(100);
            Mobility = rand.Next(100);
            
        }

        public static Tank operator ^(Tank t34, Tank pantera)
        {
            if (t34.Armor > pantera.Armor) t34.winPoints += 1;
            else if (t34.Armor < pantera.Armor) pantera.winPoints += 1;


            if (t34.Ammunition > pantera.Ammunition) t34.winPoints += 1;
            else if (t34.Ammunition < pantera.Ammunition) pantera.winPoints += 1;

            if (t34.Mobility > pantera.Mobility) t34.winPoints += 1;
            else if (t34.Mobility < pantera.Mobility) pantera.winPoints += 1;

            if (t34.winPoints > pantera.winPoints) return t34;
            else if (t34.winPoints < pantera.winPoints)return pantera;

            return t34;
        }

        public void GetInfo(Tank tank)
        {
            Console.WriteLine("Name: {0}",tank.Name);
            Console.WriteLine("Modility: {0}", tank.Mobility);
            Console.WriteLine("Ammunity: {0}",tank.Ammunition);
            Console.WriteLine("Armor: {0}",tank.Armor);
        }
           
    }
}
