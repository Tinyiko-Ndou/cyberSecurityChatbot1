# cyberSecurityChatbot1

Description
This is a console-based chatbot developed in C# that helps users learn about basic cybersecurity practices.  
The chatbot interacts with the user, answers questions, and provides advice on topics like passwords, phishing, and safe browsing.

 Features
- Plays a welcome sound on startup
- Displays ASCII art banner
- Accepts user input and responds interactively
- Provides cybersecurity tips
- Runs continuously until the user exits

How to Run
1. Open the project in Visual Studio
2. Make sure `welcome.wav` is in the project directory
3. Build and run the program
4. Enter your name
5. Ask questions or type `exit` to quit

 How It Works
The chatbot uses a loop to continuously accept user input.  
It processes the input by converting it to lowercase and checking for keywords using `if-else` statements.  
Based on the detected keywords, it returns predefined responses related to cybersecurity topics.
