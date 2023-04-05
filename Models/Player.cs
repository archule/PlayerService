/* internal representation of our data */
// DTO --> external representation

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayerService.Models
{

    public class Player {


        /* can be PlayerId or Id or have key annotation */
        [Key]
        [Required]
        public int Id { get; set;}
        
        
        /* nullable reference type allowed by default */
        [Required]
        public string FirstName {get; set;} = null!;
        
        [Required]
        public string LastName {get; set;}
        
        
        public string? Position {get;set;} = null!;
             
        public string College {get;set;}



        public string? Class {get;set;}

      
        public float Rating {get;set;}


        //[Required(AllowEmptyStrings = true)]
        public string? PlayerInfo {get;set;}

        /*


        [Required]
        public int Height {get;set;}

        [Required]
        public int Weight {get;set;}

        [Required]
        public float Arms {get;set;}


        public float Hands {get;set;}


        public int Age {get;set;}

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
        [Column(TypeName = "decimal(6,2)")]
        public decimal SixtyYardShuttle {get;set;}
        */ 
        
    }
}