public class Solution
{
    public int NumUniqueEmails(string[] emails)
    {
        var emailCount = 0;
        var uniqueEmails = new List<string>();

        foreach (var email in emails)
        {
            var realEmail = ForwardEmail(email);

            if (!uniqueEmails.Contains(realEmail))
            {
                uniqueEmails.Add(realEmail);
                emailCount++;
            }
        }

        return emailCount;
    }

    public static string ForwardEmail(string email)
    {
        var indexOfDomain = email.IndexOf('@');
        var localName = email.Substring(0, indexOfDomain);
        var domainName = email.Substring(indexOfDomain);

        if (localName.Contains('+'))
        {
            localName = localName.Substring(0, localName.IndexOf('+'));
        }

        if (localName.Contains('.'))
        {
            localName = localName.Replace(".", string.Empty);
        }

        return localName + domainName;
    }
}