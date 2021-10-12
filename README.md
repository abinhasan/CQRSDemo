# CQRSDemo
Command Query Responsibility Segregation (CQRS). It is an architectural pattern that separates the read and writes operations of your application

# Scaffold-DbContext example
Scaffold-DbContext -ContextDir DataContext -Context DatabaseContext "Server=IT-ABIN;Database=ecommercedb123;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f

# Understanding the CRQS pattern
The Command Query Responsibility Segregation (CQRS) pattern separates a service’s write tasks from its read tasks. While reading and writing to the same database is acceptable for small applications, distributed applications operating at web-scale require a segmented approach. Typically there’s more read activity than write activity. Also, read activity is immutable. Thus, replicas dedicated to reading data can be spread out over a variety of geolocations. This approach allows users to get the data that closest to them. The result is a more efficient enterprise application.

# Advantages
1. Separating write activity from ready activities allows you to use the best database technology for the task at hand, for example, a SQL database for writing and a non-SQL database for reading.
2. Read activity tends to be more frequent than writing, thus you can reduce response latency by placing read data sources in strategic geolocations for better performance.
3. Separating write from read activity leads to more efficient scaling of storage capacity based on real-world usage.
4. We can scale the read and write databases independently of each other
5. The write database can be normalized to 3rd Normal Form to make writes efficient
6. The read databases can be denormalized the data to suit specific queries and need not perform complex operations like JOIN tables to return the required data.
Managing security and permissions is easy
7. It makes queries simple
8. It forces us to change the way we think, UI sends a command to the write model and not a data model object
9. We can use a relational database for the write side and use NoSQL database for the read side. Scaling a NoSQL database is relatively easy.

# Disadvantages
1. Supporting the CQRS pattern requires expertise in a variety of database technologies.
2. Using the CQRS patterns means that more database technologies are required hence there is more inherent cost either in terms of hardware or if a cloud provider is used, utilization expense.
3. Ensuring data consistency requires special consideration in terms of Service Level Agreements (see the CAP theorem).
4. Using a large number of databases means more points of failure, thus companies need to have comprehensive monitoring and fail-safety mechanisms in place to provide adequate operation
5. It makes the whole system complex
6. Data can be stale
7. Handling eventually consistent data is a monster of its own.
