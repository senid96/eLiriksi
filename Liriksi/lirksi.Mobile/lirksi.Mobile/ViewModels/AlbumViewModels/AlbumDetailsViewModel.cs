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
        private readonly APIService _albumService = new APIService("album");

        public int _albumId { get; set; }

        private Album _album;
        public Album Album
        {
            get { return _album; }
            set { SetProperty(ref _album, value); }
        }
        public ObservableCollection<SongGetRequest> SongList { get; set; } = new ObservableCollection<SongGetRequest>();

       
        public async Task Init()
        {
            await GetAlbumById();
            await GetSongs();
        }

        public async Task GetAlbumById()
        {
            Album = await _albumService.GetById<Album>(_albumId, "GetAlbumById");
        }
       
        public async Task GetSongs()
        {
                var songList = await _songService.GetById<IEnumerable<SongGetRequest>>(Album.Id, "GetSongsByAlbum");
                SongList.Clear();
                foreach (var item in songList)
                {
                    SongList.Add(item);
                }
        }

    }
}
