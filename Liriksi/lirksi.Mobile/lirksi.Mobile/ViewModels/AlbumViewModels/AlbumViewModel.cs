using liriksi.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace lirksi.Mobile.ViewModels
{
    public class AlbumViewModel : BaseViewModel
    {
        private readonly APIService _albumService = new APIService("album");
        private readonly APIService _performerService = new APIService("performer");

        public AlbumViewModel()
        {
            InitCommand = new Command(async() => await Init());        
        }
        public ObservableCollection<Album> AlbumList { get; set; } = new ObservableCollection<Album>();
        public ObservableCollection<Performer> PerformerList { get; set; } = new ObservableCollection<Performer>();
        
        Performer _selectedPerformer = null;

        public Performer SelectedPerformer
        {
            get { return _selectedPerformer; }
            set
            {
                SetProperty(ref _selectedPerformer, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if (PerformerList.Count == 0)
            {
                var performerList = await _performerService.Get<IEnumerable<Performer>>(null, null);
                PerformerList.Clear();
                foreach (var item in performerList)
                {
                    PerformerList.Add(item);
                }
            }

            if (SelectedPerformer != null)
            {
                int performerId = _selectedPerformer.Id;
                var albumList = await _albumService.Get<IEnumerable<Album>>(performerId, "GetAlbumsByPerformerId");
                AlbumList.Clear();
                foreach (var item in albumList)
                {
                    AlbumList.Add(item);
                }
            }
        }
    }
}
