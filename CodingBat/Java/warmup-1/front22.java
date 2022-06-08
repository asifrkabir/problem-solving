public String front22(String str) {
  String repeat;
  
  if(str.length() < 2) repeat = str;
  else repeat = str.substring(0, 2);
  
  return repeat + str + repeat;
}