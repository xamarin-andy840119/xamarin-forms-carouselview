﻿using System.Drawing;

namespace CustomLayouts.Controls.Interface
{
    public interface ITabProvider
    {
        /// <summary>
        ///     image
        /// </summary>
        string ImageSource { get; set; }

        /// <summary>
        ///     title
        /// </summary>
        string Title { get; set; }
    }
}