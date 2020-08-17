using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels
{
    public class SongViewModel
    {
        private readonly APIService _songService = new APIService("song");
        public SongViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        //observble je da bi gui mogao raditi fino, kao fb kad se skrola.. procitati malo jos
        public ObservableCollection<SongGetRequest> SongList { get; set; } = new ObservableCollection<SongGetRequest>();
        
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _songService.Get<IEnumerable<SongGetRequest>>(null, null);
            SongList.Clear();
            foreach (var song in list)
            {
                SongList.Add(song);
            }
        } 
    }
}
