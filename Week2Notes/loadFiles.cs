
            _entries.Clear();
            Console.WriteLine(Path.GetFullPath(filename));
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryResponse = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Journal loaded successfully.");