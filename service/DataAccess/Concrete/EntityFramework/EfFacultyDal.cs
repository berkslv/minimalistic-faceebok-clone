using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfFacultyDal : EfEntityRepositoryBase<Faculty, HubContext>, IFacultyDal
    {
        
    }
}