using System.ComponentModel.DataAnnotations;

namespace PlayerService.Dtos {
    public class PlayerReadDto {

        public int Id { get; set;}

       
        public string FirstName {get; set;} 
        
      
        public string LastName {get; set;}
        
        public string College {get;set;}
    }
}