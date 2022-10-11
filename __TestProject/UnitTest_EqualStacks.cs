using EqualStacks;
using System.Diagnostics;

namespace __TestProject
{
    public class UnitTest_EqualStacks
    {
        [Fact]
        public void Test1()
        {
            int result = 0;

            result = EqualStacksClass.equalStacks(
                new List<int>() { 1, 2, 1, 1 },
                new List<int> { 1, 1, 2 },
                new List<int> { 1, 1 });

            Assert.Equal(2, result);

            result = EqualStacksClass.equalStacks(
                new List<int>() { 3, 2, 1, 1, 1 },
                new List<int> { 4, 3, 2 },
                new List<int> { 1, 1, 4, 1 });

            Assert.Equal(5, result);

            result = EqualStacksClass.equalStacks(
                new List<int>() { 12, 22, 5, 4, 33, 2, 2, 3, 2, 1, 1, 1 },
                new List<int> { 4, 3, 2 },
                new List<int> { 1, 1, 4, 1 });

            Assert.Equal(5, result);
        }

        [Fact]
        public void Test2()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "TestData", "EqualStacks");
            DirectoryInfo dir = new DirectoryInfo(path);
            Assert.True(dir.Exists);

            // 37455 79656 95073

            var filePath = Path.Combine(path, "0201.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            Assert.True(fileInfo.Exists);
            var data1 = GetData(fileInfo);
            Assert.NotEmpty(data1);
            Assert.True(data1.Count == 37455);

            filePath = Path.Combine(path, "0202.txt");
            fileInfo = new FileInfo(filePath);
            Assert.True(fileInfo.Exists);
            var data2 = GetData(fileInfo);
            Assert.NotEmpty(data2);
            Assert.True(data2.Count == 79656);

            filePath = Path.Combine(path, "0203.txt");
            fileInfo = new FileInfo(filePath);
            Assert.True(fileInfo.Exists);
            var data3 = GetData(fileInfo);
            Assert.NotEmpty(data3);
            Assert.True(data3.Count == 95073);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = EqualStacksClass.equalStacks(data1, data2, data3);
            watch.Stop();
            Assert.Equal(1656086, result);
            Assert.True(watch.ElapsedMilliseconds < 9000, "TIMEOUT!!!");
        }

        [Fact]
        public void Test3()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "TestData", "EqualStacks");
            DirectoryInfo dir = new DirectoryInfo(path);
            Assert.True(dir.Exists);

            // 80242 71404 24125

            var filePath = Path.Combine(path, "0101.txt");
            FileInfo fileInfo = new FileInfo(filePath);
            Assert.True(fileInfo.Exists);
            var data1 = GetData(fileInfo);
            Assert.NotEmpty(data1);
            Assert.True(data1.Count == 80242);

            filePath = Path.Combine(path, "0102.txt");
            fileInfo = new FileInfo(filePath);
            Assert.True(fileInfo.Exists);
            var data2 = GetData(fileInfo);
            Assert.NotEmpty(data2);
            Assert.True(data2.Count == 71404);

            filePath = Path.Combine(path, "0103.txt");
            fileInfo = new FileInfo(filePath);
            Assert.True(fileInfo.Exists);
            var data3 = GetData(fileInfo);
            Assert.NotEmpty(data3);
            Assert.True(data3.Count == 24125);

            Stopwatch watch = new Stopwatch();
            watch.Start();
            var result = EqualStacksClass.equalStacks(data1, data2, data3);
            watch.Stop();
            Assert.Equal(1162867, result);
            Assert.True(watch.ElapsedMilliseconds < 4000, "TIMEOUT!!!");
        }

        public List<int> GetData(FileInfo fileInfo)
        {
            var lines = File.ReadAllLines(fileInfo.FullName);
            List<int> tmp = new List<int>();
            foreach (var line in lines)
            {
                tmp = new List<int>();
                var str = line.Split(" ", StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
                foreach (var s in str)
                {
                    int arrItem = Convert.ToInt32(s);
                    tmp.Add(arrItem);
                }
            }
            return tmp;
        }
    }
}