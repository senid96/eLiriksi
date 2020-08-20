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
    public class AlbumViewModel
    {
        private readonly APIService _albumService = new APIService("album");

        public AlbumViewModel()
        {
            InitCommand = new Command(async() => await Init());        
        }
        public ObservableCollection<Album> AlbumList { get; set; } = new ObservableCollection<Album>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _albumService.Get<IEnumerable<Album>>(null, null);
            AlbumList.Clear();
            foreach (var item in list)
            {
                AlbumList.Add(item);
            }
        }
    }
}
