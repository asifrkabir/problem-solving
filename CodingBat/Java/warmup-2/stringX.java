public String stringX(String str) {
  if(str.length() <= 2) return str;
  
  String output = str.substring(0, 1);
  
  for(int i = 1; i < str.length() - 1; i++){
    if(str.charAt(i) != 'x'){
      output += str.charAt(i);
    }
  }
  
  output += str.substring(str.length() - 1);
  
  return output;
}