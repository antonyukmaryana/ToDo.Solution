using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Item
  {
    private string _word;
    private string _sentence;
    private int _count;
    private static List<Item> _instances = new List<Item> {};

    public Item(string word, string sentence, int count)
    {
      _word = word;
      _sentence = sentence;
      _count = count;
    }

    public string Word
    {
      get => _word;
      set => _word = value;
    }

    public string Sentence
    {
      get => _sentence;
      set => _sentence = value;
    }

    public int Count
    {
      get => _count;
      set => _count = value;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
