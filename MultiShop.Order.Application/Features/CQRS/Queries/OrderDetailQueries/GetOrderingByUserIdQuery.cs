using MediatR;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Mediator.Results.OrderingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries
{
    public class GetOrderingByUserIdQuery : IRequest<List<GetOrderingByUserIdQueryResult>>
    {
      
    }
}
