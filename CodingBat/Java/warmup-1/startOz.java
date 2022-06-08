public String startOz(String str) {
  String output = "";
  
  if(str.length() == 1 && str.charAt(0) == 'o') output += "o";
  
  if(str.length() >= 2){
    
    if(str.charAt(0) == 'o') output += "o";
    if(str.charAt(1) == 'z') output += "z";
  }
  
  return output;
}