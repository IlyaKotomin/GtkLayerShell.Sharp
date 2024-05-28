# GtkLayerShell.Sharp

GtkLayerShell.Sharp is a C# wrapper for the GTK Layer Shell library, providing functionality to create panels and other desktop components using GTK in a Wayland environment.

## Features

- Retrieve GTK Layer Shell library version information
- Check if GTK Layer Shell is supported
- Initialize and configure GTK windows as layer shell surfaces
- Set and get window properties like namespace, layer, anchors, margins, and exclusive zones
- Control keyboard interactivity and mode for layer windows

## Requirements

- .NET 6.0 or later
- GTK Sharp
- GTK 3.0 or later
- GTK Layer Shell library

## Installation

To use GtkLayerShell.Sharp in your project, you need to install the necessary dependencies and configure your environment.

1. Install the GTK Layer Shell library. Refer to the [official GTK Layer Shell documentation](https://github.com/wmww/gtk-layer-shell) for installation instructions.
2. Add the GtkLayerShell.Sharp package to your .NET project.

## Usage

Here's a basic example of how to use GtkLayerShell.Sharp in a .NET project:

```csharp
using System;
using Gtk;
using GtkLayerShell.Sharp;
using GtkLayerShell.Sharp.Global;

class Program
{
    static void Main()
    {
        Application.Init();

        Window window = new Window("GtkLayerShell.Sharp Example");
        window.SetDefaultSize(800, 600);
        window.DeleteEvent += (o, args) => Application.Quit();

        LayerShell.InitWindow(window);
        LayerShell.SetLayer(window, Layer.Top);
        LayerShell.SetAnchor(window, Edge.Top, true);
        LayerShell.SetAnchor(window, Edge.Left, true);
        LayerShell.SetAnchor(window, Edge.Right, true);
        LayerShell.SetExclusiveZone(window, -1);

        window.ShowAll();
        Application.Run();
    }
}
```
## Contributing

Contributions are welcome! Please submit a pull request or open an issue to discuss your ideas.

## License

This project is licensed under the GNU GENERAL PUBLIC LICENSE. See the [LICENSE](LICENSE) file for more details.

## Acknowledgements

This project is inspired by the [GTK Layer Shell](https://github.com/wmww/gtk-layer-shell) project. Special thanks to all contributors of the GTK Layer Shell library.

---

For more details, refer to the source code and additional documentation provided in the project repository.
