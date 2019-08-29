This repository demonstrates quick-and-dirty usage of the new Roslyn [`DiagnosticSuppressor` infrastructure](https://gist.github.com/mavasani/fcac17a9581b5c54cef8a689eeec954a).

It does not demonstrate best practices. It's meant to be the simplest and brainless diagnostic suppressor there could be. It wasn't really ever intended to see the light of day, but I'm sharing it in response to [this comment](https://gist.github.com/mavasani/fcac17a9581b5c54cef8a689eeec954a#gistcomment-3011774).

To test it, first open `DiagnosticSuppressorTest.sln` and build the debug configuration. Next run `Test.bat`, which will build the `TestLibrary` project with the analyzer.

The analyzer suppresses all `CS0649` diagnostics with a message containing the string `TestStruct.X`. (This is not the right way to selectively suppress diagnostics based on a symbol name, once again: This is a bare minimum test.) If you look at `TestStruct.cs`, you'll see `CS0649` should've been emitted for both fields, but it will only be emitted for `Y`.
