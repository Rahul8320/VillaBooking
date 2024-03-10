using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using VillaBooking.Domain.Entities;

namespace VillaBooking.Web.Models.ViewModels;

public class VillaNumberVM
{
    public VillaNumber VillaNumber { get; set; } = default!;

    [ValidateNever]
    public IEnumerable<SelectListItem> VillaList { get; set; } = default!;
}
