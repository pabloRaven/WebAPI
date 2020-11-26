using MyFinances.WebApi.Models.Domains;
using MyFinances.WebApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFinances.WebApi.Models.Converter
{
    public static class OperationConverter
    {
        public static OperationDto ToDto (this Operations model)
        {
            return new OperationDto
            {
                CategoryId = model.CategoryId,
                Date = model.Date,
                Description = model.Description,
                Name = model.Name,
                Value = model.Value
            };
        }

        public static IEnumerable<OperationDto> ToDtos (
            this IEnumerable<Operations>model)
        {
            if (model ==null)            
                return Enumerable.Empty<OperationDto>();

            return model.Select(x => x.ToDto());
            
        }

        public static Operations ToDao(this OperationDto model)
        {
            return new Operations
            {
                CategoryId = model.CategoryId,
                Date = model.Date,
                Description = model.Description,
                Name = model.Name,
                Value = model.Value
            };
        }
    }
}
