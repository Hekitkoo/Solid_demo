namespace Shop4_5.Interfaces;

public interface IEmailNotification
{
    public void SendEmail(Order order);
}