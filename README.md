# svv2-service-api
Single View V2 data consolidation service (via GraphQL)

# Description 

This server is meant to consolidate data from disparate sources in Hackney ecosystem under one GraphQL interface, taking the business logic burden from the frontend.

The code in Service\Boundary\HackneyApi is generated by NSwag from the files in Service\Boundary\Swagger automatically from REST Swagger specifications.

Currently the server is integrated with HousingSearchAPI. A client for PersonAPI is generated but not yet incorporated in GraphQL structure.

Note that the file Service\Boundary\Swagger\Hackney-housingSearchApi-1.0.0-resolved.json has been downloaded from Swaggerhub and then manually edited to accommodate
PersonTypes that are used by the HousingSearchAPI server but not documented in swagger specification.

# Running

Configure your desired API endpoint URLs in `Service\appsettings.Development.json`. Alternatively, set up any other ASP.NET configuration source, such as environment, with the same parameters.

Open the project in Visual Studio and run debug. Browser window opens up automatically with GraphQL client. 

Alternatively, use `dotnet run` command line and visit local page at `http://localhost:_port_/graphql`.

Create a new query document. At the bottom of the page, set up authorisation header with your Hackney Google JWT token.

Add queries such as the example below to the client window:

```
query SearchPersons($search: String!) {
  search {
    persons(searchText: $search, pageSize: 40) {
      total
      page {
        title
        firstname
        surname
        dateOfBirth
        personTypes
      }
    }
  }
}
```

This query is parametrised, so to run it, a parameter is required:
```json
{
  "search": "john"
}
```

Execute the query, explore the results.
