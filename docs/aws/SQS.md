# Concept
Amazon Simple Queue Service (SQS) lets you send, store, and receive messages between software components at any volume,
without losing messages or requiring other services to be available.
![image](https://user-images.githubusercontent.com/48196420/207760791-432786f5-2f82-4a3c-bdc3-4099ff6b7564.png)

# Producer
- The message is persisted in SQS until a consumer deletes it
- Send by SendMessage API
- Message standard: unlimited throughput 

# Consumer
- Can be running on EC2 instance, AWS lambda)
- Poll SQS for messages (receive up to 10 msg at a time)
- Handle msg (Example: insert the msg into an RDS DB or dynamo db,...)
- Delete the msg using DeleteMsg API

#Options: Fifo or standart

#  Working fine with another AWS services like auto scalling group 

![image](https://user-images.githubusercontent.com/48196420/207762128-154d1f13-33db-497d-a99b-a65b14b0fd26.png)

# Policy and security
- Encryption : KMS Key, Client side encryption, In-flight encryption using HTTPS API
- Control by IAM Policy and SQS Policy
