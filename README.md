# hexagonal-architecture
API using an hexagonal architecture



-- Notes --
API - Controller (Seria uma porta)
	Application (Seria onde temos a nossas regras de negocio - Seria a service que estamos acostumados)
		Repository - (Seria o nosso adaptador?)
		


To create a new postgres in docker
	     docker run --name hexagonal-architecture -p 5432:5432 -e POSTGRES_PASSWORD=1234 postgres