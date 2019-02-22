namespace LIKHAB.DataLayer.Interface
{
    public interface IRandevu
    {
        int Is { get; set; } // Is
        string Title { get; set; } // Title (length: 200)
        string Description { get; set; } // Description
        System.DateTime? StartDate { get; set; } // StartDate
        System.DateTime? EndDate { get; set; } // EndDate
        string Location { get; set; } // Location (length: 200)
        bool? AllDay { get; set; } // AllDay
        int? Type { get; set; } // Type
        string Subject { get; set; } // Subject (length: 200)
        int? Status { get; set; } // Status
        int? Label { get; set; } // Label
    }
}