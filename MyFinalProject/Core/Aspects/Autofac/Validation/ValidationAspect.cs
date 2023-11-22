using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
//IsAssignableFrom metodu, bir tipin (IValidator), başka bir tip (validatorType) tarafından uygulanıp uygulanamayacağını belirler. Yani, validatorType tipinden bir nesnenin, IValidator tipinden bir nesneye atanıp atanamayacağını kontrol eder.

//Bu kontrol, validatorType’ın doğru bir validatör tipi olup olmadığını belirlemek için kullanılır. Eğer validatorType, IValidator interface’ini uygulamıyorsa, bir hata fırlatılır. Bu sayede, yanlışlıkla validatör olmayan bir tipin validatör olarak kullanılması engellenmiş olur.


//Activator.CreateInstance(_validatorType) ifadesi, validatör tipinden (_validatorType) bir nesne oluşturur. Bu nesne, IValidator interface’ini uygular ve bir validasyon işlemi gerçekleştirebilir.

//_validatorType.BaseType.GetGenericArguments()[0] ifadesi, validatörün hangi tip üzerinde çalıştığını belirler. Bu tip, validatör sınıfının genel tip argümanlarından biridir.

//invocation.Arguments.Where(t => t.GetType() == entityType) ifadesi, metot çağrısının argümanları arasında, validatörün çalıştığı tipi taşıyanları seçer.

//Son olarak, foreach döngüsü ile her bir argüman için validasyon işlemi gerçekleştirilir. Eğer bir argüman geçerli değilse, ValidationTool.Validate metodu bir hata fırlatır.