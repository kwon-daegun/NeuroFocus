# 🧠 NeuroFocus

> **A Calm, Adaptive Desktop Environment for Neurodivergent Minds.**

**NeuroFocus** is a desktop environment controller designed to assist individuals with **ADHD** and **Autism** who experience sensory overload or executive dysfunction. By orchestrating Windows settings, audio, and visual elements into "Focus Modes," it helps users maintain a regulated state suitable for work, rest, or play.

Built with performance and accessibility in mind using **.NET 8** and **WPF**.

## 🎯 Core Mission

Modern operating systems are noisy, bright, and demanding. For neurodivergent users, this can lead to rapid burnout and sensory overwhelm. NeuroFocus acts as a "sensory gatekeeper," allowing users to create preset environments that instantly adapt the OS to their current mental energy levels.

## ✨ Key Features (Planned)

- **🛡️ Sensory Profiles:** Create profiles like "Deep Work," "Decompression," or "Low Energy."
  - _Example:_ One click to dim screens, mute non-essential apps, and enable grayscale mode.
- **🔇 Audio Partitioning:** Automatically route distracting applications to muted channels while keeping essential audio (e.g., white noise, meetings) active.
- **👁️ Visual Noise Reduction:** Toggle desktop icons, taskbar auto-hide, and simplify window borders to reduce visual clutter.
- **🍅 Executive Function Assists:** Integrated customized Pomodoro timers that trigger sensory shifts (e.g., screen warms up during breaks).
- **📊 Usage Insights:** Local data tracking (via MSSQL) to help users understand what times of day they are most focused or overwhelmed.

## 🛠️ Tech Stack

- **Framework:** .NET 8.0
- **UI Framework:** WPF (Windows Presentation Foundation)
- **Pattern:** MVVM (Model-View-ViewModel) using the CommunityToolkit.Mvvm
- **Database:** Microsoft SQL Server (MSSQL) LocalDB / Express
- **ORM:** Entity Framework Core (EF Core)
- **DI:** Microsoft.Extensions.DependencyInjection

## 🚀 Getting Started

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (v17.8 or later)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or LocalDB)

### Installation

1.  **Clone the repository**

    ```bash
    git clone [https://github.com/kwon-daegun/NeuroFocus](https://github.com/kwon-daegun/NeuroFocus.git)
    cd NeuroFocus
    ```

2.  **Configure Database**

    - Update the connection string in `appsettings.json` to point to your local MSSQL instance.
    - Run migrations to create the database:

    ```bash
    dotnet ef database update
    ```

3.  **Build and Run**
    - Open the solution file `NeuroFocus.sln` in Visual Studio.
    - Set `NeuroFocus.Desktop` as the startup project.
    - Press `F5` to run.

## 🤝 Contributing

We welcome contributions from developers, designers, and specifically from neurodivergent users who can provide feedback on accessibility and UX.

1.  Fork the Project
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  Push to the Branch (`git push origin feature/AmazingFeature`)
5.  Open a Pull Request

## 📄 License

Distributed under the MIT License. See `LICENSE` for more information.
