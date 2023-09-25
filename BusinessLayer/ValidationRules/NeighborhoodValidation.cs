using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class NeighborhoodValidation : AbstractValidator<Neighborhood>
    {
        public NeighborhoodValidation()
        {
            RuleFor(x => x.NeighborhoodName).NotEmpty().WithMessage("Boş bırakılmaz.");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("İlçe boş bırakılmaz.");
        }
    }
}
