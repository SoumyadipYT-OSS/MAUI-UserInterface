using Microsoft.Maui.Controls;


namespace _36_TableView.TableClass {
    public class BasicTable : ContentPage {
        public BasicTable() {
            Content = new TableView {
                Intent = TableIntent.Form,
                Root = new TableRoot("Table Title")
                {
                    new TableSection("Section 1 Title")
                    {
                        new TextCell
                        {
                            Text = "TextCell Text",
                            Detail = "TextCell Detail"
                        },
                        new EntryCell
                        {
                            Label = "EntryCell:",
                            Placeholder = "default keyboard",
                            Keyboard = Keyboard.Default
                        }
                    },
                    new TableSection("Section 2 Title")
                    {
                        new EntryCell
                        {
                            Label = "Another EntryCell",
                            Placeholder = "phone keyboard",
                            Keyboard = Keyboard.Telephone
                        },
                        new SwitchCell
                        {
                            Text = "SwitchCell:"
                        }
                    }
                }
            };
        }
    }
}