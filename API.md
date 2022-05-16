# FORT Technical Exercise

The following data is only for for information purposes; to see the develop requirements done. To test the functionality of the API, use the link of the Postman collection present at the Readme.md file.

## Functionalities:

Aditional to the required functionality requested and developed. There area also aditional web api methods created for maintenance purposes such as UpdateCity and DeleteCity.

# Create a user account with the following:

        * Name

        * Email

        * Password

Api Sample Request:

POST https://localhost:5001/api/account/signup

Request Body

{
"Name": "Peter",
"Email": "peter@gmail.com",
"Password": "Test@1233",
"ConfirmPassword": "Test@1233"
}

Response Body

true

# A user should be able to authenticate with an email and password

POST https://localhost:5001/api/account/login

Request Body

{
"email": "sterling@gmail.com",
"password": "Test@1234"
}

Response Body

eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RlcmxpbmdAZ21haWwuY29tIiwianRpIjoiMzM4ZjlhOWItN2FhYy00Y2U0LTg3YWUtMWM3N2Y0YjZiYzY0IiwiZXhwIjoxNjUyNzUzNDc2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo0NDM0MSIsImF1ZCI6IlVzZXIifQ.fAk129MELAomFhajIBSqbs47SwStGkOQ9dNhx5OMHow

# An authenticated user should be able to add and remove their favorite cities where a city consists of the following:

City name

Country

# Add City Request:

POST https://localhost:5001/api/Cities

Request Headers

Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RlcmxpbmdAZ21haWwuY29tIiwianRpIjoiMzM4ZjlhOWItN2FhYy00Y2U0LTg3YWUtMWM3N2Y0YjZiYzY0IiwiZXhwIjoxNjUyNzUzNDc2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo0NDM0MSIsImF1ZCI6IlVzZXIifQ.fAk129MELAomFhajIBSqbs47SwStGkOQ9dNhx5OMHow

Request Body

{
"Name": "San Cristobal",
"Country": "Republica Dominicana"
}

# GetCityById

GET https://localhost:5001/api/cities/2

Request Headers

Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RlcmxpbmdAZ21haWwuY29tIiwianRpIjoiMzM4ZjlhOWItN2FhYy00Y2U0LTg3YWUtMWM3N2Y0YjZiYzY0IiwiZXhwIjoxNjUyNzUzNDc2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo0NDM0MSIsImF1ZCI6IlVzZXIifQ.fAk129MELAomFhajIBSqbs47SwStGkOQ9dNhx5OMHow

Response Body

{"idCity":2,"name":"San Cristobal","country":"Republica Dominicana"}

# Get All cities

GET https://localhost:5001/api/cities

Request Headers

Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoianVsaW9nQGdtYWlsLmNvbSIsImp0aSI6IjZlMDFjOTEwLWU2ZDYtNDZhNC1hZDg2LWVhOThjM2RmM2ZjMSIsImV4cCI6MTY1Mjc0OTExMiwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzNDEiLCJhdWQiOiJVc2VyIn0.Ynhp4NlvinR6nW0O15am1qvIhadSMmPxzrwvKYTSLy0

Response Body

[{"idCity":1,"name":"San Cristobal","country":"Republica Dominicana"},{"idCity":2,"name":"San Cristobal","country":"Republica Dominicana"}]

# Add Favorite City of User

POST https://localhost:5001/api/FavoriteUserCities/1

Request Headers

Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoianVsaW9nQGdtYWlsLmNvbSIsImp0aSI6IjZlMDFjOTEwLWU2ZDYtNDZhNC1hZDg2LWVhOThjM2RmM2ZjMSIsImV4cCI6MTY1Mjc0OTExMiwiaXNzIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NDQzNDEiLCJhdWQiOiJVc2VyIn0.Ynhp4NlvinR6nW0O15am1qvIhadSMmPxzrwvKYTSLy0

Location: https://localhost:5001/api/FavoriteUserCities/1
Response Body

1

# Get Favorite City of User

GET https://localhost:5001/api/FavoriteUserCities

Request Headers

Authorization: Bearer eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RlcmxpbmdAZ21haWwuY29tIiwianRpIjoiOWZlZGY2ZDctNWZmZS00YWE0LWI2OGYtNjRkMmYxNzFmMzY0IiwiZXhwIjoxNjUyNzU1MzY2LCJpc3MiOiJodHRwczovL2xvY2FsaG9zdDo0NDM0MSIsImF1ZCI6IlVzZXIifQ.PH8F8akGtMXwDPsNYyxS4l-BcMt-xruQQEpAiRGvqVg

Response Body
{
"name":"Sterling",
"email":"sterling@gmail.com",
"favCities":[
{"idCity":1,"name":"San Cristobal","country":"Republica Dominicana"}
]
}
