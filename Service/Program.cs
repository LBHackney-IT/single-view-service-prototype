using Resolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddAWSLambdaHosting(LambdaEventSource.HttpApi)
    .AddGraphQLServer()
    .AddAuthorization()
    .AddQueryType<Query>();

builder.Services
    .AddAuthentication()
    .AddJwtBearer();

var app = builder.Build();
app.UseAuthentication();
app.MapGraphQL();

await app.RunAsync();