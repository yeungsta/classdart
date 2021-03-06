﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassDart.Composer
{
    public class Constants
    {
        public const string DocType = "<!DOCTYPE html>";
        public const string Jquery = "http://code.jquery.com/jquery-1.6.4.min.js";
        //TODO: Jquery mobile 1.2 had problems with navbar showing up on bottom of screen.
        public const string JqueryMobile = "http://code.jquery.com/mobile/1.0/jquery.mobile-1.0.min.js";
        public const string JqueryMobileCss = "http://code.jquery.com/mobile/1.0/jquery.mobile-1.0.min.css";
        public const string ClassDartUrl = "http://www.classdart.com";
        public const string RegularSiteRedirect = "/?classdart=regular";
        public const string OutputFile = "index.html";
        public const string BlankTarget = "_blank";
        public const string Break = "<br>";
        public const string Paragraph = "<p>";
        public const string NewLine = "\n";

        //file paths
        public const string ActiveLogoPath = "logo.png";
        public const string MasterCssPath = "../../shared/master.css";
        public const string TemplateCssPath = "../../shared/templates/";
        public const string TemplateCssName = "template_";
        public const string CssExtension = ".css";
        public const string DefaultTemplate = "ice";

        //jQuery Mobile
        public const string ListDivider = "list-divider";
        public const string DataRole = "data-role";
        public const string DataMini = "data-mini";       
        public const string PageRole = "page";
        public const string HeaderRole = "header";
        public const string FooterRole = "footer";
        public const string ContentRole = "content";
        public const string NavbarRole = "navbar";
        public const string ButtonRole = "button";
        public const string CollapsibleRole = "collapsible";
        public const string DataInset = "data-inset";
        public const string DataIcon = "data-icon";
        public const string DataInline = "data-inline";       
        public const string DataId = "data-id";
        public const string DataTransition = "data-transition";
        public const string DataRel = "data-rel";
        public const string DataPosition = "data-position";
        public const string DataIconPosition = "data-iconpos";   
        public const string DataTheme = "data-theme";
        public const string DataContentTheme = "data-content-theme";      
        public const string PositionFixed = "fixed";
        public const string PositionBottom = "bottom";
        public const string None = "none";
        public const string Slide = "slide";
        public const string SlideDown = "slidedown";
        public const string GoBack = "back";
        public const string CountClass = "ui-li-count";
        public const string CornerTopClass = "ui-corner-top";
        public const string ShowAllTextClass = "showAllText";
        public const string SubscriptionId = "SubscriptionId";
        public const string FormAction = "action";
        public const string FormMethod = "method";
        public const string Post = "post";
        public const string FormClass = "subscriptionFormClass"; //todo: add this to CSS: "padding:10px 20px;"
        public const string EditorFieldClass = "editor-field";
        public const string Columns = "cols";
        public const string Rows = "rows";
        public const string Name = "name";
        public const string Placeholder = "placeholder";
        public const string Submit = "submit";
        public const string Text = "text";
        public const string Hidden = "hidden";

        //jQuery icons
        public const string OrigSiteIcon = "monitor";
        public const string CallIcon = "phone";
        public const string StreamIcon = "grid";
        public const string AssignmentsIcon = "star";
        public const string InstructorIcon = "home";
        public const string BackIcon = "arrow-l";
        public const string EmailIcon = "email";
        public const string FacebookIcon = "facebook";
        public const string LinkedInIcon = "linkedin";
        public const string TwitterIcon = "twitter";
        public const string YelpIcon = "yelp";

        //default values
        public const string DefaultHours = "Monday - Friday:\n10am - 9pm\n\nSaturday - Sunday:\n11am - 8pm\n\nHappy Hour\nMonday - Friday:\n5pm - 7pm";
        public const string DefaultWebsite = "www.your-website.com";
        public const string DefaultTwitter = "your_twitter_username";
        public const string DefaultEmail = "your@email.here";
        public const string DefaultPhone = "111-1111";
        public const string DefaultAboutTitleFormat = "Welcome to\n{0}!";
        public const string DefaultAboutTextFormat = "A description or story\nabout {0} here...";
    }
}