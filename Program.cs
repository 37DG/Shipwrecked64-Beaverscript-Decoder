Dictionary<char, char> decoder = new Dictionary<char, char>
{
	{ 'a', 'b' },
	{ 'b', 'a' },
	{ 'c', 'd' },
	{ 'd', 'c' },
	{ 'e', 'f' },
	{ 'f', 'e' },
	{ 'g', 'h' },
	{ 'h', 'g' },
	{ 'i', 'j' },
	{ 'j', 'i' },
	{ 'k', 'l' },
	{ 'l', 'k' },
	{ 'm', 'n' },
	{ 'n', 'm' },
	{ 'o', 'p' },
	{ 'p', 'o' },
	{ 'q', 'r' },
	{ 'r', 'q' },
	{ 's', 't' },
	{ 't', 's' },
	{ 'u', 'v' },
	{ 'v', 'u' },
	{ 'w', 'x' },
	{ 'x', 'w' },
	{ 'y', 'z' },
	{ 'z', 'y' }
};


bool isRunning = true;
Console.WriteLine("This program encodes/decodes BeaverScratch provided in various areas throughout Shipwrecked64. \n" +
			   "Enter the sentence you would like to convert or type quit");
while (isRunning)
{
	Console.Write("> ");

	var userInput = Console.ReadLine();
	string output = "";

	if (userInput.ToLower() == "quit")
	{
		isRunning = false;
		break;
	}

	if (userInput.ToLower() == "")
	{
		continue;
	}

	if (userInput != null)
	{
		List<bool> isCapitalized = new List<bool>();
		foreach (char letter in userInput)
		{
			string strLetter = letter.ToString();
			isCapitalized.Add(strLetter.Equals(strLetter.ToUpper()));
		}

		int counter = 0;
		foreach (char letter in userInput.ToLower())
		{
			char outLetter;
			bool isInDict = decoder.TryGetValue(letter, out outLetter);

			if (isInDict && isCapitalized[counter])
			{
				output += outLetter.ToString().ToUpper();
			}
			else if (isInDict)
			{
				output += outLetter.ToString();
			}
			else
			{
				output += letter.ToString();
			}
			counter++;
		}
	}


	Console.WriteLine(output);
}

