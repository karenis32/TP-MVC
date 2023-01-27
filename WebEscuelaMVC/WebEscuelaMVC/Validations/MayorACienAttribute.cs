using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validations
{
    public class MayorACienAttribute: ValidationAttribute
    {
        public MayorACienAttribute()
        {
            ErrorMessage = "El numero debe ser mayor a 100";
        }
        public override bool IsValid(object value)
        {
            //   return base.IsValid(value);
            int numero = (int)value;
            if (numero <= 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
