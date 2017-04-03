using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class SearchJobsViewModel 
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        // The search results
        public List<Job> Jobs { get; set; } // keep

        // The column to search, defaults to all
        public JobFieldType Column { get; set; } = JobFieldType.All; // keep

        // The search value
        [Display(Name = "Keyword:")] // keep
        public string Value { get; set; } = "";

        // All columns, for display
        // public List<JobFieldType> Columns { get; set; } // dup

        // View title
        // public string Title { get; set; } = ""; // dup

        /* public SearchJobsViewModel() // dup
        {
            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
            */

        }
    }
}
