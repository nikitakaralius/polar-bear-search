namespace Core.Extensions;

public static class ButtonExtensions
{
    public static void Disable(this Button button) => 
        button.Visible = false;

    public static void Enable(this Button button) => 
        button.Visible = true;
}