using HGT.TxtBrasil.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HGT.TxtBrasil.Domain.Repository
{
    public interface IRepositorio<T>
    {
        void SalvarEAtualizarContexto(IAggregateRoot<Guid> entidade);
        void Adicionar(IAggregateRoot<Guid> entidade);
        void AdicionarLista(List<IAggregateRoot<Guid>> entidades);
        void Remover(IAggregateRoot<Guid> entidade);
        T PorId(Guid id);
        IList<T> Todos();
        IList<T> Todas();

    }
}
