namespace CGPFE.Mechanics.Dialogue;

public class DialogueLine(string? speakerName, string line)
{
    public string? SpeakerName = speakerName;
    public string Line = line;

    public DialogueLine(string line) : this(null, line)
    {
    }
}