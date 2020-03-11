using liriksi.Model;
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
        public PerformerService(LiriksiContext context)
        {
            _context = context;
        }
        public List<Performer> Get()
        {
            return _context.Performer.ToList<Performer>();
        }
    }
}
