class program
{
    static void Main(string[] args)
    {

        while (true)
        {

            string nucleotide = Console.ReadLine();

            if (IsValidSequence(nucleotide))
            {
                Console.WriteLine("Current half DNA sequence : {0}", nucleotide);
                while (true)
                {
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    string replicate = Console.ReadLine();
                    if (replicate == "Y")
                    {
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(nucleotide));
                        break;
                    }
                    else if (replicate == "N")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please input Y or N.");
                    }
                }
            } else{
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence ? (Y/N) : ");
            string invalid = Console.ReadLine();
            if (invalid == "Y")
            {
                continue;
            }
            else if (invalid == "N")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please input Y or N.");
                continue;
            }

        } 
    }
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }
    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}