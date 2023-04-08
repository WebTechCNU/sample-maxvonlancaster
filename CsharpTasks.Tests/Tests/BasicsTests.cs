using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTasks.Tests.Tests
{
    public class BasicsTests
    {
        private string assemblyName = "";
        private string nameSpace = "";

        [Test]
        public void MyAccessModifiersExists()
        {
            var type = Assembly.GetAssembly(typeof(Sample))?
                .GetType("CsharpTasks._01_basics.MyAccessModifiers");
            Assert.IsTrue(type?.IsClass);
        }

        [Test]
        public void BirthYearPrivate()
        {
            var type = Assembly.GetAssembly(typeof(Sample))?
                .GetType("CsharpTasks._01_basics.MyAccessModifiers");
            var field = type?.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => f.Name == "birthYear");
            Assert.IsTrue(field?.IsPrivate);
        }

        [Test]
        public void BirthYearInt()
        {
            var type = Assembly.GetAssembly(typeof(Sample))?
                .GetType("CsharpTasks._01_basics.MyAccessModifiers");
            var field = type?.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                .FirstOrDefault(f => f.Name == "birthYear");
            Assert.IsTrue(field?.FieldType == typeof(int));
        }
    }
}
