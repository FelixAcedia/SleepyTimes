using System;
using SleepyTimes.Services;
using VampireCommandFramework;

namespace SleepyTimes.Commands;

internal class TimeCommands{
    [Command("getDays", description: "Outputs the total days of the server world.")]
    public static void GetDaysCommand(ChatCommandContext ctx) {
        int days = TimeService.GetTotalDays() ?? -1;
        if (days == -1) {
            throw new Exception("Unable to determine the total days of the server world.");
        }
        ctx.Reply($"Total days of the server world: {days}");
    }

    [Command("getTime", description: "Outputs the total time of the server world.")]
    public static void GetTimeCommand(ChatCommandContext ctx) {
        int days = TimeService.GetTotalDays() ?? -1;
        if (days == -1) {
            throw new Exception("Unable to determine the total days of the server world.");
        }

        int yearTotal = days / TimeService.DAYS_IN_YEAR;
        int monthTotal = days % TimeService.DAYS_IN_YEAR /  TimeService.DAYS_IN_MONTH;
        int dayTotal = days % TimeService.DAYS_IN_YEAR % TimeService.DAYS_IN_MONTH;

        ctx.Reply($"Total time of the server world: {yearTotal} Years, {monthTotal} Months, {dayTotal} Days");
    }

}