namespace MMN.API.Helpers;

public static class DependencyInjection {
    public static void AddApiLayer(this IHostApplicationBuilder builder) {
        builder.Services.AddSingleton(builder.Configuration);
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
    }
}