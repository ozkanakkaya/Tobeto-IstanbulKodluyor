using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }

}
//AttributeUsage bir .NET attribute’üdür ve bir attribute’ün nasıl kullanılacağını belirtir1AttributeUsage attribute’ü, bir attribute’ün hangi programlama öğelerine (sınıflar, metotlar, vb.) uygulanabileceğini, birden fazla kez uygulanıp uygulanamayacağını ve alt sınıflar tarafından miras alınıp alınamayacağını belirtir.

//AttributeTargets.Class | AttributeTargets.Method ifadesi, bu attribute’ün sınıflar ve metotlar üzerine uygulanabileceğini belirtir.

//AllowMultiple = true ifadesi, bu attribute’ün aynı öğeye birden fazla kez uygulanabileceğini belirtir.

//Inherited = true ifadesi, bu attribute’ün alt sınıflar tarafından miras alınabileceğini belirtir.

//Intercept metodu, bir IInvocation nesnesi alır. Bu nesne, çağrılan metot hakkında bilgi içerir. Intercept metodu, metot çağrısının çeşitli aşamalarında çalıştırılacak kodları belirler. Örneğin, bir metot çağrısı öncesi, sonrası, hata durumunda ve başarılı olduğunda çalıştırılacak kodları belirleyebilir