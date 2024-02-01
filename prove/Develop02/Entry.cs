using System;
using System.Collections.Generic;

public class Entry {
    public DateTime CurrentDate = DateTime.Now;
    public string _formattedEntry = "";
    private List<string> questions;

    public Entry() {
        questions = new List<string>() {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What do I want to do differently tomorrow?",
            "What programming concept should I learn next?",
            "What are my thoughts on the philisophical existentialism of humanity?"
        };
    }

    public string GetNextQuestion() {
        var _random = new Random();
        int _randomQuestion = _random.Next(questions.Count);
        return questions[_randomQuestion];

    }
}
