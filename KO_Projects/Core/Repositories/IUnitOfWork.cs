using Microsoft.AspNetCore.Mvc;
namespace KO_Projects.Core.Repositories;


    public interface IUnitOfWork
    {
        IUserRepository User { get; }

        IRoleRepository Role { get; }
    }