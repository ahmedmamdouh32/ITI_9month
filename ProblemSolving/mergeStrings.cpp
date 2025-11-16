class Solution {
public:
    string mergeAlternately(string word1, string word2) {
        
    string mergeStr;

	int word1_length = word1.length();    
	int word2_length = word2.length();
    int shortest_word_length = min(word1_length, word2_length);

    for (int i = 0; i < shortest_word_length; i++) {
		mergeStr += word1[i];
		mergeStr += word2[i];
    }

    if(word1_length != word2_length)
        if (word1_length > word2_length) {
		    mergeStr += word1.substr(shortest_word_length);
	    }
        else{
            mergeStr += word2.substr(shortest_word_length);
        }

    return mergeStr;
    }
};