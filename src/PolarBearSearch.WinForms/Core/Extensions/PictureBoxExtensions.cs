namespace Core.Extensions;

public static class PictureBoxExtensions
{
    public static void Clear(this PictureBox pictureBox)
    {
        pictureBox.Replace(null!);
    }

    public static void Replace(this PictureBox pictureBox, Image image)
    {
        pictureBox.Image?.Dispose();
        pictureBox.Image = image;
        pictureBox.Refresh();
    }
}