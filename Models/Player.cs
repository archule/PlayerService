/* internal representation of our data */
// DTO --> external representation

using System.ComponentModel.DataAnnotations;
namespace PlayerService.Models
{

    public class Player {

        [Key]
        [Required]
        public int Id { get; set;}
        
        [Required]
        public string FirstName {get; set;}
        
        [Required]
        public string LastName {get; set;}
        
        [Required]
        public string Position {get;set;}
        [Required]      
        public string College {get;set;}

        [Required]
        public float Rating {get;set;}


        public string PlayerInfo {get;set;}


        public string Class {get;set;}
        


        [Required]
        public int Height {get;set;}

        [Required]
        public int Weight {get;set;}

        [Required]
        public float Arms {get;set;}

        [Required]
        public float Hands {get;set;}

        [Required]
        public int Age {get;set;}

        [Required]
        public string Hometown {get;set;}       

        [Required]
        public string ScoutingReport {get;set;} 

        [Required]
        public float Forty {get;set;} 

        [Required]
        public int Bench {get;set;} 

        [Required]
        public float VerticalJump {get;set;} 

        [Required]
        public float BroadJump {get;set;} 

        [Required]
        public float ThreeCone {get;set;} 

        [Required]
        public float TwentyYardShuttle {get;set;} 

        [Required]
        public float SixtyYardShuttle {get;set;} 
        
    }
}