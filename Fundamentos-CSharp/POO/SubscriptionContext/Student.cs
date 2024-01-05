using POO.NotificationContext;
using POO.SharedContext;

namespace POO.SubscriptionContext
{
  public class Student : BaseContent
  {
    public Student()
    {
      Subscriptions = new List<Subscription>();
    }
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }

    public IList<Subscription> Subscriptions { get; set; }

    public void CreateSubscription(Subscription subscription)
    {
      if (IsPremium)
      {
        AddNotification(new Notification("Premium", "O aluno já possui uma inscrição ativa."));
        return;
      }
      Subscriptions.Add(subscription);
    }
    public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
  }
}