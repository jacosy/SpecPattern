using Logic.Utils;

namespace UI
{
    public partial class App
    {
        public App()
        {
            Initer.Init(@"Server=(LocalDb)\MSSQLLocalDB;Database=SpecPattern;Trusted_Connection=true;");
        }
    }
}
