public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        int length = nums.Length;

//tạo bucket
Dictionary<int, int> bucket = new Dictionary<int, int>();
foreach (var item in nums)
{
			if (bucket.ContainsKey(item)) bucket[item] += 1;
			else bucket.Add(item, 1);
}

//reverse lại bucket
Dictionary<int, List<int>> reverseBucket = new Dictionary<int, List<int>>();
foreach (var item in bucket)
{
			if (reverseBucket.ContainsKey(item.Value))
			{
				reverseBucket[item.Value].Add(item.Key);
			}
			else
			{
				reverseBucket.Add(item.Value, new List<int>() { item.Key });
			}
}

	//loop ngược tại lấy k top frequent
	int n = 0;
	List<int> res = new List<int>();
	for (int i = length; i > 0; i--)
	{
		if (!reverseBucket.ContainsKey(i)) continue;

		if (n >= k) break;

		res.AddRange(reverseBucket[i]);
		n += reverseBucket[i].Count;


	}
return res.ToArray();
    }
}
