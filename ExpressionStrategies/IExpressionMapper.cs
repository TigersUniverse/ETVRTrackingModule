namespace ETVRTrackingModule.ExpressionStrategies;

public interface IMappingStrategy
{
    public void HandleOSCMessage(OSCMessage message);
}