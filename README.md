# Guess Me 🤓

This is project is a part of my **C# Marathon** I am doing 15 C# projects 😋 using some instructions given in [this blog](https://dev.to/nerdjfpb/15-c-project-ideas-beginner-to-expert-with-tutorial-iio). This blog has given out 15 C# Projects ideas to fallow and improve skills 🦾

This is the first C# Application I selected from those 15.

## This a C# WinForms game - Guess Me

<img src="./screenshot.png" />

If you have done some game projects in your favourite language, you may have probably interfered a project called _Guess Number_. This is a improved version of that game 😁

### Game flows like this

The computer randomly selects a number between 0 and 101. Player has 6 chances to guess the number. If the number entered by user is higher than the computer selected number, a message like "You guessed too high" is displayed. Otherwise something like "You guessed too small" is displayed.

The computer also guess the number 😮 The player can guess the number before computer does and win the game! If both guess the number same time, it is a draw 😐

### Special Features of this App

- Has a GUI 😏
- Computer also plays against the player 🤗
- Input textbox accepts only integers 🤔

Player press _enter_ to submit the number

Usually this App comes as a _CLI Application_. I gave it a _UI_.

The computer also **guess** the number. He reduce or increase half by half until the correct number is selected. If the computer can avoid using the numbers player already has used 😱 computer itelligance can be improved more

This game can be more improved in this way, but I do not have much time ☹

- First player throws a number then computer's turn and so on...
- Set a timer ⏰ for each round
