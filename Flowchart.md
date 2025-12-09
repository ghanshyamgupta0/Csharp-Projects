 ┌──────────────────┐
 │ Start Application │
 └───────┬──────────┘
         │
         ▼
 ┌────────────────────┐
 │ Load UI / CLI Menu │
 └───────┬────────────┘
         │
         ▼
 ┌──────────────────────────────────────────────┐
 │ User selects operation:                       │
 │ 1. Generate File Hash                         │
 │ 2. Compare File Hash                          │
 │ 3. Monitor Folder for Changes (optional)      │
 │ 4. Exit                                       │
 └───────┬───────────────────────────────────────┘
         │
         ├───────────────────────────┐
         │                           │
         ▼                           ▼
 ┌──────────────────┐        ┌──────────────────────┐
 │ Generate Hash     │        │ Compare Hash         │
 └───────┬───────────┘        └───────────┬─────────┘
         │                                  │
         ▼                                  ▼
 ┌──────────────────────────┐      ┌────────────────────────────┐
 │ Ask user to choose file  │      │ Ask user for two files or   │
 │                          │      │ file + saved hash           │
 └───────┬──────────────────┘      └────────────┬───────────────┘
         │                                       │
         ▼                                       ▼
 ┌─────────────────────────┐         ┌───────────────────────────┐
 │ Compute hash (SHA256,   │         │ Compute/Load both hashes  │
 │ SHA512, MD5, etc.)      │         └────────────┬──────────────┘
 └───────┬─────────────────┘                      │
         │                                        ▼
         ▼                             ┌──────────────────────┐
 ┌────────────────────────┐            │ Compare hash values  │
 │ Display hash to user   │            └───────────┬──────────┘
 │ Save to file? (Y/N)    │                        │
 └───────┬────────────────┘                        ▼
         │                                ┌────────────────────────┐
         ▼                                │ Match => Integrity OK   │
 ┌─────────────────────────────┐          ├────────────────────────┤
 │ Write hash to .hash file    │          │ Not Match => Tampered   │
 └──────────┬──────────────────┘          └────────────────────────┘
            │
            ▼
 ┌──────────────────┐
 │      End         │
 └──────────────────┘



 FileIntegrityChecker/
│
├── FileIntegrityChecker.csproj
│
├── Program.cs
│
├── Core/
│   ├── HashComputer.cs
│   ├── FileComparator.cs
│   ├── HashAlgorithms.cs
│   └── DirectoryMonitor.cs       (optional: for folder monitoring)
│
├── Models/
│   └── HashResult.cs
│
├── Services/
│   ├── LoggerService.cs
│   ├── FileService.cs
│   └── ConfigService.cs          (optional)
│
├── UI/
│   ├── Menu.cs
│   └── ConsolePrinter.cs
│
└── Utils/
    ├── Extensions.cs
    └── PathUtils.cs

