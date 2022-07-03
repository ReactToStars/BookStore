using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
        }

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

        public void UpdateStatus(int id, string orderStatus, string? paymentStatus = null)
        {
            var orderFormDb = _db.OrderHeaders.FirstOrDefault(x => x.Id == id);
            if(orderFormDb != null)
            {
                orderFormDb.OrderStatus = orderStatus;
                if(paymentStatus != null)
                {
                    orderFormDb.PaymentStatus  = paymentStatus;
                }
            }
        }

        public void UpdateStripePaymentID(int id, string sessionId, string paymentIntentId)
        {
            var orderFormDb = _db.OrderHeaders.FirstOrDefault(x => x.Id == id);

            orderFormDb.SessionId = sessionId;
            orderFormDb.PaymentIntentId = paymentIntentId;
        }
    }
}
