# Tech Test - .NET

Welcome to the .NET tech test.

We have prepared a small app that we would like you to work on. We have a few challenges in the form of a bug report, a performance issue and a user story.

Please timebox a maximum of 3 hours and try to implement as many of the challenges that you can.

If you are running out of time, feel free to add some comments to explain what you would do if you had more time.

We will build on your work in the technical interview.

Note that we have included a hoppscotch collection for your convenience.

https://hoppscotch.io/

You can import the collection, when prompted, choose "Import from Hoppscotch".

Note that you need to install the browser extension for the requests to succeed.

## The challenges:

### Bug: Unexpected 500 error

**Repro steps**

1. Make a request to the api/orders endpoint

**Expected**  
The request should succeed with a status of 200.

**Actual**  
The request errors with a status of 500.

### Performance Issue: Excessive slowdown on api/customers/customer-ids-with-orders

_Note: there isn't really a measurable peformance issue, but for the sake of this test, let's pretend that the endpoint is performing badly. So we are not interested in measuring the performance here, rather we are interested to understand how you could reimplement the endpoint to hypothetically improve performance._

We have had reports that the `/customers/customer-ids-with-orders` endpoint is performing poorly and sometimes timing out.

Please try to improve the implemetation of this endpoint in a way which could potentially make the endpoint response time shorter.

### User Story: As an API user I want to be able to assign products to orders

We would like you to implement a new endpoint which allows an API user to associate products with an order.

Please also update the GET /orders endpoint to return the list of associated products on each order.

There are already a handful or products in the database and these are what are available to be added to the order.

One order can have many products associated with it, and a product can be associated to any number of orders.


## How to submit your response

Please do not push branches or commits to this repository. Instead, can you create a zip file with the repository contents and send it to us via email.

If you have issues due to the size of the zip file/repository, then you can archive only the `.git` folder and send that to us.