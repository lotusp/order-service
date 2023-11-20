using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace com.tw.flyhigh.controller
{
    public class OrderController : ApiController
    {
        private readonly OrderServiceImpl orderServiceImpl;

        public OrderController(OrderServiceImpl orderServiceImpl)
        {
            this.orderServiceImpl = orderServiceImpl;
        }

        [HttpPost]
        public HttpResponseMessage createOrder([FromBody] CreateOrderDto createOrderDto)
        {
            Order order = orderServiceImpl.createOrder(createOrderDto);
            return Request.CreateResponse(HttpStatusCode.Created, order);
        }

        [HttpGet]
        public List<Order> getOrders(long userId)
        {
            return orderServiceImpl.getOrders(userId);
        }
    }
}
