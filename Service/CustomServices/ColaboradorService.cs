using CRUD_ONION_API.Domain.Models;
using CRUD_ONION_API.Repository.Inteface;
using CRUD_ONION_API.Service.Interface;

namespace CRUD_ONION_API.Service.CustomServices
{
    public class ColaboradorService : ICustomService<Colaboradores>
    {
        private readonly IRepository<Colaboradores> _colaboradoresRepository;
        public ColaboradorService(IRepository<Colaboradores> colaboradoresRepository)
        {
            _colaboradoresRepository = colaboradoresRepository;
        }

        public void Delete(Colaboradores entity)
        {
            try
            {
                if (entity != null)
                {
                    _colaboradoresRepository.Delete(entity);
                    _colaboradoresRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Colaboradores Get(int Id)
        {
            try
            {
                var obj = _colaboradoresRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Colaboradores> GetAll()
        {
            try
            {
                var obj = _colaboradoresRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(Colaboradores entity)
        {
            try
            {
                if (entity != null)
                {
                    _colaboradoresRepository.Insert(entity);
                    _colaboradoresRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Remove(Colaboradores entity)
        {
            try
            {
                if (entity != null)
                {
                    _colaboradoresRepository.Remove(entity);
                    _colaboradoresRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Colaboradores entity)
        {
            try
            {
                if (entity != null)
                {
                    _colaboradoresRepository.Update(entity);
                    _colaboradoresRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
