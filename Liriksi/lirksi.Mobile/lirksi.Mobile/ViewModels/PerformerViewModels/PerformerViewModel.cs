using liriksi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace lirksi.Mobile.ViewModels.PerformerViewModels
{
    public class PerformerViewModel: BaseViewModel
    {
        /* service */
        private readonly APIService _performerService = new APIService("performer");

        /* performer list */
        public ObservableCollection<Performer> PerformerList { get; set; } = new ObservableCollection<Performer>();

        public PerformerViewModel()
        {
            Title = "Performer";
        }


        /*---------------------------------------- METHODS ------------------------------------------- */

        public async Task GetPerformers()
        {
           var list = await _performerService.Get<List<Performer>>(null, "GetPerformers");
            PerformerList.Clear();
            foreach (var item in list)
            {
                PerformerList.Add(item);
            }
        }
    }
}
