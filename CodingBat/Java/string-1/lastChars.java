public String lastChars(String a, String b) {
  String output = "";
  
  if(a.length() == 0) output += "@";
  else output += a.substring(0, 1);
  
  if(b.length() == 0) output += "@";
  else output += b.substring(b.length() - 1);
  
  return output;
}