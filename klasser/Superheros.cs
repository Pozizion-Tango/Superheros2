using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser
{
    public class Superheros
    {
        private string name;
        private string power;
        private string costume;
        private string backstory;
        private string moralcode;
        private string enemies;
        private string weakness;


        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public string Power
        {
            get { return power; }
            private set { power = value; }
        }
        public string Costume
        {
            get { return costume; }
            private set { costume = value; }
        }
        public string Backstory
        {
            get { return backstory; }
            private set { backstory = value; }
        }
        public string Moralcode
        {
            get { return moralcode; }
            private set { moralcode = value; }
        }
        public string Enemies
        {
            get { return enemies; }
            private set { enemies = value; }
        }
        public string Weakness
        {
            get { return weakness; }
            private set { weakness = value; }
        }
    }
}
