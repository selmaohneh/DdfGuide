﻿using System.Collections.Generic;
using DdfGuide.Core;
using Newtonsoft.Json;

namespace DdfGuide.Android
{
    public class AndroidDtoProvider : IProvider<IEnumerable<AudioDramaDto>>
    {
        public IEnumerable<AudioDramaDto> Get()
        {
            var dtos = JsonConvert.DeserializeObject<IEnumerable<AudioDramaDto>>(json);
            return dtos;
        }

        private string json = @"[
  {
    ""Id"": ""ea043c87-a90f-4bf7-963f-b747c9795147"",
    ""Title"": ""... und der Super-Papagei"",
    ""NumberEuropa"": 1,
    ""ReleaseDate"": ""1979-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/001.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der neueste Auftrag an die drei Detektive hört sich recht harmlos an: sie sollen einen entflogenen Papagei suchen. Doch kaum beginnen sie mit ihren Nachforschungen, da scheinen sich plötzlich noch einige andere Leute sehr für diesen Papagei zu interessieren. Vielleicht deshalb, weil er lateinische Sprüche zitieren kann? Aber bald geht es nicht mehr nur um einen, sondern um sieben Papageien - und alle sieben führen höchst seltsame Reden. Ob da nicht eine geheime Botschaft hintersteckt? Jedenfalls sind auch ein jähzorniger Kunsthändler und ein berüchtigter Meisterdieb hinter den Vögeln her. Die drei ??? müssen sich ganz schön die hellen Köpfe zerbrechen, ehe sie auch diesen abenteuerlichen Fall aufklären und eine wohlverdiente Belohnung einheimsen..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Fentriss, Schriftsteller"",
        ""Speaker"": ""Richard Lauffen""
      },
      {
        ""Character"": ""Mr. Claudius, Kunsthändler"",
        ""Speaker"": ""Gerlach Fiedler""
      },
      {
        ""Character"": ""Mrs. Claudius"",
        ""Speaker"": ""Ingrid Andree""
      },
      {
        ""Character"": ""Miss Waggoner"",
        ""Speaker"": ""Katharina Brauren""
      },
      {
        ""Character"": ""Carlos"",
        ""Speaker"": ""Stefan Brönneke""
      },
      {
        ""Character"": ""Onkel Ramos"",
        ""Speaker"": ""Juan Perez [Karl-Ulrich Meves]""
      },
      {
        ""Character"": ""Hugenay"",
        ""Speaker"": ""Albert Giro [Wolfgang Kubach]""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      }
    ]
  },
  {
    ""Id"": ""3599e31b-b73c-4452-b5d3-0ddbc7c9743a"",
    ""Title"": ""... und der Phantomsee"",
    ""NumberEuropa"": 2,
    ""ReleaseDate"": ""1979-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/002.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Welches Geheimnis verbirgt sich in einem vergilbten Brief und in den nach langer Zeit wieder aufgetauchten Aufzeichnungen des Seemanns Angus Gunn? Wurde tatsächlich in einer lange vergangenen Sturmnacht ein Piratenschatz von einem sinkenden Schiff gestohlen? Das möchten die drei Detektive Justus, Bob und Peter ebenfalls gerne wissen. Den Nachkommen von Gunn ist es bisher nicht gelungen, das Versteck des Schatzes ausfindig zu machen. Professor Shy, den diese Sache für seine Arbeit am Historischen Forschungsinstitut interessiert, hatte bisher auch kein Glück. Immer mehr Personen tauchen auf und machen sich verdächtig. Auch Java-Jim, ein undurchsichtiger Seemann, versucht den drei ??? zuvorzukommen. Und welche Rolle spielt Stebins, der wegen Unterschlagung im Gefängnis war und auf Bewährung frei ist? Der Professor vermutet, daß er und Java-Jim zusammenarbeiten. Aber am Ende sind die drei ??? allen eine Nasenlänge voraus: die rätselhaften Hinweise führen sie zum Phantomsee und damit endlich zur Lösung."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Patrick Kenneth"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Java-Jim"",
        ""Speaker"": ""Heinz Überreiter [Gottfried Kramer]""
      },
      {
        ""Character"": ""Mrs. Flora Gunn"",
        ""Speaker"": ""Veronika Weckler""
      },
      {
        ""Character"": ""Cluny Gunn"",
        ""Speaker"": ""Fabian Harloff""
      },
      {
        ""Character"": ""Rory"",
        ""Speaker"": ""Klaus-Peter Reisch [Peter Buchholz]""
      },
      {
        ""Character"": ""Stebins"",
        ""Speaker"": ""Hans Meinhardt [Karl-Ulrich Meves]""
      },
      {
        ""Character"": ""Mr. Widner"",
        ""Speaker"": ""Ernst von Klipstein""
      },
      {
        ""Character"": ""Verwalter von Powder Gulch"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Bibliothekarin"",
        ""Speaker"": ""Katharina Brauren""
      }
    ]
  },
  {
    ""Id"": ""770c6c19-7df3-4ae9-bd1a-16aaa143453a"",
    ""Title"": ""... und der Karpatenhund"",
    ""NumberEuropa"": 3,
    ""ReleaseDate"": ""1979-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/003.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""\""Bei mir spukt es!\"" Mit diesem verzweifelten Ausruf von Mr. Prentice beginnt ein neues Abenteuer der drei ???. Ein Abenteuer, das immer verwickelter wird und bei dem sogar der sonst so superschlaue Erste Detektiv, Justus Jonas, eine Zeitlang völlig im Dunkeln tappt. - Welche unheimliche Gestalt geht in der Wohnung von Mr. Prentice ein und aus und versetzt diesen in immer größere Ängste und Schrecken? Was ist die Quelle jener gespenstischen Lichtblitze in seinem Arbeitszimmer, sechs Meter über der Straße? Wer hat die wertvolle gläserne Skulptur des Karpatenhundes verschwinden lassen, und wer versucht, allen Mietern den Aufenthalt in dem großen Appartementhaus unmöglich zu machen? Die wenigen Spuren weisen in verschiedene Richtungen, und für unser Detektivtrio gilt es wieder einmal, eine harte Nuß zu knacken. Werden sie Licht in das Dunkel bringen?..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Prentice"",
        ""Speaker"": ""Hans Hessling""
      },
      {
        ""Character"": ""Niedland"",
        ""Speaker"": ""Gerlach Fiedler""
      },
      {
        ""Character"": ""Pfarrer"",
        ""Speaker"": ""Ernst von Klipstein""
      },
      {
        ""Character"": ""Mrs. Boogle"",
        ""Speaker"": ""Katharina Brauren""
      },
      {
        ""Character"": ""Sonny Elmquist"",
        ""Speaker"": ""Philip Kunzmann [Gernot Endemann]""
      },
      {
        ""Character"": ""Mr. Murphy"",
        ""Speaker"": ""Karl-Ulrich Meves""
      },
      {
        ""Character"": ""Miss Chalmers"",
        ""Speaker"": ""Pamela Punti [Heikedine Körting?]""
      },
      {
        ""Character"": ""Mr. Hassel"",
        ""Speaker"": ""Rolf Hundertwasser [Wolfgang Kubach?]""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Rolf Mamero""
      }
    ]
  },
  {
    ""Id"": ""ceca04fd-5d6c-4b3a-94ee-5d6c04034221"",
    ""Title"": ""... und die schwarze Katze"",
    ""NumberEuropa"": 4,
    ""ReleaseDate"": ""1979-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/004.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""In einem kleinen Wanderzirkus wittern die drei jungen Detektive Peter, Bob und Justus ihren neuesten Fall. Denn wenn ein finster aussehender Mann mit Gewalt eine häßliche schwarze Stoffkatze - den Hauptgewinn einer Schießbude - an sich bringen will, sie schließlich stiehlt und am nächsten Tag per Zeitungsanzeige nach weiteren Stoffkatzen fahndet, dann muß irgend etwas dahinter stecken. Außerdem: Wieso trifft den Wanderzirkus seit Wochen ein Unglücksfall nach dem anderen? Und wer ist der Unbekannte mit der auffallenden Tätowierung, der immer wieder im Zirkus auftaucht, aber in brenzligen Momenten spurlos verschwindet? Justus und seine Freunde setzen sich ihm und der gestohlenen Katze auf die Spur und lassen sich beinah auf eine falsche Fährte jagen. Nach aufregenden Fehlschlägen gelingt es ihnen aber schließlich doch, das Geheimnis der schwarzen Katze zu lüften und in letzter Minute einem raffinierten Verbrecher die Maske vom Gesicht zu reißen - im wahrsten Sinne des Wortes..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Andy Carson"",
        ""Speaker"": ""Stefan Schwade""
      },
      {
        ""Character"": ""Mr. Carson"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Khan, der Kraftmensch"",
        ""Speaker"": ""René Genesis""
      },
      {
        ""Character"": ""Einzigartiger Gabbo"",
        ""Speaker"": ""Iwan Raszinsky [Karl-Ulrich Meves]""
      },
      {
        ""Character"": ""Iwan"",
        ""Speaker"": ""Boris Stepin [Wolfgang Kubach]""
      },
      {
        ""Character"": ""Junge"",
        ""Speaker"": ""Philip Baader""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Der alte Mann"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Wachmann"",
        ""Speaker"": ""Peter Buchholz""
      },
      {
        ""Character"": ""Jungen"",
        ""Speaker"": ""Stefan Brönneke, Alexander Körting""
      },
      {
        ""Character"": ""Jahrmarktfrau"",
        ""Speaker"": ""Heikedine Körting""
      },
      {
        ""Character"": ""Funksprecher"",
        ""Speaker"": ""Gernot Endemann""
      }
    ]
  },
  {
    ""Id"": ""0b316bc5-7c26-45e8-8838-f0bee4277d41"",
    ""Title"": ""... und der Fluch des Rubins"",
    ""NumberEuropa"": 5,
    ""ReleaseDate"": ""1979-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/005.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Alfred Hitchcock und die drei Detektive (Firmenzeichen ???) haben es hier mit einem seltsamen Vermächtnis zu tun: Onkel Horatio hat seinem Neffen etwas Wertvolles hinter lassen - aber was? Und vor allem wo? Die jungen Kriminalisten Justus, Peter und Bob sehen sich hier mit viel zu vielen Gipsköpfen, geheimnisvollen Herren und dem Wort August in mindestens fünf Bedeutungen konfrontiert. Werden Justus und seine Freunde mit diesem Fall nicht überfordert?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""August August, genannt Gus"",
        ""Speaker"": ""Stephan Chrzescinski""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Mr. Dwiggins"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""Mr. Rhandur"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Joe"",
        ""Speaker"": ""Peter Buchholz""
      },
      {
        ""Character"": ""Lisa"",
        ""Speaker"": ""Madeleine Stolze""
      },
      {
        ""Character"": ""Mutter"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Patrick Kenneth"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Bauarbeiter"",
        ""Speaker"": ""Gernot Endemann""
      }
    ]
  },
  {
    ""Id"": ""45c7e3cf-d2a1-4c48-8891-61c5fa3cfff5"",
    ""Title"": ""... und der sprechende Totenkopf"",
    ""NumberEuropa"": 6,
    ""ReleaseDate"": ""1979-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/006.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bob und Peter halten von Anfang an nicht viel davon, daß ihr Freund Justus auf einer Versteigerung ausgerechnet einen uralten Koffer mit unbekanntem Inhalt ersteigern will. Hätten sie geahnt, welch gefährliche Verwicklungen sich aus dem Besitz des Koffers ergeben würden - sie hätten noch weit heftiger protestiert! Nicht genug damit, daß er neben den Kleidern und Utensilien eines Zauberkünstler einen Totenkopf enthält: der merkwürdige Schädel kann auch noch sprechen! Ziemlicher Schock für die drei Detektive, die keinesfalls an Spuk glauben. Und kaum beginnen sie, dieses Geheimnis zu ergründen, da ist schon eine ganze Bande Dunkelmänner hinter ihnen und dem Koffer her. Die rätselhaften Sprüche des Totenkopfes führen die drei ??? zu einer wahrsagenden Zigeunerin, auf die Spur des verschollenen Zauberkünstlers und eines unaufgeklärten Bankraubes. Doch als sie den letzten Hinweis zur Lösung des Falles in Händen halten, scheint alles schief zu gehen..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Patrick Kenneth"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Gulliver"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""Mr. Maximillian"",
        ""Speaker"": ""Richard Lauffen""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Mrs. Miller"",
        ""Speaker"": ""Marianne Wolters [Marianne Kehlau]""
      },
      {
        ""Character"": ""Mr. Grant"",
        ""Speaker"": ""Hans Meinhardt [Lothar Grützner]""
      },
      {
        ""Character"": ""Auktionator"",
        ""Speaker"": ""Gerlach Fiedler""
      },
      {
        ""Character"": ""Fred Brown"",
        ""Speaker"": ""Peter Buchholz""
      },
      {
        ""Character"": ""Hauswirt"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Mann"",
        ""Speaker"": ""Karl-Ulrich Meves""
      }
    ]
  },
  {
    ""Id"": ""c3afa15b-d657-4c55-a6b6-ef1374e1b22e"",
    ""Title"": ""... und der unheimliche Drache"",
    ""NumberEuropa"": 7,
    ""ReleaseDate"": ""1979-10-31T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/007.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein paar entlaufene Hunde zu suchen - naja, das ist normalerweise kein besonders verlockender Auftrag für drei clevere Detektive, doch kaum beginnen Justus, Bob und Peter mit der Suche, da erzählt ihnen der Hundebesitzer, Mr. Allen, von einem Seeungeheuer, das er an der Küste gesehen haben will. Wie bitte - Seeungeheuer? Doch Mr. Allen hat nicht gescherzt. Die ??? stoßen bei ihren Nachforschungen nicht nur auf einen leibhaftigen Drachen, der unheimlich hustet, sondern auch ein mysteriöses Höhlenlabyrinth, auf verschiebbare Felswände, bewaffnete Froschmänner und manch andere Merkwürdigkeiten. Wem gehört zum Beispiel die unheimliche Stimme am Telefon? Und was ist dieser Mr. Shelby für ein Mensch? Er nennt sich Spezialist für Tricks und Späße aller Art - aber bald stellt sich heraus, daß man auch mit Tricks und Späßen entschieden zu weit gehen kann..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""H. H. Allen"",
        ""Speaker"": ""Werner Cartano""
      },
      {
        ""Character"": ""Mr. Shelby"",
        ""Speaker"": ""Richard Lauffen""
      },
      {
        ""Character"": ""Mr. Carter"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Jack Morgan"",
        ""Speaker"": ""Klaus Klein [Wolfgang Kubach]""
      },
      {
        ""Character"": ""Harry Morgan"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Telephonistin"",
        ""Speaker"": ""Reinhilt Schneider""
      }
    ]
  },
  {
    ""Id"": ""431c0388-67c8-4786-bd82-0014b50761bc"",
    ""Title"": ""... und der grüne Geist"",
    ""NumberEuropa"": 8,
    ""ReleaseDate"": ""1979-10-31T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/008.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Merkwürdig, daß an diesem Abend anscheinend nicht nur Bob und Peter zufällig das Haus des längst verstorbenen Mathias Green besichtigen, das abgerissen werden soll. Mehr als merkwürdig, nämlich höchst gruselig, wenn dann plötzlich ein grün schimmernder Geist erscheint, was außer den beiden immerhin sechs ausgewachsene Männer (oder waren es sieben?) bezeugen können. Justus dagegen findet den Bericht seiner Freunde weder sehr merkwürdig, noch sehr gruselig, sondern sehr verdächtig -- und schon bald stecken die drei ??? in den Ermittlungen zu einem neuen Fall. Bald stellt sich heraus, daß irgendjemand hinter einer wertvollen Perlenkette hinterher ist, die in dem Abbruchhaus gefunden wurde. Sie ist dem Unbekannten sogar eine Entführung wert, wie Bob, Peter und ein neuer Freund am eigenen Leibe zu spüren bekommen. Doch Justus wäre nicht Justus, käme ihm nicht gerade rechtzeitig die rettende Erleuchtung..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Chang"",
        ""Speaker"": ""Torsten Sense""
      },
      {
        ""Character"": ""Patrick Kenneth"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Miss Lydia Green"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Harold Carlson"",
        ""Speaker"": ""Alexander Stubbe [Peter Kirchberger]""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Jensen"",
        ""Speaker"": ""Rolf Mamero""
      },
      {
        ""Character"": ""Won"",
        ""Speaker"": ""Victor Bernard [Ernst von Klipstein]""
      },
      {
        ""Character"": ""Wongs Diener"",
        ""Speaker"": ""Karl-Ulrich Meves""
      },
      {
        ""Character"": ""Li"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Männer bei Greens Haus"",
        ""Speaker"": ""Reiner Brönneke, Gernot Endemann""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Peter Buchholz""
      }
    ]
  },
  {
    ""Id"": ""00c4ac1c-d839-4f46-853e-d9efad898546"",
    ""Title"": ""... und die rätselhaften Bilder"",
    ""NumberEuropa"": 9,
    ""ReleaseDate"": ""1979-10-31T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/009.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Allzu viel ist es ja nicht, was der alte Maler Joshua Cameron hinterlassen hat - und obendrein blieb er die Miete schuldig! Aber ein merkwürdiger Kauz muß er gewesen sein: zeigen doch die 20 numerierten Ölbilder aus seinem Nachlaß alle dasselbe Motiv, nämlich sein Wohnhaus. Dies und die Tatsache, daß sich nicht nur eine Gräfin und ihr Verwalter, sondern auch mehrere Unbekannte und ein Kunsthändler auffällig für die Bilder interessieren, bringen die drei ??? auf den Plan. Sind die Gemälde vielleicht doch nicht so ganz wertlos? Vielleicht besteht da auch irgendein Zusammenhang mit den wirren Worten, die Cameron vor seinem Tod im Fieber gestammelt hatte... Während Justus, Peter und Bob ermitteln, versucht ihr alter Rivale, Skinny Norris, ihnen Steine in den Weg zu legen. Das wird am Ende für ihn selbst gefährlich. Nur gut, daß Justus rechtzeitig eine Erleuchtung kommt!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Peter Kirchberger [Andreas Beurmann]""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Professor Carswell"",
        ""Speaker"": ""Theodor Anzinger [Volker Bogdan]""
      },
      {
        ""Character"": ""Hal Carswell"",
        ""Speaker"": ""Oliver Mink""
      },
      {
        ""Character"": ""Gräfin"",
        ""Speaker"": ""Henriette Bischoff [Gisela Trowe]""
      },
      {
        ""Character"": ""Armand Marechal"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""De Groot"",
        ""Speaker"": ""René Genesis""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Maxwell James"",
        ""Speaker"": ""Werner Cartano""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      }
    ]
  },
  {
    ""Id"": ""720649b4-a148-42b9-b601-49e8bff27741"",
    ""Title"": ""... und die flüsternde Mumie"",
    ""NumberEuropa"": 10,
    ""ReleaseDate"": ""1980-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/010.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Alfred Hitchcock und seine Freunde, die drei jungen Detektive Justus, Peter und Bob (Firmenzeichen ???), sind davon überzeugt: Eine tausendjährige Mumie kann nicht flüstern. Aber die Mumie, die im Besitz des berühmten Ägyptologen Yarborough ist, flüstert dennoch, und zwar in einem altägyptischen Dialekt, den niemand verstehen kann. Die drei Fragezeichen sind entschlossen, das Geheimnis zu lösen, auch wenn der Fluch der Mumie sie treffen sollte. Ein großer und ein kleiner Libyer, eine abessinische Katze zuviel und Diebe aus Beruf und Leidenschaft legen ihnen dabei allerhand Schwierigkeiten in den Weg. Ob dieser Fall nicht doch zu kompliziert für die drei Fragezeichen ist?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Patrick"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Professor Yarborough"",
        ""Speaker"": ""Karl Walter Diess""
      },
      {
        ""Character"": ""Wilkins, sein Butler"",
        ""Speaker"": ""Ulrich Matschoss""
      },
      {
        ""Character"": ""Professor Freeman"",
        ""Speaker"": ""Joachim Wolff [Klaus Stieringer]""
      },
      {
        ""Character"": ""Achmed"",
        ""Speaker"": ""Ali Branowitch [Joachim Wolff]""
      },
      {
        ""Character"": ""Hamid"",
        ""Speaker"": ""Alexander Körting""
      },
      {
        ""Character"": ""Harry"",
        ""Speaker"": ""Peter Buchholz""
      },
      {
        ""Character"": ""Joe"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Uhrenmacher"",
        ""Speaker"": ""Gernot Endemann""
      }
    ]
  },
  {
    ""Id"": ""82140e94-ef26-4f4e-aa55-d39d34ff44c6"",
    ""Title"": ""... und das Gespensterschloß"",
    ""NumberEuropa"": 11,
    ""ReleaseDate"": ""1980-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/011.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Alfred Hitchcock hat zur Klärung unwahrscheinlicher Ereignisse Helfer bekommen: Die drei ???, hinter denen sich die jungen Detektive Justus, Peter und Bob verbergen. Wer könnte ein Interesse daran haben, den Spuk im Schloß zu veranstalten? Wer möchte unbedingt Besucher vom Schloß fernhalten? Zusammen mit seinen Freunden versucht Justus dem Geheimnis auf die Spur zu kommen. Werden sie es schaffen, sich als jüngste Detektei ihre Sporen zu verdienen? Wird es ihnen gelingen, das Geheimnis des Gespensterschlosses aufzuklären?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Stephen Terrill"",
        ""Speaker"": ""Wolf Rahtjen""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Mr. Grant"",
        ""Speaker"": ""Horst Breiter""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      }
    ]
  },
  {
    ""Id"": ""33da0aad-647a-41bf-92bb-fb1fa7fd4627"",
    ""Title"": ""... und der seltsame Wecker"",
    ""NumberEuropa"": 12,
    ""ReleaseDate"": ""1980-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/012.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Es gibt Wecker, die klingeln, Wecker, die schnarren, Wecker, die Musik ertönen lassen, oder einen mit Glockengeläut aus dem Schlaf holen. Einen Wecker aber, der einen furchterregenden schrillen Schrei ausstößt, haben Justus, Bob und Peter noch nie erlebt, und einen solchen haben sie soeben auf dem Schrottplatz aufgestöbert! Kein Wunder, daß diese seltsame Konstruktion die Neugier und die Phantasie der drei Detektive anstachelt: Wer hat einen solchen Wecker gebaut und warum? Als sie das herauszufinden versuchen, geraten sie unversehens auf die Spur eines raffinierten Kunstraubes. Doch ehe sie ihn aufklären können, gibt es manche harte Rätselnuß zu knacken..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Felix"",
        ""Speaker"": ""Karl-Ulrich Meves""
      },
      {
        ""Character"": ""Mrs. Smith"",
        ""Speaker"": ""Maria Benders""
      },
      {
        ""Character"": ""Harry"",
        ""Speaker"": ""Marco Beddies""
      },
      {
        ""Character"": ""Mrs. King"",
        ""Speaker"": ""Helga Bammert""
      },
      {
        ""Character"": ""Julie Taylor"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Martha Harris"",
        ""Speaker"": ""Marga Maasberg [Eva Gelb]""
      },
      {
        ""Character"": ""Carlos"",
        ""Speaker"": ""Hans-Werner Kuhn [Günter Heising]""
      },
      {
        ""Character"": ""Gerald Cramer"",
        ""Speaker"": ""Volker Brandt""
      },
      {
        ""Character"": ""Gerald Watson"",
        ""Speaker"": ""Werner van Thiel [Werner Cartano]""
      },
      {
        ""Character"": ""Hugenay"",
        ""Speaker"": ""Albert Giro [Wolfgang Kubach]""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Mr Jankins"",
        ""Speaker"": ""Lothar Zibell""
      }
    ]
  },
  {
    ""Id"": ""2ae4f07c-7275-4c11-aeca-6cc32cd53c2e"",
    ""Title"": ""... und der lachende Schatten"",
    ""NumberEuropa"": 13,
    ""ReleaseDate"": ""1980-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/013.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Schatten pflegen normalerweise zu schweigen. Hier aber lacht ein Schatten - schrill und furchterregend! Doch nicht nur dieser höchst ungewöhnliche Schatten bereitet Justus, Bob und Peter Kopfzerbrechen. Auf dem Landsitz der alten Miss Sanchez scheinen auch sonst recht merkwürdige Dinge vorzugehen. Was hat es zum Beispiel mit dem Gerücht auf sich, daß ganz in der Nähe ein wertvoller Indianerschatz vergraben sein soll - \""an einem Ort, wo kein Mann ihn finden kann\""? Ehe die drei Jungen sich versehen, sind sie in einem ebenso gefährlichen, wie mysteriösen Fall verwickelt, denn der Indianerschatz existiert wirklich. Ein skrupelloser Gangster versucht ihn zu erbeuten und setzt dabei nicht nur das Leben von vier Indianerjungen aufs Spiel. Doch dank Justus' Scharfsinn und Mut und mit Hilfe der Polizei wird dem Mann das Handwerk gelegt. Am Ende gibt es zwar keinen lachenden Schatz mehr, dafür aber drei lachende Detektive, die wieder einmal einen Fall heil überstanden haben!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Mr. Harris"",
        ""Speaker"": ""Günter Heising""
      },
      {
        ""Character"": ""Miss Sanchez"",
        ""Speaker"": ""Marlene Lindner [Ursula Vogel]""
      },
      {
        ""Character"": ""Ted Sanchez"",
        ""Speaker"": ""Nicolas Körting""
      },
      {
        ""Character"": ""Sanders"",
        ""Speaker"": ""Torsten Sense""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Natches"",
        ""Speaker"": ""Gernot Endemann""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Prof. Meeker"",
        ""Speaker"": ""Josef Dahmen""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Joachim Wolff""
      }
    ]
  },
  {
    ""Id"": ""3c23f4bd-9be1-4bc7-a5cd-2f2859903197"",
    ""Title"": ""... und das Bergmonster"",
    ""NumberEuropa"": 14,
    ""ReleaseDate"": ""1980-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/014.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Das neue Abenteuer, das Justus, Bob und Peter zu bestehen haben, fängt ganz harmlos an: mit der Suche nach einem Schlüssel. Doch schon bald häufen sich verdächtige Vorgänge. Warum hat Kathleen Hammond, die angeblich so geschäftstüchtig ist, solche Hemmungen, wenn sie eine Unterschrift leisten soll? Warum baut ihr Mann hinter dem kleinen Gasthof für die wenigen Gäste ein so großes Schwimmbecken? Auf dem Berg hinter dem Haus entdecken die drei ??? geheimnisvolle Spuren von einem übergroßen Fußabdruck. Dann kommen sie dahinter, daß ein Gast des Hauses es anscheinend auf Kathleens Geld abgesehen hat. Aber trotz vieler Anhaltspunkte wollen die Ermittlungen diesmal nicht recht vorangehen. Buchstäblich in letzter Minute erst lösen sie das seltsame Geheimnis, das Kathleen bedroht, und decken hinter den düsteren Legenden um ein Bergmoster die Wahrheit auf."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Smathers"",
        ""Speaker"": ""Josef Dahmen""
      },
      {
        ""Character"": ""Mr. Jensen"",
        ""Speaker"": ""Wolf Rahtjen""
      },
      {
        ""Character"": ""Patrick"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Kenneth"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Kathleen"",
        ""Speaker"": ""Brigitte Alexis""
      },
      {
        ""Character"": ""Mr. Joe Hammond"",
        ""Speaker"": ""Volker Brandt""
      },
      {
        ""Character"": ""Mrs. Hammond"",
        ""Speaker"": ""Hanni Vanhaiden""
      },
      {
        ""Character"": ""Richardsen"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Lieferant"",
        ""Speaker"": ""Franz-Josef Steffens""
      }
    ]
  },
  {
    ""Id"": ""9728c991-837c-4e6c-84a7-3d4bf32101ea"",
    ""Title"": ""... und der rasende Löwe"",
    ""NumberEuropa"": 15,
    ""ReleaseDate"": ""1980-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/015.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Zur Zeit langweilen sich Justus, Bob und Peter ziemlich. Doch im richtigen Moment verhilft ihnen Alfred Hitchcock zu einem interessanten Fall: Der sonst so sanfte Löwe George - Attraktion in Jim Halls \""Dschungelland\"", einem Tierpark für Touristen - ist in letzter Zeit so unruhig. Besonders nachts... Und nicht nur George, sondern auch ein Gorilla und sogar ein schwarzer Panther streifen hier frei herum. Da kann einem schon mulmig werden. Wer könnte Interesse daran haben, wilde Tiere aus ihren Käfigen zu lassen? Und warum sind Eisenstäbe aus der Trödelhandlung von Justus' Onkel auf einmal so gefragt? Was haben Diamanten mit der ganzen Geschichte zu tun? Außerdem müssen Justus, Bob und Peter noch so seltsame Typen wie Hank Murphy, Dobbsie und Olsen auf die Schliche kommen, und dabei geraten sie prompt in Lebensgefahr. Denn mit wilden Tieren und Diamantenschmugglern ist nicht zu spaßen."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Miß Larson"",
        ""Speaker"": ""Reinhilt Schneider""
      },
      {
        ""Character"": ""Jim Hall"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Mike Hall"",
        ""Speaker"": ""Mathias Lorenz""
      },
      {
        ""Character"": ""Eastland"",
        ""Speaker"": ""Karl Walter Diess""
      },
      {
        ""Character"": ""Olsen"",
        ""Speaker"": ""Karl-Ulrich Meves""
      },
      {
        ""Character"": ""Hank Murphy"",
        ""Speaker"": ""Harald Pages""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Doc Dawson"",
        ""Speaker"": ""Wolfgang Jürgen""
      },
      {
        ""Character"": ""Dobbsie"",
        ""Speaker"": ""Joachim Wolff""
      }
    ]
  },
  {
    ""Id"": ""b58dbe06-b6d3-4902-b625-20a9f092fbac"",
    ""Title"": ""... und der Zauberspiegel"",
    ""NumberEuropa"": 16,
    ""ReleaseDate"": ""1980-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/016.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Justus, Bob und Peter sind ja glücklicherweise schon allerlei gewöhnt. Wenn also jemand erzählt, in einem riesigen, spanischen Spiegel, der Mrs. Darnley gehört, spuke es, und wenn dann nachts in Mr. Darnleys Haus seltsame Geräusche zu hören sind, - dann kriegt zumindest Justus weniger Gänsehaut, als vielmehr Lust, der Sache auf den Grund zu gehen. Kaum beginnen die drei ??? zu ermitteln, stoßen sie auch schon auf jede Menge Verdächtiges: Ein Spanier, der sich für den Spiegel interessiert, wird zusammengeschlagen; der Präsident des Staates Ruffino weiß Geheimnisvolles vom Spiegel und warnt vor einem gewissen Juan Gomez; politische Intrigen scheinen sich am Spiegel zu entzünden, - schließlich wird sogar ein Junge entführt! Und das alles wegen eines alten Spiegels? Sehr merkwürdig! Doch unsere cleveren Detektive werden die Wahrheit herausfinden - wetten?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs. Darnley"",
        ""Speaker"": ""Gisela Trowe""
      },
      {
        ""Character"": ""Jeff Darnley"",
        ""Speaker"": ""Mike Henning""
      },
      {
        ""Character"": ""Jenny Darnley"",
        ""Speaker"": ""Marlen Krause""
      },
      {
        ""Character"": ""Senior Santora"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Gomez"",
        ""Speaker"": ""Karl-Heinz Gerdesmann""
      },
      {
        ""Character"": ""Brotverkäufer"",
        ""Speaker"": ""Harald Pages""
      }
    ]
  },
  {
    ""Id"": ""326b21f4-85ea-4c79-bcba-c0e503a810f5"",
    ""Title"": ""... und die gefährliche Erbschaft"",
    ""NumberEuropa"": 17,
    ""ReleaseDate"": ""1980-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/017.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der geheimnisvolle Marcus Towne, genannt Dingo, hinterläßt ein mysteriöses Testament. Es ist in Form einer mehrteiligen Rätselaufgabe abgefaßt. Das Vermögen soll demjenigen zufallen, der das Rätsel um diesen seltsamen \""letzten Willen\"" löst. Warum setzte Dingo so ein verrücktes Testament auf? Wollte er damit eventuell Erbschleichern einen Stein in den Weg legen? Die rechtmäßigen Erben wenden sich zusammen mit dem Rechtsanwalt an die drei ??? und bitten um Hilfe beim Rätsellösen. Rätsel für Rätsel beginnen nun die drei ??? zu entwirren. Sie stellen bald fest, daß man leicht in die Irre geht, wenn ein Rätsel- und Ränkeschmied zur Nachwelt spricht. Aber nicht nur das bereitet ihnen Kopfzerbrechen. Seit sie den Fall übernommen haben, sind sie von lauernden Gefahren und ungeahnten Bedrohungen umgeben. Doch nichts kann die drei ??? erschüttern. Sie besitzen genug Wagemut, dem Rätsel dieser geheimnisvollen Erbschaft auf den Grund zu kommen!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Nelly Towne"",
        ""Speaker"": ""Pamela Punti [Heikedine Körting]""
      },
      {
        ""Character"": ""Billy Towne"",
        ""Speaker"": ""Peer Siegel""
      },
      {
        ""Character"": ""Ordner"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Lopez"",
        ""Speaker"": ""Hans Irle""
      },
      {
        ""Character"": ""Dillon"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Roger Callow"",
        ""Speaker"": ""Hans Daniel""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Heidi Schaffrath""
      }
    ]
  },
  {
    ""Id"": ""c47bb405-3009-4f39-968d-bc62d49ad654"",
    ""Title"": ""... und die Geisterinsel"",
    ""NumberEuropa"": 18,
    ""ReleaseDate"": ""1980-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/018.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein Flug quer über den amerikanischen Kontinent - das ist eine nicht zu verachtende Abwechslung für die drei jungen Detektive Justus, Bob und Peter. Wenn außerdem ein Auftrag dafür herausspringt, um so besser: Sie sollen nämlich klären, wer hinter den Diebstählen und Sabotageakten steckt, die einer Filmgesellschaft auf Skeleton Island zu schaffen machen. Auch sonst gibt es einige merkwürdige Dinge auf dieser Insel. Die Einheimischen sind von einer alten Geistergeschichte beunruhigt, munkeln von einem verschollenen Piratenschatz, der im Meer versenkt worden sein soll und beargwöhnen mißtrauisch den jungen Griechen Chris mit seinem Vater. Sollten vielleicht diese Fremden für die Diebstähle bei der Filmgesellschaft verantwortlich sein? Die drei ??? wissen es bald besser - und dieses Wissen bringt sie prompt in Gefahr. Doch jetzt zahlt sich ihr Vertrauen in Chris aus: Er hilft ihnen nicht nur mutig aus der Klemme, sondern trägt auch entscheidend zur Entlarvung der gesuchten Diebe bei, denen in letzter Minute der sagenhafte Piratenschatz entrissen wird..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Sam"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""Chris Markos"",
        ""Speaker"": ""Stephan Chrzescinski""
      },
      {
        ""Character"": ""Kommissar Nostigon"",
        ""Speaker"": ""Volker Brandt""
      },
      {
        ""Character"": ""Mr. Shaw"",
        ""Speaker"": ""Joachim Richert""
      },
      {
        ""Character"": ""Denton"",
        ""Speaker"": ""Karl-Heinz Gerdesmann""
      },
      {
        ""Character"": ""Farraday"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Jeff"",
        ""Speaker"": ""Harald Pages""
      },
      {
        ""Character"": ""Bill Ballinger"",
        ""Speaker"": ""Günter Flesch""
      },
      {
        ""Character"": ""Jim Ballinger"",
        ""Speaker"": ""Heinz Werder""
      },
      {
        ""Character"": ""Mr. Norris"",
        ""Speaker"": ""Horst Schick""
      },
      {
        ""Character"": ""Mrs. Barton"",
        ""Speaker"": ""Marianne Kehlau""
      }
    ]
  },
  {
    ""Id"": ""3fe9fe79-0bf5-4521-a9d4-ee78b38b86b4"",
    ""Title"": ""... und der Teufelsberg"",
    ""NumberEuropa"": 19,
    ""ReleaseDate"": ""1980-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/019.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Auch wenn man nicht an Gespenster glaubt, bei einem abendlichen Spaziergang durchs Tal der Wehklagen können einem schon die Haare zu Berge stehen. Klar, daß unsere drei Detektive dem schauerlichen Heulen, dem das Tal seinen Namen verdankt, nachgehen müssen. Das jeden Abend einsetzende Stöhnen scheint aus einer Höhle im Teufelsberg zu kommen, doch sobald man sie betritt, herrscht Ruhe. Sollte an den Gerüchten, daß El Diablo, ein offiziell längst totgesagter Bandit, dort umgeht, doch etwas dransein? Prof. Walsh, der wie Justus, Bob und Peter auf der Mendoza-Ranch weilt, ist genauso wenig abergläubisch wie die Jungen. Die Landarbeiter aber lassen sich mehr und mehr nervös machen. Wer nur versucht mit allen Mitteln, Eindringlinge vom Teufelsberg fernzuhalten - und warum? Selbst Justus tappt im Dunkeln. Bis er ein winziges Steinchen in der Höhle findet, das alles andere ist als ein gewöhnlicher Stein..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Dalton"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Mrs. Dalton"",
        ""Speaker"": ""Helga Bammert""
      },
      {
        ""Character"": ""Hardin"",
        ""Speaker"": ""Christian Mey""
      },
      {
        ""Character"": ""Prof. Walsh"",
        ""Speaker"": ""Joachim Rake""
      },
      {
        ""Character"": ""Ben Jackson"",
        ""Speaker"": ""Günter Flesch""
      },
      {
        ""Character"": ""Wreston"",
        ""Speaker"": ""Ulrich Benthin""
      },
      {
        ""Character"": ""Cardigo"",
        ""Speaker"": ""Harald Pages""
      },
      {
        ""Character"": ""Waldo Turner"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Taucher"",
        ""Speaker"": ""Joachim Richert""
      }
    ]
  },
  {
    ""Id"": ""0763a4d0-8faa-4547-aa3b-f43914afdacf"",
    ""Title"": ""... und die flammende Spur"",
    ""NumberEuropa"": 20,
    ""ReleaseDate"": ""1980-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/020.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Nur selten verläßt der alte Töpfer, genannt der Potter, sein Haus in Rocky Beach. Doch nicht nur sein Eremitendasein macht die Einwohner mißtrauisch, auch sein Aussehen: Er hat langes weißes Haar, einen schön gekämmten Vollbart, ein wallendes weißes Gewand, und er geht immer barfuß. Außerdem trägt er um den Hals ein Medaillon aus Keramik, das einen scharlachroten Adler mit zwei Köpfen zeigt -- ist das nicht höchst sonderbar? Plötzlich aber verschwindet er, obwohl er seine Tochter, Mrs. Dobson, und seinen Enkel Tom, zu Besuch erwartet. Ist eine zufällige, kurze Begegnung mit den zwei etwas undurchsichtigen fremden Männern der Grund? Ein weiterer verdächtiger Mann, angeblich ein Sportfischer, hat offenbar ebenfalls die Finger in dieser geheimnisvollen Sache. Alle sind sie hinter dem Symbol eines zweiköpfigen Adlers her -- so einem Adler, wie der Potter um den Hals hängen hat. Flammende Fußspuren und das Geräusch fließenden Wassers in der Leitung im Potterschen Haus bringen Mrs. Dobson an den Rand der Hysterie. Mit gewohntem Forscherdrang und üblicher Tatkraft versuchen die drei Fragezeichen, hinter das Geheimnis zu kommen: Sollte der Potter etwa ein Edelmann aus Europa, der doppelköpfige Adler sein Emblem, sein wallendes Gewand eine wehmütige Erinnerung an einen fürstlichen Umhang sein? -- Das Inkognito wahren -- so heißt es bei Hoheiten, wenn sie unerkannt bleiben wollen..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Hauptkommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Mihai Eftimin"",
        ""Speaker"": ""Volker Brandt""
      },
      {
        ""Character"": ""Dr. Radulescu"",
        ""Speaker"": ""Günter Flesch""
      },
      {
        ""Character"": ""Potter"",
        ""Speaker"": ""Karl-Heinz Gerdesmann""
      },
      {
        ""Character"": ""Mrs. Dobson"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Tom Dobson"",
        ""Speaker"": ""Alexander Körting""
      },
      {
        ""Character"": ""Farrier"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Hans Irle""
      }
    ]
  },
  {
    ""Id"": ""be1b1eac-2795-42c8-a12d-161d53ccd3c0"",
    ""Title"": ""... und der tanzende Teufel"",
    ""NumberEuropa"": 21,
    ""ReleaseDate"": ""1980-10-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/021.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine Serie Diebstähle in Rocky Beach - und jedesmal fehlt einer jener verbreiteten Bordkoffer. Die drei ??? nehmen sich dieses ominösen Falls an. Und immer dann, wenn sie gerade eine neue Spur verfolgen, taucht die unheimlich reale Gestalt eines \""Tanzenden Teufels\"", eines Dämons aus einer fremden Kultur mit schrecklichen Drohungen und Feuer und Rauch, auf ..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs. Dalton"",
        ""Speaker"": ""Heidi Schaffrath""
      },
      {
        ""Character"": ""Christina Dalton"",
        ""Speaker"": ""Karina Leising [Heikedine Körting]""
      },
      {
        ""Character"": ""Frankie Bender"",
        ""Speaker"": ""Oliver Mink""
      },
      {
        ""Character"": ""H. P. Clay"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Jim Clay"",
        ""Speaker"": ""Marcus Meiering [Dieter B. Gerlach]""
      },
      {
        ""Character"": ""Walter Quail"",
        ""Speaker"": ""Christian Mey""
      },
      {
        ""Character"": ""Trödler Hummer"",
        ""Speaker"": ""Joachim Richert""
      },
      {
        ""Character"": ""Jason Wilkes"",
        ""Speaker"": ""Joachim Rake""
      },
      {
        ""Character"": ""Chiang"",
        ""Speaker"": ""Tom Barrows [Jürgen Thormann? Hans Irle?]""
      },
      {
        ""Character"": ""Diakon Kastner"",
        ""Speaker"": ""Hans Irle""
      },
      {
        ""Character"": ""Butler"",
        ""Speaker"": ""Hans Daniel""
      },
      {
        ""Character"": ""Mrs. Shaw"",
        ""Speaker"": ""Marianne Kehlau""
      }
    ]
  },
  {
    ""Id"": ""c9e573be-5926-4b8d-9169-4c3af8be09de"",
    ""Title"": ""... und der verschwundene Schatz"",
    ""NumberEuropa"": 22,
    ""ReleaseDate"": ""1981-05-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/022.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Gerade als Justus, Bob und Peter eine Ausstellung japanischer Kunstschätze besuchen, wird dort ein besonders wertvoller juwelenbesetzter Gürtel gestohlen. Zu dumm, daß der japanische Sicherheitsbeamte die drei jungen Detektive nicht bei der Aufklärung des dreisten Diebstahls helfen lassen will! Aber dafür hat Alfred Hitchcock einen neuen, ziemlich mysteriösen Fall für sie: Eine alte Dame wird angeblich Tag und Nacht von kleinen \""Gnomen\"" belästigt. Versteht sich, daß die drei ??? nicht an Gnomen glauben -- aber was sind es dann für merkwürdige kleine Gestalten, die sie mit eigenen Augen beobachten? Während sie noch rätseln, sitzen sie plötzlich in der Falle und werden ohnmächtige Zeugen eines raffinierten Bankraubes. Führt eine Spur vom Bankraub zum Gürteldiebstahl? Justus kombiniert schneller als die Gauner -- mit Köpfchen und polizeilicher Hilfe wird auch dieser knifflige Doppelfall gelöst..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews,Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Rawley"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Mr. Frank"",
        ""Speaker"": ""Siegfried Wald""
      },
      {
        ""Character"": ""Mr. Togati"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Taro"",
        ""Speaker"": ""Stefan Brönneke""
      },
      {
        ""Character"": ""Patrick"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Miss Agawam"",
        ""Speaker"": ""Ursula Vogel""
      },
      {
        ""Character"": ""Jordan"",
        ""Speaker"": ""Hans Meinhardt [Franz-Josef Steffens]""
      },
      {
        ""Character"": ""Chuck"",
        ""Speaker"": ""Roland Fabricius [Edgar Bessen??]""
      },
      {
        ""Character"": ""Liliputaner"",
        ""Speaker"": ""Erich Büttner [Joachim Wolff]""
      },
      {
        ""Character"": ""Wachmann im Museum"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Hafenpolizist"",
        ""Speaker"": ""Peter Kirchberger""
      }
    ]
  },
  {
    ""Id"": ""986ffdda-c8c3-48a6-926a-c1c6f0a5f688"",
    ""Title"": ""... und das Aztekenschwert"",
    ""NumberEuropa"": 23,
    ""ReleaseDate"": ""1981-05-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/023.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die Brüder Pico und Diego Alvaro verlieren durch ein Feuer ihren ganzen Besitz. Eine wahrhaft unrealistische, aber von den drei ??? -- befeuert durch Justus' Eigen- und Spürsinn - gehegte Hoffnung könnte die Lage zum Guten wenden: wenn sich nämlich das juwelenbesetzte sogenannte \""Aztekenschwert\"" finden ließe, das ein Alvaro-Ahn seinerzeit von Cortez persönlich geschenkt bekam. Mühselige und teilweise lebensgefährliche Ermittlungen -- und immer verfolgt von undurchsichtigen Fremden -- bringen die drei ??? und Diego auf eine heiße Spur. Wird es den vier Jungen gelingen, noch vor ihren Verfolgern das legendäre Cortez-Schwert zu finden?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Skinny"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Cody"",
        ""Speaker"": ""Simon Schuchadt [Wolfgang Kaven]""
      },
      {
        ""Character"": ""Diego Alvaro"",
        ""Speaker"": ""Jan Odle""
      },
      {
        ""Character"": ""Pico Alvaro"",
        ""Speaker"": ""Mathias Lorenz""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Assistent"",
        ""Speaker"": ""Claes Holmcrantz [Gernot Endemann]""
      },
      {
        ""Character"": ""Sheriff"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Tulsa"",
        ""Speaker"": ""Klaus Klein [Franz-Josef Steffens]""
      },
      {
        ""Character"": ""Cap"",
        ""Speaker"": ""Fritz Wegely [Siegfried Wald]""
      },
      {
        ""Character"": ""Pike"",
        ""Speaker"": ""Philip Mehringer [Joachim Wolff]""
      },
      {
        ""Character"": ""Mr Shaw"",
        ""Speaker"": ""Franz-Josef Steffens""
      }
    ]
  },
  {
    ""Id"": ""6626140b-01bb-4639-831e-9b2c822b1d00"",
    ""Title"": ""... und die silberne Spinne"",
    ""NumberEuropa"": 24,
    ""ReleaseDate"": ""1981-05-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/024.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Verschwörung in Magnusstad: Der junge Lars Holmqvist soll um sein Erbe gebracht werden. Seine Freunde, Justus, Bob und Peter wollen ihm helfen, geraten dabei aber selbst in eine gefährliche Lage: Plötzlich ist die legendäre silberne Spinne, die für Lars und ganz Magnusstad eine besondere Bedeutung hat, in ihrem Zimmer. Die Feinde von Lars möchten den drei ??? offensichtlich einen Raub in die Schuhe schieben. Eine abenteuerliche Verfolgungsjagd beginnt. Schaffen es die drei Freunde es auch diesmal wieder?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Bengt"",
        ""Speaker"": ""Charles Regnier""
      },
      {
        ""Character"": ""Britta"",
        ""Speaker"": ""Ingeburg Kanstein""
      },
      {
        ""Character"": ""Lars Holmqvist"",
        ""Speaker"": ""Gernot Endemann""
      },
      {
        ""Character"": ""Young"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Forsborg"",
        ""Speaker"": ""Richard Heelel [Franz-Josef Steffens]""
      },
      {
        ""Character"": ""Mann"",
        ""Speaker"": ""Siegfried Wald""
      },
      {
        ""Character"": ""Frau"",
        ""Speaker"": ""Brigitte Alexis""
      },
      {
        ""Character"": ""Köhler"",
        ""Speaker"": ""Hans Meinhardt [Reiner Brönneke]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Wärter"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""Kellner"",
        ""Speaker"": ""Peter Kirchberger""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      }
    ]
  },
  {
    ""Id"": ""2c096599-5cb6-436f-aca9-814a96004518"",
    ""Title"": ""... und die singende Schlange"",
    ""NumberEuropa"": 25,
    ""ReleaseDate"": ""1981-10-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/025.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Zugegeben. Mrs. Patricia Osborne ist eine etwas seltsame Dame. Nicht genug damit, daß sie rote Samtkleider als Schutzschild gegen die Gefahren des Lebens betrachtet und Spinnweben für hervorragende Heilmittel hält -- sie glaubt auch felsenfest, daß ein mit dem Messer allabendlich ums Bett gezogener Kreis sie vor nächtlichem Unheil schützt! Als sie aber auch noch einen finsteren Asmodi zu geheimen Zusammenkünften einlädt, bei denen ein gräßlicher Singsang aus dem verschlossenen Zimmer dringt, da reicht es ihrer Nichte Allie. Das Mädchen schaltet kurzentschlossen die drei ??? ein. Vermutet sie zu recht, daß jemand die Leichtgläubigkeit ihrer Tante verbrecherisch ausnutzen will? Zusammen mit Justus, Bob und Peter folgt sie Asmodi, der in einem abgelegenen Haus merkwürdige Kultabende abhält. Sie schleichen sich ein -- und beobachten entsetzt, wie sich zwischen schwarz vermummten Gestalten im Kerzengeflacker einer fremdartigen Zeremonie plötzlich eine riesige Schlange zu winden scheint! Und diese Schlange läßt einen grausigen Gesang ertönen... Werden die drei ??? ihr Geheimnis enthüllen?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Allie Jamison"",
        ""Speaker"": ""Katrin Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Asmodi"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Dr. Shaitan"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Noxworth"",
        ""Speaker"": ""Christian Rode""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Prof. Barrister"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Marie"",
        ""Speaker"": ""Susanne Wulkow""
      },
      {
        ""Character"": ""der \""Clochard\"""",
        ""Speaker"": ""Karl-Heinz Gerdesmann""
      },
      {
        ""Character"": ""Patricia Osborne"",
        ""Speaker"": ""Barbara Focke""
      },
      {
        ""Character"": ""Margaret Compton"",
        ""Speaker"": ""Ingeburg Kanstein""
      },
      {
        ""Character"": ""Mann am Grundstück"",
        ""Speaker"": ""Wolfgang Kaven""
      }
    ]
  },
  {
    ""Id"": ""adc67c1a-b75f-4864-b465-2d5a1143f6d2"",
    ""Title"": ""... und die Silbermine"",
    ""NumberEuropa"": 26,
    ""ReleaseDate"": ""1981-10-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/026.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Allie Jamison kann die drei ??? schon manchmal aufregen, starrköpfig und voreingenommen, wie sie ist! Oder sollte sie etwa recht haben mit ihrer Vermutung, bei Wesley Thurgood, dem neuen Nachbarn ihres Onkels, stimme etwas nicht? Eigentlich wollten die drei ??? während der Sommerferien nur Allies Onkel beim Bäumeschneiden helfen. Aber je mehr merkwürdige Dinge geschehen, desto spannender -- und gefährlicher wird es auch für unsere Freunde. Ist es nicht seltsam, daß der steinreiche Thurgood ausgerechnet die alte, verlassene Silbermine gekauft hat, die berüchtigte \""Todesfalle\""? Und warum wird er gleich so zornig, als Allie versucht, das Bergwerk zu erforschen? Ahnt er vielleicht etwas von dem schaurigen Fund, den die drei ??? und Allie dort machen werden? Aber hier ist Vorsicht am Platze! Denn Thurgood ist nicht der einzige, der den drei ??? mysteriös vorkommt... Schließlich gibt es in den nahen Bergen noch manch alte Stadt, die heute völlig menschenleer ist. Und gar nicht weit davon beginnt schon die Wüste. Könnte da nicht jemand, der eine nicht ganz reine Weste hat, auf dumme Gedanken kommen?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Allie Jamison"",
        ""Speaker"": ""Katrin Fröhlich""
      },
      {
        ""Character"": ""Harrison Osborne"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Thurgood"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Sheriff"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Mrs. Macomber"",
        ""Speaker"": ""Gisela Trowe""
      },
      {
        ""Character"": ""Atkinson"",
        ""Speaker"": ""Klaus Stieringer""
      },
      {
        ""Character"": ""Manny"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Gasper"",
        ""Speaker"": ""Rolf Mamero""
      }
    ]
  },
  {
    ""Id"": ""399f6977-90e3-42fa-b1ef-87bda4ff12e1"",
    ""Title"": ""... und der magische Kreis"",
    ""NumberEuropa"": 27,
    ""ReleaseDate"": ""1981-10-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/027.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""In Santa Monica geschehen an einem Abend gleich zwei folgenschwere Ereignisse auf einmal: Ein Verlag geht in Flammen auf -- und im benachbarten Filmlabor werden sämtliche Filme der bekannten Schauspielerin Madeline Bainbridge gestohlen. Als dann auch noch das Manuskript der Memoiren Madeline Bainbridges verschwindet, ist den drei ???, Justus, Peter und Bob, klar, daß hier etwas nicht mit rechten Dingen zugeht. Die Nachforschungen, die sie anstellen, führen die drei Detektive in das unheimliche Reich der Magie. Alles erscheint undurchschaubar. Was bedeutet der magische Kreis, in dem die Zahl 13 eine so große Rolle spielt? Was verbirgt sich hinter Madeline Bainbridges rätselhafter Vergangenheit und was ist wahr an der Bahauptung, sie sei eine Hexe? Gibt es den Mord durch Magie? Diese Frage gilt es für die drei zu lösen. Bei ihren Ermittlungsarbeiten sind die unheimlichsten Situationen zu überstehen und Peter kommt nach einer entscheidenden Entdeckung in große Gefahr..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Horace Tremayne"",
        ""Speaker"": ""Karl-Ulrich Meves""
      },
      {
        ""Character"": ""William Tremayne"",
        ""Speaker"": ""Günter Flesch""
      },
      {
        ""Character"": ""Marvin Gray"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Madeline Bainbridge"",
        ""Speaker"": ""Ursula Vogel""
      },
      {
        ""Character"": ""Mr. Thomas"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Jefferson"",
        ""Speaker"": ""Christian Rode""
      },
      {
        ""Character"": ""Clara Adams"",
        ""Speaker"": ""Ingeburg Kanstein""
      },
      {
        ""Character"": ""Grean"",
        ""Speaker"": ""Manuel Hümpel [Rüdiger Schulzki]""
      },
      {
        ""Character"": ""Schrottplatzwart"",
        ""Speaker"": ""Siegfried Wald""
      }
    ]
  },
  {
    ""Id"": ""3d5c335c-cbf8-4883-b0ad-63b05d0adb22"",
    ""Title"": ""... und der Doppelgänger"",
    ""NumberEuropa"": 28,
    ""ReleaseDate"": ""1982-06-07T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/028.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Sollte es ihn wahrhaftig geben, einen zweiten... Justus Jonas? Jan, der sich aus Angst vor hinterhältigen Gaunern auf dem Schrottplatz einquartiert hat, weiß nicht, daß er dadurch die drei ???, und vor allem sein Ebenbild Justus in große Schwierigkeiten bringt. Gefahr und Chaos lauern auf Schritt und Tritt. Justus wird an Jans Stelle von den Männern geschnappt und eingesperrt. Rätselhafte Botschaften! Politische Intrigen über Länder und Kontinente! Lebensgefährliche Irrtümer! Ein Gegner, der sich beinahe in der abgeschirmten Zentrale der Nachwuchsdetektive einnistet! Aber Bob und Peter beweisen, daß sie auch ohne ihren Chef richtig und überlegt handeln können. Eine wilde Verfolgungsjagd beginnt, denn es geht um Minuten!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Reporter"",
        ""Speaker"": ""Peter Kirchberger""
      },
      {
        ""Character"": ""Fred, Extremist"",
        ""Speaker"": ""Heinrich Baum [Karl Walter Diess]""
      },
      {
        ""Character"": ""Walt, Extremist"",
        ""Speaker"": ""Friedhelm Hubertus [Siegfried Wald]""
      },
      {
        ""Character"": ""Gordon Mackenzie"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Adam Ndula"",
        ""Speaker"": ""Hans Meinhardt [Henry Kielmann]""
      },
      {
        ""Character"": ""Jan Carew"",
        ""Speaker"": ""Sascha Draeger""
      },
      {
        ""Character"": ""Polizist im Suchtrupp"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Hauswirt"",
        ""Speaker"": ""Hubert Mittendorf""
      }
    ]
  },
  {
    ""Id"": ""18259a5f-8886-4af9-8627-e83c398df339"",
    ""Title"": ""... und das Riff der Haie"",
    ""NumberEuropa"": 30,
    ""ReleaseDate"": ""1982-06-07T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/030.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Demonstranten blockieren die Arbeiten an der Ölbohrinsel vor der Küste von Santa Barbara. Die drei Detektive fahren hinaus, um sich die Demonstration anzusehen. Sie werden in rätselhafte Vorgänge verwickelt. Etwas Unheimliches geschieht mit dem Boot von Mr. Croowe, und als ein gewaltiger Sturm aufzieht, gibt das Meer eines seiner Geheimnisse preis. Was schiebt sich da aus den Wellen? Ein Meeresungeheuer...?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Joachim Richert""
      },
      {
        ""Character"": ""Crowe"",
        ""Speaker"": ""Henry Kielmann""
      },
      {
        ""Character"": ""Käptn Jason"",
        ""Speaker"": ""Karl Walter Diess""
      },
      {
        ""Character"": ""MacGruder"",
        ""Speaker"": ""Siegfried Wald""
      },
      {
        ""Character"": ""Hanley"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Torao"",
        ""Speaker"": ""Joko Talmann [Rüdiger Schulzki]""
      },
      {
        ""Character"": ""Berg"",
        ""Speaker"": ""Andreas Beurmann / Wolfgang Draeger""
      },
      {
        ""Character"": ""Yamura"",
        ""Speaker"": ""Hubert Mittendorf""
      },
      {
        ""Character"": ""Die Gebrüder Connors"",
        ""Speaker"": ""Nicolas Körting, Lothar Grützner""
      },
      {
        ""Character"": ""Weston"",
        ""Speaker"": ""Joachim Richert""
      }
    ]
  },
  {
    ""Id"": ""b3cbde08-e78a-4224-94b9-527e9f738c9c"",
    ""Title"": ""... und das Narbengesicht"",
    ""NumberEuropa"": 31,
    ""ReleaseDate"": ""1983-03-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/031.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ist das Narbengesicht wirklich blind? Zweifel erscheinen angebracht, nachdem ziemlich sicher ist, daß dieser seltsame Mann bei einem Banküberfall \""Schmiere\"" gestanden hat. Offene und ungeklärte Fragen haben die drei ??? schon immer interessiert. Eine verlorene Brieftasche verhilft ihnen zum Einstieg in einen Kriminalfall, bei dem es um weit mehr als nur einen Banküberfall geht."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Shelby Tuckerman"",
        ""Speaker"": ""Pinkas Braun""
      },
      {
        ""Character"": ""Mr. Hitfield"",
        ""Speaker"": ""Christian Riege [Manfred Steffen]""
      },
      {
        ""Character"": ""Mr. Bonestell"",
        ""Speaker"": ""Joachim Richert""
      },
      {
        ""Character"": ""Mrs. Denicola"",
        ""Speaker"": ""Katharina Brauren""
      },
      {
        ""Character"": ""Eileen"",
        ""Speaker"": ""Ruth Niehaus""
      },
      {
        ""Character"": ""Ernie"",
        ""Speaker"": ""Helmut Zierl""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Harald Pages""
      },
      {
        ""Character"": ""Hoang Van Dong"",
        ""Speaker"": ""Chen Lung Chung [Volker Brandt]""
      },
      {
        ""Character"": ""Frau an der Bushaltestelle"",
        ""Speaker"": ""Ursula Vogel""
      },
      {
        ""Character"": ""Nachrichtensprecher"",
        ""Speaker"": ""Joachim Wolff""
      },
      {
        ""Character"": ""Patrick"",
        ""Speaker"": ""Joachim Richert""
      }
    ]
  },
  {
    ""Id"": ""d4b57068-a9c5-41a9-8e29-d3ce10df2944"",
    ""Title"": ""... und der Ameisenmensch"",
    ""NumberEuropa"": 32,
    ""ReleaseDate"": ""1983-03-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/032.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine Vogelscheuche erwacht plötzlich zum Leben und stürzt sich auf alles, was ihr in die Quere kommt. Letitia Radford beginnt zu verzweifeln. In ihrer Todesangst beauftragt sie die drei Detektive, das Rätsel der wandelnden Vogelscheuche zu lösen. Justus, Bob und Peter nehmen den Auftrag an und geraten unversehens in Lebensgefahr."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Dr. Woolley"",
        ""Speaker"": ""Manfred Steffen""
      },
      {
        ""Character"": ""Larry Conklin"",
        ""Speaker"": ""Sylvester Merten [Helmut Zierl]""
      },
      {
        ""Character"": ""Letitia Radford"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Mrs. Chumley"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Mrs. Burroughs"",
        ""Speaker"": ""Katharina Brauren""
      },
      {
        ""Character"": ""Mr. Burroughs"",
        ""Speaker"": ""Martin Fichte [Joachim Wolff]""
      },
      {
        ""Character"": ""Gary Malz"",
        ""Speaker"": ""Volker Brandt""
      },
      {
        ""Character"": ""Mr. Agnier"",
        ""Speaker"": ""Willem Fricke""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Patrick"",
        ""Speaker"": ""Joachim Richert""
      }
    ]
  },
  {
    ""Id"": ""aa4237e7-9e65-4c70-95af-e7fbb5f9d9f8"",
    ""Title"": ""... und die bedrohte Ranch"",
    ""NumberEuropa"": 33,
    ""ReleaseDate"": ""1983-10-21T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/033.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der Zufall vermittelt Justus, Bob und Peter die Bekanntschaft mit dem exzentrischen Ehepaar Barron, und unerwartet finden sie sich auf Rancho Valverde eingeschlossen, ohne Kontakt zur Umwelt! Geht der Kampf nun gegen außerirdische Wesen, oder gegen kriminelle Betrüger und Diebe? Unsere drei Klugen Detektive werden die Wahrheit herausfinden - wetten?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Patrick"",
        ""Speaker"": ""Wolfgang Kubach""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Peter Kirchberger""
      },
      {
        ""Character"": ""Mr. Barron"",
        ""Speaker"": ""Pinkas Braun""
      },
      {
        ""Character"": ""Mrs. Barron"",
        ""Speaker"": ""Monika Peitsch""
      },
      {
        ""Character"": ""Hank Detweiler"",
        ""Speaker"": ""Siegfried Wald""
      },
      {
        ""Character"": ""Elsie Spratt"",
        ""Speaker"": ""Pia Werfel [Barbara Focke]""
      },
      {
        ""Character"": ""Leutnant Ferrante"",
        ""Speaker"": ""Volkert Kraeft""
      },
      {
        ""Character"": ""Bones"",
        ""Speaker"": ""Siegfried Meyerheim [Helmut Zierl]""
      },
      {
        ""Character"": ""vermeintlicher US-Präsident"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Kenneth"",
        ""Speaker"": ""- ??? -""
      },
      {
        ""Character"": ""Omeganer"",
        ""Speaker"": ""- ??? -""
      },
      {
        ""Character"": ""Simon deLuca"",
        ""Speaker"": ""- ??? -""
      },
      {
        ""Character"": """",
        ""Speaker"": """"
      },
      {
        ""Character"": ""Neuabmischung:"",
        ""Speaker"": """"
      },
      {
        ""Character"": """",
        ""Speaker"": """"
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Elsie Spratt"",
        ""Speaker"": ""Hansi Jochmann""
      }
    ]
  },
  {
    ""Id"": ""5373d6a5-9a58-450f-b0e7-50bb894233b2"",
    ""Title"": ""... und der rote Pirat"",
    ""NumberEuropa"": 34,
    ""ReleaseDate"": ""1984-04-05T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/034.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Wer verbirgt sich hinter der Maske des \""roten Piraten\"" - und warum bedroht er Justus, Bob und Peter? Was steckt hinter den Tonbandinterviews von Major Karnes - und wonach gräbt dieser heimlich in der Piratenbucht? Trotz aller Gefahren lassen die drei ??? nicht locker, bis sie das Rätsel um den legendären Piratenschatz gelöst haben - einen Schatz, der allerhand Geheimnisse birgt!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Shaw"",
        ""Speaker"": ""Horst Schick""
      },
      {
        ""Character"": ""Kapitän Joy"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""Jeremy Joy"",
        ""Speaker"": ""Philip Siegel""
      },
      {
        ""Character"": ""Joshua Evans"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Major Karnes"",
        ""Speaker"": ""Manfred Schermutzki""
      },
      {
        ""Character"": ""Sam Davis"",
        ""Speaker"": ""Utz Richter""
      },
      {
        ""Character"": ""Hubert"",
        ""Speaker"": ""- ??? -""
      },
      {
        ""Character"": ""Carl"",
        ""Speaker"": ""- ??? -""
      }
    ]
  },
  {
    ""Id"": ""5d93495e-d7fa-4a0e-8f83-23e1be109f86"",
    ""Title"": ""... und der Höhlenmensch"",
    ""NumberEuropa"": 35,
    ""ReleaseDate"": ""1984-10-16T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/035.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Das Skelett eines Urzeitmenschen lockt Justus, Bob und Peter in den kleinen Ort Citrus Grove. Kaum sind sie dort, als es auch schon zu rätselhaften Zwischenfällen kommt. Erwacht der Urmensch zu geheimnisvollen Leben? Und wieso legen sich plötzlich alle Bewohner von Citrus Grove zum Schlafen in den Park...?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Eleonor"",
        ""Speaker"": ""Susanne Wulkow""
      },
      {
        ""Character"": ""Birkensteen"",
        ""Speaker"": ""Oskar Kluge [Günter König]""
      },
      {
        ""Character"": ""Terreano"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Brandon"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Hoffer"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""McGee"",
        ""Speaker"": ""Utz Richter""
      },
      {
        ""Character"": ""Thalia"",
        ""Speaker"": ""Ingeburg Kanstein""
      },
      {
        ""Character"": ""Stefano"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""John"",
        ""Speaker"": ""Edgar Bessen""
      },
      {
        ""Character"": ""Tankwart"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""LKW-Fahrer"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Mann am Bahnhof"",
        ""Speaker"": ""Christian Rode""
      },
      {
        ""Character"": ""Bürgermeister"",
        ""Speaker"": ""Edgar Bessen""
      }
    ]
  },
  {
    ""Id"": ""6c6a9149-8a8f-4506-a449-f854b238aea8"",
    ""Title"": ""... und der Super-Wal"",
    ""NumberEuropa"": 36,
    ""ReleaseDate"": ""1985-05-29T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/036.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Justus, Bob und Peter retten einen Wal, der bei Ebbe ins allzu flache Wasser geraten ist. Damit beginnt eine Reihe von gefährlichen Abenteuern. Der Wal wird dressiert und soll für Bergungsarbeiten eingesetzt werden. Doch damit ist irgend jemand gar nicht einverstanden! Was liegt da Geheimnisvolles auf dem Meeresgrund? Justus muß sich gewaltig anstrengen, um schließlich das Geheimnis lüften zu können..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Constance"",
        ""Speaker"": ""Heidi Schaffrath""
      },
      {
        ""Character"": ""Slater"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""Donner"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Horst Frank""
      },
      {
        ""Character"": ""Fischer"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Ocean-World-Mitarbeiter"",
        ""Speaker"": ""Peter Lakenmacher, Christian Rode""
      }
    ]
  },
  {
    ""Id"": ""a047e13c-051c-405a-919b-b4aa0d5cba30"",
    ""Title"": ""... und der heimliche Hehler"",
    ""NumberEuropa"": 37,
    ""ReleaseDate"": ""1985-11-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/037.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein fünfjähriger Junge verschwindet. Wurde er entführt? Ist er weggelaufen? Die drei Detektive machen sich daran, die Frage zu klären. Und sie kommen weiteren Geheimnissen auf die Spur. Was verbirgt sich in dem alten Hotel? Warum maskiert sich Mr. Burton? Die drei ??? kommen zu einer überraschenden Lösung des Falles."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Regina"",
        ""Speaker"": ""Ursela Monn""
      },
      {
        ""Character"": ""Teddy"",
        ""Speaker"": ""Simon Jäger""
      },
      {
        ""Character"": ""Mrs. Peabody"",
        ""Speaker"": ""Gisela Trowe""
      },
      {
        ""Character"": ""Burton"",
        ""Speaker"": ""Günter Pfitzmann""
      },
      {
        ""Character"": ""Kommissar"",
        ""Speaker"": ""Günter Flesch""
      },
      {
        ""Character"": ""Mooch"",
        ""Speaker"": ""Joachim Richert""
      },
      {
        ""Character"": ""Mr. Conine"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Fergus"",
        ""Speaker"": ""Günther Dockerill""
      }
    ]
  },
  {
    ""Id"": ""8376546b-13c0-4fcc-b34e-754d1dc177b7"",
    ""Title"": ""... und der unsichtbare Gegner"",
    ""NumberEuropa"": 38,
    ""ReleaseDate"": ""1986-03-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/038.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ben Peck, Peters Großvater, hat eine Reihe von Erfindungen gemacht, und jetzt will er eine davon in New York verkaufen. Aber er hat ständig Angst, daß man ihm sein geistiges Eigentum stiehlt. Da ist vor allem Ed Snabel. Was hat dieser Mann vor. Warum verfolgt er Ben Peck. Die drei Detektive erleben eine atemberaubene Jagd quer durch Amerika..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs. Shaw"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Mr. Peck"",
        ""Speaker"": ""Wolfgang Völz""
      },
      {
        ""Character"": ""Ed Snabel"",
        ""Speaker"": ""Horst Naumann""
      },
      {
        ""Character"": ""Bartlett"",
        ""Speaker"": ""Jochen Sehrndt""
      },
      {
        ""Character"": ""FBI-Agent Anderson"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Passantin"",
        ""Speaker"": ""Ingrid Andree""
      }
    ]
  },
  {
    ""Id"": ""a2217410-5eee-4366-b971-f4ad99477e42"",
    ""Title"": ""... und die Perlenvögel"",
    ""NumberEuropa"": 39,
    ""ReleaseDate"": ""1986-03-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/039.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei Detektive \""finden\"" eine vergessene Brieftaube und damit beginnt ein geheimnisvolles Abenteuer, bei dem es um wertvolle Perlen und ermorderte Vögel geht. Die drei ??? stehen vor vielen Rätseln, aber sie geben nicht auf. - Doch dann richtet sich der Lauf einer Pistole auf sie."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Blinky"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Miss Melody"",
        ""Speaker"": ""Gisela Trowe""
      },
      {
        ""Character"": ""Frisbee"",
        ""Speaker"": ""Hans Paetsch""
      }
    ]
  },
  {
    ""Id"": ""c43041f9-b3b0-44dc-b2ea-42e3ba98055e"",
    ""Title"": ""... und der Automarder"",
    ""NumberEuropa"": 40,
    ""ReleaseDate"": ""1986-11-22T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/040.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""In Rocky Beach klirren die Autoscheiben, die ein geheimnisvoller Automarder serienweise zertrümmert. Und nicht nur das: ein \""Adler\"" verschwindet. Ein Fall, der selbst für die drei Detektive unlösbar zu sein scheint. Doch dann geht dem Ersten Detektiv ein Licht auf!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Jacobs"",
        ""Speaker"": ""Horst Naumann""
      },
      {
        ""Character"": ""Paul Jacobs"",
        ""Speaker"": ""Sascha Draeger""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Gottfried Kramer""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Ingeborg Kallweit""
      },
      {
        ""Character"": ""Mr. Temple"",
        ""Speaker"": ""Jochen Sehrndt""
      },
      {
        ""Character"": ""Sarah Temple"",
        ""Speaker"": ""Svenja Pages""
      },
      {
        ""Character"": ""Willard Temple"",
        ""Speaker"": ""Ben Becker""
      },
      {
        ""Character"": ""Polizeileutnant"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Hauptkomm. Reynolds"",
        ""Speaker"": ""Günter Flesch""
      },
      {
        ""Character"": ""Margon"",
        ""Speaker"": ""Henry Kielmann""
      },
      {
        ""Character"": ""William Margon"",
        ""Speaker"": ""Michael Grimm""
      },
      {
        ""Character"": ""Passanten"",
        ""Speaker"": ""Lothar Grützner, Hans Hessling""
      }
    ]
  },
  {
    ""Id"": ""da824de1-65fe-472e-9854-b83569f91249"",
    ""Title"": ""... und das Volk der Winde"",
    ""NumberEuropa"": 41,
    ""ReleaseDate"": ""1987-09-17T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/041.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der Wissenschaftler Arnold Brewster ruft die drei Detektive zu Hilfe, denn durch eine Intrige ist er in ein Altersheim abgeschoben worden. Justus, Bob und Peter versuchen, ihm zu helfen. Sie kommen dabei einem geheimnisvollen Geschehen auf die Spur, bei dem es um Indianer, Gold und einen rätselhaften \""Tanzenden Saurier\"" geht. Tödliche Gefahren lauern auf die drei ???..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Brewster"",
        ""Speaker"": ""Horst Naumann""
      },
      {
        ""Character"": ""Clifford"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Marie"",
        ""Speaker"": ""Svenja Pages""
      },
      {
        ""Character"": ""Zindler"",
        ""Speaker"": ""Karl Walter Diess""
      },
      {
        ""Character"": ""Pamir"",
        ""Speaker"": ""Manfred Steffen""
      },
      {
        ""Character"": ""Martin"",
        ""Speaker"": ""Frank-Dieter Tausch""
      },
      {
        ""Character"": ""Botin"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Kellner"",
        ""Speaker"": ""Helmut Ahner""
      }
    ]
  },
  {
    ""Id"": ""f131d4be-9fb3-4585-90ad-e7c2b511b7a1"",
    ""Title"": ""... und der weinende Sarg"",
    ""NumberEuropa"": 42,
    ""ReleaseDate"": ""1987-10-26T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/042.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei Detektive sind dem Geheimnis eines verborgenen Tresors auf der Spur. Der neugierige Michael ist es, der ihnen den ersten Tip gibt; drei Totenköpfe auf einem Sarg scheinen Wegweiser zu sein. Doch schnell wird es gefährlich, denn in der Nähe des Sargs ist es nich geheuer - schon gar nicht, wenn mitten in der Nacht das Käuzchen ruft..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Michael Cross"",
        ""Speaker"": ""Matthias Klimsa""
      },
      {
        ""Character"": ""Mrs. Cross"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Mr. Cross"",
        ""Speaker"": ""Horst Naumann""
      },
      {
        ""Character"": ""Grady Markels"",
        ""Speaker"": ""Gerd Baltus""
      },
      {
        ""Character"": ""Brackmann"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Margie"",
        ""Speaker"": ""Monika Gabriel""
      },
      {
        ""Character"": ""Nachrichtensprecher"",
        ""Speaker"": ""Karl Walter Diess Günter Flesch""
      },
      {
        ""Character"": ""Sawyer"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Museumsbesucherin"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Gärtner"",
        ""Speaker"": ""Günther Dockerill""
      },
      {
        ""Character"": ""Mr. Rossing"",
        ""Speaker"": ""Eric Vaessen""
      },
      {
        ""Character"": ""Rossings Assistentin"",
        ""Speaker"": ""Claudia Schermutzki""
      }
    ]
  },
  {
    ""Id"": ""14a46a32-ac2d-4aa4-a930-a8a913f94476"",
    ""Title"": ""... und der höllische Werwolf"",
    ""NumberEuropa"": 43,
    ""ReleaseDate"": ""1988-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/043.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein Werwolf macht Hollywood unsicher. Er verübt Überfall auf Überfall - und dabei geht es ihm nur um kleine Teddybären. Justus, Bob und Peter machen einen seltsamen Fund am Strand und kommen so auf die Spur des Verbrechers. Sie haben ihr vielleicht gefährlichstes Abenteuer zu bestehen..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Lucille"",
        ""Speaker"": ""Petra Kaminski [Julia Müller-Wesemann?]""
      },
      {
        ""Character"": ""Charles"",
        ""Speaker"": ""Henry Kielmann""
      },
      {
        ""Character"": ""McLain"",
        ""Speaker"": ""Rolf Jülich""
      },
      {
        ""Character"": ""Verleiher"",
        ""Speaker"": ""Hartmut Kollakowsky""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Sears"",
        ""Speaker"": ""Manfred Liptow""
      },
      {
        ""Character"": ""Evans"",
        ""Speaker"": ""Bernd Fallske""
      },
      {
        ""Character"": ""Pelzhändler"",
        ""Speaker"": ""Eric Vaessen""
      },
      {
        ""Character"": ""[Kom. Reynolds]"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Lucilles Mutter"",
        ""Speaker"": ""Astrid Kollex""
      },
      {
        ""Character"": ""Sekretärin"",
        ""Speaker"": ""Eva Gelb""
      },
      {
        ""Character"": ""Mädchen"",
        ""Speaker"": ""Veronika Neugebauer""
      },
      {
        ""Character"": ""Junge 1"",
        ""Speaker"": ""Manou Lubowski""
      },
      {
        ""Character"": ""Junge 2"",
        ""Speaker"": ""Niki Nowotny""
      }
    ]
  },
  {
    ""Id"": ""a5e054e7-62fc-48b9-8245-3b17f14b32ac"",
    ""Title"": ""... und der gestohlene Preis"",
    ""NumberEuropa"": 44,
    ""ReleaseDate"": ""1988-10-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/044.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die Vergangenheit holt Justus wieder ein. Er hat als Kind in dem Film \""Die kleinen Strolche\"" mitgespielt. Nun soll er noch einmal als Baby Fatso ins Licht der Öffentlichkeit treten. Das gefällt ihm überhaupt nicht. Doch plötzlich entwickelt sich ein Fall für die drei Detektive daraus und ihr Interesse ist geweckt. Vor allem, als sie erfahren, daß es um 20.000 Dollar geht."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Milton"",
        ""Speaker"": ""Horst Naumann""
      },
      {
        ""Character"": ""Bonehead"",
        ""Speaker"": ""Sascha Draeger""
      },
      {
        ""Character"": ""Peggy"",
        ""Speaker"": ""Veronika Neugebauer""
      },
      {
        ""Character"": ""Footsie"",
        ""Speaker"": ""Niki Nowotny""
      },
      {
        ""Character"": ""Bloodhound"",
        ""Speaker"": ""Manou Lubowski""
      },
      {
        ""Character"": ""Lomax"",
        ""Speaker"": ""Peter Pantel [Wolf Rahtjen]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Dorothea Kaiser""
      },
      {
        ""Character"": ""Gordon Harker"",
        ""Speaker"": ""Stefan Brönneke""
      }
    ]
  },
  {
    ""Id"": ""b5ae9553-d8ca-4005-80a8-e8f16ffd7707"",
    ""Title"": ""... und das Gold der Wikinger"",
    ""NumberEuropa"": 45,
    ""ReleaseDate"": ""1989-04-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/045.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Auf der Insel Ragnarson Rock geschehen geheimnisvolle Dinge. Fotos, die Bob gemacht hat, müssen der Schlüssel sein. Doch Justus, Bob und Peter - die drei Detektive - können zunächst nichts Besonderes darauf entdecken. Aber dann heult ein Wolf auf der Insel, und Justus spitzt die Ohren. Kommt er dem Geheimnis auf die Spur?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Ingmar Ragnarson"",
        ""Speaker"": ""Rolf E. Schenker""
      },
      {
        ""Character"": ""Karl Ragnarson"",
        ""Speaker"": ""Utz Richter""
      },
      {
        ""Character"": ""Sam Ragnarson"",
        ""Speaker"": ""Marco Kröger""
      },
      {
        ""Character"": ""Mr. Manning"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Mrs. Manning"",
        ""Speaker"": ""Julia Mahnkopf""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Mrs. Andrews"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Manfred Bendixen [Günter König]""
      },
      {
        ""Character"": ""Mathilda"",
        ""Speaker"": ""Ursula Vogel""
      }
    ]
  },
  {
    ""Id"": ""89fc29b7-7993-4f68-afda-b3b344581f5a"",
    ""Title"": ""... und der schrullige Millionär"",
    ""NumberEuropa"": 46,
    ""ReleaseDate"": ""1989-05-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/046.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Als bei der Verlobung seiner Tochter ein Teller zu Boden fällt, erleidet der geizige Millionär Pilcher einen Herzanfall. Er scheint dem Tode nahe, doch dann ist er plötzlich verschwunden. Wurde er entführt? Die drei Detektive versuchen, das Rätsel zu lösen, und Justus fordert seine Kollegen zum logischen Denken auf..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Harry Burnside"",
        ""Speaker"": ""Thomas Naumann""
      },
      {
        ""Character"": ""Millionär Pilcher"",
        ""Speaker"": ""Michael von Rospatt""
      },
      {
        ""Character"": ""Marilyn Pilcher"",
        ""Speaker"": ""Gabi Libbach""
      },
      {
        ""Character"": ""Sekretär Sanchez"",
        ""Speaker"": ""Walter Eltz""
      },
      {
        ""Character"": ""Harald Durham"",
        ""Speaker"": ""Ernst A. Frantz""
      },
      {
        ""Character"": ""Frau Durham"",
        ""Speaker"": ""Micaela Kreißler""
      },
      {
        ""Character"": ""Jim Westerbrook"",
        ""Speaker"": ""Michael Quiatkowsky""
      },
      {
        ""Character"": ""Mrs. Westerbrook"",
        ""Speaker"": ""Gerlinde Dillge""
      },
      {
        ""Character"": ""Dr. Gonzaga"",
        ""Speaker"": ""Manfred Liptow""
      },
      {
        ""Character"": ""Ramon Navarro"",
        ""Speaker"": ""Norbert Langer""
      }
    ]
  },
  {
    ""Id"": ""ea2617d0-c2e3-4eb5-add2-a0171c3b937c"",
    ""Title"": ""... und die Comic-Diebe"",
    ""NumberEuropa"": 49,
    ""ReleaseDate"": ""1990-11-26T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/049.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Auf der InterComiCon werden Comics von unersetzlichem Wert gestohlen, und die drei ??? stehen unmittelbar daneben. Sie versuchen, den Fall aufzukären, doch es erscheint zunächst unmöglich den Dieb zu finden. Dann aber ergibt sich eine Spur! Sofort reagiert der Dieb, und Peter entgeht nur ganz knapp einem tödlichen Anschlag..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Axel Griswold"",
        ""Speaker"": ""Helgo Liebig""
      },
      {
        ""Character"": ""Purvis"",
        ""Speaker"": ""Heiner Kramm""
      },
      {
        ""Character"": ""Dan DeMento"",
        ""Speaker"": ""Peter Heinrich [Peter Heinrich Brix?]""
      },
      {
        ""Character"": ""Leo Rottweiler"",
        ""Speaker"": ""Reiner Brönneke""
      },
      {
        ""Character"": ""Steve Trash"",
        ""Speaker"": ""Thomas Naumann""
      },
      {
        ""Character"": ""Rainey Fields"",
        ""Speaker"": ""Xenia Hey""
      },
      {
        ""Character"": ""Junge"",
        ""Speaker"": ""Leonhard Mahlich""
      }
    ]
  },
  {
    ""Id"": ""41672076-0267-4f54-af5e-e8829052bf15"",
    ""Title"": ""... und der verschwundene Filmstar"",
    ""NumberEuropa"": 50,
    ""ReleaseDate"": ""1991-03-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/050.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein Filmstar verschwindet - Diller Rourke, Hauptdarsteller im Horrorstreifen \""Atemlos II\"", erscheint nicht zu den Dreharbeiten auf dem Friedhof. Die Zentrale der drei ??? wird überfallen und verwüstet. Trotzdem heften sie sich an die Fersen von Erfolgsproduzent Marty Morningbaum, seinem Regisseur und dem mysteriösen Kristallkugel-Guru mit dem dritten Auge. Eine knallharte Betrugsgeschichte, live aus dem glitzernden Show-Geschäft."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Jon Travis"",
        ""Speaker"": ""Rolf Becker""
      },
      {
        ""Character"": ""Marty Morningbaum"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""Diller Rourke"",
        ""Speaker"": ""Michael Quiatkowsky""
      },
      {
        ""Character"": ""Marble Ackbourne-Smith"",
        ""Speaker"": ""Wolf Rahtjen""
      },
      {
        ""Character"": ""Margo"",
        ""Speaker"": ""Hanni Vanhaiden""
      },
      {
        ""Character"": ""Kevin"",
        ""Speaker"": ""Fred Maire""
      },
      {
        ""Character"": ""Herr Andrews"",
        ""Speaker"": ""Günter König""
      }
    ]
  },
  {
    ""Id"": ""ccef3034-6ad0-4c72-90a2-bcda204014e1"",
    ""Title"": ""... und der riskante Ritt"",
    ""NumberEuropa"": 51,
    ""ReleaseDate"": ""1991-03-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/051.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Caramba! Wie heiß brennt die Sonne in den Bergen der Sierra Madre! Wäre da nicht der Silberschatz aus den Zeiten der Revolution, kein Mensch würde hier auf störrischen Wildeseln zwischen Kakteen und Buschwerk herumreiten. Ein brummelnder Vulkan, der jeden Moment ausbrechen kann, macht die Sache auch nicht gemütlicher. Selten haben die drei ??? ein so gefährliches Abenteuer erlebt."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mercedes"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Brit"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Dusty Rice"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Ascension"",
        ""Speaker"": ""Eckart Dux""
      }
    ]
  },
  {
    ""Id"": ""689e14e1-7ee9-4d0f-b5d1-fc54a496bd9c"",
    ""Title"": ""... und die Musikpiraten"",
    ""NumberEuropa"": 52,
    ""ReleaseDate"": ""1991-07-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/052.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Schlägerei auf dem Vergnügungsfest, Überfall auf Bob und eine nächtliche Verfolgungsjagd - es sieht ganz so aus, als sei der junge Detektiv zwischen zwei rivalisierende Gaunerbanden geraten. Die heiße Spur führt zur Plattenfirma Galactic Sound. Hier sind auf mysteriöse Weise Masterbänder verschwunden. Aber wie schmuggeln die Musikpiraten die Aufnahmen aus dem Haus?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Brick"",
        ""Speaker"": ""Rainer Schmitt""
      },
      {
        ""Character"": ""Thanom"",
        ""Speaker"": ""Peter Heinrich [Peter Heinrich Brix?]""
      },
      {
        ""Character"": ""Prem"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Butler"",
        ""Speaker"": ""Gerd Baltus""
      },
      {
        ""Character"": ""Sax"",
        ""Speaker"": ""Andreas Mannkopff""
      },
      {
        ""Character"": ""Celeste"",
        ""Speaker"": ""Michaela Gröger""
      },
      {
        ""Character"": ""Lara"",
        ""Speaker"": ""Gerlach Fiedler""
      },
      {
        ""Character"": ""Rivers"",
        ""Speaker"": ""Wolfgang Völz""
      },
      {
        ""Character"": ""Hansen"",
        ""Speaker"": ""Verena Wiet""
      },
      {
        ""Character"": ""Maxi"",
        ""Speaker"": ""Hildegard Krekel""
      },
      {
        ""Character"": ""Quill"",
        ""Speaker"": ""Matthias Bullach""
      },
      {
        ""Character"": ""Tony"",
        ""Speaker"": ""Michael Quiatkowsky""
      }
    ]
  },
  {
    ""Id"": ""23523b90-3b82-4e7c-93af-c14895872c3e"",
    ""Title"": ""... und die Automafia"",
    ""NumberEuropa"": 53,
    ""ReleaseDate"": ""1991-07-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/053.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Mit Autos kennt sich Justus' Vetter Ty Cassey einfach phantastisch aus. Ein bißchen zu gut, findet Kommissar Maxim vom Sonderdezernat Autodiebstähle und nimmt den verdächtigen jungen Mann vorläufig fest. Zugegeben, der geniale Mechaniker in den abgerissenen Klamotten, der die meiste Zeit durch die Gegend trampt, wirkt schon etwas ausgeflippt -- aber ein Autodieb? Die drei ??? setzen alles dran, Tys Unschuld zu beweisen. Dabei bekommen sie es mit ausgekochten Profis zu tun, die vor nichts zurückschrecken."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""Ty Cassey"",
        ""Speaker"": ""Stefan Brönneke""
      },
      {
        ""Character"": ""Inspektor Cole"",
        ""Speaker"": ""Wolfgang Schimmelpfennig [Günter König]""
      },
      {
        ""Character"": ""Kommissar Maxim"",
        ""Speaker"": ""Peter Matic""
      },
      {
        ""Character"": ""Gilbar"",
        ""Speaker"": ""Rolf Becker""
      },
      {
        ""Character"": ""Torres"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Jake Hatch"",
        ""Speaker"": ""Hans Barein""
      },
      {
        ""Character"": ""Tiburon"",
        ""Speaker"": ""Michael Quiatkowsky""
      }
    ]
  },
  {
    ""Id"": ""d5684805-3caa-4863-9575-e8e6649e882f"",
    ""Title"": ""Gefahr im Verzug"",
    ""NumberEuropa"": 54,
    ""ReleaseDate"": ""1992-02-17T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/054.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Anonyme Drohungen, umstürzende Kulissen, herumliegende Rasierklingen, eine Explosion: Es ist offensichtlich, das irgend jemand George Brandon nach dem Leben trachtet. Der Star des Musicals Gefahr im Verzug entgeht den mysteriösen Unfällen nur um Haaresbreite. Aber die Show läuft weiter und entwickelt sich sogar zum Kassenschlager. Um unauffällig ermitteln zu können, schleusen sich Justus, Peter und Kelly, als Statisten getarnt, in den Theaterbetrieb ein."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""Buzz Newman"",
        ""Speaker"": ""Christian Weber [Manou Lubowski]""
      },
      {
        ""Character"": ""George Brandon"",
        ""Speaker"": ""Fabian Harloff""
      },
      {
        ""Character"": ""Jim Bernardie"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Firestone"",
        ""Speaker"": ""Peter Schiff""
      },
      {
        ""Character"": ""Crocker"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Lovell Madeira"",
        ""Speaker"": ""Rainer Schmitt""
      },
      {
        ""Character"": ""Vic Hammell"",
        ""Speaker"": ""Ben Tappé""
      },
      {
        ""Character"": ""Dan"",
        ""Speaker"": ""Henry König""
      }
    ]
  },
  {
    ""Id"": ""d8119596-198a-4036-ab92-ba25aa3b081f"",
    ""Title"": ""Gekaufte Spieler"",
    ""NumberEuropa"": 55,
    ""ReleaseDate"": ""1992-02-17T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/055.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Kaum zu fassen! Trainer Duggan bietet Peter das begehrte Stipendium am Shoremont College an. Die einzige Bedingung: Er soll in der dortigen Basketball-Mannschaft mitspielen. Das ist die Chance für den begeisterten Sportler. Wenig später findet er einen dicken Briefumschlag mit Hundert-Dollar-Scheinen in seinem Auto. Wie sich herausstellt, ist Peter nicht der einzige, der Bestechungsgelder erhält. Was steckt dahinter? Um den Skandal der gekauften Spieler aufzudecken, wird Justus sogar zum Papagei."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""Trainer Tong"",
        ""Speaker"": ""Michael Harck""
      },
      {
        ""Character"": ""Trainer Duggan"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Präsident Harper"",
        ""Speaker"": ""Eric Vaessen""
      },
      {
        ""Character"": ""Jerri"",
        ""Speaker"": ""Samira Chanfir""
      },
      {
        ""Character"": ""Nora"",
        ""Speaker"": ""Ann Montenbruck""
      },
      {
        ""Character"": ""Cory"",
        ""Speaker"": ""Ben Tappé""
      },
      {
        ""Character"": ""Norman"",
        ""Speaker"": ""Henry König""
      },
      {
        ""Character"": ""Powers"",
        ""Speaker"": ""Hans Clarin""
      }
    ]
  },
  {
    ""Id"": ""1f55d549-ba70-4053-ab1f-d1cdb05d1327"",
    ""Title"": ""Angriff der Computer-Viren"",
    ""NumberEuropa"": 56,
    ""ReleaseDate"": ""1992-09-14T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/056.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Kein Mensch kann von Computer-Viren angesteckt werden, aber ein viruskranker Computer kann tausende Menschenleben gefährden! Das erkennen unsere drei Detektive, als ihr eigener Computer \""abstürzt\"". Sie handeln sofort. Ihr Nachforschungen führen sie in die abenteuerliche Welt einer Werbefilmproduktion und ... auf die Spur eines genialen Spinners, der leider auch ein gefährlicher Erpresser ist. Ein Fall für die drei ???, und ganz speziell für Justus, den Computer-Freak!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""Liz"",
        ""Speaker"": ""Verena Großer""
      },
      {
        ""Character"": ""Harold"",
        ""Speaker"": ""Willi Röbke""
      },
      {
        ""Character"": ""Dose"",
        ""Speaker"": ""Jan-Friedrich Conrad""
      },
      {
        ""Character"": ""Silas Ek"",
        ""Speaker"": ""Hans Sievers""
      },
      {
        ""Character"": ""Sekretär"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""Jan"",
        ""Speaker"": ""Stefan Brönneke""
      },
      {
        ""Character"": ""Lys"",
        ""Speaker"": ""Annika Pages""
      },
      {
        ""Character"": ""Branson Barr"",
        ""Speaker"": ""Michael Harck""
      },
      {
        ""Character"": ""Norton Rome"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Feuerwehrmann"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""6de1755c-eee2-4eab-9c52-e51f8ba2b846"",
    ""Title"": ""Tatort Zirkus"",
    ""NumberEuropa"": 57,
    ""ReleaseDate"": ""1994-07-14T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/057.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Panik im Zirkus: Die junge Artistin Mary di Domenico stürzt während der Abendvorstellung vom Drahtseil. Für Justus, Bob und Peter steht fest: das war kein Unfall! Immerhin gilt Mary als Erbin der wertvollen Sammlung von dem berühmten Clown Jacky Knivel. Die drei Juniordetektive sind bereit, den Fall zu übernehmen, und schon stehen sie vor einem Rätsel: Ist ihre Auftraggeberin wirklich so unschuldig, wie sie behauptet?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mary, Artistin"",
        ""Speaker"": ""Heidrun von Goessel""
      },
      {
        ""Character"": ""Winkler, Zirkusdirektor"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""Pipo, Clown"",
        ""Speaker"": ""Arthur Brauss""
      },
      {
        ""Character"": ""Morton, Chauffeur"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Cotta, Polizeiinspektor"",
        ""Speaker"": ""Michael Poelchau""
      },
      {
        ""Character"": ""Alma"",
        ""Speaker"": ""Eva Zlonitzky""
      },
      {
        ""Character"": ""Schwester"",
        ""Speaker"": ""Gerda-Maria Jürgens""
      },
      {
        ""Character"": ""[Shirley Kubinski]"",
        ""Speaker"": ""Thea Frank""
      }
    ]
  },
  {
    ""Id"": ""6dec7c23-c105-4588-98f0-4149ab2efad5"",
    ""Title"": ""... und der verrückte Maler"",
    ""NumberEuropa"": 58,
    ""ReleaseDate"": ""1994-07-18T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/058.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Tante Mathilda ist wütend! Wie kann Onkel Titus es nur wagen, dieses grauenhafte Gemälde einfach in ihr Wohnzimmer zu hängen! Noch in der selben Nacht versucht jemand, den Ölschinken zu klauen. Grund genug für Justus, Bob und Peter sich einzuschalten. Drohanrufe, nächtliche Überfälle und eine verdächtige Safefirma führen die drei jungen Detektive übers Meer zu einem einsam gelegenen Haus an der Küste. Dort erwartet sie eine gefährliche Überraschung."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""William Ashley"",
        ""Speaker"": ""Franz Rudnick""
      },
      {
        ""Character"": ""Burt Ashley"",
        ""Speaker"": ""Knut Basewitz""
      },
      {
        ""Character"": ""Pecker, Angestellter"",
        ""Speaker"": ""Lutz Büschken [Uwe Büschken?]""
      },
      {
        ""Character"": ""Axel"",
        ""Speaker"": ""Tobias Pauls""
      },
      {
        ""Character"": ""Lys"",
        ""Speaker"": ""Kerstin Draeger""
      },
      {
        ""Character"": ""Mrs. Bloomingdale"",
        ""Speaker"": ""Eva Zlonitzky""
      },
      {
        ""Character"": ""Stella"",
        ""Speaker"": ""Rebecca Völz""
      }
    ]
  },
  {
    ""Id"": ""3a9254fd-e7f0-4ff5-8e4f-9f60b8d82782"",
    ""Title"": ""Giftiges Wasser"",
    ""NumberEuropa"": 59,
    ""ReleaseDate"": ""1994-08-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/059.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die Nachricht trifft Justus, Peter und Bob wie eine Bombe: Ein Unbekannter droht, daß gesamte Trinkwasser des verschlafenen Touristenstädtchens Sedona zu vergiften. Sollte das geplante Rockfestival nicht abgesagt werden? Die Polizei ist ratlos. Die drei ??? übernehmen den Fall und geraten bald in brenzlige Situationen. Da meldet sich der Erpresser erneut - das Ultimatum läuft ab."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Ruth, Zeitungs-Journalistin"",
        ""Speaker"": ""Hansi Jochmann""
      },
      {
        ""Character"": ""Jean Baxter, TV-Journalistin"",
        ""Speaker"": ""Heidrun von Goessel""
      },
      {
        ""Character"": ""Van Well, Pressechef"",
        ""Speaker"": ""Ulrich Faulhaber""
      },
      {
        ""Character"": ""Sinagua, Indianerin"",
        ""Speaker"": ""Samira Chanfir""
      },
      {
        ""Character"": ""Chosmo, Journalist"",
        ""Speaker"": ""Matthias Bullach""
      },
      {
        ""Character"": ""Monsieur Jaubert"",
        ""Speaker"": ""Michael Poelchau""
      },
      {
        ""Character"": ""René Hancock"",
        ""Speaker"": ""Thomas Schüler""
      },
      {
        ""Character"": ""Joan Brown"",
        ""Speaker"": ""Rebecca Völz""
      },
      {
        ""Character"": ""Hendrik Walton, Fabrikant"",
        ""Speaker"": ""Karl Michael Mechel""
      }
    ]
  },
  {
    ""Id"": ""e649ce29-62f3-4d23-83f9-f77e6d2dfb39"",
    ""Title"": ""Dopingmixer"",
    ""NumberEuropa"": 60,
    ""ReleaseDate"": ""1994-08-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/060.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Sport läßt Justus normalerweise kalt. Besonders, wenn er an einem neuen Fall arbeitet. Aber was er da auf dem Sportplatz der Highschool von Rocky Beach erlebt, macht ihn stutzig. Einer der Jungs, die mit Peter für das Sportfest trainieren, läuft sensationell schnell! Und kaum versuchen die drei ???, der Sache auf den Grund zu gehen, taucht der Sprinter unter. Opfer gewinnsüchtiger Manager oder selbst ein gewiefter Dopingbetrüger? Wer hat da seine Finger im Spiel?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Glenn Miles"",
        ""Speaker"": ""Christian Stark""
      },
      {
        ""Character"": ""Benny"",
        ""Speaker"": ""Tobias Pauls""
      },
      {
        ""Character"": ""Tom Descanso, Trainer"",
        ""Speaker"": ""Justus Frantz""
      },
      {
        ""Character"": ""Field, Lehrer"",
        ""Speaker"": ""Michael Quiatkowsky""
      },
      {
        ""Character"": ""Hutchins, Sport-Reporter"",
        ""Speaker"": ""Uwe Büschken""
      },
      {
        ""Character"": ""Dr. Landman, Schuldirektor"",
        ""Speaker"": ""Gerd Duwner""
      },
      {
        ""Character"": ""Stan"",
        ""Speaker"": ""Tilman Madaus""
      },
      {
        ""Character"": ""Eleonore Sharp"",
        ""Speaker"": ""Margot Linde""
      }
    ]
  },
  {
    ""Id"": ""001453f9-ea60-4ad6-97fc-f206dfb773f1"",
    ""Title"": ""Spuk im Hotel"",
    ""NumberEuropa"": 62,
    ""ReleaseDate"": ""1995-02-27T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/062.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Seltsame Dinge geschehen im Hotel der exzentrischen Amanda Black. Ein Unbekannter treibt seine Spielchen mit der ehemaligen Schauspielerin. Über Nacht verschwinden Erinnerungsstücke, die an denkbar merkwürdigen Stellen wieder auftauchen. Doch als schließlich ein Nebengebäude in Flammen aufgeht, sind sich Justus, Peter und Bob einig: Das ist bitterer Ernst! Die drei ??? entschließen sich, dem Täter eine Falle zu stellen."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Amanda Black"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Mrs. Silverstone"",
        ""Speaker"": ""Barbara Ratthey""
      },
      {
        ""Character"": ""Mr. Garfield"",
        ""Speaker"": ""Holger Mahlich [Utz Richter]""
      },
      {
        ""Character"": ""Mr. Hartford"",
        ""Speaker"": ""Hans Hessling""
      },
      {
        ""Character"": ""Mrs. Hartford"",
        ""Speaker"": ""Ursula Sieg""
      },
      {
        ""Character"": ""Mrs. Green"",
        ""Speaker"": ""Monika Werner""
      },
      {
        ""Character"": ""Henry"",
        ""Speaker"": ""Lutz Schnell""
      },
      {
        ""Character"": ""Lys"",
        ""Speaker"": ""Kerstin Draeger""
      },
      {
        ""Character"": ""Linda"",
        ""Speaker"": ""Janina Richter""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Willem Fricke""
      }
    ]
  },
  {
    ""Id"": ""2d76ec40-5cf7-475c-b6d7-dfbdc4b2995c"",
    ""Title"": ""Fußball-Gangster"",
    ""NumberEuropa"": 63,
    ""ReleaseDate"": ""1995-08-28T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/063.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Welches Interesse könnte ein Lebensmittelkonzern daran haben, eine ganze Fußballmannschaft unter seine Kontrolle zu bringen? Jimboy, Justus' Cousin, hat sich mächtig verändert, seit er Stürmer in dieser Elf ist. Und zwar nicht zu seinem Vorteil. Die drei ??? merken bald den Zusammenhang zwischen Jimboys Schweigsamkeit und seinen Erlebnissen im streng bewachten Trainingslager. Aber kaum haben sie Erfolg bei ihren Erkundigungen, schaltet sich Inspektor Cotta ein. Justus, Peter und Bob sollen die Finger von dem brandheißen Fall lassen. Das sehen die drei ??? entschieden anders..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Jimboy-Jonas"",
        ""Speaker"": ""Frank Meyer-Brockmann""
      },
      {
        ""Character"": ""Mr. Bow"",
        ""Speaker"": ""Klaus Sonnenschein""
      },
      {
        ""Character"": ""Eric Randolph"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Elizabeth"",
        ""Speaker"": ""Verena Großer""
      },
      {
        ""Character"": ""Lys"",
        ""Speaker"": ""Kerstin Draeger""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Tamara Mostowsky"",
        ""Speaker"": ""Astrid Kollex""
      }
    ]
  },
  {
    ""Id"": ""b065baf7-264d-40ea-8dc1-a5569571c0f0"",
    ""Title"": ""Geisterstadt"",
    ""NumberEuropa"": 64,
    ""ReleaseDate"": ""1995-08-28T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/064.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Über Nacht wird aus harmlosen Skiferien in den Bergen ein gefährliche Suche im Kriminalfall Oames. Der Gastgeber der drei ???, der berühmte Spieleverleger Michael Julius Oames, ist entführt worden. Die Kidnapper fordern eine Million Dollar. Eine Menge Geld, finden Justus, Bob und Peter und beschließen, der Polizei von Lake Tahoe unter die Arme zu greifen. Kann Oames Vergangenheit Licht in die Sache bringen? Da stoßen sie auf eine heiße Spur. Sie führt direkt in eine Geisterstadt."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Peter Pasetti""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Morton, Chauffeur"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Inspektor Capistrano"",
        ""Speaker"": ""Hans Sievers""
      },
      {
        ""Character"": ""Sergeant Hawthrone"",
        ""Speaker"": ""Jürgen Kopp""
      },
      {
        ""Character"": ""Simon Oames"",
        ""Speaker"": ""Peter Kirchberger""
      },
      {
        ""Character"": ""Silvie Oames"",
        ""Speaker"": ""Edith Hancke""
      },
      {
        ""Character"": ""Michael Julius Oames"",
        ""Speaker"": ""Günther Jerschke""
      },
      {
        ""Character"": ""Mandy Taylor"",
        ""Speaker"": ""Micaela Kreißler""
      },
      {
        ""Character"": ""Deborah Street"",
        ""Speaker"": ""Astrid Kollex""
      },
      {
        ""Character"": ""Greenwater"",
        ""Speaker"": ""Norman Messer""
      }
    ]
  },
  {
    ""Id"": ""fe1632e2-3b60-4953-a177-624bd85ff50e"",
    ""Title"": ""Diamantenschmuggel"",
    ""NumberEuropa"": 65,
    ""ReleaseDate"": ""1995-12-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/065.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ihren ersten Trip nach Europa haben sich Justus, Peter und Bob anders vorgestellt: Statt der erwarteten Vergnügungstour durch London werden sie in einen Diamantenschmuggel verwickelt und sogar - natürlich unfreiwillig und zunächst völlig ahnungslos - als Kuriere der heißen Ware benutzt. Schnell wird ihnen klar, daß die Reisegesellschaft, mit der sie einen Ausflug nach Rotterdam unternehmen, nicht nur aus erlebnishungrigen Touristen besteht. Welche Rolle spielt zum Beispiel der tolpatschige Mr. Thomas? Steckt er hinter den anonymen Briefen? Doch von solchen Einschüchterungsversuchen lassen sich die drei ??? bestimmt nicht abschrecken!"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Alex Burlington"",
        ""Speaker"": ""Klaus Sonnenschein""
      },
      {
        ""Character"": ""Richard Applebloome"",
        ""Speaker"": ""Tilman Madaus""
      },
      {
        ""Character"": ""Robert Applebloome"",
        ""Speaker"": ""Franz Rudnick""
      },
      {
        ""Character"": ""Mary"",
        ""Speaker"": ""Edith Hancke""
      },
      {
        ""Character"": ""Elizabeth"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""John Smith"",
        ""Speaker"": ""Dirk Anton""
      },
      {
        ""Character"": ""Jenkins"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Thomas"",
        ""Speaker"": ""Stephan Chrzescinski""
      },
      {
        ""Character"": ""Andrew"",
        ""Speaker"": ""Michael von Rospatt""
      },
      {
        ""Character"": ""Mrs. Rodriguez"",
        ""Speaker"": ""Katja Brügger""
      },
      {
        ""Character"": ""Hoteldirektor"",
        ""Speaker"": ""Hans Sievers""
      },
      {
        ""Character"": ""Blondine"",
        ""Speaker"": ""Veronika Neugebauer""
      }
    ]
  },
  {
    ""Id"": ""b493babd-138e-47b7-a23b-dba9a5d77706"",
    ""Title"": ""... und die Schattenmänner"",
    ""NumberEuropa"": 66,
    ""ReleaseDate"": ""1995-12-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/066.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Aus einem harmlosen Ausflug nach Rom wird für die drei ??? ein ganz heißer Fall. Direkt vor ihren Augen ereignen sich dreiste Überfälle an sorglosen Spaziergängern. Die Geschwindigkeit und Routine der Diebstähle macht klar: Hier sind Profis am Werk. Keine Frage, daß Justus, Peter und Bob die Verfolgung aufnehmen. Als sie jedoch den wahren Drahtziehern auf die Spur kommen, wird die Situation für sie mehr als brenzlig..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Alberto Bergamelli, Fotograf"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Alexandra"",
        ""Speaker"": ""Reinhilt Schneider""
      },
      {
        ""Character"": ""Ignazio, Pensionswirt"",
        ""Speaker"": ""Leonardo Cuseneza""
      },
      {
        ""Character"": ""Sofia, Pensionswirtin"",
        ""Speaker"": ""Maria Chirivi""
      },
      {
        ""Character"": ""Franca"",
        ""Speaker"": ""Samira Chanfir""
      },
      {
        ""Character"": ""Italienerin"",
        ""Speaker"": ""Francesca Chiavon""
      },
      {
        ""Character"": ""1. Italiener"",
        ""Speaker"": ""Marcello Grassi""
      },
      {
        ""Character"": ""2. Italiener"",
        ""Speaker"": ""Luigi Pane""
      }
    ]
  },
  {
    ""Id"": ""4c64ff03-d04b-42bd-9450-19b2c1f826c6"",
    ""Title"": ""... und das Geheimnis der Särge"",
    ""NumberEuropa"": 67,
    ""ReleaseDate"": ""1996-04-29T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/067.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Haarsträubende Dinge erzählt man sich von den berühmten Höhlenlabyrinthen auf der schwäbischen Alb, aber natürlich ist davon nur die Hälfte wahr. Doch Justus, Peter und Bob, die drei Junior-Detektive aus Rocky Beach, beginnen an Spukgeschichten zu glauben, als sie in der Geisterhöhle urplötzlich eine grausige Entdeckung machen..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Babette Eberle"",
        ""Speaker"": ""Michael von Rospatt""
      },
      {
        ""Character"": ""Bruder Benedikt"",
        ""Speaker"": ""Tassilo Jelde""
      },
      {
        ""Character"": ""Mylná"",
        ""Speaker"": ""Utz Richter""
      },
      {
        ""Character"": ""Alexandra"",
        ""Speaker"": ""Reinhilt Schneider""
      },
      {
        ""Character"": ""Wirt"",
        ""Speaker"": ""Hans Paetsch""
      },
      {
        ""Character"": ""Wirtin"",
        ""Speaker"": ""Ingeborg Ottmann""
      },
      {
        ""Character"": ""Max"",
        ""Speaker"": ""Lutz Schnell""
      },
      {
        ""Character"": ""1. Polizist"",
        ""Speaker"": ""Boris von Sychowski""
      },
      {
        ""Character"": ""2. Polizist"",
        ""Speaker"": ""Frank Meyer-Brockmann""
      }
    ]
  },
  {
    ""Id"": ""a51a0190-6506-4c8a-a0f1-e87e2030c154"",
    ""Title"": ""... und der Schatz im Bergsee"",
    ""NumberEuropa"": 68,
    ""ReleaseDate"": ""1996-04-29T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/068.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine brenzlige Situation für Justus, Peter und Bob: Ihr Rundflug über die Schweizer Alpen endet jäh mit einer Bruchlandung. Der Pilot ist bewußtlos, das Funkgerät zerstört. Plötzlich landet ein Helikopter neben ihnen. Bewaffnete Männer fesseln und knebeln Bob, und die drei ??? müssen hilflos zusehen, wie die Gangster das Flugzeugwrack durchsuchen. Wenig später verschwinden sie wieder. Die drei Junior-Detektive können sich in Sicherheit bringen. Doch dann kommen die Gangster zurück..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Jerzy"",
        ""Speaker"": ""Michael Bideller""
      },
      {
        ""Character"": ""Mariana"",
        ""Speaker"": ""Antje Roosch""
      },
      {
        ""Character"": ""1. Mann"",
        ""Speaker"": ""Nicolas König""
      },
      {
        ""Character"": ""2. Mann"",
        ""Speaker"": ""Lutz Schnell""
      }
    ]
  },
  {
    ""Id"": ""844332d7-5ae6-4bcc-a6bb-47627ca84d51"",
    ""Title"": ""Späte Rache"",
    ""NumberEuropa"": 69,
    ""ReleaseDate"": ""1996-08-05T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/069.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""\""Wir haben Peter! Er muß für alles bezahlen!\"" Ein anonymer Brief schreckt Justus und Bob auf. Eigene Nachforschungen nach dem Schicksal ihres Zweiten Detektivs bleiben ergebnislos, deshalb wenden sie sich hilfesuchend an die Polizei von Rocky Beach. Ihr Freund Inspektor Cotta schlägt vor, eine Polizeipsychologin hinzuzuziehen. Sie soll aus dem Bekennerschreiben Hinweise auf den Charakter des Täters herauslesen. Und tatsächlich kommt die Expertin zu einem überraschenden Schluß: Hinter der Entführung steckt ein lange zurückliegender Fall der drei Detektive. Justus und Bob durchforsten ihr umfangreiches Archiv. Denn die Zeit läuft..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Erna Fiedler"",
        ""Speaker"": ""Ursula Gompf""
      },
      {
        ""Character"": ""Dr. Ferguson"",
        ""Speaker"": ""Antje Cornelius""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""John Brady"",
        ""Speaker"": ""Dirk Anton""
      },
      {
        ""Character"": ""Matt Brady"",
        ""Speaker"": ""Volker Bogdan""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Mr. Shaw"",
        ""Speaker"": ""Eberhard Haar""
      },
      {
        ""Character"": ""Mrs. Shaw"",
        ""Speaker"": ""Heikedine Körting""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""4de359e9-5239-4cba-ae2c-5112a4dcf845"",
    ""Title"": ""Schüsse aus dem Dunkel"",
    ""NumberEuropa"": 70,
    ""ReleaseDate"": ""1996-08-05T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/070.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Mit einer flotten Bühnenshow präsentiert die erfolgreiche Modedesignerin Sally Samson ihre neue Kollektion. Bei der Westernmode passiert es: Ein Model bricht, von einem Schuß getroffen, zusammen. Ein kaltblütiger Anschlag? Wem war die junge Frau im Weg? Oder war es ein Ablenkungsmanöver? Gibt es eine Verbindung zwischen dem Schuß und den geraubten Entwürfen aus Sally Samsons Tresor? Für Justus, Peter und Bob, die drei erfolgreichen Detektive aus Rocky Beach, gibt es nur eine Möglichkeit, dem Täter auf die Spur zu kommen: Sie müssen sich als Model bewerben."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Alan"",
        ""Speaker"": ""Oliver Reinhardt""
      },
      {
        ""Character"": ""Sally Samson"",
        ""Speaker"": ""Cornelia Meinhardt""
      },
      {
        ""Character"": ""Sofie Samson"",
        ""Speaker"": ""Samira Chanfir""
      },
      {
        ""Character"": ""Dr. Harris"",
        ""Speaker"": ""Hansi Jochmann""
      },
      {
        ""Character"": ""John Davis"",
        ""Speaker"": ""Tim Wieck""
      },
      {
        ""Character"": ""Homer Washington"",
        ""Speaker"": ""Hans Sievers""
      },
      {
        ""Character"": ""Fahrer"",
        ""Speaker"": ""Klaus-Peter Kaehler""
      },
      {
        ""Character"": ""Brenda"",
        ""Speaker"": ""Micaela Kreißler""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Junge"",
        ""Speaker"": ""Jona Mues""
      }
    ]
  },
  {
    ""Id"": ""70b3ad7f-7312-4a4b-a7cd-55376f53817d"",
    ""Title"": ""... und die verschwundene Seglerin"",
    ""NumberEuropa"": 71,
    ""ReleaseDate"": ""1996-10-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/071.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Was geschah mit Irma Bannister? Von einem Segelausflug mit Freunden kehrte die beliebte Antiquitätenhändlerin nicht mehr zurück. Doch die Trauer der Hinterbliebenen hält sich in Grenzen. Die drei Detektive aus Rocky Beach wittern einen brisanten Fall und nehmen die Fährte auf. Doch ihre Recherchen enden in einer Sackgasse, die Betroffenen schweigen. Was ist tatsächlich passiert?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mrs. Lu Kwan"",
        ""Speaker"": ""Susanne von Loessl""
      },
      {
        ""Character"": ""Jefferson"",
        ""Speaker"": ""Christian Redl""
      },
      {
        ""Character"": ""Dimitrios, Bankdirektor"",
        ""Speaker"": ""Wilhelm Wieben""
      },
      {
        ""Character"": ""Dan Jordan, Reporter"",
        ""Speaker"": ""Michael Lott""
      },
      {
        ""Character"": ""Olivia"",
        ""Speaker"": ""Eva Weissmann""
      },
      {
        ""Character"": ""Santoria"",
        ""Speaker"": ""Holger Ohlendieck""
      },
      {
        ""Character"": ""Portier"",
        ""Speaker"": ""Johann Herstermann""
      },
      {
        ""Character"": ""Sergeant"",
        ""Speaker"": ""Ingvar Jensen""
      },
      {
        ""Character"": ""Irma"",
        ""Speaker"": ""Konstanze Ullmer""
      }
    ]
  },
  {
    ""Id"": ""ec631b59-d5e3-416e-8174-5d73b49f1e93"",
    ""Title"": ""Dreckiger Deal"",
    ""NumberEuropa"": 72,
    ""ReleaseDate"": ""1996-10-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/072.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Kings Cafe ist für die Schülerinnen und Schüler der High School von Rocky Beach ein beliebter Treffpunkt: Der freundliche Besitzer Malcolm King hat immer ein offenes Ohr für sie und hilft, wo er kann. Deshalb ist es ein großer Schock für sie, als King plötzlich verhaftet wird. Die Polizei hat in seinem Laden Rauschgift gefunden. Justus, Peter und Bob, die drei jungen Detektive, wollen King helfen. Aber sie wissen nicht, worauf sie sich da eingelassen haben."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Laura McLaughin"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Malcolm King"",
        ""Speaker"": ""Jörg Gillner""
      },
      {
        ""Character"": ""Lansana King"",
        ""Speaker"": ""Sabine Hahn""
      },
      {
        ""Character"": ""Hester Dalton"",
        ""Speaker"": ""Marianne Bernhardt""
      },
      {
        ""Character"": ""Billie"",
        ""Speaker"": ""Stefan Conradi""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Oliver Reinhardt""
      },
      {
        ""Character"": ""Wachmann"",
        ""Speaker"": ""Dieter Ohlendiek""
      },
      {
        ""Character"": ""2. Wächter"",
        ""Speaker"": ""Michael Lott""
      },
      {
        ""Character"": ""1. Polizist"",
        ""Speaker"": ""Torben Liebrecht""
      },
      {
        ""Character"": ""2. Polizist"",
        ""Speaker"": ""Rene Spiegelberger""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Doris Jahn""
      },
      {
        ""Character"": ""Kundin"",
        ""Speaker"": ""Susann Jarling""
      }
    ]
  },
  {
    ""Id"": ""9feff321-0c23-4ec2-9bd0-447861705116"",
    ""Title"": ""Poltergeist"",
    ""NumberEuropa"": 73,
    ""ReleaseDate"": ""1997-02-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/073.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Unheimliches geschieht im Haus von Mrs. Cartier: Klopfzeichen ertönen, Möbel bewegen sich, Tassen fliegen durch die Luft. Ein Fall ganz nach dem Geschmack von Justus, Peter und Bob! Die anfängliche Begeisterung der Detektive verwandelt sich aber bald in Angst und Entsetzen. Treibt da tatsächlich ein Poltergeist sein Unwesen? Eine natürliche Erklärung für diese Phänomene scheint es nicht zu geben..."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs. Madigan"",
        ""Speaker"": ""Anne Marks-Rocke""
      },
      {
        ""Character"": ""Eathon Easton, ihr Untermieter"",
        ""Speaker"": ""Helgo Liebig""
      },
      {
        ""Character"": ""Mrs. Lydia Cartier"",
        ""Speaker"": ""Gerda Gmelin""
      },
      {
        ""Character"": ""Sigourney, ihr Dienstmädchen"",
        ""Speaker"": ""Susanne Beck""
      },
      {
        ""Character"": ""Kelly"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""Inspektor Kershaw"",
        ""Speaker"": ""Frank Felicetti""
      },
      {
        ""Character"": ""Hugenay"",
        ""Speaker"": ""Hans Irle""
      },
      {
        ""Character"": ""Museumswärterin"",
        ""Speaker"": ""Marianne Kehlau""
      }
    ]
  },
  {
    ""Id"": ""f017c02f-7e50-4096-9e2e-b71650d76d6d"",
    ""Title"": ""... und das brennende Schwert"",
    ""NumberEuropa"": 74,
    ""ReleaseDate"": ""1997-02-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/074.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Onkel Titus hat allen Grund zur Freude: Er wird zu einer Testamentsvollstreckung eingeladen! Doch statt der erhofften Millionen erbt er einen wertlosen roten Kristall, den er an einen gewissen Beany weitergeben soll. Wer aber ist Beany? Die drei ??? nehmen die Ermittlungen auf. Ein anonymer Anrufer bringt sie auf die Spur eines gefährlichen Geheimbundes. Und plötzlich geraten Justus, Peter und Bob in einen atemberaubenden Strudel aus Besessenheit, Wahnsinn und Aberglaube."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Mr. Whitehead"",
        ""Speaker"": ""Uwe Friedrichsen""
      },
      {
        ""Character"": ""Steven Robinshaw, Anwalt"",
        ""Speaker"": ""Helgo Liebig""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mary"",
        ""Speaker"": ""Victoria Voncampe""
      },
      {
        ""Character"": ""Stan"",
        ""Speaker"": ""Georg Tryphon""
      },
      {
        ""Character"": ""Jeffrey"",
        ""Speaker"": ""Michael Quiatkowsky""
      },
      {
        ""Character"": ""John"",
        ""Speaker"": ""Andreas Martens""
      },
      {
        ""Character"": ""Dr. Wright"",
        ""Speaker"": ""Dietmar Mues""
      },
      {
        ""Character"": ""Carrie Hanson"",
        ""Speaker"": ""Hella von der Osten-Sacken""
      },
      {
        ""Character"": ""Tim Conrad"",
        ""Speaker"": ""Moritz Gentsch""
      }
    ]
  },
  {
    ""Id"": ""4f4fcadb-14b6-4645-98a6-a94c8a9468ae"",
    ""Title"": ""Die Spur des Raben"",
    ""NumberEuropa"": 75,
    ""ReleaseDate"": ""1997-07-14T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/075.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Peter traut seinen Augen nicht: Am frühen Abend klettert ein schwarzer Schatten auf dem Dach des Hotels herum. Instinktiv reißt Peter die Kamera hoch und drückt ab. Was er wenig später in den Händen hlt ist eine Sensation: die erste Aufnahme des \""Raben\"", dem dreisten Juwelendieb von Los Angeles. Doch mit der Veröffentlichung der Fotos wird der unheimliche Balancekünstler auf die drei Jungs aus Rocky Beach aufmerksam. Er fordert sie zu einem Wettkampf heraus. Ein mörderischer Wettlauf gegen die Zeit beginnt."",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs. Shaw"",
        ""Speaker"": ""Heikedine Körting""
      },
      {
        ""Character"": ""Amanda Black"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Detective Gregston"",
        ""Speaker"": ""Wolf-Dietrich Berg""
      },
      {
        ""Character"": ""Nora Sethons"",
        ""Speaker"": ""Ursula Sieg""
      },
      {
        ""Character"": ""Mrs. Aston"",
        ""Speaker"": ""J.S.""
      },
      {
        ""Character"": ""Mr. Krieger"",
        ""Speaker"": ""Jörg Gillner""
      },
      {
        ""Character"": ""Lisa Manninger"",
        ""Speaker"": ""Katja Stichel""
      }
    ]
  },
  {
    ""Id"": ""8b6863f8-7484-42d1-8531-737f771c2e89"",
    ""Title"": ""Stimmen aus dem Nichts"",
    ""NumberEuropa"": 76,
    ""ReleaseDate"": ""1997-09-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/076.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""\""Meine Schwester will mich in den Tod treiben!\"" Die alte Dame, die neben Justus im Wartezimmer sitzt, ist am Rande eines Nervenzusammenbruchs. Der erste Detektiv wittert einen neuen Fall für die drei ??? und bietet seine Hilfe an. Doch was er dann erfährt, läßt ihn erbleichen. Mrs. Holligan wird von ihrer Schwester bedroht, verfolgt, in den Wahnsinn getrieben. Doch ihre Schwester wurde vor drei Monaten beerdigt. Justus, Peter und Bob müssen sich bei der Aufklärung des Falles beeilen. Mrs. Holligan ist schwer herzkrank, jede neue Attacke kann ihrem Leben ein Ende setzen. Doch wer steckt wirklich hinter den mysteriösen Stimmen aus dem Jenseits?"",
    ""Roles"": [
      {
        ""Character"": ""Hitchcock, Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Abigail Holligan"",
        ""Speaker"": ""Katharina Brauren""
      },
      {
        ""Character"": ""Metzla Holligan"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Dr. Franklin"",
        ""Speaker"": ""Judy Winter""
      },
      {
        ""Character"": ""Dr. Miller"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Mrs. Petersen"",
        ""Speaker"": ""Victoria Voncampe""
      },
      {
        ""Character"": ""Sekretariat"",
        ""Speaker"": ""Dokter Renz, König Boris, Schiffmeister (Fettes Brot)""
      },
      {
        ""Character"": ""Mr. Brian"",
        ""Speaker"": ""Peter Schubert""
      },
      {
        ""Character"": ""Mrs. Dream"",
        ""Speaker"": ""Petra Ehlers""
      },
      {
        ""Character"": ""Jack Cliffwater"",
        ""Speaker"": ""Thomas Schüler""
      }
    ]
  },
  {
    ""Id"": ""098ccc76-078a-4ca6-9a7e-d8a4db8616df"",
    ""Title"": ""Pistenteufel"",
    ""NumberEuropa"": 77,
    ""ReleaseDate"": ""1997-12-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/077.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Karen Sulzenberger, Topstar der deutschen Skinationalmannschaft, hat Angst. Mysteriöse Drohbriefe machen ihr das Leben zur Hölle! Wer versucht die attraktive Läuferin aus ihrer Erfolgsspur zu stoßen? Auf Skiern und Snowboards nehmen die drei ??? in den Bergen des amerikanischen Weltcup-Ortes Vail die Ermittlungen auf. Doch das erste Attentat auf der Piste können auch die Detektive nicht verhindern. Mit 120 Sachen rast Karen auf ein tödliches Hindernis zu..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Karen Sulzenberger"",
        ""Speaker"": ""Kristina von Weltzien""
      },
      {
        ""Character"": ""Nicola"",
        ""Speaker"": ""Maria Fuchs""
      },
      {
        ""Character"": ""McMannoman"",
        ""Speaker"": ""Wolfgang Noack""
      },
      {
        ""Character"": ""Tony"",
        ""Speaker"": ""Martin Lohmann""
      },
      {
        ""Character"": ""Mrs. Seven"",
        ""Speaker"": ""Eva Gelb""
      },
      {
        ""Character"": ""Trainer"",
        ""Speaker"": ""Hans Sievers""
      },
      {
        ""Character"": ""Roger"",
        ""Speaker"": ""H. P. Kaehler""
      },
      {
        ""Character"": ""1. Mann"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""2. Mann"",
        ""Speaker"": ""Richard Ems""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Micaela Kreißler""
      },
      {
        ""Character"": ""Uli"",
        ""Speaker"": ""Norman Messer""
      }
    ]
  },
  {
    ""Id"": ""f5ce7670-2a51-4e76-ab85-f3b28f258484"",
    ""Title"": ""Das leere Grab"",
    ""NumberEuropa"": 78,
    ""ReleaseDate"": ""1998-01-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/078.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Fassungslos starrt Justus auf das Foto, das ein Freund erst vor wenigen Tagen in Venezuela geschossen hat. Die Frau auf dem Bild ist Catherine Jonas, Justus' Mutter. Doch wie ist das möglich? Seine Eltern sind seit über zehn Jahren tot! Ihr Flugzeug stürzte vor der Küste Südamerikas ins Meer. Gab es damals doch Überlebende des Flugzeugabsturzes? Aber warum haben sich seine Eltern dann nie bei ihm gemeldet? Der erste Detektiv reagiert kopflos. Ohne zu überlegen, bucht er einen Flug und landet in der gefährlichsten Stadt Venezuelas: der Diamantenstadt Suerte."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Albert Hitfield"",
        ""Speaker"": ""Manfred Steffen""
      },
      {
        ""Character"": ""Morton, Chauffeur"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Lys"",
        ""Speaker"": ""Kerstin Draeger""
      },
      {
        ""Character"": ""J.J."",
        ""Speaker"": ""Gregor Reisch""
      },
      {
        ""Character"": ""Julius Jonas"",
        ""Speaker"": ""Wolfgang Kaven""
      },
      {
        ""Character"": ""Catherine Jonas"",
        ""Speaker"": ""Anne Moll""
      },
      {
        ""Character"": ""Arturo"",
        ""Speaker"": ""Carlos Goiach""
      },
      {
        ""Character"": ""Autovermieter"",
        ""Speaker"": ""Richard Ems""
      }
    ]
  },
  {
    ""Id"": ""88943019-7e9f-476b-9314-505b5dd10970"",
    ""Title"": ""Im Bann des Voodoo"",
    ""NumberEuropa"": 79,
    ""ReleaseDate"": ""1998-03-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/079.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine Strohpuppe, deren Anblick Herzrasen und Atemnot auslöst, uralte Rituale und magische Kulte und das mitten im sonnigen Kalifornien! Al Parker, der erfolgreiche Musikproduzent, kann darüber nur lachen. Doch dann gerät er selbst in den Bannkreis des Voodoo: die Untoten fordern seinen Tod. Justus, Peter und Bob, die drei Detektive aus Rocky Beach, tun ihr Bestes, aber sie kämpfen gegen einen mächtigen Gegner."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Al Parker, Musikproduzent"",
        ""Speaker"": ""Lennardt Krüger""
      },
      {
        ""Character"": ""William Needle"",
        ""Speaker"": ""Nicolas König""
      },
      {
        ""Character"": ""Stevens"",
        ""Speaker"": ""Lothar Behrendt""
      },
      {
        ""Character"": ""Bart"",
        ""Speaker"": ""Dokter Renz (Fettes Brot)""
      },
      {
        ""Character"": ""Luke"",
        ""Speaker"": ""Schiffmeister (Fettes Brot)""
      },
      {
        ""Character"": ""Frank"",
        ""Speaker"": ""König Boris (Fettes Brot)""
      },
      {
        ""Character"": ""Joan, Visagistin"",
        ""Speaker"": ""Alida Gundlach""
      },
      {
        ""Character"": ""Jeffrey"",
        ""Speaker"": ""Niko Minninger""
      },
      {
        ""Character"": ""Hank"",
        ""Speaker"": ""Harvey Dräger""
      },
      {
        ""Character"": ""Billy"",
        ""Speaker"": ""Sven Stricker""
      },
      {
        ""Character"": ""Angestellter"",
        ""Speaker"": ""Jens Herrndorff""
      }
    ]
  },
  {
    ""Id"": ""6ab2c1d4-d44a-451b-9c98-3d23785c1c4c"",
    ""Title"": ""Geheimakte Ufo"",
    ""NumberEuropa"": 80,
    ""ReleaseDate"": ""1998-05-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/080.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bob und Peter stockt der Atem. Durch die Bäume schimmert unwirklich grelles Licht - ein Raumschiff in in den Wäldern um Rocky Beach gelandet. Für Peter steht fest: Die Außerirdischen übernehmen die Macht auf der Erde! Justus, der Kopf des Detektivtrios, reagiert gelassen auf die Ufo-Berichte seiner Freunde. Doch dann taucht ein weiterer Augenzeuge auf und der Erste Detektiv wird stutzig. Nochmals untersuchen die drei ??? den Landeplatz des Raumschiffs, ohne zu ahnen, daß sie bereits erwartet werden..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Cosma"",
        ""Speaker"": ""Elke Reissert""
      },
      {
        ""Character"": ""Vladimir Contreras"",
        ""Speaker"": ""Gerhart Hinze""
      },
      {
        ""Character"": ""Roger Carpenter"",
        ""Speaker"": ""Igmar Frentzen""
      }
    ]
  },
  {
    ""Id"": ""b201ec7c-bdab-46df-960b-fc3da98ffc80"",
    ""Title"": ""Verdeckte Fouls"",
    ""NumberEuropa"": 81,
    ""ReleaseDate"": ""1998-06-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/081.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Erfolgreiche Wochen liegen hinter einem deutschen Fußball-Team. Nun wollen sich die Spieler unter der Sonne Kaliforniens auf die Rückrunde vorbereiten. Aber schon bald wird die Harmonie durch merkwürdige Vorgänge erschüttert: Ein Unbekannter treibt in den Mannschafträumen sein böses Spiel. Welches Ziel verfolgt er mit dem Zerschneiden von Trikots und dem Aufsprayen geheimnisvoller Symbole? Die drei ??? nehmen die Ermittlungen auf."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kelly Madigan"",
        ""Speaker"": ""Juliane Szalay""
      },
      {
        ""Character"": ""DaElba"",
        ""Speaker"": ""Ozanan Rocha""
      },
      {
        ""Character"": ""Alberto"",
        ""Speaker"": ""Antonio Luz""
      },
      {
        ""Character"": ""Mr. Toll"",
        ""Speaker"": ""Balduin Baas""
      },
      {
        ""Character"": ""Franke"",
        ""Speaker"": ""Wolfgang Noack""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Günter König""
      },
      {
        ""Character"": ""Mr. Burt"",
        ""Speaker"": ""Gerd Baltus""
      },
      {
        ""Character"": ""Boris"",
        ""Speaker"": ""Carlos Goiach""
      },
      {
        ""Character"": ""Papagei"",
        ""Speaker"": ""Heikedine Körting""
      }
    ]
  },
  {
    ""Id"": ""f07fb91d-555a-4834-bf3d-07518179f38f"",
    ""Title"": ""Die Karten des Bösen"",
    ""NumberEuropa"": 82,
    ""ReleaseDate"": ""1998-10-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/082.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Milva Summer glaubt an Schicksalsmächte. Bis die Karten des Bösen eines Tages ihr nahes Ende prophezeien. In ihrer Todesangst wendet sie sich an Justus, Peter und Bob und bittet die jungen Detektive um Schutz vor dem drohenden Unglück. Können die drei ??? den Kräften des Tarots trotzen? Ist die Hollywood-Diva dem Tode geweiht?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Milva Summer, Astrologin"",
        ""Speaker"": ""Elizabeth Volkmann""
      },
      {
        ""Character"": ""Professor Steed, Tiermediziner"",
        ""Speaker"": ""Henning Schlüter""
      },
      {
        ""Character"": ""Daniel Art, Bodyguard"",
        ""Speaker"": ""Monty Arnold""
      },
      {
        ""Character"": ""Mike Hanson, Reporter"",
        ""Speaker"": ""Corny Littmann""
      },
      {
        ""Character"": ""Nachrichtensprecher"",
        ""Speaker"": ""Werner Pohlenz""
      }
    ]
  },
  {
    ""Id"": ""d31abc59-5cb5-488a-9f3a-bae70238b47e"",
    ""Title"": ""Meuterei auf hoher See"",
    ""NumberEuropa"": 83,
    ""ReleaseDate"": ""1999-02-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/083.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Statt sich bei einem gemütlichen Segeltörn im pazifischen Ozean die Sonne auf den Bauch brennen zu lassen, geraten Justus, Peter und Bob, die jungen Detektive aus Rocky Beach, auf hoher See in eine Meuterei. Binnen Minuten gerät das Forschngsschiff \""Wavedancer\"" in die Gewalt eines fanatischen Wissenschaftlers. Unter seinem Kommando steuert das Schiff in unbekannte Gewässer."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Käptn Jason"",
        ""Speaker"": ""Franz-Josef Steffens""
      },
      {
        ""Character"": ""Professor Clark"",
        ""Speaker"": ""Erich Krieg""
      },
      {
        ""Character"": ""Carol Ford, Fernsehjournalistin"",
        ""Speaker"": ""Claudia Schermutzki""
      },
      {
        ""Character"": ""Dr. Helprin, Wissenschaftler"",
        ""Speaker"": ""Rudolf Herget""
      },
      {
        ""Character"": ""Mr. Evans"",
        ""Speaker"": ""Peter Groß""
      },
      {
        ""Character"": ""Enrique Serra"",
        ""Speaker"": ""Jörg Gillner""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Roland Becker""
      }
    ]
  },
  {
    ""Id"": ""6bb10656-98f6-4aae-9f6e-31121672e010"",
    ""Title"": ""Musik des Teufels"",
    ""NumberEuropa"": 84,
    ""ReleaseDate"": ""1999-02-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/084.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Was ist nur mit Bob los? Warum reagiert der sonst so ausgeglichene Dritte Detektiv plötzlich agressiv und gereizt auf seine Freunde Justus und Peter? Es scheint, als stünde er unter dem Einfluß einer fremden Macht. Justus und Peter beschatten ihren Freund und folgen ihm unauffällig in den Konzertsal eines Privathauses. Dort lauscht er gebannt der Musik eines virtuosen Geigenspielers. Und bevor sie wissen, wie ihnen geschieht, werden auch Justus und Peter von dem Klängen gleichsam verhext. Können sie sich dem Bann des Teufelsgeigers entziehen, ehe es zu spät ist?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Jelena"",
        ""Speaker"": ""Alexandra Doerk""
      },
      {
        ""Character"": ""Mr. Charkov, Jelenas Vater"",
        ""Speaker"": ""Klaus Dittmann""
      },
      {
        ""Character"": ""Vanderhell, Teufelsgeiger"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Roland Becker""
      },
      {
        ""Character"": ""Mrs. Andrews"",
        ""Speaker"": ""Carola Lange""
      }
    ]
  },
  {
    ""Id"": ""544c8518-be73-4050-93b2-a4dc9a0a4d61"",
    ""Title"": ""Feuerturm"",
    ""NumberEuropa"": 85,
    ""ReleaseDate"": ""1999-05-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/085.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Wer ist Jonny? Und warum ist er verschwunden? Die drei Detektive aus Rocky Beach stehen vor einer schier unlösbaren Aufgabe. Sie sollen einen unbekannten Mann finden und ihm einen Brief übergeben, der zu einem geheimnisvollen Schatz führt. Die anonyme Botschaft lockt die drei ??? in die Wildnis des King´s National Parks. Plötzlich wird der Botendienst lebensgefährlich für Justus, Peter und Bob: Jemand versucht ihren Auftrag zu vereiteln. Werden die drei Detektive Jonny helfen können, bevor die Falle zuschnappt? Ein Wettlauf gegen die Zeit beginnt."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Walker"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Monica"",
        ""Speaker"": ""Hansi Jochmann""
      },
      {
        ""Character"": ""Lady MacWeiden"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Mac George"",
        ""Speaker"": ""Johann Schibli""
      },
      {
        ""Character"": ""Chris"",
        ""Speaker"": ""Daniel Kruth""
      },
      {
        ""Character"": ""Campingwart"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""Frau des Campingwarts"",
        ""Speaker"": ""Ingrid Weiß""
      }
    ]
  },
  {
    ""Id"": ""2eeb9c1f-c301-4a10-bb7d-7aec8d6bdfdf"",
    ""Title"": ""Nacht in Angst"",
    ""NumberEuropa"": 86,
    ""ReleaseDate"": ""1999-08-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/086.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Freitagabend, 20.25 Uhr, Steadman-Museum, Los Angeles: Mr. Peacock, der freundliche, aber schusselige Museumsdirektor, betritt mit Justus, Peter und Bob das Gebäude. In wenigen Minuten werden die drei Detektive exklusiv den wertvollsten Diamanten der Welt sehen: das berühmte \""Feuer des Mondes\"". 20.28 Uhr: Im Museum gehen die Lichter aus. Stromausfall? Sabotage? 20.30 Uhr: Fünf Gangster dringen in das Museum ein. Kurze Zeit später befinden sich Mr. Peacock und die drei ??? in ihrer Gewalt. Die Verbrecher wollen den Diamanten und sie sind bereit, dafür über Leichen zu gehen."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Mr. Peacock, Museumsdirektor"",
        ""Speaker"": ""Helmut Ahner""
      },
      {
        ""Character"": ""Alpha"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Beth"",
        ""Speaker"": ""Katja Brügger""
      },
      {
        ""Character"": ""Ernie"",
        ""Speaker"": ""Wolfgang Hartmann""
      },
      {
        ""Character"": ""Dog"",
        ""Speaker"": ""Niko Minninger""
      },
      {
        ""Character"": ""Ceewee"",
        ""Speaker"": ""Michael Quiatkowsky""
      }
    ]
  },
  {
    ""Id"": ""e3fc3c17-4bef-49cb-8695-019211775a61"",
    ""Title"": ""Wolfsgesicht"",
    ""NumberEuropa"": 87,
    ""ReleaseDate"": ""1999-10-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/087.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der Mann lebt allein an der Küste, die Nachbarn kennen ihn kaum, das Haus verlässt er nur selten: ein einsamer Wolf - oder ist er in Wirklichkeit das \""Wolfsgesicht\"", der gefürchtete Attentäter? Zweimal hat er bereits zugeschlagen und jedesmal konnte er fliehen, ohne Spuren zu hinterlassen. Selbst Justus, das Computerhirn des Detektivtrios \""Die Drei ???\"", ist ratlos. Da erhält die Polizei Hinweise auf den nächsten Coup. Diesmal plant der Attentäter einen Anschlag auf den Präsidenten der Vereinigten Staaten. Die Zeit drängt. Schon morgen wird der Präsident nach Rocky Beach kommen."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mrs. Harding, Polizeipsychologin"",
        ""Speaker"": ""Katrin Wasow""
      },
      {
        ""Character"": ""Mr. Ambler, Assistent"",
        ""Speaker"": ""Rainer Schmitt""
      },
      {
        ""Character"": ""Rodder, das Wolfsgesicht"",
        ""Speaker"": ""Andreas Martens""
      },
      {
        ""Character"": ""Mr. Laurent, Ladenbesitzer"",
        ""Speaker"": ""Lutz Lukasz""
      },
      {
        ""Character"": ""Mr. Stepelton, Ladenbesitzer"",
        ""Speaker"": ""Harald Pages""
      },
      {
        ""Character"": ""Ray, Praktikant"",
        ""Speaker"": ""Marcel Rinkenauer""
      },
      {
        ""Character"": ""Sandy, Verkäuferin"",
        ""Speaker"": ""Kathi Robens""
      },
      {
        ""Character"": ""Kundin"",
        ""Speaker"": ""Cornelia Meinhardt""
      }
    ]
  },
  {
    ""Id"": ""7370ef57-d489-46de-99f5-91d8e30a036c"",
    ""Title"": ""Vampir im Internet"",
    ""NumberEuropa"": 88,
    ""ReleaseDate"": ""1999-12-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/088.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Mit voller Kraft rast der Vampir gegen die Scheibe. Glas splittert, Scherben fliegen durch die Luft. Das Fledermaus-Monster scheint die Wände seines Käfigs zu sprengen: Das brandneue Computerspiel zieht die drei Detektive aus Rocky Beach in seinen Bann. Begeistert tauchen sie ein in die virtuelle Welt der Drachen und Monster. Die Welt des Spiels scheint sich mit der Realität zu vermischen. Justus, Peter und Bob müssen höllisch aufpassen, um den Vampiren nicht zum Opfer zu fallen."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Doe Dungeon, Programmierer"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Lili Buschfort"",
        ""Speaker"": ""Christina Holsten""
      },
      {
        ""Character"": ""Tom Beker"",
        ""Speaker"": ""Wolfgang Hartmann""
      },
      {
        ""Character"": ""Märchenerzähler"",
        ""Speaker"": ""Hans Paetsch""
      },
      {
        ""Character"": ""Königin Trulie"",
        ""Speaker"": ""Hanna Reisch""
      },
      {
        ""Character"": ""Vinton"",
        ""Speaker"": ""Nils Noller""
      },
      {
        ""Character"": ""Amme"",
        ""Speaker"": ""Katharina Brauren""
      },
      {
        ""Character"": ""Medusa"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Oinki Hinki"",
        ""Speaker"": ""Niko Minninger""
      },
      {
        ""Character"": ""Vampir-Frau"",
        ""Speaker"": ""Julia von Spieß""
      },
      {
        ""Character"": ""Hexe"",
        ""Speaker"": ""Micaela Kreißler""
      },
      {
        ""Character"": ""Oma"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Wache"",
        ""Speaker"": ""Michael Quiatkowsky""
      },
      {
        ""Character"": ""Computerstimme"",
        ""Speaker"": ""Sascha Gutzeit""
      }
    ]
  },
  {
    ""Id"": ""583be1ca-6499-4bfc-b1dc-9d6cf8bc34d1"",
    ""Title"": ""Tödliche Spur"",
    ""NumberEuropa"": 89,
    ""ReleaseDate"": ""2000-05-15T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/089.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Morton ist tot! Der Freund und Chauffeur der drei Detektive aus Rocky Beach ist mit seinem Wagen über die Klippen gestürzt. - Ein Unfall? Oder war es Mord? Justus, Peter und Bob sind ratlos. Was wissen sie eigentlich über Morton? Die drei ??? beginnen in der Vergangenheit ihres Freundes zu stöbern und entdecken dabei Hinweise, die sie lieber nicht gefunden hätten. Als plötzlich ein rätselhafter Geheimcode auftaucht, wird Justus' Kombinationsgabe auf eine harte Probe gestellt. Es bleibt nicht viel Zeit, denn die Schatten der Vergangenheit rücken unaufhaltsam näher..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mr. Gilbert"",
        ""Speaker"": ""Manfred Reddemann""
      },
      {
        ""Character"": ""Mrs. Grayson"",
        ""Speaker"": ""Beate Hasenau""
      },
      {
        ""Character"": ""Mr. Perkins"",
        ""Speaker"": ""Marco Kröger""
      },
      {
        ""Character"": ""Mac Dunno"",
        ""Speaker"": ""Gerhard Marcel""
      },
      {
        ""Character"": ""Wachmann"",
        ""Speaker"": ""Ulli Plessmann""
      }
    ]
  },
  {
    ""Id"": ""b8210a51-be4c-433c-bcc9-aca7629c6f4b"",
    ""Title"": ""Der Feuerteufel"",
    ""NumberEuropa"": 90,
    ""ReleaseDate"": ""2000-05-15T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/090.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Auf der Suche nach einer passenden Maske für eine Halloween-Party trifft Peter auf Aaron Moore. Der Grusel-Autor wird von einem dämonischen Feuerteufel bedroht und bangt um sein Leben. Bereits drei unheimliche Vorzeichen haben sich erfüllt: Feuer, Luft und Erde haben sich gegen den Schriftsteller erhoben. Erfüllt sich auch das vierte Zeichen, bedeutet dies den Tod Moores. Können Justus, Peter und Bob, die drei erfolgreichen Detektive aus Rocky Beach, den Fluch bannen? Sie kämpfen gegen Geister und Dämonen, gegen die vier Elemente und den Feuerteufel. Ein auswegloses Unterfangen?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Aaron Moore"",
        ""Speaker"": ""Reent Reins""
      },
      {
        ""Character"": ""Roxanne"",
        ""Speaker"": ""Regine Lamster""
      },
      {
        ""Character"": ""Bruce Black"",
        ""Speaker"": ""Til Demtröder""
      }
    ]
  },
  {
    ""Id"": ""d44f0211-c428-4e82-bdd1-1cb90423db21"",
    ""Title"": ""Todesflug"",
    ""NumberEuropa"": 92,
    ""ReleaseDate"": ""2000-10-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/092.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Justus, Peter und Bob sitzen fest: Mitten in der Wüste versagt ihr Auto und das Wasser geht zur Neige. Die Nerven der drei Jungs sind zum Zerreißen gespannt. Plötzlich durchbricht ein Dröhnen die Stille: Ein Tiefflieger zieht über ihre Köpfe hinweg und setzt zur Landung an. Die drei Detektive schöpfen Hoffnung. Das könnte die Rettung bedeuten. Doch unversehens geraten sie in eine tödliche Falle. Ein größenwahnsinniger Weltraumforscher bringt Bob in höchste Lebensgefahr. Wie können die drei cleveren Jungs verhindern, dass Bob ins Weltall geschossen wird?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Gregstone"",
        ""Speaker"": ""Wolf Rahtjen""
      },
      {
        ""Character"": ""Butch"",
        ""Speaker"": ""Frank Felicetti""
      },
      {
        ""Character"": ""Ramirez"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Radiosprecher"",
        ""Speaker"": ""Hubertus Borck""
      }
    ]
  },
  {
    ""Id"": ""eed4f756-1640-4df5-a612-e5b44f7fb008"",
    ""Title"": ""... und das Geisterschiff"",
    ""NumberEuropa"": 93,
    ""ReleaseDate"": ""2000-11-27T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/093.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein Geisterschiff kreuzt vor der Küste von Rocky Beach. Justus, Peter und Bob trauen ihren Augen nicht: Der Dreimast mit den zerfetzten Segeln gleitet durch die neblige See. Spuk oder Wirklichkeit? Die drei Jungs brauchen starke Nerven, denn Nachforschungen führen sie zu Piraten aus längst vergangenen Zeiten. Hat ein Fluch sie in die Gegenwart zurückgebracht? Um das Rätsel zu lösen, gibt es nur eine Möglichkeit: Die drei Detektive aus Rocky Beach müssen selbst an Bord gehen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Quin"",
        ""Speaker"": ""Rasmus Borowski""
      },
      {
        ""Character"": ""Mr. Conrad Farnham"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Mrs. Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Deborah Snell"",
        ""Speaker"": ""Anja Topf""
      }
    ]
  },
  {
    ""Id"": ""6c4f6910-6ee2-4fcb-9dbe-31c0222caa26"",
    ""Title"": ""Das schwarze Monster"",
    ""NumberEuropa"": 94,
    ""ReleaseDate"": ""2000-11-27T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/094.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Zirkus Trinket kommt mit einer unglaublichen Attraktion nach Rocky Beach: In der Manage tritt ein mörderisches Monster aus den Wäldern Alaskas auf. Doch dann entsteigt die Kreatur dem Käfig und verbreitet Angst und Schrecken. Die drei ??? nehmen die Spur des rätselhaften Wesens auf, denn natürlich glauben sie nicht an ein echtes Monster. Doch plötzlich steht es vor ihnen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Alois Copper"",
        ""Speaker"": ""Werner Cartano""
      },
      {
        ""Character"": ""Mr. Carter"",
        ""Speaker"": ""Marius Berthold""
      },
      {
        ""Character"": ""Miss Lilly"",
        ""Speaker"": ""Jocelyn Boisseaux-Endemann""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Frau des Bürgermeisters"",
        ""Speaker"": ""Wanda Osten""
      },
      {
        ""Character"": ""Reporter"",
        ""Speaker"": ""Jacky Nonnon""
      },
      {
        ""Character"": ""Stewart"",
        ""Speaker"": ""Tilman Madaus""
      },
      {
        ""Character"": ""Pico, Clown"",
        ""Speaker"": ""Hubertus Borck""
      }
    ]
  },
  {
    ""Id"": ""b8b1edfc-1477-45b2-a5ea-ecbf3ce31153"",
    ""Title"": ""... und der rote Rächer"",
    ""NumberEuropa"": 96,
    ""ReleaseDate"": ""2001-04-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/096.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei ??? sollen Brandstifter sein? Ein unglaublicher Verdacht. Wo sie gerade noch selbst als Helfer am Brandort zugepackt haben. Doch eine Visitenkarte der drei ??? wurde direkt im Hafen von Rocky Beach aufgefunden. Wie kam sie dorthin? Spielt hier jemand ein falsches Spiel? Jetzt müssen die drei ??? scharf kombinieren und vor allem einen kühlen Kopf bewahren. Nur die Überführung des wahren Täters kann sie entlasten."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Detective Frank"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""Dave Rawling"",
        ""Speaker"": ""Helmut Gentsch""
      },
      {
        ""Character"": ""Praktikantin Lesley"",
        ""Speaker"": ""Ann Montenbruck""
      },
      {
        ""Character"": ""Mrs. Shaw"",
        ""Speaker"": ""Heikedine Körting""
      },
      {
        ""Character"": ""Mr. Smith"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Sheppard"",
        ""Speaker"": ""Marius Kreissler""
      },
      {
        ""Character"": ""Feuerwehrmann"",
        ""Speaker"": ""Wolfgang Kaven""
      },
      {
        ""Character"": """",
        ""Speaker"": """"
      }
    ]
  },
  {
    ""Id"": ""4252e76f-c866-48e9-baf4-b303a2d18a08"",
    ""Title"": ""Insektenstachel"",
    ""NumberEuropa"": 97,
    ""ReleaseDate"": ""2001-06-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/097.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Regungslos sitzt das Insekt auf dem Lampen schirm. Es sieht aus wie eine Riesenwespe. Der Körper ist etwa dreißig Millimeter lang und am Hinterteil blitzt der Ansatz eines Stachels auf. Das Sonnenlicht spiegelt sich in den Facettenaugen. Mrs. Hazelwood schwinden die Sinne... Die alte Dame hat panische Angst vor Insekten. Als ihre Hausangestellte Opfer eines Hornissenangriffs wird, dreht sie durch. Die drei ??? leisten erste Hilfe und stoßen dabei auf einige merkwürdige Dinge."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Janet Hazelwood"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Laura Stryker"",
        ""Speaker"": ""Regina Lemnitz""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Mrs. White"",
        ""Speaker"": ""Brigitte Böttrich""
      },
      {
        ""Character"": ""Mr. Collins"",
        ""Speaker"": ""Daniel Eggers""
      }
    ]
  },
  {
    ""Id"": ""6476e571-0315-4d14-891a-1737cde7faed"",
    ""Title"": ""Tal des Schreckens"",
    ""NumberEuropa"": 98,
    ""ReleaseDate"": ""2001-08-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/098.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Mitten in den Magic Mountains wacht eine Frau am Steuer ihres Autos auf: Sie hat keine Ahnung wo sie ist, ihr Kopf schmerzt. Das Einzige, an das sie sich erinnern kann, ist ein Indianer mit Adlerkopfmaske, der sie mitten in der Nacht aus dem Auto gezerrt hat. Die Polizei zweifelt an dem Verstand der Frau, doch die drei ??? glauben ihr. Sie versprechen, die mysteriöse Geschichte aufzuklären. Todesmutig machen sie sich auf in das Tal des Schreckens und erleben die Horrornacht ihres Lebens."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Ann Sullivan"",
        ""Speaker"": ""Heidi Schaffrath""
      },
      {
        ""Character"": ""Mr. Martin"",
        ""Speaker"": ""Christian Mey""
      },
      {
        ""Character"": ""Mr. Caddy"",
        ""Speaker"": ""Helmut Gentsch""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Anna Carlsson""
      },
      {
        ""Character"": ""Lady Day"",
        ""Speaker"": ""Reinhilt Schneider""
      },
      {
        ""Character"": ""Henry"",
        ""Speaker"": ""Wilhelm Wieben""
      },
      {
        ""Character"": ""Mann aus der Wüste"",
        ""Speaker"": ""Wilhelm Hornbostel""
      },
      {
        ""Character"": ""Miller"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Debby"",
        ""Speaker"": ""Roswitha Benda""
      },
      {
        ""Character"": ""Joe"",
        ""Speaker"": ""Jakob Lichtblau [Eberhard Haar]""
      }
    ]
  },
  {
    ""Id"": ""b18c8a44-c54c-4438-8344-676a24c3b933"",
    ""Title"": ""Rufmord"",
    ""NumberEuropa"": 99,
    ""ReleaseDate"": ""2001-09-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/099.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""»On Air« - das rote Licht im Aufnahmestudio des Radiosenders von Rocky Beach leuchtet. Die drei ??? sind live auf Sendung. Und kein anderer als der berühmte Starmoderator Kevin Anderson führt mit witzigen Sprüchen durchs Programm. Justus, Peter und Bob berichten begeistert von ihrer Detektivarbeit - bis sich plötzlich ein anonymer Anrufer in die Sendung schaltet und mit verstellter Stimme eine tödliche Drohung ausspricht. Ein Fall für die drei Detektive?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Kevin Anderson"",
        ""Speaker"": ""Thomas Bug""
      },
      {
        ""Character"": ""Clarissa Franklin"",
        ""Speaker"": ""Judy Winter""
      },
      {
        ""Character"": ""Dr. Freeman"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Mrs. Brighton"",
        ""Speaker"": ""Monika Werner""
      },
      {
        ""Character"": ""Mrs. Wheel"",
        ""Speaker"": ""Ines Sawatzki""
      },
      {
        ""Character"": ""Schwester Whitney"",
        ""Speaker"": ""Andrea Lange""
      },
      {
        ""Character"": ""Besucher"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""Bote"",
        ""Speaker"": ""Stefan Rütter""
      },
      {
        ""Character"": ""Goodween"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""a7840b83-4f53-4028-9c88-d90ec9af0253"",
    ""Title"": ""Toteninsel"",
    ""NumberEuropa"": 100,
    ""ReleaseDate"": ""2001-10-15T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/100.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Folge A: »Das Rätsel der Sphinx« Ein seltsames Rätsel und ein unbekannter Anrufer; die drei ??? haben alle Hände voll zu tun. Wer- oder was verbirgt sich hinter dem geheimnisvollen Namen \""Sphinx\""? Alle Fäden laufen auf der \""Montana\"" zusammen, einem Schiff, auf dem der neueste Fall für Justus, Bob und Peter eine dramatische Wendung nimmt... Folge B: »Das vergessene Volk« Dichter Urwald, ein Vulkankrater, und eine unbewohnte Insel. Peter Shaw - ganz auf sich allein gestellt - durchlebt im Dschungel einen wahren Albtraum. Wer ist das entstellte Narbengesicht, dem er urplötzlich in einer unterirdischen Höhle gegenüber steht? Folge C: »Der Fluch der Gräber« Eine Bombendrohung, Raketenköpfe und den Tod vor Augen bringen nicht nur den ängstlichen Zweiten Detektiv gehörig ins Schwitzen. \""Makatao\"", die Toteninsel entpuppt sich als eine gefährliche Falle. Ein nervenaufreibender Wettlauf mit der Zeit beginnt ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Jelena"",
        ""Speaker"": ""Alexandra Doerk""
      },
      {
        ""Character"": ""Dr. Svenson"",
        ""Speaker"": ""Antje Roosch""
      },
      {
        ""Character"": ""Mr. Schwarz"",
        ""Speaker"": ""Erik Schäffler""
      },
      {
        ""Character"": ""Mr. Olin"",
        ""Speaker"": ""Uli Krohm""
      },
      {
        ""Character"": ""Juan"",
        ""Speaker"": ""Oliver Böttcher""
      },
      {
        ""Character"": ""Professor Phoenix"",
        ""Speaker"": ""Wilfried Glatzeder""
      },
      {
        ""Character"": ""Rachel Hadden"",
        ""Speaker"": ""Anna Carlsson""
      },
      {
        ""Character"": ""Al"",
        ""Speaker"": ""Nicolas König""
      },
      {
        ""Character"": ""Anne"",
        ""Speaker"": ""Corinna Wodrich""
      }
    ]
  },
  {
    ""Id"": ""673d9b32-8791-4171-ab7f-e81a6b616ad9"",
    ""Title"": ""... und das Hexen-Handy"",
    ""NumberEuropa"": 101,
    ""ReleaseDate"": ""2001-12-03T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/101.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der neueste Hit unter den Teenagern in Rocky-Beach: \""Hexen-Handys\""! Sie leuchten im Dunkeln giftgrün und statt zu klingeln, kichern sie gruselig. Doch dann legt sich ein düsterer Schatten auf das Küstenstädtchen. Einige der stolzen Besitzer dieser Handys verschwinden auf unheimliche Weise. Zurück am Tatort bleiben nur die leuchtenden Mobiltelefone, auf deren Display die Teufelszahl 666 erscheint. Die drei Detektive Justus, Peter und Bob nehmen per Handy die Spur auf, ohne zu wissen, was sie am anderen Ende der Leitung erwartet..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Giorgio Cade"",
        ""Speaker"": ""Bastian Pastewka""
      },
      {
        ""Character"": ""Monique Carrera"",
        ""Speaker"": ""Amanda Lear""
      },
      {
        ""Character"": ""Mrs. Jones"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Jenny Collins"",
        ""Speaker"": ""Anja Topf""
      },
      {
        ""Character"": ""Jeremy Scott"",
        ""Speaker"": ""Woody Mues""
      },
      {
        ""Character"": ""Mrs. Scott"",
        ""Speaker"": ""Hansi Jochmann""
      },
      {
        ""Character"": ""Oma Scott"",
        ""Speaker"": ""Apollonia Minniger""
      },
      {
        ""Character"": ""Acer"",
        ""Speaker"": ""Thomas Schüler""
      }
    ]
  },
  {
    ""Id"": ""5579e2cd-03af-43d9-abd0-18b9ff706c73"",
    ""Title"": ""Doppelte Täuschung"",
    ""NumberEuropa"": 102,
    ""ReleaseDate"": ""2002-03-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/102.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bob gerät mitten in einen Banküberfall und kann für Bruchteile von Sekunden das Gesicht des Täters sehen. Während die drei ??? das erstellte Phantombild genau studieren, stattet der Bankräuber ihnen einen Besuch in der Zentrale ab. Zunächst scheint geklärt, dass es sich bei ihrem neuen Auftraggeber um den Zwillingsbruder des Verdächtigen handelt. Doch schon bald wissen Justus, Peter und Bob nicht mehr, mit welchem der Brüder sie es zu tun haben. Ein gefährliches Verwirrspiel beginnt."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""King"",
        ""Speaker"": ""Wolfgang Condrus""
      },
      {
        ""Character"": ""Jenny Collins"",
        ""Speaker"": ""Anja Topf""
      },
      {
        ""Character"": ""Tricia Wilson"",
        ""Speaker"": ""Ursula Vogel""
      },
      {
        ""Character"": ""Goodween"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""3e6e7670-0e5a-47c9-b0c3-a4fb0af89dee"",
    ""Title"": ""Das Erbe des Meisterdiebes"",
    ""NumberEuropa"": 103,
    ""ReleaseDate"": ""2002-05-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/103.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der berühmte Meisterdieb Victor Hugenay ist tot! In einem rätselhaften Testament hinterlässt er Hinweise auf bisher unentdecktes Diebesgut: einige wertvolle Gemälde. Eine Herausforderung für Justus' Superhirn! Aber der erste Detektiv lässt sich diesmal von seiner Arbeit ablenken. Was ist los mit dem Kopf der drei Detektive? Als ein geheimnisvoller Unbekannter ebenfalls hinter dem Bilderversteck her zu sein scheint, müssen Justus, Peter und Bob zeigen, was in ihnen steckt."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Matthias Fuchs""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Brittany"",
        ""Speaker"": ""Dorette Hugo""
      },
      {
        ""Character"": ""Victor Hugenay"",
        ""Speaker"": ""Albert Giro [Wolfgang Kubach]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Wilbur Graham"",
        ""Speaker"": ""Thomas Bammer""
      },
      {
        ""Character"": ""Bruder Raphael"",
        ""Speaker"": ""Siegfried Kernen""
      },
      {
        ""Character"": ""Inspektor Berger"",
        ""Speaker"": ""Jan Buchwald""
      },
      {
        ""Character"": ""Baldwin"",
        ""Speaker"": ""Gerhart Hinze""
      }
    ]
  },
  {
    ""Id"": ""a9c6c81c-f65b-4694-b21e-eae1b2a8de09"",
    ""Title"": ""Gift per E-Mail"",
    ""NumberEuropa"": 104,
    ""ReleaseDate"": ""2002-07-08T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/104.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Achtung Feuerquallen! - Beim Tauchen vor der Küste von Rocky Beach kann Mrs Baker den giftigen Tieren in letzter Sekunde entkommen. Aber dann erscheinen die Quallen plötzlich per E-Mail auf Mrs Bakers Computerbildschirm und bedrohen nicht nur ihre Dateien, sondern auch ihr Leben. Mit Hilfe von Tom Wood - einem Computerexperten - nehmen die drei ??? die Spur des anonymen Absenders auf. Wenn da nur nicht Dick Perry wäre, ein überheblicher Detektiv aus Santa Monica, der Justus, Peter und Bob die Ermittlung mehr als schwer macht..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Dick Perry"",
        ""Speaker"": ""Ernst Hilbich""
      },
      {
        ""Character"": ""Mrs. Meg Baker"",
        ""Speaker"": ""Lotti Krekel""
      },
      {
        ""Character"": ""Mrs. Wood"",
        ""Speaker"": ""Elga Schütz""
      },
      {
        ""Character"": ""Jack Sharky"",
        ""Speaker"": ""Stefan Babic""
      },
      {
        ""Character"": ""Betty Shutton"",
        ""Speaker"": ""Regina Pressler""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mrs. Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      }
    ]
  },
  {
    ""Id"": ""844554cb-c8b2-4a2c-9ce7-1a02eaa6acb1"",
    ""Title"": ""... und der Nebelberg"",
    ""NumberEuropa"": 105,
    ""ReleaseDate"": ""2002-09-16T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/105.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine Wandertour in den Rocky Mountains - Peter und Bob sind begeistert! Doch unterwegs hüllt auf einmal ein undurchdringlicher Nebel den Berggipfel ein und die Wandergruppe wird von einer geisterhaften Erscheinung überrascht. \""Das Phantom ist zurückgekehrt\"", murmeln die Alten des nahegelegenen Bergdorfes. Da fängt der Erste Detektiv Feuer, denn neben der körperlichen Anstrengung sind jetzt seine Gehirnzellen gefragt. Was steckt hinter der Spukerscheinung? Die drei ??? müssen diesmal besonders klug vorgehen, um die wortkargen Einsiedler zum Sprechen zu bringen."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Joanna Masterson"",
        ""Speaker"": ""Barbara Marcks""
      },
      {
        ""Character"": ""Jack Masterson"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Sarah Masterson"",
        ""Speaker"": ""Nadja Reichardt""
      },
      {
        ""Character"": ""Mr Harry Falkner"",
        ""Speaker"": ""Wolfgang Hartmann""
      },
      {
        ""Character"": ""Harvey Ashford"",
        ""Speaker"": ""Rolf E. Schenker""
      },
      {
        ""Character"": ""Marc"",
        ""Speaker"": ""Hartmut Kollakowski""
      }
    ]
  },
  {
    ""Id"": ""c740de80-49f4-4ee0-a513-0187a76a90ee"",
    ""Title"": ""Der Mann ohne Kopf"",
    ""NumberEuropa"": 106,
    ""ReleaseDate"": ""2002-09-16T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/106.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""\""DJ Devil\"" von der Presse auch reißerisch \""Satans-DJ\"" genannt, scheint wahrlich über teuflische Fähigkeiten zu verfügen. Der geheimnisvolle DJ ohne Kopf entlockt am Wochenende seinem Mischpult die unheimlichsten Beats, die die tanzenden Besucher in rasende Euphorie versetzen. Doch plötzlich gerät die Szenerie ausser Kontrolle. Die drei ??? sind an diesem Abend zufällig Besucher in der Diskothek \""Planet Evil\"" und werden Zeugen eines unheimlichen Phänomens, das Justus an die Grenzen seiner Logik katapultiert ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Amy Scream"",
        ""Speaker"": ""Marianne Kehlau""
      },
      {
        ""Character"": ""Monique Carrera"",
        ""Speaker"": ""Amanda Lear""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Ellen"",
        ""Speaker"": ""Celine Fontanges""
      },
      {
        ""Character"": ""Pam"",
        ""Speaker"": ""Enie van de Meiklokjes""
      },
      {
        ""Character"": ""Jim Cowley"",
        ""Speaker"": ""Cäsar""
      },
      {
        ""Character"": ""Jeffrey"",
        ""Speaker"": ""Kim Alexander Frank""
      },
      {
        ""Character"": ""Mandy Robin"",
        ""Speaker"": ""Manuela Dahm""
      },
      {
        ""Character"": ""1. Sanitäter"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""2. Sanitäter"",
        ""Speaker"": ""Hartmut Kollakowsky""
      },
      {
        ""Character"": ""Bardame"",
        ""Speaker"": ""Monique Carrera [Amanda Lear]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Diskothekenbesucher"",
        ""Speaker"": ""Echt""
      }
    ]
  },
  {
    ""Id"": ""33258bc6-6e02-46bb-baae-02abb855b458"",
    ""Title"": ""... und der Schatz der Mönche"",
    ""NumberEuropa"": 107,
    ""ReleaseDate"": ""2003-01-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/107.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""\""Ich möchte Peter Shaw sprechen. Es ist dringend!\"" - \""Worum geht es denn, Mister?\"" - \""Um sein Leben.\"" Eigentlich hatte Peter nur nach einem geeigneten Drehort für ein Filmprojekt an der Schule gesucht. Doch in der verlassenen Fabrikhalle findet er mehr als nur einen stimmungsvollen Schauplatz für den geplanten Kriminalfilm: ein geheimnisvolles Kästchen, einen Zettel mit merkwürdigen Schriftzeichen - und einen messerwerfenden Asiaten, der sich sofort an seine Fersen heftet. Und dies alles ist erst der Auftakt zu einem neuen Fall für die drei ???..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Lama Geshe"",
        ""Speaker"": ""Rolf Nagel""
      },
      {
        ""Character"": ""Tai Sutsi"",
        ""Speaker"": ""Dr. Boo Young-Shin""
      },
      {
        ""Character"": ""Chuck"",
        ""Speaker"": ""Yan Kimsang""
      },
      {
        ""Character"": ""Vinaya"",
        ""Speaker"": ""Prof. Dr. Zhu""
      },
      {
        ""Character"": ""Mr Zhang"",
        ""Speaker"": ""Ingo Feder""
      },
      {
        ""Character"": ""Lesley Dimple"",
        ""Speaker"": ""Maja Stehli [Ingeborg Kantstein ?]""
      },
      {
        ""Character"": ""Mrs. Wilbur"",
        ""Speaker"": ""Ingeburg Kanstein""
      }
    ]
  },
  {
    ""Id"": ""b1e37af8-74db-4749-8f25-c1c963f0d9f2"",
    ""Title"": ""Die sieben Tore"",
    ""NumberEuropa"": 108,
    ""ReleaseDate"": ""2003-04-07T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/108.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Wer ist der unheimliche Mr. Carter, der in einem düsteren alten Schloss lebt und aussieht wie ein abgemagerter Vogel? Auch sein Auftrag für die drei ??? ist mehr als seltsam: \""Findet das Versteck bei den sieben Toren!\"". Was zunächst harmlos klingt, entpuppt sich als äußerst gefährliches Unterfangen. Justus, Peter und Bob müssen Räume betreten, deren Türen sie besser nicht geöffnet hätten, und entdecken dabei Unglaubliches..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Caspar Carter"",
        ""Speaker"": ""Claus Wilcke""
      },
      {
        ""Character"": ""Enid"",
        ""Speaker"": ""Janina Richter""
      },
      {
        ""Character"": ""Albert"",
        ""Speaker"": ""Wolf Rahtjen""
      },
      {
        ""Character"": ""Montgomery"",
        ""Speaker"": ""Hans Sievers""
      }
    ]
  },
  {
    ""Id"": ""189a4483-a423-4d29-8d79-5952eae1df6b"",
    ""Title"": ""Gefährliches Quiz"",
    ""NumberEuropa"": 109,
    ""ReleaseDate"": ""2003-04-07T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/109.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Hochspannung im Studio: Die Kamera läuft, die Scheinwerfer sind auf Justus gerichtet: Wird er alle Fragen in der beliebten Quiz-Show Wer knackt die Nuss? beantworten können? Er muss. Das Leben eines Menschen hängt davon ab. Skrupellose Gangster haben einen raffinierten Plan ausgeheckt. Und wieder einmal müssen Die drei ??? scharf kombinieren, um den Verbrechern auf die Spur zu kommen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Nick Nobel"",
        ""Speaker"": ""Ilja Richter""
      },
      {
        ""Character"": ""Sandy"",
        ""Speaker"": ""Micaela Kreissler""
      },
      {
        ""Character"": ""Bill"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Mike Pherson"",
        ""Speaker"": ""Wolf-Dietrich Berg""
      },
      {
        ""Character"": ""Assistent"",
        ""Speaker"": ""Martin Meyer""
      },
      {
        ""Character"": ""Clarissa"",
        ""Speaker"": ""Theresa Underberg""
      },
      {
        ""Character"": ""Veronica"",
        ""Speaker"": ""Saskia Weckler""
      },
      {
        ""Character"": ""Joe"",
        ""Speaker"": ""Jan-David Rönfeldt""
      },
      {
        ""Character"": ""Sekretärin"",
        ""Speaker"": ""Traudel Sperber""
      }
    ]
  },
  {
    ""Id"": ""582ae4f6-e9d4-4220-8535-07b996b17a98"",
    ""Title"": ""Panik im Park"",
    ""NumberEuropa"": 110,
    ""ReleaseDate"": ""2003-06-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/110.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Panik in Rocky Beach! Plötzlich werden im Stadtpark harmlose Hunde zu wilden Bestien, die sogar Menschen angreifen. Hat der seltsame schwarze Stein, den die drei ??? im Park entdecken, etwas mit dem gefährlichen Verhalten der Tiere zu tun? Wo kommt er her? Welches Geheimnis birgt er in sich? Justus, Peter und Bob machen sich mit Feuereifer auf die Suche. Unversehens geraten sie in ein neues atemberaubendes und gefährliches Abenteuer. Aber sind sie tatsächlich auf der richtigen Spur?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Pablo"",
        ""Speaker"": ""Kai Hendrik Möller""
      },
      {
        ""Character"": ""Dr. Brolin"",
        ""Speaker"": ""Karl-Friedrich Gerster""
      },
      {
        ""Character"": ""Jenkins"",
        ""Speaker"": ""Gustav-Adolph Artz""
      },
      {
        ""Character"": ""Professor Clark"",
        ""Speaker"": ""Thor W.Müller""
      },
      {
        ""Character"": ""Bürgermeister Hoover"",
        ""Speaker"": ""Michael Griem""
      },
      {
        ""Character"": ""Margie"",
        ""Speaker"": ""Susanne Leu""
      },
      {
        ""Character"": ""Mike"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Clark"",
        ""Speaker"": ""Wolf Rahtjen""
      },
      {
        ""Character"": ""Wachmann"",
        ""Speaker"": ""Kristian Kretschmer""
      }
    ]
  },
  {
    ""Id"": ""2fcd2fd5-18fc-482b-a971-39dc67026f6b"",
    ""Title"": ""Die Höhle des Grauens"",
    ""NumberEuropa"": 111,
    ""ReleaseDate"": ""2003-08-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/111.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Totenkopfbecher, Übernachten im Sarg, eine geheimnisvolle Höhle: Die drei ??? freuen sich auf eine aufregende Woche in der 'Geisterburg' - dem einsam gelegenen Erlebnishotel für wohliges Gruseln. Als sich jedoch seltsame Zwischenfälle häufen, wird schnell klar: Was als spannender, aber harmloser Aufenthalt geplant war, gerät zu einem gefährlichen Abenteuer für Justus, Peter und Bob. Liegt der Schlüssel zu allem in der Höhle des Grauens - und in dem Geheimnis, das dort verborgen ist?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Maggie Jones"",
        ""Speaker"": ""Ulrike Johannson""
      },
      {
        ""Character"": ""Lythia Waterstone"",
        ""Speaker"": ""Barbara Focke""
      },
      {
        ""Character"": ""Elisabeth Waterstone"",
        ""Speaker"": ""Linde Fulde""
      },
      {
        ""Character"": ""John Stanley"",
        ""Speaker"": ""Kai Böger""
      },
      {
        ""Character"": ""Jack Donelly"",
        ""Speaker"": ""Andreas Mattau""
      },
      {
        ""Character"": ""Althena"",
        ""Speaker"": ""Michaela Boland""
      },
      {
        ""Character"": ""Corona"",
        ""Speaker"": ""Stefanie Kirchberger""
      },
      {
        ""Character"": ""Fahrer Ken"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""John Fairbanks"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""Hal Fairbanks"",
        ""Speaker"": ""Heidi Schaffrath""
      },
      {
        ""Character"": ""Walt"",
        ""Speaker"": ""Wolfgang Kaven""
      },
      {
        ""Character"": ""Blackeye"",
        ""Speaker"": ""Georg Marquard""
      }
    ]
  },
  {
    ""Id"": ""cfd0dc71-7c63-49fa-bbf0-4f64843b589a"",
    ""Title"": ""Schlucht der Dämonen"",
    ""NumberEuropa"": 112,
    ""ReleaseDate"": ""2003-10-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/113.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Während einer Pferdeshow verschwindet 'Lady', das 29 Jahre alte Pferd eines Teilnehmers. Wurde es entführt? Aber wer könnte Interesse an dem alten Tier haben, das eigentlich keine 100 Dollar mehr wert ist? Der Spürsinn der drei ??? ist geweckt. Schnell werden die Ermittlungen jedoch zu einem gefährlichen Unterfangen, als die drei Detektive aus Rocky Beach bedroht werden. Schwarze Federn sind das Warnsignal, das die unbekannten Täter hinterlassen. Bald führt eine heiße Spur die drei Detektive in die 'Schlucht der Dämonen', einen unheimlichen Ort mitten in der Wüste. Nur zu Pferd kann das unwegsame Gelände erkundet werden und Justus, Peter und Bob müssen fest im Sattel sitzen, um dieses gefährliche Abenteuer bestehen zu können."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Donovan"",
        ""Speaker"": ""Joachim Richert""
      },
      {
        ""Character"": ""Pit"",
        ""Speaker"": ""Wolfgang Wagner""
      },
      {
        ""Character"": ""Max"",
        ""Speaker"": ""Johannes Rothenstein""
      },
      {
        ""Character"": ""Cowboy"",
        ""Speaker"": ""Christian Niehues""
      },
      {
        ""Character"": ""Creeklong"",
        ""Speaker"": ""Nobi Schatka""
      },
      {
        ""Character"": ""Brad Fleming"",
        ""Speaker"": ""Dennis Jensen""
      }
    ]
  },
  {
    ""Id"": ""24acb30a-cd01-4e98-92ec-c89317f96977"",
    ""Title"": ""Das Auge des Drachen"",
    ""NumberEuropa"": 113,
    ""ReleaseDate"": ""2003-11-24T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/112.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein markerschütternder Hilfeschrei hallt durch den Wald. Als Justus, Peter und Bob sich alarmiert auf die Suche machen, finden sie ein kleines Mädchen, das zitternd in den Himmel zeigt: \""Es ... es war ein Drache! Ein Drache hat mich angegriffen!\"" Kurze Zeit später schwebt tatsächlich ein seltsames Tier hoch oben in den Wolken. Eine optische Täuschung? Oder gibt es doch Dinge zwischen Himmel und Erde, die rational nicht erklärbar sind? Die drei Detektive aus Rocky Beach müssen bei ihren Ermittlungen zu diesem Fall sehr genau hinsehen und machen die Erfahrung, dass man selbst den eigenen Augen nicht immer trauen kann ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Emily"",
        ""Speaker"": ""Madeleine Weingart""
      },
      {
        ""Character"": ""Mrs Silverstone"",
        ""Speaker"": ""Katrin Wasow""
      },
      {
        ""Character"": ""Dr.Wakefield"",
        ""Speaker"": ""Hans Daniel""
      },
      {
        ""Character"": ""Alruna"",
        ""Speaker"": ""Gisela Trowe""
      },
      {
        ""Character"": ""Marcus Lake"",
        ""Speaker"": ""Thomas Karallus""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      }
    ]
  },
  {
    ""Id"": ""7ca07318-ebb8-4220-9923-ef537447a5cb"",
    ""Title"": ""Die Villa der Toten"",
    ""NumberEuropa"": 114,
    ""ReleaseDate"": ""2004-02-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/114.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der Auftrag der Anruferin scheint reichlich merkwürdig, aber leicht zu erfüllen zu sein: Die drei ??? sollen beweisen, dass es in der Villa einer berühmten, verstorbenen Opernsängerin nicht spukt. Doch es kommt, wie es kommen muss. Bei dem halbherzigen Versuch, den nicht vorhandenen Geist während einer Séance zu rufen, antwortet dieser tatsächlich! Und die tote Sängerin erklärt, dass ihr Tod kein Unfall war, sondern dass sie ermordet wurde. Plötzlich ermitteln Justus, Peter und Bob im Auftrag eines spukenden Geistes und werden in ein gefährliches Intrigenspiel verwickelt. Hätten die drei Detektive diesen Fall doch besser an die Polizei abgeben sollen?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Bernadette O'Donnell"",
        ""Speaker"": ""Eva Maria Bauer""
      },
      {
        ""Character"": ""Cecilia Jones"",
        ""Speaker"": ""Hanni Vanhaiden""
      },
      {
        ""Character"": ""Elouise Adams"",
        ""Speaker"": ""Hannelore Wüst""
      },
      {
        ""Character"": ""Mrs Willow"",
        ""Speaker"": ""Elga Schütz""
      },
      {
        ""Character"": ""Möbelpacker"",
        ""Speaker"": ""Christian Niehues""
      }
    ]
  },
  {
    ""Id"": ""e737ce38-4aa8-4c06-a8d7-2f1eaf46fd32"",
    ""Title"": ""Auf tödlichem Kurs"",
    ""NumberEuropa"": 115,
    ""ReleaseDate"": ""2004-04-05T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/116.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei erfolgreichen Detektive aus Rocky Beach stehen vor einem Rätsel: Wer könnte Interesse an dem wertlosen Ölbild haben, das ihrem alten Freund, Kommissar Reynolds, entwendet wurde? Welches Geheimnis verbirgt sich hinter dem Bild, auf dem die Segeljacht \""Gwendolyn\"" zu sehen ist? Die Ermittlungen führen Justus, Peter und Bob unversehens in ein gefährliches Abenteuer."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Bertram Hiese""
      },
      {
        ""Character"": ""Escovedo"",
        ""Speaker"": ""Ignacio Descalzo""
      },
      {
        ""Character"": ""Anita Caballero"",
        ""Speaker"": ""Isabell Navarro""
      },
      {
        ""Character"": ""Lesley Dimple"",
        ""Speaker"": ""Ann Montenbruck""
      },
      {
        ""Character"": ""Regina Pearson"",
        ""Speaker"": ""Ingeborg Kallweit""
      },
      {
        ""Character"": ""Mr Horowitz"",
        ""Speaker"": ""Herrmann Otto""
      },
      {
        ""Character"": ""Mr Rothman"",
        ""Speaker"": ""Peter Weiss""
      },
      {
        ""Character"": ""Mrs O'Rien"",
        ""Speaker"": ""Victoria von Trautmannsorff""
      }
    ]
  },
  {
    ""Id"": ""138825db-c686-47bd-8d10-f9887fdf2848"",
    ""Title"": ""Codename: Cobra"",
    ""NumberEuropa"": 116,
    ""ReleaseDate"": ""2004-06-14T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/115.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Kann ein Toter E-Mails versenden? Die 10-jährige Julia hat eine verschlüsselte E-Mail erhalten - von ihrem toten Bruder Ted! Sie bittet die drei ??? um Hilfe. Dann verschwindet das Mädchen plötzlich. Zurück bleibt eine E-Mail auf ihrem PC, die das grässliche Bild einer drohenden Kobra zeigt. Welche Bedeutung hat die Schlange? Wer ist der Absender der Nachricht? Was ist mit dem Mädchen geschehen? Die drei erfolgreichen Detektive aus Rocky Beach müssen haarscharf kombinieren, um den Schlüssel zur Lösung in diesem gefährlichen Fall zu finden."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mr Applegate"",
        ""Speaker"": ""Stephan Benson""
      },
      {
        ""Character"": ""Julia Applegate"",
        ""Speaker"": ""Sophie Lechtenbrink""
      },
      {
        ""Character"": ""Teddy Applegate"",
        ""Speaker"": ""Jona Mues""
      },
      {
        ""Character"": ""Rafter"",
        ""Speaker"": ""Volker Bogdan""
      },
      {
        ""Character"": ""Archie"",
        ""Speaker"": ""Bertram Hiese""
      },
      {
        ""Character"": ""Jenny Collins"",
        ""Speaker"": ""Anja Topf""
      }
    ]
  },
  {
    ""Id"": ""c7c20ba4-9be8-4f14-a2ba-02fd82673ec6"",
    ""Title"": ""Der finstere Rivale"",
    ""NumberEuropa"": 117,
    ""ReleaseDate"": ""2004-09-06T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/117.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Mitten in der Nacht wird von einem Unbekannten ein geheimnisvoller Koffer über den Zaun des Schrottplatzes geworfen. Justus, Peter und Bob trauen ihren Augen kaum, als sie feststellen, was das Fundstück enthält. Wer hat den Koffer über den Zaun geworfen? Und warum? Für wen war er eigentlich bestimmt? Die drei ??? stürzen sich in die Ermittlungen. Doch erst als auf dem Schrottplatz ein Feuer ausbricht, realisieren die drei Detektive, dass sie in großer Gefahr schweben ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godwin"",
        ""Speaker"": ""André Minninger""
      },
      {
        ""Character"": ""Wagner"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Beaumont"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Calhoon"",
        ""Speaker"": ""Bernd Stephan""
      },
      {
        ""Character"": ""Mike"",
        ""Speaker"": ""Arndt Schmöle""
      },
      {
        ""Character"": ""Zia"",
        ""Speaker"": ""Brigitte Böttrich""
      }
    ]
  },
  {
    ""Id"": ""eb834868-10b6-4084-8f21-3edf23a2cf0a"",
    ""Title"": ""Das düstere Vermächtnis"",
    ""NumberEuropa"": 118,
    ""ReleaseDate"": ""2004-09-06T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/118.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Unheimliche und gefährliche Dinge geschehen bei der Theatergruppe REALITY 5, seit der verstorbene Drehbuchautor Scott Carrara der Truppe sein letztes Werk - \""Das düstere Vermächtnis\"" - zur Uraufführung hinterlassen hat. Der Spürsinn der Drei ??? ist geweckt: Welche Rolle spielt das Rätsel der Königin von Saba, das Carrara in seinem Theaterstück verarbeitet hat? Und was hat ein Steinzeitmensch im Wohnwagen verloren? Eigentlich wollten Peter und Bob nur ein Schulpraktikum bei REALITY 5 machen, aber ein Blick hinter die Kulissen beschert den drei Detektiven unversehens einen neuen Fall..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Ralph"",
        ""Speaker"": ""Jan-David Rönfeld""
      },
      {
        ""Character"": ""Robbie"",
        ""Speaker"": ""Manfred Reddemann""
      },
      {
        ""Character"": ""Jack"",
        ""Speaker"": ""Daniel Brühl""
      },
      {
        ""Character"": ""Dennis"",
        ""Speaker"": ""Stefan Brönneke""
      },
      {
        ""Character"": ""Gina"",
        ""Speaker"": ""Chiara Ferraú""
      },
      {
        ""Character"": ""Charly"",
        ""Speaker"": ""Aaron Lee Ullmer""
      },
      {
        ""Character"": ""Sheriff"",
        ""Speaker"": ""Harry Rowohlt""
      },
      {
        ""Character"": ""Turnbull"",
        ""Speaker"": ""Detlef Bierstedt""
      },
      {
        ""Character"": ""Jenny Collins"",
        ""Speaker"": ""Anja Topf""
      },
      {
        ""Character"": ""Dizzy"",
        ""Speaker"": ""Marion Klaus""
      }
    ]
  },
  {
    ""Id"": ""ebd06fe3-6859-4ffe-bbcd-dfdec3b00b68"",
    ""Title"": ""Der schwarze Skorpion"",
    ""NumberEuropa"": 120,
    ""ReleaseDate"": ""2005-01-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/120.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bei der Beachvolleyball-Weltmeisterschaft in Rocky Beach wird ein Spieler der amerikanischen Mannschaft von einem riesigen Skorpion gestochen und schwebt in Lebensgefahr. Wie ist das giftige Spinnentier in den Sand des Spielfeldes geraten? Wurde hier ein Anschlag verübt? Die drei ??? nehmen die Ermittlungen auf und bekommen es mit weiteren unheimlichen Tieren zu tun ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Ken Parker"",
        ""Speaker"": ""Jürgen Holdorf""
      },
      {
        ""Character"": ""Dr. Robinson"",
        ""Speaker"": ""Heinz Lieven""
      },
      {
        ""Character"": ""Mickey McQuire"",
        ""Speaker"": ""Marco Sand""
      },
      {
        ""Character"": ""Mrs. Bancroft"",
        ""Speaker"": ""Ilka Kirsch""
      },
      {
        ""Character"": ""Trevis"",
        ""Speaker"": ""Manou Lubowski""
      },
      {
        ""Character"": ""Zuschauer"",
        ""Speaker"": ""Alexander Müller""
      },
      {
        ""Character"": ""Strandgirl"",
        ""Speaker"": ""Veronika Neugebauer""
      }
    ]
  },
  {
    ""Id"": ""e861e09e-deae-4b02-8206-1ac6ddf3b5f1"",
    ""Title"": ""Spur ins Nichts"",
    ""NumberEuropa"": 121,
    ""ReleaseDate"": ""2008-04-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/121.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Justus sitzt in der Falle! Orientierungslos und ohne Erinnerung erwacht er in einer dunklen, kalten, verschlossenen Kammer. Wurde der Erste Detektiv entführt und in ein geheimes Versteck gebracht? Und wer ist der junge Mann, der mit ihm eingeschlossen ist? Kann er sich tatsächlich auch an nichts erinnern? Oder weiß er mehr, als er Justus verraten will? Die Drei ??? werden in einen höchst mysteriösen Fall verwickelt, in dem sie scharf kombinieren müssen, um dem Gegner auf die Spur zu kommen. Und dieser schreckt vor nichts zurück ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Shawn"",
        ""Speaker"": ""Robin Brosch""
      },
      {
        ""Character"": ""Jolene"",
        ""Speaker"": ""Marion Elskis""
      },
      {
        ""Character"": ""Leah"",
        ""Speaker"": ""Susanne Sternberg""
      },
      {
        ""Character"": ""Jelena"",
        ""Speaker"": ""Alexandra Doerk""
      },
      {
        ""Character"": ""Sue"",
        ""Speaker"": ""Kerstin Hilbig""
      },
      {
        ""Character"": ""Kimberly Lloyd"",
        ""Speaker"": ""Ingeborg Christiansen""
      },
      {
        ""Character"": ""William Boyd"",
        ""Speaker"": ""Olaf Kreutzenbeck""
      },
      {
        ""Character"": ""Thorndike"",
        ""Speaker"": ""Michael Lott""
      }
    ]
  },
  {
    ""Id"": ""83e0d114-0520-4b82-9164-c49840ffe32e"",
    ""Title"": ""... und der Geisterzug"",
    ""NumberEuropa"": 122,
    ""ReleaseDate"": ""2008-04-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/122.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die Fahrt mit dem Museumszug hatten sich die drei Detektive aus Rocky Beach eigentlich gemütlicher vorgestellt. Doch spätestens im Eisenbahntunnel durch den Black Mountain vergeht den Freunden die Ausflugslaune. Die Durchfahrt wird aufs Gruseligste boykottiert. Natürlich glauben die Drei ??? kein Wort von der Spukgeschichte, nach der verunglückte Arbeiter ihr geisterhaftes Unwesen im Tunnel treiben sollen. Doch um herauszufinden, wer tatsächlich hinter den üblen Machenschaften steckt, bleiben Justus, Peter und Bob nur wenige Stunden ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Fred Jenkins"",
        ""Speaker"": ""Nick Seidensticker""
      },
      {
        ""Character"": ""Mr Campbell"",
        ""Speaker"": ""Gerhart Hinze""
      },
      {
        ""Character"": ""Sam Reilly"",
        ""Speaker"": ""Jürgen Strube""
      },
      {
        ""Character"": ""Carl Sheehan"",
        ""Speaker"": ""Michael Weckler""
      },
      {
        ""Character"": ""Collins"",
        ""Speaker"": ""Thorsten Weber""
      },
      {
        ""Character"": ""Mr Kingsley"",
        ""Speaker"": ""Herbert Tennigkeit""
      },
      {
        ""Character"": ""Mrs Kingsley"",
        ""Speaker"": ""Tina Rehfeld-Wildmann""
      },
      {
        ""Character"": ""Devlin Reno"",
        ""Speaker"": ""J�rg Pleva""
      },
      {
        ""Character"": ""Dr. Long"",
        ""Speaker"": ""Lou Wong""
      }
    ]
  },
  {
    ""Id"": ""8ea3247c-9ed0-4e20-aa7e-7130d910971d"",
    ""Title"": ""Fußballfieber"",
    ""NumberEuropa"": 123,
    ""ReleaseDate"": ""2008-05-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/123.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Peter, der Zweite Detektiv, trainiert begeistert für die kalifornischen Schulfußballmeisterschaften. Zur gleichen Zeit erscheint ein Junge auf dem Schrottplatz und bittet die drei ??? um Hilfe: Im Haus seiner Großeltern geschehen unheimliche Dinge und die beiden alten Leute sind überzeugt, dass sie es mit den schrecklichen Vorzeichen des Todes zu tun haben. Als Justus, Peter und Bob die Ermittlungen aufnehmen, ahnen sie nicht, welche Gefahren noch auf sie zukommen werden..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Emiliano"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Pancho"",
        ""Speaker"": ""Ben Hecker""
      },
      {
        ""Character"": ""Esperanza"",
        ""Speaker"": ""Ingeborg Christiansen""
      },
      {
        ""Character"": ""Pedro"",
        ""Speaker"": ""Anton Sprick""
      },
      {
        ""Character"": ""Abelardo"",
        ""Speaker"": ""Peter Heinrich Brix""
      },
      {
        ""Character"": ""---"",
        ""Speaker"": ""...""
      }
    ]
  },
  {
    ""Id"": ""9992a0b8-6f4f-430e-9612-66ea6ba7cff2"",
    ""Title"": ""Geister-Canyon"",
    ""NumberEuropa"": 124,
    ""ReleaseDate"": ""2008-07-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/124.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Als die Drei ??? versprechen, bei einer Lösegeldübergabe zu helfen, ahnen sie noch nicht, was auf sie zukommt. Unversehens befinden sie sich auf einer nervenaufreibenden Irrfahrt durch den wilden Westen Amerikas. Welchen hinterhältigen Plan verfolgt der Erpresser? Wozu lockt er sie in die tiefsten und gefährlichsten Canyons? Und dann geschieht, was nie hätte geschehen dürfen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. O'Sullivan"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""Butler Paul"",
        ""Speaker"": ""Volker Bogdan""
      },
      {
        ""Character"": ""Dick Perry"",
        ""Speaker"": ""Ernst H.Hilbich""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Frank Thannhäuser""
      },
      {
        ""Character"": ""Aufsicht"",
        ""Speaker"": ""Patrick Bach""
      }
    ]
  },
  {
    ""Id"": ""8562f696-8e18-40de-b25c-17446ea5ec5a"",
    ""Title"": ""Feuermond"",
    ""NumberEuropa"": 125,
    ""ReleaseDate"": ""2008-10-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/125.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Rätselhafte Briefe eines verstorbenen Malers bringen Die drei ??? auf die Spur eines verschollenes Gemäldes... Und der Gegenspieler der Detektive aus Rocky Beach ist kein geringerer als der französische Meisterdieb Victor Hugenay! Wird es den drei ??? gelingen, das Rätsel um Feuermond zu lüften? Teil A: Das Rätsel der Meister Justus, Peter und Bob sind alte Briefe des berühmten verstorbenen Malers Jaccard zugespielt worden. Warum will jemand das Interesse der drei ??? auf das Gemälde Feuermond lenken, von dem in den Briefen die Rede ist? Und vor allen Dingen: Wer steckt dahinter? Als der international gesuchte Meisterdieb Victor Hugenay auftaucht, ist endgültig klar: Die drei ??? befinden sich wieder mitten in einem gefährlichen Abenteuer... Teil B: Der Pfad der Täuschung Welche Informationen hat der gesuchte Meisterdieb Victor Hugenay über das berühmte, verschollene Gemälde Feuermond, hinter dem so viele her sind? Justus, Peter und Bob müssen haarscharf kombinieren. Unter Einsatz aller Kräfte treiben die drei ??? den Fall voran. Sogar die Zentrale, der betagte Wohnwagen, muss für einen atemberaubenden Einsatz auf kurvenreicher Straße herhalten... Teil C: Die Nacht der Schatten Auf einer kleinen Insel vor Rocky Beach treffen die drei ??? in nächtlicher Finsternis erneut auf den Meisterdieb Hugenay. Die Jagd nach Feuermond beginnt. Und schnell zeigt sich, dass es die drei Detektive mit mehr als einem Widersacher zu tun haben. Wem wird es gelingen, das Gemälde zu finden und das große Geheimnis um Feuermond zu lüften?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Tante Mathilda Jonas"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Brittany"",
        ""Speaker"": ""Dorette Hugo""
      },
      {
        ""Character"": ""Hugenay"",
        ""Speaker"": ""Albert Giro [Wolfgang Kubach]""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Jaccard (Off-Stimme)"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Andy Miller"",
        ""Speaker"": ""Jannik Endemann""
      },
      {
        ""Character"": ""Sharon Lockwood"",
        ""Speaker"": ""Nova Meierheinrich""
      },
      {
        ""Character"": ""Rubbish George"",
        ""Speaker"": ""Utz Richter""
      },
      {
        ""Character"": ""Charles Knox"",
        ""Speaker"": ""Dirk Bach""
      },
      {
        ""Character"": ""Graham, Reporter"",
        ""Speaker"": ""Thomas Bammer""
      },
      {
        ""Character"": ""Julianne Wallace"",
        ""Speaker"": ""Marlen Diekhoff""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Mrs. Albright"",
        ""Speaker"": ""Lotti Krekel""
      },
      {
        ""Character"": ""Mr. Myers"",
        ""Speaker"": ""Eberhard Haar""
      },
      {
        ""Character"": ""Mr. Barker"",
        ""Speaker"": ""Wolf Pahls""
      },
      {
        ""Character"": ""Lkw-Fahrer"",
        ""Speaker"": ""Nick Heidfeld""
      },
      {
        ""Character"": ""Moderator"",
        ""Speaker"": ""Holger Wemhoff""
      },
      {
        ""Character"": ""Ansager"",
        ""Speaker"": ""Bertram Hiese""
      },
      {
        ""Character"": ""Nachtschatten"",
        ""Speaker"": ""Frank Tannhäuser""
      },
      {
        ""Character"": ""Polizist 1"",
        ""Speaker"": ""Fabian Harloff""
      },
      {
        ""Character"": ""Polizist 2"",
        ""Speaker"": ""Erik Schäffler""
      }
    ]
  },
  {
    ""Id"": ""d776ef70-4c30-43b6-9963-c1033e17d22b"",
    ""Title"": ""Schrecken aus dem Moor"",
    ""NumberEuropa"": 126,
    ""ReleaseDate"": ""2008-11-14T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/126.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Glücklicherweise ruht der tote Körper aus der vorgeschichtlichen Eisenzeit als Ausstellungsstück in einem Glaskasten im Steadman Museum. Doch ausgerechnet während Peters Schicht als Nachtwächter scheint die gruselige Moorleiche zu erwachen und ihr Unwesen in den verlassenen Gängen des Museums zu treiben. An die plötzliche Auferstehung einer Jahrtausendealten Leiche können Justus, Peter und Bob natürlich nicht glauben - auch wenn alle Indizien genau darauf hinweisen ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Dr. Chandler"",
        ""Speaker"": ""Wolf Pahlke""
      },
      {
        ""Character"": ""Max"",
        ""Speaker"": ""Sven Dahlem""
      },
      {
        ""Character"": ""Austin"",
        ""Speaker"": ""Patrick Bach""
      },
      {
        ""Character"": ""Dwain"",
        ""Speaker"": ""Tim Knauer""
      },
      {
        ""Character"": ""Mr. Monroe"",
        ""Speaker"": ""Jochen Regelin""
      },
      {
        ""Character"": ""Professor Rosenberg"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Papagei"",
        ""Speaker"": ""Heikedine Körting""
      }
    ]
  },
  {
    ""Id"": ""bc49b3a8-0cd9-4aa7-b31e-a208836c4e49"",
    ""Title"": ""Schwarze Madonna"",
    ""NumberEuropa"": 127,
    ""ReleaseDate"": ""2008-12-05T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/127.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Als Peter einen verletzten jungen Mann aus dem Meer rettet, ahnt er noch nicht, dass er damit auch einen neuen Fall für die drei ??? an Land zieht. Doch schon kurze Zeit später befinden sich die drei Detektive aus Rocky Beach mitten in einem spannenden Abenteuer, in dem eine verschwundene Marienstatue die Hauptrolle spielt. Wie viele Gegner gibt es bei dieser gefährlichen Jagd? Wie weit werden sie gehen, um die begehrte Schwarze Madonna zu bekommen? Justus, Peter und Bob stoßen an ihre Grenzen. Dieser Fall ist gefährlich, sehr gefährlich. Er bedroht sogar die Existenz ihres Detektivunternehmens..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Goodween"",
        ""Speaker"": ""André Minninger""
      },
      {
        ""Character"": ""José"",
        ""Speaker"": ""Patrick Bach""
      },
      {
        ""Character"": ""Steve Bright"",
        ""Speaker"": ""Marek Erhardt""
      },
      {
        ""Character"": ""Brian Smith"",
        ""Speaker"": ""Christian Rode""
      },
      {
        ""Character"": ""Martin"",
        ""Speaker"": ""Jesse Grimm""
      },
      {
        ""Character"": ""Wächter"",
        ""Speaker"": ""Sven Dahlem""
      },
      {
        ""Character"": ""Mrs. Osborne"",
        ""Speaker"": ""Anja Nejarri""
      },
      {
        ""Character"": ""Mr. Pentecost"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""Senora Gonzales"",
        ""Speaker"": ""Susanne von Loessl""
      }
    ]
  },
  {
    ""Id"": ""06d16723-5a66-47fb-9737-2133e5083a28"",
    ""Title"": ""Schatten über Hollywood"",
    ""NumberEuropa"": 128,
    ""ReleaseDate"": ""2009-02-06T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/128.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Geister gibt es nicht - davon sind Justus, Peter und Bob überzeugt. Bis sich eines Nachts eine unheimliche weiße Gestalt vom berühmten Hollywood-Schriftzug in den Hollywood Hills stürzt und spurlos verschwindet. Haben es die drei ??? mit dem Geist der verstorbenen Schauspielerin Casey Wye zu tun? Fragmente eines seltsamen Briefes weisen darauf hin. Als dann auch noch verschiedene Menschen in hinterhältige Fallen geraten, ist klar: Justus, Peter und Bob müssen schwer auf der Hut sein, wenn sie dieses Geheimnis lüften und dabei mit heiler Haut davonkommen wollen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs Bennett"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Wächter"",
        ""Speaker"": ""Marek Erhardt""
      },
      {
        ""Character"": ""Crowle"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""Casey Wye"",
        ""Speaker"": ""Gisela Trowe""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Oliver Taper"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""2633e7f8-9be8-41b3-b910-96f60ddb3d35"",
    ""Title"": ""SMS aus dem Grab"",
    ""NumberEuropa"": 129,
    ""ReleaseDate"": ""2009-03-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/129.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Als Rubbish George, der schrullige Stadtstreicher aus Rocky Beach, von einem Tag auf den anderen verschwindet, ahnen Justus, Peter und Bob sofort, dass hier etwas nicht mit rechten Dingen zugeht. Zwischen den wenigen Habseeligkeiten des wunderlichen Mannes finden die drei Detektive einen rätselhaften Brief. Die Spur führt zu den Pyramiden in Ägypten! Welches Geheimnis aber will Rubbish George dort lüften? Die drei ??? begeben sich in das dunkle Reich der Sphinx - und geraten dabei in eine Falle..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Layla"",
        ""Speaker"": ""Saskia Weckler""
      },
      {
        ""Character"": ""Alaa Edine"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""Abazza"",
        ""Speaker"": ""Abdul Kader-Diab""
      },
      {
        ""Character"": ""Kamelhändler"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""Kamelführer"",
        ""Speaker"": ""Fathi Farnazmatis""
      },
      {
        ""Character"": ""Wärter"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Ägypter"",
        ""Speaker"": ""Lothar Grützner""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Rubbish George"",
        ""Speaker"": ""Utz Richter""
      },
      {
        ""Character"": ""Kommissar"",
        ""Speaker"": ""Klaus Dittmann""
      },
      {
        ""Character"": ""Aisha"",
        ""Speaker"": ""Susanne von Loessl""
      },
      {
        ""Character"": ""Verkäufer"",
        ""Speaker"": ""Farhat Al Yhi""
      },
      {
        ""Character"": ""Dick Vincent"",
        ""Speaker"": ""Holger Löwenberg""
      },
      {
        ""Character"": ""Taxifahrer"",
        ""Speaker"": ""Wolf Pahlke""
      }
    ]
  },
  {
    ""Id"": ""3da0fffa-9fe9-4ec1-9fa4-a66b13343ff2"",
    ""Title"": ""Der Fluch des Drachen"",
    ""NumberEuropa"": 130,
    ""ReleaseDate"": ""2009-05-15T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/130.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Durch Justus Jonas' Schuld ist eine wertvolle Vase, die ein Kunde auf dem Schrottplatz deponiert hatte, in tausend Scherben zersprungen. Die drei ??? haben 24 Stunden Zeit, um für Ersatz zu sorgen. Aber nicht nur Justus, Peter und Bob haben großes Interesse an einer dunkelblauen Vase mit einem weißen Drachenmotiv. Ein gefährliches Abenteuer nimmt seinen Lauf ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Beverly Leung"",
        ""Speaker"": ""Susanne Stangl""
      },
      {
        ""Character"": ""Thomas Johnson"",
        ""Speaker"": ""Lutz Herkenrath""
      },
      {
        ""Character"": ""1. Polizist"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""2. Polizist"",
        ""Speaker"": ""Edgar Hoppe""
      },
      {
        ""Character"": ""James"",
        ""Speaker"": ""Sönke Städtler""
      },
      {
        ""Character"": ""Daniel Baker"",
        ""Speaker"": ""Sascha Rotermund""
      },
      {
        ""Character"": ""Mr. Grogan"",
        ""Speaker"": ""Günter Flesch""
      }
    ]
  },
  {
    ""Id"": ""91a02363-6734-491e-8e84-99e875d4b970"",
    ""Title"": ""Haus des Schreckens"",
    ""NumberEuropa"": 131,
    ""ReleaseDate"": ""2009-07-03T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/131.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Was geht im Marriott House, dem gruseligen alten Gebäude draußen auf einer einsamen Insel, vor sich? Spukt es dort tatsächlich? Als eine Person entführt wird und unheimliche Spuren Böses ahnen lassen, ist schnell klar: Dies ist ein Fall für die drei ???! Wer oder was hat den berühmten Musikproduzenten Lloyd Scavenger in seiner Gewalt? Justus, Peter und Bob, die drei erfolgreichen Detektive aus Rocky Beach, nehmen die Spur auf - und geraten in ein Labyrinth, in dem hinter jeder Ecke ein neues Rätsel wartet ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Lloyd Scanvenger"",
        ""Speaker"": ""Stefan Benson""
      },
      {
        ""Character"": ""Jack Lowell"",
        ""Speaker"": ""Siegfried Kernen""
      },
      {
        ""Character"": ""Alexander Nolan"",
        ""Speaker"": ""Wilfried Hochholdinger""
      },
      {
        ""Character"": ""Jaqueline William"",
        ""Speaker"": ""Henrike Fehrs""
      },
      {
        ""Character"": ""Ian Parsley"",
        ""Speaker"": ""Jörg Gillner""
      },
      {
        ""Character"": ""Mary Parsley"",
        ""Speaker"": ""Karin Abicht""
      },
      {
        ""Character"": ""Jasper Kittle"",
        ""Speaker"": ""Peter Weis""
      },
      {
        ""Character"": ""Shawne Davison"",
        ""Speaker"": ""Susanne Lothar""
      },
      {
        ""Character"": ""Officer Wood"",
        ""Speaker"": ""Roman Kretschmer""
      },
      {
        ""Character"": """",
        ""Speaker"": """"
      }
    ]
  },
  {
    ""Id"": ""3794d7fd-fff0-48b2-beca-94a5018e65f5"",
    ""Title"": ""Spuk im Netz"",
    ""NumberEuropa"": 132,
    ""ReleaseDate"": ""2009-08-21T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/132.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Miss Bennett, die Leiterin der Bücherei in Rocky Beach, ist verschwunden! Eine überstürzt verlassene Wohnung, gelöschte Dateien und ein Zettel mit einer Reihe merkwürdiger Zahlen weisen auf einen äußerst mysteriösen Fall hin. Die drei ??? machen sich auf die Suche. Bald schon wissen sie: die Bibliothekarin ist den geheimnisvollen Zeichen einer geisterhaften Erscheinung im Internet gefolgt. Wohin soll sie gelockt werden? Welche Botschaft hat sie erhalten? Die Antwort steht in den Sternen! Werden die drei erfolgreichen Detektive aus Rocky Beach sie lesen können?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Miss Bennett"",
        ""Speaker"": ""Renate Pichler""
      },
      {
        ""Character"": ""Karen"",
        ""Speaker"": ""Céline Fontanges""
      },
      {
        ""Character"": ""Becky"",
        ""Speaker"": ""Katharina von Keller""
      },
      {
        ""Character"": ""Felicia Sparing"",
        ""Speaker"": ""Rhea Harder""
      },
      {
        ""Character"": ""Mrs. Amelia Sparing"",
        ""Speaker"": ""Karin Buchholz""
      },
      {
        ""Character"": ""Mr. Sparing"",
        ""Speaker"": ""Sky du Mont""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Professor Alkurah"",
        ""Speaker"": ""Ben Hecker""
      },
      {
        ""Character"": ""Erroll"",
        ""Speaker"": ""Bertram Hiese""
      },
      {
        ""Character"": ""Mrs. Featherstone"",
        ""Speaker"": ""Sabine Hahn""
      },
      {
        ""Character"": ""Wärter"",
        ""Speaker"": ""Jürgen Hohldorf""
      }
    ]
  },
  {
    ""Id"": ""1e012039-ebf9-48bd-a488-03feb5d2dde1"",
    ""Title"": ""Fels der Dämonen"",
    ""NumberEuropa"": 133,
    ""ReleaseDate"": ""2009-10-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/133.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein toller Sandstrand in einer einsamen Bucht, perfektes Surf-Wetter, ein schattiges Plätzchen für das Zelt: Die drei ??? freuen sich auf ein paar stressfreie Ferientage am Meer. Doch dann taucht ein völlig verängstigter Junge auf und berichtet von einem gruseligen schwarzen Zwerg, der ihn verfolgt. Als der Zweite Detektiv kurze Zeit darauf beim Wellenreiten eine mehr als unheimliche Begegnung im Wasser hat, ist klar: hier bahnt sich ein neuer Fall für die drei Detektive an! Wer oder was treibt sein Unwesen in der abgelegenen Bucht? Werden Justus, Peter und Bob das Geheimnis um den \""Fels der Dämonen\"" lüften?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Sergeant Ludlow"",
        ""Speaker"": ""Dietmar Mues""
      },
      {
        ""Character"": ""Banden-Chef"",
        ""Speaker"": ""Eberhard Haar""
      },
      {
        ""Character"": ""Eddy Reardon"",
        ""Speaker"": ""Lukas Sperber""
      },
      {
        ""Character"": ""Spanier"",
        ""Speaker"": ""Eric Schaeffler""
      },
      {
        ""Character"": ""Jack"",
        ""Speaker"": ""Fabian Harloff""
      },
      {
        ""Character"": ""Italiener"",
        ""Speaker"": ""Lutz Harder""
      },
      {
        ""Character"": ""Gauner"",
        ""Speaker"": ""Sven Dahlem""
      },
      {
        ""Character"": ""Gehilfe"",
        ""Speaker"": ""Gerhart Hinze""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Bertram Hiese""
      }
    ]
  },
  {
    ""Id"": ""92d1d50b-872b-4d5e-8967-5899d6b66114"",
    ""Title"": ""Der tote Mönch"",
    ""NumberEuropa"": 134,
    ""ReleaseDate"": ""2009-10-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/134.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein böser Geist will Christine Harkinson von ihrem Anwesen vertreiben! Davon ist zumindest ihr Gärtner überzeugt. Lo Wang bangt um das Leben seiner Arbeitgeberin. Justus, Peter und Bob, die drei erfolgreichen Detektive aus Rocky Beach, machen sich auf die Suche nach dem ominösen Geist. Wer oder was steckt hinter der gruseligen Kapuzengestalt, die nachts ihr Unwesen im Garten treibt? Als die drei ??? ein offenes altes Grab entdecken, ist sich Peter ganz sicher: Ein toter Mönch verfolgt Christine! Doch worauf hat er es abgesehen...?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Christine"",
        ""Speaker"": ""Inken Sommer""
      },
      {
        ""Character"": ""Mr. Bambridge"",
        ""Speaker"": ""Gustav-Adolph Artz""
      },
      {
        ""Character"": ""Lo Wang"",
        ""Speaker"": ""Dae Joon Yoo""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Anthony Hearst"",
        ""Speaker"": ""Wolfgang Pampel""
      },
      {
        ""Character"": ""Truckfahrer"",
        ""Speaker"": ""Konstantin Graudus""
      },
      {
        ""Character"": ""Avercromby"",
        ""Speaker"": ""Nicolas König""
      }
    ]
  },
  {
    ""Id"": ""951925e3-e4e5-45f0-b845-428ca981f836"",
    ""Title"": ""Fluch des Piraten"",
    ""NumberEuropa"": 135,
    ""ReleaseDate"": ""2009-11-27T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/135.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine Reihe rätselhafter Fotos weckt die Neugier der drei erfolgreichen Detektive aus Rocky Beach. Alles deutet darauf hin, dass ein kostbarer Goldschatz auf einer einsamen Insel verborgen ist. Doch vor Ort wird schnell klar, dass nicht nur Justus, Peter und Bob dem Schatz auf der Spur sind. Es beginnt eine Jagd mit ungewissem Ausgang."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Pilot"",
        ""Speaker"": ""Gerhart Hinze""
      },
      {
        ""Character"": ""Max"",
        ""Speaker"": ""Traudel Sperber""
      },
      {
        ""Character"": ""Liolotta"",
        ""Speaker"": ""Peter Striebeck""
      },
      {
        ""Character"": ""Althena"",
        ""Speaker"": ""Steffi Kirchberger""
      },
      {
        ""Character"": ""Sarah Livingston"",
        ""Speaker"": ""Rosemarie Wohlbauer""
      },
      {
        ""Character"": ""Elvira Zuckerman"",
        ""Speaker"": ""Konstanze Ullmer""
      }
    ]
  },
  {
    ""Id"": ""d3972585-2d87-4eab-a45e-11ba0297fbc3"",
    ""Title"": ""... und das versunkene Dorf"",
    ""NumberEuropa"": 136,
    ""ReleaseDate"": ""2010-02-05T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/136.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""In einem kleinen Bergdorf scheint ein Geist sein Unwesen am nahe gelegenen See zu treiben! Welch dunkles Geheimnis verbirgt sich in den Tiefen des Gewässers? Wer oder was steckt hinter der gespenstischen Erscheinung am Ufer? Die drei ??? gehen auf Tauchstation, um das Geheimnis zu lüften. Und dann entdecken sie das Unvorstellbare ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Darren Duff"",
        ""Speaker"": ""Jesse Grimm""
      },
      {
        ""Character"": ""Carl"",
        ""Speaker"": ""Oliver Böttcher""
      },
      {
        ""Character"": ""Joan"",
        ""Speaker"": ""Christine Pappert""
      },
      {
        ""Character"": ""Paul Brooks"",
        ""Speaker"": ""Heinz Lieven""
      },
      {
        ""Character"": ""Joe Wilcox"",
        ""Speaker"": ""Rolf Becker""
      },
      {
        ""Character"": ""Cassandra Wilcox"",
        ""Speaker"": ""Elke Reissert""
      },
      {
        ""Character"": ""Daniel"",
        ""Speaker"": ""Jochen Baumert""
      },
      {
        ""Character"": ""Henry"",
        ""Speaker"": ""Frank Felicetti""
      },
      {
        ""Character"": ""Doktor Holloway"",
        ""Speaker"": ""Barbara Focke""
      },
      {
        ""Character"": ""Cedric Duff"",
        ""Speaker"": ""Rolf E. Schenker""
      }
    ]
  },
  {
    ""Id"": ""63b48f53-b253-4ab1-898e-7e89e0189f3f"",
    ""Title"": ""Pfad der Angst"",
    ""NumberEuropa"": 137,
    ""ReleaseDate"": ""2010-03-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/137.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein neuer Fall bahnt sich an, ganz nach dem Geschmack der drei erfolgreichen Detektive aus Rocky Beach: Ein verschrobener Wissenschaftler bittet die drei ??? um Hilfe bei der Wiederbeschaffung einer Erfindung, die ihm gestohlen wurde. Doch dann häufen sich merkwürdige Geschehnisse und behindern die Recherchen. Natürlich lassen sich Justus, Peter und Bob zunächst nicht beeindrucken - bis sie um ihr Leben bangen müssen ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Winston Granville"",
        ""Speaker"": ""Christian Rode""
      },
      {
        ""Character"": ""Matthew Granville"",
        ""Speaker"": ""Uwe Friedrichsen""
      },
      {
        ""Character"": ""Smithy"",
        ""Speaker"": ""Konstantin Graudus""
      },
      {
        ""Character"": ""Mr. Jackmore"",
        ""Speaker"": ""Michael Brennicke""
      },
      {
        ""Character"": ""Professor Frazier"",
        ""Speaker"": ""Wilhelm Wieben""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Tetje Mierendorf""
      }
    ]
  },
  {
    ""Id"": ""d373c97d-705c-434f-8d83-57a8dfcf5304"",
    ""Title"": ""Die geheime Treppe"",
    ""NumberEuropa"": 138,
    ""ReleaseDate"": ""2010-05-21T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/138.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Warum wurde der junge Wissenschaftler Davy Swann entführt? Und warum nannten ihn die vermummten Täter immer Philippe? Justus, Peter und Bob nehmen die Spur auf. Diese führt in das labyrinthische Gebäude der Universität mit geheimen Treppen und einer düsteren Bibliothek. Hier stoßen die drei ??? auf ein merkwürdiges Buch und seltsame Verse. Natürlich knacken die drei erfolgreichen Detektive aus Rocky Beach das Rätsel. Doch dann fangen die Schwierigkeiten erst an ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Davy Swann"",
        ""Speaker"": ""Torsten Sense""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Craig Holden"",
        ""Speaker"": ""Gerhard Olschewski""
      },
      {
        ""Character"": ""Löwenritter"",
        ""Speaker"": ""Burghart Klaußner""
      }
    ]
  },
  {
    ""Id"": ""00cbd571-bc84-4652-a0b4-da7ad87cbdf5"",
    ""Title"": ""Das Geheimnis der Diva"",
    ""NumberEuropa"": 139,
    ""ReleaseDate"": ""2010-07-09T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/139.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Seltsame Vorkommnisse überschatten die Proben der Laienspielgruppe \""Die Masken\"" im alten Stadttheater von Rocky Beach: Kulissen verschwinden und eine Schauspielerin wird hinter der Bühne von einem grässlichen Phantom angegriffen. Wer oder was treibt sein Unwesen in dem verwinkelten Theatergebäude? Hängen die Ereignisse mit der international bekannten Schauspielerin Helena Darraz zusammen, die in wenigen Tagen nach Rocky Beach kommen will? Sofort nehmen die drei ??? die Ermittlungen auf. Und es wird gefährlich ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Helena Darraz"",
        ""Speaker"": ""Ingrid Andree""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Pritchard"",
        ""Speaker"": ""Sascha Rotermund""
      },
      {
        ""Character"": ""Sid"",
        ""Speaker"": ""Tilman Madaus""
      },
      {
        ""Character"": ""Caroline"",
        ""Speaker"": ""Celine Fontanges""
      },
      {
        ""Character"": ""Sandy"",
        ""Speaker"": ""Simona Pahl""
      },
      {
        ""Character"": ""Steven"",
        ""Speaker"": ""René Dawn-Claude""
      },
      {
        ""Character"": ""Ernest"",
        ""Speaker"": ""Tim Kreuer""
      },
      {
        ""Character"": ""Radioansagerin"",
        ""Speaker"": ""Susanne Wulkow""
      },
      {
        ""Character"": ""Harvey Griscom"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""John Dellcourt"",
        ""Speaker"": ""Gustav Adolph Artz""
      },
      {
        ""Character"": ""Miss Darraz"",
        ""Speaker"": ""Sabine Hahn""
      }
    ]
  },
  {
    ""Id"": ""8c32477b-f7d9-4f09-994b-10ed4c49d1f5"",
    ""Title"": ""Stadt der Vampire"",
    ""NumberEuropa"": 140,
    ""ReleaseDate"": ""2010-08-20T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/140.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine riesige Fledermaus versetzt die Kleinstadt Yonderwood in Angst und Schrecken. Nachdem einige Menschen mit Bissspuren und einer Menge Blut in ihren Betten erwacht sind, hat der Großteil der Einwohner bereits das Weite gesucht. Justus, Peter und Bob haben noch nie an Vampire geglaubt. In diesem neuen Fall jedoch scheint es, als müssten die drei berühmten Detektive aus Rocky Beach ihre Meinung ändern ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas, Erster Detektiv"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw, Zweiter Detektiv"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews, Recherchen und Archiv"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Josy McDonaghough"",
        ""Speaker"": ""Lili Draeger""
      },
      {
        ""Character"": ""Homer Diesel"",
        ""Speaker"": ""Christian Senger""
      },
      {
        ""Character"": ""Mary Stamper"",
        ""Speaker"": ""Annabelle Krieg""
      },
      {
        ""Character"": ""Otis Stamper"",
        ""Speaker"": ""Klaus Dittmann""
      },
      {
        ""Character"": ""Jonathan Black"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""Miles Black"",
        ""Speaker"": ""Sascha Rotermund""
      },
      {
        ""Character"": ""Klara Kowalski"",
        ""Speaker"": ""Steffi Kirchberger""
      },
      {
        ""Character"": ""Silvester Proud"",
        ""Speaker"": ""Gustav Adolph Artz""
      },
      {
        ""Character"": ""Pfarrer Clark"",
        ""Speaker"": ""Gerd Baltus""
      }
    ]
  },
  {
    ""Id"": ""37e7f214-29c7-42e8-926e-4925b4d3df47"",
    ""Title"": ""T�dliches Eis"",
    ""NumberEuropa"": 142,
    ""ReleaseDate"": ""2010-12-03T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/142.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Schnee und Eis, Wölfe und arktische Stürme - das Nordic Wilderness Race ist eines der härtesten Schlittenhunderennen der Welt. Als die drei ??? von der Journalistin Carol Ford gefragt werden, ob sie bei der Reportage über das Rennen helfen wollen, sagen die Jungen begeistert zu. Doch damit lassen sie sich auf ein gefährliches Abenteuer ein. Als es zu einem ernsthaften Zwischenfall mit skrupellosen Verbrechern kommt, ist klar: Die drei Detektive müssen schnell handeln, damit dies nicht ihr letzter Fall wird!"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Carol Ford"",
        ""Speaker"": ""Claudia Schermutzki""
      },
      {
        ""Character"": ""Francis Studstill"",
        ""Speaker"": ""Elena Wilms""
      },
      {
        ""Character"": ""Baxter Norsworthy"",
        ""Speaker"": ""Udo Schenk""
      },
      {
        ""Character"": ""Gordon Hoke"",
        ""Speaker"": ""Holger Löwenberg""
      },
      {
        ""Character"": ""Jared Fox"",
        ""Speaker"": ""Meik Spallek""
      },
      {
        ""Character"": ""Candace Duskin"",
        ""Speaker"": ""Andrea Linau""
      },
      {
        ""Character"": ""George Bennet"",
        ""Speaker"": ""Urs Affolter""
      },
      {
        ""Character"": ""Greg Harper"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""Woodland"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Reporterin"",
        ""Speaker"": ""Jamie Leaves""
      },
      {
        ""Character"": ""Reporter"",
        ""Speaker"": ""Glenn Goltz""
      },
      {
        ""Character"": ""Wellford"",
        ""Speaker"": ""Oliver Geilhardt""
      },
      {
        ""Character"": ""Pilot"",
        ""Speaker"": ""Achim Schülke""
      }
    ]
  },
  {
    ""Id"": ""d17809ed-74f7-4cd3-bdc8-0ff1c246addc"",
    ""Title"": ""...und die Poker-H�lle"",
    ""NumberEuropa"": 143,
    ""ReleaseDate"": ""2010-12-03T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/143.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Als Justus, Peter und Bob einem jungen Mann helfen wollen, dem in einer Postfiliale Geld gestohlen wurde, geraten sie in die gefährliche Unterwelt von China Town. Zufällig kommen sie einer illegalen Pokerspielhölle auf die Spur. Dabei müssen die drei erfolgreichen Detektive aus Rocky Beach die Erfahrung machen, dass die Beteiligten sehr unangenehm werden, wenn man ihnen in die Karten sieht! Und dann geschieht, was nie hätte geschehen dürfen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Richie Hanson"",
        ""Speaker"": ""Dennis Schmidt-Foß""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Goodween"",
        ""Speaker"": ""André Minninger""
      },
      {
        ""Character"": ""Benni"",
        ""Speaker"": ""Ivo Möller""
      },
      {
        ""Character"": ""Jacki Jin"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Corinna Wodrich""
      },
      {
        ""Character"": ""Croupier"",
        ""Speaker"": ""Dirk Bach""
      }
    ]
  },
  {
    ""Id"": ""08a16070-b836-4642-ac90-8843384cd5ba"",
    ""Title"": ""Zwillinge der Finsternis"",
    ""NumberEuropa"": 144,
    ""ReleaseDate"": ""2011-01-28T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/144.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Es schneit bei 20 Grad über Null, ein riesiger Erdspalt tut sich über Nacht auf, seltsame Nebel wabern, und ein Mann lässt Flammen aus seiner Hand wachsen: Rocky Beach hat es mit dem Teufel zu tun! Das jedenfalls nimmt Peter an, als er und seine beiden Detektivkollegen in den Fall \""Zwillinge der Finsternis\"" geraten. Zwei in Leder gebundene Bücher sollen satanische Zauberformeln enthalten. Wer sie besitzt, hat teuflische Macht. Und es gibt einige Menschen, die hinter den beiden Büchern her sind. Ein Exemplar wurde bereits gestohlen! Die drei ??? müssen ihren Widersachern schnellstens zuvorkommen, um das Schlimmste zu verhindern..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus Jonas"",
        ""Speaker"": ""Hans Meinhardt""
      },
      {
        ""Character"": ""Arthur Sinclair"",
        ""Speaker"": ""Joachim Pukaß""
      },
      {
        ""Character"": ""Mr. Peastone"",
        ""Speaker"": ""Eberhard Haar""
      },
      {
        ""Character"": ""Jeremy Witherspoon"",
        ""Speaker"": ""Martin Semmelrogge""
      },
      {
        ""Character"": ""Barnaby Witherspoon"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""2f5a9f68-3b52-4a2c-a4c8-db5493f33ec1"",
    ""Title"": ""... und die Rache der Samurai"",
    ""NumberEuropa"": 145,
    ""ReleaseDate"": ""2011-03-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/145.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Auf dem Internat Shadow Stone geht es nicht mit rechten Dingen zu. Ein Schüler ist spurlos verschwunden, und die Mitglieder der Samurai-AG, die mit alten japanischen Schwertern kämpfen, verhalten sich mehr als merkwürdig. Um den Fall zu klären, schleusen sich die drei ??? in die Schule ein. Doch schnell bekommen sie zu spüren, dass sie hier unerwünscht sind. Und dann durchschneidet mit gefährlichem Schwung ein Schwert die Luft! - Warum bloß haben die drei Detektive diesen Auftrag angenommen? Warum bloß?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Takasi Yukawa"",
        ""Speaker"": ""Wilfried Dziallas""
      },
      {
        ""Character"": ""Frank Hektor"",
        ""Speaker"": ""Michael Lott""
      },
      {
        ""Character"": ""Sean Doherty"",
        ""Speaker"": ""Leonhard Mahlich""
      },
      {
        ""Character"": ""Mandy"",
        ""Speaker"": ""Jasmin Wagner""
      },
      {
        ""Character"": ""Zeno Daniels"",
        ""Speaker"": ""Philipp Baltus""
      },
      {
        ""Character"": ""Percy"",
        ""Speaker"": ""Jesse Grimm""
      },
      {
        ""Character"": ""Keko"",
        ""Speaker"": ""Jens Wendland""
      },
      {
        ""Character"": ""Anthony Fender"",
        ""Speaker"": ""Peter Buchholz""
      }
    ]
  },
  {
    ""Id"": ""223ec923-0211-4212-bd2a-9bf43be31aab"",
    ""Title"": ""Der Biss der Bestie"",
    ""NumberEuropa"": 146,
    ""ReleaseDate"": ""2011-05-06T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/146.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Kann eine tote Bestie beißen? Das Skelett des Säbelzahntigers im Naturkundemuseum von Rocky Beach sieht zwar sehr bedrohlich aus, doch dass es den Leiter Dr. Wadleigh attackiert haben soll, kommt den drei ??? äußerst merkwürdig vor. Aber wer oder was treibt dann nachts sein Unwesen im Museum? Justus, Peter und Bob gehen den Spuren nach. Und entdecken das Unfassbare ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt [Andreas Beurmann]""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Quentin Wadleigh"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""Dr. Winston Wadleigh"",
        ""Speaker"": ""Mathias Münster""
      },
      {
        ""Character"": ""Dr. John Frears"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Jamie"",
        ""Speaker"": ""Philipp Draeger""
      },
      {
        ""Character"": ""Sammy"",
        ""Speaker"": ""Jacob Mayerhoff""
      },
      {
        ""Character"": ""Mrs. Pitkätossu"",
        ""Speaker"": ""Ingeborg Kallweit""
      },
      {
        ""Character"": ""Jackall Madson"",
        ""Speaker"": ""Ingo Nommsen""
      },
      {
        ""Character"": ""Tiger Madson"",
        ""Speaker"": ""Dieter Dücker""
      },
      {
        ""Character"": ""Vivian"",
        ""Speaker"": ""Saskia Mayerhoff""
      },
      {
        ""Character"": ""Fitzwilliam Waterfield"",
        ""Speaker"": ""Wolfgang Völz""
      },
      {
        ""Character"": ""Sanitäter"",
        ""Speaker"": ""Robin Brosch""
      }
    ]
  },
  {
    ""Id"": ""a573cb00-7a4b-493d-9f4b-f9137125e9e7"",
    ""Title"": ""Grusel auf Campbell Castle"",
    ""NumberEuropa"": 147,
    ""ReleaseDate"": ""2011-06-24T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/147.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Adam Campbell hat ein schweres Erbe angetreten: er muss das imposante Schloss seines verstorbenen Vaters in Schuss halten. Bei einer spiritistischen Sitzung meldet sich dessen Geist und spricht von einem sonderbaren Vermächtnis. Natürlich nehmen die drei ??? die Ermittlungen auf. Mit einem Gespenst, davon sind sie überzeugt, haben sie es nicht zu tun! Bis Peter von einer gruseligen schwarzen Hand ins Meer gezogen wird. Erst in letzter Sekunde kann er gerettet werden. Der Zweite Detektiv ahnt Unheilvolles: Wurde er von einem Wassergeist attackiert?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Adam Campbell"",
        ""Speaker"": ""Santiago Ziesmer""
      },
      {
        ""Character"": ""Henry Campbell"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""John Taylor"",
        ""Speaker"": ""Holger Umbreit""
      },
      {
        ""Character"": ""Edward Crockett"",
        ""Speaker"": ""Ben Hecker""
      },
      {
        ""Character"": ""Mrs. Harkort"",
        ""Speaker"": ""Katja Brügger""
      },
      {
        ""Character"": ""Mr. Prescott"",
        ""Speaker"": ""Stefan Kaminski""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Jack Leech"",
        ""Speaker"": ""Volker Bogdan""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""André Minninger""
      },
      {
        ""Character"": ""Einbrecher"",
        ""Speaker"": ""Patrick Bach""
      }
    ]
  },
  {
    ""Id"": ""a959de2d-3d35-493a-a59d-25b747f7b8ec"",
    ""Title"": ""...und die feurige Flut"",
    ""NumberEuropa"": 148,
    ""ReleaseDate"": ""2011-08-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/148.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein schwerer Fluch lastet auf Allie Jamison, einer alten Bekannten der drei ???. Jedenfalls ist sie davon überzeugt. Schon in der nächsten Vollmondnacht soll etwas Schlimmes geschehen! Es gibt nur einen Ausweg: Justus, Peter und Bob müssen ein alchemistisches Rätsel lösen - in nur 24 Stunden. Ihre fieberhaften Ermittlungen führen die drei Detektive in eine Welt von Zauberern und Wahrsagern. Als Justus jedoch in einen Hinterhalt gelockt wird, ist klar: Dieser Fall ist lebensgefährlich!"",
    ""Roles"": [
      {
        ""Character"": ""ERZÄHLER"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Allie Jamison"",
        ""Speaker"": ""Katrin Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Ursula Burns"",
        ""Speaker"": ""Birke Bruck""
      },
      {
        ""Character"": ""Emerald Pendragon"",
        ""Speaker"": ""Monty Arnold""
      },
      {
        ""Character"": ""Carl Parsley"",
        ""Speaker"": ""Peter Weis""
      },
      {
        ""Character"": ""Sunshine"",
        ""Speaker"": ""Dagmar Dreke""
      },
      {
        ""Character"": ""1. Mann"",
        ""Speaker"": ""Tetje Mierendorf""
      }
    ]
  },
  {
    ""Id"": ""3012cb51-bbb2-4e73-9b7d-cb7154b47c7d"",
    ""Title"": ""Der namenlose Gegner"",
    ""NumberEuropa"": 149,
    ""ReleaseDate"": ""2011-09-30T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/149.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""In dem sonst so idyllischen Vorort Seven Pines droht ein Nachbarschaftskrieg auszuarten. Die aufgebrachten Anwohner bitten die drei ??? um Hilfe. Doch Bob wird bei einer nächtlichen Beschattungsaktion verletzt und verliert das Bewusstsein. Als er wieder zu sich kommt, weiß er nicht mehr, wer er ist! Das nutzt ein alter Feind der drei ??? gnadenlos aus. Während der dritte Detektiv nun auf unerwartete Abwege gerät, bekommen Justus und Peter es mit einem gefährlichen Gegner zu tun. Schnell wird aus einem scheinbar harmlosen Routinefall eine harte Probe für das berühmte Trio aus Rocky Beach - womöglich die härteste, die es für sie gegeben hat..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Cynthia McGowan"",
        ""Speaker"": ""Luise Lunow""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Henry König""
      },
      {
        ""Character"": ""Mrs. Andrews"",
        ""Speaker"": ""Konstanze Ullmer""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Mina Parker"",
        ""Speaker"": ""Annabelle Krieg""
      },
      {
        ""Character"": ""Brandon Fraser"",
        ""Speaker"": ""Tim Grobe""
      },
      {
        ""Character"": ""Beatrix Fraser"",
        ""Speaker"": ""Sophie Lechtenbrink""
      },
      {
        ""Character"": ""Roxy"",
        ""Speaker"": ""Julia Fölster""
      },
      {
        ""Character"": ""Josh"",
        ""Speaker"": ""Volker Hanisch""
      },
      {
        ""Character"": ""Paul"",
        ""Speaker"": ""Tim Kreuer""
      }
    ]
  },
  {
    ""Id"": ""8c3e09a8-df01-415f-bde4-7161bffc32f0"",
    ""Title"": ""Geisterbucht"",
    ""NumberEuropa"": 150,
    ""ReleaseDate"": ""2011-11-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/150.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei ??? übernehmen und lösen (hoffentlich!) ihren 150sten Fall! In drei atemberaubenden Folgen sind sie dem Rätsel der Geisterbucht auf der Spur! Welches Geheimnis verbirgt sich hinter dem Testament, dass der exzentrische Harry Shreber kurz vor seinem Tod verfasst hat? Führen die verschlüsselten Verse tatsächlich zu Rashuras Schatz? (Teil A) Den drei Detektiven wird nichts anderes übrig bleiben: Sie müssen in Flammendes Wasser (Teil B) hinab tauchen; denn nur in der Tiefe des Meeres kann geklärt werden, warum Der brennende Kristall (Teil C) so viel Unglück über eine große Anzahl Menschen bringen konnte... Teil A: Rashuras Schatz Die drei berühmten Detektive aus Rocky Beach müssen ein Rätsel lösen, das ihnen der schrullige Harry Shreber in seinem Testament hinterlassen hat. Schnell finden sie heraus, dass der erste Hinweis in einem schrottreifen Flugzeug in Shrebers Garten versteckt sein könnte. Die Suche nach Rashuras Schatz beginnt - aber Justus, Peter und Bob sind bei weitem nicht die Einzigen, die das Rätsel lösen wollen... Teil B: Flammendes Wasser Die Spur zu Rashuras Schatz führt die drei ??? hoch in die Berge, tief unter die Erde und hinaus auf die offene See. Aber mit jedem Hinweis wird alles nur noch geheimnisvoller und gefährlicher! Ein Wettlauf mit der Zeit beginnt... Teil C: Der brennende Kristall Noch immer haben Justus, Peter und Bob das Rätsel aus dem Testament nicht lösen können. Welche Rolle spielen Moby Dick und der brennende Kristall? Die drei ??? begeben sich zur Geisterbucht, um das Geheimnis zu lüften. Doch sie sind nicht allein! Jeder pokert hoch in diesem Spiel, das nur einer gewinnen kann..."",
    ""Roles"": [
      {
        ""Character"": ""Teil A"",
        ""Speaker"": """"
      },
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Frank Mason"",
        ""Speaker"": ""Wolfgang Condrus""
      },
      {
        ""Character"": ""Miles Dempster"",
        ""Speaker"": ""Stephan Benson""
      },
      {
        ""Character"": ""Mr. Sapchevsky"",
        ""Speaker"": ""Andreas Schmidt-Schaller""
      },
      {
        ""Character"": ""Gerry"",
        ""Speaker"": ""Kostja Ullmann""
      },
      {
        ""Character"": ""Ismael"",
        ""Speaker"": ""Stephan Schad""
      },
      {
        ""Character"": ""Carla Fenton"",
        ""Speaker"": ""Natalie O'Hara""
      },
      {
        ""Character"": ""Mrs. Maruthers"",
        ""Speaker"": ""Ulrike Johannson""
      },
      {
        ""Character"": ""Inspektor Havilland"",
        ""Speaker"": ""Oliver Kalkofe""
      },
      {
        ""Character"": ""Taylor"",
        ""Speaker"": ""Bernhard Hoecker""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Angelica"",
        ""Speaker"": ""Anna Thalbach""
      },
      {
        ""Character"": ""Schwester 1"",
        ""Speaker"": ""Manuela Becker""
      },
      {
        ""Character"": ""Schwester 2"",
        ""Speaker"": ""Traudel Sperber""
      },
      {
        ""Character"": ""Pfleger"",
        ""Speaker"": ""Sven Dahlem""
      },
      {
        ""Character"": ""Teil B"",
        ""Speaker"": """"
      },
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Taylor"",
        ""Speaker"": ""Bernhard Hoecker""
      },
      {
        ""Character"": ""Mr. Smith"",
        ""Speaker"": ""Tim Grobe""
      },
      {
        ""Character"": ""Curtis Fisher"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Amrita Chakyar"",
        ""Speaker"": ""Angela Stresemann""
      },
      {
        ""Character"": ""Inspektor Havilland"",
        ""Speaker"": ""Oliver Kalkofe""
      },
      {
        ""Character"": ""Ismael"",
        ""Speaker"": ""Stephan Schad""
      },
      {
        ""Character"": ""Angelica"",
        ""Speaker"": ""Anna Thalbach""
      },
      {
        ""Character"": ""Sergeant Madhu"",
        ""Speaker"": ""Olli Dittrich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Henry König""
      },
      {
        ""Character"": ""Mrs. Andrews"",
        ""Speaker"": ""Konstanze Ullmer""
      },
      {
        ""Character"": ""Frank Mason"",
        ""Speaker"": ""Wolfgang Condrus""
      },
      {
        ""Character"": ""Mr. Raffer"",
        ""Speaker"": ""Harald Dietl""
      },
      {
        ""Character"": ""Feuerwehrmann"",
        ""Speaker"": ""Kai-Hendrik Möller""
      },
      {
        ""Character"": ""Kapitän"",
        ""Speaker"": ""Sky du Mont""
      },
      {
        ""Character"": ""Teil C"",
        ""Speaker"": """"
      },
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Frank Mason"",
        ""Speaker"": ""Wolfgang Condrus""
      },
      {
        ""Character"": ""Taylor"",
        ""Speaker"": ""Bernhard Hoecker""
      },
      {
        ""Character"": ""Curtis Fisher"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""John Fisher"",
        ""Speaker"": ""Dirk Bach""
      },
      {
        ""Character"": ""Gerry"",
        ""Speaker"": ""Kostja Ullmann""
      },
      {
        ""Character"": ""Ismael"",
        ""Speaker"": ""Stephan Schad""
      },
      {
        ""Character"": ""Mr. Smith"",
        ""Speaker"": ""Tim Grobe""
      },
      {
        ""Character"": ""Mrs. Maruthers"",
        ""Speaker"": ""Ulrike Johannson""
      },
      {
        ""Character"": ""Angelica"",
        ""Speaker"": ""Anna Thalbach""
      },
      {
        ""Character"": ""Sergeant Madhu"",
        ""Speaker"": ""Olli Dittrich""
      },
      {
        ""Character"": ""Mr. Castro"",
        ""Speaker"": ""Jörg Gillner""
      },
      {
        ""Character"": ""Sanitäter"",
        ""Speaker"": ""Robert Kottula""
      },
      {
        ""Character"": ""Anudhara"",
        ""Speaker"": ""Rosakutty Hemsing""
      }
    ]
  },
  {
    ""Id"": ""f00b5c1e-dc43-4d04-9d72-50aa88b66c05"",
    ""Title"": ""Schwarze Sonne"",
    ""NumberEuropa"": 151,
    ""ReleaseDate"": ""2012-01-20T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/151.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bei einem Malkurs lernt Bob den sympathischen und begabten Denzel Hopkins kennen. Der Mann wird plötzlich beschuldigt, ein wertvolles Gemälde gestohlen zu haben. Denzel beteuert, das Bild noch nie gesehen zu haben und unschuldig zu sein. Wie konnte er dann bereits in der Vergangenheit immer wieder ein zentrales Motiv aus diesem Bild malen - die schwarze Sonne? Die drei ??? müssen ihren gesamten detektivischen Spürsinn aufbieten, um diesen Fall zu lösen."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Laurence Seinfeld"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""Denzel Hopkins"",
        ""Speaker"": ""Tilo Schmitz""
      },
      {
        ""Character"": ""Goldie Hopkins"",
        ""Speaker"": ""Madeleine Weingarten""
      },
      {
        ""Character"": ""Neil Rockwell"",
        ""Speaker"": ""Wanja Mues""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mrs. Summer Hopkins"",
        ""Speaker"": ""Regina Lemnitz""
      },
      {
        ""Character"": ""Brooks, Galerist"",
        ""Speaker"": ""Martin May""
      },
      {
        ""Character"": ""Mr. Elroy Follister"",
        ""Speaker"": ""Stephan Schwartz""
      },
      {
        ""Character"": ""Martha"",
        ""Speaker"": ""Hanna Reisch""
      },
      {
        ""Character"": ""Dillon"",
        ""Speaker"": ""Gregor Reisch""
      },
      {
        ""Character"": ""Wayne"",
        ""Speaker"": ""Woody Mues""
      },
      {
        ""Character"": ""Gefängniswärter"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Wirt"",
        ""Speaker"": ""Klaus Dittmann""
      },
      {
        ""Character"": ""Greis"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Beamter"",
        ""Speaker"": ""Monty Arnold""
      }
    ]
  },
  {
    ""Id"": ""59e18ef7-9853-4911-9655-fe9cace5e0f6"",
    ""Title"": ""Botschaft aus der Unterwelt"",
    ""NumberEuropa"": 154,
    ""ReleaseDate"": ""2012-05-18T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/154.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Dank seiner unfehlbaren Kombinationsgabe hat Justus Jonas wieder einmal einen Fall der drei ??? im Handumdrehen gelöst. Doch kaum ist die Akte geschlossen, bekommen die drei Detektive Post von einem mysteriösen Klienten. Er benennt sich selbst nach Sherlock Holmes großem Erzfeind \""Professor Moriarty\"" und beauftragt Justus, Peter und Bob, für ihn eine geheimnisvolle Botschaft zu entschlüsseln. Schon bald müssen die drei ??? erfahren, dass sie Figuren in einem gefährlichen Spiel sind: Onkel Titus wird verhaftet, Inspektor Cotta ist unerreichbar - und Moriarty scheint stets einen Schritt voraus zu sein. Aber Justus wäre nicht Justus, wenn er die Herausforderung nicht annehmen würde!"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Titus Jonas"",
        ""Speaker"": ""Hans Meinhard""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Prof. Jane Heathcliff"",
        ""Speaker"": ""Victoria von Trauttmansdorff""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Mr. Grey"",
        ""Speaker"": ""Urs Affolter""
      },
      {
        ""Character"": ""Lester Price"",
        ""Speaker"": ""Fabian Harloff""
      },
      {
        ""Character"": ""Cinelly"",
        ""Speaker"": ""Bernd Stephan""
      },
      {
        ""Character"": ""Mr. Monroe"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Miss Deborah Cassidy"",
        ""Speaker"": ""Barbara Focke""
      },
      {
        ""Character"": ""Mr. Burke"",
        ""Speaker"": ""Kai-Hendrik Möller""
      },
      {
        ""Character"": ""Miss Trimble"",
        ""Speaker"": ""Christine Pappert""
      },
      {
        ""Character"": ""Mr. Weston"",
        ""Speaker"": ""Joachim Lautenbach""
      },
      {
        ""Character"": ""Nachbarin"",
        ""Speaker"": ""Doris Maria Kaiser""
      },
      {
        ""Character"": ""Butler"",
        ""Speaker"": ""Erik Schäffler""
      },
      {
        ""Character"": ""Goodween"",
        ""Speaker"": ""Andr� Minninger""
      },
      {
        ""Character"": ""Michael Kowalski"",
        ""Speaker"": ""Tobias Schmidt""
      }
    ]
  },
  {
    ""Id"": ""74619904-b5c0-4938-b5f4-4dfb57c9799b"",
    ""Title"": ""...und der Meister des Todes"",
    ""NumberEuropa"": 155,
    ""ReleaseDate"": ""2012-07-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/155.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Das alte Haus an der Küste hat einst einem Marionettenspieler gehört. Der perfekte Drehort für ihren Horrorfilm, finden die drei ??? und ihre Schulkollegen aus dem Filmkurs. Schließlich hängen die unheimlichen Puppen immer noch an den Wänden. Als es in ihrer Nähe zu mysteriösen Ereignissen kommt, glauben Justus, Peter und Bob zunächst nicht an Magie. Doch dann gerät ausgerechnet einer der Detektive in den Bann einer düsteren Macht. Haben die Marionetten ihre Finger im Spiel? Oder zieht jemand anderes im Hintergrund die Fäden?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Zack Martin"",
        ""Speaker"": ""Christian Stark""
      },
      {
        ""Character"": ""Mary-Ann Leigh"",
        ""Speaker"": ""Manuela Bäcker""
      },
      {
        ""Character"": ""Latona Johnson"",
        ""Speaker"": ""Julia Hummer""
      },
      {
        ""Character"": ""Frank Norman"",
        ""Speaker"": ""Till Huster""
      },
      {
        ""Character"": ""Mrs. Robinson"",
        ""Speaker"": ""Heidi Berndt""
      },
      {
        ""Character"": ""Angela Sciutto"",
        ""Speaker"": ""Gisela Fritsch""
      },
      {
        ""Character"": ""Federico Sciutto"",
        ""Speaker"": ""Rainer Fritzsche""
      },
      {
        ""Character"": ""Mr. Torrance"",
        ""Speaker"": ""Ingo Feder""
      },
      {
        ""Character"": ""Frau"",
        ""Speaker"": ""Konstanze Ullmer""
      }
    ]
  },
  {
    ""Id"": ""2cc94fe6-9c62-42ec-b413-4dd83df9704a"",
    ""Title"": ""Im Netz des Drachen"",
    ""NumberEuropa"": 156,
    ""ReleaseDate"": ""2012-08-24T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/156.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Dragoncourt, das Anwesen des exzentrischen Spiele-Programmierers Stephen Baron, steht zum Verkauf. Der Mann ist schwer erkrankt und hat sich nach Europa zurückgezogen. Doch der mit dem Verkauf der Immobilie beauftragte Makler ist verzweifelt, denn seltsame Dinge geschehen auf Dragoncourt. Ganz klar: hier müssen die drei erfolgreichen Detektive aus Rocky Beach ermitteln! Die Recherchen führen Justus, Bob und Peter in die fantastische Welt des Online-Games \""Im Land der Drachen\"". Und schnell wird aus einem scheinbar harmlosen Spiel eine tödliche Gefahr: Alles deutet darauf hin, dass die virtuellen Figuren den Weg in die Wirklichkeit gefunden haben und hier ihr Unwesen treiben..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Ryan Holbrooke"",
        ""Speaker"": ""Manfred Reddemann""
      },
      {
        ""Character"": ""Sheriff Pickett"",
        ""Speaker"": ""Gerhart Hinze""
      },
      {
        ""Character"": ""Stephen Baron"",
        ""Speaker"": ""Patrick Elias""
      },
      {
        ""Character"": ""Zyklon"",
        ""Speaker"": ""Wolfgang Berger""
      },
      {
        ""Character"": ""Al Dahab"",
        ""Speaker"": ""Neil Malik""
      },
      {
        ""Character"": ""Frau"",
        ""Speaker"": ""Regine Lamster""
      },
      {
        ""Character"": ""Matthew"",
        ""Speaker"": ""Mike Olsowski""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Zabriski"",
        ""Speaker"": ""Volker Bogdan""
      }
    ]
  },
  {
    ""Id"": ""73e9320a-4068-4700-a7ef-3963b9c69685"",
    ""Title"": ""Im Zeichen der Schlangen"",
    ""NumberEuropa"": 157,
    ""ReleaseDate"": ""2012-09-28T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/157.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Auf dem Schrottplatz laufen die Vorbereitungen für eine große Auktion auf Hochtouren. Plötzlich erscheint ein bedrohlicher Riese und beauftragt die drei Detektive mit einem geheimnisvollen Fall. Die Spur führt immer tiefer in längst vergangene Zeiten. Noch ahnen Justus, Peter und Bob nicht, dass sie schon bald in einen Strudel gefährlicher Ereignisse geraten werden. Doch mysteriöse Rätsel, nächtliche Beschatter, geisterhafter Rauch und ein bewaffnetes Phantom machen den drei ??? schnell klar, dass ihr ganzes Können gefordert ist, um nicht auf der Strecke zu bleiben. Nichts ist so, wie es auf den ersten Blick scheint..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt""
      },
      {
        ""Character"": ""Riese"",
        ""Speaker"": ""Tilo Schmitz""
      },
      {
        ""Character"": ""Hunnicutt"",
        ""Speaker"": ""Heinz Lieven""
      },
      {
        ""Character"": ""Sheila"",
        ""Speaker"": ""Melanie Pukaß""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Felicity"",
        ""Speaker"": ""Kari Erlhoff""
      },
      {
        ""Character"": ""Chester"",
        ""Speaker"": ""Mike Olsowski""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""Andr� Minninger""
      }
    ]
  },
  {
    ""Id"": ""bbc404c8-d165-45e4-8fed-31d8bcf03c8c"",
    ""Title"": ""...und der Feuergeist"",
    ""NumberEuropa"": 158,
    ""ReleaseDate"": ""2012-11-30T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/158.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die privat geführte Oper Califia in Rocky Beach steht vor dem finanziellen Aus. So ist es nicht verwunderlich, dass die drei ??? zunächst an eine werbewirksame Veranstaltung glauben, als sich eine Mitarbeiterin der Oper Hilfe suchend an sie wendet: Im Gewölbekeller des Gebäudes gehen mysteriöse Dinge vor sich - und ein seltsames Wesen wurde gesichtet! Justus, Peter und Bob übernehmen den Fall und ahnen nicht, auf was sie sich da einlassen. Plötzlich bricht während einer Aufführung ein Großfeuer aus! War es Brandstiftung? Welche Rolle spielen dabei der undurchsichtige Moody Firthway und sein rotes Notizbuch? Nur Justus erkennt als Einziger, was sich tatsächlich hinter den Kulissen abspielt."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Michelle"",
        ""Speaker"": ""Ulrike Stürzbecher""
      },
      {
        ""Character"": ""Ronald Pounder"",
        ""Speaker"": ""Jürgen Kluckert""
      },
      {
        ""Character"": ""Maurice Blight"",
        ""Speaker"": ""Oliver Böttcher""
      },
      {
        ""Character"": ""Betsy"",
        ""Speaker"": ""Heidi Schaffrath""
      },
      {
        ""Character"": ""Isabella"",
        ""Speaker"": ""Isabel Navarro""
      },
      {
        ""Character"": ""Vladas Abakulow"",
        ""Speaker"": ""Eric Schäffler""
      },
      {
        ""Character"": ""Moody Firthway"",
        ""Speaker"": ""Peter Striebeck""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Mike Olsowski""
      },
      {
        ""Character"": ""Jenna"",
        ""Speaker"": ""Konstanze Ullmer""
      },
      {
        ""Character"": ""1. Mann"",
        ""Speaker"": ""Olaf Kreutzenbeck""
      },
      {
        ""Character"": ""2. Mann"",
        ""Speaker"": ""Rainer Fritzsche""
      },
      {
        ""Character"": ""3. Mann"",
        ""Speaker"": ""Claus Fuchs""
      }
    ]
  },
  {
    ""Id"": ""80d50286-91e1-4be2-bbed-26d4b5f03e76"",
    ""Title"": ""Nacht der Tiger"",
    ""NumberEuropa"": 159,
    ""ReleaseDate"": ""2013-01-11T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/159.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Wer ist der unbekannte Auftraggeber im neuen Fall der drei erfolgreichen Detektive aus Rocky Beach? Wie von Geisterhand erscheinen verschlüsselte Botschaften auf dem Computerbildschirm in der Zentrale. Justus' Ehrgeiz ist geweckt und die drei ??? beginnen zu ermitteln. Sie lösen die komplizierten Rätsel des Unbekannten und folgen seiner Spur. Dabei werden die drei Jungen immer tiefer in dubiose Machenschaften verstrickt. Als sich herausstellt, dass ein guter Freund von ihnen als Täter infrage kommt, stehen Justus, Peter und Bob vor einer schwierigen Entscheidung: Sollen sie ihren Freund ausliefern oder der Polizei die Wahrheit verschweigen? Justus fasst einen Plan - und die drei ??? entdecken das Unvorstellbare in der 'Nacht der Tiger'..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Caroline Cotta"",
        ""Speaker"": ""Michaela Mahlich""
      },
      {
        ""Character"": ""Morton"",
        ""Speaker"": ""Andreas von der Meden""
      },
      {
        ""Character"": ""Sergeant Donatelli"",
        ""Speaker"": ""Peter Weis""
      },
      {
        ""Character"": ""1. Mann"",
        ""Speaker"": ""Robin Brosch""
      }
    ]
  },
  {
    ""Id"": ""6cede061-a3fb-4874-a729-502b002e937d"",
    ""Title"": ""Geheimnisvolle Botschaften"",
    ""NumberEuropa"": 160,
    ""ReleaseDate"": ""2013-03-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/160.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Der Raub eines alten handgefertigten Buchs stellt die drei ??? vor ein Rätsel. Denn im Haus von Professor Mathewson hätte es weitaus wertvollere Beute gegeben. Kaum beginnen Justus, Peter und Bob zu ermitteln, stecken sie schon bis zum Hals in Schwierigkeiten: Ein geheimnisvoller Gegner ist ihnen stets einen Schritt voraus und schreckt vor nichts zurück..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Barbara"",
        ""Speaker"": ""Tanja Geke""
      },
      {
        ""Character"": ""Professor Mathewson"",
        ""Speaker"": ""Stephan Schwartz""
      },
      {
        ""Character"": ""Arthur"",
        ""Speaker"": ""Stephan Benson""
      },
      {
        ""Character"": ""Alan Jones"",
        ""Speaker"": ""Wolfgang Pampel""
      },
      {
        ""Character"": ""Shu Liin"",
        ""Speaker"": ""Monika Freisfeld-Pampel""
      },
      {
        ""Character"": ""Kellner"",
        ""Speaker"": ""Sven Dahlem""
      },
      {
        ""Character"": ""Frank"",
        ""Speaker"": ""Simon Jäger""
      },
      {
        ""Character"": ""Stadtverwalter"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""Andr� Minninger""
      }
    ]
  },
  {
    ""Id"": ""c5390546-e470-45a4-84b1-47055ff646fd"",
    ""Title"": ""Die blutenden Bilder"",
    ""NumberEuropa"": 161,
    ""ReleaseDate"": ""2013-05-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/161.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Dreizehn geheimnisvolle Bilder sorgen auf dem Schrottplatz von Justus' Onkel Titus für allerhand Aufregung. Als sich eine ganze Reihe von zwielichtigen Gestalten für die Gemälde interessiert wittern die drei ??? einen Fall. Zu dumm, dass einige der Bilder bereits spurlos verschwunden sind. Justus, Peter und Bob müssen sich bei ihrer Suche beeilen, denn Rocky Beach wird von einem hinterhältigen Erpresser heimgesucht, der es ausgerechnet auf Kunstwerke abgesehen hat und eine mysteriöse Spur hinterlässt."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Greenwalt"",
        ""Speaker"": ""Harald Dietl""
      },
      {
        ""Character"": ""Brock"",
        ""Speaker"": ""Guido A. Schick""
      },
      {
        ""Character"": ""Deforge"",
        ""Speaker"": ""Bruno F. Apitz""
      },
      {
        ""Character"": ""Mrs. Kretchmer"",
        ""Speaker"": ""Monika Werner""
      },
      {
        ""Character"": ""Mrs. Espenson"",
        ""Speaker"": ""Karin Eckhold""
      },
      {
        ""Character"": ""Mrs. Wondratschek"",
        ""Speaker"": ""Ela Nitzsche""
      },
      {
        ""Character"": ""Mrs. Field"",
        ""Speaker"": ""Celine Fontanges""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      }
    ]
  },
  {
    ""Id"": ""05c1dbf3-443f-48ef-9f87-f45dad9c182a"",
    ""Title"": ""...und der schreiende Nebel"",
    ""NumberEuropa"": 162,
    ""ReleaseDate"": ""2013-07-12T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/162.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Als die drei ??? Post von einem alten Bekannten erhalten, ahnen sie noch nicht, was für ein gefährliches Abenteuer sie erwartet. Der rätselhafte Hilferuf führt sie mitten in die Einöde von South Dakota. Dort werden sie Zeugen unfassbarer Ereignisse, die eine abgelegene Prärie-Ortschaft heimsuchen. Welches dunkle Geheimnis steckt hinter dem unheimlichen Nebel, der die Einwohner in Angst und Schrecken versetzt? Und was hat es mit den grässlichen Schreien auf sich, die immer wieder aus den weißen Schwaden dringen? Die drei Detektive nehmen die Ermittlungen auf - und geraten selbst in die Fänge des Nebels..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Prof. Arnold Brewster"",
        ""Speaker"": ""Horst Naumann""
      },
      {
        ""Character"": ""Miss Daggett"",
        ""Speaker"": ""Ingeborg Christiansen""
      },
      {
        ""Character"": ""Hold"",
        ""Speaker"": ""Christian Rode""
      },
      {
        ""Character"": ""Hank Tornby"",
        ""Speaker"": ""Edgar Hoppe""
      },
      {
        ""Character"": ""Mike Cobble"",
        ""Speaker"": ""Gordon Piedesack""
      },
      {
        ""Character"": ""Martin Ishniak"",
        ""Speaker"": ""Erkki Hopf""
      },
      {
        ""Character"": ""Samuel Cobble"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""William Prescott"",
        ""Speaker"": ""Eberhard haar""
      },
      {
        ""Character"": ""Jim Sesto"",
        ""Speaker"": ""Gustav-Adolph Artz""
      }
    ]
  },
  {
    ""Id"": ""5aaa1b52-51f1-485e-bac8-4c9ab9963e03"",
    ""Title"": ""und der verschollene Pilot"",
    ""NumberEuropa"": 163,
    ""ReleaseDate"": ""2013-08-30T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/163.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eigentlich sollen die drei ??? für Onkel Titus nur ein Auto überführen. Doch der dichte Nebel in den Bergen zwingt sie, sich dort eine Unterkunft zu suchen. Ein seltsamer Pick-up-Fahrer führt sie zum 'King of the Mountain', einem heruntergekommenen Hotel ohne einen einzigen Gast. Bald geschehen seltsame Dinge, die nur eins bedeuten können: Das Hotel birgt ein Geheimnis. Hat das Wrack eines vor Jahren in den Bergen abgestürzten Flugzeugs etwas damit zu tun?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Fynch"",
        ""Speaker"": ""Stefan Benson""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      }
    ]
  },
  {
    ""Id"": ""6fb237b2-acab-41cf-b9f8-57709dc27e9d"",
    ""Title"": ""- Fu�ball-Teufel"",
    ""NumberEuropa"": 164,
    ""ReleaseDate"": ""2013-10-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/164.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eigentlich wollen Die drei ??? am Felsen Hookes Nose nur nach einem verschwundenen Hund suchen, doch schon bald taucht ein düsterer Mann mit Pferdefuß auf. Ist der Hooked Nose wirklich ein verfluchter Ort, an dem der Teufel umgeht? Und was hat der junge Fußballer Lenni Carson mit dem Geheimnis des Felsens zu tun? Müssen es Justus, Peter und Bob bei ihren Ermittlungen diesmal wirklich mit dem Teufel persönlich aufnehmen?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Lenni"",
        ""Speaker"": ""Tim Kreuer""
      },
      {
        ""Character"": ""John Greyfox"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Clay Carson"",
        ""Speaker"": ""Krystian Martinek""
      },
      {
        ""Character"": ""Walter"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Freddy Hays"",
        ""Speaker"": ""Woody Mues""
      },
      {
        ""Character"": ""Trainer"",
        ""Speaker"": ""Bruno F. Apitz""
      },
      {
        ""Character"": ""Mann"",
        ""Speaker"": ""Wolfram Winfried""
      },
      {
        ""Character"": ""Junge"",
        ""Speaker"": ""Francesco Nieheim""
      }
    ]
  },
  {
    ""Id"": ""11caa5ed-e801-459a-91a4-1ee5805c1734"",
    ""Title"": ""Im Schatten des Giganten"",
    ""NumberEuropa"": 165,
    ""ReleaseDate"": ""2013-11-29T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/165.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei ??? begleiten Mr. Andrews auf eine Recherche-Reise in den Yosemite National Park. Doch anstatt sich zu erholen, finden sich Justus, Bob und Peter plötzlich mitten in einem hochgefährlichen Fall wieder: Einer von ihnen wird angeschossen, im Wald geben mysteriöse Blutspuren Rätsel auf und die drei Detektive machen einen schrecklichen Fund. Schließlich kommt es am Half Dome, dem großen Granitfelsen im Park, zu einer Kletterpartie auf Leben und Tod..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Henry König""
      },
      {
        ""Character"": ""Randy"",
        ""Speaker"": ""Marek Harloff""
      },
      {
        ""Character"": ""Jeanne"",
        ""Speaker"": ""Katja Brügger""
      },
      {
        ""Character"": ""Ginette"",
        ""Speaker"": ""Birte Kretschmer""
      },
      {
        ""Character"": ""Tara"",
        ""Speaker"": ""Angela Roy""
      },
      {
        ""Character"": ""Steven"",
        ""Speaker"": ""Robert Steudtner""
      },
      {
        ""Character"": ""Ranger Thornton"",
        ""Speaker"": ""Detlef Bierstedt""
      },
      {
        ""Character"": ""Mr. Louis"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Busfahrer"",
        ""Speaker"": ""Volker Bogdan""
      },
      {
        ""Character"": ""Lindsey"",
        ""Speaker"": ""Susan Jarling""
      }
    ]
  },
  {
    ""Id"": ""2e0865ee-80c1-42a4-affc-af37572e83a0"",
    ""Title"": ""und die brennende Stadt"",
    ""NumberEuropa"": 166,
    ""ReleaseDate"": ""2014-01-17T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/166.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ex-Kommissar Reynolds stattet den drei Detektiven einen Besuch ab. Es geht um das rätselhafte Testament seines Bruders, das Justus, Peter und Bob für ihren alten Freund entschlüsseln sollen. Ehe sie sich`s versehen, stecken die drei ??? mitten in einem brandheißen Fall, der ihren vollen Einsatz verlangt. Denn das Erbe ruft düstere Gestalten auf den Plan - und die schrecken vor nichts zurück..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Mr. Bennet"",
        ""Speaker"": ""Sven Dahlem""
      },
      {
        ""Character"": ""Mrs. Dearing"",
        ""Speaker"": ""Saskia Weckler""
      },
      {
        ""Character"": ""Conrad Nash"",
        ""Speaker"": ""Rüdiger Schulzki""
      }
    ]
  },
  {
    ""Id"": ""1729a5b1-a42c-4453-b829-f965ef30bf79"",
    ""Title"": ""und das blaue Biest"",
    ""NumberEuropa"": 167,
    ""ReleaseDate"": ""2014-02-21T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/167.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Im Film-Erlebnispark Movie Empire gehen seltsame Dinge vor sich. Ein Unbekannter verübt hinterhältige Sabotage-Akte und bringt damit die Shows und Besucher in Gefahr. Aber wem könnte daran gelegen sein, den Park zu ruinieren? Als wäre das nicht genug, taucht immer wieder ein blau schimmerndes Monstrum auf, das einem mythischen Mantikor ähnelt. Furchtlos nehmen die drei ??? die Ermittlungen auf. Bis sie eines Nachts plötzlich dem Biest gegenüberstehen!"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Andy Carson"",
        ""Speaker"": ""Stefan Schwade""
      },
      {
        ""Character"": ""Mrs. Hampton"",
        ""Speaker"": ""Celine Fontanges""
      },
      {
        ""Character"": ""Nicky DeLores"",
        ""Speaker"": ""Morgens von Gadow""
      },
      {
        ""Character"": ""Miss Woodrow"",
        ""Speaker"": ""Karin Abicht""
      },
      {
        ""Character"": ""Judy Nigel"",
        ""Speaker"": ""Angela Stresemann""
      },
      {
        ""Character"": ""Direktor Grayston"",
        ""Speaker"": ""Jörg Gillner""
      },
      {
        ""Character"": ""Gregory Katic"",
        ""Speaker"": ""Oliver Böttcher""
      },
      {
        ""Character"": ""Mr. Clark"",
        ""Speaker"": ""Stefan Brentle""
      },
      {
        ""Character"": ""Tarzan"",
        ""Speaker"": ""Sascha Draeger""
      },
      {
        ""Character"": ""Mädchen"",
        ""Speaker"": ""Nicola Melissian""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mr. Callister"",
        ""Speaker"": ""Ingo Feder""
      },
      {
        ""Character"": ""Lionel Pengrim"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""Ned"",
        ""Speaker"": ""Bruno Ploeger""
      }
    ]
  },
  {
    ""Id"": ""c4aaf18d-9315-4059-b1c0-83a70e53cb32"",
    ""Title"": ""GPS - Gangster"",
    ""NumberEuropa"": 168,
    ""ReleaseDate"": ""2014-05-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/168.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei ??? kommen zu spät: Sie k�nnen ihren Schützling nicht vor der Katastrophe retten! Zum Glück ist es nur ein Geocaching-Wettbewerb. Doch schlagartig wird aus dem Spiel gefährlicher Ernst, als der geheimnisvolle Captain Skull auf der Bildfläche erscheint. Auf seinem Raubzug durch Rocky Beach spielt er Katz und Maus mit der Polizei. Wird er über Leichen gehen? Können die Detektive den Wettlauf mit der Zeit gewinnen?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Deborah Rodman"",
        ""Speaker"": ""Gabriele Libbach""
      },
      {
        ""Character"": ""Samuel Rodman"",
        ""Speaker"": ""Christian Concillio""
      },
      {
        ""Character"": ""Benjamin Rodman"",
        ""Speaker"": ""Henning Karge""
      },
      {
        ""Character"": ""Vallery Flockheart"",
        ""Speaker"": ""Caroline Kiesewetter""
      },
      {
        ""Character"": ""Nigel Tillerman"",
        ""Speaker"": ""Lutz Mackensy""
      },
      {
        ""Character"": ""Josh Reilly"",
        ""Speaker"": ""Nicholas Müller""
      },
      {
        ""Character"": ""Lexington"",
        ""Speaker"": ""Sascha Eigner""
      },
      {
        ""Character"": ""Reporter"",
        ""Speaker"": ""Rasmus Borowski""
      },
      {
        ""Character"": ""Journalistin"",
        ""Speaker"": ""Nicola Melissian""
      },
      {
        ""Character"": ""Prescott"",
        ""Speaker"": ""Rolf Becker""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Sergeant Morales"",
        ""Speaker"": ""Peter Weis""
      },
      {
        ""Character"": ""Mr. Arvidson"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Mrs. Arvidson"",
        ""Speaker"": ""Hedy Haase""
      },
      {
        ""Character"": ""Mann"",
        ""Speaker"": ""Andreas Becker""
      }
    ]
  },
  {
    ""Id"": ""66dd5758-c65c-4d00-8d37-365d575a3aaf"",
    ""Title"": ""Die Spur des Spielers"",
    ""NumberEuropa"": 169,
    ""ReleaseDate"": ""2014-07-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/169.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bei einer Versteigerung auf dem Schrottplatz von Onkel Titus kommt ein scheinbar wertloses Schachspiel für eine ungeheure Summe unter den Hammer. Kurze Zeit später wird das Spiel gestohlen - ein neuer Fall für die drei ???! Welches Geheimnis birgt das Spiel? Wem hat es gehört? Die Zeit drängt, denn Justus, Peter und Bob sind nicht die Einzigen, die das Rätsel lösen wollen. Und nicht jede Figur in diesem Spiel ist das, was sie zu sein scheint..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Hans Meinhardt""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Bradley"",
        ""Speaker"": ""Nico König""
      },
      {
        ""Character"": ""Bishop Blake"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""Junge Frau"",
        ""Speaker"": ""Heikedine Körting""
      },
      {
        ""Character"": ""Derek"",
        ""Speaker"": ""Tim Helssen""
      },
      {
        ""Character"": ""Mrs. Kretschmer"",
        ""Speaker"": ""Monika Werner""
      },
      {
        ""Character"": ""Chastity"",
        ""Speaker"": ""Undine Ullmer""
      },
      {
        ""Character"": ""Charity"",
        ""Speaker"": ""Kassandra Ullmer""
      },
      {
        ""Character"": ""Sam Chiccarelli"",
        ""Speaker"": ""Astrid Kollex""
      },
      {
        ""Character"": ""Griffin Silverman"",
        ""Speaker"": ""Stephan Schad""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      }
    ]
  },
  {
    ""Id"": ""a88928a7-97b4-490d-9ef4-842a72b5be33"",
    ""Title"": ""Straße des Grauens"",
    ""NumberEuropa"": 170,
    ""ReleaseDate"": ""2014-08-29T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/170.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ex-Kommissar Reynolds wurde entführt! Justus, Peter und Bob machen sich sofort auf die Spur des Täters. Der der verbietet ihnen jeglichen Kontakt zur Polizei, schickt ihnen ein Paket mit fragwürdigem Inhalt und lässt ihnen seltsame Hinweise zukommen. Durch die glühende Hitze der Wüste jagen die drei ??? ihren ruchlosen Gegner. Und dann verschwindet auch noch Bob! Wie weit werden die Detektive gehen, um ihre Freunde zu retten?"",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Lieneweg""
      },
      {
        ""Character"": ""Kommissar Reynolds"",
        ""Speaker"": ""Wolfgang Draeger""
      },
      {
        ""Character"": ""Mitch Palmer"",
        ""Speaker"": ""Michael Lott""
      },
      {
        ""Character"": ""Dimitri"",
        ""Speaker"": ""Manou Lubowski""
      },
      {
        ""Character"": ""Roy"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Boss"",
        ""Speaker"": ""Henry König""
      },
      {
        ""Character"": ""Cindy"",
        ""Speaker"": ""Konstanze Ullmer""
      },
      {
        ""Character"": ""Mike"",
        ""Speaker"": ""Oliver Böttcher""
      },
      {
        ""Character"": ""Wirt"",
        ""Speaker"": ""Peter Lakenmacher""
      },
      {
        ""Character"": ""Rockford"",
        ""Speaker"": ""Christian Senger""
      },
      {
        ""Character"": ""Casino-Besucher"",
        ""Speaker"": ""Robin Bosch""
      },
      {
        ""Character"": ""Casino-Besucherin"",
        ""Speaker"": ""Brigitte Böttrich""
      },
      {
        ""Character"": ""Rezeption 1"",
        ""Speaker"": ""Dorothea Lott""
      },
      {
        ""Character"": ""Rezeption 2"",
        ""Speaker"": ""Marco Spina""
      },
      {
        ""Character"": ""Fernfahrer"",
        ""Speaker"": ""Tilman Madaus""
      },
      {
        ""Character"": ""Putzfrau"",
        ""Speaker"": ""Maria Baptista""
      }
    ]
  },
  {
    ""Id"": ""d36022bd-8756-42e0-a13f-ef7b37e454b6"",
    ""Title"": ""... und das Phantom aus dem Meer"",
    ""NumberEuropa"": 171,
    ""ReleaseDate"": ""2014-10-03T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/171.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""In einem beschaulichen Küstenort unweit von Rocky Beach passieren seltsame Dinge: Eine Gestalt erhebt sich aus dem Meer und versetzt die Strandbesucher in Angst und Schrecken. Ein ruheloser Geist, der auf Rache sinnt? Die drei ??? fangen an zu ermitteln. Ob der neue Bewohner des alten Leuchtturms etwas damit zu tun hat? Oder der kauzige Seebär am Hafen? Justus, Peter und Bob gehen keiner Gefahr aus dem Weg, um das Netz aus Lügen zu entwirren."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Harry Salas"",
        ""Speaker"": ""Pat Murphy""
      },
      {
        ""Character"": ""Vanessa Goodstein"",
        ""Speaker"": ""Simone Ritscher""
      },
      {
        ""Character"": ""Eliah Cristobal"",
        ""Speaker"": ""Stephan Schwartz""
      },
      {
        ""Character"": ""Albert Goodstein"",
        ""Speaker"": ""Manfred Reddemann""
      },
      {
        ""Character"": ""Ben Kramer"",
        ""Speaker"": ""Jan-Christof Kick""
      },
      {
        ""Character"": ""Fiona Kramer"",
        ""Speaker"": ""Lilian Körting""
      },
      {
        ""Character"": ""Wirt"",
        ""Speaker"": ""Harald Halgardt""
      },
      {
        ""Character"": ""Jimmy Blue Eye"",
        ""Speaker"": ""Ulli Potofski""
      },
      {
        ""Character"": ""1. Mann"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""2. Mann"",
        ""Speaker"": ""Fabian Harloff""
      },
      {
        ""Character"": ""Frau"",
        ""Speaker"": ""Saskia Weckler""
      },
      {
        ""Character"": ""Rosaria"",
        ""Speaker"": ""Gela del Este""
      },
      {
        ""Character"": ""Silvie"",
        ""Speaker"": ""Katharina von Keller""
      },
      {
        ""Character"": ""Jessy"",
        ""Speaker"": ""Manuela Bäcker""
      },
      {
        ""Character"": ""Sergeant"",
        ""Speaker"": ""Alexander Stamm""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Gordon Piedesack""
      },
      {
        ""Character"": ""Rikuo Yamamoto"",
        ""Speaker"": ""Toru Takahashi""
      }
    ]
  },
  {
    ""Id"": ""ecbe9b30-dc27-45aa-83d9-86f8ca0e31a0"",
    ""Title"": ""D�mon der Rache"",
    ""NumberEuropa"": 173,
    ""ReleaseDate"": ""2015-01-16T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/173.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bei einer Ballonfahrt entdeckt Peter in der Nähe einer abgelegenen Villa ein Monster eindeutig ein neuer Fall f�r die drei ???! Ihre Ermittlungen führen die Detektive zur seltsamen Mrs Pembroke und ihrem Neffen Luke. Die beiden werden von der grässlichen Gestalt bedroht. Luke bittet Justus, Peter und Bob um Hilfe. Doch schnell wird klar: Der Dämon der Rache ist nicht aufzuhalten..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Rupert"",
        ""Speaker"": ""Udo Schenk""
      },
      {
        ""Character"": ""Luke"",
        ""Speaker"": ""Daniel Kirchberger""
      },
      {
        ""Character"": ""Gwendolyn Pembroke"",
        ""Speaker"": ""Aranka Mamero""
      },
      {
        ""Character"": ""Lance Vaughn"",
        ""Speaker"": ""Rainer Schmitt""
      },
      {
        ""Character"": ""'The Destroyer'"",
        ""Speaker"": ""Stephan Schad""
      },
      {
        ""Character"": ""Darby Farnham"",
        ""Speaker"": ""Christine Jensen""
      },
      {
        ""Character"": ""Earl Forrester"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Alvin Cray"",
        ""Speaker"": ""Michael Bideller""
      },
      {
        ""Character"": ""Mr. Lloyd"",
        ""Speaker"": ""Lutz Mackensy""
      }
    ]
  },
  {
    ""Id"": ""259b6113-af03-4869-ab49-61fc1c81a663"",
    ""Title"": ""...und das Tuch der Toten"",
    ""NumberEuropa"": 174,
    ""ReleaseDate"": ""2015-03-06T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/174.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein zunächst harmloser Ausflug entwickelt sich zu einem geheimnisvollen Fall für die drei ???: In einem sagenumwobenen Waldgebiet in den Santa Monica Mountains streift eine düstere Gestalt umher. Ein Wesen aus der Urzeit? Justus, Peter und Bob sto�en auf rätselhafte Spuren. Was sie nicht wissen: Sie sind nicht die Verfolger, sondern die Beute..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Guillermo"",
        ""Speaker"": ""Mario Ramos""
      },
      {
        ""Character"": ""Stanley Morgan"",
        ""Speaker"": ""Romanus Fuhrmann""
      },
      {
        ""Character"": ""Grace Powell"",
        ""Speaker"": ""Luise Lunow""
      },
      {
        ""Character"": ""Angus"",
        ""Speaker"": ""Till Demtröder""
      },
      {
        ""Character"": ""Inspektor Cottahol"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Baxter"",
        ""Speaker"": ""Hans Kahlert""
      },
      {
        ""Character"": ""Kranführer"",
        ""Speaker"": ""Klaus Dittmann""
      }
    ]
  },
  {
    ""Id"": ""60b811ea-8d40-48f3-a7b3-30c1fd62fea0"",
    ""Title"": ""Schattenwelt"",
    ""NumberEuropa"": 175,
    ""ReleaseDate"": ""2015-05-15T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/175.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Teil A: Teuflisches Duell Kurz nach ihrem Einzug ins Studentenwohnheim werden die drei ??? Zeugen merkwürdiger Ereignisse auf dem Campus. Unmenschliche Schreie hallen �ber das Gelände, freundliche Studenten werden plötzlich aggressiv... Geht hier alles mit rechten Dingen zu? Und wer ist der Teumessische Fuchs, über den man überall Gerüchte hört? Eine Fuchsjagd der besonderen Art beginnt... Teil B: Angriff in der Nacht Ihre Ermittlungen führen die drei ??? immer weiter in einen Sumpf aus Lügen und dunklen Machenschaften. Doch wer steckt hinter alldem? Justus, Peter und Bob sind dem Teumessischen Fuchs auf der Spur, der überall und nirgends zu sein scheint. Doch haben die drei Detektive den richtigen Riecher? Eines Nachts schlägt ihr unbekannter Gegner plötzlich zu... Teil C: Die dunkle Macht Die drei Detektive machen ein paar spektakuläre Entdeckungen. Doch der Teumessische Fuchs scheint ihnen stets einen Schritt voraus zu sein. Noch immer wissen sie nicht, wer sich hinter dem rätselhaften Wesen verbirgt. Und je näher die drei ??? ihm kommen, desto gefährlicher wird es für sie. Als Justus, Peter und Bob endlich auf ihren Widersacher treffen, zeigt der Fuchs sein wahres Gesicht..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Andrews"",
        ""Speaker"": ""Henry König""
      },
      {
        ""Character"": ""Jeremy Bright"",
        ""Speaker"": ""Stephan Schad""
      },
      {
        ""Character"": ""Taylor-Jackson"",
        ""Speaker"": ""Jona Mues""
      },
      {
        ""Character"": ""Francine Breckenridge"",
        ""Speaker"": ""Elga Schütz""
      },
      {
        ""Character"": ""A.C. Berany"",
        ""Speaker"": ""Hanni Vanhaiden""
      },
      {
        ""Character"": ""Samantha"",
        ""Speaker"": ""Henrike Fehrs""
      },
      {
        ""Character"": ""Corvy"",
        ""Speaker"": ""Karin Suender""
      },
      {
        ""Character"": ""Lemuel Garvine"",
        ""Speaker"": ""Tim Grobe""
      },
      {
        ""Character"": ""Prof. Roalstad"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Chris"",
        ""Speaker"": ""Soi Anifantis""
      },
      {
        ""Character"": ""Gamma"",
        ""Speaker"": ""Wolfram Grandezka""
      },
      {
        ""Character"": ""Barfrau"",
        ""Speaker"": ""Rhesi Underberg""
      },
      {
        ""Character"": ""John"",
        ""Speaker"": ""Stephan Benson""
      },
      {
        ""Character"": ""Walker"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Lederhose"",
        ""Speaker"": ""Klaus Krückemeyer""
      },
      {
        ""Character"": ""1.Polizist"",
        ""Speaker"": ""Tim Kreuer""
      },
      {
        ""Character"": ""2.Polizist"",
        ""Speaker"": ""Jesse Grimm""
      },
      {
        ""Character"": ""Stimme (TS)"",
        ""Speaker"": ""Wolfgang Völz""
      },
      {
        ""Character"": ""Jason"",
        ""Speaker"": ""Woody Mues""
      },
      {
        ""Character"": ""Mrs. Roalstad"",
        ""Speaker"": ""Beate Rysopp""
      },
      {
        ""Character"": ""Mrs. Fernandez"",
        ""Speaker"": ""Anja Topf""
      },
      {
        ""Character"": ""Lemuel Garvine"",
        ""Speaker"": ""Tim Grobe""
      },
      {
        ""Character"": ""Emery"",
        ""Speaker"": ""Peter Weis""
      },
      {
        ""Character"": ""Ginger"",
        ""Speaker"": ""Heidi Schaffrath""
      },
      {
        ""Character"": ""Sanitäter"",
        ""Speaker"": ""Franzisko Löwe""
      },
      {
        ""Character"": ""Schwester"",
        ""Speaker"": ""Maike Nagel""
      },
      {
        ""Character"": ""Ivy"",
        ""Speaker"": ""Leonie Lander""
      },
      {
        ""Character"": ""Prof. Haynthorb"",
        ""Speaker"": ""Wolfgang Dräger""
      },
      {
        ""Character"": ""Dr. Wilcomb"",
        ""Speaker"": ""Heinz Lieven""
      }
    ]
  },
  {
    ""Id"": ""4d57b2f6-020d-448b-bae3-fe1adc3f14e2"",
    ""Title"": ""...und der gestohlene Sieg"",
    ""NumberEuropa"": 176,
    ""ReleaseDate"": ""2015-07-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/176.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Zwei Tore liegen die L.A. Strikers zurück, zehn Minuten vor dem Abpfiff. Das Fußballspiel gegen die haushoch überlegenen Rochester Ravens scheint längst entschieden zu sein. Doch plötzlich wendet sich das Blatt und die Strikers nehmen den glänzenden Pokal mit nach Hause. Was ist geschehen? Die Ermittlungen bringen Justus, Peter und Bob auf die Spur eines skrupellosen Erpressers..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Sidney"",
        ""Speaker"": ""Dorothee Sturz""
      },
      {
        ""Character"": ""Tiffany"",
        ""Speaker"": ""Maureen Havlena""
      },
      {
        ""Character"": ""Salma Hutchinson"",
        ""Speaker"": ""Tina Eschmann""
      },
      {
        ""Character"": ""Trevor Pomery"",
        ""Speaker"": ""Ben Hecker""
      },
      {
        ""Character"": ""Beatrice"",
        ""Speaker"": ""Ursula Sieg""
      },
      {
        ""Character"": ""Claire"",
        ""Speaker"": ""Karin Eckhold""
      },
      {
        ""Character"": ""Pflegerin"",
        ""Speaker"": ""Susanne Wulkow""
      },
      {
        ""Character"": ""Roger Wolf"",
        ""Speaker"": ""Stephan Schad""
      }
    ]
  },
  {
    ""Id"": ""42e1434f-348b-47e2-af58-1630359969bb"",
    ""Title"": ""Der Geist des Goldgr�bers"",
    ""NumberEuropa"": 177,
    ""ReleaseDate"": ""2015-10-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/177.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Im menschenleeren Dead Mans Canyon begegnet den drei ??? plötzlich ein Goldgräber. Und zwar nicht irgendeiner - John Dewey kam vor über 100 Jahren zu Tode und verfluchte jeden, der seinem Gold zu nahe kommt. Für Justus steht fest: Alles Legende! Doch als in der darauffolgenden Nacht gespenstischer Besuch vor der Tür steht, erwacht die Legende zum Leben ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Dusty Kirkpatrick"",
        ""Speaker"": ""Hans Kahlert""
      },
      {
        ""Character"": ""Miranda Kramer"",
        ""Speaker"": ""Susanne Sternberg""
      },
      {
        ""Character"": ""Barclay"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Holly"",
        ""Speaker"": ""Martina Treger""
      },
      {
        ""Character"": ""Brian"",
        ""Speaker"": ""Volker Hanisch""
      },
      {
        ""Character"": ""Raven"",
        ""Speaker"": ""Neda Rahmanian""
      },
      {
        ""Character"": ""Dr. Hardwick"",
        ""Speaker"": ""Till Huster""
      },
      {
        ""Character"": ""Robert"",
        ""Speaker"": ""Tim Kreuer""
      },
      {
        ""Character"": ""Manolo"",
        ""Speaker"": ""Wolfgang Berger""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Kai-Hendrik Möller""
      }
    ]
  },
  {
    ""Id"": ""d12de517-63cd-4544-aa46-a45764305e2c"",
    ""Title"": ""Der gefiederte Schrecken"",
    ""NumberEuropa"": 178,
    ""ReleaseDate"": ""2015-12-04T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/178.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Was hat ein seltsames Vogelwesen mit einem riesigen Aquarium zu tun? Wer hat ein Interesse daran, die gigantische Meereslandschaft des mürrischen Mr Faring zu zerstören? Und vor allem, warum? Schon am Anfang ihres neuesten Falles gibt es eine Menge Fragezeichen für Justus, Peter und Bob. Und am Tatort gilt es nicht nur, erstaunliche Kreaturen in Sicherheit zu bringen, sondern auch ein höchst merkwürdiges Rätsel zu lösen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Barbara Mathewson"",
        ""Speaker"": ""Tanja Geke""
      },
      {
        ""Character"": ""Zacharias Faring"",
        ""Speaker"": ""Olaf Reichmann""
      },
      {
        ""Character"": ""Malone"",
        ""Speaker"": ""Tilo Schmitz""
      },
      {
        ""Character"": ""Ben Crane"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""Timothy Jackson"",
        ""Speaker"": ""Nicolas König""
      },
      {
        ""Character"": ""Reginald"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      }
    ]
  },
  {
    ""Id"": ""b5201634-f48a-4227-80dc-df78bfde33b6"",
    ""Title"": ""Die Rache des Untoten"",
    ""NumberEuropa"": 179,
    ""ReleaseDate"": ""2016-01-15T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/179.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Bob soll ein Vermögen erben! Nur hat er von seinem Wohltäter noch nie etwas gehört. Schnell stellt sich heraus, dass auch andere Menschen ein ähnliches Schreiben erhalten haben. Die drei ??? brechen gemeinsam mit ihnen zu einer Reise auf. Ihr Ziel: Eine verlassene Hütte im \""Tal der Klapperschlangen\"". Plötzlich verschwindet eine junge Frau und es wird klar: Jemand hat es auf die Reisegruppe abgesehen..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Evander Whiteside"",
        ""Speaker"": ""Claus Wilcke""
      },
      {
        ""Character"": ""Wendy Brown"",
        ""Speaker"": ""Catrin Owerfeldt""
      },
      {
        ""Character"": ""Christopher Barclay"",
        ""Speaker"": ""Martin Paas""
      },
      {
        ""Character"": ""Edgar Bristol"",
        ""Speaker"": ""Sascha Gutzeit""
      },
      {
        ""Character"": ""Carter Godfrey"",
        ""Speaker"": ""Nicolas König""
      },
      {
        ""Character"": ""Chuck Foster"",
        ""Speaker"": ""Heiko Wohlgemuth""
      },
      {
        ""Character"": ""Busfahrer Sam"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Officer Ossietzky"",
        ""Speaker"": ""Romanus Fuhrmann""
      },
      {
        ""Character"": ""Matt"",
        ""Speaker"": ""Mike Oslowski""
      },
      {
        ""Character"": ""Stephen"",
        ""Speaker"": ""Alexander Kruuse-Mettin""
      },
      {
        ""Character"": ""Billy"",
        ""Speaker"": ""Tom Pidde""
      },
      {
        ""Character"": ""Polizist Jerry"",
        ""Speaker"": ""Stefan Weißenburger""
      }
    ]
  },
  {
    ""Id"": ""799815df-5585-4baa-b1fb-62149675a432"",
    ""Title"": ""...und die flüsternden Puppen"",
    ""NumberEuropa"": 180,
    ""ReleaseDate"": ""2016-04-03T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/180.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Das Mädchen Bianca wurde entführt! Am helllichten Tag, direkt vor einem Fitnessstudio! Eine Botschaft, offenbar in Panik auf einem alten Walkman hinterlassen, ist der einzige Hinweis. Die drei ??? verfolgen die Spur der Entführer bis zu einer verlassenen Hütte in Mexiko - und bringen sich dabei selbst in Gefahr."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Michael Rompa"",
        ""Speaker"": ""Mario Ramos""
      },
      {
        ""Character"": ""Afton"",
        ""Speaker"": ""Julia Fölster""
      },
      {
        ""Character"": ""Skinny Norris"",
        ""Speaker"": ""Michael Harck""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""é Minninger""
      },
      {
        ""Character"": ""Chef"",
        ""Speaker"": ""Eric Schäffler""
      },
      {
        ""Character"": ""Ron"",
        ""Speaker"": ""Gordon Piedesack""
      },
      {
        ""Character"": ""Ansage"",
        ""Speaker"": ""Joachim Langer""
      },
      {
        ""Character"": ""Oma"",
        ""Speaker"": ""Renate Pichler""
      }
    ]
  },
  {
    ""Id"": ""fd705619-6981-4a63-87e1-c8b8d53d0940"",
    ""Title"": ""Das Kabinett des Zauberers"",
    ""NumberEuropa"": 181,
    ""ReleaseDate"": ""2016-05-13T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/181.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Wie kann es sein, dass ein Zauberer während einer Vorstellung verschwindet? Ist er Opfer seiner eigenen Magie geworden? Alles andere als Hokuspokus, sind sich die drei ??? einig. Auf ihrer Suche nach dem verschwundenen Zauberer Pablo müssen Justus, Peter und Bob mehr als nur ein Zauberkabinett durchsuchen, und offebar gefällt das jemandem überhaupt nicht ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Linneweg""
      },
      {
        ""Character"": ""Quinn"",
        ""Speaker"": ""Tobias Diakow""
      },
      {
        ""Character"": ""Nightingale"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Pablo"",
        ""Speaker"": ""Till Huster""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Mrs. Thompson"",
        ""Speaker"": ""Ingeborg Kallweit""
      },
      {
        ""Character"": ""Mrs. Kato"",
        ""Speaker"": ""Dorothea Hagener""
      },
      {
        ""Character"": ""Sullivan"",
        ""Speaker"": ""Jonas Hartmann""
      },
      {
        ""Character"": ""Angelina"",
        ""Speaker"": ""Norma Draeger""
      },
      {
        ""Character"": ""Joshua"",
        ""Speaker"": ""Hugo Richert""
      },
      {
        ""Character"": ""1. Junge"",
        ""Speaker"": ""Louis Körting""
      },
      {
        ""Character"": ""2. Junge"",
        ""Speaker"": ""Henrik Bichels""
      },
      {
        ""Character"": ""Mädchen"",
        ""Speaker"": ""Lilian Körting""
      }
    ]
  },
  {
    ""Id"": ""efb7c779-660d-42dc-bafe-af7c9b400ce5"",
    ""Title"": ""Im Haus des Henkers"",
    ""NumberEuropa"": 182,
    ""ReleaseDate"": ""2016-07-22T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/182.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine Serie von Überfällen beschäftigt die Polizei von Rocky Beach. Als ein harmlos wirkender Mann unerwartet den letzten Raub gesteht und ein alter Bekannter in die Sache hineingezogen wird, ist klar: Hier geht etwas nicht mit rechten Dingen zu! Justus, Peter und Bob ermitteln an düsteren Orten und geraten in die Gesellschaft zwielichtiger Gestalten ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mrs. Shaw"",
        ""Speaker"": ""Heikedine Körting""
      },
      {
        ""Character"": ""Randy Carlisle"",
        ""Speaker"": ""Johannes Semm""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""André Minninger""
      },
      {
        ""Character"": ""Busfahrer"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Christoph Meyer""
      },
      {
        ""Character"": ""Mia"",
        ""Speaker"": ""Elea Richert""
      },
      {
        ""Character"": ""Mrs. Crouch"",
        ""Speaker"": ""Pia Werfel""
      },
      {
        ""Character"": ""Edna Shinefield"",
        ""Speaker"": ""Rosemarie Wohlbauer""
      },
      {
        ""Character"": ""George"",
        ""Speaker"": ""Gordon Piedesack""
      },
      {
        ""Character"": ""Ronny"",
        ""Speaker"": ""Anton Pleva""
      },
      {
        ""Character"": ""Loreen"",
        ""Speaker"": ""Barbara Schipper""
      },
      {
        ""Character"": ""TV-Moderatorin"",
        ""Speaker"": ""Dagmar Berghoff""
      },
      {
        ""Character"": ""Daphne"",
        ""Speaker"": ""Enie van de Meiklokjes""
      },
      {
        ""Character"": ""Kiera"",
        ""Speaker"": ""Isabella Grothe""
      },
      {
        ""Character"": ""Luther Litti"",
        ""Speaker"": ""Wolf Frass""
      },
      {
        ""Character"": ""Kyle Caldwell"",
        ""Speaker"": ""Joachim Kretzer""
      },
      {
        ""Character"": ""Hay"",
        ""Speaker"": ""Tobias Diakow""
      },
      {
        ""Character"": ""Junge"",
        ""Speaker"": ""Hugo Richert""
      }
    ]
  },
  {
    ""Id"": ""21dd5294-ce64-4614-97d7-72420fd8ad17"",
    ""Title"": ""...und der letzte Song"",
    ""NumberEuropa"": 183,
    ""ReleaseDate"": ""2016-09-30T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/183.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Lenny The Rock, der erfolgreiche Rockstar, veranstaltet auf seinem Anwesen ein teures Geburtstagskonzert voller Spezialeffekte. Als Höhepunkt der Party hat er eine Überraschung angekündigt. Auch Justus, Peter und Bob sind unter den Gästen. Die Detektive rechnen mit Vielem - doch sicher nicht mit dem, was dann passiert! Bei den Ermittlungen gerät einer der drei in große Gefahr..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Linneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Lenny The Rock"",
        ""Speaker"": ""Peter Kirchberger""
      },
      {
        ""Character"": ""Sue Tamara"",
        ""Speaker"": ""Maria Hartmann""
      },
      {
        ""Character"": ""Sax Sandler"",
        ""Speaker"": ""Christian Concilio""
      },
      {
        ""Character"": ""Tim Durnell"",
        ""Speaker"": ""Douglas Welbat""
      },
      {
        ""Character"": ""Ron"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Keith"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Debbie Peterson"",
        ""Speaker"": ""Maud Ackermann""
      },
      {
        ""Character"": ""Frank Wheeler"",
        ""Speaker"": ""Timo Wenzel""
      },
      {
        ""Character"": ""Joe"",
        ""Speaker"": ""Stefan Brönneke""
      },
      {
        ""Character"": ""Clayton"",
        ""Speaker"": ""Gordon Piedesack""
      },
      {
        ""Character"": ""Kellnerin"",
        ""Speaker"": ""Simona Pahl""
      },
      {
        ""Character"": ""Partygäste"",
        ""Speaker"": ""Die Gäste Record-Release-Party am 8. Mai 2016 in Hasselburg""
      }
    ]
  },
  {
    ""Id"": ""ac1dcdeb-48da-4707-9201-c6d20369ce2d"",
    ""Title"": ""...und der Hexengarten"",
    ""NumberEuropa"": 184,
    ""ReleaseDate"": ""2016-12-02T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/184.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Die drei ??? sollen gegen Geisterpflanzen ermitteln? Zunächst hält Peter den Auftrag seines Schulkameraden Jesse für einen Scherz. Doch der meint es ernst - denn das mysteriöse Leuchten und die körperlosen Stimmen im Gewächshaus eines benachbarten Anwesens scheinen echt zu sein. Als Jesses Schwester behauptet, das Anwesen gehöre einer Hexenfamilie, werden die Detektive hellhörig..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Jesse"",
        ""Speaker"": ""Jacob Weigert""
      },
      {
        ""Character"": ""Trainer"",
        ""Speaker"": ""Till Huster""
      },
      {
        ""Character"": ""Jaden"",
        ""Speaker"": ""Flemming Draeger""
      },
      {
        ""Character"": ""Joshua"",
        ""Speaker"": ""Louis Körting""
      },
      {
        ""Character"": ""April"",
        ""Speaker"": ""Lilli Körting""
      },
      {
        ""Character"": ""Autumn"",
        ""Speaker"": ""Sabrina Heuer-Diakow""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Charles Morland"",
        ""Speaker"": ""Horst Stark""
      },
      {
        ""Character"": ""Tanika Frost"",
        ""Speaker"": ""Isabella Grothe""
      },
      {
        ""Character"": ""Savannah Frost"",
        ""Speaker"": ""Christiane Leuchtmann""
      },
      {
        ""Character"": ""Dennis Frost"",
        ""Speaker"": ""Sascha Oliver Bauer""
      },
      {
        ""Character"": ""Jane Thompson"",
        ""Speaker"": ""Maud Ackermann""
      },
      {
        ""Character"": ""Tyler"",
        ""Speaker"": ""Christian Rudolf""
      },
      {
        ""Character"": ""Gardener"",
        ""Speaker"": ""Christian Concilio""
      }
    ]
  },
  {
    ""Id"": ""4dc09eb4-6e4f-4b93-bd55-7877d313cc0f"",
    ""Title"": ""...und der Mann ohne Augen"",
    ""NumberEuropa"": 185,
    ""ReleaseDate"": ""2017-01-20T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/185.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Es brennt! Dichte Flammen lodern auf der Veranda eines einsamen Hauses am Rand von Rocky Beach. Nachdem die Gefahr gebannt ist, nehmen Justus, Peter und Bob das Haus unter die Lupe. Könnte es Brandstiftung gewesen sein? Als plötzlich ein Einbrecher durch eine ausgebrannte Wohnung schleicht, sind sich sicher: Das war kein Unfall..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Adam Quinn"",
        ""Speaker"": ""Romanus Fuhrmann""
      },
      {
        ""Character"": ""Mr. Carrington"",
        ""Speaker"": ""Martin May""
      },
      {
        ""Character"": ""Mrs. Carrington"",
        ""Speaker"": ""Manuela Dahm-Mauerhofer""
      },
      {
        ""Character"": ""Liza Hawkins"",
        ""Speaker"": ""Lucia Angela Mahler""
      },
      {
        ""Character"": ""Mr. Hawkins"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Mrs. Hawkins"",
        ""Speaker"": ""Birte Kretschmer""
      },
      {
        ""Character"": ""Leslie Louge-Smith"",
        ""Speaker"": ""Uschi Hugo""
      },
      {
        ""Character"": ""Schauspieler"",
        ""Speaker"": ""Erik Schäffler""
      },
      {
        ""Character"": ""Britney Rogers"",
        ""Speaker"": ""Theresa Berlage""
      },
      {
        ""Character"": ""Sanitäter"",
        ""Speaker"": ""Oliver Böttcher""
      },
      {
        ""Character"": ""Mr. Sisko"",
        ""Speaker"": ""Daniel Welbat""
      }
    ]
  },
  {
    ""Id"": ""1da77f8a-ac16-4fd3-a948-05f11405fa28"",
    ""Title"": ""Insel des Vergessens"",
    ""NumberEuropa"": 186,
    ""ReleaseDate"": ""2017-03-10T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/186.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Peters Opa ist verschwunden! Angeblich soll Bennington Peck still und heimlich in ein Pflegeheim gezogen sein und wird nun vermisst. Peter ist fassungslos. Das kann doch unmöglich sein! Als der Zweite Detektiv plötzlich in den Lokalnachrichten entdeckt, wie der alte Herr eine Tankstelle überf�llt, überstürzen sich die Ereignisse..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Thomas Fritsch""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Ben Peck"",
        ""Speaker"": ""Wolfgang Völz""
      },
      {
        ""Character"": ""Sandra"",
        ""Speaker"": ""Maureen Havlena""
      },
      {
        ""Character"": ""TV-Nachrichtensprecher"",
        ""Speaker"": ""Holger Wemhoff""
      },
      {
        ""Character"": ""Mr. Castro"",
        ""Speaker"": ""Jürgen Thormann""
      },
      {
        ""Character"": ""Dokor Burke"",
        ""Speaker"": ""Hans Peter Korff""
      },
      {
        ""Character"": ""Mrs. Penny"",
        ""Speaker"": ""Herma Koehn""
      },
      {
        ""Character"": ""Schwester Beatrixe"",
        ""Speaker"": ""Roswitha Völz""
      },
      {
        ""Character"": ""Mr. Hooper"",
        ""Speaker"": ""Günther Karl""
      },
      {
        ""Character"": ""Ellyn Djawadi"",
        ""Speaker"": ""Anika Pages""
      },
      {
        ""Character"": ""Mr. Turner"",
        ""Speaker"": ""Klaus Dittmann""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Godween"",
        ""Speaker"": ""André Minninger""
      }
    ]
  },
  {
    ""Id"": ""bdaba85a-e63e-4fae-b419-d678b4af8557"",
    ""Title"": ""...und das silberne Amulett"",
    ""NumberEuropa"": 187,
    ""ReleaseDate"": ""2017-05-19T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/187.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Eine rätselhafte Botschaft fliegt über den Zaun des Schrottplatzes: eine Dose, darin ein Schlüssel, ein Parkschein und ein silbernes Amulett. Was hat es damit auf sich? Und vor allem: Wer hat den drei ??? die Dose zugespielt? Justus, Peter und Bob müssen Antworten auf viele Fragen finden - und das schnell..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Axel Milberg""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Linneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Kramer"",
        ""Speaker"": ""Volker Bogdan""
      },
      {
        ""Character"": ""Emma Bailey"",
        ""Speaker"": ""Hansi Jochmann""
      },
      {
        ""Character"": ""Hank"",
        ""Speaker"": ""Ben Hecker""
      },
      {
        ""Character"": ""Lewis Geriwell"",
        ""Speaker"": ""Frank Gustavus""
      },
      {
        ""Character"": ""Henry Appleton"",
        ""Speaker"": ""Peter Heeckt""
      },
      {
        ""Character"": ""Amber"",
        ""Speaker"": ""Sarah Madeleine Tusk""
      },
      {
        ""Character"": ""Laura"",
        ""Speaker"": ""Maud Ackermann""
      },
      {
        ""Character"": ""Gerald"",
        ""Speaker"": ""Michael von Rospatt""
      },
      {
        ""Character"": ""Nat"",
        ""Speaker"": ""Tobias Schmidt""
      },
      {
        ""Character"": ""Collins"",
        ""Speaker"": ""Gosta Liptow""
      },
      {
        ""Character"": ""Nadar Rope"",
        ""Speaker"": ""Michael Bideller""
      }
    ]
  },
  {
    ""Id"": ""e3cc8859-2926-4a16-a83c-766293dad932"",
    ""Title"": ""Signale aus dem Jenseits"",
    ""NumberEuropa"": 188,
    ""ReleaseDate"": ""2017-07-28T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/188.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Mit den Toten Kontakt aufnehmen: An so etwas glauben die drei ??? nicht. Doch genau das scheint Astrala in Karma Hour, der neuen Lieblingssendung von Tante Mathilda, tatsächlich zu gelingen. Was steckt hinter den Fähigkeiten der geheimnisvollen Spiritistin? Und weshalb kommt sie Bob so bekannt vor? Die drei Detektive setzen sich auf ihre Spur und geraten dabei in die Schusslinie eines äußerst mysteriösen Verbrechers...."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Axel Milberg""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Linneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Inspektor Cotta"",
        ""Speaker"": ""Holger Mahlich""
      },
      {
        ""Character"": ""Clarissa Franklin"",
        ""Speaker"": ""Judy Winter""
      },
      {
        ""Character"": ""Laura Stryker"",
        ""Speaker"": ""Regina Lemnitz""
      },
      {
        ""Character"": ""Anruferin"",
        ""Speaker"": ""Topsy Küppers""
      },
      {
        ""Character"": ""Anrufer"",
        ""Speaker"": ""Oliver Kalkofe""
      },
      {
        ""Character"": ""Regisseur"",
        ""Speaker"": ""Nikolas Tantsoukes""
      },
      {
        ""Character"": ""Stephen"",
        ""Speaker"": ""Timo Hempel""
      },
      {
        ""Character"": ""Redakteurin"",
        ""Speaker"": ""Reinhilt Schneider""
      },
      {
        ""Character"": ""Goodween"",
        ""Speaker"": ""André Minninger""
      },
      {
        ""Character"": ""Sax Sandler"",
        ""Speaker"": ""Christian Concilio""
      }
    ]
  },
  {
    ""Id"": ""31c54428-3021-494a-a906-206afebf10bb"",
    ""Title"": ""Der unsichtbare Passagier"",
    ""NumberEuropa"": 189,
    ""ReleaseDate"": ""2017-09-29T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/189.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Justus, Peter und Bob steht ein tolles Abenteuer bevor: eine Reise mit dem Coast Imperial, dem berühmten Luxuszug! Doch kurz nach Fahrtbeginn verschwindet einer der Mitreisenden spurlos. Handelt es sich um eine Entführung? Die drei Fragezeichen nehmen die Ermittlungen auf. Es bleibt ihnen nicht viel Zeit. Der nächste Bahnhof wäre die perfekte Fluchtmöglichkeit ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Axel Milberg""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Mr. Whitty"",
        ""Speaker"": ""Claus Wilcke""
      },
      {
        ""Character"": ""Hank"",
        ""Speaker"": ""Robert Missler""
      },
      {
        ""Character"": ""Cowboy Dick"",
        ""Speaker"": ""Wolfgang Kaven""
      },
      {
        ""Character"": ""Mr. Arbuthnott"",
        ""Speaker"": ""Eckart Dux""
      },
      {
        ""Character"": ""Mrs. Lockwood"",
        ""Speaker"": ""Ingeborg Kallweit""
      },
      {
        ""Character"": ""Linda"",
        ""Speaker"": ""Svenja Pages""
      },
      {
        ""Character"": ""Roger"",
        ""Speaker"": ""Christian Stark""
      },
      {
        ""Character"": ""Mann"",
        ""Speaker"": ""Gernot Endemann""
      },
      {
        ""Character"": ""Einsatzleiter"",
        ""Speaker"": ""Achim Schülke""
      },
      {
        ""Character"": ""Polizist"",
        ""Speaker"": ""Alexander Mettin""
      },
      {
        ""Character"": ""Mechaniker"",
        ""Speaker"": ""Joachim Kretzer""
      }
    ]
  },
  {
    ""Id"": ""5f2f82f5-ef80-45ef-bdd9-1fe211fc07eb"",
    ""Title"": ""... und die Kammer der Rätsel"",
    ""NumberEuropa"": 190,
    ""ReleaseDate"": ""2017-12-01T00:00:00"",
    ""CoverUrl"": ""http://www.rocky-beach.com/hoerspiel/cover/190.jpg"",
    ""Interpreter"": ""Die drei ???"",
    ""Description"": ""Ein Auftrag der seltsamen Art: Die drei ??? sollen bei einer Wette behilflich sein. Gesucht ist ein Team aus klugen Köpfen, die sich in weniger als fünf Stunden aus fünf verschiedenen Rätselräumen befreien können. Wer wäre da geeigneter als Justus, Peter und Bob? Doch was zunächst als Spa� beginnt, entpuppt sich bald als gefährlicher Ernst ..."",
    ""Roles"": [
      {
        ""Character"": ""Erzähler"",
        ""Speaker"": ""Axel Milberg""
      },
      {
        ""Character"": ""Justus Jonas"",
        ""Speaker"": ""Oliver Rohrbeck""
      },
      {
        ""Character"": ""Peter Shaw"",
        ""Speaker"": ""Jens Wawrczeck""
      },
      {
        ""Character"": ""Bob Andrews"",
        ""Speaker"": ""Andreas Fröhlich""
      },
      {
        ""Character"": ""Tante Mathilda"",
        ""Speaker"": ""Karin Linneweg""
      },
      {
        ""Character"": ""Onkel Titus"",
        ""Speaker"": ""Rüdiger Schulzki""
      },
      {
        ""Character"": ""Jeff Ronaldo"",
        ""Speaker"": ""Till Huster""
      },
      {
        ""Character"": ""Mr. McBrandon"",
        ""Speaker"": ""Rainer Brandt""
      },
      {
        ""Character"": ""Sandy"",
        ""Speaker"": ""Anna Carlsson""
      },
      {
        ""Character"": ""Roboter"",
        ""Speaker"": ""Joachim Kretzer""
      },
      {
        ""Character"": ""Computerstimme"",
        ""Speaker"": ""Hansi Jochmann""
      },
      {
        ""Character"": ""Bruce Torino"",
        ""Speaker"": ""Michael Lott""
      }
    ]
  }
]";
    }
}