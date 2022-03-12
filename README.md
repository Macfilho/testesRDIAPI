# testesRDIAPI
Done in Visual Studio 2019 , .net core 5.0, db sqlite, works https and Swagger 
crud creditcards, still in tests and enhacements

1 – API that receive customer card and save it on the db
Request information:
CustomerId - int
Card Number – long - max 16 characters
CVV – int - max 5 characters
Response information:
Registration date – Date now in UTC
Token – long – (Size of token may vary)
CardId - int
2 – API that validate that token based on data provided in the request
Request information:
CustomerId – int
CardId - int
Token – long – (Size of token may vary)
CVV – int - max 5 characters
Response information:
Validated – bool


Algorithm
The algorithm used to create the token is:
a) Get last 4 digits of card
b) Apply algorithm described below in Problem #1 and the number of rotations would be the
CVV number.
The algorithm to validate the token
1. If creation date of token is more than 30 min, return as not valid
2. Use the cardid to locate the card number
3. If customer is not the owner of the card, return as not valid
4. Print the card number in the console
5. Process the algorithm described above in creation process to create the token again and
compare with the token received in the request, if match return true otherwise false.
