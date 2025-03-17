# BoursoOFXMoney

## Overview

BoursoOFXMoney is a solution designed to convert OFX (Open Financial Exchange) files exported by BoursoBank into a valid format that can be used by Microsoft Money 2005. The solution consists of two main projects:

1. **Converter**: A library that handles the conversion logic.
2. **Converter.UI**: A Windows Forms application that provides a user interface for the conversion process.

## Projects

### Converter

The `Converter` project is a class library that contains the core functionality for converting OFX files. It includes the following key components:

- **CommonOFX.cs**: Defines the structure of the OFX file using XML serialization.
- **InputBoursoOFX.cs**: Represents the input OFX structure.
- **OutputBoursoOFX.cs**: Represents the output OFX structure.
- **Tool.cs**: Contains the main conversion logic.
- **XmlTools.cs**: Provides utility methods for XML serialization.

### Converter.UI

The `Converter.UI` project is a Windows Forms application that provides a graphical user interface for the conversion process. It includes the following key components:

- **MainWindow.cs**: The main form of the application.
- **MainWindow.Designer.cs**: The designer file for the main form.
- **Program.cs**: The entry point of the application.

## Usage

1. **Build the Solution**: Open the solution in Visual Studio and build it to generate the necessary binaries.
2. **Run the Application**: Start the `Converter.UI` project to launch the Windows Forms application.
3. **Select Source File**: Use the "Browse" button to select the source OFX file.
4. **Convert File**: Click the "Convert" button to convert the selected OFX file to a valid format.
5. **Save Converted File**: Choose the destination path to save the converted OFX file.

## Dependencies

- .NET 8.0
- Windows Forms

## License

This project is licensed under the MIT License.

## Contact

For any questions or issues, please contact the project maintainer.
