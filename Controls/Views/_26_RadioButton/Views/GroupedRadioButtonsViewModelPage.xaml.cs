using _26_RadioButton.ViewModels;

namespace _26_RadioButton.Views {

	public partial class GroupedRadioButtonsViewModelPage : ContentPage {
		public GroupedRadioButtonsViewModelPage() {
			InitializeComponent();
			BindingContext = new AnimalsViewModel {
				GroupName = "animals",
				Selection = "Monkey"
			};
		}
	}
}