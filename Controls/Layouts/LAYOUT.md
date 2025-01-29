# .NET MAUI Layouts

.NET MAUI provides a variety of layouts to help you design your mobile applications. Each layout has its own unique properties and use cases. Below are the main layouts available in .NET MAUI:


## 1. StackLayout

The `StackLayout` organizes its children in a single line, either vertically or horizontally.

### Properties:
- **Orientation**: Specifies the direction of the stack (Vertical or Horizontal).
- **Spacing**: Defines the space between each child element.

#### Output:
![_01_StackLayout](https://github.com/user-attachments/assets/e2daa0e7-c215-4fa3-84d5-3bb9cf6fe13a)

------

## 2. Grid
The `Grid` layout organizes its children into rows and columns, similar to a table.

### Properties:
- **RowDefinition**: Defines the rows in the grid.
- **ColumnDefinitions**: Defines the columns in the grid.

#### Output:
https://github.com/user-attachments/assets/a00cb2db-492c-4116-b43f-b00a78166e29

------

## 3. FlexLayout
The `FlexLayout` is a versatile layout that can arrange its children horizontally and vertically in a flexible way.

### Properties:
- **Direction**: Specifies the direction of the layout (Row, Column, RowReverse, ColumnReverse).
- **JustifyContent**: Aligns children along the main axis (Start, Center, End, SpaceBetween, SpaceAround, SpaceEvenly).
- **AlignItems**: Aligns children along the cross axis (Start, Center, End, Stretch).
- **Wrap**: Specifies whether children should wrap to the next line (NoWrap, Wrap, WrapReverse).

#### Output:
https://github.com/user-attachments/assets/22741463-0054-493d-a66b-a186b2c5f667

------

## 4. AbsoluteLayout
The `AbsoluteLayout` allows you to position its children at specific coordinates.

### Properties:
- **LayoutBounds**: Specifies the position and size of the child element.
- **LayoutFlags**: Specifies how the bounds are interpreted (None, All, XProportional, YProportional, WidthProportional, HeightProportional).

- #### Output:
![_04_AbsoluteLayout](https://github.com/user-attachments/assets/03ead9e0-1093-4c5b-a005-bedcb959bd09)

------

## 5. BindableLayout
The `BindableLayout` allows you to bind a collection of data to a layout, creating a dynamic UI.

### Properties:
- **ItemsSource**: The collection of data to bind to.
- **ItemTemplate**: The template to use for each item in the collection.


#### Output:
https://github.com/user-attachments/assets/06dad621-6c6a-408e-ba0a-7d9f39d14491

------
