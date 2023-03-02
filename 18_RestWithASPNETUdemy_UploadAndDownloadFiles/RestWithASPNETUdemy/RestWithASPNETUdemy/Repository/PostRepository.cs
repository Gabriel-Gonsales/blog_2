using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Repository
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        public PostRepository(MySQLContext context) : base (context) { }

        /*public Post Disable(long id)
        {
            if (!_context.Persons.Any(p => p.Id.Equals(id))) return null;
            var user = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (user != null)
            {
                user.Enabled = false;
                try
                {
                    _context.Entry(user).CurrentValues.SetValues(user);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return user;
        }*/

        public List<Post> FindByTitle(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                return _context.Posts.Where(
                    p => (p.Title.Contains(title)) && p.Enabled.Equals(1)).ToList();
            }
            else{
                return _context.Posts.Where(
                    p => p.Enabled.Equals(1)).ToList();
            }
        }
    }
}
