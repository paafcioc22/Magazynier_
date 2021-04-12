using FluentValidation; 
using Magazynier.AplicationServices.API.Domain.PUT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Validators
{
    public class PutDocRequestValidator : AbstractValidator<PutDocRequest>
    {
        public PutDocRequestValidator()
        {
 
            this.RuleFor(x => x.Document.Fmm_NrListu).Length(0, 30);
            this.RuleFor(x => x.Document.Trn_NrDokumentu).Length(0, 30);
 
        }


         
    }
}
