using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using DAL;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

#region Passar a conexão para a DAL
        // Este método é usado para adicionar serviços ao contêiner de injeção de dependência.
        public void ConfigureServices(IServiceCollection services)
        {
            // Obtém a string de conexão do arquivo de configuração
            string? connectionString = Configuration.GetConnectionString("DefaultConnection");

            // Verifica se a string de conexão não é nula antes de adicioná-la
            if (!string.IsNullOrEmpty(connectionString))
            {
                // Configura o serviço do DbContext na camada DAL
                services.AddDALServices(connectionString);
            }
            else
            {
                // Se a string de conexão for nula, você pode lançar uma exceção, fazer log ou tomar outra ação adequada ao seu aplicativo.
                throw new Exception("A string de conexão 'DefaultConnection' não foi encontrada no arquivo de configuração.");
            }

            // Adiciona suporte ao controlador
            services.AddControllers();
#endregion


            // Adiciona suporte ao controlador
            services.AddControllers();

            // Adiciona o gerador Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "API", Version = "v1" });
            });
        }

        // Este método é usado para configurar o pipeline de solicitação HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Verifica se o ambiente é de desenvolvimento
            if (env.IsDevelopment())
            {
                // Exibe página de erro detalhada apenas em ambiente de desenvolvimento
                app.UseDeveloperExceptionPage();

                // Habilita o middleware do Swagger
                app.UseSwagger();

                // Especifica o endpoint Swagger JSON
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                    c.RoutePrefix = string.Empty; // Define a raiz do Swagger UI para a raiz da aplicação
                });
            }
            else
            {
                // Redireciona para HTTPS em ambientes de produção
                app.UseHttpsRedirection();
            }

            // Habilita roteamento
            app.UseRouting();

            // Habilita autorização (se necessário)
            // app.UseAuthorization();

            // Configura os endpoints
            app.UseEndpoints(endpoints =>
            {
                // Mapeia os endpoints dos controladores
                endpoints.MapControllers();
            });
        }
    }
}
