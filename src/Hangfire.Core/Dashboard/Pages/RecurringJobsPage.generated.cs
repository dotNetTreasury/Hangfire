﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hangfire.Dashboard.Pages
{
    
    #line 2 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    using System.Linq;
    using System.Text;
    
    #line 4 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using CronExpressionDescriptor;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Dashboard.Resources;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
    using Hangfire.Storage;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class RecurringJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");










            
            #line 10 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
  
    Layout = new LayoutPage(Strings.RecurringJobsPage_Title);
	List<RecurringJobDto> recurringJobs;
    
    int from, perPage;

    int.TryParse(Query("from"), out from);
    int.TryParse(Query("count"), out perPage);

    Pager pager = null;

	using (var connection = Storage.GetConnection())
	{
	    var storageConnection = connection as JobStorageConnection;
	    if (storageConnection != null)
	    {
	        pager = new Pager(from, perPage, storageConnection.GetRecurringJobCount());
	        recurringJobs = storageConnection.GetRecurringJobs(pager.FromRecord, pager.FromRecord + pager.RecordsPerPage - 1);
	    }
	    else
	    {
            recurringJobs = connection.GetRecurringJobs();
	    }
	}


            
            #line default
            #line hidden
WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1 class=\"page-header\"" +
">");


            
            #line 38 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                           Write(Strings.RecurringJobsPage_Title);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n\r\n");


            
            #line 40 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
         if (recurringJobs.Count == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"alert alert-info\">\r\n                ");


            
            #line 43 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
           Write(Strings.RecurringJobsPage_NoJobs);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </div>\r\n");


            
            #line 45 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"js-jobs-list\">\r\n                <div class=\"btn-toolbar b" +
"tn-toolbar-top\">\r\n                    <button class=\"js-jobs-list-command btn bt" +
"n-sm btn-primary\"\r\n                            data-url=\"");


            
            #line 51 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 Write(Url.To("/recurring/trigger"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 52 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Strings.RecurringJobsPage_Triggering);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-play-circle\"></span>\r\n                        ");


            
            #line 55 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                   Write(Strings.RecurringJobsPage_TriggerNow);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n                    <button class=\"js-jobs-lis" +
"t-command btn btn-sm btn-default\"\r\n                            data-url=\"");


            
            #line 59 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 Write(Url.To("/recurring/remove"));

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-loading-text=\"");


            
            #line 60 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                          Write(Strings.Common_Deleting);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-confirm=\"");


            
            #line 61 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                     Write(Strings.Common_DeleteConfirm);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            disabled=\"disabled\">\r\n                        <spa" +
"n class=\"glyphicon glyphicon-remove\"></span>\r\n                        ");


            
            #line 64 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                   Write(Strings.Common_Delete);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </button>\r\n\r\n");


            
            #line 67 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     if (pager != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral(" ");


            
            #line 69 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                      Write(Html.PerPageSelector(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 70 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral(@"                </div>

                <table class=""table"">
                    <thead>
                    <tr>
                        <th class=""min-width"">
                            <input type=""checkbox"" class=""js-jobs-list-select-all""/>
                        </th>
                        <th class=""min-width"">");


            
            #line 79 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         Write(Strings.Common_Id);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th class=\"min-width\">");


            
            #line 80 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                         Write(Strings.RecurringJobsPage_Table_Cron);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");


            
            #line 81 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                       Write(Strings.RecurringJobsPage_Table_TimeZone);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th>");


            
            #line 82 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                       Write(Strings.Common_Job);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th class=\"align-right min-width\">");


            
            #line 83 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                     Write(Strings.RecurringJobsPage_Table_NextExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <th class=\"align-right min-width\">");


            
            #line 84 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                     Write(Strings.RecurringJobsPage_Table_LastExecution);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                    </tr>\r\n                    </thead>\r\n                 " +
"   <tbody>\r\n");


            
            #line 88 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                     foreach (var job in recurringJobs)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <tr class=\"js-jobs-list-row hover\">\r\n                    " +
"        <td>\r\n                                <input type=\"checkbox\" class=\"js-j" +
"obs-list-checkbox\" name=\"jobs[]\" value=\"");


            
            #line 92 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                     Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n                            </td>\r\n                            <td class=\"mi" +
"n-width\">");


            
            #line 94 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                             Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td class=\"min-width\">\r\n                      " +
"          ");



WriteLiteral("\r\n");


            
            #line 97 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                  
                                    var cronDescription = job.Cron;
                                    try
                                    {
                                        cronDescription = ExpressionDescriptor.GetDescription(job.Cron);
                                    }
                                    catch (FormatException)
                                    {
                                    }
                                

            
            #line default
            #line hidden
WriteLiteral("                                ");


            
            #line 107 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                           Write(cronDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </td>\r\n                            <td class=\"min-w" +
"idth\">\r\n");


            
            #line 110 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 if (!String.IsNullOrWhiteSpace(job.TimeZoneId))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <span title=\"");


            
            #line 112 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            Write(TimeZoneInfo.FindSystemTimeZoneById(job.TimeZoneId).DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\" data-container=\"body\">");


            
            #line 112 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                                                                    Write(job.TimeZoneId);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 113 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    ");

WriteLiteral(" UTC\r\n");


            
            #line 117 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td>\r\n");


            
            #line 120 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 if (job.Job != null)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    ");

WriteLiteral(" ");


            
            #line 122 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                  Write(Html.JobName(job.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 123 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <em>");


            
            #line 126 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                   Write(job.LoadException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 127 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td class=\"align-r" +
"ight min-width\">\r\n");


            
            #line 130 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 if (job.NextExecution != null)
                                {
                                    
            
            #line default
            #line hidden
            
            #line 132 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                               Write(Html.RelativeTime(job.NextExecution.Value));

            
            #line default
            #line hidden
            
            #line 132 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                               
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <em>");


            
            #line 136 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                   Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 137 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                            <td class=\"align-r" +
"ight min-width\">\r\n");


            
            #line 140 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                 if (job.LastExecution != null)
                                {
                                    if (!String.IsNullOrEmpty(job.LastJobId))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <a href=\"");


            
            #line 144 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                            Write(Url.JobDetails(job.LastJobId));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                            <span class=\"label label-default " +
"label-hover\" style=\"");


            
            #line 145 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                                            Write(String.Format("background-color: {0};", JobHistoryRenderer.GetForegroundStateColor(job.LastJobState)));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                                ");


            
            #line 146 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                           Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                            </span>\r\n                          " +
"              </a>\r\n");


            
            #line 149 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <em>\r\n                                   " +
"         ");


            
            #line 153 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                       Write(Strings.RecurringJobsPage_Canceled);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 153 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                                                           Write(Html.RelativeTime(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                                        </em>\r\n");


            
            #line 155 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                    }
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <em>");


            
            #line 159 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                   Write(Strings.Common_NotAvailable);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 160 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </td>\r\n                        </tr>\r\n");


            
            #line 163 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n");


            
            #line 167 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                 if (pager != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral(" ");


            
            #line 169 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                  Write(Html.Paginator(pager));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 170 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 172 "..\..\Dashboard\Pages\RecurringJobsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>    ");


        }
    }
}
#pragma warning restore 1591
