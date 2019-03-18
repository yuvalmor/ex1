using System;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        private funcPointer fP;
        public string Name
        {
            get { return Name; }
            set {;}
        }
        public string Type {
            get { return Type; }
            set { Type = "Single mission"; }
        }
        public SingleMission(funcPointer funcPointer, string name)
        {
            Name = name;
            fP = funcPointer;
        }
        public double Calculate(double value)
        {
            OnCalculate?.Invoke(this,value);
            return fP(value);
        }
    }
}
