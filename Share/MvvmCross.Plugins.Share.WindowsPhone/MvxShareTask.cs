// MvxShareTask.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using MvvmCross.Platform.WindowsPhone.Tasks;
using Microsoft.Phone.Tasks;
using System;

namespace MvvmCross.Plugins.Share.WindowsPhone
{
    public class MvxShareTask : MvxWindowsPhoneTask, IMvxShareTask
    {
        public void ShareShort(string message)
        {
            var task = new ShareStatusTask { Status = message };
            DoWithInvalidOperationProtection(task.Show);
        }

        public void ShareLink(string title, string message, string link)
        {
            var task = new ShareLinkTask { Title = title, Message = message, LinkUri = new Uri(link) };
            DoWithInvalidOperationProtection(task.Show);
        }
    }
}