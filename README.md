# ShelfTalkers

C# pharmacy shelf-talker tools (Savemor, 2013): LabelMaker Admin pulls the product catalog from SQL Server and FTP-uploads Products.xml; the store LabelMaker downloads that catalog and prints shelf talkers; ShelfTalkerHost is a WPF (.NET 3.5) label viewer. Live SQL and FTP credentials in `app.config` and `Settings.settings` have been replaced with placeholders (see the committed `*.example` files). Open `ShelfTalkers.sln` in Visual Studio.

**Source last updated:** 2013-09-09  
**Language:** C#  
**Target:** v3.5  
**Output:** WinExe

## What it is

C# pharmacy shelf-talker tools (Savemor, 2013): LabelMaker Admin pulls the product catalog from SQL Server and FTP-uploads Products.xml; the store LabelMaker downloads that catalog and prints shelf talkers; ShelfTalkerHost is a WPF (.NET 3.5) label viewer. Live SQL and FTP credentials in `app.config` and `Settings.settings` have been replaced with placeholders (see the committed `*.example` files). Open `ShelfTalkers.sln` in Visual Studio.

## Solution structure

| Project | Language | Path |
|---------|----------|------|
| `Admin` | C# | `Admin/Admin.csproj` |
| `LabelMaker` | C# | `LabelMaker/LabelMaker.csproj` |
| `WPF` | C# | `WPF/WPF.csproj` |

The solution also includes InstallShield projects `Setup/Setup.isproj` and `AdminSetup/AdminSetup.isproj` (DiskImages binaries are gitignored).

## How to open

Open `ShelfTalkers.sln` in Visual Studio. Copy each `*.example` file to the matching `app.config` or `Settings.settings` name and fill in local SQL/FTP values before running Admin or LabelMaker.

## Attribution and provenance

- **Assembly company:** Vader Consulting
- **Assembly copyright:** Copyright © 2013, Copyright © Vader Consulting 2013

## License

MIT. See `LICENSE`.
