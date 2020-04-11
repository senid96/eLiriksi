using AutoMapper;
using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.WebAPI.EF;
using liriksi.WebAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services
{
    public class PerformerService : IPerformerService
    {
        private readonly LiriksiContext _context;
        private readonly IMapper _mapper;
        public PerformerService(LiriksiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Performer> Get(PerformerInsertRequest obj) //insertRequest.. same object used for search
        {
            var query = _context.Performer.AsQueryable();
            if (!string.IsNullOrWhiteSpace(obj.Name))
                query = query.Where(x => x.Name.Contains(obj.Name));
            if (!string.IsNullOrWhiteSpace(obj.Surname))
                query = query.Where(x => x.Surname.Contains(obj.Surname));
            if (!string.IsNullOrWhiteSpace(obj.ArtisticName))
                query = query.Where(x => x.ArtisticName.Contains(obj.ArtisticName));

            return query.ToList();
        }

        public Performer Insert(PerformerInsertRequest obj)
        {
            var entity = _mapper.Map<Performer>(obj);
            _context.Performer.Add(entity);
            _context.SaveChanges();

            return  _context.Performer.Last();
        }
    }
}
