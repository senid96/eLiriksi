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
    public class SongViewModel: BaseViewModel
    {
        private readonly APIService _songService = new APIService("song");
        private readonly APIService _albumService = new APIService("album");
        public SongViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        //observble je da bi gui mogao raditi fino, kao fb kad se skrola.. procitati malo jos
        public ObservableCollection<SongGetRequest> SongList { get; set; } = new ObservableCollection<SongGetRequest>();
        public ObservableCollection<Album> AlbumList { get; set; } = new ObservableCollection<Album>();
        Album _selectedAlbum = null;
        public Album SelectedAlbum 
        {
            get { return _selectedAlbum; }
            set 
            { 
                SetProperty(ref _selectedAlbum, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            } 
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if(AlbumList.Count == 0) //ne puni je ako je vec napunjena(ovo je jer se isto ovo sve poziva na change drop downa)
            {
                //za punjenje dropdown liste
                var albumList = await _albumService.Get<IEnumerable<Album>>(null, null);
                AlbumList.Clear();
                foreach (var album in albumList)
                {
                    AlbumList.Add(album);
                }
            }

            if (SelectedAlbum != null)
            {
                int albumId = SelectedAlbum.Id;

                //za punjenje pjesama
                var songList = await _songService.GetById<IEnumerable<SongGetRequest>>(albumId, "GetSongsByAlbum");
                SongList.Clear();
                foreach (var song in songList)
                {
                    SongList.Add(song);
                }
            }
         
        } 
    }
}
