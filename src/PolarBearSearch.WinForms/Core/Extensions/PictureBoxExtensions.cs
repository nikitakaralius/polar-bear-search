namespace Core.Extensions;

public static class PictureBoxExtensions
{
    public static void RefreshWith(this PictureBox pictureBox, Image image)
    {
        pictureBox.Image?.Dispose();
        pictureBox.Image = image;
        pictureBox.Refresh();
    }
}