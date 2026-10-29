# C# Desktop Application for RPA Training

A Windows Forms application built as an example target for robotic process automation. It is paired with [UIPathDataInputRPA](https://github.com/TonyJimenezDev/UIPathDataInputRPA), which uses Excel rows to populate the application and report processing status.

## Technical overview

- Language: C#
- UI: Windows Forms
- Target framework: .NET Framework 4.7.2
- Solution: `DataInputsRPATraining.sln`
- Application project: `DataInputsRPATraining/DataInputsRPATraining.csproj`

The source contains login, country-selection, and inventory forms. The country-selection flow opens USA, Japan, or China inventory forms.

## Suggested local setup

1. Use a Windows development environment with Visual Studio desktop .NET tooling and the .NET Framework 4.7.2 targeting components.
2. Open `DataInputsRPATraining.sln`.
3. Inspect the code and configuration, then build and launch the application.
4. Use synthetic inputs when pairing it with the UiPath automation.
5. Check the bot's paths and selectors against the application that is actually running.

These are setup directions derived from the project structure. A successful clean build has not been verified by this documentation update.

## Demonstration scope

The login form contains fixed demonstration credentials. It is a training interface, not a production authentication system. Do not reuse that authentication design or enter real passwords into the example application.

## Source layout

- `Forms/`: launch, login, and country selection
- `Inventory/`: country-specific inventory forms
- `InputData.cs`: input-data code
- `Program.cs`: application startup

## Validation still needed

- Clean build and launch on the documented Windows environment
- End-to-end processing with a small synthetic workbook
- Verification of completion and exception reporting in the companion bot
- Review of bundled data and screenshots before recording a public demonstration

No employer/client code, production deployment, or measured business outcome is claimed by this project description.
