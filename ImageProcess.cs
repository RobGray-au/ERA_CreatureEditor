using System.Drawing.Drawing2D;
using System.Drawing.Imaging;


namespace ERA_CreatureEdit
{
    /// <summary>
    ///   This class is responsible for loading an image from a file, resizing it to fit within 100x100 pixels while preserving aspect ratio,
    ///     optionally converting it to grayscale, and then assigning it to the AvatarImage property of a Creature object. 
    ///         May need to load System.Drawing.Common via NuGet for this to work.
    /// </summary>
    internal class ImageProcessor
    {
        public bool IsOk { get; set; }
        
        public static bool CreateAvatar(ERA_CreatureEdit.Models.Creature activeCreature, string validFilePath, bool greyScale)
        {
			try
			{
                // Load and resize
                using (Image originalImage = Image.FromFile(validFilePath))
                { 
                    Bitmap resizedImage = ResizeImageWithAspect(originalImage, 100, 100, Color.Transparent);
                    if (greyScale)
                    {
                        Bitmap grayImage = ConvertToGrayscale(resizedImage);
                        resizedImage.Dispose();
                        resizedImage = grayImage;
                    }
                    activeCreature.AvatarImage = resizedImage;

                    return true;
                }
                    


            }
            catch (Exception ex)
			{
                Console.WriteLine("Error processing image. "+ex.ToString());
                return false;
				throw;
			}
        }

        /// <summary>
        /// Resizes an image to fit within maxWidth x maxHeight while preserving aspect ratio.
        /// Pads with background color if needed.  copilot
        /// </summary>
        static Bitmap ResizeImageWithAspect(Image original, int maxWidth, int maxHeight, Color backgroundColor)
        {
            // Calculate scaling ratio
            double ratioX = (double)maxWidth / original.Width;
            double ratioY = (double)maxHeight / original.Height;
            double ratio = Math.Min(ratioX, ratioY);

            // Calculate new dimensions
            int newWidth = (int)(original.Width * ratio);
            int newHeight = (int)(original.Height * ratio);

            // Create a new bitmap with the target size
            Bitmap result = new Bitmap(maxWidth, maxHeight);
            result.SetResolution(original.HorizontalResolution, original.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(result))
            {
                // Fill background
                graphics.Clear(backgroundColor);

                // High-quality settings
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                
                // Center the image
                int posX = (maxWidth - newWidth) / 2;
                int posY = (maxHeight - newHeight) / 2;

                graphics.DrawImage(original, posX, posY, newWidth, newHeight);
            }

            return result;
        }

        /// <summary>
        /// copilot
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        static Bitmap ConvertToGrayscale(Bitmap original)
        {
            int w = original.Width;
            int h = original.Height;

            Bitmap grayBitmap = new Bitmap(w, h);

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    Color pixelCol = original.GetPixel(x, y);

                    // Luminance formula: 0.3R + 0.59G + 0.11B
                    int grayValue = (int)(pixelCol.R * 0.3 + pixelCol.G * 0.59 + pixelCol.B * 0.11);

                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    grayBitmap.SetPixel(x, y, grayColor);
                }
            }

            return grayBitmap;
        }

        /// <summary>
        /// http://www.switchonthecode.com/tutorials/csharp-tutorial-convert-a-color-image-to-grayscale
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            using (Graphics g = Graphics.FromImage(newBitmap))
            {

                //create the grayscale ColorMatrix
                ColorMatrix colorMatrix = new ColorMatrix(
                   new float[][]
                   {
                        new float[] {.3f, .3f, .3f, 0, 0},
                        new float[] {.59f, .59f, .59f, 0, 0},
                        new float[] {.11f, .11f, .11f, 0, 0},
                        new float[] {0, 0, 0, 1, 0},
                        new float[] {0, 0, 0, 0, 1}
                   });

                //create some image attributes
                using (ImageAttributes attributes = new ImageAttributes())
                {

                    //set the color matrix attribute
                    attributes.SetColorMatrix(colorMatrix);

                    //draw the original image on the new image
                    //using the grayscale color matrix
                    g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                                0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);
                }
            }
            return newBitmap;
        }

    }
}
