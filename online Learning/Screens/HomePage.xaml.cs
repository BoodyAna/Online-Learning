using online_Learning.Modduls;
using System.Collections.ObjectModel;

namespace online_Learning.Screens;

public partial class HomePage : ContentPage
{
    ObservableCollection<LessonModdule> Lessons { get; set; }

    public HomePage()
	{
		InitializeComponent();
        OnInit();
        colc.ItemsSource = Lessons;
    }

    void OnInit()
    {
        Lessons = new ObservableCollection<LessonModdule>();

        
        Lessons.Add(new LessonModdule()
        {
            Name = "Math",
            Image = "https://cdn.dribbble.com/users/10086039/screenshots/19080442/media/3448df6cb5af9ec220a724b1bd228812.png?resize=400x300&vertical=center",
            LessonNumber = "22",
        });
        Lessons.Add(new LessonModdule()
        {
            Name = "English",
            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8D8PsSmTY_79O-nm8OiGgQxi23WyMHAKzuhSIk3o1sA&s",
            LessonNumber = "36",
        });
        Lessons.Add(new LessonModdule()
        {
            Name = "History",
            Image = "https://i.pinimg.com/originals/b4/7b/fb/b47bfbcd716ecdc348335e9928108a9c.jpg",
            LessonNumber = "18",
        });
    }

    private async void colc_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        LessonModdule? item = colc.SelectedItem as LessonModdule;
        try
        {
            Uri uri = new Uri($"https://api.whatsapp.com/send?phone=201551541190&text=I%20want%20to%20request%20a%20{item.Name}%20course");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {

        }
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        try
        {
            Uri uri = new Uri($"https://api.whatsapp.com/send?phone=201551541190&text=I%20want%20to%20request%20a%20Scince%20course");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {

        }
    }
}