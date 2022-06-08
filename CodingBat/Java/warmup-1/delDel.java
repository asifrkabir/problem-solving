public String delDel(String str) {
  if(str.length() >= 4){
    String del = str.substring(1, 4);
  
  if(del.equals("del")) return str.substring(0, 1) + str.substring(4);
  }
  
  return str;
}