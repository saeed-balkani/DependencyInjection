using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoC.IoC
{
    public class DependencyInjector
    {
        private Dictionary<Type, Type> dependenciesMap = new Dictionary<Type, Type>();

        public T Dependency<T>()
        {
            return (T)Dependency(typeof(T));
        }
        public object Dependency(Type typeTo)
        {
            Type dependencyType;
            if (!dependenciesMap.TryGetValue(typeTo, out dependencyType))
            {
                throw new Exception(string.Format("Coult Not {0}", typeTo.FullName));
            }
            var firstConstructor = dependencyType.GetConstructors().First();
            var constructorParameters = firstConstructor.GetParameters();
            if (!constructorParameters.Any())
                return Activator.CreateInstance(dependencyType);
            var parameters = new List<object>();
            foreach (var item in constructorParameters)
            {
                parameters.Add(Dependency(item.ParameterType));
            }
            return firstConstructor.Invoke(parameters.ToArray());
        }
        public void Register<TForm, TTO>()
        {
            dependenciesMap.Add(typeof(TForm), typeof(TTO));
        }
    }
}
