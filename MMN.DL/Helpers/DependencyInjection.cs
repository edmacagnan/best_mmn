using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MMN.DL.Interfaces;

namespace MMN.DL.Helpers;

public static class DependencyInjection {
    public static void AddDataLayer(this IHostApplicationBuilder builder) {
        var connectionString = builder.Configuration.GetConnectionString("mmn");
        builder.Services.AddDbContextPool<IAppDb, Context>(opts => {
            opts.UseSqlServer(connectionString);
        });
    }
}