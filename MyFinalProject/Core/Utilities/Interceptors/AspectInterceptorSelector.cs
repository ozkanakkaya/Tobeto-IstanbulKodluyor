using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Core.Utilities.Interceptors
{

    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();
            var methodAttributes = type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }

}
//Bu kod parçası, bir sınıfın (type) ve bir metodun (method) üzerinde tanımlanan MethodInterceptionBaseAttribute attribute’lerini toplar. Bu attribute’ler, bir metot çağrısı öncesi, sonrası, hata durumunda ve başarılı olduğunda çalıştırılacak kodları belirler.

//GetCustomAttributes<MethodInterceptionBaseAttribute>(true) metodu, belirli bir tip veya metot üzerinde tanımlanan MethodInterceptionBaseAttribute attribute’lerini getirir. true parametresi, attribute’lerin miras alınan sınıflarda da aranacağını belirtir.

//classAttributes.AddRange(methodAttributes) kodu, metot seviyesinde tanımlanan attribute’leri, sınıf seviyesinde tanımlanan attribute’ler listesine ekler.

//Son olarak, classAttributes.OrderBy(x => x.Priority).ToArray() kodu, attribute’leri önceliklerine (Priority) göre sıralar ve bir dizi olarak döndürür. Bu sayede, bir metot çağrısı öncesi, sonrası, hata durumunda ve başarılı olduğunda hangi kodların çalışacağı belirlenir.