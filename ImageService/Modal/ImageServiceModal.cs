﻿using ImageService.Infrastructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ImageService.Modal
{
    public class ImageServiceModal : IImageServiceModal
    {
        public string AddFile(string path, out bool result)
        {

            result = false;
            return "fail";
        }

        public string AddFolder(string path, out bool result)
        {
            System.IO.Directory.CreateDirectory(path);
            result = true;
            return "success";

        }
    }
}
