using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DemoAzureOfflineSync.UITests
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void IniciarCurso()
        {
            //app.Repl();
            app.EnterText(x => x.Class("EntryEditText").Index(0), "Roberto Cervantes");
            app.EnterText(x => x.Class("EntryEditText").Index(1), "rcervantes@outlook.com");
            app.Tap(x => x.Class("AppCompatButton").Index(0));
        }

        [Test]
        public void AgregarContacto()
        {
            app.EnterText(x => x.Class("EntryEditText").Index(0), "Roberto Cervantes");
            app.EnterText(x => x.Class("EntryEditText").Index(1), "rcervantes@outlook.com");
            app.Tap(x => x.Class("AppCompatButton").Index(0));
            //app.Repl();
            app.Tap(x => x.Class("AppCompatButton").Index(0));
            app.Tap(x => x.Class("AppCompatButton").Index(1));
        }
    }
}

