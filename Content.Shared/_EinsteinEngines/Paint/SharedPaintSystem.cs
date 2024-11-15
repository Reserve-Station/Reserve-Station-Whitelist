namespace Content.Shared._EinsteinEngines.Paint;

public abstract class SharedPaintSystem : EntitySystem
{
    public virtual void UpdateAppearance(EntityUid uid, PaintedComponent? component = null) { }
}
