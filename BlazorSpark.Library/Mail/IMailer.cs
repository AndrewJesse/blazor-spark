﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSpark.Library.Mail
{
    public interface IMailer
    {
        Task<string> RenderAsync<T>(Mailable<T> mailable);
        Task SendAsync<T>(Mailable<T> mailable);
        Task SendAsync(string message, string subject, IEnumerable<MailRecipient> to, MailRecipient from, MailRecipient replyTo, IEnumerable<MailRecipient> cc, IEnumerable<MailRecipient> bcc, IEnumerable<Attachment> attachments = null);
    }
}
