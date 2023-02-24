using RestWithASPNETUdemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("comments")]
    public class Comment : BaseEntity
    {
        [Column("content")]
        public string Content { get; set; }

        [Column("person_name")]
        public string PersonName { get; set; }

        [Column("posts_id")]
        public int PostId { get; set; }

        [Column("post_date")]
        public DateTime PostDate { get; set; }

    }

}
