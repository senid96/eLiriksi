using liriksi.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace lirksi.Mobile.ViewModels
{
    public class SongDetailsViewModel:BaseViewModel
    {
        public SongGetRequest Song { get; set; }
    }
}
