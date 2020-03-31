using AutoMapper;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class BaseService<TModel, TSearch, TDatabase> : IService<TModel, TSearch> where TDatabase: class
    {
        protected readonly LiriksiContext _context;
        protected readonly IMapper _mapper;
        public BaseService(LiriksiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        virtual public List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<TModel>>(list);
        }

        virtual public TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
