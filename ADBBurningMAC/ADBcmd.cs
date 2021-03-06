﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ADBBurningMAC
{
    class ADBCmd
    {
        public static void detectAdbTool()
        {
            // Todo
        }

        public static bool detectDevice()
        {
            detectAdbTool();

            String backString = WinCmd.cmd("adb " + "devices -l");

            string s = @"sabresd";
            Regex r = new Regex(s, RegexOptions.IgnoreCase);
            Match mB = r.Match(backString);
            if (!mB.Success)
            {
                MessageBox.Show("Please Insert Your USB Cable.");
                return false;
            }

            return true;
        }

        public static void push(String srcPath, String destPath)
        {
            WinCmd.cmd("adb " + "push " + srcPath + " " + destPath, null);
        }

        public static void push(String srcPath, String destPath, TextBox textBox)
        {
            WinCmd.cmd("adb " + "push " + srcPath + " " + destPath, textBox);
        }

        public static void execute(String cmd)
        {
            WinCmd.cmd("adb " + "shell " + cmd, null);
        }

        public static void execute(String cmd, TextBox textBox)
        {
            WinCmd.cmd("adb " + "shell " + cmd, textBox);
        }

        public static void pull(String srcPath, String destPath)
        {
            WinCmd.cmd("adb " + "pull " + srcPath + " " + destPath, null);
        }

        public static void pull(String srcPath, String destPath, TextBox textBox)
        {
            WinCmd.cmd("adb " + "pull " + srcPath + " " + destPath, textBox);
        }
    }
}