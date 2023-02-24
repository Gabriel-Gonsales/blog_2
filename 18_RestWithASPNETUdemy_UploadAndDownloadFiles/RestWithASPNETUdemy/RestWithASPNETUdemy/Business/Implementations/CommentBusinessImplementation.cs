using RestWithASPNETUdemy.Data.Converter.Implementations;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Utils;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;
using System.Xml.Linq;

namespace RestWithASPNETUdemy.Business.Implementations
{

    public class CommentBusinessImplementation : ICommentBusiness
    {

        private readonly ICommentRepository _repository;

        private readonly CommentConverter _converter;

        public CommentBusinessImplementation(ICommentRepository repository)
        {
            _repository = repository;
            _converter = new CommentConverter();
        }

        // Method responsible for returning all people,
        public List<CommentVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one comment by ID
        public CommentVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new comment
        public CommentVO Create(CommentVO comment)
        {
            var commentEntity = _converter.Parse(comment);
            commentEntity = _repository.Create(commentEntity);
            return _converter.Parse(commentEntity);
        }

        // Method responsible for updating one comment
        public CommentVO Update(CommentVO comment)
        {
            var commentEntity = _converter.Parse(comment);
            commentEntity = _repository.Update(commentEntity);
            return _converter.Parse(commentEntity);
        }

        // Method responsible for deleting a comment from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<CommentVO> FindByPostId(string Id)
        {
            return _converter.Parse(_repository.FindByPostId(Id));
        }
    }
}

