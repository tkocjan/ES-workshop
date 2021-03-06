using System;
using System.Threading.Tasks;

namespace SampleProject.Infrastructure
{
    public interface IProvider<T>
    {
        Task<T> GetById(Guid id);
    }
}