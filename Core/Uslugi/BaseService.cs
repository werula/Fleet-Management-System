using Core.Repozytoria;

namespace Core.Uslugi
{
    public class BaseService<T> where T:class
    {
        public BaseRepo<T> Repository { get; set; }

        public BaseService(BaseRepo<T> _repository)
        {
            this.Repository = _repository;
        }
    }

    public class BaseServiceM2M<T> where T : class
    {
        public BaseRepoM2M<T> Repository { get; set; }

        public BaseServiceM2M(BaseRepoM2M<T> _repository)
        {
            this.Repository = _repository;
        }
    }
}
