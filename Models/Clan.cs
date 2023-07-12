using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VtM_5e_Storyteller_Companion.Models
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bane { get; set; }
        public string Compulsion { get; set; }
    }

    public class ClanConfiguration
    {
        /* Seed the clan table with the clan data out of the
         * VtM 5th Edition core rulebook.
         */
        public void Configure()
        {
            var HasData =
            (
                new Clan
                {
                    Id = 1,
                    Name = "Brujah",
                    Description = "The rabble rebel against power and rage against tyranny.",
                    Bane = "The Blood of the Brujah simmers\r\nwith barely contained rage, exploding\r\nat the slightest provocation.\r\nSubtract dice equal to the Bane Severity\r\nof the Brujah from any roll\r\nto resist fury frenzy. This cannot\r\ntake the pool below one die.",
                    Compulsion = "Rebellion: The vampire takes a stand against\r\nwhatever or whomever they see\r\nas the status quo in the situation,\r\nwhether that’s their leader, a\r\nviewpoint expressed by a potential\r\nvessel, or just the task they were\r\nsupposed to do at the moment.\r\nUntil they’ve gone against their\r\norders or expectations, perceived\r\nor real, the vampire receives a twodice\r\npenalty to all rolls. This Compulsion\r\nends once they’ve managed\r\nto either make someone change\r\ntheir minds (by force if necessary)\r\nor done the opposite of what was\r\nexpected of them."
                },
                new Clan
                {
                    Id = 2,
                    Name = "Gangrel",
                    Description = "The feral outlanders blend Vampire and Beast.",
                    Bane = "Gangrel relate to their Beast much\r\nas other Kindred relate to the\r\nGangrel: suspicious partnership. In\r\nfrenzy, Gangrel gain one or more\r\nanimal features: a physical trait,\r\na smell, or a behavioral tic. These\r\nfeatures last for one more night\r\nafterward, lingering like a hangover\r\nfollowing debauchery. Each\r\nfeature reduces one Attribute by 1\r\npoint – the Storyteller may decide\r\nthat a forked tongue or bearlike\r\nmusk reduces Charisma, while\r\nbatlike ears reduce Resolve (“all\r\nthose distracting sounds”). If nothing\r\nimmediately occurs to you,\r\nthe feature reduces Intelligence or\r\nManipulation.\r\nThe number of features a\r\nGangrel manifests equals their\r\nBane Severity. If your character\r\nRides the Wave of their frenzy\r\n(see p. 219) you can choose only\r\none feature to manifest, thus\r\ntaking only one penalty to their\r\nAttributes.",
                    Compulsion = "Feral Impulses: Returning to an animalistic state,\r\nthe vampire regresses to a point\r\nwhere speech is hard, clothes are\r\nuncomfortable, and arguments are\r\nbest settled with teeth and claws.\r\nFor one scene, the vampire\r\ngains a three-dice penalty to all\r\nrolls involving Manipulation and\r\nIntelligence. They can only speak\r\nin one-word sentences during this\r\ntime."
                },
                new Clan
                {
                    Id = 3,
                    Name = "Malkavian",
                    Description = "The madness of the lunatics conceals and reveals truths.",
                    Bane = "Afflicted by their lineage, all\r\nMalkavians are cursed with at least\r\none type of mental derangement.\r\nDepending on their history and the\r\nstate of their mind at death, they\r\nmay experience delusions, visions\r\nof terrible clarity, or something\r\nentirely different.\r\nWhen the Malkavian suffers a\r\nBestial Failure or a Compulsion,\r\ntheir curse comes to the fore. Suffer\r\na penalty equal to your character’s\r\nBane Severity to one category\r\nof dice pools (Physical, Social, or\r\nMental) for the entire scene. This\r\nis in addition to any penalties\r\nincurred by Compulsions.\r\nYou and the Storyteller decide\r\nthe type of penalty and the exact\r\nnature of the character’s affliction\r\nduring character creation",
                    Compulsion = "Delusion: Their extrasensory gifts running\r\nwild, the vampire experiences what\r\nmight be truths or portents, but\r\nwhat others call figments of imagination,\r\ndredged up by Hunger.\r\nWhile still functional, the\r\nvampire’s mind and perceptions\r\nare skewed. They receive a two-dice\r\npenalty to rolls involving Dexterity,\r\nManipulation, Composure, and\r\nWits as well as on rolls to resist\r\nterror frenzy, for one scene."
                },
                new Clan
                {
                    Id = 4,
                    Name = "Nosferatu",
                    Description = "The hideous Sewer Rats hide their disfigured forms in the darkness, from whence they gather secrets.",
                    Bane = "Hideous and vile, all Nosferatu\r\ncount as having the Repulsive\r\nFlaw (-2) and can never increase\r\ntheir rating in the Looks Merit. In\r\naddition, any attempt to disguise\r\nthemselves as human incur a\r\npenalty to your dice pool equal\r\nto your character’s Bane Severity\r\n(this includes the Obfuscate powers\r\nMask of a Thousand Faces and\r\nImpostor’s Guise)",
                    Compulsion = "Cryptophilia: The need to know permeates the\r\nvampire. They become consumed\r\nwith a hunger for secrets, to know\r\nthat which few or no one knows,\r\nalmost as strong as that for blood.\r\nThey also refuse to share secrets\r\nwith others, except in strict trade\r\nfor greater ones.\r\nAll actions not spent working\r\ntoward learning a secret, no matter\r\nhow big or small, receive a twodice\r\npenalty. The Compulsion ends\r\nwhen the vampire learns a secret\r\nbig enough to be considered useful.\r\nSharing this secret is optional."
                },
                new Clan
                {
                    Id = 5,
                    Name = "Toreador",
                    Description = "The Degenerates seek thrills of art, romance, and cruelty amidst stagnant undeath.",
                    Bane = "Toreador exemplify the old saying\r\nthat art in the blood takes\r\nstrange forms. They desire beauty\r\nso intensely that they suffer in\r\nits absence. While your character\r\nfinds itself in less than beautiful\r\nsurroundings, lose the equivalent\r\nof their Bane Severity in dic e\r\nfrom dice pools to use Disciplines.\r\nThe Storyteller decides\r\nspecifically how the beauty or ugliness\r\nof the Toreador’s environment\r\n(including clothing, blood\r\ndolls, etc.) penalizes them, based\r\non the character’s aesthetics.\r\nThat said, even devotees of the\r\nAshcan School never find normal\r\nstreets perfectly beautiful. This\r\nobsession with aesthetics also\r\ncauses divas to lose themselves in\r\nmoments of beauty and a bestial\r\nfailure often results in a rapt\r\ntrance, as detailed in the Compulsion\r\nrules (p. 208)",
                    Compulsion = "Obsession: Enraptured by beauty, the vampire\r\nbecomes temporarily obsessed with\r\na singular gorgeous thing, able to\r\nthink of nothing else.\r\nPick one feature, such as a\r\nperson, a song, an artwork, blood\r\nspatter, or even a sunrise. Enraptured,\r\nthe vampire can hardly take\r\ntheir attention from it, and if spoken\r\nto, they only talk about that\r\nsubject. Any other actions receive\r\na two-dice penalty. This Compulsion\r\nlasts until they can no longer\r\nperceive the beloved object, or the\r\nscene ends."
                },
                new Clan
                {
                    Id = 6,
                    Name = "Tremere",
                    Description = "Broken by a new inquisition, the once-mighty Warlocks seek to restore their monopoly on sorcerous power.",
                    Bane = "Once the clan was defined by a rigid hierarchy of\r\nBlood Bonds reaching from the top to the bottom\r\nof the Pyramid. But after the fall of Vienna, their\r\nBlood has recoiled and aborted all such connections.\r\nTremere vitae can no longer Blood Bond other\r\nKindred, though they themselves can be Bound by\r\nKindred from other clans. A Tremere can still bind\r\nmortals and ghouls, though the corrupted vitae must\r\nbe drunk an additional number of times equal to\r\nthe vampire’s Bane Severity for the bond to form.\r\nSome theorize this change is the revenge of the\r\nAntediluvian devoured by Tremere, others attribute\r\nit to a simple mutation. Regardless, the clan studies\r\ntheir vitae intently to discover if the process can be\r\nreversed, and, indeed, determine if they would want\r\nto do so",
                    Compulsion = "Perfectionism: Nothing but the best satisfies\r\nthe vampire. Anything less than\r\nexceptional performance instills a\r\nprofound sense of failure, and they\r\noften repeat tasks obsessively to get\r\nthem “just right.”\r\nUntil the vampire scores a critical\r\nwin on a Skill roll or the scene\r\nends, the vampire labors under a\r\ntwo-dice penalty to all dice pools.\r\nReduce the penalty to one die for\r\na repeated action, and remove it\r\nentirely on a second repeat."
                },
                new Clan
                {
                    Id = 7,
                    Name = "Ventrue",
                    Description = "The aristocratic Blue Bloods enforce the Traditions and the Masquerade on the lesser breeds.",
                    Bane = "The Ventrue are in possession of rarefied palates. When\r\na Ventrue drinks blood from any mortal outside their\r\npreference, a profound exertion of will is required or\r\nthe blood taken surges back up as scarlet vomit. Preferences\r\nrange greatly, from Ventrue who can only feed\r\nfrom genuine brunettes, individuals of Swiss descent,\r\nor homosexuals, to others who can only feed from\r\nsoldiers, mortals who suffer from PTSD, or methamphetamine\r\nusers. With a Resolve + Awareness test (Difficulty\r\n4 or more) your character can sense if a mortal\r\npossesses the blood they require.\r\nIf you want your character to feed from anything\r\nbut their preferred victim, you must spend Willpower\r\npoints equal to the character’s Bane Severity ■",
                    Compulsion = "Arrogance: The need to rule rears its head in the vampire. They\r\nstop at nothing to assume command of a situation.\r\nSomeone must obey an order from the vampire.\r\nAny action not directly associated with leadership\r\nreceives a two-dice penalty. This Compulsion lasts\r\nuntil an order has been obeyed, though the order\r\nmust not be supernaturally enforced, such as through\r\nDominate."
                },
                new Clan
                {
                    Id = 8,
                    Name = "Caitiff",
                    Description = "The clanless show no common traits, except to find themselves outcast by Vampires of distinct lineage.",
                    Bane = "Untouched by the Antediluvians,\r\nthe Caitiff share no common bane.\r\nCaitiff characters begin with the\r\nSuspect (•) Flaw and you may not\r\npurchase positive Status for them\r\nduring character creation. The Storyteller\r\nmay always impose a one\r\nor two dice penalty on Social tests\r\nagainst fellow Kindred who know\r\nthey are Caitiff, regardless of their\r\neventual Status.\r\nFurther, to improve one of the\r\nDisciplines of a Caitiff costs six\r\ntimes the level purchased in experience\r\npoints ■",
                    Compulsion = "The caitiff are clanless and never suffers any specific clan compulsion."
                },
                new Clan
                {
                    Id = 9,
                    Name = "Thin-Blooded",
                    Description = "Born too far from Caine to fully share his curse, the Mercurian thin-bloods must claw their way into a dark world - or find a way out.",
                    Bane = "A thin blood is always considered clanless and never suffers any specific clan bane or compulsion.",
                    Compulsion = "A thin blood is always considered clanless and never suffers any specific clan bane or compulsion."
                }
            );
        }
    }
}
