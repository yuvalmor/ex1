using System;

namespace Excercise_1
{
    public class SingleMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        const string desc = "Single mission";
        private funcPointer fP;
        public string Name
        {
            get;
        }
        public string Type {
            get;
        }
        public SingleMission(funcPointer funcPointer, string name)
        {
            Name = name;
            Type = desc;
            fP = funcPointer;
        }
        public double Calculate(double value)
        {
            double answer = fP(value);
            OnCalculate?.Invoke(this,answer);
            return answer;
        }
    }
}
