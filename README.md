# Kortfattat om ASP.NET

ASP.NET Core är ett ramverk för webbutveklare till för att förenkla byggandet av bland annat webb applikationer och APIs. Det är en så kallad "Cross-Plattform" som kan användas på olika sorters enheter och operativsystem som t.ex Windows, Linux och macOS. Det används framförallt för att det är snabbt och säkert.

# Startup
Det är i klassen Startup vi kan konfigurera hur appen ska fungera. 
I ConfigureServices lägger man till de services man vill att appen ska ha. Som till denna inlämning lades databasen till.  

# WWWRoot
Innehåller bland annat CSS, javascript, bilder mm. Det vill säga alla de statiska filerna som appen använder.

# Razor språket
Razor språket är en markup syntax för server baserad kod till webb platser. Det består av C# och HTML blandat för att bygga upp  Content Page.

# Razor pages
Razor pages är ett template som ingår i ASP.NET Core.
En Razor page består av två filer, en cshtml fil (Content Page) som innhåller det vi kallar Razor språket och en cshtml.cs fil (Page Model) som står för logiken bakom webbsidan. 
I Page Model finns metoder som kallas Page Handlers som OnGet och OnPost för att kunna hantera olika requests från användare. Page Model sköter om all logik till den Content Page den är knuten till.
Content Page står för själva UI:n, alltså hur sidan ser ut.

# MVC

- Model innehåller klasser som beskriver datan som arbetas med.

- View är applikationens UI, vad användaren ser och interagerar med. 

- Controller tar emot data från användaren (från View) och kommunicerar den vidare till Model vid behov. Hela applikationens flöde och logik.
