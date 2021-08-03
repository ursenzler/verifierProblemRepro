[<VerifyXunit.UsesVerify>]
module VerifierPluginProblemRepro.VerifierTest

open VerifyXunit
open Xunit

let verify (value : 't) =
    Verifier.Verify<'t>(value).ToTask() |> Async.AwaitTask

[<Fact>]
let test () =
    verify "does not work"