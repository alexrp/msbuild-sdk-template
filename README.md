# MSBuild SDK Template

This is a template repository showing how to implement a very basic custom
MSBuild SDK and test the resulting package *without* any annoying intermediate
steps like publishing to a remote NuGet feed.

[Here is an article detailing some of the problems that this template solves.](https://alexrp.com/Articles/Sanely+Testing+MSBuild+SDKs)

## Usage

When using this template, be aware that you have to change a bunch of stuff:

* Replace all references to `Foo`, `Foo.Sdk`, `Foo.Tasks`, etc with names that
  make sense for your project.
* Replace name, description, author, licensing, and repository information in
  [`Directory.Build.props`](Directory.Build.props) and
  [`Directory.Build.targets`](Directory.Build.targets) with your own.
* Customize [`.editorconfig`](.editorconfig) to your preferences.
* Add a `NUGET_TOKEN` secret to your new GitHub repository that lets you publish
  release packages.
* Write a new [`README.md`](README.md). 😉

## Building

Building and testing the SDK is straightforward:

```bash
dotnet build
cd src/samples/foo
dotnet build
dotnet run
```

## Contributing

Feel free to send pull requests to this repository, but please note that I will
squash the repository's history into a single commit.
