﻿// This file is part of AHD Subtitles Maker
// A program that can make and edit subtitle.
// 
// Copyright © Alaa Ibrahim Hadid 2009 - 2021
//
// This library is free software; you can redistribute it and/or modify 
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation; either version 3 of the License, 
// or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.See the GNU Lesser General Public 
// License for more details.
//
// You should have received a copy of the GNU Lesser General Public License 
// along with this library; if not, write to the Free Software Foundation, 
// Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
namespace AHD.SM.Controls
{
    public class SubtitleBufferObject
    {
        public int StartPixel { get; set; }
        public int EndPixel { get; set; }

        public int WidthPixels { get; set; }
        public bool IsSelected { get; set; }

        public double SubtitleStartTime { get; set; }
        public double SubtitleEndTime { get; set; }

        public string Text { get; set; }

        public int Temp_StartPixel { get; set; }
        public int Temp_EndPixel { get; set; }
        public double Temp_SubtitleStartTime { get; set; }
        public double Temp_SubtitleEndTime { get; set; }

        public bool FLAG { get; set; }
    }
}