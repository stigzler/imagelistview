# ImageListView stigzler fork

## Added Features:

### ImageListView.ShowImageBorders

Allows a simple toggle of the image borders on/off.

### ImageListViewItem.OverlayImage

Overlays this image on top of image thumbnail, unless in Details view (doesn't display in this instance).

Related Properties:
ImageListView.ShowOverlayImage - toggles visibility

ImageListView.OverlayImageAlignment - Where to display to image

ImageListView.OverlayImagePadding - Padding around overlay image

### Exposed ImageListViewItemCollection Constructor as a Public Method
This allows users to inherit this class to leverage custom ImageListViewItem collections and add custom members.

e.g:

```cs
internal class GameListViewItemCollection : ImageListView.ImageListViewItemCollection
{
    public GameListViewItemCollection(ImageListView owner) : base(owner)
    {
            
    }
}
```

### ImageListViewItemCollection made independent object

Added new Constructor for ImageListViewItemCollection and also made ImageListView public Property, allowing instantiation of such a list without passing the ImageListView at instantiation, allowing binding to ImageListView at later time.
