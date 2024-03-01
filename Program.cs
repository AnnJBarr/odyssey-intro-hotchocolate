using Odyssey.MusicMatcher;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder
                .WithOrigins("https://studio.apollographql.com")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    })
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddType<Playlist>();

var app = builder.Build();

//http://localhost:5059/GraphQL/
app.UseCors();
app.MapGraphQL();
app.Run();

