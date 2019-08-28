*[The 4th Lounge<C++> Game Marmalade](http://chat.stackoverflow.com/rooms/73528/lounge-game-marmalade) presents...*

# XWord

Your best friend is in danger! An evil mastermind with a PhD in cryptosomething keeps him prisoner inside a cell that can only be opened by entering a secret 4-letter code. The evil mastermind is a total asshole, but he does value skills, so here's the deal: he will start a timer and present you with a board that contains the secret code in a slightly obfuscated form. 

If you will be able to figure out the code before the timer expires, good for you - and for your friend; otherwise, the cell where your friend is kept will be instantly filled with water, struck by a bolt, set on fire, compressed to the size of 1 cube millimeter, and eaten by a shark. Chances are your best friend won't survive that. Would you let that happen? Of course not!

So here's a few things you'd better keep in mind:

- The board mostly contains random letters, but it also contains a **secret sentence** which is 50 to 100 characters long (spaces are omitted, and no punctuation is present in the original sentence). 
- The secret sentence can be obtained by following a **snake-like path** in the table: given a starting position, the sequence of letters in the sentence may proceed in any of the four directions *up*, *down*, *left*, and *right* (no diagonal steps are allowed).
- In a bout of compassion, the evil mastermind gets you to **choose one word** that shall appear in the secret sentence, and also provides you with a list of candidate words to pick from - if you choose a word which is not from the list, please pick a meaningful one, or the game might hang. Oh, and it might take a while before the mastermind comes up with a challenge for you, so don't be too impatient after you've pressed the *New Challenge!* button.
- In a second bout of compassion (don't get used to it), the evil mastermind is giving you the possibility of **letting the secret sentence be randomly rearranged** in the game board. If you find it too hard to spot familiar words in the grid as originally presented, you may consider taking advantage of this option (by clicking the *Rescramble* button). 
- The secret sentence has 4 of its letters replaced (in order) by the letters 'S', 'H', 'I', and 'T'. Your task is to figure out what the original letters are: these letters happen to form a **4-letter code** that you have to type before the timer expires. If the code is correct, your friend will be freed up, and a positive score will be assigned to you based on the difficulty of the challenge. 

# Notes

XWord takes the secret sentences by performing HTTP requests to the Web Site http://bnc.bl.uk/BLquery.php. The potential 4-letter codes are taken from a file that must be located in the same folder as xword's executable.

Oh, and **you can cheat** if you really need to! Just left-click on the countdown edit box and press *Alt*+*Ctrl*+*Shift*+*C*. The secret code will appear in a dialog box.
