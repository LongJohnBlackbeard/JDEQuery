using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0006Z2 - .
/// </summary>
public class F0006Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZACTN.
        /// </summary>
        public const string SZACTN = "SZACTN";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZSTYL.
        /// </summary>
        public const string SZSTYL = "SZSTYL";

        /// <summary>
        /// SZDC.
        /// </summary>
        public const string SZDC = "SZDC";

        /// <summary>
        /// SZLDM.
        /// </summary>
        public const string SZLDM = "SZLDM";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZAN8O.
        /// </summary>
        public const string SZAN8O = "SZAN8O";

        /// <summary>
        /// SZCNTY.
        /// </summary>
        public const string SZCNTY = "SZCNTY";

        /// <summary>
        /// SZADDS.
        /// </summary>
        public const string SZADDS = "SZADDS";

        /// <summary>
        /// SZFMOD.
        /// </summary>
        public const string SZFMOD = "SZFMOD";

        /// <summary>
        /// SZDL01.
        /// </summary>
        public const string SZDL01 = "SZDL01";

        /// <summary>
        /// SZDL02.
        /// </summary>
        public const string SZDL02 = "SZDL02";

        /// <summary>
        /// SZDL03.
        /// </summary>
        public const string SZDL03 = "SZDL03";

        /// <summary>
        /// SZDL04.
        /// </summary>
        public const string SZDL04 = "SZDL04";

        /// <summary>
        /// SZRP01.
        /// </summary>
        public const string SZRP01 = "SZRP01";

        /// <summary>
        /// SZRP02.
        /// </summary>
        public const string SZRP02 = "SZRP02";

        /// <summary>
        /// SZRP03.
        /// </summary>
        public const string SZRP03 = "SZRP03";

        /// <summary>
        /// SZRP04.
        /// </summary>
        public const string SZRP04 = "SZRP04";

        /// <summary>
        /// SZRP05.
        /// </summary>
        public const string SZRP05 = "SZRP05";

        /// <summary>
        /// SZRP06.
        /// </summary>
        public const string SZRP06 = "SZRP06";

        /// <summary>
        /// SZRP07.
        /// </summary>
        public const string SZRP07 = "SZRP07";

        /// <summary>
        /// SZRP08.
        /// </summary>
        public const string SZRP08 = "SZRP08";

        /// <summary>
        /// SZRP09.
        /// </summary>
        public const string SZRP09 = "SZRP09";

        /// <summary>
        /// SZRP10.
        /// </summary>
        public const string SZRP10 = "SZRP10";

        /// <summary>
        /// SZRP11.
        /// </summary>
        public const string SZRP11 = "SZRP11";

        /// <summary>
        /// SZRP12.
        /// </summary>
        public const string SZRP12 = "SZRP12";

        /// <summary>
        /// SZRP13.
        /// </summary>
        public const string SZRP13 = "SZRP13";

        /// <summary>
        /// SZRP14.
        /// </summary>
        public const string SZRP14 = "SZRP14";

        /// <summary>
        /// SZRP15.
        /// </summary>
        public const string SZRP15 = "SZRP15";

        /// <summary>
        /// SZRP16.
        /// </summary>
        public const string SZRP16 = "SZRP16";

        /// <summary>
        /// SZRP17.
        /// </summary>
        public const string SZRP17 = "SZRP17";

        /// <summary>
        /// SZRP18.
        /// </summary>
        public const string SZRP18 = "SZRP18";

        /// <summary>
        /// SZRP19.
        /// </summary>
        public const string SZRP19 = "SZRP19";

        /// <summary>
        /// SZRP20.
        /// </summary>
        public const string SZRP20 = "SZRP20";

        /// <summary>
        /// SZRP21.
        /// </summary>
        public const string SZRP21 = "SZRP21";

        /// <summary>
        /// SZRP22.
        /// </summary>
        public const string SZRP22 = "SZRP22";

        /// <summary>
        /// SZRP23.
        /// </summary>
        public const string SZRP23 = "SZRP23";

        /// <summary>
        /// SZRP24.
        /// </summary>
        public const string SZRP24 = "SZRP24";

        /// <summary>
        /// SZRP25.
        /// </summary>
        public const string SZRP25 = "SZRP25";

        /// <summary>
        /// SZRP26.
        /// </summary>
        public const string SZRP26 = "SZRP26";

        /// <summary>
        /// SZRP27.
        /// </summary>
        public const string SZRP27 = "SZRP27";

        /// <summary>
        /// SZRP28.
        /// </summary>
        public const string SZRP28 = "SZRP28";

        /// <summary>
        /// SZRP29.
        /// </summary>
        public const string SZRP29 = "SZRP29";

        /// <summary>
        /// SZRP30.
        /// </summary>
        public const string SZRP30 = "SZRP30";

        /// <summary>
        /// SZTA.
        /// </summary>
        public const string SZTA = "SZTA";

        /// <summary>
        /// SZTXJS.
        /// </summary>
        public const string SZTXJS = "SZTXJS";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZTC01.
        /// </summary>
        public const string SZTC01 = "SZTC01";

        /// <summary>
        /// SZTC02.
        /// </summary>
        public const string SZTC02 = "SZTC02";

        /// <summary>
        /// SZTC03.
        /// </summary>
        public const string SZTC03 = "SZTC03";

        /// <summary>
        /// SZTC04.
        /// </summary>
        public const string SZTC04 = "SZTC04";

        /// <summary>
        /// SZTC05.
        /// </summary>
        public const string SZTC05 = "SZTC05";

        /// <summary>
        /// SZTC06.
        /// </summary>
        public const string SZTC06 = "SZTC06";

        /// <summary>
        /// SZTC07.
        /// </summary>
        public const string SZTC07 = "SZTC07";

        /// <summary>
        /// SZTC08.
        /// </summary>
        public const string SZTC08 = "SZTC08";

        /// <summary>
        /// SZTC09.
        /// </summary>
        public const string SZTC09 = "SZTC09";

        /// <summary>
        /// SZTC10.
        /// </summary>
        public const string SZTC10 = "SZTC10";

        /// <summary>
        /// SZND01.
        /// </summary>
        public const string SZND01 = "SZND01";

        /// <summary>
        /// SZND02.
        /// </summary>
        public const string SZND02 = "SZND02";

        /// <summary>
        /// SZND03.
        /// </summary>
        public const string SZND03 = "SZND03";

        /// <summary>
        /// SZND04.
        /// </summary>
        public const string SZND04 = "SZND04";

        /// <summary>
        /// SZND05.
        /// </summary>
        public const string SZND05 = "SZND05";

        /// <summary>
        /// SZND06.
        /// </summary>
        public const string SZND06 = "SZND06";

        /// <summary>
        /// SZND07.
        /// </summary>
        public const string SZND07 = "SZND07";

        /// <summary>
        /// SZND08.
        /// </summary>
        public const string SZND08 = "SZND08";

        /// <summary>
        /// SZND09.
        /// </summary>
        public const string SZND09 = "SZND09";

        /// <summary>
        /// SZND10.
        /// </summary>
        public const string SZND10 = "SZND10";

        /// <summary>
        /// SZCC01.
        /// </summary>
        public const string SZCC01 = "SZCC01";

        /// <summary>
        /// SZCC02.
        /// </summary>
        public const string SZCC02 = "SZCC02";

        /// <summary>
        /// SZCC03.
        /// </summary>
        public const string SZCC03 = "SZCC03";

        /// <summary>
        /// SZCC04.
        /// </summary>
        public const string SZCC04 = "SZCC04";

        /// <summary>
        /// SZCC05.
        /// </summary>
        public const string SZCC05 = "SZCC05";

        /// <summary>
        /// SZCC06.
        /// </summary>
        public const string SZCC06 = "SZCC06";

        /// <summary>
        /// SZCC07.
        /// </summary>
        public const string SZCC07 = "SZCC07";

        /// <summary>
        /// SZCC08.
        /// </summary>
        public const string SZCC08 = "SZCC08";

        /// <summary>
        /// SZCC09.
        /// </summary>
        public const string SZCC09 = "SZCC09";

        /// <summary>
        /// SZCC10.
        /// </summary>
        public const string SZCC10 = "SZCC10";

        /// <summary>
        /// SZPECC.
        /// </summary>
        public const string SZPECC = "SZPECC";

        /// <summary>
        /// SZALS.
        /// </summary>
        public const string SZALS = "SZALS";

        /// <summary>
        /// SZISS.
        /// </summary>
        public const string SZISS = "SZISS";

        /// <summary>
        /// SZGLBA.
        /// </summary>
        public const string SZGLBA = "SZGLBA";

        /// <summary>
        /// SZALCL.
        /// </summary>
        public const string SZALCL = "SZALCL";

        /// <summary>
        /// SZLMTH.
        /// </summary>
        public const string SZLMTH = "SZLMTH";

        /// <summary>
        /// SZLF.
        /// </summary>
        public const string SZLF = "SZLF";

        /// <summary>
        /// SZOBJ1.
        /// </summary>
        public const string SZOBJ1 = "SZOBJ1";

        /// <summary>
        /// SZOBJ2.
        /// </summary>
        public const string SZOBJ2 = "SZOBJ2";

        /// <summary>
        /// SZOBJ3.
        /// </summary>
        public const string SZOBJ3 = "SZOBJ3";

        /// <summary>
        /// SZSUB1.
        /// </summary>
        public const string SZSUB1 = "SZSUB1";

        /// <summary>
        /// SZTOU.
        /// </summary>
        public const string SZTOU = "SZTOU";

        /// <summary>
        /// SZSBLI.
        /// </summary>
        public const string SZSBLI = "SZSBLI";

        /// <summary>
        /// SZANPA.
        /// </summary>
        public const string SZANPA = "SZANPA";

        /// <summary>
        /// SZCT.
        /// </summary>
        public const string SZCT = "SZCT";

        /// <summary>
        /// SZCERT.
        /// </summary>
        public const string SZCERT = "SZCERT";

        /// <summary>
        /// SZMCUS.
        /// </summary>
        public const string SZMCUS = "SZMCUS";

        /// <summary>
        /// SZBTYP.
        /// </summary>
        public const string SZBTYP = "SZBTYP";

        /// <summary>
        /// SZPC.
        /// </summary>
        public const string SZPC = "SZPC";

        /// <summary>
        /// SZPCA.
        /// </summary>
        public const string SZPCA = "SZPCA";

        /// <summary>
        /// SZPCC.
        /// </summary>
        public const string SZPCC = "SZPCC";

        /// <summary>
        /// SZINTA.
        /// </summary>
        public const string SZINTA = "SZINTA";

        /// <summary>
        /// SZINTL.
        /// </summary>
        public const string SZINTL = "SZINTL";

        /// <summary>
        /// SZD1J.
        /// </summary>
        public const string SZD1J = "SZD1J";

        /// <summary>
        /// SZD2J.
        /// </summary>
        public const string SZD2J = "SZD2J";

        /// <summary>
        /// SZD3J.
        /// </summary>
        public const string SZD3J = "SZD3J";

        /// <summary>
        /// SZD4J.
        /// </summary>
        public const string SZD4J = "SZD4J";

        /// <summary>
        /// SZD5J.
        /// </summary>
        public const string SZD5J = "SZD5J";

        /// <summary>
        /// SZD6J.
        /// </summary>
        public const string SZD6J = "SZD6J";

        /// <summary>
        /// SZFPDJ.
        /// </summary>
        public const string SZFPDJ = "SZFPDJ";

        /// <summary>
        /// SZCAC.
        /// </summary>
        public const string SZCAC = "SZCAC";

        /// <summary>
        /// SZPAC.
        /// </summary>
        public const string SZPAC = "SZPAC";

        /// <summary>
        /// SZEEO.
        /// </summary>
        public const string SZEEO = "SZEEO";

        /// <summary>
        /// SZERC.
        /// </summary>
        public const string SZERC = "SZERC";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZBPTP.
        /// </summary>
        public const string SZBPTP = "SZBPTP";

        /// <summary>
        /// SZAPSB.
        /// </summary>
        public const string SZAPSB = "SZAPSB";

        /// <summary>
        /// SZTSBU.
        /// </summary>
        public const string SZTSBU = "SZTSBU";

        /// <summary>
        /// SZRP31.
        /// </summary>
        public const string SZRP31 = "SZRP31";

        /// <summary>
        /// SZRP32.
        /// </summary>
        public const string SZRP32 = "SZRP32";

        /// <summary>
        /// SZRP33.
        /// </summary>
        public const string SZRP33 = "SZRP33";

        /// <summary>
        /// SZRP34.
        /// </summary>
        public const string SZRP34 = "SZRP34";

        /// <summary>
        /// SZRP35.
        /// </summary>
        public const string SZRP35 = "SZRP35";

        /// <summary>
        /// SZRP36.
        /// </summary>
        public const string SZRP36 = "SZRP36";

        /// <summary>
        /// SZRP37.
        /// </summary>
        public const string SZRP37 = "SZRP37";

        /// <summary>
        /// SZRP38.
        /// </summary>
        public const string SZRP38 = "SZRP38";

        /// <summary>
        /// SZRP39.
        /// </summary>
        public const string SZRP39 = "SZRP39";

        /// <summary>
        /// SZRP40.
        /// </summary>
        public const string SZRP40 = "SZRP40";

        /// <summary>
        /// SZRP41.
        /// </summary>
        public const string SZRP41 = "SZRP41";

        /// <summary>
        /// SZRP42.
        /// </summary>
        public const string SZRP42 = "SZRP42";

        /// <summary>
        /// SZRP43.
        /// </summary>
        public const string SZRP43 = "SZRP43";

        /// <summary>
        /// SZRP44.
        /// </summary>
        public const string SZRP44 = "SZRP44";

        /// <summary>
        /// SZRP45.
        /// </summary>
        public const string SZRP45 = "SZRP45";

        /// <summary>
        /// SZRP46.
        /// </summary>
        public const string SZRP46 = "SZRP46";

        /// <summary>
        /// SZRP47.
        /// </summary>
        public const string SZRP47 = "SZRP47";

        /// <summary>
        /// SZRP48.
        /// </summary>
        public const string SZRP48 = "SZRP48";

        /// <summary>
        /// SZRP49.
        /// </summary>
        public const string SZRP49 = "SZRP49";

        /// <summary>
        /// SZRP50.
        /// </summary>
        public const string SZRP50 = "SZRP50";

        /// <summary>
        /// SZAN8GCA1.
        /// </summary>
        public const string SZAN8GCA1 = "SZAN8GCA1";

        /// <summary>
        /// SZAN8GCA2.
        /// </summary>
        public const string SZAN8GCA2 = "SZAN8GCA2";

        /// <summary>
        /// SZAN8GCA3.
        /// </summary>
        public const string SZAN8GCA3 = "SZAN8GCA3";

        /// <summary>
        /// SZAN8GCA4.
        /// </summary>
        public const string SZAN8GCA4 = "SZAN8GCA4";

        /// <summary>
        /// SZAN8GCA5.
        /// </summary>
        public const string SZAN8GCA5 = "SZAN8GCA5";

        /// <summary>
        /// SZRMCU1.
        /// </summary>
        public const string SZRMCU1 = "SZRMCU1";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZPCTN.
        /// </summary>
        public const string SZPCTN = "SZPCTN";

        /// <summary>
        /// SZCLNU.
        /// </summary>
        public const string SZCLNU = "SZCLNU";

        /// <summary>
        /// SZBUCA.
        /// </summary>
        public const string SZBUCA = "SZBUCA";

        /// <summary>
        /// SZADJENT.
        /// </summary>
        public const string SZADJENT = "SZADJENT";

        /// <summary>
        /// SZUAFL.
        /// </summary>
        public const string SZUAFL = "SZUAFL";
    }

    /// <inheritdoc />
    public override string TableName => "F0006Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZACTN", "SZACTN", JdeDataType.String, 2),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZSTYL", "SZSTYL", JdeDataType.String, 4),
        new JdeField("SZDC", "SZDC", JdeDataType.String, 80),
        new JdeField("SZLDM", "SZLDM", JdeDataType.String, 2),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZAN8O", "SZAN8O", JdeDataType.Numeric),
        new JdeField("SZCNTY", "SZCNTY", JdeDataType.String, 6),
        new JdeField("SZADDS", "SZADDS", JdeDataType.String, 6),
        new JdeField("SZFMOD", "SZFMOD", JdeDataType.String, 2),
        new JdeField("SZDL01", "SZDL01", JdeDataType.String, 60),
        new JdeField("SZDL02", "SZDL02", JdeDataType.String, 60),
        new JdeField("SZDL03", "SZDL03", JdeDataType.String, 60),
        new JdeField("SZDL04", "SZDL04", JdeDataType.String, 60),
        new JdeField("SZRP01", "SZRP01", JdeDataType.String, 6),
        new JdeField("SZRP02", "SZRP02", JdeDataType.String, 6),
        new JdeField("SZRP03", "SZRP03", JdeDataType.String, 6),
        new JdeField("SZRP04", "SZRP04", JdeDataType.String, 6),
        new JdeField("SZRP05", "SZRP05", JdeDataType.String, 6),
        new JdeField("SZRP06", "SZRP06", JdeDataType.String, 6),
        new JdeField("SZRP07", "SZRP07", JdeDataType.String, 6),
        new JdeField("SZRP08", "SZRP08", JdeDataType.String, 6),
        new JdeField("SZRP09", "SZRP09", JdeDataType.String, 6),
        new JdeField("SZRP10", "SZRP10", JdeDataType.String, 6),
        new JdeField("SZRP11", "SZRP11", JdeDataType.String, 6),
        new JdeField("SZRP12", "SZRP12", JdeDataType.String, 6),
        new JdeField("SZRP13", "SZRP13", JdeDataType.String, 6),
        new JdeField("SZRP14", "SZRP14", JdeDataType.String, 6),
        new JdeField("SZRP15", "SZRP15", JdeDataType.String, 6),
        new JdeField("SZRP16", "SZRP16", JdeDataType.String, 6),
        new JdeField("SZRP17", "SZRP17", JdeDataType.String, 6),
        new JdeField("SZRP18", "SZRP18", JdeDataType.String, 6),
        new JdeField("SZRP19", "SZRP19", JdeDataType.String, 6),
        new JdeField("SZRP20", "SZRP20", JdeDataType.String, 6),
        new JdeField("SZRP21", "SZRP21", JdeDataType.String, 20),
        new JdeField("SZRP22", "SZRP22", JdeDataType.String, 20),
        new JdeField("SZRP23", "SZRP23", JdeDataType.String, 20),
        new JdeField("SZRP24", "SZRP24", JdeDataType.String, 20),
        new JdeField("SZRP25", "SZRP25", JdeDataType.String, 20),
        new JdeField("SZRP26", "SZRP26", JdeDataType.String, 20),
        new JdeField("SZRP27", "SZRP27", JdeDataType.String, 20),
        new JdeField("SZRP28", "SZRP28", JdeDataType.String, 20),
        new JdeField("SZRP29", "SZRP29", JdeDataType.String, 20),
        new JdeField("SZRP30", "SZRP30", JdeDataType.String, 20),
        new JdeField("SZTA", "SZTA", JdeDataType.String, 20),
        new JdeField("SZTXJS", "SZTXJS", JdeDataType.Numeric),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTC01", "SZTC01", JdeDataType.String, 8),
        new JdeField("SZTC02", "SZTC02", JdeDataType.String, 8),
        new JdeField("SZTC03", "SZTC03", JdeDataType.String, 8),
        new JdeField("SZTC04", "SZTC04", JdeDataType.String, 8),
        new JdeField("SZTC05", "SZTC05", JdeDataType.String, 8),
        new JdeField("SZTC06", "SZTC06", JdeDataType.String, 8),
        new JdeField("SZTC07", "SZTC07", JdeDataType.String, 8),
        new JdeField("SZTC08", "SZTC08", JdeDataType.String, 8),
        new JdeField("SZTC09", "SZTC09", JdeDataType.String, 8),
        new JdeField("SZTC10", "SZTC10", JdeDataType.String, 8),
        new JdeField("SZND01", "SZND01", JdeDataType.String, 2),
        new JdeField("SZND02", "SZND02", JdeDataType.String, 2),
        new JdeField("SZND03", "SZND03", JdeDataType.String, 2),
        new JdeField("SZND04", "SZND04", JdeDataType.String, 2),
        new JdeField("SZND05", "SZND05", JdeDataType.String, 2),
        new JdeField("SZND06", "SZND06", JdeDataType.String, 2),
        new JdeField("SZND07", "SZND07", JdeDataType.String, 2),
        new JdeField("SZND08", "SZND08", JdeDataType.String, 2),
        new JdeField("SZND09", "SZND09", JdeDataType.String, 2),
        new JdeField("SZND10", "SZND10", JdeDataType.String, 2),
        new JdeField("SZCC01", "SZCC01", JdeDataType.String, 2),
        new JdeField("SZCC02", "SZCC02", JdeDataType.String, 2),
        new JdeField("SZCC03", "SZCC03", JdeDataType.String, 2),
        new JdeField("SZCC04", "SZCC04", JdeDataType.String, 2),
        new JdeField("SZCC05", "SZCC05", JdeDataType.String, 2),
        new JdeField("SZCC06", "SZCC06", JdeDataType.String, 2),
        new JdeField("SZCC07", "SZCC07", JdeDataType.String, 2),
        new JdeField("SZCC08", "SZCC08", JdeDataType.String, 2),
        new JdeField("SZCC09", "SZCC09", JdeDataType.String, 2),
        new JdeField("SZCC10", "SZCC10", JdeDataType.String, 2),
        new JdeField("SZPECC", "SZPECC", JdeDataType.String, 2),
        new JdeField("SZALS", "SZALS", JdeDataType.String, 2),
        new JdeField("SZISS", "SZISS", JdeDataType.String, 2),
        new JdeField("SZGLBA", "SZGLBA", JdeDataType.String, 16),
        new JdeField("SZALCL", "SZALCL", JdeDataType.String, 4),
        new JdeField("SZLMTH", "SZLMTH", JdeDataType.String, 2),
        new JdeField("SZLF", "SZLF", JdeDataType.Numeric),
        new JdeField("SZOBJ1", "SZOBJ1", JdeDataType.String, 12),
        new JdeField("SZOBJ2", "SZOBJ2", JdeDataType.String, 12),
        new JdeField("SZOBJ3", "SZOBJ3", JdeDataType.String, 12),
        new JdeField("SZSUB1", "SZSUB1", JdeDataType.String, 16),
        new JdeField("SZTOU", "SZTOU", JdeDataType.Numeric),
        new JdeField("SZSBLI", "SZSBLI", JdeDataType.String, 2),
        new JdeField("SZANPA", "SZANPA", JdeDataType.Numeric),
        new JdeField("SZCT", "SZCT", JdeDataType.String, 8),
        new JdeField("SZCERT", "SZCERT", JdeDataType.String, 2),
        new JdeField("SZMCUS", "SZMCUS", JdeDataType.String, 24),
        new JdeField("SZBTYP", "SZBTYP", JdeDataType.String, 2),
        new JdeField("SZPC", "SZPC", JdeDataType.Numeric),
        new JdeField("SZPCA", "SZPCA", JdeDataType.Numeric),
        new JdeField("SZPCC", "SZPCC", JdeDataType.Numeric),
        new JdeField("SZINTA", "SZINTA", JdeDataType.String, 8),
        new JdeField("SZINTL", "SZINTL", JdeDataType.String, 8),
        new JdeField("SZD1J", "SZD1J", JdeDataType.Numeric),
        new JdeField("SZD2J", "SZD2J", JdeDataType.Numeric),
        new JdeField("SZD3J", "SZD3J", JdeDataType.Numeric),
        new JdeField("SZD4J", "SZD4J", JdeDataType.Numeric),
        new JdeField("SZD5J", "SZD5J", JdeDataType.Numeric),
        new JdeField("SZD6J", "SZD6J", JdeDataType.Numeric),
        new JdeField("SZFPDJ", "SZFPDJ", JdeDataType.Numeric),
        new JdeField("SZCAC", "SZCAC", JdeDataType.Numeric),
        new JdeField("SZPAC", "SZPAC", JdeDataType.Numeric),
        new JdeField("SZEEO", "SZEEO", JdeDataType.String, 2),
        new JdeField("SZERC", "SZERC", JdeDataType.String, 4),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZBPTP", "SZBPTP", JdeDataType.String, 30),
        new JdeField("SZAPSB", "SZAPSB", JdeDataType.String, 2),
        new JdeField("SZTSBU", "SZTSBU", JdeDataType.String, 24),
        new JdeField("SZRP31", "SZRP31", JdeDataType.String, 20),
        new JdeField("SZRP32", "SZRP32", JdeDataType.String, 20),
        new JdeField("SZRP33", "SZRP33", JdeDataType.String, 20),
        new JdeField("SZRP34", "SZRP34", JdeDataType.String, 20),
        new JdeField("SZRP35", "SZRP35", JdeDataType.String, 20),
        new JdeField("SZRP36", "SZRP36", JdeDataType.String, 20),
        new JdeField("SZRP37", "SZRP37", JdeDataType.String, 20),
        new JdeField("SZRP38", "SZRP38", JdeDataType.String, 20),
        new JdeField("SZRP39", "SZRP39", JdeDataType.String, 20),
        new JdeField("SZRP40", "SZRP40", JdeDataType.String, 20),
        new JdeField("SZRP41", "SZRP41", JdeDataType.String, 20),
        new JdeField("SZRP42", "SZRP42", JdeDataType.String, 20),
        new JdeField("SZRP43", "SZRP43", JdeDataType.String, 20),
        new JdeField("SZRP44", "SZRP44", JdeDataType.String, 20),
        new JdeField("SZRP45", "SZRP45", JdeDataType.String, 20),
        new JdeField("SZRP46", "SZRP46", JdeDataType.String, 20),
        new JdeField("SZRP47", "SZRP47", JdeDataType.String, 20),
        new JdeField("SZRP48", "SZRP48", JdeDataType.String, 20),
        new JdeField("SZRP49", "SZRP49", JdeDataType.String, 20),
        new JdeField("SZRP50", "SZRP50", JdeDataType.String, 20),
        new JdeField("SZAN8GCA1", "SZAN8GCA1", JdeDataType.Numeric),
        new JdeField("SZAN8GCA2", "SZAN8GCA2", JdeDataType.Numeric),
        new JdeField("SZAN8GCA3", "SZAN8GCA3", JdeDataType.Numeric),
        new JdeField("SZAN8GCA4", "SZAN8GCA4", JdeDataType.Numeric),
        new JdeField("SZAN8GCA5", "SZAN8GCA5", JdeDataType.Numeric),
        new JdeField("SZRMCU1", "SZRMCU1", JdeDataType.String, 24),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZPCTN", "SZPCTN", JdeDataType.Numeric),
        new JdeField("SZCLNU", "SZCLNU", JdeDataType.Numeric),
        new JdeField("SZBUCA", "SZBUCA", JdeDataType.String, 10),
        new JdeField("SZADJENT", "SZADJENT", JdeDataType.String, 2),
        new JdeField("SZUAFL", "SZUAFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0006Z2_0", "Primary Key on SZEDBT, SZEDLN, SZEDTN, SZEDUS", new[] { "SZEDBT", "SZEDLN", "SZEDTN", "SZEDUS" }, isUnique: true, isPrimaryKey: true)
    };
}
