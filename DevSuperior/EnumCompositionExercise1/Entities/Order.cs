using EnumCompositionExercise1.Entities.Enum;
using System.Globalization;
using System.Text;

namespace EnumCompositionExercise1.Entities;
internal class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Order()
    {
    }
    public Order(DateTime moment, OrderStatus orderStatus, Client client)
    {
        Moment = moment;
        OrderStatus = orderStatus;
        Client = client;
    }

    public void AddItems(OrderItem orderItem)
    {
        OrderItems.Add(orderItem);
    }
    public void RemoveItems(OrderItem orderItem)
    {
        OrderItems.Remove(orderItem);
    }
    public double Total()
    {
        double total = 0;
        foreach (OrderItem item in OrderItems)
        {
            total += item.SubTotal();
        }

        return total;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("\nORDER SUMMARY:");
        sb.Append("Order moment: ");
        sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
        sb.Append("Order status: ");
        sb.AppendLine(OrderStatus.ToString());
        sb.Append("Client: ");
        sb.Append(Client.Name);
        sb.Append(" (");
        sb.Append(Client.BirthDate.ToString("dd/MM/yyyy"));
        sb.Append(") - ");
        sb.AppendLine(Client.Email);
        sb.AppendLine("Order items: ");
        foreach (OrderItem item in OrderItems)
        {
            sb.Append(item.Product.Name);
            sb.Append(", $");
            sb.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantity: ");
            sb.Append(item.Quantity);
            sb.Append(", Subtotal: $");
            sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
        }
        sb.Append("Total price: $");
        sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));
        return sb.ToString();
    }
}