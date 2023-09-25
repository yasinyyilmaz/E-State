using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class TypeValidation : AbstractValidator<EntityLayer.Entities.Type>
    {
        public TypeValidation()
        {
            RuleFor(x => x.TypeName).NotEmpty().WithMessage("Boş bırakılmaz.");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("Boş bırakılmaz.");
        }
    }
}
