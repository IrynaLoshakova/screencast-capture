﻿// Screencast Capture, free screen recorder
// http://screencast-capture.googlecode.com
//
// Copyright © César Souza, 2012-2013
// cesarsouza at gmail.com
//
//    This program is free software; you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation; either version 2 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program; if not, write to the Free Software
//    Foundation, Inc., 675 Mass Ave, Cambridge, MA 02139, USA.
// 

namespace ScreenCapture.ViewModels
{
    using ScreenCapture.Properties;
    using System.ComponentModel;

    /// <summary>
    ///   ViewModel for binding option windows.
    /// </summary>
    /// 
    public class OptionViewModel : INotifyPropertyChanged
    {

        /// <summary>
        ///   Gets or sets the default save folder, which is
        ///   opened by default when the application starts.
        /// </summary>
        /// 
        public string DefaultSaveFolder { get; set; }

        /// <summary>
        ///   Gets or sets whether to capture the mouse cursor image.
        /// </summary>
        /// 
        public bool CaptureMouse { get; set; }

        /// <summary>
        ///   Gets or sets whether to capture mouse clicks.
        /// </summary>
        /// 
        public bool CaptureClick { get; set; }

        /// <summary>
        ///   Gets or sets whether the application has been opened before.
        /// </summary>
        /// 
        public bool FirstRun { get; set; }




        /// <summary>
        ///   Initializes a new instance of the <see cref="OptionViewModel"/> class.
        /// </summary>
        /// 
        public OptionViewModel()
        {
            Load();
        }

        /// <summary>
        ///   Saves the contents of the view-model 
        ///   into the application settings file.
        /// </summary>
        /// 
        public void Save()
        {
            Settings.Default.FirstRun = FirstRun;
            Settings.Default.DefaultFolder = DefaultSaveFolder;
            Settings.Default.CaptureMouse = CaptureMouse;
            Settings.Default.CaptureClick = CaptureClick;

            Settings.Default.Save();
        }

        /// <summary>
        ///   Loads the contents of the application
        ///   settings file into this view-model.
        /// </summary>
        /// 
        public void Load()
        {
            FirstRun = Settings.Default.FirstRun;
            DefaultSaveFolder = Settings.Default.DefaultFolder;
            CaptureMouse = Settings.Default.CaptureMouse;
            CaptureClick = Settings.Default.CaptureClick;
        }



        // The PropertyChanged event doesn't needs to be explicitly raised
        // from this application. The event raising is handled automatically
        // by the NotifyPropertyWeaver VS extension using IL injection.
        //
#pragma warning disable 0067
        /// <summary>
        ///   Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore 0067
    }
}