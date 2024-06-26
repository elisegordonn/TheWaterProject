using Microsoft.EntityFrameworkCore;

namespace TheWaterProject.Models;

public class EFOrderRepository : IOrderRepository
{
    private WaterProjectContext context;
                
    public EFOrderRepository(WaterProjectContext ctx) {
        context = ctx;
    }
                
    public IQueryable<Order> Orders => context.Orders
        .Include(o => o.Lines)
        .ThenInclude(l => l.Project);
                                                        
    public void SaveOrder(Order order) {
        context.AttachRange(order.Lines.Select(l => l.Project));
        if (order.OrderID == 0) {
            context.Orders.Add(order);
        }
        context.SaveChanges();
    }
}