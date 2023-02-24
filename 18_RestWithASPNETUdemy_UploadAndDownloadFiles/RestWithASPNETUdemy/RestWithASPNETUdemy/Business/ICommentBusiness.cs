using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface ICommentBusiness
    {
        CommentVO Create(CommentVO comment);
        CommentVO FindByID(long id);
        List<CommentVO> FindAll(); 
        List<CommentVO> FindByPostId(string Id);
        CommentVO Update(CommentVO comment);
        void Delete(long id);
    }
}
