using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Workker.Telemetria.InfraStructure.Persistence.SessionManagement;

namespace Workker.Telemetria.InfraStructure.Persistence.UnitOfWorkComponent
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ISessionBuilder _sessionBuilder;

        public UnitOfWork(ISessionBuilder sessionBuilder)
        {
            _sessionBuilder = sessionBuilder;
        }

        public void Begin()
        {
            if (ThereIsATransactionInProgress())
            {
                GetTransaction().Dispose();
            }

            GetSession().BeginTransaction();
        }

        private bool ThereIsATransactionInProgress()
        {
            return GetTransaction().IsActive || GetTransaction().WasCommitted || GetTransaction().WasRolledBack;
        }

        public void Commit()
        {
            ITransaction transaction = GetTransaction();
            if (!transaction.IsActive)
                throw new InvalidOperationException("Must call Start() on the unit of work before committing");

            transaction.Commit();
        }

        private ITransaction GetTransaction()
        {
            return GetSession().Transaction;
        }

        public void RollBack()
        {
            if (GetTransaction().IsActive)
            {
                GetTransaction().Rollback();
            }
        }

        public ISession GetSession()
        {
            return _sessionBuilder.GetSession();
        }

        public void Dispose()
        {
            GetSession().Dispose();
        }
    }
}
