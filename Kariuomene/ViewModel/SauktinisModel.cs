using System;
using System.Collections.Generic;

namespace Kariuomene.ViewModel
{
    public class SauktinisModel
    {
        public int Viso { get; set; }
        public IList<RinktinesModel> Rinktines { get; set; }
        public DateTime CacheDateTime { get; set; }

        public IList<NaujienaModel> Naujienos { get; set; }
    }
}
