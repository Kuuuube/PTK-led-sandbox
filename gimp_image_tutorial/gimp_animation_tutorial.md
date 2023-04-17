# Gimp Animation Tutorial

1. Crop and/or resize the desired animation to 64 x 128 px. Scaling all layers can be done with `Scale Image`.

![](scale_image.png)

2. Set the animation to grayscale.

![](grayscale.png)

3. Set the animation to indexed.

![](indexed.png)

4. Set the indexed settings to use 16 color. Setting dithering to `None` is also recommended but not required.

![](indexed_settings.png)

5. Check whether the first or last frame is the top layer. If the last frame is the top layer, use `Reverse Layer Order`.

![](reverse_layer_order.png)

6. To export all layers use the [Export Layers](https://khalim19.github.io/gimp-plugin-export-layers/) plugin. Set the `Layer name` to the `layer[001]` preset and set the file extension to `bmp`.

![](export_layers.png)

If you get this warning you can press `OK` and proceed with exporting.

![](export_warning.png)

7. Change the export settings to `Do not write color space information`.

![](export_settings.png)

8. Click `Export`.