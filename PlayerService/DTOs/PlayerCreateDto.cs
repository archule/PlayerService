using System.ComponentModel.DataAnnotations;

namespace PlayerService.Dtos {
    public class PlayerCreateDto {

       
        public string FirstName {get; set;} 
        
     
        public string LastName {get; set;}
        
        public string College {get;set;}
    }
}