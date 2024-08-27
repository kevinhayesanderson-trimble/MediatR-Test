using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Request
{
    internal interface ICommand<out TResponse> : IRequest<TResponse>
    {
    }
}
