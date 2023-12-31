namespace GitVersion;

[Serializable]
public class GitToolsException : Exception
{
    public GitToolsException(string messageFormat, params object[] args)
        : base(string.Format(messageFormat, args))
    {
    }

    public GitToolsException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    public GitToolsException()
    {
    }

    public GitToolsException(string? message) : base(message)
    {
    }
}
