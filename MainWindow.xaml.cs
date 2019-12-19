using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            /**/
        }


        /*
         给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。

        示例 1：

        输入: "babad"
        输出: "bab"
        注意: "aba" 也是一个有效答案。


        示例 2：

        输入: "cbbd"
        输出: "bb"

         */

        /// <summary>
        /// 回文缓存，key开始索引,value结束索引，同开始索引回文只缓存最大
        /// </summary>
        Dictionary<int, int> palindromes = new Dictionary<int, int>();
        public string LongestPalindrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i];
                foreach (var item in palindromes)
                {
                    //相邻
                    if (item.Value + 1 == i)
                    {
                        var newKey = item.Key - 1;
                        var newValue = i;
                        //能组成新回文
                        if (newKey >= 0 && s[newKey] == c)
                        {
                            palindromes[newKey] = newValue;
                        }
                    }

                    //相邻上一个
                    if (item.Value + 2 == i)
                    {

                    }
                }
                palindromes.Add(i, i);
            }
            return null;
        }
    }
}
