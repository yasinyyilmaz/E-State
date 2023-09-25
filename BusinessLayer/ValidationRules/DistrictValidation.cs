using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class DistrictValidation : AbstractValidator<District>   
    {
        public DistrictValidation()
        {
            RuleFor(x => x.DistrictName).NotEmpty().WithMessage("Boş bırakılmaz.");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Şehir boş bırakılmaz.");
        }
    }
}
