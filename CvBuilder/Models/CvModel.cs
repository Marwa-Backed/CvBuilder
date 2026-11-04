namespace CvBuilder.Models
{
        public class CvModel
        {
            public string FullName { get; set; } = "";
            public string JobTitle { get; set; } = "";
            public string Email { get; set; } = "";
            public string Phone { get; set; } = "";
            public string Address { get; set; } = "";
            public string Summary { get; set; } = "";
            public string Experience { get; set; } = "";
            public string Education { get; set; } = "";
            public string Skills { get; set; } = "";
            public string Languages { get; set; } = "";
            public string SelectedColor { get; set; } = "#0B3B3A";
            public string TemplateStyle { get; set; } = "Modern";
            public string PhotoBase64 { get; set; } = ""; 
        }
    }
   