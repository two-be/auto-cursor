using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCursor.Library;

public class MorningGreetings
{
    private readonly List<string> _greetings =
    [
        "Good morning! ☀️ Hope you have a fantastic start to your day.",
        "Morning! 😊 Wishing you a wonderful day ahead.",
        "Hi there! 🌞 Good morning to you.",
        "ทำงานดีดีนะ..🙂",
        "Morning! 😄 Hope today brings you lots of joy.",
        "Good morning! 🌸 May your day be filled with positivity.",
        "Hi! 🌼 Wishing you a bright and beautiful morning.",
        "Good morning! 🌅 Hope your day is off to a great start.",
        "Morning! 💼 Here's to a productive day.",
        "Good morning! ✨ Sending you good vibes for the day.",
        "Hi there! 🌞 Hope you have an amazing morning.",
        "Good morning! 🌟 Let's make today awesome.",
        "Morning! 🌻 Wishing you a day full of smiles.",
        "Good morning! 😌 Hope you slept well and feel refreshed.",
        "Hi! 🌈 Good morning and have a fantastic day.",
        "Good morning! 🌄 Ready for a new day full of possibilities?",
        "Morning! 🌷 Hope your day is as wonderful as you are.",
        "Good morning! 🌞 May your day be bright and successful.",
        "Hi there! 🌺 Good morning and best wishes for today.",
        "Good morning! 🎉 Let's make today unforgettable.",
        "Morning! ☕ Hope you have a great start to your day.",
        "Good morning! 😊 Wishing you a day full of happiness.",
    ];

    public string GetRandomGreeting()
    {
        var rng = new Random();
        var index = rng.Next(_greetings.Count);
        return _greetings[index];
    }
}
