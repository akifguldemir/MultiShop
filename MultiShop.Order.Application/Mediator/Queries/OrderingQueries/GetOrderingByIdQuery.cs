﻿using MediatR;
using MultiShop.Order.Application.Mediator.Results;

namespace MultiShop.Order.Application.Mediator.Queries.OrderingQueries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public int Id { get; set; }

        public GetOrderingByIdQuery(int id)
        {
            Id = id;
        }
    }
}
