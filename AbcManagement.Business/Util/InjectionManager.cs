using AbcManagement.DataAccess.Abstract;
using AbcManagement.DataAccess.Concrete.EF;
using Ninject;
using Ninject.Modules;

namespace AbcManagement.Business.Util
{
    public class InjectionManager
    {
        private static IKernel Kernel { get; set; }

        public static T GetInstance<T>()
        {
            Kernel = new StandardKernel(new InstanceModule());
            return Kernel.Get<T>();
        }
    }

    public class InstanceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDA_Users>().To<EFDA_Users>();
        }
    }
}
