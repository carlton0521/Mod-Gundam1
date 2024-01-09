/// <summary>
/// Represents a hop or step within a scene path.
/// </summary>
public class SceneHop
{
  public Action Action { get; set; }
  public Scene ToScene { get; set; }
  public sbyte ScoreOfTrend { get; set; }
  public sbyte ScoreOfCompleteness { get; set; }
}
