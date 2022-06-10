public int countHi2(String str) {
  if(str.length() <= 1) return 0;
  
  if(str.substring(0, 2).equals("hi")){
    return 1 + countHi2(str.substring(2));
  }
  
  if(str.charAt(0) == 'x'){
    if(str.length() >= 3 && str.substring(1, 3).equals("hi")){
      return 0 + countHi2(str.substring(3));
    }
  }
  
  return 0 + countHi2(str.substring(1));
}