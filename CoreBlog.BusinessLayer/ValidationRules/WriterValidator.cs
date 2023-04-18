using CoreBlog.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterNameSurname).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez!");
            RuleFor(x => x.WriterNameSurname).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın!");
            RuleFor(x => x.WriterNameSurname).MaximumLength(20).WithMessage("Lütfen 20 karakterden fazla değer girişi yapmayın!");
            RuleFor(x => x.WriterEmail).NotEmpty().WithMessage("Email adresi boş geçilemez!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre doğrulama alanı boş geçilemez!");
            RuleFor(x => x.WriterPassword).Equal(x => x.ConfirmPassword).WithMessage("Şifreler birbiri ile uyuşmuyor!");
        }
    }
}
