using Service.Gateways;
using Service.Resolvers;
using Service.Resolvers.Implementation;
using System.Net.Http.Headers;
using HousingSearchClient = Service.Boundary.HackneyApi.HousingSearh.Client;
using PersonClient = Service.Boundary.HackneyApi.Person.Client;

var builder = WebApplication.CreateBuilder(args);
var options = new HackneyApi();
builder.Configuration.Bind(nameof(HackneyApi), options);

builder.Services
    .AddHttpClient()
    .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()
    .AddSingleton<HackneyApi>(options)
    .AddTransient<HousingSearchClient>()
    .AddTransient<PersonClient>()
    .AddTransient<ISearch, Search>()
    .AddAWSLambdaHosting(LambdaEventSource.HttpApi)
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();
app.MapGraphQL();

await app.RunAsync();