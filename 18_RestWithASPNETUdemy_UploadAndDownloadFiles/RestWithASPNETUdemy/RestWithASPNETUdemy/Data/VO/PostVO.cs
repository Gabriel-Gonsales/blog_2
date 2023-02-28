using RestWithASPNETUdemy.Hypermedia;
using RestWithASPNETUdemy.Hypermedia.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Data.VO
{
    public class PostVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public byte[] Arquivo { get; set; }
        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}