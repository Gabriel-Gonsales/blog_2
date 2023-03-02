using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;
using System.Xml.Linq;

namespace RestWithASPNETUdemy.Business.Implementations
{

    public class PostBusinessImplementation : IPostBusiness
    {

        private readonly IPostRepository _repository;

        private readonly PostConverter _converter;

        public PostBusinessImplementation(IPostRepository repository)
        {
            _repository = repository;
            _converter = new PostConverter();
        }

        // Method responsible for returning all people,
        public List<PostVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one post by ID
        public PostVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new post
        public PostVO Create(PostVO post)
        {
            var postEntity = _converter.Parse(post);
            postEntity = _repository.Create(postEntity);
            return _converter.Parse(postEntity);
        }

        // Method responsible for updating one post
        public PostVO Update(PostVO post)
        {
            var postEntity = _converter.Parse(post);
            postEntity = _repository.Update(postEntity);
            return _converter.Parse(postEntity);
        }

        // Method responsible for deleting a post from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public PagedSearchVO<PostVO> FindWithPagedSearch(string title, string sortDirection, int pageSize, int page)
        {
            var sort = (!string.IsNullOrWhiteSpace(sortDirection)) && !sortDirection.Equals("desc") ? "asc" : "desc";
            var size = (pageSize < 1) ? 10 : pageSize;
            var offset = page > 0 ? (page - 1) * size : 0;

            string query = @"select * from posts p where p.enabled = 1";
            if (!string.IsNullOrWhiteSpace(title)) query = query + $" and p.titulo like '%{title}%' ";
            query += $" order by p.id {sort} limit {size} offset {offset}";

            string countQuery = @"select count(*) from posts p where p.enabled = 1 ";
            if (!string.IsNullOrWhiteSpace(title)) countQuery = countQuery + $" and p.titulo like '%{title}%' ";

            var posts = _repository.FindWithPagedSearch(query);
            int totalResults = _repository.GetCount(countQuery);

            return new PagedSearchVO<PostVO>
            {
                CurrentPage = page,
                List = _converter.Parse(posts),
                PageSize = size,
                SortDirections = sort,
                TotalResults = totalResults
            };
        }
        public List<PostVO> FindByTitle(string title)
        {
            return _converter.Parse(_repository.FindByTitle(title));
        }
    }
}

