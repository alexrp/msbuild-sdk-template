using Microsoft.Build.Utilities;

namespace Foo.Tasks
{
    public sealed class Foo : Task
    {
        public override bool Execute()
        {
            Log.LogWarning("Hello World");

            return true;
        }
    }
}
