public String frontBack(String str) {
  if(str.isEmpty() || str.length() == 1) return str;
  else if(str.length() == 2) return Character.toString(str.charAt(1)) + Character.toString(str.charAt(0));
  return Character.toString(str.charAt(str.length() - 1)) + str.substring(1, str.length() - 1) + Character.toString(str.charAt(0));
}