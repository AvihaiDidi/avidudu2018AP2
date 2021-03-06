﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageService.Modal
{
    public interface IImageServiceModal
    {
        /// <summary>
        /// The Function Addes A file to the system
        /// </summary>
        /// <param name="path">The Path of the Image from the file</param>
        /// <returns>Indication if the Addition Was Successful</returns>
        string AddFile(string path, out bool result);

        /// <summary>
        /// the function adds a folder
        /// </summary>
        /// <param name="path">The Path of the Image from the file</param>
        /// <param name="result">Indication if the Addition Was Successful</param>
        /// <returns>Indication if the Addition Was Successful</returns>
        string AddFolder(string path, out bool result);

    }
}
