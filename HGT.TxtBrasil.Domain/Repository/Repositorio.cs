using HGT.TxtBrasil.Domain.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Repository
{
    public class Repositorio<T> : BaseRepository, IRepositorio<T>
    {
        public Repositorio()
        {

        }

        public Repositorio(ISession session)
            : base(session)
        {

        }
        public void SalvarEAtualizarContexto(IAggregateRoot<Guid> entidade)
        {
            base.SalvarEAtualizarSession(entidade);
        }

        public void Adicionar(IAggregateRoot<Guid> entidade)
        {
            base.Salvar(entidade);
        }

        public void AdicionarLista(List<IAggregateRoot<Guid>> entidades)
        {
            base.SalvarLista(entidades);
        }

        public void Remover(IAggregateRoot<Guid> entidade)
        {
            base.Deletar(entidade);
        }

        public T PorId(Guid id)
        {
            return base.Obter<T>(id);
        }

        public IList<T> Todos()
        {
            return base.Todos<T>();
        }

        public IList<T> Todas()
        {
            return base.Todos<T>();
        }


        public void Refresh(IAggregateRoot<Guid> clienteEspelho)
        {
            base.Session.Refresh(clienteEspelho);
        }
    }
}
