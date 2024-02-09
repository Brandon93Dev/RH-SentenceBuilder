# RH-SentenceBuilder

This web application enables users to dynamically construct sentences by selecting words based on various word types such as Noun, Verb, Adjective, Adverb, Pronoun, Preposition, Conjunction, Determiner, and Exclamation. Using a user-friendly interface built with Angular (Seperate project that interacts with this one) individuals can seamlessly choose a word type and then select specific words from populated lists associated with each type.

Once users have crafted their sentences by adding chosen words, they can submit their creations to the backend (this project). The backend connects to a SQL database, plays a crucial role. It facilitates this process by providing RESTful services, allowing the frontend to make a GET call to retrieve word lists and a POST call to submit new sentences.

The frontend strictly adheres to the absence of hardcoded values, ensuring flexibility and adaptability.

Furthermore, the backend not only handles the submission of sentences but also manages the retrieval of previously submitted sentences. The architecture ensures that only the backend can connect to the database, maintaining security and separation of concerns. Overall, the application provides an intuitive and robust platform for constructing, submitting, and revisiting creative sentences.




