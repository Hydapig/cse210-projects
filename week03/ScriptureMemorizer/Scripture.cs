public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (var t in text.Split(" ", StringSplitOptions.RemoveEmptyEntries))
        {
            _words.Add(new Word(t));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsToHide = Math.Min(numberToHide, _words.Count(w => !w.IsHidden()));

        HashSet<int> hiddenIndexes = new HashSet<int>();

        while (hiddenIndexes.Count < wordsToHide)
        {
            int index = random.Next(0, _words.Count);
            if (!hiddenIndexes.Contains(index) && !_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenIndexes.Add(index);
            }
        }
    }
    
    
    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}