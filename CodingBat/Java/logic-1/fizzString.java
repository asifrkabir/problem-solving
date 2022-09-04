public String fizzString(String str) {
  if(str.length() >= 1){
    if(str.length() == 1){
      if(str.charAt(0) == 'f') return "Fizz";
      
      if(str.charAt(0) == 'b') return "Buzz";
    }
    else{
      if(str.charAt(0) == 'f'){
        if(str.charAt(str.length() - 1) == 'b') return "FizzBuzz";
        
        return "Fizz";
      }
      
      if(str.charAt(str.length() - 1) == 'b') return "Buzz";
    }
  }
  
  return str;
}