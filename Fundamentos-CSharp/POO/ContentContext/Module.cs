using POO.ContentContext;
using POO.SharedContext;
namespace POO.ContentContext
{
  public class Module : BaseContent
  {
    public Module()
    {
      Lectures = new List<Lecture>();
    }
    public int Order { get; set; }
    public string Title { get; set; }

    public IList<Lecture> Lectures { get; set; }
  }
}
