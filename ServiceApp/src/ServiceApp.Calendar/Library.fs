namespace ServiceApp.Calendar.Library

open System

type Calendar =
    {
        title: string
        timezone: TimeZoneInfo
        entries: CalendarEntry list
    } 

and CalendarEntry =
    {
        startTime: DateTime
        duration: TimeSpan
        title: string
        calendar: Calendar
    }

type Month =
    January = 1
    | February = 2
    | March = 3
    | April = 4
    | May = 5
    | June = 6
    | July = 7
    | August = 8
    | September = 9
    | October = 10
    | November = 11
    | December = 12

type DayCalendar =
    {
        entries: CalendarEntry list
    }
    
type MonthCalendar =
    {
        month: Month
        days: DayCalendar array
    }
