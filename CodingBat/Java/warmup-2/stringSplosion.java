public String stringSplosion(String str) {
  String output = "";
  
  for(int i = 1; i <= str.length(); i++){
    output += str.substring(0, i);
  }
  
  return output;
}