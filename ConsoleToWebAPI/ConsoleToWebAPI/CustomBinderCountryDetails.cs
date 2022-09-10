using ConsoleToWebAPI.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI
{
    public class CustomBinderCountryDetails : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName);
            var strResult = value.FirstValue;
            var result = int.TryParse(strResult, out var id);
            if (!result)
            {
                return Task.CompletedTask;
            }

            var model = new CountryModel()
            {
                Id = id,
                Name = "india",
                Area = 500,
                Population = 340000
            };

            bindingContext.Result = ModelBindingResult.Success(model);
            return Task.CompletedTask;
        }
    }
}
