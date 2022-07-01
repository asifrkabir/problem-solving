public String extraEnd(String str) {
  String repeatChars = str.substring(str.length() - 2);
  
  return repeatChars + repeatChars + repeatChars;
}