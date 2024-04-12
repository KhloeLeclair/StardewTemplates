# Stardew Valley Mod Templates

This is a project to create useful template projects to get users started
with Stardew Valley C# modding.


## Templates

* [Single Mod](#single-mod)
* [Multiple Mod Repository](#multiple-mod-repository)


## Single Mod

So far, there is a single template for creating a single mod project. This
template is bare bones and attempts to just get users quickly started with
best practices, including:

* Using the ModBuildConfig NuGet package that all C# mods use to handle
  referencing SMAPI, the game, setting up sensible build defaults, debug
  configuration, packaging builds, and everything else it does.
* Using the ModTranslationClassBuilder NuGet package to generate strongly
  typed i18n bindings.
* Using the ModManifestBuilder NuGet package to automatically generate
  and update a `manifest.json` file for the mod.

* Using nullable reference types.
* Disabling mod ZIP creation when not in Release configuration to avoid
  accidentally publishing a debug build of the mod.

This template also includes an `.editorconfig` file with a few opinionated
rules for C# formatting, including:

* Tab indentation, with a size of 4.
* Sorting for `using` declarations, with system directives first.
* File-scoped namespaces.
* Errors for a couple SMAPI diagnostics involving net field casting.

The included `ModEntry.cs` logs a simple Hello World! message to the
game's log, but it does use the ModTranslationClassBuilder to do so.



## Multiple Mod Repository

WIP. This will be a more involved template with a common project, and
several useful utilities built in, as compared to the barebones nature
of the single mod template.
