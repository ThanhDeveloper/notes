# Load balances
=> are servers that forward traffic to multiple servers (Ex: EC2) downstream

# Elastic load balancer ELB (AWS)
=> is a managed load balancer manage by AWS.

# Aws provided 4 kind of Load balances:
- Classic lb
- Application lb
- Network lb
- Gateway lb

# Benefit of BL
- Spread load across multiple downstream instances
- Expose a single point of access to your application
- Regular health checks to your instances
- enforce stickiness with cookie
- Provide SSL termination
- High available across zones

# Stickiness
Stickiness allows the load balancer to bind a user's session to a specific target. The stickiness type differs based on the type of cookie used. You can use a combination of stickiness types across your target groups, or even turn off stickiness. Stickiness cannot be turned on if cross-zone load balancing is turned off.

![image](https://user-images.githubusercontent.com/48196420/204753540-2ceae42a-9230-458c-a476-9c88b88a7f2c.png)

# Cross-zone load balancing
Each load balancer instance distributes evenly across all registered instances in all AZ

![image](https://user-images.githubusercontent.com/48196420/204755887-09b0c6a6-6635-4561-a165-5e55f2e29ca4.png)
