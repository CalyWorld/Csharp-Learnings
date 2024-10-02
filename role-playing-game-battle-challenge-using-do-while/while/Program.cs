// See https://aka.ms/new-console-template for more information
Random random = new Random();

int heroHealth = 10;
int monsterHealth = 10;


while (heroHealth > 0 && monsterHealth > 0){
    int heroAttack = random.Next(1, 10);
    monsterHealth -= heroAttack;
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
    
    if(monsterHealth <= 0) break;

    int monsterAttack = random.Next(1, 10);
    heroHealth -= monsterAttack;
    Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");

    if(heroHealth <= 0) break;
}

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins" : "Monster Wins");

// Console.WriteLine($"hero - {heroHealth}");
// Console.WriteLine($"monster - {monsterHealth}");