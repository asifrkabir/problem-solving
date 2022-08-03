public String extraFront(String str) {
  if(str.length() == 0) return "";
  
  if(str.length() == 1) return str + str + str;
  
  String repeatingString = str.substring(0, 2);
  
  return repeatingString + repeatingString + repeatingString;
}