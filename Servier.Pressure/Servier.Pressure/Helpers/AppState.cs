namespace Servier.Pressure.Helpers;

public class AppState
{
    public event Action? OnChange;

    private bool _treatmentChanged;
    public bool TreatmentChanged
    {
        get => _treatmentChanged;
        set
        {
            if (_treatmentChanged != value)
            {
                _treatmentChanged = value;
                NotifyStateChanged();
            }
        }
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
