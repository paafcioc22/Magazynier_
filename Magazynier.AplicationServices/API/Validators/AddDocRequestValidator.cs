using FluentValidation;
using Magazynier.AplicationServices.API.Domain.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Validators
{
    public class AddDocRequestValidator : AbstractValidator<AddDocRequest>
    {
        public AddDocRequestValidator()
        {
            this.RuleFor(x => x.Fmm_NrlistuPaczka).Length(0, 30);
            this.RuleFor(x => x.Fmm_NrListu).Length(0, 30);
            this.RuleFor(x => x.Trn_NrDokumentu).Length(0, 30);             
            this.RuleFor(x => x.Fmm_NrlistuPaczka).Length(0, 30);
        }
    }
}
