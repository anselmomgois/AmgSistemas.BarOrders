using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmgSistemas.BarOrders
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<Interfaces.IProdutoFilialRepository, Repository.ProdutoFilialRepository>();
            services.AddScoped<Interfaces.IGrupoProdutoRepository, Repository.GrupoProdutoRepository>();
            services.AddScoped<Interfaces.IFilialRepository, Repository.FilialRepository>();
            services.AddScoped<Interfaces.IMesaRepository, Repository.MesaRepository>();
            services.AddScoped<Interfaces.IMesaAtendenteRepository, Repository.MesaAtendenteRepository>();
            services.AddScoped<Interfaces.IComandaRepository, Repository.ComandaRepository>();
            services.AddScoped<Interfaces.IParametroRepository, Repository.ParametroRepository>();
            services.AddScoped<Interfaces.IDispositivoRepository, Repository.DispositivoRepository>();

            services.AddScoped<Interfaces.IProdutoFilialServices, Services.ProdutoFilialServices>();            
            services.AddScoped<Interfaces.IFilialServices, Services.FilialServices>();            
            services.AddScoped<Interfaces.IGrupoProdutoServices, Services.GrupoProdutoServices>();
            services.AddScoped<Interfaces.IMesaServices, Services.MesaServices>();
            services.AddScoped<Interfaces.IPedidoServices, Services.PedidoServices>();
            services.AddScoped<Interfaces.IComandaServices, Services.ComandaServices>();

            services.AddScoped<Interfaces.IParametroServices, Services.ParametrosServices>();

            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
                                  });
            });


            services.AddDbContext<BD.BancoContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("DbContext")));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(MyAllowSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
