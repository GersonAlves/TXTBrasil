using HGT.TxtBrasil.Domain.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workker.Telemetria.InfraStructure.Persistence.SessionManagement;

namespace HGT.TxtBrasil.Domain.Repository
{
    public abstract class BaseRepository
    {
        private ISession _session;

        public virtual ISession Session
        {//TODO:remover acoplamento
            get { return _session ?? (_session = new SessionBuilder().GetSession()); }
        }

        #region Métodos Genericos para acesso ao DB

        public BaseRepository()
        {

        }

        public BaseRepository(ISession session)
        {
            _session = session;
        }

        public virtual void Salvar(IAggregateRoot<Guid> root)
        {
            Session.SaveOrUpdate(root);
        }
        public virtual void SalvarEAtualizarSession(IAggregateRoot<Guid> root)
        {
            Session.SaveOrUpdate(root);
            Session.Flush();
        }

        public virtual void SalvarLista(List<IAggregateRoot<Guid>> roots)
        {
            foreach (var root in roots)
            {
                Session.SaveOrUpdate(root);
            }
        }

        public virtual void Deletar(IAggregateRoot<Guid> root)
        {
            Session.Delete(root);
        }

        public virtual IList<T> Todos<T>()
        {
            var objs = Session.CreateCriteria(typeof(T)).List<T>();
            return objs;
        }

        public virtual T Obter<T>(Guid id)
        {
            var obj = Session.Get<T>(id);
            return obj;
        }

        #endregion
    }
}
