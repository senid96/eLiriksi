using liriksi.Model;
using liriksi.Model.Requests;
using liriksi.Model.Requests.album;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels
{
    public class SongViewModel : BaseViewModel
    {
        private readonly APIService _songService = new APIService("song");

        string _title = string.Empty;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        string _text = string.Empty;
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public SongViewModel()
        {
            SearchCommand = new Command(async () => await Search());
        }
        public ObservableCollection<SongGetRequest> SongList { get; set; } = new ObservableCollection<SongGetRequest>();

        public ICommand SearchCommand { get; set; }

        async Task Search()
        {
            SongSearchRequest req = new SongSearchRequest()
            {
                Title = Title,
                Text = Text
            };

            SongList.Clear();
            List<SongGetRequest> list = await _songService.Get<List<SongGetRequest>>(req, null);
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    SongList.Add(item);
                }
            }

        }
    }
}
