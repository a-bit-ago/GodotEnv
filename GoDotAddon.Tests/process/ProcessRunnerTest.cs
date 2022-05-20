namespace Chickensoft.GoDotAddon.Tests {
  using System;
  using System.Threading.Tasks;
  using Chickensoft.GoDotAddon;
  using Shouldly;
  using Xunit;

  public class ProcessRunnerTest {
    [Fact]
    public async Task RunsProcess() {
      var runner = new ProcessRunner();
      var result = await runner.Run(
        Environment.CurrentDirectory, "echo", new string[] { "hello" }
      );
      result.ExitCode.ShouldBe(0);
      result.Success.ShouldBe(true);
      result.StandardOutput.ShouldBe("hello\n");
      result.StandardError.ShouldBe("");
    }
  }
}
