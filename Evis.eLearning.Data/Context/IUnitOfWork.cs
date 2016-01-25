using Evis.eLearning.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evis.eLearning.Data
{
    /// <summary>
    /// Provides basic structure for a Unit of work
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commits the unit of work
        /// </summary>
        void Commit();

        /// <summary>
        /// Gets a repository by type
        /// </summary>
        /// <typeparam name="T">Type of repository</typeparam>
        /// <returns></returns>
        IRepository<T> GetRepository<T>() where T : class; 
    }
}
