﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.ViewModels.Products;

namespace WebAPI.Application.Validators.Products
{
    public class CreateProductValidator:AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
              .NotEmpty()
              .NotNull()
                  .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
              .MaximumLength(150)
              .MinimumLength(5)
                  .WithMessage("Lütfen ürün adını 5 ile 150 karakter arasında giriniz.");
            RuleFor(p => p.Description)
                .MinimumLength(5)
                .WithMessage("Lütfen en az 5 karakter açıklama giriniz");
        }

    }
}
