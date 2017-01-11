using Abp.Domain.Repositories;
using EasyFast.Application.Edition.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFast.Application.Edition
{
    public class EditionAppService : EasyFastAppServiceBase, IEditionAppService
    {
        #region MyRegion
        private readonly IRepository<Abp.Application.Editions.Edition> _editionRepository;
        public EditionAppService(IRepository<Abp.Application.Editions.Edition> editionRepository)
        {
            _editionRepository = editionRepository;
        }
        #endregion

        public IEnumerable<EditionDto> GetList()
        {
            var list = _editionRepository.GetAll().Select(o => new EditionDto
            {
                Name = o.Name,
                DisplayName = o.DisplayName
            }).ToList();
            return list;
        }
    }
}
