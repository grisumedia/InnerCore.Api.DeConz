﻿namespace InnerCore.Api.deConz.Models.Sensors.CLIP
{
    public interface CLIPLightlevelState : IGeneralSensorState
    {
        /// <summary>
        /// Light level in 10000 log10 (lux) +1 measured by sensor. Logarithm scale used because the human eye adjusts to light levels and small changes at low lux levels are more noticeable than at high lux levels.
        /// </summary>
        long? LightLevel { get; set; }

        /// <summary>
        /// lightlevel is at or below given dark threshold
        /// </summary>
        bool? Dark { get; set; }

        /// <summary>
        /// lightlevel is at or above light threshold (dark+offset).
        /// </summary>
        bool? Daylight { get; set; }

    }
}