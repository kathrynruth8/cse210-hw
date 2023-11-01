public class ReflectingActivity : Activity{
    private string _reflectingIntro = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private List<string> _reflectingPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

    };


    public ReflectingActivity(string activityName, int activityDuration)
        :base(activityName, activityDuration)
    {

    }
// 1. The activity should begin with the standard starting message and prompt for the duration that is used by all activities.

// 2. The description of this activity should be something like: "This activity will help you reflect on times in your 
// life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."

// 3. After the starting message, select a random prompt to show the user such as:
        // - Think of a time when you stood up for someone else.
        // - Think of a time when you did something really difficult.
        // - Think of a time when you helped someone in need.
        // - Think of a time when you did something truly selfless.

// 4. After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. 
// These questions should be pulled from a list such as the following:
        // - Why was this experience meaningful to you?
        // - Have you ever done anything like this before?
        // - How did you get started?
        // - How did you feel when it was complete?
        // - What made this time different than other times when you were not as successful?
        // - What is your favorite thing about this experience?
        // - What could you learn from this experience that applies to other situations?
        // - What did you learn about yourself through this experience?
        // - How can you keep this experience in mind in the future?

// 5. After each question the program should pause for several seconds before continuing to the next one. 
// While the program is paused it should display a kind of spinner.

// 6. It should continue showing random questions until it has reached the number of seconds the user specified for the duration.

// 7. The activity should conclude with the standard finishing message for all activities.
}