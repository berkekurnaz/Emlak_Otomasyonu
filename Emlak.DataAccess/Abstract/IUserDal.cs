using Emlak.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.DataAccess.Abstract
{
    public interface IUserDal
    {
        List<User> GetAll();
        List<User> GetAllWithFilter(Expression<Func<User, bool>> filter);
        List<User> GetById(string Id);
        void Add(User user);
        void Update(User user, User newUser);
        void Delete(User user);
        bool Login(User user);
    }
}
