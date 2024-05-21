# GraphicalRepresentation

This project is a simple Windows Forms application that plots a parametric curve based on the equations:

\[ x = R \cos^3(t) \]
\[ y = R \sin^3(t) \]

## Features

- Displays a coordinate system with labeled axes.
- Accepts user input for the parameter \( R \).
- Calculates and plots the points of the curve based on the parametric equations.
- Handles different ranges of the parameter \( t \).

## Requirements

- Visual Studio 2022
- .NET Framework

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine.

### Prerequisites

Ensure you have Visual Studio 2022 installed with the .NET desktop development workload.

### Installation

1. Clone the repository to your local machine using:
    ```sh
    git clone https://github.com/toliaa/Graphical-representation-of-the-function.git
    ```

2. Open the solution file `GraphicalRepresentation.sln` in Visual Studio 2022.

3. Build the project by selecting `Build > Build Solution` or by pressing `Ctrl+Shift+B`.

4. Run the project by selecting `Debug > Start Debugging` or by pressing `F5`.

## Usage

1. Enter the value of the coefficient \( R \) in the text box.
2. Click the "Draw" button to plot the graph of the parametric equations.
3. The results will be displayed on the panel. If the input is invalid, an error message will be shown.

### Example Inputs and Outputs

- **Example with \( R = 1 \)**:
  - Input: `R = 1`
  - Output: A parametric curve based on the equations \( x = \cos^3(t) \) and \( y = \sin^3(t) \).

- **Example with invalid input**:
  - Input: `R = abc`
  - Output: `Please enter a valid numeric value for R.`

## Project Structure

- **GraphicalRepresentation.cs**: Contains the main logic for handling user input and plotting the graph.
- **GraphicalRepresentation.Designer.cs**: Contains the auto-generated code for the UI components.
- **Program.cs**: Contains the entry point of the application.

## Error Handling

- **FormatException**: Caught when the user inputs non-numeric values. Displays a message box prompting the user to enter valid numeric values.
- **Exception**: Catches all other exceptions and displays a generic error message.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- The project was developed using Visual Studio 2022.
- The parametric equation plotting logic is based on standard mathematical formulas.
