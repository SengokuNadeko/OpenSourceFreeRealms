﻿using SOE.Core;
using SOE.Interfaces;
using SOE;
using Gateway.Login;
using System.Threading;

namespace Gateway.Player
{
    internal class NPC
    {
        public static void SendPlayerUpdatePacketAddNpc(SOEClient soeClient)
        {

            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C008200000052000000C00000000111005200000000924E0001110052000000004D4B000111005200000080015000010B005200000070015000010B005200000040FF4F00010B0052000000A0005000010B0052000000C0005000010B0052000000D0005000010B005200000050095000010B0052000000A01524000111005200000060964F00010B0052000000F0FB4F00010B005200000080005000010B005200000060D54E0001110052000000D0C14D0001110052000000C0015000010B00520000009081370001110052000000B0FF4F00010B0052000000F0085000010B005200000030095000010B00520000004011000001110052000000C0D449000111005200000040024A000111005200000040944F0001110052000000A01026000111005200000000844F000111005200000040844F0001110052000000B0904F000111005200000030CC49000111005200000030F24A000111005200000040F24A000111005200000010005000010B0052000000305A00000111005200000030FB4F00010B0052000000305B000001180052000000205B0000011800520000005001000001050052000000000D000001110052000000D03F000001050052000000B08E4F000111005200000060944F000111005200000000914F0001110052000000C08E4F000111005200000070944F0001110052000000D08E4F0001110052000000D0904F0001110052000000E08E4F0001110052000000A0904F000111005200000050844F0001110052000000E0904F000111005200000090CC49000111005200000000D249000111005200000020D249000111005200000010C54A0001110052000000E0834F000111005200000020844F000111005200000030844F0001110052000000F0904F000111005200000030D2490001110052000000A0CC49000111005200000040CC490001110052000000003F4C0001110052000000A03E4C0001110052000000E0C74F0001110052000000D0C34A000111005200000010DB4A000111005200000070F04C0001110052000000F0834F000111005200000010844F0001110052000000C0904F00011100520000006030000001120052000000B0C34A000111005200000020CC490001110052000000C03E4C0001110052000000A07B4D0001110052000000F0C74F0001110052000000909D4E000111005200000000CC49000111005200000050F24A0001110052000000907B4D000111005200000020024A0001110052000000F0F14A0001110052000000B0EF4A0001110052000000D0EF4A0001110052000000B03E4C0001110052000000C0EF4A0001110052000000E0EF4A0001110052000000F0EF4A0001110052000000807B4D000111005200000020D449000111005200000050D449000111005200000000D84B0001110052000000803E4C0001110052000000501C500001110052000000005B0000011800520000003021000001110052000000F038000001110052000000105B000001180052000000B057000001110052000000D05600000105005200000050274F0001110052000000A051000001050052000000301C500001110052000000701A000001110052000000B04D000001110052000000404E000001050052000000305800000111005200000020580000011100520000006057000001110052000000C0174D0001110052000000D07600000105005200000020564E0001110052000000F01B5000011100520000007057000001110052000000B002000001050052000000C077000001000052000000F056000001110052000000C04B0000010500520000001059000001050052000000B018000001050052000000904F00000111005200000070D54D00011100520000007002000001050052000000705B0000011100520000002003000001050052000000E021000001110052000000A02A00000117005200000030574B0001110052000000501B4C00011100"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C00010000005200000080345000011100"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000100000052000000F01B50000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000100000052000000301C50000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000F000000520000002004000001050052000000304C000001050052000000C0A9000001110052000000203B000001110052000000B0A900000111005200000080A9000001110052000000C0060000011100520000003001000001050052000000906E00000111005200000020590000010500520000003059000001110052000000000400000105005200000030D24900000052000000A0CC4900000052000000501C50000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000500000052000000C04300000105005200000000914F00000052000000A03E4C00000052000000E0C74F00000052000000501B4C000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C00050000005200000000D2490000005200000030844F0000005200000040CC490000005200000000D84B00000052000000000400000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000200000052000000003F4C00000052000000803450000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000C00000052000000B08E4F0000005200000090CC490000005200000020D24900000052000000E0834F00000052000000F0904F0000005200000050D44900000052000000803E4C0000005200000030574B00000052000000304C000000005200000030010000000052000000906E0000000052000000305900000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000D000000520000003001000001050052000000906E000001110052000000500300000105005200000000924E0000005200000060944F00000052000000D08E4F00000052000000D0904F0000005200000010C54A0000005200000020844F0000005200000020CC4900000052000000C03E4C00000052000000909D4E0000005200000020D449000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C001100000052000000304C000001050052000000A04E00000105005200000050030000010500520000009033000001110052000000305900000111005200000000040000010500520000003005000001050052000000406F000001110052000000C0000000000052000000C0D4490000005200000040024A00000052000000C08E4F0000005200000070944F0000005200000050844F00000052000000E0904F0000005200000060300000000052000000B0C34A000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000F00000052000000203E0000011100520000001003000001050052000000F003000001110052000000B02200000111005200000040944F00000052000000A0102600000052000000E08E4F00000052000000A0904F0000005200000070F04C0000005200000010844F00000052000000A07B4D00000052000000F0C74F00000052000000C0EF4A00000052000000F0EF4A00000052000000807B4D000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C00190000005200000060700000011100520000001004000001110052000000506F000001110052000000004C0000010500520000002002000001050052000000A0152400000052000000908137000000520000004011000000005200000000844F0000005200000040844F00000052000000B0904F0000005200000040F24A00000052000000D0C34A0000005200000010DB4A00000052000000F0834F00000052000000C0904F0000005200000000CC490000005200000050F24A00000052000000907B4D0000005200000020024A00000052000000F0F14A00000052000000B0EF4A00000052000000D0EF4A00000052000000B03E4C00000052000000E0EF4A000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C0009000000520000001002000001050152000000906F000001050052000000F02000000111005200000080330000011100520000008001500000005200000070015000000052000000C001500000005200000030CC490000005200000030F24A000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C00010000005200000030700000011100"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketNpcRelevance */"23000C000100000052000000300950000000"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A008200000052000000C00000000001000000010000000C000000000000009D1D0000240000000000000000015200000000924E000006000000030000000000000000000000DD9F06000000000000000000000152000000004D4B000006000000030000000000000000000000DD9F060000000000000000000001520000008001500001030000000152000000700150000103000000015200000040FF4F0001030000000152000000A000500001030000000152000000C000500001030000000152000000D0005000010300000001520000005009500001030000000152000000A0152400000600000003000000000000000000000071A10600000000000000000000015200000060964F0001030000000152000000F0FB4F0001030000000152000000800050000103000000015200000060D54E0000060000000300000000000000000000007C9F06000000000000000000000152000000D0C14D00000600000003000000000000000000000048A106000000000000000000000152000000C001500001030000000152000000908137000006000000030000000000000000000000DD9F06000000000000000000000152000000B0FF4F0001030000000152000000F0085000010300000001520000003009500001030000000152000000401100000006000000160000000B00000000000000655A0000FFFFFFFF00000000000152000000C0D44900000600000003000000000000000000000035D54D00000000000000000000015200000040024A000006000000030000000000000000000000F39F0600000000000000000000015200000040944F000006000000030000000000000000000000EE9F06000000000000000000000152000000A010260000060000000300000000000000000000007C9F0600000000000000000000015200000000844F00000600000003000000000000000000000035D54D00000000000000000000015200000040844F00000600000003000000000000000000000035D54D000000000000000000000152000000B0904F000006000000030000000000000000000000F39F0600000000000000000000015200000030CC490000060000000300000000000000000000007C9F0600000000000000000000015200000030F24A000006000000030000000000000000000000EE9F0600000000000000000000015200000040F24A000006000000030000000000000000000000EE9F060000000000000000000001520000001000500001030000000152000000305A00000001000000010000000C00000000000000CEA10600000000000000000000015200000030FB4F0001030000000152000000305B000000FFFFFFFF65000000BD00000000000000428901005F92010000000000000152000000205B000000FFFFFFFF65000000BD00000000000000DB6A06000000000000000000000152000000500100000002000000020000000200000000000000B81D00005A04000000000000000152000000000D000000060000000300000000000000000000005F510000FFFFFFFF00000000000152000000D03F00000000000000120000000000000000000000EDDE0500FFFFFFFF01000000000152000000B08E4F0000060000000300000000000000000000007C9F0600000000000000000000015200000060944F000006000000030000000000000000000000EE9F0600000000000000000000015200000000914F000006000000030000000000000000000000F39F06000000000000000000000152000000C08E4F0000060000000300000000000000000000007C9F0600000000000000000000015200000070944F000006000000030000000000000000000000EE9F06000000000000000000000152000000D08E4F0000060000000300000000000000000000007C9F06000000000000000000000152000000D0904F000006000000030000000000000000000000F39F06000000000000000000000152000000E08E4F0000060000000300000000000000000000007C9F06000000000000000000000152000000A0904F000006000000030000000000000000000000F39F0600000000000000000000015200000050844F00000600000003000000000000000000000035D54D000000000000000000000152000000E0904F000006000000030000000000000000000000F39F0600000000000000000000015200000090CC490000060000000300000000000000000000007C9F0600000000000000000000015200000000D249000006000000030000000000000000000000EE9F0600000000000000000000015200000020D249000006000000030000000000000000000000EE9F0600000000000000000000015200000010C54A000006000000030000000000000000000000EE9F06000000000000000000000152000000E0834F00000600000003000000000000000000000035D54D00000000000000000000015200000020844F00000600000003000000000000000000000035D54D00000000000000000000015200000030844F00000600000003000000000000000000000035D54D000000000000000000000152000000F0904F000006000000030000000000000000000000F39F0600000000000000000000015200000030D249000006000000030000000000000000000000EE9F06000000000000000000000152000000A0CC490000060000000300000000000000000000007C9F0600000000000000000000015200000040CC490000060000000300000000000000000000007C9F06000000000000000000000152000000003F4C000006000000030000000000000000000000F39F06000000000000000000000152000000A03E4C000006000000030000000000000000000000F39F06000000000000000000000152000000E0C74F00000600000003000000000000000000000035D54D000000000000000000000152000000D0C34A0000060000000300000000000000000000007C9F0600000000000000000000015200000010DB4A000006000000030000000000000000000000EE9F0600000000000000000000015200000070F04C000006000000030000000000000000000000EE9F06000000000000000000000152000000F0834F00000600000003000000000000000000000035D54D00000000000000000000015200000010844F00000600000003000000000000000000000035D54D000000000000000000000152000000C0904F000006000000030000000000000000000000F39F06000000000000000000000152000000603000000006000000240000003D00000000000000E1890100FFFFFFFF00000000000152000000B0C34A0000060000000300000000000000000000007C9F0600000000000000000000015200000020CC490000060000000300000000000000000000007C9F06000000000000000000000152000000C03E4C000006000000030000000000000000000000F39F06000000000000000000000152000000A07B4D000006000000030000000000000000000000F39F06000000000000000000000152000000F0C74F0000060000000300000000000000000000007C9F06000000000000000000000152000000909D4E000006000000030000000000000000000000F39F0600000000000000000000015200000000CC490000060000000300000000000000000000007C9F0600000000000000000000015200000050F24A000006000000030000000000000000000000EE9F06000000000000000000000152000000907B4D000006000000030000000000000000000000F39F0600000000000000000000015200000020024A000006000000030000000000000000000000F39F06000000000000000000000152000000F0F14A0000060000000300000000000000000000007C9F06000000000000000000000152000000B0EF4A00000600000003000000000000000000000035D54D000000000000000000000152000000D0EF4A00000600000003000000000000000000000035D54D000000000000000000000152000000B03E4C000006000000030000000000000000000000F39F06000000000000000000000152000000C0EF4A00000600000003000000000000000000000035D54D000000000000000000000152000000E0EF4A00000600000003000000000000000000000035D54D000000000000000000000152000000F0EF4A00000600000003000000000000000000000035D54D000000000000000000000152000000807B4D000006000000030000000000000000000000F39F0600000000000000000000015200000020D44900000600000003000000000000000000000035D54D00000000000000000000015200000050D44900000600000003000000000000000000000035D54D00000000000000000000015200000000D84B00000600000003000000000000000000000035D54D000000000000000000000152000000803E4C000006000000030000000000000000000000F39F06000000000000000000000152000000501C500000000000006700000000000000000000000C510000FFFFFFFF00000000000152000000005B000000FFFFFFFF65000000BD00000000000000D9EF05005F92010000000000000152000000302100000001000000010000000C000000000000007FB3000065B5000000000000000152000000F03800000001000000010000000C000000000000007FC8010066B5000000000000000152000000105B000000FFFFFFFF65000000BD00000000000000D01100000000000000000000000152000000B05700000006000000030000000000000000000000EF130000FFFFFFFF00000000000152000000D05600000000000000120000000000000000000000A28F0600000000000100000000015200000050274F0000060000000300000000000000000000007C9F06000000000000000000000152000000A0510000000000000012000000000000000000000054410600F98D060001000000000152000000301C500000000000006700000000000000000000004F420000FFFFFFFF00000000000152000000701A00000006000000200000001B00000000000000DC550000FFFFFFFF00000000000152000000B04D00000001000000010000000C00000000000000357306003673060000000000000152000000404E00000001000000B9000000F600000000000000B385060000000000000000000001520000003058000000010000007B000000AB000000000000000319000000000000000000000001520000002058000000010000007B000000AB00000000000000B8A7060000000000000000000001520000006057000000010000007B000000AB00000000000000E11800000000000000000000000152000000C0174D000006000000030000000000000000000000DD9F06000000000000000000000152000000D07600000002000000020000000200000000000000DF8F0600000000000000000000015200000020564E0000060000000300000000000000000000007C9F06000000000000000000000152000000F01B500000000000006700000000000000000000004F420000FFFFFFFF000000000001520000007057000000010000007B000000AB00000000000000639006000000000000000000000152000000B00200000000000000120000000000000000000000672700005A04000001000000000152000000C077000000000000004D010000770100000000000061A806000000000000000000000152000000F05600000006000000030000000000000000000000E31300000000000000000000000152000000C04B0000000000000012000000000000000000000047550600FFFFFFFF01000000000152000000105900000000000000120000000000000000000000095C06000000000001000000000152000000B018000000020000000200000002000000000000006D210100CD94000000000000000152000000904F000000010000007B000000AB00000000000000598C0600000000000000000000015200000070D54D000006000000030000000000000000000000EE9F06000000000000000000000152000000700200000002000000A3000000ED00000000000000742700005A04000000000000000152000000705B00000001000000570100007C01000000000000F0BA060048BC0600000000000001520000002003000000020000000200000002000000000000006F2700005A04000000000000000152000000E021000000060000004E0100001400000000000000A5D705000000000000000000000152000000A02A00000006000000270000000A00000000000000DF9400005A0400000000000000015200000030574B000006000000030000000000000000000000DD9F06000000000000000000000152000000501B4C0000060000000300000000000000000000004AA1060000000000000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A0001000000520000008034500000000000006700000000000000000000000C510000FFFFFFFF000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A000C000000520000002004000000020000000200000002000000000000006D39000092DC4D0000000000000152000000304C00000002000000A3000000ED000000000000007D570600FFFFFFFF00000000000152000000C0A900000006000000500000008A00000000000000C92502005A04000000000000000152000000203B00000006000000500000008A00000000000000C8250200FFFFFFFF00000000000152000000B0A900000006000000410000004500000000000000CA2502005A0400000000000000015200000080A900000006000000500000008A00000000000000A76E01005A04000000000000000152000000C00600000006000000160000000B0000000000000073430000FFFFFFFF00000000000152000000300100000002000000020000000200000000000000B61D00005A04000000000000000152000000906E00000001000000010000000C0000000000000040DB4D006B0B000000000000000152000000205900000000000000120000000000000000000000CC99060000000000010000000001520000003059000000010000007B000000AB00000000000000DD990600DE99060000000000000152000000000400000002000000A3000000ED000000000000006B390000653D0000000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A000100000052000000C0430000000200000002000000020000000000000014F90500FFFFFFFF000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A000300000052000000300100000002000000020000000200000000000000B61D00005A04000000000000000152000000906E00000001000000010000000C0000000000000040DB4D006B0B000000000000000152000000500300000002000000A3000000ED00000000000000BF270000653D0000000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A000800000052000000304C00000002000000A3000000ED000000000000007D570600FFFFFFFF00000000000152000000A04E00000000000000120000000000000000000000C28606000000000001000000000152000000500300000002000000A3000000ED00000000000000BF270000653D000000000000000152000000903300000001000000010000000C00000000000000A334010024000000000000000001520000003059000000010000007B000000AB00000000000000DD990600DE99060000000000000152000000000400000002000000A3000000ED000000000000006B390000653D000000000000000152000000300500000002000000A3000000ED00000000000000353C000092DC4D0000000000000152000000406F00000001000000010000000C00000000000000C1DB4D00DC110000000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A000400000052000000203E00000001000000010000000C00000000000000B6D7050032B8000000000000000152000000100300000002000000A3000000ED000000000000006E2700005A04000000000000000152000000F00300000001000000010000000C000000000000006A390000DF11000000000000000152000000B02200000001000000010000000C0000000000000053B7000024000000000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A0005000000520000006070000000010000007B000000AB0000000000000095DD4D0096DD4D0000000000000152000000100400000001000000010000000C000000000000006C390000DB11000000000000000152000000506F00000001000000010000000C00000000000000C2DB4D00DE11000000000000000152000000004C00000002000000A3000000ED000000000000000C570600FFFFFFFF00000000000152000000200200000000000000120000000000000000000000592700005A040000010000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A000400000052000000100200000002000000A4000000ED0000000000000058270000DAA1060000C01500000152000000906F00000002000000550100007A01000000000000F1DB4D000000000000000000000152000000F02000000001000000010000000C00000000000000F3B10000700B000000000000000152000000803300000001000000010000000C000000000000009E34010093DC4D00000000000001"));
            //LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNotifications */"23000A0001000000520000003070000000010000007B000000AB0000000000000030C1060000000000000000000001"));
            //Don't Touch These
            LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNpc */"2300020052000000000D00005F5100001801000000673C0600F0E2D400010000000000803F4C4AB1C40106D8C108E9AD430000803FCEFE7EBD00000000E1807F3F000000000100000000000000010000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000064000000FFFFFFFFFFFFFFFFFFFFFFFF0000FFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FFFFFFFF000000000100000000000000000200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000800000000000000720D00000000000000000000"));
            LoginManager.SendTunneledClientPacket(soeClient, LoginManager.StringToByteArray(/* PlayerUpdatePacketAddNpc */"2300020052000000D03F0000EDDE0500D401000000673C0600F0E2D400010000000000803FC014B2C4DC96E2C12635AD430000803F2BB3A03E00000000451073BF0000000001000000000000000100000007000000626173655F3032080000006D61686F67616E79000000000100000000000000000000000000000000000000000000000000000000000000000000000000000064000000FFFFFFFFFFFFFFFFFFFFFFFF0000FFFFFFFF00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FFFFFFFF000000000100000000000000000200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000800000000000000720D00000000000000000000"));
        }
    }
}
