namespace Servier.Pressure.Services;

public class SurveyProgressService
{
    private readonly Dictionary<string, bool> _fieldStates = [];
    private Func<Func<Task>, Task>? _dispatcherInvokeAsync; 
    
    public event Action? OnProgressChanged;

    public void SetDispatcher(Func<Func<Task>, Task> dispatcherInvokeAsync)
    {
        _dispatcherInvokeAsync = dispatcherInvokeAsync;
    }

    public void RegisterField(string fieldName)
    {
        _fieldStates.TryAdd(fieldName, false);
    }

    public void UpdateField(string fieldName, bool isFilled)
    {
        if (_fieldStates.ContainsKey(fieldName))
        {
            _fieldStates[fieldName] = isFilled;
            _ = NotifyProgressChangedAsync();
        }
    }

    private async Task NotifyProgressChangedAsync()
    {
        if (_dispatcherInvokeAsync != null)
        {
            await _dispatcherInvokeAsync.Invoke(() =>
            {
                OnProgressChanged?.Invoke();
                return Task.CompletedTask;
            });
        }
        else
        {
            OnProgressChanged?.Invoke();
        }
    }
    public void Reset()
    {
        _fieldStates.Clear();
        _ = NotifyProgressChangedAsync();
    }

    public void LoadFields(Dictionary<string, bool> loadedFields)
    {
        _fieldStates.Clear();
        foreach (var kvp in loadedFields)
        {
            _fieldStates[kvp.Key] = kvp.Value;
        }
        _ = NotifyProgressChangedAsync();
    }

    public int TotalFields => _fieldStates.Count;

    public int FilledFields => _fieldStates.Values.Count(v => v);
    public int GetProgressPercent()
    {
        if (TotalFields == 0) return 0;
        return (int)((double)FilledFields / TotalFields * 100);
    }
}
