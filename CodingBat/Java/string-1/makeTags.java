public String makeTags(String tag, String word) {
  String startTag = "<" + tag + ">";
  String endTag = "</" + tag + ">";
  
  return startTag + word + endTag;
}