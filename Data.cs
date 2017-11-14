using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace IFSfractals
{
    public class Data : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double a;

        public double A
        {
            get { return a; }
            set { a = value; OnPropertyChanged("A"); }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = value; OnPropertyChanged("B"); }
        }

        private double c;

        public double C
        {
            get { return c; }
            set { c = value; OnPropertyChanged("C"); }
        }

        private double d;

        public double D
        {
            get { return d; }
            set { d = value; OnPropertyChanged("D"); }
        }

        private double e;

        public double E
        {
            get { return e; }
            set { e = value; OnPropertyChanged("E"); }
        }

        private double f;

        public double F
        {
            get { return f; }
            set { f = value; }
        }

        private int pocetBodu;

        public int PocetBodu
        {
            get { return pocetBodu; }
            set { pocetBodu = value; OnPropertyChanged("PocetBodu"); }
        }

        //private string _bodiky;

        //public string Bodiky
        //{
        //    get { return _bodiky; }
        //    set { _bodiky = value; }
        //}

        private PointCollection mypointCollection;

        public PointCollection MyPointCollection
        {
            get { return mypointCollection; }
            set
            {
                mypointCollection = value; OnPropertyChanged("MyPointCollection");
            }
        }

        public List<Bod> Body { get; set; }
        public Data()
        {
            A = 0.85;
            B = 0.04;
            C = -0.04;
            D = 0.85;
            E = 0;
            F = 1.60;
            PocetBodu = 100;
            MyPointCollection = new PointCollection();
            VypocitejBody = new MujCommand(Pocitanibodu);
            //Body = new List<Bod>();
        }

        public ICommand VypocitejBody { get; private set; }

        public void Pocitanibodu()
        {
            double x = 0;
            double y = 0;

            for (int i = 0; i < PocetBodu; i++)
            {

                x = (A * x) + (B * y) + E;
                y = (C * x) + (D * y) + F;
                //Body.Add(new Bod(x, y));
                MyPointCollection.Add(new Point(x, y));
                //Bodiky += $"{x.ToString("F0")},{y.ToString("F0")} ";
            }
        }
    }

}
