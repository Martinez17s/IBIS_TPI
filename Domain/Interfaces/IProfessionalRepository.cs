using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProfessionalRepository
    {
        void Create(Professional entity);
        List<Professional> GetAll();
        Professional? GetById(int id);
    }
}
