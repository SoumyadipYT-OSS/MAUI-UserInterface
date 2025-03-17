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

https://github.com/user-attachments/assets/5cbe754a-767f-4b91-bfe7-0fc2e2acca36

------

## Entry

The Entry control provides a single-line text input field, commonly used for forms or user data entry in .NET MAUI apps.

### Key Properties:
- **`Text`:** Gets or sets the text displayed in the Entry field.
- **`Placeholder`:** Specifies the text displayed when the Entry field is empty.
- **`IsPassword`:** A boolean value that determines whether the Entry is used for entering passwords, masking the input.

**Output:**

------
