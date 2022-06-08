public String backAround(String str) {
  String lastChar = Character.toString(str.charAt(str.length() - 1));
  return lastChar + str + lastChar;
}