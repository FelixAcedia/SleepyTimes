using System;
using ProjectM.Scripting;

namespace SleepyTimes.Services;

internal class TimeService{
    private static ServerGameManager ServerGameManager => Core.ServerScriptMapper.GetServerGameManager();

    private static bool HasDayNightCycle => ServerGameManager.HasDayNightCycle;
    private static double ServerTime => ServerGameManager.DayNightCycle.Time;

    private static float DayLength => ServerGameManager.DayNightCycle.DayDurationInSeconds;

    public const int DAYS_IN_MONTH = 28;
    public const int DAYS_IN_YEAR = 336;

    public static int? GetTotalDays() {
        return HasDayNightCycle? (int)Math.Floor(ServerTime / DayLength) : null;
    }
}