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
namespace AHD.SM
{
    partial class sc_PlayBack
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sc_PlayBack));
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_NewSubtitleDuration = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_AdvanceTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_ShiftTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDown_playerTimer = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AskToDownloadFromOS = new System.Windows.Forms.CheckBox();
            this.checkBox_auto_generate_wave = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_wanrMeWhenMKVLoaded = new System.Windows.Forms.CheckBox();
            this.checkBox_warnWhenID3Detected = new System.Windows.Forms.CheckBox();
            this.checkBox_scrollTimeLine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NewSubtitleDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AdvanceTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ShiftTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_playerTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // numericUpDown_NewSubtitleDuration
            // 
            resources.ApplyResources(this.numericUpDown_NewSubtitleDuration, "numericUpDown_NewSubtitleDuration");
            this.numericUpDown_NewSubtitleDuration.Name = "numericUpDown_NewSubtitleDuration";
            this.toolTip1.SetToolTip(this.numericUpDown_NewSubtitleDuration, resources.GetString("numericUpDown_NewSubtitleDuration.ToolTip"));
            // 
            // numericUpDown_AdvanceTime
            // 
            resources.ApplyResources(this.numericUpDown_AdvanceTime, "numericUpDown_AdvanceTime");
            this.numericUpDown_AdvanceTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_AdvanceTime.Name = "numericUpDown_AdvanceTime";
            this.toolTip1.SetToolTip(this.numericUpDown_AdvanceTime, resources.GetString("numericUpDown_AdvanceTime.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // numericUpDown_ShiftTime
            // 
            resources.ApplyResources(this.numericUpDown_ShiftTime, "numericUpDown_ShiftTime");
            this.numericUpDown_ShiftTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_ShiftTime.Name = "numericUpDown_ShiftTime";
            this.toolTip1.SetToolTip(this.numericUpDown_ShiftTime, resources.GetString("numericUpDown_ShiftTime.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // numericUpDown_playerTimer
            // 
            resources.ApplyResources(this.numericUpDown_playerTimer, "numericUpDown_playerTimer");
            this.numericUpDown_playerTimer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_playerTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_playerTimer.Name = "numericUpDown_playerTimer";
            this.toolTip1.SetToolTip(this.numericUpDown_playerTimer, resources.GetString("numericUpDown_playerTimer.ToolTip"));
            this.numericUpDown_playerTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_AskToDownloadFromOS
            // 
            resources.ApplyResources(this.checkBox_AskToDownloadFromOS, "checkBox_AskToDownloadFromOS");
            this.checkBox_AskToDownloadFromOS.Name = "checkBox_AskToDownloadFromOS";
            this.toolTip1.SetToolTip(this.checkBox_AskToDownloadFromOS, resources.GetString("checkBox_AskToDownloadFromOS.ToolTip"));
            this.checkBox_AskToDownloadFromOS.UseVisualStyleBackColor = true;
            // 
            // checkBox_auto_generate_wave
            // 
            resources.ApplyResources(this.checkBox_auto_generate_wave, "checkBox_auto_generate_wave");
            this.checkBox_auto_generate_wave.Name = "checkBox_auto_generate_wave";
            this.toolTip1.SetToolTip(this.checkBox_auto_generate_wave, resources.GetString("checkBox_auto_generate_wave.ToolTip"));
            this.checkBox_auto_generate_wave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // checkBox_wanrMeWhenMKVLoaded
            // 
            resources.ApplyResources(this.checkBox_wanrMeWhenMKVLoaded, "checkBox_wanrMeWhenMKVLoaded");
            this.checkBox_wanrMeWhenMKVLoaded.Name = "checkBox_wanrMeWhenMKVLoaded";
            this.checkBox_wanrMeWhenMKVLoaded.UseVisualStyleBackColor = true;
            // 
            // checkBox_warnWhenID3Detected
            // 
            resources.ApplyResources(this.checkBox_warnWhenID3Detected, "checkBox_warnWhenID3Detected");
            this.checkBox_warnWhenID3Detected.Name = "checkBox_warnWhenID3Detected";
            this.checkBox_warnWhenID3Detected.UseVisualStyleBackColor = true;
            // 
            // checkBox_scrollTimeLine
            // 
            resources.ApplyResources(this.checkBox_scrollTimeLine, "checkBox_scrollTimeLine");
            this.checkBox_scrollTimeLine.Name = "checkBox_scrollTimeLine";
            this.checkBox_scrollTimeLine.UseVisualStyleBackColor = true;
            // 
            // sc_PlayBack
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_auto_generate_wave);
            this.Controls.Add(this.checkBox_scrollTimeLine);
            this.Controls.Add(this.checkBox_AskToDownloadFromOS);
            this.Controls.Add(this.checkBox_wanrMeWhenMKVLoaded);
            this.Controls.Add(this.checkBox_warnWhenID3Detected);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_playerTimer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_ShiftTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_AdvanceTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_NewSubtitleDuration);
            this.Controls.Add(this.label1);
            this.Name = "sc_PlayBack";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NewSubtitleDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AdvanceTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ShiftTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_playerTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_NewSubtitleDuration;
        private System.Windows.Forms.NumericUpDown numericUpDown_AdvanceTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_ShiftTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_playerTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_wanrMeWhenMKVLoaded;
        private System.Windows.Forms.CheckBox checkBox_warnWhenID3Detected;
        private System.Windows.Forms.CheckBox checkBox_AskToDownloadFromOS;
        private System.Windows.Forms.CheckBox checkBox_scrollTimeLine;
        private System.Windows.Forms.CheckBox checkBox_auto_generate_wave;
    }
}
