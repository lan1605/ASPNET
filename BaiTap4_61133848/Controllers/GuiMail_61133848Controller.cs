﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap4_61133848.Models;

namespace BaiTap4_61133848.Controllers
{
    public class GuiMail_61133848Controller : Controller
    {
        // GET: GuiMail_61133848
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(MailInfo model)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress(model.From);
            mail.To.Add(model.To);
            mail.Subject = model.Subject;
            mail.Body = model.Body;
            mail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new System.Net.NetworkCredential(model.From, model.Password),
                EnableSsl = true
            };
            smtp.Send(mail);
            return RedirectToAction("Index", "Mail");
        }
    }
}