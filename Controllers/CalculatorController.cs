using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult CalculatorView()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult CalculatorView(CalculatorModel model, string calc)
        {
            if(calc=="+")
            {
                model.Result = model.Input1 + model.Input2;
            }
          else if (calc == "-")
            {
                model.Result = model.Input1 - model.Input2;
            }

            else if (calc == "*")
            {
                model.Result = model.Input1 * model.Input2;
            }

            else if (calc == "/")
            {
                model.Result = model.Input1 / model.Input2;
            }

            return View(model);
        }

    }
}
