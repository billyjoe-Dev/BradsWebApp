# Blazor WebAssembly (WASM) .NET Hosted Portfolio Site

Check it out here: [bradfield-dev.com](https://bradfield-dev.com)

## Overview 
This is a simple portfolio and blog built with the .NET 6 hosted version of [Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor). I'm building this application to showcase my skills and experience as a Software Developer while also taking the opportunity to become more proficient in C# and .NET. In addition, I will be implementing a personal blog, where I will write about development topics that interest me and work on improving my technical writing skills.

### Technologies/Tools used
- [Blazor WebAssembly](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)
- C# & .NET Core 6
- JavaScript
- [Tailwind CSS](https://tailwindcss.com/)
- [DaisyUI](https://daisyui.com/)

### Architecture
The solution contains 2 project and 1 still in OR (Operation Room):
- PortfolioWebsite.Client.csproj: The Blazor client application
- OR: PortfolioWebsite.Server.csproj: The .NET Core backend
- PortfolioWebsite.Shared.csproj: The model that will be used to shared across both projects

## Current Status
The portfolio is currently in an early stage of development. So far, I have completed the following tasks:

:heavy_check_mark: Setup the project structure \
:heavy_check_mark: Setup the project dependencies \
:heavy_check_mark: Created a temporary landing page \
:heavy_check_mark: Deployed the project to a [Azure](https://azure.microsoft.com/en-us/) droplet \
:heavy_check_mark: Set up domain Mailbox [Say hello Bradfield](hello@bradfield-dev.com) \
:heavy_check_mark: Finished the main page

## Planned Features
- [ ] Add blog
- [ ] Add featured projects section
:heavy_check_mark: Add custom domain with SSL Certificate [bradfield-dev.com](https://bradfield-dev.com) \
- [ ] Work on mobile friendliness
- [ ] Finish up with Server
- [ ] Render globalized and localized content from DB

## Running the project
1. Install the latest Visual Studio 2022 (at least v17.0.4)
2. Clone the repository
3. Open the solution in Visual Studio and press F5 to build and run (with debugging)

## License
This project is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.en.html).
Please see the [LICENSE.md](LICENSE.md) file for more information.
