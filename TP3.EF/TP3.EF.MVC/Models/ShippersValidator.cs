using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace TP3.EF.MVC.Models
{

    public class ShippersValidator : AbstractValidator<ShippersView>
    {
       
public ShippersValidator()
        {
            RuleFor(model => model.CompanyName).NotEmpty().WithMessage("El nombre no puede estar Vacio");
            RuleFor(model => model.CompanyName).Length(1,40).WithMessage("El Nombre debe ser menor que 40 Caracteres");
            RuleFor(model => model.Phone).Length(1,24).WithMessage("El telefono debe ser menor que 24 Caracteres");
            RuleFor(model => model.Phone).NotEmpty().WithMessage("El telefono no puede estar Vacio");
            RuleFor(model => model.Phone).Must(PhoneValidation).WithMessage("Los caracteres Ingresados no se corresponden con un telefono");
        }

        private bool PhoneValidation(string value)
        {
            var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            if (r.IsMatch(value))
            {
                return true;
            }
            return false;
        }



    }
}