- CQRS stands for Command Query Responsibility Segregation, and it is a design pattern used in software development to separate the responsibility of reading data from that of writing data
- Command handlers receive commands and are responsible for updating the write model of the system.
- Query handlers receive queries and are responsible for retrieving data from the read model of the system.

By separating the read and write models, CQRS can provide several benefits:

+ Improved performance: Since the read model is optimized for reading data, it can be designed to provide fast access to the data that is needed for queries.
+ Improved scalability: The read and write models can be scaled independently, allowing for better performance and availability of the system as a whole.
+ Improved maintainability: The separation of concerns provided by CQRS can make it easier to reason about and maintain the application.

![image](https://user-images.githubusercontent.com/48196420/221789839-34c592dd-d5e0-41c0-900c-09a10298a9ab.png)
