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
        private readonly APIService _performerService = new APIService("performer");
        public SongViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        Album _selectedAlbum = null;
        Performer _selectedPerformer = null;

        //observble je da bi gui mogao raditi fino, kao fb kad se skrola.. procitati malo jos
        public ObservableCollection<SongGetRequest> SongList { get; set; } = new ObservableCollection<SongGetRequest>();
        public ObservableCollection<Album> AlbumList { get; set; } = new ObservableCollection<Album>();
        public ObservableCollection<Performer> PerformerList { get; set; } = new ObservableCollection<Performer>();

        public Album SelectedAlbum 
        {
            get { return _selectedAlbum; }
            set 
            { 
                SetProperty(ref _selectedAlbum, value);
                if (value != null)
                {
                    PopulateSongs();
                }
            } 
        }
        public Performer SelectedPerformer
        {
            get { return _selectedPerformer; }
            set
            {
                SetProperty(ref _selectedPerformer, value);
                if (value != null)
                {
                    PopulateAlbums();
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            //performeri
            if (PerformerList.Count == 0)
            {
                    var performerList = await _performerService.Get<IEnumerable<Performer>>(null, null);
                    PerformerList.Clear();
                    foreach (var item in performerList)
                    {
                        PerformerList.Add(item);
                    }
            }
        } 

        public async Task PopulateAlbums()
        {
            //za punjenje dropdown liste
            int performerId = SelectedPerformer.Id;
            var albumList = await _albumService.Get<IEnumerable<Album>>(performerId, "GetAlbumsByPerformerId");
            AlbumList.Clear();
            foreach (var album in albumList)
            {
                AlbumList.Add(album);
            }
        }

        public async Task PopulateSongs()
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
