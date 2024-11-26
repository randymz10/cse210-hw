public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(new char[] { ' ' });
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int length = _words.Count;
        for (int i = 0; i < numberToHide; i++)
        {
            int randomNumber = random.Next(0, length);
            _words[randomNumber].Hide();
        }
    }
    public string GetDisplayText()
    {
        string[] words = _words.Select(word => word.GetDisplayText()).ToArray();
        string text = String.Join(" ", words);
        return $"{_reference.GetDisplayText()} {text}";
    }
    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                isCompletelyHidden = false;
            }
        }
        return isCompletelyHidden;

    }
}
