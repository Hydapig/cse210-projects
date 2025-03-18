using System;

public class PromptGenorator
{
    public List<string> _prompts = new List<string>() {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?"
    };

    private List<string> _usedPrompts = new List<string>();

    public string GetRandomPrompt()
    {
        if (_prompts.Count == 0)
        {
            // Reset if all prompts have been used
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }

        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        string selectedPrompt = _prompts[randomIndex];

        // Move the selected prompt from _prompts to _usedPrompts
        // This makes sure all prompts from the list are used before repeating
        _prompts.RemoveAt(randomIndex);
        _usedPrompts.Add(selectedPrompt);

        return selectedPrompt;
    }

}