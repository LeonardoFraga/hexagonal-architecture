# hexagonal-architecture
API using an hexagonal architecture



-- Notes --
API - Controller (Seria uma porta)
	Application (Seria onde temos a nossas regras de negocio - Seria a service que estamos acostumados)
		Repository - (Seria o nosso adaptador?)
		

Create network
	docker network create mynetwork

To create a new postgres in docker
	     docker run -d --network=mynetwork --name hexagonal-architecture -p 5432:5432 -e POSTGRES_PASSWORD=1234 postgres

Build Image
	docker build -t fragaapi .

Build Container
	docker run -d --network=mynetwork --name hexa-api-3 -p 8000:8080 -e ASPNETCORE_URLS=http://+:80 fragaapi

Docker Connection
// "ConnectionString": "User ID=postgres;Password=1234;Server=hexagonal-db;Port=5432;Database=HexagonalDb;Pooling=true;"