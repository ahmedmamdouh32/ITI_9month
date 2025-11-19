class Solution {
public:
	bool repeatedSubstringPattern(string s)
	{
		int s_length = s.length();

		if (s_length % 2 == 0) {
			if (s.substr(0, s_length / 2) == s.substr(s_length / 2, s_length / 2)) {
				return true;
			}
		}

		bool result = false;

		for (int substr_length = 1; substr_length <= s_length / 2;substr_length++)
		{
			if (s_length % substr_length == 0)
			{
				for (int i = 0; i < s_length - substr_length;i += substr_length)
				{
					if (s.substr(i, substr_length) == s.substr(i + substr_length, substr_length))
					{
						result = true;
					}
					else
					{
						result = false;
						break;
					}
				}
			}
			if (result) {
				return result;
			}
		}
		return result;
	}
};