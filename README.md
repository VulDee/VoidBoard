# VoidBoard
An open source passion project for people who can't afford a physical soundboard

---

## table of contents

- [how to install and use](#how-to-install-and-use)
- [how to rebuild](#how-to-rebuild)
- [rights](#rights)
- [credits](#credits)

---

## how to install and use

### requirements

- windows 10/11
- .net 8 sdk
- vb-cable (recommended for microphone routing)

### installation

1. download the latest release from the releases tab
2. extract the zip file
3. run `VoidBoard.exe`
4. drag mp3 files into sound slots
5. assign hotkeys if needed
6. select your input/output devices
7. if using discord or game vc, set VB-CABLE as your microphone

### default hotkeys

- `capslock + 0-9` for sound slots
- `F9` reopens the gui when hidden

### features

- 10 sound slots
- drag and drop mp3 support
- custom volume per slot
- dark/light/system themes
- tray mode
- global hotkeys
- config saving
- virtual audio cable support

---

## how to rebuild

### requirements

install these first:

- visual studio code
- .net 8 sdk
- git

### clone the repository

```bash
git clone https://github.com/VulDee/VoidBoard.git
```

### open the folder

```bash
cd VoidBoard
code .
```

### restore packages

```bash
dotnet restore
```

### run the app

```bash
dotnet run
```

### build a release version

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

compiled files will be inside:

```text
bin/Release/net8.0-windows/win-x64/publish/
```

---

## rights

VoidBoard is licensed under the MIT license.

you are allowed to:
- use
- modify
- redistribute
- fork
- improve
- make custom builds

just keep the original license included with the software.

---

## credits

created by Nate
