using FluentValidation;
using ProvaH1_Frete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProvaH1_Frete.Validations
{
    public class CalcularFreteValidation: AbstractValidator<Frete>
    {
        public CalcularFreteValidation()
        {
            RuleFor(Frete => Frete.ComprimentoCm)

                     .NotEmpty().WithMessage("O valor é obrigatorio, tente novamente")
                     .NotNull().WithMessage("Valor não informado, tente novamente")
                     .GreaterThan(0).WithMessage("Valor do comprimento deve ser maior que 0");


            RuleFor(Frete => Frete.LarguraCm)

                    .NotEmpty().WithMessage("O valor é obrigatorio, tente novamente")
                    .NotNull().WithMessage("Valor não informado, tente novamente")
                    .GreaterThan(0).WithMessage("Valor de largura deve ser maior que 0");

            RuleFor(Frete => Frete.AlturaCm)

                   .NotEmpty().WithMessage("O valor é obrigatorio, tente novamente")
                   .NotNull().WithMessage("Valor não informado, tente novamente")
                   .GreaterThan(0).WithMessage("Valor da altura deve ser maior que 0");

            RuleFor(Frete => Frete.tipoPostagem)
                   .NotEmpty().WithMessage("O valor é obrigatorio, deve ser informado")
                   .NotNull().WithMessage("O valor não informado, tente novamente")
                   .LessThan(4).WithMessage("Deve ser menor que 4: PAC = 1, Sedex = 2, Sedex10 = 3, Sedex12 = 4");
        }
    }
}
