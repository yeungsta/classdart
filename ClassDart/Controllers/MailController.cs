﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ActionMailer.Net.Mvc;
using ActionMailer.Net.Standalone;
using ClassDart.Models;
using RazorEngine;

namespace ClassDart.Controllers
{
    [Authorize]
    public class MailControllerAsync : RazorMailerBase
    {
        public override string ViewPath
        {
            get {
                //note: can't use HttpContext w/ action mailer!
                string path = AppDomain.CurrentDomain.GetData("APPBASE").ToString() + "\\Views\\Mail";
                return path;
            }
        }

        public RazorEmailResult SendSubscribedEmailAsync(string email, string className, int classId)
        {
            To.Add(email);
            From = "Class Dart <" + Constants.ReplyEmail + ">";
            Subject = "You have just subscribed to " + className;

            SendSubscribedEmailViewModel viewModel = new SendSubscribedEmailViewModel();
            viewModel.Email = email;
            viewModel.ClassName = className;
            //viewModel.UnsubscribeLink = "http://localhost:2048/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;
            //viewModel.UnsubscribeLink = "http://www.menudart.com/classdart/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;
            viewModel.UnsubscribeLink = "http://www.classdart.com/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;

            return Email("SendSubscribedEmailAsync", viewModel);
        }

        public RazorEmailResult SendClassUpdateEmailAsync(string email, string className, int classId, string classUrl)
        {
            To.Add(email);
            From = "Class Dart <" + Constants.ReplyEmail + ">";
            Subject = "Update from class: " + className;

            SendClassUpdateEmailViewModel viewModel = new SendClassUpdateEmailViewModel();
            viewModel.Email = email;
            viewModel.ClassName = className;
            viewModel.ClassLink = Utilities.GetFullUrl(classUrl);
            //todo: change for production
            //viewModel.UnsubscribeLink = "http://localhost:2048/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;
            //viewModel.UnsubscribeLink = "http://www.menudart.com/classdart/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;
            viewModel.UnsubscribeLink = "http://www.classdart.com/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;

            return Email("SendClassUpdateEmailAsync", viewModel);
        }
    }

    [Authorize]
    public class MailController : MailerBase
    {
/*
        public EmailResult SendPasswordResetEmail(string email, string resetLink)
        {
            return null;
        }

        public EmailResult SendSignUpEmail(string email)
        {
            return null;
        }

        public EmailResult SendActivateEmail(string email, int amount, IList<MenuAndLink> menusJustActivated, IList<MenuAndLink> allActivatedMenus)
        {
            return null;
        }

        public EmailResult SendActivateEmailTrial(string email, IList<MenuAndLink> menusJustActivated)
        {
            return null;
        }

        public EmailResult SendDeactivateEmail(string email, int amount, IList<MenuAndLink> remainingActiveMenus, IList<MenuAndLink> deactivatedMenus)
        {
            return null;
        }

        public EmailResult SendFeedbackEmail(string email, string htmlfeedback)
        {
            return null;
        }

        public EmailResult SendTrialExpiredEmail(string email, IList<MenuAndLink> deactivatedMenus)
        {
            return null;
        }

        //Email for when trial is about to expire
        public EmailResult SendTrialWarningEmail(string email, IList<MenuAndLink> deactivatedMenus)
        {
            return null;
        }

        public EmailResult SendCouponAppliedEmail(string email)
        {
            return null;
        }

        public EmailResult SendPreviewLinkEmail(string email, string previewLink)
        {
            return null;
        }

        public EmailResult SendViewLinkEmail(string email, string viewLink)
        {
            return null;
        }

        public EmailResult NewUserNoticeEmail(string email)
        {
            return null;
        }
*/
/*
        public EmailResult SendSubscribedEmail(string email, string className, int classId)
        {
            To.Add(email);
            From = "Class Dart <" + Constants.ReplyEmail + ">";
            Subject = "You have just subscribed to " + className;

            SendSubscribedEmailViewModel viewModel = new SendSubscribedEmailViewModel();
            viewModel.Email = email;
            viewModel.ClassName = className;
            viewModel.UnsubscribeLink = "http://localhost:2048/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;

            return Email("SendSubscribedEmail", viewModel);
        }
*/
        public EmailResult SendClassUpdateEmail(string email, string className, int classId, string classUrl)
        {
            To.Add(email);
            From = "Class Dart <" + Constants.ReplyEmail + ">";
            Subject = "Update from class: " + className;

            SendClassUpdateEmailViewModel viewModel = new SendClassUpdateEmailViewModel();
            viewModel.Email = email;
            viewModel.ClassName = className;
            viewModel.ClassLink = classUrl;
            viewModel.UnsubscribeLink = "http://localhost:2048/Subscribe/Unsubscribe/" + classId + "?emailInput=" + email;

            return Email("SendClassUpdateEmail", viewModel);
        }
/*
        public EmailResult SendPasswordResetEmail(string email, string resetLink)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.ReplyEmail + ">";
            Subject = "Your Menu Dart Password Has Been Reset";
            //Attachments.Inline["corplogo.jpg"] = DocMgr.GetContentFileBytes("/images/corp-logo.jpg");

            SendPasswordResetEmailViewModel viewModel = new SendPasswordResetEmailViewModel();
            viewModel.Email = email;
            viewModel.ResetLink = resetLink;

            return Email("SendPasswordResetEmail", viewModel);
        }

        public EmailResult SendSignUpEmail(string email)
        {
            To.Add(email);
            From = "Menu Dart Welcome Team <" + Constants.SupportEmail + ">";
            Subject = "Welcome to Menu Dart!";

            return Email("SendSignUpEmail", email);
        }

        public EmailResult SendActivateEmail(string email, int amount, IList<MenuAndLink> menusJustActivated, IList<MenuAndLink> allActivatedMenus)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.SupportEmail + ">";
            Subject = "Your Menu Is Activated!";

            SendActivateEmailViewModel viewModel = new SendActivateEmailViewModel();
            viewModel.Email = email;
            viewModel.MonthlyBill = amount;
            viewModel.MenusJustActivated = menusJustActivated;
            viewModel.AllActivatedMenus = allActivatedMenus;

            return Email("SendActivateEmail", viewModel);
        }

        public EmailResult SendActivateEmailTrial(string email, IList<MenuAndLink> menusJustActivated)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.SupportEmail + ">";
            Subject = "Your Menu Is Activated!";

            SendActivateEmailViewModel viewModel = new SendActivateEmailViewModel();
            viewModel.Email = email;
            viewModel.MenusJustActivated = menusJustActivated;

            return Email("SendActivateEmailTrial", viewModel);
        }

        public EmailResult SendDeactivateEmail(string email, int amount, IList<MenuAndLink> remainingActiveMenus, IList<MenuAndLink> deactivatedMenus)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.SupportEmail + ">";
            Subject = "Your Menu Is Deactivated";

            SendDeactivateEmailViewModel viewModel = new SendDeactivateEmailViewModel();
            viewModel.Email = email;
            viewModel.MonthlyBill = amount;
            viewModel.RemainingActiveMenus = remainingActiveMenus;
            viewModel.DeactivatedMenus = deactivatedMenus;

            return Email("SendDeactivateEmail", viewModel);
        }

        public EmailResult SendFeedbackEmail(string email, string htmlfeedback)
        {
            //send to MenuDart support team
            To.Add(Constants.SupportEmail);
            From = email;
            Subject = "Customer Feedback from " + email;

            return Email("SendFeedbackEmail", htmlfeedback);
        }

        public EmailResult SendTrialExpiredEmail(string email, IList<MenuAndLink> deactivatedMenus)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.SupportEmail + ">";
            Subject = "Your 30-day free trial has expired. Activate your mobile menu!";

            SendTrialExpiredEmailViewModel viewModel = new SendTrialExpiredEmailViewModel();
            viewModel.Email = email;
            viewModel.DeactivatedMenus = deactivatedMenus;

            return Email("SendTrialExpiredEmail", viewModel);
        }

        //Email for when trial is about to expire
        public EmailResult SendTrialWarningEmail(string email, IList<MenuAndLink> deactivatedMenus)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.SupportEmail + ">";
            Subject = "Your 30-day free trial is expiring soon. Activate your mobile menu!";

            SendTrialExpiredEmailViewModel viewModel = new SendTrialExpiredEmailViewModel();
            viewModel.Email = email;
            viewModel.DeactivatedMenus = deactivatedMenus;

            return Email("SendTrialWarningEmail", viewModel);
        }

        public EmailResult SendCouponAppliedEmail(string email)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.SupportEmail + ">";
            Subject = "You've Received a Free Month!";

            return Email("SendCouponAppliedEmail", email);
        }

        public EmailResult SendPreviewLinkEmail(string email, string previewLink)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.ReplyEmail + ">";
            Subject = "Your Menu Dart Preview Menu Is Ready";

            SendPreviewLinkEmailViewModel viewModel = new SendPreviewLinkEmailViewModel();
            viewModel.Email = email;
            viewModel.PreviewLink = previewLink;

            return Email("SendPreviewLinkEmail", viewModel);
        }

        public EmailResult SendViewLinkEmail(string email, string viewLink)
        {
            To.Add(email);
            From = "Menu Dart <" + Constants.ReplyEmail + ">";
            Subject = "Your Menu Dart Menu Link";

            SendViewLinkEmailViewModel viewModel = new SendViewLinkEmailViewModel();
            viewModel.Email = email;
            viewModel.Link = viewLink;

            return Email("SendViewLinkEmail", viewModel);
        }

        public EmailResult NewUserNoticeEmail(string email)
        {
            //send to MenuDart support team
            To.Add(Constants.SupportEmail);
            From = email;
            Subject = "New User Sign Up: " + email;

            return Email("NewUserNoticeEmail", email);
        }
 */ 
    }
}
