using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator()
        {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("'{PropertyName}' alanı boş geçilemez.")
            .MinimumLength(3).WithMessage("'{PropertyName}' alanı en az {MinLength} karakter olmalıdır.")
            .MaximumLength(100).WithMessage("'{PropertyName}' alanı en fazla {MaxLength} karakter olmalıdır.")
            .WithName("Kurs Adı");
            RuleFor(x => x.Description)
            .NotEmpty().WithMessage("'{PropertyName}' alanı boş geçilemez.")
            .MinimumLength(3).WithMessage("'{PropertyName}' alanı en az {MinLength} karakter olmalıdır.")
            .MaximumLength(500).WithMessage("'{PropertyName}' alanı en fazla {MaxLength} karakter olmalıdır.")
            .WithName("Kategori Açıklaması");
            RuleFor(p => p.Price).NotEmpty();
            RuleFor(p => p.Price).GreaterThanOrEqualTo(10)/*.When(p => p.CategoryId == 1)*/;// kategoriid 1se unitprice 10'dan büyük olmalı.
        }
    }
}
