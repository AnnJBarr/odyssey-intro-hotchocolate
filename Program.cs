using Odyssey.MusicMatcher;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

//http://localhost:5059/GraphQL/
app.MapGraphQL();

app.Run();

