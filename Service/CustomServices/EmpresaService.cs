using CRUD_ONION_API.Domain.Models;
using CRUD_ONION_API.Repository.Inteface;
using CRUD_ONION_API.Service.Interface;

namespace CRUD_ONION_API.Service.CustomServices
{
    public class EmpresaService: ICustomService<Empresas>
    {
        private readonly IRepository<Empresas> _empresasRepository;
        public EmpresaService(IRepository<Empresas> empresasRepository)
        {
            _empresasRepository = empresasRepository;
        }

        public void Delete(Empresas entity)
        {
            try
            {
                if (entity != null)
                {
                    _empresasRepository.Delete(entity);
                    _empresasRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Empresas Get(int Id)
        {
            try
            {
                var obj = _empresasRepository.Get(Id);
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

        public IEnumerable<Empresas> GetAll()
        {
            try
            {
                var obj = _empresasRepository.GetAll();
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

        public void Insert(Empresas entity)
        {
            try
            {
                if (entity != null)
                {
                    _empresasRepository.Insert(entity);
                    _empresasRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Remove(Empresas entity)
        {
            try
            {
                if (entity != null)
                {
                    _empresasRepository.Remove(entity);
                    _empresasRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Empresas entity)
        {
            try
            {
                if (entity != null)
                {
                    _empresasRepository.Update(entity);
                    _empresasRepository.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
