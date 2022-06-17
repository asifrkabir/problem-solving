public String altPairs(String str) {
  if(str.length() <= 2) return str;
  
  String output = "";
  
  for(int i = 0; i < str.length();){
    output += str.charAt(i);
    
    if(i % 2 == 0) i++;
    else i += 3;
  }
  
  return output;
}