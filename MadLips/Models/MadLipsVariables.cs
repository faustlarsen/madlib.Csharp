namespace MadLips.Models // using FriendLetter.Models; to access it
{
  public class MadlipStory 
  {
    public string Person1 { get; set; } // auto-implemented property
    public string Person2 { get; set; } // allow any Sender to create a letter to their friends.
    public string Animal { get; set; }
    public string Exclamation { get; set; }
    public string Verb { get; set; }
    public string Noun { get; set; }
  }
}
