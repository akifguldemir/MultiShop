using MediatR;
using MultiShop.Order.Application.Mediator.Results.OrderingResults;

namespace MultiShop.Order.Application.Mediator.Queries.OrderingQueries
{
    public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
    {
    }
}
