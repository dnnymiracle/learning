string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");


/*You can find the length of a string using LENGTH. Length is a property of a string and it returns the number of characters in 
that string.*/


Console.WriteLine($The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($The name {secondFriend} has {secondFriend.Length} letters.");


/*For clarification and note - Console.WriteLine() writes text to the screen. So far we have learned how to declare variables and concatenate strings. 
 Console.WriteLine is what we call a "method." A method is a block of code that implements some action. It has a name, so you can access it. 
the trim method and related methods TrimStart and TrimEnd do that work. You can just use those methods to remove leading and trailing spaces.
(https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=4)
*/

string greeting = "     Hello World!        ";
ConsoleWriteLine($"[trimmedGreeting]");

string trimmedGreeting = greeting.TrimStart();
ConsoleWriteLine($"[{trimmedGreeting}]");


trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");


/*the square brackets [ and ] help visualize what the Trim, TrimStart and TrimEnd methods do. The brackets show where whitespace 
starts and ends. 
 also single line comments = ( // )  Multi Line Comments (/* */) XML Comments (///) */

 /*Replace - another method available to work with strings. replace searches for a substring and replaces it with different text. replace
 takes two parameters. these are strings between the parentheses. the first string is the text to search for. the second string is the text
 to replace it with. .re after the sayHello variable: */

 string sayHello = "Hello World!";
 Console.WriteLine(sayHello);
 sayHello = sayHello.Replace("Hello", "Greetings");
 Console.WriteLine(sayHello);

 /* two other useful methods make a string ALL CAPS or all lower case. Try the following code. Type it in to see how Intellisense 
 provides hints as you start to type To: */

 Console.WriteLine(sayHello.ToUpper());
 Console.WriteLine(sayHello.ToLower());

 /* the other part of a search and replace operation is to find text in a string. You can use the Contains method for searching. 
 it will tell you if a string contains a substring inside it. try following code to explore Contains: */

 string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));

/*the contains method returns a boolean value which tells you if the string you were searching for was found. A boolean stores either
a true or false value. When displayed as text output, they are capitalized: True and False, respectively. You'll learn more about boolean 
values in a later lesson. 
 ##My AdhD refuses to let me just "accept" things. So, I will also include my own research into exactly what microsoft is telling you...


 (Basic Mathematical Concepts J. David Brown Frank J. Palas Southern Methodist University D.C. Heath and Company Lexington, Massachusetts)
 (1970)

 Chapter I of this book is titled "Logic." Rightly so, computer programming is nothing more than logic. We make statements. We declare them true or false.


 Logic is a way of thinking or a chain of reasoning. Webster's New Collegiate Dictionary defines logic as: "The science that deals with the canons and 
 criteria of validity in thought and demonstration; the science of the formal principles of reasoning." Our book focuses on what is often called,
 symbolic logic. logic in which words are replaced by symbols (i.e. variables) which are manipulated to obtain certain desired results. 




