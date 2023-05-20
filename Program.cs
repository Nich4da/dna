using System;

class Program
{
    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Enter half of the DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);

                Console.Write("Do you want to replicate it? (Y/N): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == 'Y' || choice == 'y')
                {
                    string replicatedSequence = ReplicateSequence(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice == 'N' || choice == 'n')
                {
                    // Skip DNA replication
                }
                else
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char programChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (programChoice == 'N' || programChoice == 'n')
            {
                continueProgram = false;
            }
            else if (programChoice != 'Y' && programChoice != 'y')
            {
                Console.WriteLine("Please input Y or N.");
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

    static string ReplicateSequence(string halfDNASequence)
    {
        string replicatedSequence = "";

        foreach (char nucleotide in halfDNASequence)
        {
            switch (nucleotide)
            {
                case 'A':
                    replicatedSequence += 'T';
                    break;
                case 'T':
                    replicatedSequence += 'A';
                    break;
                case 'C':
                    replicatedSequence += 'G';
                    break;
                case 'G':
                    replicatedSequence += 'C';
                    break;
            }
        }

        return replicatedSequence;
    }
}

