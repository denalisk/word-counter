### SPECIFICATIONS FOR WORD COUNTER APP

##### Requirements
* Take in a string and return the number of times a selected word appears in the string

##### Spec List

* Take a string as input from the user and return it. This will test if the program can successfully grab the large string input from the user.
    * **INPUT:** "This is a string"
    * **OUTPUT:** "This is a string"


* Take a single word string ("target word") as input from the user and return it. This will test to see if the program can grab the target word input from the user successfully.
    * **INPUT:** "string"
    * **OUTPUT:** "string"


* Take a string from the user and return a series of individual words. This will see if the program can successfully break the large string into discreet segments.
    * **INPUT:** "This is a string"
    * **OUTPUT:** ["This" "is" "a" "string"]


* Check to see if the first word in the series of words is the target word. This will check to see if the program can accept the series of words as an input and build the base functionality for checking the target word against others.
    * **INPUT:** ["This" "is" "a" "string"], "string"
    * **OUTPUT:** false


* Check to see if the target word is contained in the series of words. This will test if the program can find the target word in a large number of words.
    * **INPUT:** ["This" "is" "a" "string"], "string"
    * **OUTPUT:** true


* Count the number of time the target word found a match. This will check to see if the program can return the number of times a word appears in a string.
    * **INPUT:** ["This" "is" "a" "string"], "string"
    * **OUTPUT:** 1
