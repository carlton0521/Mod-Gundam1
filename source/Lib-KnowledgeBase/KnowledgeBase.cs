/// <summary>
/// Represents the knowledge base component of the system.
/// </summary>
public class KnowledgeBase
{
  /// <summary>
  /// Retrieves information about a knowledge item.
  /// </summary>
  public YAMLlmSystemPrompt GetKnowledgeInfo() { /* Implementation */ }

  /// <summary>
  /// Retrieves possible paths for a given scene.
  /// </summary>
  public ScenePath[] GetPossibleScenePaths(ScenePath scenePath) { /* Implementation */ }

  /// <summary>
  /// Retrieves the score of a scene.
  /// </summary>
  public byte GetSceneScore(Scene scene) { /* Implementation */ }
}
