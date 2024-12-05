

namespace EstudoAulaC_ExercicioHerançaPolimorfismo.Entities
{
    internal class OutsourcedEmployee : Employee
    {

        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name,int hours,double valueperhour,double additionalCharge) : base(name,hours,valueperhour) {
        
            AdditionalCharge = additionalCharge;
        }
        public override double payment(int hours, double valueperhour,double additionalcharge)
        {
            return  hours * valueperhour + (additionalcharge * 1.10);
            return base.payment(hours, valueperhour);
        }
    }
}
