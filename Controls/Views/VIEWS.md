# .NET MAUI Views

.NET MAUI Views are the building blocks of user interfaces, providing a wide range of controls to create stunning cross-platform apps. From simple labels to advanced layouts, Views are versatile and powerful tools for UI development.


### **Key Features**
• Highlight the unique aspects of .NET MAUI Views, such as:
   >> Cross-platform compatibility.

   >> Native performance and look-and-feel.

   >> A rich library of built-in controls.

------

## Activity Indicator

The Activity Indicator is a visual representation used to inform users that a process or activity is ongoing in the background.

### Key Properties:
- **`IsRunning`:** A boolean value indicating whether the Activity Indicator is currently spinning.
- **`Color`:** Sets the color of the indicator for better customization.
- **`IsVisible`:** A boolean value determining whether the indicator is shown on the screen.

------

## BlazorWebView

The BlazorWebView is a control that enables you to host a Blazor application within a .NET MAUI app. It allows seamless integration of Blazor components for building interactive and modern web-based user interfaces.

### Key Properties:
- **`HostPage`:** Specifies the path to the HTML file that acts as the host for the Blazor components.
- **`RootComponents`:** Manages the collection of Blazor root components that are rendered in the BlazorWebView.
- **`Services`:** Configures dependency injection by providing service instances to the Blazor application.

------

## Border

The Border control is used to create a rectangular or rounded container for visual elements, making it ideal for styling and organizing content in a .NET MAUI app.

### Key Properties:
- **`Background`:** Sets the background color of the border container.
- **`Stroke`:** Specifies the color of the border stroke.
- **`StrokeShape`:** Defines the shape of the border, such as a rectangle or rounded corners.
- **`StrokeThickness`:** Determines the width of the border stroke.

------

## BoxView

The BoxView control is a simple rectangular shape, ideal for creating visual elements such as lines, dividers, or colored blocks in a .NET MAUI app.

### Key Properties:
- **`Color`:** Sets the fill color of the BoxView.
- **`CornerRadius`:** Defines the radius of the corners, enabling rounded rectangles.
- **`WidthRequest` and `HeightRequest`:** Specify the desired width and height of the BoxView.

**Output:**

https://github.com/user-attachments/assets/bbac237a-cba6-48d3-970c-36c7c7d981e5

------

## Button

The Button control is a fundamental interactive element that allows users to trigger actions when tapped or clicked in a .NET MAUI app.

### Key Properties:
- **`Text`:** Specifies the text displayed on the button.
- **`BackgroundColor`:** Sets the background color of the button.
- **`Command`:** Binds a command to be executed when the button is pressed.
- **`FontAttributes`:** Adjusts the text style, such as bold or italic.

**Output:**

https://github.com/user-attachments/assets/04e2d27b-45ca-4797-a334-c33e15933389

------

## CarouselView

The CarouselView control is a flexible container for displaying a collection of items in a horizontally or vertically scrollable layout. It is commonly used for creating image sliders or item carousels in a .NET MAUI app.

### Key Properties:
- **`ItemsSource`:** Specifies the collection of items to be displayed in the CarouselView.
- **`ItemTemplate`:** Defines the template for rendering each item in the carousel.
- **`IsBounceEnabled`:** A boolean value indicating whether the carousel bounces when it reaches the end of the scrollable area.
- **`PeekAreaInsets`:** Sets the visible area of items adjacent to the currently displayed item.

**Output:**

https://github.com/user-attachments/assets/aa53f326-bbd3-450f-a686-79eff5b9b11b

------

## Cell

The Cell class is used as a base class for creating cells in a list or table view. It provides a flexible way to display and format data in .NET MAUI applications.

### Key Properties:
- **`Height`:** Specifies the height of the cell.
- **`IsEnabled`:** Determines whether the cell is interactive or disabled.
- **`Parent`:** Refers to the parent object of the cell, typically a ListView or TableView.

**Output:**

https://github.com/user-attachments/assets/5beba81b-fa35-4604-b821-7382cf45d824

------

## CheckBox

The CheckBox control allows users to select or deselect an option, making it useful for input scenarios that require binary choices in a .NET MAUI app.

### Key Properties:
- **`IsChecked`:** A boolean value indicating whether the CheckBox is checked or unchecked.
- **`Color`:** Sets the color of the CheckBox when it is checked.
- **`Command`:** Executes a bound command when the CheckBox's state changes.

**Output:**

https://github.com/user-attachments/assets/4b5ac89e-e79b-426d-98b0-0f4e21c9dfa7

------

## CollectionView

The CollectionView control is a flexible and efficient way to display a collection of data in a customizable layout. It is ideal for scenarios like lists, grids, or custom layouts in .NET MAUI applications.

### Key Properties:
- **`ItemsSource`:** Specifies the collection of items to display in the CollectionView.
- **`ItemTemplate`:** Defines the template used to render each item in the collection.
- **`Layout`:** Determines the layout for the CollectionView, such as a vertical list or a grid.
- **`SelectionMode`:** Specifies how items can be selected, such as Single, Multiple, or None.

**Output:**

![_09_CollectionView](https://github.com/user-attachments/assets/f2c7bff4-dc3b-4b86-a93e-d3e1aca56a6d)

------

## ContentView

The ContentView control is a container that provides a simple way to organize and display a single child element, making it useful for creating reusable components in .NET MAUI applications.

### Key Properties:
- **`Content`:** Specifies the single child element to display within the ContentView.
- **`Padding`:** Defines the space between the ContentView's edges and its child element.
- **`BackgroundColor`:** Sets the background color of the ContentView for styling purposes.

**Output:**

![_10_ContentView](https://github.com/user-attachments/assets/186396bb-47e0-41c9-a15b-89983364cd59)

------

## DatePicker

The DatePicker control allows users to select a date from an interactive calendar, making it a convenient option for date-related inputs in .NET MAUI apps.

### Key Properties:
- **`Date`:** Gets or sets the selected date.
- **`MinimumDate` and `MaximumDate`:** Define the range of dates the user can select.
- **`Format`:** Specifies the display format of the date, such as `MM/dd/yyyy`.

**Output:**

https://github.com/user-attachments/assets/bf39d448-07b1-4e28-986a-eed940dd131d

------

## Editor

The Editor control provides a multi-line text input field, ideal for scenarios where users need to enter or edit larger amounts of text in a .NET MAUI app.

### Key Properties:
- **`Text`:** Gets or sets the text displayed in the Editor.
- **`Placeholder`:** Specifies the text that is displayed when the Editor is empty.
- **`Keyboard`:** Determines the type of keyboard displayed, such as numeric or text-based.

**Output:**

![_12_Editor](https://github.com/user-attachments/assets/f2189c9a-f0f6-4717-958e-897f1ee56a2d)

https://github.com/user-attachments/assets/5cbe754a-767f-4b91-bfe7-0fc2e2acca36

------

## Entry

The Entry control provides a single-line text input field, commonly used for forms or user data entry in .NET MAUI apps.

### Key Properties:
- **`Text`:** Gets or sets the text displayed in the Entry field.
- **`Placeholder`:** Specifies the text displayed when the Entry field is empty.
- **`IsPassword`:** A boolean value that determines whether the Entry is used for entering passwords, masking the input.

**Output:**

https://github.com/user-attachments/assets/fcff2d9e-1e18-494a-944e-80d137b57bfd

------

## GraphicsView

The GraphicsView control provides a canvas for rendering 2D graphics using .NET MAUI's drawing APIs. It is highly versatile and enables custom visualizations, animations, and designs.

### Key Properties:
- **`Drawable`:** Defines the object responsible for rendering custom graphics on the canvas.
- **`HeightRequest` and `WidthRequest`:** Specify the desired height and width of the GraphicsView.
- **`BackgroundColor`:** Sets the background color of the canvas.

**Output:**

https://github.com/user-attachments/assets/909c9b73-314a-40c8-adad-7b8999d5ac01

------

## HybridWebView

The HybridWebView control is a specialized web view that enables communication between .NET MAUI applications and JavaScript running within the web content. It provides a way to build powerful web-integrated apps.

### Key Properties:
- **`Uri`:** Specifies the URL or local file path to load in the web view.
- **`EnableJavaScript`:** A boolean value that determines whether JavaScript is enabled in the web view.
- **`EvaluateJavaScriptAsync`:** Executes JavaScript code in the web content and returns the result asynchronously.

------

## ImageButton

The ImageButton control combines an image with the functionality of a button, allowing users to perform actions when the image is tapped or clicked in a .NET MAUI app.

### Key Properties:
- **`Source`:** Specifies the image to display on the button.
- **`Command`:** Binds a command to be executed when the ImageButton is pressed.
- **`Aspect`:** Determines how the image is scaled within the button (e.g., Fill, AspectFit, AspectFill).
- **`BorderColor`:** Sets the color of the button's border for styling.

**Output:**

https://github.com/user-attachments/assets/19a2f8bc-d9bb-4556-8d0f-e41413341306

------

## IndicatorView

The IndicatorView control is used to display indicators that represent the number of items in a `CarouselView` and indicate the currently visible item.

### Key Properties:
- **`ItemsSource`:** Specifies the collection of items the IndicatorView represents.
- **`IndicatorColor`:** Sets the color of unselected indicators.
- **`SelectedIndicatorColor`:** Sets the color of the currently selected indicator.
- **`IndicatorSize`:** Defines the size of each indicator dot for customization.

**Output:**

https://github.com/user-attachments/assets/8ea617d9-ac3b-46c2-99c8-db115271fa21

------

## Label

The Label control is used to display text in a .NET MAUI application. It is a versatile control that supports a wide range of formatting and styling options.

### Key Properties:
- **`Text`:** Specifies the text to be displayed in the Label.
- **`FontSize`:** Sets the size of the text for customization.
- **`TextColor`:** Defines the color of the text.
- **`HorizontalTextAlignment` and `VerticalTextAlignment`:** Adjust the alignment of the text within the Label.

**Output:**

![_19_Label](https://github.com/user-attachments/assets/200e3cd8-c584-4798-9f38-a216ee8dea25)

------

## Line

The Line class is used to draw straight lines in a .NET MAUI application, ideal for creating custom graphics or visual dividers.

### Key Properties:
- **`X1` and `Y1`:** Define the starting point coordinates of the line.
- **`X2` and `Y2`:** Define the ending point coordinates of the line.
- **`Stroke`:** Specifies the color of the line.
- **`StrokeThickness`:** Determines the width of the line.

**Output:**

![_20_Line](https://github.com/user-attachments/assets/9c2d1b38-f3f0-4f70-815a-289842909b85)

------

## ListView

The ListView control is used to display a vertical scrollable list of items. It supports templates for defining how each item is displayed and allows for interactive features like item selection.

### Key Properties:
- **`ItemsSource`:** Specifies the collection of items to display in the ListView.
- **`ItemTemplate`:** Defines the template for rendering each item in the list.
- **`SelectionMode`:** Determines whether items can be selected and the type of selection (None, Single, or Multiple).
- **`SeparatorColor`:** Sets the color of the separator between items for better styling.

**Output:**


