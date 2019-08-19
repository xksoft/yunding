using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 云顶阵形碰撞器
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroes_1 = new List<Hero>
            {
                new Hero {Name = "虚空行者", Races = {Race.虚空}, Professions = {Profession.法师}, Price = 1},
                new Hero {Name = "九尾妖狐", Races = {Race.狂野}, Professions = {Profession.法师}, Price = 2},
                new Hero {Name = "仙灵女巫", Races = {Race.约德尔人}, Professions = {Profession.法师}, Price = 2},
                new Hero {Name = "卡牌大师", Races = {Race.海盗}, Professions = {Profession.法师}, Price = 2},
                new Hero {Name = "堕落天使", Races = {Race.恶魔}, Professions = {Profession.法师}, Price = 3},
                new Hero {Name = "邪恶小法师", Races = {Race.约德尔人}, Professions = {Profession.法师}, Price = 3},
                new Hero {Name = "铸星龙王", Races = {Race.龙}, Professions = {Profession.法师}, Price = 4},
                new Hero {Name = "死亡颂唱者", Races = {Race.暗影}, Professions = {Profession.法师}, Price = 5},
                new Hero {Name = "虚空掠夺者", Races = {Race.虚空}, Professions = {Profession.刺客}, Price = 1},
                new Hero {Name = "血港魅影", Races = {Race.海盗}, Professions = {Profession.刺客}, Price = 2},
                new Hero {Name = "影流之主", Races = {Race.忍者}, Professions = {Profession.刺客}, Price = 2},
                new Hero {Name = "不祥之刃", Races = {Race.帝国}, Professions = {Profession.刺客}, Price = 3},
                new Hero {Name = "痛苦之拥", Races = {Race.恶魔}, Professions = {Profession.刺客}, Price = 3},
                new Hero {Name = "傲之追猎者", Races = {Race.狂野}, Professions = {Profession.刺客}, Price = 3},
                new Hero {Name = "离群之刺", Races = {Race.忍者}, Professions = {Profession.刺客}, Price = 4},
                new Hero {Name = "无双剑姬", Races = {Race.贵族}, Professions = {Profession.剑士}, Price = 1},
                // new Hero {Name = "卡蜜尔",  Races ={Race.海克斯}, Professions = {Profession.剑士}, Price = 1},
                new Hero {Name = "暮光之眼", Races = {Race.忍者}, Professions = {Profession.剑士}, Price = 2},
                new Hero {Name = "暗裔剑魔", Races = {Race.恶魔}, Professions = {Profession.剑士}, Price = 3},
                new Hero {Name = "海洋之灾", Races = {Race.海盗}, Professions = {Profession.剑士}, Price = 3},
                new Hero {Name = "荣耀行刑官", Races = {Race.帝国}, Professions = {Profession.剑士}, Price = 4},
                new Hero {Name = "疾风剑豪", Races = {Race.浪人}, Professions = {Profession.剑士}, Price = 5},
                new Hero {Name = "祖安怒兽", Races = {Race.狂野}, Professions = {Profession.斗士}, Price = 1},
                new Hero {Name = "蒸汽机器人", Races = {Race.机器人}, Professions = {Profession.斗士}, Price = 2},
                new Hero {Name = "虚空遁地兽", Races = {Race.虚空}, Professions = {Profession.斗士}, Price = 2},
                new Hero {Name = "雷霆咆哮", Races = {Race.极地}, Professions = {Profession.斗士}, Price = 3},
                // new Hero {Name = "蔚",  Races ={Race.海克斯}, Professions = {Profession.斗士}, Price = 3},
                new Hero {Name = "虚空恐惧", Races = {Race.虚空}, Professions = {Profession.斗士}, Price = 4},
                new Hero {Name = "冰霜女巫", Races = {Race.极地}, Professions = {Profession.元素使}, Price = 2},
                new Hero {Name = "狂暴之心", Races = {Race.约德尔人, Race.忍者}, Professions = {Profession.元素使}, Price = 3},
                new Hero {Name = "复仇焰魂", Races = {Race.恶魔}, Professions = {Profession.元素使}, Price = 4},
                new Hero {Name = "冰晶凤凰", Races = {Race.极地}, Professions = {Profession.元素使}, Price = 5},
                new Hero {Name = "弗雷尔卓德之心", Races = {Race.极地}, Professions = {Profession.护卫}, Price = 2},
                new Hero {Name = "曙光女神", Races = {Race.贵族}, Professions = {Profession.护卫}, Price = 4},
                //new Hero {Name = "潘森", Races = {Race.龙}, Professions = {Profession.护卫}, Price = 5},
                new Hero {Name = "法外狂徒", Races = {Race.海盗}, Professions = {Profession.枪手}, Price = 1},
                new Hero {Name = "麦林炮手", Races = {Race.约德尔人}, Professions = {Profession.枪手}, Price = 1},
                new Hero {Name = "圣枪游侠", Races = {Race.贵族}, Professions = {Profession.枪手}, Price = 2},
                new Hero {Name = "海洋之灾", Races = {Race.海盗}, Professions = {Profession.枪手, Profession.剑士}, Price = 3},
                // new Hero {Name = "金克丝", Races = {Race.海克斯}, Professions = {Profession.枪手}, Price = 4},
                new Hero {Name = "赏金猎人", Races = {Race.海盗}, Professions = {Profession.枪手}, Price = 5},
                new Hero {Name = "诺克萨斯之手", Races = {Race.帝国}, Professions = {Profession.骑士}, Price = 1},
                new Hero {Name = "德玛西亚之力", Races = {Race.贵族}, Professions = {Profession.骑士}, Price = 1},
                new Hero {Name = "铁铠冥魂", Races = {Race.暗影}, Professions = {Profession.骑士}, Price = 1},
                new Hero {Name = "圣锤之毅", Races = {Race.约德尔人}, Professions = {Profession.骑士}, Price = 3},
                new Hero {Name = "北地之怒", Races = {Race.极地}, Professions = {Profession.骑士}, Price = 4},
                new Hero {Name = "正义天使", Races = {Race.贵族}, Professions = {Profession.骑士}, Price = 5},
                new Hero {Name = "暗影猎手", Races = {Race.贵族}, Professions = {Profession.游侠}, Price = 1},
                new Hero {Name = "惩戒之箭", Races = {Race.恶魔}, Professions = {Profession.游侠}, Price = 2},
                new Hero {Name = "寒冰射手", Races = {Race.极地}, Professions = {Profession.游侠}, Price = 3},
                new Hero {Name = "永猎双子", Races = {Race.暗影}, Professions = {Profession.游侠}, Price = 4},
                new Hero {Name = "蜘蛛女皇", Races = {Race.恶魔}, Professions = {Profession.换形师}, Price = 1},
                new Hero {Name = "狂野女猎手", Races = {Race.狂野}, Professions = {Profession.换形师}, Price = 1},
                //  new Hero {Name = "杰斯", Races = {Race.海克斯}, Professions = {Profession.换形师}, Price = 2},
                new Hero {Name = "龙血武姬", Races = {Race.龙}, Professions = {Profession.换形师}, Price = 3},
                new Hero {Name = "迷失之牙", Races = {Race.狂野, Race.约德尔人}, Professions = {Profession.换形师}, Price = 4},
                new Hero {Name = "诺克萨斯统领", Races = {Race.恶魔, Race.帝国}, Professions = {Profession.换形师}, Price = 5},
            };
            var top = 0;
            var count = 0;
            while (true)
            {
                var heroes = new List<Hero>(heroes_1);
                var random = new Random();
                var num = 8; //阵容人数
                var list = new List<Hero>();
                for (var i = 0; i < num; i++)
                {
                    var hero = heroes[random.Next(0, heroes.Count)];
                    heroes.Remove(hero);
                    list.Add(hero);
                }


                var raceData = new List<Race>();
                var professionsData = new List<Profession>();
                foreach (var hero in list)
                {
                    raceData.AddRange(hero.Races);
                    professionsData.AddRange(hero.Professions);
                }

                var raceGroup = raceData.GroupBy(a => a).ToList();
                var professionsGroup = professionsData.GroupBy(a => a).ToList();
                var rank = ParseNum(ref raceGroup,ref professionsGroup);


                count++;

                if (rank > top)
                {
                    top = rank;
                    ;
                    Console.Title = "最高分数:" + top + " 累计尝试次数:" + count;

                    Console.WriteLine("\r\n\r\n=====================\r\n分数:" + top + "\r\n==============\r\n");
                    Console.WriteLine("阵形：\r\n");
                    foreach (var hero in list)
                    {
                        Console.WriteLine(hero.Name+" "+hero.Price+"金币");
                    }

                    Console.WriteLine("\r\n种族羁绊：\r\n");
                    foreach (var race in raceGroup)
                    {
                        Console.WriteLine(race.Key + ":" + race.Count());
                    }

                    Console.WriteLine("\r\n职业羁绊：\r\n");
                    foreach (var professions in professionsGroup)
                    {
                        Console.WriteLine(professions.Key + ":" + professions.Count());
                    }
                }

                if (count % 10000 == 0)
                {
                    Console.Title = "最高分数:" + top + " 累计尝试次数:" + count;
                }
            }


            Console.ReadKey();
        }

        static int ParseNum(ref List<IGrouping<Race, Race>> races,
            ref List<IGrouping<Profession, Profession>> professions)
        {
            int count = 0;
            var traces1 = races.ToList();
            var professions1 = professions.ToList();
            foreach (var race in traces1)
            {
                switch (race.Key)
                {
                    case Race.恶魔:
                        if (race.Count() >= 6)
                            count += 6;
                        else if (race.Count() >= 4)
                            count += 4;
                        else if (race.Count() >= 2)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.龙:
                        if (race.Count() >= 2)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.浪人:
                        if (race.Any())
                            count += 1;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.极地:
                        if (race.Count() >= 6)
                            count += 6;
                        else if (race.Count() >= 4)
                            count += 4;
                        else if (race.Count() >= 2)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.帝国:
                        if (race.Count() >= 4)
                            count += 4;
                        else if (race.Count() >= 2)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.忍者:

                        if (race.Count() == 4)
                            count += 4;
                        else if (race.Count() == 1)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.贵族:
                        if (race.Count() >= 6)
                            count += 6;
                        else if (race.Count() >= 3)
                            count += 3;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.暗影:
                        if (race.Count() >= 2)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.海盗:
                        if (race.Count() >= 3)
                            count += 3;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.机器人:
                        if (race.Any())
                            count += 1;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.虚空:
                        if (race.Count() >= 3)
                            count += 3;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.狂野:
                        if (race.Count() >= 4)
                            count += 4;
                        else if (race.Count() >= 2)
                            count += 2;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.约德尔人:
                        if (race.Count() >= 6)
                            count += 6;
                        else if (race.Count() >= 3)
                            count += 3;
                        else
                        {
                            races.Remove(race);
                        }

                        break;
                    case Race.海克斯:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            foreach (var profession in professions1)
            {
                switch (profession.Key)
                {
                    case Profession.法师:
                        if (profession.Count() >= 6)
                            count += 6;
                        else if (profession.Count() >= 3)
                            count += 3;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.刺客:
                        if (profession.Count() >= 6)
                            count += 6;
                        else if (profession.Count() >= 3)
                            count += 3;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.剑士:
                        if (profession.Count() >= 6)
                            count += 6;
                        else if (profession.Count() >= 3)
                            count += 3;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.斗士:
                        break;
                    case Profession.元素使:
                        if (profession.Count() >= 3)
                            count += 3;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.护卫:
                        if (profession.Count() >= 2)
                            count += 2;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.枪手:

                        if (profession.Count() >= 4)
                            count += 4;
                        else if (profession.Count() >= 2)
                            count += 2;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.骑士:
                        if (profession.Count() >= 6)
                            count += 6;
                        else if (profession.Count() >= 4)
                            count += 4;
                        else if (profession.Count() >= 2)
                            count += 2;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.游侠:

                        if (profession.Count() >= 4)
                            count += 4;
                        else if (profession.Count() >= 2)
                            count += 2;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    case Profession.换形师:
                        if (profession.Count() >= 3)
                            count += 3;
                        else
                        {
                            professions.Remove(profession);
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }


            return count;
        }
    }

    class Hero
    {
        public string Name;
        public List<Race> Races = new List<Race>();
        public List<Profession> Professions = new List<Profession>();
        public int Price;
    }

    enum Race
    {
        恶魔,
        龙,
        浪人,
        极地,
        帝国,
        忍者,
        贵族,
        暗影,
        海盗,
        机器人,
        虚空,
        狂野,
        约德尔人,
        海克斯
    }

    enum Profession
    {
        法师,
        刺客,
        剑士,
        斗士,
        元素使,
        护卫,
        枪手,
        骑士,
        游侠,
        换形师
    }
}