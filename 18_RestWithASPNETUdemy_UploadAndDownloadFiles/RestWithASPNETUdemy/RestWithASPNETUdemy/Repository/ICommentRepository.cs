using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface ICommentRepository : IRepository<Comment>
    {
        List<Comment> FindByPostId(string Id);
    }
}
