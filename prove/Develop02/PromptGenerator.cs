public class PromptGenerator
{
    public List<String> _prompts = new List<string>();
    public String GetRandomPrompt()
    {
        int randomNum = new Random().Next(5);

        return _prompts[randomNum];
    }
}