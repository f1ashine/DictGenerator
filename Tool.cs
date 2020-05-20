using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DictGenerator
{
    class Tool
    {
        /// <summary>
        /// 解析exe目录下的config文件
        /// </summary>
        public static Config parseJsonByFile(string filePath)
        {
            try {
                using (System.IO.StreamReader file = System.IO.File.OpenText(filePath))
                {
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject o = (JObject)JToken.ReadFrom(reader);
                        return parse(o);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Out.WriteLine(e.Message);
                return null;
            }
        }
        /// <summary>
        /// 解析Resource中的config文件
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Config parseJsonByResource(String json)
        {
            return parse(JObject.Parse(json));
        }

        private static Config parse(JObject o)
        {
            Config config = new Config();
            config.setObj(o);
            foreach (JProperty i in o.Properties())
            {
                switch (i.Path)
                {
                    case "combination": break;
                    case "symbols":
                        JArray array = (JArray)i.Value;
                        foreach (JValue value in array)
                        {
                            String str = (String)value.Value;
                            if (!String.IsNullOrEmpty(str))
                                config.Symobls.Add(str);
                        }
                        break;
                    case "commonString":
                        JArray tmp = (JArray)i.Value;
                        foreach (JValue value in tmp)
                        {
                            String _ = (String)value.Value;
                            if (!String.IsNullOrEmpty(_))
                                config.commonString.Add(_);
                        }
                        break;
                    default:
                        return null;
                }
            }
            return config;
        }
        /// <summary>
        /// 反转字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String ToReverse(String s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        /// <summary>
        /// 返回首字母大写的字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static String ToFirstUpper(String s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1);
        }
        /// <summary>
        /// 将Treenode集合转为字符串集合
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<String> convertNodeToList(List<TreeNode> list)
        {
            List<String> tmp = new List<string>();
            foreach (TreeNode node in list)
            {
                tmp.Add(node.Text);
            }
            return tmp;
        }
        /// <summary>
        /// 根据要求的长度对元素进行组合
        /// </summary>
        /// <param name="list"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static List<String> generateList(List<string> list, int length)
        {
            if (length == 1 || list.Count == 1)
            {
                return list;
            }
            var res = list;
            List<String> result = new List<string>(list);
            for (int i = 1; i < length; i++)
            {
                res = (from s in list from l in res select s + l).ToList();
                result.AddRange(res);
            }
            return result;
        }

        public static List<String> combineDict(Stack<List<String>> s)
        {
            if (s.Count == 0)
            {
                return null;
            }
            if (s.Count == 1)
            {
                return s.Pop();
            }
            else
            {
                List<String> l1 = s.Pop();
                List<String> l2 = s.Pop();
                s.Push(generateList(l2, l1));
                return combineDict(s);
            }
        }
        /// <summary>
        /// 组合字典
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static List<String> generateList(List<String> first, List<String> second)
        {
            return (from f in first from s in second where !s.Contains(f) select new System.Text.StringBuilder(f).Append(s).ToString()).ToList();
        }

        /// <summary>
        /// 合并数组中的字符到一个字符串中
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static String mergeArray(String[] str)
        {
            String s = "";
            foreach (String tmp in str)
            {
                s += tmp;
            }
            return s;
        }
        /// <summary>
        /// 将数组中每个元素的首字母大写然后再合并
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static List<String> getNameList(String[] str)
        {
            List<String> list = new List<String>();
            String firstUpper = "";
            String Abbr = "";
            String firstUpperAbbr = "";
            foreach (String tmp in str)
            {
                firstUpper += ToFirstUpper(tmp);
                Abbr += tmp.Substring(0, 1).ToUpper();
                firstUpperAbbr += tmp.Substring(0, 1);
            }
            list.Add(firstUpper);
            list.Add(Abbr);
            list.Add(firstUpper);
            return list;
        }


        public static String toJsonFormat(String s)
        {
            String[] str = s.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 0; i < str.Length; i++)
            {
                str[i] = "\"" + str[i].Trim() + "\",\n";
            }
            return mergeArray(str);
        }

    }
}
