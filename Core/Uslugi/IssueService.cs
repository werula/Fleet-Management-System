using Core.Repozytoria;
using Core.Uslugi.Interfejsy;
using Domena.Models;

namespace Core.Uslugi
{
    public class IssueService : BaseService<Issue>, IIssueService
    {
        public IssueService() : base(new IssueRepository())
        {

        }

        public Issue Create(Issue row)
        {
            return base.Repository.Create(row);
        }
        public bool Delete(int id)
        {
            return base.Repository.Delete(id);
        }

        public Issue[] GetArray()
        {
            return base.Repository.GetArray();
        }

        public Issue GetSingle(int id)
        {
            return base.Repository.GetSingle(id);
        }

        public Issue Update(Issue row)
        {
            return base.Repository.Update(row);
        }
    }
}

