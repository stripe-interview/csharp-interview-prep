## Motivation:

At Stripe, our interview process has some interviews where you write
code, typically on your laptop.

We've noticed that more often than not, we've had to spend a significant
portion of the interview helping candidates setup a C#
environment on their personal laptops.

We've created a (rather ad-hoc) C# solution to help candidates
determine if their laptops were setup to write C#, so interviews can
be about evaluating the candidate, and not the way their environment is
setup.

# Getting Ready

If you have not already, please install [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

This solution supports the following  development environments.

## Console (Windows, Linux, OSX)
in the directory of the repo run
```sh
dotnet restore
dotnet build
dotnet test tests/
```

If ```dotnet restore``` fails, is likely you are missing nuget.org feed. You can addit by following this instructions: [Adding Nuget.org](https://docs.microsoft.com/en-us/nuget/resources/nuget-faq#i-don-t-see-nuget-org-in-my-list-of-repositories--how-do-i-get-it-back-)

## Visual Studio Code (Windows, Linux, OSX)
Open the directory of the repo

Open the command palette

Select `Tasks: Run Test Task`

## Visual Studio 2019 (Windows)
Open `csharp-interview-prep.sln`

Open Test Explorer

Click `Run all`

Ensure you can run and debug the included tests using your preferred environment.
This project uses xUnit for implementing and executing tests.

# About This Project:

## I prefer .Net Framework 6/nUnit/Bespoke Powershell Scripts, do I need to use this?

If you prefer different configuration files, that's awesome.
Some interview questions may ask to implement something from nothing,
and some may want to watch you interact with a pre-existing codebase.
For the former, it doesn't matter what you use, as long as you're able
to get things setup quickly.

Concerning the latter: xUnit is a common library for implementing unit
tests in C#.
Because of that, all pre-existing codebases we use in our interviews use
xUnit.
We aren't really specifically interested in how great your are at writing
xUnit tests, but want you to quickly get them up and running.

## Useful References:
- [.NET](https://dotnet.microsoft.com/)
- [xUnit](https://xunit.github.io/)
