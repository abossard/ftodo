module ServiceApp.Calendar.Tests
open FsUnit
open System
open Xunit
open ServiceApp.Calendar.Model

[<Fact>]
let ``I can create a Calendar`` () =
    createCalendar "mein level" TimeZoneInfo.Utc |> should be ofExactType<Calendar>