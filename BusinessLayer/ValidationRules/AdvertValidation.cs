using EntityLayer.Entities;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BusinessLayer.ValidationRules
{
    public class AdvertValidation : AbstractValidator<Advert>
    {
        public AdvertValidation()
        {
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres bilgisi boş bırakılmaz.");
            RuleFor(x => x.AdvertTitle).NotEmpty().WithMessage("İlan başlığı boş bırakılmaz.");
            RuleFor(x => x.AdvertTitle).MinimumLength(2).WithMessage("En az 2 karakter girmelisiniz.");
            RuleFor(x => x.AdvertTitle).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz.");
            RuleFor(x => x.Area).NotEmpty().WithMessage("Bölge alanı boş bırakılmaz.");
            RuleFor(x => x.BathroomNumbers).NotEmpty().WithMessage("Banyo sayısı boş bırakılmaz.");
            RuleFor(x => x.NumberOfRooms).NotEmpty().WithMessage("Oda sayısı boş bırakılmaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılmaz.");
            RuleFor(x => x.Floor).NotEmpty().WithMessage("Kat alanı boş bırakılmaz.");
            RuleFor(x => x.Garage).NotEmpty().WithMessage("Garaj alanı boş bırakılmaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş bırakılmaz.");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon alanı boş bırakılmaz.");
            // KURS -> RuleFor(x => x.PhoneNumber).Matches(new Regex(@"([\+]90?)([ ]?)(\([0-9]{3}\))([]?)([0-9]{3})(\s*[\-]?)([0-9]{2})(\s*[\-]?)([0-9]{2})"));
            // CHATGPT -> RuleFor(x => x.PhoneNumber).Matches(new Regex(@"^(\+[0-9]{1,3}\s?)?(\([0-9]{3}\)\s?)?[0-9]{3}(\s*[\-]?)?[0-9]{2}(\s*[\-]?)?[0-9]{2}$"));
            //RuleFor(x => x.Neighborhood).NotEmpty().WithMessage("Mahalle alanı boş bırakılmaz.");
            RuleFor(x => x.CityId).NotEmpty().WithMessage("Şehir alanı boş bırakılmaz.");
            RuleFor(x => x.TypeId).NotEmpty().WithMessage("Tip alanı boş bırakılmaz.");
            RuleFor(x => x.SituationId).NotEmpty().WithMessage("Açıklama alanı boş bırakılmaz.");
            RuleFor(x => x.DistrictId).NotEmpty().WithMessage("İlçe alanı boş bırakılmaz.");

        }
    }
}
