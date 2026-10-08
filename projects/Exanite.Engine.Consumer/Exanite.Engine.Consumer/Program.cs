using Exanite.Engine.Ecs.Queries;
using Exanite.Engine.Framework;

namespace Exanite.Engine.Consumer;

public static partial class Program
{
    public const string CompanyName = "Exanite";
    public const string ProgramName = "Exanite.Engine.Consumer";

    public static int Main(string[] args)
    {
        var settings = new EngineSettings(CompanyName, ProgramName);
        using var engine = EngineRoot.Create(settings, []);

        return engine.Launch(args);
    }

    [Query]
    public static void Test()
    {
        // TODO: Currently the source generator only works when Exanite.Engine.Analyzers is explicitly referenced. Need to investigate.
    }
}
