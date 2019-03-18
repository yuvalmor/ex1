using System;
using System.Collections.Generic;

namespace Excercise_1
{
    public class ComposedMission : IMission
    {
        public event EventHandler<double> OnCalculate;
        Queue<funcPointer> queue = new Queue<funcPointer>();
        const string typeName = "Composed mission";
        public string Type {
            get { return Type; }
            set { Type = typeName; }
        }
        public string Name
        {
            get { return Name; }
            set {; }
        }
        public ComposedMission(string str)
        {
            Name = str;
        }
        public double Calculate(double value)
        {
            OnCalculate?.Invoke(this, value);
            Queue<funcPointer> temp = new Queue<funcPointer>();
            funcPointer fp;
            double answer = value;
            while (queue.Count > 0)
            {
                fp = queue.Dequeue();
                temp.Enqueue(fp);
                answer = fp(answer);
            }
            queue = temp;
            return answer;
        }
        public ComposedMission Add(funcPointer funcPointer)
        {
            queue.Enqueue(funcPointer);
            return this;
        }
    }
}
