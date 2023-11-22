using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }

}
//Bu sınıf, bir metot çağrısının çeşitli aşamalarında çalıştırılacak kodları tanımlar. Intercept metodu, bir metot çağrısı öncesi, sonrası, hata durumunda ve başarılı olduğunda çalıştırılır. Bu, Aspect Oriented Programming (AOP) prensiplerini uygulamak için kullanılır. AOP, çapraz kesitli endişeleri (loglama, güvenlik, önbellekleme, validasyon vb.) kod tabanından ayırmak için kullanılır.

//OnBefore, OnAfter, OnException ve OnSuccess metotları, bir metot çağrısı öncesi, sonrası, hata durumunda ve başarılı olduğunda çalıştırılacak kodları tanımlar. Bu metotlar virtual olarak tanımlanmış, yani alt sınıflar tarafından ezilebilir (override).