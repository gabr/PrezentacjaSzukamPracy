string[] GetUsersUniqueNames()
{
  // get all users

  // extract names only

  // remove duplicates

  // return result
}


string[] GetUsersUniqueNames()
{
  // get all users
  Repository repo = new Repository();
  var users = repo.GetUsers();

  // extract names only
  string[] names = new string[users.Length];
  for (int i = 0; i < users.Length; i++)
    names[i] = users[i].Name;

  // remove duplicates
  HashSet<string> uniqueNames = new HashSet<string>();
  foreach (string name i names)
    uniqueNames.Add(name);

  // return result
  return uniqueNames.ToArray();
}


string[] GetUsersUniqueNames()
{
  return new Repository()
    .GetUsers()
    .GroupBy(u => u.Name)
    .Select(g => g.Key)
    .ToArray();
}


string[] GetUsersUniqueNames()
{
  var users = GetAlLUsers();
  var usersNames = ExtractUsersNames(users);
  return GetUniqueValues(usersNames);
}

