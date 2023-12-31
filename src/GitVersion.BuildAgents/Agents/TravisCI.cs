using GitVersion.Logging;
using GitVersion.OutputVariables;

namespace GitVersion.Agents;

internal class TravisCi : BuildAgentBase
{
    public TravisCi(IEnvironment environment, ILog log) : base(environment, log)
    {
    }

    public const string EnvironmentVariableName = "TRAVIS";
    protected override string EnvironmentVariable => EnvironmentVariableName;

    public override bool CanApplyToCurrentContext() => "true".Equals(Environment.GetEnvironmentVariable(EnvironmentVariable)) && "true".Equals(Environment.GetEnvironmentVariable("CI"));

    public override string GenerateSetVersionMessage(GitVersionVariables variables) => variables.FullSemVer;

    public override string[] GenerateSetParameterMessage(string name, string? value) => new[]
    {
        $"GitVersion_{name}={value}"
    };

    public override bool PreventFetch() => true;
}
