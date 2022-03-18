namespace Project.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            double income = base.Payment();
            income += AdditionalCharge + (AdditionalCharge * 10 / 100);
            return income;
        }
    }
}