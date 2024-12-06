using FluentValidation;
using JeverlyStroe.Domain.Models;

namespace JeverlyStroe.Domain.Validators;

public class OrderValidator:AbstractValidator<Order>
{
    public OrderValidator()
    {
        RuleFor(o => o.Id).NotEmpty().WithMessage("Id cannot be empty");
        RuleFor(o=>o.CustomerName).NotEmpty().WithMessage("Name cannot be empty");
        RuleFor(o=>o.TotalCost).NotEmpty().WithMessage("Cost cannot be empty")
            .GreaterThan(0).WithMessage("Cost should be greater than 0");
        RuleFor(o=>o.OrderDate).NotEmpty().WithMessage("CreatedAt cannot be empty");
        RuleFor(o=>o.UserId).NotEmpty().WithMessage("IdUser cannot be empty");
        RuleFor(o=>o.ProductId).NotEmpty().WithMessage("IdProduct cannot be empty");
    }
}