public String everyNth(String str, int n) {
  String output = Character.toString(str.charAt(0));
  
  if(n < str.length() - 1){
    for(int i = n; i < str.length(); i += n){
      output += Character.toString(str.charAt(i));
    }
  }
  
  return output;
}