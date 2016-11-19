[<AutoOpen>]
module CExprKit.Prelude
open System
open System.IO


let (^) = (<|)

/// write to the console in the provided color
let writelnc color txt =
    let oldcolor = Console.ForegroundColor
    Console.ForegroundColor <- color
    Console.WriteLine(txt:string)
    Console.ForegroundColor <- oldcolor

let printWarnfn msg =
    Printf.kprintf (writelnc ConsoleColor.Cyan) msg

let printErrorfn msg =
    Printf.kprintf (writelnc ConsoleColor.Red) msg

let printTracefn msg =
    Printf.kprintf (writelnc ConsoleColor.Green) msg



[<RequireQualifiedAccess>]
module Path =
    let changeExt ext path =
        Path.GetFileNameWithoutExtension path + ext
