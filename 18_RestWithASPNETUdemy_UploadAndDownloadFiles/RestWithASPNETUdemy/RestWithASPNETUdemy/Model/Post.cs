using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("posts")]
    public class Post : BaseEntity
    {
        [Column("titulo")]
        public string Title { get; set; }

        [Column("descricao")]
        public string Description { get; set; }

        [Column("file_name")]
        public string FileName { get; set; }

        [Column("enabled")]
        public int Enabled { get; set; }

    }

}
