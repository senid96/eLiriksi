using liriksi.Model;
using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace liriksi.WebAPI.Services.Interfaces
{
    public interface IPerformerService
    {
        List<Performer> Get(PerformerInsertRequest obj); //same object for search and insert
        Performer GetById(int id);
        Performer Insert(PerformerInsertRequest obj);
        Performer Update(int id, PerformerInsertRequest obj);
        bool Delete(int id);
    }
}
