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
        {    //Autofac bize AOP imkaný sunar. O yüzden .net in kendi ýoc containerýna autofact i enjecte edeceðiz.
            //Autofac,Ninject,CastleWindsor,StructureMap,LightInject,DryInject:.net projelerinde kendi içinde IOC Container alt yapýsýný bize sunar.
            //AOP:Bir metodun önünde ,sonunda ,bir metod hata verdiðinde çalýþan kod parçacýklarýný AOP mimarisiyle yazýyoruz.
            services.AddControllers();
            services.AddSingleton<IProductService,ProductManager>();
            services.AddSingleton<IProductDal, EfProductDal>();
            //singletoný içerisinde data tutmuyorsak kullanýrýz. çünkü örneðin   sepete uygularsak birbirinin 
            //referansýný tuttuðu için biri sepete eklediðinde diðerleride ekler. sepettekileri sildiðinde diðerlerininde
            //sepetteki ürünleri silinir(referans tipten dolayý)

            //ýoc bizim yerimize new leme yapar.
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
