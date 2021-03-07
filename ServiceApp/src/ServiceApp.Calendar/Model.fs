module ServiceApp.Calendar.Model

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
    }

let createCalendarEntry startTime duration title =
    {startTime = startTime; duration = duration; title = title}

let createCalendar title timezone = 
    {title = title; timezone = timezone; entries = [] }
    
let createMonthCalendars calendar =
    calendar.entries

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
