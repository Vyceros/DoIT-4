using Autofac;
using DoIT.Data;
using DoIT.Interfaces;
using DoIT.Services;
using Ninject.Modules;
using Ninject.Web.Common;

namespace DoIT
{
    public class DependencyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LectorService>().As<ILectorService>().InstancePerLifetimeScope();
            builder.RegisterType<StudentService>().AsSelf().InstancePerDependency();
        }

        /* private readonly IConfiguration _configuration;
         public DependencyModule(IConfiguration configuration)
         {
              _configuration = configuration;
         }
         public override void Load()
         {
             Bind<IConfiguration>().ToConstant(_configuration);
             Bind<ILectorService>().To<LectorService>();
             Bind<ApplicationDbContext>().ToSelf().InRequestScope();
         }*/
    }
}
