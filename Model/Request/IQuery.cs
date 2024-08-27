using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Request
{
    internal interface IQuery<out IQueryResult> :IRequest<IQueryResult>
    {
    }

    internal interface IQueryResult
    {
    }
}
