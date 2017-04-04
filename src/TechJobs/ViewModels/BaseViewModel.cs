using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // TODO #7.0 - Extract members common to JobFieldsViewModel and 
        // SearchJobsViewModel to BaseViewModel
        
        // The search results
        // public List<Job> Jobs { get; set; } // No

        // The column to search, defaults to all
        // public JobFieldType Column { get; set; } = JobFieldType.All; // No

        // The search value
        // [Display(Name = "Keyword:")] // No
        // public string Value { get; set; } = ""; // No

        // All columns, for display
        public List<JobFieldType> Columns { get; set; } // yes

        // View title
        public string Title { get; set; } = ""; // yes

        public BaseViewModel() // No... combine public JobFieldsViewModel() & public SearchJobsViewModel()
                               // OK this is likely going to be solved using interfaces. 
                               // Look at http://stackoverflow.com/questions/178333/multiple-inheritance-in-c-sharp
        {
            // Populate the list of all columns

            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
