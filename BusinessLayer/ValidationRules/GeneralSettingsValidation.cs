using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GeneralSettingsValidation : AbstractValidator<GeneralSettings>
    {
        public GeneralSettingsValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres bırakılmaz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail boş bırakılmaz.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon boş bırakılmaz.");
            RuleFor(x => x.ImageName).NotEmpty().WithMessage("Resim boş bırakılmaz.");
        }
    }
}
