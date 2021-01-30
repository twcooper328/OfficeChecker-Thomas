using System.ComponentModel.DataAnnotations;

namespace OfficeChecker.Models
{
    //this is just for convenience 
    #region Enum Multi-Select Field
    
    public enum officeStatus
    {
        Closed, By_Invitation_Only, Reservation_Required, Business_As_Usual
    }

    
    public enum officeServices
    {
        Full, Limited, Suspended
    }

    public enum techSupport
    {
        Yes=1 
        ,Not_Currently=2 
        ,Reservation_Only=3

    }

    public enum locationType
    {
        Corporate, Innovation, Delivery_Center, Business
    }
    

    public enum marketUnit
    {
         Northeast, Midwest, South, West
    }
    //covid region
    public enum faceCovering
    {
        Required, Optional
    }
    public enum temperatureChecking
    {
        Conducting_Employee_selfCheck=1
        ,Conducting_by_Accenture=2
        ,Conducting_by_building_not_Accenture=3
        ,Not_Conducting=4

    }
    #endregion


    public class Office
    {
        

        public int ID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string OfficeName { get; set; }
        public marketUnit MarketUnit { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string Zip { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 10)]
        [Phone]
        
        public string PhoneNumber { get; set; }
        [Required]
        public officeStatus OfficeStatus { get; set; }
        [Required]
        public officeServices OfficeServices { get; set; }
        [Required]
        public bool Visitors { get; set; }
        [Required]
        public locationType LocationType { get; set; }
        [Required]
        public techSupport TechSupport { get; set; }  
        [Required]  
        public bool ReservableSpace { get; set; }
        
        public string DressCode { get; set; }     
        public string AdditionalInfo { get; set; }

        //Covid Info
        
        [Required]
        public faceCovering FaceCoverings { get; set; }
        [Required]
        public temperatureChecking TemperatureChecking { get; set;}

        //specialConsiderations multi select field
        [Required]
        public bool PhysicalDistancing { get; set; }
        [Required]
        public bool TemperatureChecks {get; set; } 
        public bool OtherProtocols { get; set; }
        public string SpecialDetails { get; set;}

        public string FullAddress { get { return Address + ", " + City + ", " + State + ", " + Zip;}
        }
    }
}