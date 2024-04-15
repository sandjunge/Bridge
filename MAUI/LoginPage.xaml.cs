using MAUI.ViewModel;

namespace MAUI;

public partial class LoginPage : ContentPage
{
    private ChatViewModel _viewModel = new();
    
    public LoginPage()
    {
        //mvvm verbindung mit anderen files aufbauen
        InitializeComponent();
        BindingContext = _viewModel;
        Loaded += MainPage_Loaded;
        
        //hier mache das hintergrundbild zu dem sternenhimmel
        Image hintergrundbild = new Image
        {
            Source = "hintergrund.jpg",
            Aspect = Aspect.Fill
        };
        
        //Logingrid ist der Grid im XAML-File
        Grid.SetRowSpan(hintergrundbild, 3); 
        Grid.SetColumnSpan(hintergrundbild, 3); 
        LoginGrid.Children.Insert(0, hintergrundbild); 
    }
    
    private void MainPage_Loaded(object? sender, EventArgs e)
    {
        _viewModel.Load();
    }
}