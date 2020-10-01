using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        public double Input1 { get; set; }
        public double Input2 { get; set; }
        public double Result { get; set; }

        public string Button { get; set; }

        //public double calc ( string button, double input)
        //{
        //    this.Button = button;
        //    switch (Button)
        //    {
        //        case "add":
        //            Result = Input1 + Input2;
        //            break;
        //        case "sub":
        //            Result = Input1 - Input2;
        //            break;
        //        case "mul":
        //            Result = Input1 * Input2;
        //            break;
        //        case "Divi":
        //            Result = Input1 / Input2;
        //            break;
        //    }
            
            
        //    return Result;
        //}
    }
}
