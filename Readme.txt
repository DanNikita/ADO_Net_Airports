---Readme file---
Hello and welcome to the Airports app ver.1.0!
This application allows you to calculate distance between two points (on a curve) of our planet.
As a basic points we use airports and their latitude and longitude, so you can easily check your flight's distance, even if direct flight does not exist.
Application uses more than 6800 airports all around the globe via special database, that stores not only position, but also IATA, region and much more.

I. Connection to the database.
User must be connected to the database to use this app. Please ensure stable connection to the necessary database. Type of database app: Postgres.
Host, Login, Database name and password shall be filled according to the postrgres local conditions.
Successfull connection will trigger main window to open, also status will be changed to "Connection successful!".
Any errors also will be shown. Default connection is used for testing reasons only.


II. Main window - general
User must fill two different airports to perform distance calculation. Use point A an B text boxes to fill airports names. Note: Names start with letter cases.
For example: 'Worms Airport'.
For each airport use Validate button to ensure, that airports exist in the current database. If data is correct - short info about this airport will be
shown below, including position and region.
As soon as two airports are validated - you can press calculate and application will return value in meters.

III. Main window - Search bar.
For convinience you can use special search through the database.
Use one of the three (country, city or region) options to show airports, related to this territory.
Press one of the related ticks and enter location into the search bar. Press Search! button to open the table with search results.
Airport's names can be used to calculate desired distances.
Empty search bar can be used to fill user's data to the database, for example small unregistred airport or even two simple points on planet.
Please ensure to fill airport name, latitude and longitude at least. Without this data you cannot validate the airport or calculate the distance.
Taking into the account security reasons, you cannot delete or change airports data from the database. Please use database client for manual database use.

P.S. Our team wishes you a pleasant use of our product. Feel free to contact us: dnv95@list.ru.

---HAVE A NICE FLIGHT---
