using System;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        private funcPointer fP;
        //private string name;
        public string Type {
            get { return Type; }
            set { Type = "Composed mission"; }
        }

        public string Name
        {
            get { return Name; }
            set {; }
        }

        public event EventHandler<double> OnCalculate;
        public ComposedMission(string str)
        {
            Name = str;
        }
        public double Calculate(double value)
        {
            return fP(value);
        }

        public ComposedMission Add(funcPointer funcPointer)
        {
            fP += funcPointer;
            return this;
        }
    }
}
