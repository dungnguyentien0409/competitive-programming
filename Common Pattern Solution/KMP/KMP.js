/*
 * Problem: KMP Search
 * Implemented by: Dung Nguyen Tien (Chris)
 * Explaination from: Tushar Roy
 * Build the computed pattern: https://www.youtube.com/watch?v=KG44VoDtsAA&t=475s
 * KMP Search: https://www.youtube.com/watch?v=GTJr8OvyEVQ&t=30s
*/

function buildComputedPattern(pattern) {
  //first value is 0
  // prefix is the end of the prefix, suffix is the end of the suffix
  var computedPattern = Array(pattern.length).fill(0);
  var prefix = 0, suffix = 1;
  var length
  
  while(suffix < pattern.length) {
    if (pattern[prefix] == pattern[suffix]) {
      computedPattern[suffix] = prefix + 1;;
      prefix++;
      suffix++;
    }
    else if (prefix == 0) {
      computedPattern[suffix++] = 0;
    }
    else {
      prefix = computedPattern[prefix - 1];
    }
  }
  
  return computedPattern;
}

function KMPSearch(word, pattern) {
  if (word.length == 0) return -1;
  
  var wordIndex = 0, patternIndex = 0;
  var computedPattern = buildComputedPattern(pattern);
  
  while(wordIndex < word.length) {
    if (word[wordIndex] == pattern[patternIndex]) {
      if (patternIndex == pattern.length - 1) return wordIndex - patternIndex;
      
      ++wordIndex;
      ++patternIndex;
    }
    else if (patternIndex == 0) {
      ++wordIndex;
    }
    else { //wordIndex > 0
      patternIndex = computedPattern[patternIndex - 1];
    }
  }
}

var word = "abxacacacb";
var pattern = "acacb";
document.writeln(KMPSearch(word, pattern));

