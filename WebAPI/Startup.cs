using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {    //Autofac bize AOP imkan� sunar. O y�zden .net in kendi �oc container�na autofact i enjecte edece�iz.
            //Autofac,Ninject,CastleWindsor,StructureMap,LightInject,DryInject:.net projelerinde kendi i�inde IOC Container alt yap�s�n� bize sunar.
            //AOP:Bir metodun �n�nde ,sonunda ,bir metod hata verdi�inde �al��an kod par�ac�klar�n� AOP mimarisiyle yaz�yoruz.
            services.AddControllers();
            services.AddSingleton<IProductService,ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();
            //singleton� i�erisinde data tutmuyorsak kullan�r�z. ��nk� �rne�in   sepete uygularsak birbirinin 
            //referans�n� tuttu�u i�in biri sepete ekledi�inde di�erleride ekler. sepettekileri sildi�inde di�erlerininde
            //sepetteki �r�nleri silinir(referans tipten dolay�)

            //�oc bizim yerimize new leme yapar.
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
