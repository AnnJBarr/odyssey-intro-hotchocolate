using Odyssey.MusicMatcher.Types;
using SpotifyWeb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<Query>().RegisterService<SpotifyService>();
builder.Services.AddHttpClient<SpotifyService>();

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
    });

var app = builder.Build();

//http://localhost:5059/GraphQL/
app.UseCors();
app.MapGraphQL();
app.Run();

