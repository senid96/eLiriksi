using liriksi.Model;
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
    public class AlbumDetailsViewModel :BaseViewModel
    {
        private readonly APIService _songService = new APIService("song");

        public Album Album { get; set; }
        public ObservableCollection<SongGetRequest> SongList { get; set; } = new ObservableCollection<SongGetRequest>();

        public AlbumDetailsViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            //performeri
            if (SongList.Count == 0)
            {
                int albumId = Album.Id;
                var songList = await _songService.GetById<IEnumerable<SongGetRequest>>(albumId, "GetSongsByAlbum");
                SongList.Clear();
                foreach (var item in songList)
                {
                    SongList.Add(item);
                }
            }
        }
       

    }
}
