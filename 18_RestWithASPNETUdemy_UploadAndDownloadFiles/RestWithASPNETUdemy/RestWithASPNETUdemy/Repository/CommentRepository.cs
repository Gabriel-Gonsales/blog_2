using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(MySQLContext context) : base (context) { }

        public List<Comment> FindByPostId(string Id)
        {
            if (!string.IsNullOrWhiteSpace(Id))
            {
                return _context.Comments.Where(
                    p => p.PostId.Equals(int.Parse(Id))).ToList();
            }
            return null;
        }
    }
}
