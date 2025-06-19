public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _completedCount++;
        if (_completedCount >= _targetCount)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetDetailsString()
    {
        return $"[{(_completedCount >= _targetCount ? "X" : " ")}] {_name} ({_description}) -- This Currently completed: {_completedCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonus}|{_targetCount}|{_completedCount}";
    }
}