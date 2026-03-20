# UITK System

* This package is an extension for Unity UI Toolkit System.
* Unity minimum version: **6000.1**
* Current version: **0.1.0**
* License: **MIT**

## Extensions

There are some usefull extensions you can use on the [Extensions Folder](/Runtime/Extensions/).

Here are some examples:

```csharp
using ActionCode.UITKSystem; // Add UITKSystem namespace

var root = // find a VisualElement from a UIDocument.
var label = root.Find<Label>(name: "MyText"); // Finds a Label with 'MyText' name. Shows an error if element is not found.

label.SetDisplayEnabled(true); // Sets whether the element should be displayed in the layout.
label.SetSelectableEnabled(false); // Sets whether the element can be selected.

if (label.IsFocused()) { } // Check whether the element is currently focused.
```

## Installation

### Using the Package Registry Server

Follow the instructions inside [here](https://cutt.ly/ukvj1c8) and the package **ActionCode-UI System** 
will be available for you to install using the **Package Manager** windows.

### Using the Git URL

You will need a **Git client** installed on your computer with the Path variable already set. 

- Use the **Package Manager** "Add package from git URL..." feature and paste this URL: `https://github.com/HyagoOliveira/UITKSystem.git`

- You can also manually modify you `Packages/manifest.json` file and add this line inside `dependencies` attribute: 

```json
"com.actioncode.uitk-system":"https://github.com/HyagoOliveira/UITKSystem.git"
```

---

**Hyago Oliveira**

[GitHub](https://github.com/HyagoOliveira) -
[BitBucket](https://bitbucket.org/HyagoGow/) -
[LinkedIn](https://www.linkedin.com/in/hyago-oliveira/) -
<hyagogow@gmail.com>