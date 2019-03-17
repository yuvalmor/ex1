using System;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private funcPointer fP;
        public string Name
        {
            get{return Name;}
            set{Name = value;}
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
        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            throw new NotImplementedException();
        }
    }
}
