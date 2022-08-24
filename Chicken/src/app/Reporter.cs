namespace Chickensoft.Chicken {
  using CliFx.Infrastructure;

  public interface IReporter {
    void DependencyEvent(IReportableDependencyEvent depEvent);
  }

  public class Reporter : IReporter {
    private readonly ConsoleWriter _output;
    public Reporter(ConsoleWriter output) => _output = output;

    public void DependencyEvent(IReportableDependencyEvent depEvent)
      => _output.Write(depEvent.ToString());
  }
}