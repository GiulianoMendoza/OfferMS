using Application.DTO.Error;
using Microsoft.AspNetCore.Mvc.ModelBinding;

public static class CustomValidation
{
    public static void ReturnError(ModelStateDictionary model)
    {
        try
        {
            var errors = model.Values
            .SelectMany(v => v.Errors)
            .Select(e => e.ErrorMessage)
            .ToList();

            string message = "";
            
            errors.ForEach(e =>
            {
                message = message + e.ToString() + " ";
            });

            throw new BadRequestException(message);
        }
        catch (Exception)
        {
            throw;
        }
    }
}