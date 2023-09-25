using EntityLayer.Entities;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ImagesValidation : AbstractValidator<Images>
    {
        public ImagesValidation()
        {
            RuleFor(x => x.Image).NotEmpty().WithMessage("Resim boş bırakılmaz.");
            //RuleFor(x => x.AdvertId).NotEmpty().WithMessage("İlan bilgisi boş bırakılmaz.");
        }
    }
}
