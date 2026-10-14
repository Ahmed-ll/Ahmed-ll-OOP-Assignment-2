using System.Diagnostics;
using PatternsLab.Problems.Builder;
using PatternsLab.Problems.Prototype;
using PatternsLab.Problems.Singleton;

Console.WriteLine("=== SINGLETON: BEFORE ===\n");

//var db = new DatabaseService();
//var ui = new UiService();

//Console.WriteLine();

//db.Config.Theme = "Dark";
//Console.WriteLine("Admin changed theme to Dark.");

//ui.Render();

//Console.WriteLine($"Same config object? {ReferenceEquals(db.Config, ui.Config)}");
//Console.WriteLine($"Times config was loaded from disk: {AppConfig.LoadCount}");

Console.WriteLine("=== SINGLETON: AFTER ===\n");

var db = new DatabaseService();
var ui = new UiService();

db.Config.Theme = "Dark";
ui.Render();                                                  
Console.WriteLine(ReferenceEquals(db.Config, ui.Config));     
Console.WriteLine(AppConfig.LoadCount);

//Console.WriteLine("\n=== PROTOTYPE: BEFORE ===\n");

//var sw = Stopwatch.StartNew();
//var army = new List<Enemy>();
//for (int i = 1; i <= 5; i++)
//{
//    var orc = new Orc();
//    orc.Name = $"Orc-{i}";
//    army.Add(orc);
//}
//Console.WriteLine($"Created 5 orcs in {sw.ElapsedMilliseconds} ms\n");

//Enemy original = new Orc();
//original.Name = "Boss Orc";
//Enemy copy = EnemyCopyHelper.CopyEnemy(original);

//Console.WriteLine($"\nOriginal model id: {original.ModelId}");
//Console.WriteLine($"Copy model id:     {copy.ModelId}");

//copy.Weapon.Damage = 999;
//Console.WriteLine($"\nWe changed the COPY's weapon damage to 999.");
//Console.WriteLine($"Original's weapon damage is now: {original.Weapon.Damage}");

//copy.Abilities.Add("Fire Breath");
//Console.WriteLine($"Original abilities: {string.Join(", ", original.Abilities)}");


Console.WriteLine("=== PROTOTYPE: AFTER ===\n");

Console.WriteLine("Creating prototypes (slow, only once each):");
Enemy orcProto = new Orc();
Enemy elfProto = new Elf();

var registry = new EnemyRegistry();
registry.Register("orc", orcProto);
registry.Register("elf", elfProto);

Console.WriteLine("\nCloning (should be instant):");
var sw = System.Diagnostics.Stopwatch.StartNew();
Enemy orc1 = registry.Create("orc");
Enemy orc2 = orcProto.Clone();
Enemy elf1 = registry.Create("elf");
sw.Stop();
Console.WriteLine($"3 clones took {sw.ElapsedMilliseconds} ms");

Console.WriteLine($"\nSame ModelId? {orc1.ModelId == orcProto.ModelId}");  

orc1.Weapon.Damage = 999;
orc1.Abilities.Add("Fire");
orc1.Health = 1;

Console.WriteLine($"Original weapon damage: {orcProto.Weapon.Damage}");     
Console.WriteLine($"Original abilities: {string.Join(",", orcProto.Abilities)}"); 
Console.WriteLine($"Original health: {orcProto.Health}");                  
Console.WriteLine($"Clone is Orc? {orc1 is Orc}\nsame reference? {ReferenceEquals(orc1, orcProto)}");

//Console.WriteLine("\n=== BUILDER: BEFORE ===\n");
//Console.WriteLine(RegistrationCallSites.CreateLiveStudentUgly());
//Console.WriteLine(RegistrationCallSites.CreateVideosOnlyUgly());

Console.WriteLine("=== BUILDER: AFTER ===\n");

Console.WriteLine(RegistrationCallSites.CreateLiveStudent());
Console.WriteLine(RegistrationCallSites.CreateVideosOnly());