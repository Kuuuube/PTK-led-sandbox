# PTK-led-sandbox
App for working with Wacom PTK-1240 LED displays.

## Usage
1. Make a 16 color format bmp image with a resolution of 64 x 128 px.

    [16 color bmp conversion tutorial using Gimp](https://github.com/Kuuuube/PTK-led-sandbox/blob/master/gimp_image_tutorial/gimp_image_tutorial.md)
2. Place any bmp files in a folder for conversion. Use separate folders for top and bottom screens. 

    Examples of how files are ordered when using multiple: `1 11 111 2 22 222` or `01 02 03 04 05 06`.
3. Run either with or without command line args.

## Command line args

```
PTK-led-sandbox {display} {tablet} {foldername 1} {foldername 2}
```

### Display

`1`: Top display

`2`: Bottom display

`3`: Both displays

### Tablet

`0`: No config

`1`: PTK-540WL

`2`: PTK-640

`3`: PTK-840

`4`: PTK-1240

### Filename 1

Relative or absolute path to the folder to use. 

When Display is `1` or `3` this will be used for the top display.

When Display is `2` this will be used for the bottom display.

### Filename 2 

Relative or absolute path to the folder to use. 

When Display is `3` this will be used for the bottom display.

When Display is `1` or `2` this is not used and can be omitted.

## Building

```
$options= @('--configuration', 'Release', '-p:PublishSingleFile=true', '-p:DebugType=embedded', '--self-contained', 'false')
dotnet publish PTK-led-sandbox $options --runtime win-x64 --framework net5.0 -o build/win-x64
dotnet publish PTK-led-sandbox $options --runtime linux-x64 --framework net5.0 -o build/linux-x64
```