module App

open Fable.Core
open Fable.React

open Elmish
open Elmish.React

open Elmish
open Elmish.Bridge
open Fable.React

type Model = { Count: int }

type Messages = Incr | Decr 

let init () = { Count = 0 }, Cmd.none

let update msg model = 
    match msg with
    | Incr -> { Count = model.Count + 1 }
    | Decr -> { Count = model.Count - 1 }
    , Cmd.none

let view model dispatch = 
    div 
      []
      [
      ]

Program.mkProgram init update view
|> Program.withBridge "localhost"
|> Program.withReactSynchronous "elmish-app"
|> Program.run
