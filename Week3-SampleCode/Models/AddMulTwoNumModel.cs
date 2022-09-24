using System.ComponentModel.DataAnnotations;
//using System.Runtime.ExceptionServices;

namespace AddMulTwoNum.Models
{
    public class AddMulTwoNumModel
    {
      [Required(ErrorMessage ="Please enter first number.")]
      [Range(0, Double.MaxValue, ErrorMessage =
         "First Number must be greater than 0")]
      public double? Num1 { get; set; }

      [Required(ErrorMessage = "Please enter second number.")]
      [Range(0, Double.MaxValue, ErrorMessage =
        "Second Number must be greater than 0")]
      public double Num2 { get; set; }
      public double? AddTwoNum()
      {
         double? Sum;
         Sum = Num1 + Num2;
         return Sum;
      }

      public double? MulTwoNum()
      {
         double? Product;
         Product = Num1 * Num2;
         return Product;
      }
   }
}
