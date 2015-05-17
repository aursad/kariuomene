using System;

namespace Kariuomene.ViewModel
{
    public class NaujienaModel
    {
        public string Title { get; set; }
        public string FullText { get; set; }
        public string Url { get; set; }
        public byte[] Image { get; set; }
        public string Publish { get; set; }

        public DateTime? Cached { get; set; }
    }
}