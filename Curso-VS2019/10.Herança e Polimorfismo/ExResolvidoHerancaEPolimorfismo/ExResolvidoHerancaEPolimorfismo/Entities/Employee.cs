namespace ExResolvidoHerancaEPolimorfismo.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee (string name, int hours, double valuePerhour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerhour;
        }

        public virtual double Payment()//virtual, libera o override na operação.
        {
            return Hours * ValuePerHour;
        }
    }
}
