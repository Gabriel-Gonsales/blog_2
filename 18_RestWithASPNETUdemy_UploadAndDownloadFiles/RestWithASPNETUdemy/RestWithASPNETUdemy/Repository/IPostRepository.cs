using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        //Person Disable(long id);
        List<Post> FindByTitle(string title);
    }
}
