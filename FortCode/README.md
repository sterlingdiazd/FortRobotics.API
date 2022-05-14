
# FORT Technical Exercise
Please fork this repo to complete the tasks below. Treat this as any other project in terms of how you would handle it to meet the requirements including your regular frequency of commits.

## Setup
You'll need Docker on your machine to run the environment you'll be working in easily.

* The database connection string will be passed via an environment variable and can be retrieved from the configuration using key `ConnectionStrings:DbContext`

* You'll need to add a separate document: `EXPLANATIONS.md` where any explanations for your submission will be included. More details below.

## Tasks
Please use this project as the base for your work to accomplish the following:

* Please provide an API with which you can accomplish the following

    * Create a user account with the following:
    
        * Name
        
        * Email
        
        * Password
        
    * A user should be able to authenticate with an email and password
        
    * An authenticated user should be able to add and remove their favorite cities where a city consists of the following:
    
        * City name
        
        * Country
        
    * An authenticated user should be able to retrieve a list of their favorite cities

* Please add automated testing coverage for the above functionality. Add any explanation needed, if any, to run the tests from the command line in the `EXPLANATIONS.md`.

* Add the API details to a separate document `API.md`.

* Submit a link to your forked repo.


## Running with Docker
From command line

1. Navigate to the solution folder

2. Run/update docker compose: `docker-compose up -d --build`

3. Once docker compose has been deployed successfully (you'll see it in the output), you can access the api at `http://localhost:8100`.

## Keep in mind

* **PLEASE DO NOT SUBMIT PULL REQUESTS TO THIS REPO**

* **IMPORTANT:** All necessary information to run and use the API successfully should be provided in the `EXPLANATIONS.md` if it is not handled automatically. Running and using the API successfully should not require a review of the code to determine what needs to be done.

* When running the project, the data created in the app is only required to persist as long as the app is running. In other words, if we run the app and an account for user X is created, then we should be able to authenticate with user X's credentials as long as the app is 'alive'. If the app is killed and restarted then there is no requirement that user X's account still be available. It is perfectly acceptable for the database to be recreated each time the app is run.

* There is no client/front-end requirement for these tasks. All that is required is an API.

* If you cannot get something to work as you'd like or exactly as a(the) task(s) require, then please just make a note of it and explain what you tried and what didn't work in `EXPLANATIONS.md`.

* If you find a bug in the base project/setup, please make note of it in the `EXPLANATIONS.md`. Bonus points if you add a fix for it :) in your submission.

* Feel free to change anything as long as the task requirements are met and you can still run the project as expected with the same docker compose instructions above. Please note the reasoning for your changes, if any, in `EXPLANATIONS.md`. If possible, please also avoid making changes to the existing code unless it's needed to meet the required tasks.
