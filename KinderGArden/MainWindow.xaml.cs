using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KinderGArden
{
    public struct Address
    {
        string city;
        string street;
        int number;
    }
     public enum JobTitle
    {
        nurse,chief,teacher
    }
    public enum GroupLevel
    {
        youngest,middle,oldest
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearOfBirth { get; set; }

        public Person() { }
        public Person(string Na,string Sn,int Yb)
        {
            Name = Na;
            Sn = Surname;
            Yb = YearOfBirth;
        }
    }
    public class Child : Person
    {
        public Group Group { get; set; }

        public Child() { }
        public Child(string Na,string Sn,int Yb,Group Gp) : base(Na, Sn, Yb)
        {
            Group = Gp;
        }

    }

    public class Worker : Person
    {
        public JobTitle Position { get; set; }
        public Worker() { }
        public Worker(string Na,string Sn,int Yb,JobTitle Pn) : base(Na, Sn, Yb)
        {
            Position = Pn;
        }
    }

    public class Group
    {
        public Worker Kindergartener { get; set; }
        public Worker Nurse { get; set; }
        public GroupLevel Level { get; set; }
        public List<Child> Children { get; set; }
        public Group() { }
        public Group(Worker Kr,Worker Ns,GroupLevel Lvl, List<Child> Ch)
        {
            Kindergartener = Kr;
            Nurse = Ns;
            Level = Lvl;
            Children = Ch;
        }
    }

    public class KinderGarden
    {
        public string Phone { get; set; }
        public Worker Chief { get; set; }
        public int Kids { get; set; }
        public Address Coords { get; set; }
        public KinderGarden() { }
        public KinderGarden(string Ph,Worker Ch,int Ks,Address Cs)
        {
            Phone = Ph;
            Chief = Ch;
            Kids = Ks;
            Coords = Cs;
        }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
