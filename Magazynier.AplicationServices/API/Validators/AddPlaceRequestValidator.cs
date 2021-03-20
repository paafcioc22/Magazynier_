using FluentValidation;
using Magazynier.AplicationServices.API.Domain.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Validators
{
    public class AddPlaceRequestValidator : AbstractValidator<AddPlaceRequest>
    {
        public AddPlaceRequestValidator()
        {
            this.RuleFor(x => x.PlaceName).Length(2, 3);
             
        }
    }
}
