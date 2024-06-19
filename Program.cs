using OpenAI.Chat;

ChatClient client = new (model: "gpt-3.5-turbo", Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

Console.WriteLine("Welcome to the OpenAI Chat Client! Please type your message below:");
string input = Console.ReadLine();
UserChatMessage userMessage = new (input);

ChatCompletion completion = client.CompleteChat(userMessage);

Console.WriteLine($"[AI]: {completion}");