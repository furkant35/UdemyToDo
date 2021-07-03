﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using YSKProje.ToDo.DTO.DTOs.AppUserDtos;

namespace YSKProje.ToDo.Business.ValidationRules.FluentValidation
{
    public class AppUserAddValidator : AbstractValidator<AppUserAddDto>
    {
        public AppUserAddValidator()
        {
            RuleFor(I => I.Name).NotNull().WithMessage("Kullanıcı adı boş geçilemez");
            RuleFor(I => I.Password).NotNull().WithMessage("Parola alanı boş geçilemez");
            RuleFor(I => I.ConfirmPassword).NotNull().WithMessage("Parola onayı alanı boş geçilemez");
            RuleFor(I => I.ConfirmPassword).Equal(I => I.Password).WithMessage("Parolalarınız eşleşmiyor");
            RuleFor(I => I.Email).NotNull().WithMessage("Email alanı boş geçilemez").EmailAddress().WithMessage("Geçersiz email adresi");
            RuleFor(I => I.Name).NotNull().WithMessage("Ad alanı boş geçilemez");
            RuleFor(I => I.Surname).NotNull().WithMessage("Soyad alanı boş geçilemez");
        }
    }
}
