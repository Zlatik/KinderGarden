using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinderGarden
{
    public abstract class Human
    {
        protected int age;
        protected string name;
        protected string surname;
        protected string address;
        protected string father;
        protected string mother;
        public abstract int Age { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }
        public abstract string Address { get; set; }
        public abstract string Father { get; set; }
        public abstract string Mother { get; set; }
        
    }

    public class Child : Human
    {
        public string group;
        public  string Group 
        {
            get { return group; }
            set { group = value; }
        }

        public override int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public override string Address
        {
            get { return address; }
            set { address = value; }
        }
        public override string Father
        {
            get { return father + " " + surname; }
            set { father = value; }
        }
        public override string Mother
        {
            get { return father + " " + surname; }
            set { father = value; }
        }
       
    }
}