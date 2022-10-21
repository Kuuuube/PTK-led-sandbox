using System;

namespace PTK_led_sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string config_top;
            string config_bottom;
            string tablet_name;
            int displayChunk;
            string tablet;
            string display;
            string fileOutputStr = null;
            string filename_top = null;
            string filename_bottom = null;
            string fileOutputStr_top = "";
            string fileOutputStr_bottom = "";
            string[]  file_list_top = null;
            string[] file_list_bottom = null;
            string alternate = "2";

            if (args.Length != 0)
            {
                display = args[0];
                tablet = args[1];
                if (display == "3")
                {
                    alternate = args[2];
                }
                switch (display)
                {
                    case "1":
                        filename_top = args[3];
                        break;
                    case "2":
                        filename_bottom = args[3];
                        break;
                    case "3":
                        filename_top = args[3];
                        filename_bottom = args[4];
                        break;
                }
            }
            else
            {

                Console.WriteLine("Which LED display to set image for?\n1. Top\n2. Bottom\n3. Both");
                display = Console.ReadLine();

                Console.WriteLine("Generate config for which tablet?\n0. No config\n1. PTK-540WL\n2. PTK-640\n3. PTK-840\n4. PTK-1240");
                tablet = Console.ReadLine();

                switch (display)
                {
                    case "1": //top
                        Console.WriteLine("Folder to convert:");
                        filename_top = Console.ReadLine();
                        break;
                    case "2": //bottom
                        Console.WriteLine("Folder to convert:");
                        filename_bottom = Console.ReadLine();
                        break;
                    case "3": //both
                        Console.WriteLine("Folder to convert for top screen:");
                        filename_top = Console.ReadLine();
                        Console.WriteLine("Folder to convert for bottom screen:");
                        filename_bottom = Console.ReadLine();
                        Console.WriteLine("Display writing method:\n1. Alternate Displays\n2. Write top screen then bottom screen");
                        alternate = Console.ReadLine();
                        break;
                }
            }

            switch (tablet)
            {
                case "1": //PTK-540WL
                    config_top = "{\n  \"Name\": \"Wacom PTK-540WL\",\n  \"Specifications\": {\n    \"Digitizer\": {\n      \"Width\": 203.2,\n      \"Height\": 127.0,\n      \"MaxX\": 40640.0,\n      \"MaxY\": 25400.0\n    },\n    \"Pen\": {\n      \"MaxPressure\": 2047,\n      \"Buttons\": {\n        \"ButtonCount\": 2\n      }\n    },\n    \"AuxiliaryButtons\": {\n      \"ButtonCount\": 9\n    },\n    \"MouseButtons\": null,\n    \"Touch\": null\n  },\n  \"DigitizerIdentifiers\": [\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 188,\n      \"InputReportLength\": 10,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.IntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\",\n\"CAIRAAA=\",\n\"CAISAAA=\",\n\"CAITAAA=\",\n\"IQE=\",\n";
                    config_bottom = "      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    },\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 188,\n      \"InputReportLength\": 11,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.WacomDriverIntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\"\n      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    }\n  ],\n  \"AuxilaryDeviceIdentifiers\": [],\n  \"Attributes\": {}\n}";
                    tablet_name = "PTK-540WL";
                    break;
                case "2": //PTK-640
                    config_top = "{\n  \"Name\": \"Wacom PTK-640\",\n  \"Specifications\": {\n    \"Digitizer\": {\n      \"Width\": 223.52,\n      \"Height\": 139.7,\n      \"MaxX\": 44704.0,\n      \"MaxY\": 27940.0\n    },\n    \"Pen\": {\n      \"MaxPressure\": 2047,\n      \"Buttons\": {\n        \"ButtonCount\": 2\n      }\n    },\n    \"AuxiliaryButtons\": {\n      \"ButtonCount\": 9\n    },\n    \"MouseButtons\": null,\n    \"Touch\": null\n  },\n  \"DigitizerIdentifiers\": [\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 185,\n      \"InputReportLength\": 10,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.IntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\",\n";
                    config_bottom = "      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    },\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 185,\n      \"InputReportLength\": 11,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.WacomDriverIntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\"\n      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    }\n  ],\n  \"AuxilaryDeviceIdentifiers\": [],\n  \"Attributes\": {}\n}";
                    tablet_name = "PTK-640";
                    break;
                case "3": //PTK-840
                    config_top = "{\n  \"Name\": \"Wacom PTK-840\",\n  \"Specifications\": {\n    \"Digitizer\": {\n      \"Width\": 325.12,\n      \"Height\": 203.2,\n      \"MaxX\": 65024.0,\n      \"MaxY\": 40640.0\n    },\n    \"Pen\": {\n      \"MaxPressure\": 2047,\n      \"Buttons\": {\n        \"ButtonCount\": 2\n      }\n    },\n    \"AuxiliaryButtons\": {\n      \"ButtonCount\": 9\n    },\n    \"MouseButtons\": null,\n    \"Touch\": null\n  },\n  \"DigitizerIdentifiers\": [\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 186,\n      \"InputReportLength\": 10,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.IntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\",\n";
                    config_bottom = "      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    },\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 186,\n      \"InputReportLength\": 11,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.WacomDriverIntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\"\n      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    }\n  ],\n  \"AuxilaryDeviceIdentifiers\": [],\n  \"Attributes\": {}\n}";
                    tablet_name = "PTK-840";
                    break;
                case "4": //PTK-1240
                    config_top = "{\n  \"Name\": \"Wacom PTK-1240\",\n  \"Specifications\": {\n    \"Digitizer\": {\n      \"Width\": 487.68,\n      \"Height\": 304.8,\n      \"MaxX\": 97536.0,\n      \"MaxY\": 60960.0\n    },\n    \"Pen\": {\n      \"MaxPressure\": 2047,\n      \"Buttons\": {\n        \"ButtonCount\": 2\n      }\n    },\n    \"AuxiliaryButtons\": {\n      \"ButtonCount\": 9\n    },\n    \"MouseButtons\": null,\n    \"Touch\": null\n  },\n  \"DigitizerIdentifiers\": [\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 187,\n      \"InputReportLength\": 10,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.IntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\",\n";
                    config_bottom = "      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    },\n    {\n      \"VendorID\": 1386,\n      \"ProductID\": 187,\n      \"InputReportLength\": 11,\n      \"OutputReportLength\": null,\n      \"ReportParser\": \"OpenTabletDriver.Configurations.Parsers.Wacom.IntuosV1.WacomDriverIntuosV1ReportParser\",\n      \"FeatureInitReport\": [\n        \"AgI=\"\n      ],\n      \"OutputInitReport\": null,\n      \"DeviceStrings\": {},\n      \"InitializationStrings\": []\n    }\n  ],\n  \"AuxilaryDeviceIdentifiers\": [],\n  \"Attributes\": {}\n}";
                    tablet_name = "PTK-1240";
                    break;
                default:
                    config_top = "";
                    config_bottom = "";
                    tablet_name = "no_name";
                    break;
            }

            if (filename_top != null)
            {
                file_list_top = System.IO.Directory.GetFiles(filename_top, "*.bmp", System.IO.SearchOption.TopDirectoryOnly);
            }
            if (filename_bottom != null)
            {
                file_list_bottom = System.IO.Directory.GetFiles(filename_bottom, "*.bmp", System.IO.SearchOption.TopDirectoryOnly);
            }

            int top = 0;
            int bottom = 0;

            while ((filename_top != null && file_list_top.Length >= top + 1) || (filename_bottom != null && file_list_bottom.Length >= bottom + 1))
            {
                if (filename_top != null && filename_bottom != null && alternate == "1")
                {
                    if (filename_top != null && file_list_top.Length >= top + 1)
                    {
                        displayChunk = 0;
                        fileOutputStr += convert_bmp(displayChunk, file_list_top[top]);
                        top += 1;
                    }
                    if (filename_bottom != null && file_list_bottom.Length >= bottom + 1)
                    {
                        displayChunk = 4;
                        fileOutputStr += convert_bmp(displayChunk, file_list_bottom[bottom]);
                        bottom += 1;
                    }
                }
                else
                {
                    if (filename_top != null && file_list_top.Length >= top + 1)
                    {
                        displayChunk = 0;
                        fileOutputStr_top += convert_bmp(displayChunk, file_list_top[top]);
                        top += 1;
                    }
                    if (filename_bottom != null && file_list_bottom.Length >= bottom + 1)
                    {
                        displayChunk = 4;
                        fileOutputStr_bottom += convert_bmp(displayChunk, file_list_bottom[bottom]);
                        bottom += 1;
                    }
                }
            }


            string configStr = "";

            if (alternate == "1")
            {
                configStr = config_top + fileOutputStr + config_bottom;
            }
            else
            {
                configStr = config_top + fileOutputStr_top + fileOutputStr_bottom + config_bottom;
            }
            System.IO.File.WriteAllText(tablet_name + ".json", configStr);


            string convert_bmp (int displayChunk, string filename)
            {
                const int headerOffset = 118;
                const int LENGTH = 64;
                const int HEIGTH = 32 * 4;

                byte[] bmpFile = System.IO.File.ReadAllBytes(filename);
                byte[] imgData = new ArraySegment<byte>(bmpFile, headerOffset, bmpFile.Length - headerOffset).ToArray();

                // flipping stuff because in bmp file it's stored in reverse 
                // flip every half of a byte
                for (int i = 0; i < imgData.Length; i++)
                {
                    byte chr = imgData[i];
                    byte h = (byte)((chr >> 4) & 0x0F);
                    byte l = (byte)((chr & 0x0F) << 4);
                    imgData[i] = 0;
                    imgData[i] |= h;
                    imgData[i] |= l;
                }
                Array.Reverse(imgData);

                byte[] convertedImg = new byte[LENGTH * HEIGTH];

                int x = 0;
                int y = 0;
                bool firstline = true;
                int c = 1;
                for (int i = 0; i < imgData.Length; i++)
                {
                    byte chr = imgData[i];
                    byte h = (byte)((chr >> 4) & 0x0F);
                    byte l = (byte)(chr & 0x0F);

                    int k1 = c;
                    int k2 = c + 2;
                    convertedImg[k1] = h;
                    convertedImg[k2] = l;


                    //Console.WriteLine("{0} {1}", k1, k2);
                    c += 4;
                    x += 2;

                    if (x >= LENGTH)
                    {
                        y++;
                        x = 0;
                        if (firstline)
                        {
                            firstline = false;
                            c -= LENGTH * 2 + 1;
                            //Console.WriteLine("c = {0}\n", c);
                        }
                        else
                        {
                            firstline = true;
                            c += 1;
                            //Console.WriteLine("c = {0}\n", c);
                        }
                    }
                }


                const int MAX_CHUNK_SIZE = 512;
                byte[] initString = new byte[256 + 3];
                int initStringIndex = 0;
                string fileOutputStr = "";
                int displayChunkBlock = 0;
                for (int i = 0; i < LENGTH * HEIGTH; i++)
                {
                    if (!Convert.ToBoolean(i % MAX_CHUNK_SIZE))
                    {
                        if (i > 0)
                        {
                            fileOutputStr += '\"' + Convert.ToBase64String(initString) + "\"," + Environment.NewLine;
                            Array.Clear(initString, 0, initString.Length);
                        }

                        if (displayChunkBlock > 3)
                        {
                            displayChunk++;
                            displayChunkBlock = 0;
                        }

                        initString[0] = 0x23;
                        initString[1] = (byte)displayChunk;
                        initString[2] = (byte)displayChunkBlock;
                        initStringIndex = 3;
                        displayChunkBlock++;
                    }
                    if (!Convert.ToBoolean(i % 2))
                    {
                        initString[initStringIndex] = (byte)((convertedImg[i] << 4) & 0xF0);
                        initStringIndex++;
                    }
                    else
                    {
                        initString[initStringIndex - 1] |= convertedImg[i];
                    }
                }
                fileOutputStr += '\"' + Convert.ToBase64String(initString) + "\"," + Environment.NewLine;
                return (fileOutputStr);
            }

            return;
        }
    }
}