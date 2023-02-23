using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPostBusiness
    {
        PostVO Create(PostVO post);
        PostVO FindByID(long id);
        List<PostVO> FindByTitle(string title);
        List<PostVO> FindAll();
        PagedSearchVO<PostVO> FindWithPagedSearch(string title, string sortDirection, int pageSize, int page);
        PostVO Update(PostVO post);
        void Delete(long id);
    }
}
