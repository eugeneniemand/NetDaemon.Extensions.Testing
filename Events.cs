using Niemand.Helpers;

namespace NetDaemon.Extensions.Testing;

public static partial class Events
{
    public static class Light
    {
        public static object TurnOff(LightEntity entity) =>
            new
            {
                Domain  = "light",
                Service = "turn_off",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };

        public static object TurnOn(LightEntity entity, LightTurnOnParameters lightTurnOnParameters) =>
            new
            {
                Domain  = "light",
                Service = "turn_on",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                },
                Data = lightTurnOnParameters
            };

        public static object TurnOn(LightEntity entity) =>
            new
            {
                Domain  = "light",
                Service = "turn_on",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };
    }
    
    public static class Switch
    {
        public static object TurnOff(SwitchEntity entity) =>
            new
            {
                Domain  = "switch",
                Service = "turn_off",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };

        public static object TurnOn(SwitchEntity entity) =>
            new
            {
                Domain  = "switch",
                Service = "turn_on",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };
    }

    public static class InputBoolean
    {
        public static object TurnOff(InputBooleanEntity entity) =>
            new
            {
                Domain  = "input_boolean",
                Service = "turn_off",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };

        public static object TurnOn(InputBooleanEntity entity) =>
            new
            {
                Domain  = "input_boolean",
                Service = "turn_on",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };
    }
    
    public static class AlarmPanel
    {
        public static object Disarmed(AlarmControlPanelEntity entity) =>
            new
            {
                Domain  = "alarm_control_panel",
                Service = "alarm_disarm",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };
        
        public static object ArmedAway(AlarmControlPanelEntity entity) =>
            new
            {
                Domain  = "alarm_control_panel",
                Service = "alarm_arm_away",
                Target = new
                {
                    EntityIds = new[] { entity.EntityId }
                }
            };
    }
    
    public static class Notify
    {
        public static object AlexaMedia(MediaPlayerEntity entity, string message, string type) =>
            new
            {
                Domain  = "notify",
                Service = "alexa_media",
                Data = new
                {
                    Data   = new { type = type },
                    Target = entity.EntityId,
                    Message = message
                }
            };
    }
}