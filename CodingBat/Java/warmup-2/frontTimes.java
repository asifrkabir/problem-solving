public String frontTimes(String str, int n) {
  String output = "";
  String front;
  
  if(str.length() >= 3) front = str.substring(0, 3);
  else front = str;
  
  for(int i = 0; i < n; i++){
    output += front;
  }
  
  return output;
}