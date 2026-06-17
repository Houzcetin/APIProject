using APIProje.WebApi.Entities;
    using FluentValidation;

namespace APIProje.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Product name cannot be empty!");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Please enter at least 2 character for product name!");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Enter a maximum of 50 character!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Product price cannot be empty!").GreaterThan(0).WithMessage("Product" +
                " price cannot be negative!").LessThan(1000).WithMessage("Product price cannot be that high!");
            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Product description cannot be empty!");



        }

    }
    
}
