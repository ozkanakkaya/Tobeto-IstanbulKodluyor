using Core.CrossCuttingConcerns.Validation;
using Core.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}

//ValidationTool statik bir sınıftır ve Validate adında bir metodu vardır. Bu metod, bir validatör ve bir nesne alır. Bu nesnenin validasyonunu gerçekleştirir ve eğer nesne geçerli değilse bir ValidationException fırlatır.

//var context = new ValidationContext<object>(entity); kodu, validasyon işlemi için bir bağlam (context) oluşturur.Bu bağlam, validasyonun hangi nesne üzerinde gerçekleştirileceğini belirtir.

//var result = validator.Validate(context); kodu, validatörü kullanarak validasyon işlemini gerçekleştirir. Bu işlem sonucunda bir ValidationResult nesnesi döner. Bu nesne, validasyon işleminin sonucunu ve hata detaylarını içerir.