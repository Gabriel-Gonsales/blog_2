using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class CommentConverter : IParser<CommentVO, Comment>, IParser<Comment, CommentVO>
    {
        public Comment Parse(CommentVO origin)
        {
            if (origin == null) return null;
            return new Comment
            {
                Id = origin.Id,
                Content = origin.Content,
                PersonName = origin.PersonName,
                PostDate = origin.PostDate,
                PostId= origin.PostId
            };
        }

        public CommentVO Parse(Comment origin)
        {
            if (origin == null) return null;
            return new CommentVO
            {
                Id = origin.Id,
                Content = origin.Content,
                PersonName = origin.PersonName,
                PostDate = origin.PostDate,
                PostId = origin.PostId
            };
        }

        public List<Comment> Parse(List<CommentVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<CommentVO> Parse(List<Comment> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
