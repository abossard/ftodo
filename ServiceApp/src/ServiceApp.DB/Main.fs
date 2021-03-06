module ServiceApp.DB.Main

open System
open LiteDB
open LiteDB.FSharp
open LiteDB.FSharp.Extensions

let mapper = FSharpBsonMapper()
use db = new LiteDatabase("simple.db", mapper)

type Genre = Rock | Pop | Metal

type Album = {
    Id: int
    Name: string
    DateReleased: DateTime
    Genre: Genre
}

let albums = db.GetCollection<Album>("albums")

let metallica = 
    { Id = 1; 
      Name = "Metallica";
      Genre = Metal;
      DateReleased = DateTime(1991, 8, 12) }

albums.Insert(metallica)

let result = albums.findOne <@ fun album -> album.Id = 1 @> 
