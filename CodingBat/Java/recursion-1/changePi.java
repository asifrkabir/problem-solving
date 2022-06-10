public String changePi(String str) {
  if(str.length() <= 1 || !str.contains("pi")) return str;
  
  if(str.charAt(0) == 'p' && str.charAt(1) == 'i'){
    return "3.14" + changePi(str.substring(2));
  }
  
  return String.valueOf(str.charAt(0)) + changePi(str.substring(1));
}