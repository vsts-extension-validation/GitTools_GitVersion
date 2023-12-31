using GitVersion.Logging;

namespace GitVersion.Core.Tests.Logging;

[TestFixture]
public class LoggingTests
{
    [Test]
    public void CanLogNonFormatStrings()
    {
        var log = new Log();

        log.Info("Logging using git revision syntax eg. 1.0.0.0^{} shouldn't throw");
    }
}
