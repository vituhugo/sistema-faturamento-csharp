using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace EntryApi.Application.DTOs.Binders;

public class GetEntryFilterBinder: IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var typeValue = bindingContext.HttpContext.Request.Query["filters[type]"].FirstOrDefault();
        var dateValue = bindingContext.HttpContext.Request.Query["filters[date]"].FirstOrDefault();

        var result = new EntryGetFilterDto();
        if (typeValue != null)
        {
            result.Type = typeValue;
        }

        if (dateValue != null)
        {
            result.Date = DateTime.Parse(dateValue);
        }

        bindingContext.Result = ModelBindingResult.Success(result);
        return Task.CompletedTask;
    }
}