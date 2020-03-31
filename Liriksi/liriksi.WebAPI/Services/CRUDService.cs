using AutoMapper;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class CRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TSearch, TDatabase>, ICRUD<TModel, TSearch, TInsert, TUpdate> where TDatabase: class
    {
        public CRUDService(LiriksiContext context, IMapper mapper) : base(context, mapper)
        {
        }

        virtual public TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        virtual public TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity); //mapiramo request u entitet

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity); //ovdje ponovo vracamo u request get objekat za prikaz
        }
    }
}
