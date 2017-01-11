using Abp.Application.Services;
using EasyFast.Application.Edition.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.Edition
{
    public interface IEditionAppService : IApplicationService
    {
        IEnumerable<EditionDto> GetList();
    }
}
