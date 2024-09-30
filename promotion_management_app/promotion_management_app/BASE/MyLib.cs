﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promotion_management_app.BASE
{
    public static class MyLib
    {
        private static Thread thread;
        public static int maND { get; set; }
        public static string UserName { get; set; }
        public static void CloseThisOpenThat(Form pOldForm, Form pNewForm)
        {
            pOldForm.Close();
            thread = new Thread(() =>
            {
                Application.Run(pNewForm);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public static void LoadForm(Control pBody, Control pControl, DockStyle? dockStyle = DockStyle.Fill)
        {
            pBody.Controls.Clear();
            if (pControl is Form form)
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                pBody.Controls.Add(form);
                form.Dock = (DockStyle)dockStyle;
                form.Show();
            }
            else
            {

                AddControl(pBody, pControl, (DockStyle)dockStyle);
            }
        }

        public static void Collapse(bool collapse, Control container)
        {

            if (collapse)
            {
                container.Size = container.MinimumSize;
            }
            else
            {
                container.Size = container.MaximumSize;
            }
        }

        public static void LoadForm(Form form, bool isDialog = false)
        {
            if (isDialog)
            {
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }
        }

        public static void IsNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        public static string AddCommas(decimal? number, string currency = "đ")
        {
            return (string.Format("{0:n0}", number) + currency).Trim();
        }

        public static decimal? ParseCurrencyString(string currencyString, string currencySymbol)
        {
            if (string.IsNullOrWhiteSpace(currencyString))
            {
                return null;
            }
            string cleanString = currencyString.Replace(currencySymbol, "").Replace(",", "").Trim();

            if (decimal.TryParse(cleanString, out decimal result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }


        public static string ConvertToTime(int pNumber, int cost)
        {
            int hour = pNumber / cost;
            int minute = (pNumber % cost * 60) / 10000;
            int second = (minute % cost * 60) / 10000;

            return AddZero(hour.ToString()) + ":" + AddZero(minute.ToString()) + ":" + AddZero(second.ToString());
        }

        public static string DeleteCommas(string pStr)
        {
            pStr = pStr.Replace('đ', ' ');
            pStr = pStr.Trim();
            string newStr = "";
            string[] list = pStr.Split(new char[] { '.', ',' });
            foreach (string str in list)
            {
                newStr += str;
            }

            return newStr;
        }

        public static string AddZero(string pStr)
        {
            int number = int.Parse(pStr);
            string newStr = pStr;
            if (number >= 0 && number <= 9)
            {
                newStr = "0" + pStr;
            }
            return newStr;
        }


        public static DateTime GetDateItemFromGunaData(DateTime date)
        {
            int day = date.Day;
            int month = date.Month;
            int year = date.Year;

            string nDate = year + "-" + month + "-" + day;

            return DateTime.Parse(nDate);
        }

        public static void AddControl(Control parent, Control chil, DockStyle dockStyle)
        {
            chil.Dock = dockStyle;
            parent.Controls.Add(chil);
        }

        public static void RemoveChildFrom(Control parent, int from)
        {
            int length = parent.Controls.Count - from;

            for (int i = 0; i < length; i++)
            {
                parent.Controls.RemoveAt(0);
            }
        }
    }
}
