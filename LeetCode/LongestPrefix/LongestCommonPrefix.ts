function longestCommonPrefix(strs: string[]): string {
  let len = strs.length;
  if (len < 2) {
    return strs[0];
  }
  let str1 = strs[0];
  let str2 = strs[1];

  let lngPrefixStr = "";
  let shorterStrLen = str1.length < str2.length ? str1.length : str2.length;

  for (let i = 0; i < shorterStrLen; i++) {
    if (str1[i] === str2[i]) {
      lngPrefixStr += str1[i];
    } else {
      break;
    }
  }
  if (lngPrefixStr != "" && len > 2) {
    for (let i = 2; i < strs.length; i++) {
      let strToCheck = strs[i];
      let limit = Math.min(lngPrefixStr.length, strToCheck.length);
      let j = 0;
      while (j < limit && lngPrefixStr[j] == strToCheck[j]) {
        j++;
      }
      lngPrefixStr = lngPrefixStr.slice(0, j);
      if (lngPrefixStr == "") break;
    }
  }

  return lngPrefixStr;
}
