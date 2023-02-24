using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Data.VO
{
    public class CommentVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public string PersonName { get; set; }
        public int PostId { get; set; }
        public DateTime PostDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}