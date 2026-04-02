namespace MinForsteMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Radio_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            RadioButton radio = (RadioButton)sender;
            RadioStatus.Text = "Vejr retning: " + radio.Content;
        }
    }

    private void Check_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        string valgte = "";
        if (LemonCheck.IsChecked) valgte += "Lemon, ";
        if (OrangeCheck.IsChecked) valgte += "Orange, ";
        if (BananaCheck.IsChecked) valgte += "Banana, ";

        if (valgte == "")
            CheckStatus.Text = "Frugt: ingen valgt";
        else
            CheckStatus.Text = "Frugt valgt: " + valgte.TrimEnd(',', ' ');
    }
}