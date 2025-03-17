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

https://github.com/user-attachments/assets/3bb7443a-cf45-4129-a1df-ded08517ce66

------

## Map

The Map control allows you to display and interact with maps in a .NET MAUI application. It supports features like pin placement, zooming, and map types for enhanced user experiences.

### Key Properties:
- **`MapType`:** Specifies the type of map to display, such as Street, Satellite, or Hybrid.
- **`Pins`:** A collection of pins that mark specific locations on the map.
- **`IsZoomEnabled`:** A boolean value indicating whether the user can zoom in and out on the map.
- **`IsScrollEnabled`:** A boolean value indicating whether the user can scroll or pan the map.

**Output:**

https://github.com/user-attachments/assets/9de38e91-9c03-46b2-b1d5-f3434985bc7e

------

## Path

The Path class is a powerful control for creating and displaying vector-based shapes in a .NET MAUI application. It is highly customizable and allows you to draw complex graphics.

### Key Properties:
- **`Data`:** Specifies the geometry data that defines the shape of the path (e.g., line, curve, or complex polygons).
- **`Fill`:** Sets the color or brush used to fill the interior of the path.
- **`Stroke`:** Defines the color or brush for the outline of the path.
- **`StrokeThickness`:** Specifies the width of the path's outline.

**Output:**

https://github.com/user-attachments/assets/8609a7d5-73be-45e2-914f-0af6739329f7

------

## Picker

The Picker control provides a dropdown-like interface for users to select a single item from a predefined list in a .NET MAUI application.

### Key Properties:
- **`ItemsSource`:** Specifies the collection of items to display in the picker.
- **`SelectedIndex`:** Gets or sets the zero-based index of the currently selected item.
- **`SelectedItem`:** Gets or sets the currently selected item from the `ItemsSource`.
- **`Title`:** Sets the placeholder text displayed when no item is selected.

**Output:**

https://github.com/user-attachments/assets/657e484a-ae8a-4e63-8faf-86de31d41f2a

------

## ProgressBar

The ProgressBar control is used to visually represent the progress of a task in a .NET MAUI application. It provides a simple way to give feedback on the completion status of operations.

### Key Properties:
- **`Progress`:** A double value (0.0 to 1.0) that represents the current progress of the task.
- **`ProgressColor`:** Sets the color of the progress indicator for styling.
- **`IsIndeterminate`:** A boolean value that indicates whether the progress is indeterminate (useful for ongoing tasks without a defined completion percentage).

**Output:**

https://github.com/user-attachments/assets/6ee2494a-cc06-4344-8cf1-24b6663cf1e5

------

## RadioButton

The RadioButton control allows users to select a single option from a group of choices, making it ideal for implementing mutually exclusive selections in a .NET MAUI application.

### Key Properties:
- **`IsChecked`:** A boolean value indicating whether the RadioButton is selected.
- **`Content`:** Specifies the content displayed alongside the RadioButton (e.g., text or an image).
- **`GroupName`:** Assigns the RadioButton to a logical group, ensuring only one RadioButton in the group can be selected at a time.
- **`Command`:** Executes a bound command when the RadioButton's state changes.

**Output:**

![_26_RadioButton](https://github.com/user-attachments/assets/9a0f81d0-5817-4ac6-866b-8c7a8696656b)

------

## Rectangle

The Rectangle class is used to create rectangular shapes in a .NET MAUI application, offering customization options for styling and layout.

### Key Properties:
- **`WidthRequest` and `HeightRequest`:** Specify the desired width and height of the rectangle.
- **`Fill`:** Sets the color or brush used to fill the interior of the rectangle.
- **`Stroke`:** Defines the color or brush for the border of the rectangle.
- **`StrokeThickness`:** Specifies the width of the rectangle's border.
- **`RadiusX` and `RadiusY`:** Determine the x- and y-axis radii for rounded corners.


**Output:**

https://github.com/user-attachments/assets/1197bfe5-5aaf-457b-8389-ac5fe874cc63

------

## RefreshView

The RefreshView control provides a pull-to-refresh gesture, allowing users to refresh the content of a view, such as a ListView or CollectionView, in a .NET MAUI application.

### Key Properties:
- **`Command`:** Specifies the command to execute when the refresh gesture is triggered.
- **`IsRefreshing`:** A boolean value indicating whether the refresh is in progress.
- **`Content`:** Represents the content to be refreshed, typically a scrollable view like a ListView or CollectionView.

**Output:**

https://github.com/user-attachments/assets/7a7d884b-0c11-41fb-8471-b8dc7bda453e

------

## ScrollView

The ScrollView control enables scrolling for its content, allowing users to view content that is larger than the visible area in a .NET MAUI application.

### Key Properties:
- **`Content`:** Specifies the child element to display inside the ScrollView.
- **`Orientation`:** Determines the direction of scrolling, such as `Vertical`, `Horizontal`, or `Both`.
- **`IsEnabled`:** Indicates whether scrolling is enabled or disabled.

**Output:**

https://github.com/user-attachments/assets/ce38b3d5-eac8-4dce-8134-905e402b8c60

------

## SearchBar

The SearchBar control allows users to input and submit search queries, making it ideal for filtering or searching within a .NET MAUI application.

### Key Properties:
- **`Text`:** Gets or sets the current search query entered in the SearchBar.
- **`Placeholder`:** Specifies the text displayed when the SearchBar is empty.
- **`SearchCommand`:** Executes a bound command when the user submits a search.
- **`TextChanged`:** Triggers an event whenever the text in the SearchBar changes.


**Output:**

https://github.com/user-attachments/assets/069c7853-ddae-487c-9556-b0f3b52fac83

------

## Slider

The Slider control provides a user-friendly interface for selecting a numeric value from a specified range in a .NET MAUI application. It is commonly used for scenarios like adjusting settings or inputting a range value.

### Key Properties:
- **`Minimum`:** Specifies the minimum value of the range.
- **`Maximum`:** Specifies the maximum value of the range.
- **`Value`:** Gets or sets the current value of the Slider.
- **`ThumbColor`:** Sets the color of the slider's thumb (the draggable circle).
- **`MinimumTrackColor` and `MaximumTrackColor`:** Define the colors for the track segments before and after the thumb.

**Output:**

https://github.com/user-attachments/assets/462a3170-e477-4de7-b117-70d16d248647

------

## Stepper

The Stepper control provides an easy way for users to increment or decrement a numeric value, often used for input fields requiring small adjustments in a .NET MAUI application.

### Key Properties:
- **`Minimum`:** Specifies the minimum value for the Stepper.
- **`Maximum`:** Specifies the maximum value for the Stepper.
- **`Increment`:** Sets the value by which the Stepper increases or decreases.
- **`Value`:** Gets or sets the current value of the Stepper.

**Output:**

https://github.com/user-attachments/assets/fb58fbc1-eff2-4e2c-a266-d4eb5febc4da

------

## SwipeView

The SwipeView control provides swipe gestures to reveal additional content or actions, making it useful for implementing features like swipe-to-delete in a .NET MAUI application.

### Key Properties:
- **`LeftItems`, `RightItems`, `TopItems`, `BottomItems`:** Define the swipe items that appear on each side when swiped.
- **`Content`:** Specifies the main content of the SwipeView.
- **`Threshold`:** Sets the distance a user must swipe to trigger an action.

### Key Events:
- **`SwipeStarted`:** Occurs when a swipe gesture begins.
- **`SwipeEnded`:** Occurs when a swipe gesture ends.
- **`SwipeChanging`:** Occurs when the swipe position is changing.

**Output:**

https://github.com/user-attachments/assets/ce861653-ed15-480c-b8f9-529ff15b1c00

------

## Switch

The Switch control represents a toggle mechanism, allowing users to switch between two states (e.g., On and Off) in a .NET MAUI application.

### Key Properties:
- **`IsToggled`:** A boolean value indicating whether the Switch is in the "On" (true) or "Off" (false) state.
- **`OnColor`:** Specifies the color of the Switch when it is toggled "On."
- **`ThumbColor`:** Sets the color of the Switch's thumb (the draggable part).

### Key Events:
- **`Toggled`:** Triggered when the state of the Switch changes.

**Output:**

https://github.com/user-attachments/assets/32f48f9a-b1ef-49e1-9a1d-1fd944ab4b79

------

## SwitchCell

The SwitchCell class is a specialized cell used in a `TableView`. It provides a toggleable switch as part of its display, enabling users to interact with boolean settings in a .NET MAUI application.

### Key Properties:
- **`On`:** A boolean value indicating whether the switch is toggled "On" (true) or "Off" (false).
- **`Text`:** Specifies the text displayed alongside the switch in the cell.

### Key Events:
- **`OnChanged`:** Triggered when the state of the switch changes.

**Output:**

https://github.com/user-attachments/assets/62b2f048-6a7c-4923-8ed3-b62b22b84b94

------

## TableView

The TableView control provides a structured layout for displaying rows of information, which can include text, switches, and other controls. It is often used for forms or settings in a .NET MAUI application.

### Key Properties:
- **`Root`:** Represents the root element that contains all sections and cells in the TableView.
- **`Intent`:** Specifies the purpose of the TableView, such as `Settings`, `Form`, or `Menu`.
- **`HasUnevenRows`:** A boolean value indicating whether rows in the TableView can have different heights.

### Key Elements:
- **`TableRoot`:** The container for TableSections.
- **`TableSection`:** A grouping element for organizing cells in the TableView.
- **`Cells`:** Individual elements in the TableView, such as `TextCell`, `SwitchCell`, or custom cells.

**Output:**

https://github.com/user-attachments/assets/175d3294-d33f-420c-98ea-bc6eaf20870b

------

## TextCell

The TextCell class is a simple cell type used in a `TableView`. It displays a label and an optional detail text, making it useful for settings, menus, or displaying paired information in a .NET MAUI application.

### Key Properties:
- **`Text`:** Specifies the primary text displayed in the cell.
- **`Detail`:** Specifies the secondary text or additional information displayed below the primary text.
- **`TextColor`:** Sets the color of the primary text.
- **`DetailColor`:** Sets the color of the detail text.

### Key Features:
- TextCell is lightweight and supports basic customization for quick use cases.

**Output:**

https://github.com/user-attachments/assets/549f2bba-70e5-40aa-b9c6-d6d1e4157366

------

## TimePicker

The TimePicker control allows users to select a specific time, making it useful for scheduling or time input scenarios in a .NET MAUI application.

### Key Properties:
- **`Time`:** Gets or sets the selected time as a `TimeSpan`.
- **`Format`:** Specifies the display format for the selected time (e.g., "HH:mm" or "h:mm tt").
- **`TextColor`:** Sets the color of the displayed time text.
- **`FontAttributes`:** Defines font styling, such as bold or italic, for the time text.

### Key Events:
- **`PropertyChanged`:** Triggered when the selected time changes.

**Output:**



------

## TitleBar

The TitleBar class provides control over the app's title bar in .NET MAUI applications, allowing developers to customize its appearance and behavior.

### Key Properties:
- **`Title`:** Specifies the text displayed in the title bar.
- **`BackgroundColor`:** Sets the background color of the title bar.
- **`ForegroundColor`:** Defines the color of the text and icons displayed on the title bar.
- **`IsVisible`:** A boolean value indicating whether the title bar is displayed.

### Key Methods:
- **`SetCustomView`:** Allows developers to replace the default title bar with a custom view for more advanced designs.

### Key Events:
- **`TitleBarChanged`:** Triggered when there are changes to the title bar's properties or state.

**Output:**

https://github.com/user-attachments/assets/aa0bd15d-da12-4331-9844-c743570ac9b5

------

## TwoPaneView

The TwoPaneView control is designed for dual-screen devices and scenarios where you need to display two panes of content side-by-side or in a stacked layout within a .NET MAUI application.

### Key Properties:
- **`Pane1` and `Pane2`:** Define the content displayed in each pane.
- **`PanePriority`:** Specifies which pane is given priority when the available space is constrained.
- **`MinWideModeWidth`:** Sets the minimum width required to switch to wide mode, displaying both panes side by side.
- **`TallModeThreshold`:** Determines the threshold height for switching to tall mode, where panes are stacked vertically.

### Key Events:
- **`ModeChanged`:** Triggered when the layout mode of the TwoPaneView changes (e.g., from wide to tall).

**Output:**

https://github.com/user-attachments/assets/80bc258a-705f-4c4c-9742-daeeaf32a118

------

## WebView

The WebView control enables the display of web content within a .NET MAUI application. It is a versatile control that supports features like loading URLs and displaying HTML content.

### Key Properties:
- **`Source`:** Specifies the URL or HTML content to be displayed in the WebView.
- **`CanGoBack` and `CanGoForward`:** Indicate whether the WebView can navigate back or forward in its navigation history.
- **`IsVisible`:** Determines the visibility of the WebView control on the screen.

### Key Methods:
- **`GoBack`:** Navigates back in the navigation history, if possible.
- **`GoForward`:** Navigates forward in the navigation history, if possible.
- **`Reload`:** Refreshes the current content displayed in the WebView.

### Key Events:
- **`Navigated`:** Triggered after the WebView successfully navigates to a new page.
- **`Navigating`:** Triggered while the WebView is in the process of navigating to a new page.

**Output:**

https://github.com/user-attachments/assets/9d61ea97-08d5-4cb6-93ef-e8f7ec027649

------



