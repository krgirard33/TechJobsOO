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

        // All columns, for display
        public List<JobFieldType> Columns { get; set; } // yes

        // View title
        public string Title { get; set; } = ""; // yes

        public BaseViewModel() 
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
