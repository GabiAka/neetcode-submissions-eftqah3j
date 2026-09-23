public class TimeMap {
    public Dictionary<string, List<(int timeStamp, string value)>> timeMap { get; set; }

    public TimeMap() {
        timeMap = new Dictionary<string, List<(int timeStamp, string value)>>();
    }

    public void Set(string key, string value, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            timeMap.Add(key, new List<(int timeStamp, string value)>() { (timestamp, value) });
        } else {
            timeMap[key].Add((timestamp, value));
        }
    }

    public string Get(string key, int timestamp) {
        if (!timeMap.ContainsKey(key))
            return "";

        // get list value of key
        List<(int timeStamp, string value)> listItem = timeMap[key];
        int l = 0, r = listItem.Count;

        while (l < r) {
            int m = l + (r - l) / 2;
            //1 2 3 3 3 5 7 8

            if ( listItem[m].Item1 > timestamp) {
                r = m;
            } else {
                l = m + 1;
            }
        }

      if (l == 0)
    return "";

return listItem[l - 1].Item2;
    }
}
