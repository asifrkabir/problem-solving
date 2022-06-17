public String stringYak(String str) {
  if(str.length() <= 2) return str;
  
  String output = "";
  
  for(int i = 0; i < str.length();){
    if(str.substring(i).length() >= 3){
      if(!(str.charAt(i) == 'y' && str.charAt(i + 2) == 'k')){
        output += str.substring(i, i + 1);
        i++;
      }
      else i += 3;
    }
    else if(str.substring(i).length() < 3){
      output += str.substring(i);
      break;
    }
  }
  
  return output;
}