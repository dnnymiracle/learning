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
 log.ic lojik - log. abbr. 1. The study of the principles of reasoning, especially of the structure of propositions as distinguished from their content and of 
 method and validity in deductive reasoning. 2. a. A system of reasoning: Aristotle's logic. b. A mode of reasoning: By that logic, we should sell the company tommorow. c. 
 The formal, guiding principles of a discipline, school, or science. 3. Valid reasoning: Your paper lacks the logic between an element and the whole in a set of objects, 
 individuals, principles, or events: There's a certain logic to the motion of rush hour traffic. 5. Computer Science. 
 a. The nonarithmetic operations performed by a computer, such as sorting, comparing, and matching, that involve yes-no decisions. b. Computer circuitry. c. Graphic 
 representation of computer circuitry. [Middle English, from Old French logique, from Latin logica, from Greek logike (tekhne), (art)of reasoning, logic, feminine logikos, 
 of reasoning, from logos, reason. "american heritage dictionary of english language. 3rd ed. ]

 Aristotle used "logos" as part of his three principles of rhetoric in speech and argument. Logos is a rational form of discourse that relies on inductive and 
 deductive reasoning.  λόγος in greek. Aristotle basically invented this word, he was the first author to coin the term. Both Plato and Aristotle used the term logos 
 along with rhema to refer to sentences and propositions. the ancient greek romanized is logos lit. word, discourse, or reason' i.e. "I Say' which is cognate with Latin: 
 lex, lit. 'law.' The word derives from a Proto-Indo-European root. leg, which can have the meanings "i put in order, arrange, gather, choose, count, reckon, discern, say,
 speak." In modern usage it typically connotates "account", "measure", "reason", or "discourse." Earlier I was wrong in saying Aristotle coined the term, it was first used 
 by Heraclitus (535 - 475 BC) he used the term as a principle of order and knowledge. Sophists used the term to mean "discourse." Aristotle defined it further and gave us 
 the outcome we have today. ---Diving further, Aristotle viewed logos as the very soul. The very perfecting of our higher selves. Logos was a term used in the Gospel of John
 but was ultimately, undefined until later on by Martin Luther and Jerome. 


 Enough with the philosophy, 

 Logic studies arguments, which consist of a set of premises that leads to a conclusion. ^ - (and) ->(if...then) logic studies valid forms of inference like modus ponens
 which is a term in propositional logic modus ponendo ponens implication elimination, or affirming the antecedent, is a deductive argument form and rule of inference. It 
 can be summarized as "P implies Q. P is true. Therefore, Q must also be true." 

 Modus ponens is a mixed hypothetical syllogism and is closely related to another valid form of argument, modus tollens. Both have apparently similar but invalid forms: 
 affirming the consequent and denying the antecedent. Constructive dilemma is the disjunctive version of modus ponens. Theophrastus coined these terms. Modus ponens and modus tollens
 are the standard patterns of inference that can be applied to derive chains of conclusions that lead to the desired goal. 

 The form of a modus ponens argument is a mixed hypothetical syllogism - two premises and a conclusion: 

 1. If P, then Q. 
 2. P 
 3. Therefore, Q. 

 The first premise is a conditional ("if-then") claim, namely that P implies Q. THe second premise is an assertion that P, the antecedent of the conditional claim, is the case.
 From these two premises it can be logically concluded that Q, the consequent of the conditional claim, must be the case as well. 



 #okay, i've veered way off path. 


 As the father of western logic, Aristotle was the first to develop a formal system for reasoning. He observed that the deductive validity of any argument can be
determined by its structure rather than its content. Mathematics is not possible without a basic assumption of how we derive answers from questions. Aristotles 4th 
century logic.

(mathematics an illustrated history of numbers edited by Tom Jackson)
when we construct a mathematical equation we assume that its components will interact with each other in clear, predetermined ways. Thus, the result we obtain will be repeatable.
it will always be the same however many times we perform the calculation, as will other problems like it that rely on the same set of presumably correct assumptions. Therefore, at the center of mathematics. 
The assumption that if a specific cause or relationship produces a certain result it will do so in every identical instance. Logic was defined almost 2400 years ago by Aristotle
who set down the parameters of this philosophy of viewing the world around him in a collection of works known as the Organon, meaning "the Instrument." Central to Aristotle's logic was deduction. In his words. "
A deduction is speech (logos) in which certain things having been supposed, something different from those supposed results of necessity because of their being so." 
What is supposed are the premises of the argument, and that which results of necessity is the conclusion. This process is known as a syllogism, from the Greeek word for "inference." Syllogism that result in incorrect conclusions are 
called fallacies. Aristotle showed that there are 256 vpossible versions most of which are fallacies. in which certain things having been supposed, something different from those supposed results of necessity because of their being so." 
What is supposed are the premises of the argument, and that which results of necessity is the conclusion. This process is known as a syllogism, from the Greeek word for "inference." Syllogism that result in incorrect conclusions are 
called fallacies. Aristotle showed that there are 256 vpossible versions most of which are fallacies.  


// and now we return to the book. Basic Mathematical Concepts. I will clean this up and organize it into a website later on, maybe. 

//

True and False Statements. 

"Our Main interest in certain word statements will be the results of combining these statements in various ways. First of all we consider a simple declarative sentences,
i.e, declarative sentences which express a single thought. We restrict elves further to t hose sentences which are either "true" or "false," but not both. We will call 
 such sentences <i>statements</i> It should be noted that the words "proposition" and "true-false statement" (abbreviated as "tf-statement") are used interchangeably with
the word "statement." Now, exactly what do we mean by a true or false statement?

Many sentences leave little question as to truth or falsity. So then, what is "truth"? What is "falsity"?   We do not propose to answer this question. One could write an entire philosophical
treatise on the subject. In fact, this has been done! However, in our work we do not need to have a perfect idea of what truth is. *NONSENSE* TO DUCKDUCKGOWEGO

Opposites
Mutually exclusive
Truth is the property of sentences, assertions, beliefs, thoughts, or propositions that are said to agree with the facts or to state what is the case
Falsity is a fault
Truth and falsity are said to be the truth values of propositions
A statement cannot be true and false at the same time
If the statement can be proven true, then it cannot be false

One of the most powerful types of proof in mathematics is proof by contradiction or an indirect proof. It is powerful because it can be used to prove any statement,
in several fields of mathematics. The structure is simple: assume the statementto be proven is false, and work to show its falsity until the result of that assumption is
a contradiction. Proof by contradiction in logic and mathematics is a proof that determines the truth of a statement by assuming the proposition is false, then working 
to show its falsity until the result of that assumption is a contradiction.

//A statement cannot be true and false at the same time

If the statement can be proven true, then it cannot be false

If the statement can be proven false, then it cannot be true

If the statement cannot be proven true, then it is false

If the statement cannot be proven false, then it is true'

Pragmatic theories of truth are usually associated with C.S. Pierces proposal that true beliefs will be accepted "at the end of inquiry". 
William James proposed truth be defined in terms of utility. More broadly however, pragmatic theories of truth focus on the connection between truth and epistemic practices
notably practices of inquiry and assertion. 


To be read later (Charles Sanders Peirce 1839-1914) generally recognized for first proposing a "pragmatic" theory of truth. Peirces pragmatic theory of truth is a byproduct of 
his pragmatic theory of meaning. IN a frequently-quoted passage. "How to Make our Ideas Clear."(1878) Pierce writes that, in order to pin down the meaning of a concept, we must:
"Consider what effects, which might conceivably have practical bearings, we conceive the object of our conception to have. Then, our conception of these effects is the whole of our
conception of the object. (1878[1986:266]) 


William James (1842-1910) has a series of lectures and articles...Pragmatism: A New Name for Some Old Ways of Thinking (1907) James writes that: 
"Ideas... become true just in so far as they help us get into satisfactory relation with other parts of our experience, to summarize them and get about among them by conceptual
short-cuts instead of following the interminable succession of particular phenonmena. (1907 [1975:34])

True ideas, James suggests are like tools. they make us more efficient by helping us do the things that need to get done. 


Deweys Pragmatic Theory of Truth - 1859 - 1952 - 527 page Logic: The Theory of Inquiry (1938 [2008]) 










