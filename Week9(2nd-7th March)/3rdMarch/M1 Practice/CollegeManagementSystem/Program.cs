namespace CollegeManagementSystem
{
    internal class Program
    {
        class CollageManagement
        {
            Dictionary<string, Dictionary<string, int>> studentRecords = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, LinkedList<KeyValuePair<string, int>>> studentSubjectsOrder = new Dictionary<string, LinkedList<KeyValuePair<string, int>>>();
            Dictionary<string, Dictionary<string, int>> subjectsRecords = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, LinkedList<KeyValuePair<string, int>>> subjectsStudentsOrder = new Dictionary<string, LinkedList<KeyValuePair<string, int>>>();

            public int AddStudent(string studentId, string subject, int marks)
            {
                // Add to studentRecords
                if (!studentRecords.ContainsKey(studentId))
                {
                    studentRecords[studentId] = new Dictionary<string, int>();
                    studentSubjectsOrder[studentId] = new LinkedList<KeyValuePair<string, int>>();
                }

                if (studentRecords[studentId].ContainsKey(subject))
                {
                    if (marks > studentRecords[studentId][subject])
                    {
                        studentRecords[studentId][subject] = marks;

                        // Update linked list
                        var node = studentSubjectsOrder[studentId].First;
                        while (node != null)
                        {
                            if (node.Value.Key == subject)
                            {
                                node.Value = new KeyValuePair<string, int>(subject, marks);
                                break;
                            }
                            node = node.Next;
                        }
                    }
                }
                else
                {
                    studentRecords[studentId][subject] = marks;
                    studentSubjectsOrder[studentId].AddLast(
                        new KeyValuePair<string, int>(subject, marks));
                }

                // Add to subjectsRecords
                if (!subjectsRecords.ContainsKey(subject))
                {
                    subjectsRecords[subject] = new Dictionary<string, int>();
                    subjectsStudentsOrder[subject] =
                        new LinkedList<KeyValuePair<string, int>>();
                }

                if (subjectsRecords[subject].ContainsKey(studentId))
                {
                    if (marks > subjectsRecords[subject][studentId])
                    {
                        subjectsRecords[subject][studentId] = marks;

                        var node = subjectsStudentsOrder[subject].First;
                        while (node != null)
                        {
                            if (node.Value.Key == studentId)
                            {
                                node.Value = new KeyValuePair<string, int>(studentId, marks);
                                break;
                            }
                            node = node.Next;
                        }
                    }
                }
                else
                {
                    subjectsRecords[subject][studentId] = marks;
                    subjectsStudentsOrder[subject].AddLast(
                        new KeyValuePair<string, int>(studentId, marks));
                }

                return 1;
            }

            public int RemoveStudent(string studentId)
            {
                if (!studentRecords.ContainsKey(studentId))
                    return 0;

                // Remove from subjectsRecords
                foreach (var subject in studentRecords[studentId].Keys)
                {
                    subjectsRecords[subject].Remove(studentId);

                    var node = subjectsStudentsOrder[subject].First;
                    while (node != null)
                    {
                        if (node.Value.Key == studentId)
                        {
                            subjectsStudentsOrder[subject].Remove(node);
                            break;
                        }
                        node = node.Next;
                    }
                }

                studentRecords.Remove(studentId);
                studentSubjectsOrder.Remove(studentId);

                return 1;
            }

            public string TopStudent(string subject)
            {
                if (!subjectsStudentsOrder.ContainsKey(subject))
                    return "";

                int max = subjectsRecords[subject].Values.Max();
                List<string> result = new List<string>();

                foreach (var kvp in subjectsStudentsOrder[subject])
                {
                    if (kvp.Value == max)
                    {
                        result.Add(kvp.Key + " " + max);
                    }
                }

                return string.Join("\n", result);
            }

            public string Result()
            {
                List<string> output = new List<string>();

                foreach (var student in studentSubjectsOrder)
                {
                    double avg = student.Value.Average(x => x.Value);
                    output.Add(student.Key + " " + avg.ToString("F2"));
                }

                return string.Join("\n", output);
            }
            static void Main(string[] args)
            {
                CollageManagement cm = new CollageManagement();
                string input;

                while ((input = Console.ReadLine()) != null)
                {
                    string[] parts = input.Split(' ');

                    if (parts[0] == "ADD")
                    {
                        cm.AddStudent(parts[1], parts[2], int.Parse(parts[3]));
                    }
                    else if (parts[0] == "REMOVE")
                    {
                        cm.RemoveStudent(parts[1]);
                    }
                    else if (parts[0] == "TOP")
                    {
                        Console.WriteLine(cm.TopStudent(parts[1]));
                    }
                    else if (parts[0] == "RESULT")
                    {
                        Console.WriteLine(cm.Result());
                    }
                }

            }
        }
    }
}
