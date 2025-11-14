using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0006 - .
/// </summary>
public class F0006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MCMCU.
        /// </summary>
        public const string MCMCU = "MCMCU";

        /// <summary>
        /// MCSTYL.
        /// </summary>
        public const string MCSTYL = "MCSTYL";

        /// <summary>
        /// MCDC.
        /// </summary>
        public const string MCDC = "MCDC";

        /// <summary>
        /// MCLDM.
        /// </summary>
        public const string MCLDM = "MCLDM";

        /// <summary>
        /// MCCO.
        /// </summary>
        public const string MCCO = "MCCO";

        /// <summary>
        /// MCAN8.
        /// </summary>
        public const string MCAN8 = "MCAN8";

        /// <summary>
        /// MCAN8O.
        /// </summary>
        public const string MCAN8O = "MCAN8O";

        /// <summary>
        /// MCCNTY.
        /// </summary>
        public const string MCCNTY = "MCCNTY";

        /// <summary>
        /// MCADDS.
        /// </summary>
        public const string MCADDS = "MCADDS";

        /// <summary>
        /// MCFMOD.
        /// </summary>
        public const string MCFMOD = "MCFMOD";

        /// <summary>
        /// MCDL01.
        /// </summary>
        public const string MCDL01 = "MCDL01";

        /// <summary>
        /// MCDL02.
        /// </summary>
        public const string MCDL02 = "MCDL02";

        /// <summary>
        /// MCDL03.
        /// </summary>
        public const string MCDL03 = "MCDL03";

        /// <summary>
        /// MCDL04.
        /// </summary>
        public const string MCDL04 = "MCDL04";

        /// <summary>
        /// MCRP01.
        /// </summary>
        public const string MCRP01 = "MCRP01";

        /// <summary>
        /// MCRP02.
        /// </summary>
        public const string MCRP02 = "MCRP02";

        /// <summary>
        /// MCRP03.
        /// </summary>
        public const string MCRP03 = "MCRP03";

        /// <summary>
        /// MCRP04.
        /// </summary>
        public const string MCRP04 = "MCRP04";

        /// <summary>
        /// MCRP05.
        /// </summary>
        public const string MCRP05 = "MCRP05";

        /// <summary>
        /// MCRP06.
        /// </summary>
        public const string MCRP06 = "MCRP06";

        /// <summary>
        /// MCRP07.
        /// </summary>
        public const string MCRP07 = "MCRP07";

        /// <summary>
        /// MCRP08.
        /// </summary>
        public const string MCRP08 = "MCRP08";

        /// <summary>
        /// MCRP09.
        /// </summary>
        public const string MCRP09 = "MCRP09";

        /// <summary>
        /// MCRP10.
        /// </summary>
        public const string MCRP10 = "MCRP10";

        /// <summary>
        /// MCRP11.
        /// </summary>
        public const string MCRP11 = "MCRP11";

        /// <summary>
        /// MCRP12.
        /// </summary>
        public const string MCRP12 = "MCRP12";

        /// <summary>
        /// MCRP13.
        /// </summary>
        public const string MCRP13 = "MCRP13";

        /// <summary>
        /// MCRP14.
        /// </summary>
        public const string MCRP14 = "MCRP14";

        /// <summary>
        /// MCRP15.
        /// </summary>
        public const string MCRP15 = "MCRP15";

        /// <summary>
        /// MCRP16.
        /// </summary>
        public const string MCRP16 = "MCRP16";

        /// <summary>
        /// MCRP17.
        /// </summary>
        public const string MCRP17 = "MCRP17";

        /// <summary>
        /// MCRP18.
        /// </summary>
        public const string MCRP18 = "MCRP18";

        /// <summary>
        /// MCRP19.
        /// </summary>
        public const string MCRP19 = "MCRP19";

        /// <summary>
        /// MCRP20.
        /// </summary>
        public const string MCRP20 = "MCRP20";

        /// <summary>
        /// MCRP21.
        /// </summary>
        public const string MCRP21 = "MCRP21";

        /// <summary>
        /// MCRP22.
        /// </summary>
        public const string MCRP22 = "MCRP22";

        /// <summary>
        /// MCRP23.
        /// </summary>
        public const string MCRP23 = "MCRP23";

        /// <summary>
        /// MCRP24.
        /// </summary>
        public const string MCRP24 = "MCRP24";

        /// <summary>
        /// MCRP25.
        /// </summary>
        public const string MCRP25 = "MCRP25";

        /// <summary>
        /// MCRP26.
        /// </summary>
        public const string MCRP26 = "MCRP26";

        /// <summary>
        /// MCRP27.
        /// </summary>
        public const string MCRP27 = "MCRP27";

        /// <summary>
        /// MCRP28.
        /// </summary>
        public const string MCRP28 = "MCRP28";

        /// <summary>
        /// MCRP29.
        /// </summary>
        public const string MCRP29 = "MCRP29";

        /// <summary>
        /// MCRP30.
        /// </summary>
        public const string MCRP30 = "MCRP30";

        /// <summary>
        /// MCTA.
        /// </summary>
        public const string MCTA = "MCTA";

        /// <summary>
        /// MCTXJS.
        /// </summary>
        public const string MCTXJS = "MCTXJS";

        /// <summary>
        /// MCTXA1.
        /// </summary>
        public const string MCTXA1 = "MCTXA1";

        /// <summary>
        /// MCEXR1.
        /// </summary>
        public const string MCEXR1 = "MCEXR1";

        /// <summary>
        /// MCTC01.
        /// </summary>
        public const string MCTC01 = "MCTC01";

        /// <summary>
        /// MCTC02.
        /// </summary>
        public const string MCTC02 = "MCTC02";

        /// <summary>
        /// MCTC03.
        /// </summary>
        public const string MCTC03 = "MCTC03";

        /// <summary>
        /// MCTC04.
        /// </summary>
        public const string MCTC04 = "MCTC04";

        /// <summary>
        /// MCTC05.
        /// </summary>
        public const string MCTC05 = "MCTC05";

        /// <summary>
        /// MCTC06.
        /// </summary>
        public const string MCTC06 = "MCTC06";

        /// <summary>
        /// MCTC07.
        /// </summary>
        public const string MCTC07 = "MCTC07";

        /// <summary>
        /// MCTC08.
        /// </summary>
        public const string MCTC08 = "MCTC08";

        /// <summary>
        /// MCTC09.
        /// </summary>
        public const string MCTC09 = "MCTC09";

        /// <summary>
        /// MCTC10.
        /// </summary>
        public const string MCTC10 = "MCTC10";

        /// <summary>
        /// MCND01.
        /// </summary>
        public const string MCND01 = "MCND01";

        /// <summary>
        /// MCND02.
        /// </summary>
        public const string MCND02 = "MCND02";

        /// <summary>
        /// MCND03.
        /// </summary>
        public const string MCND03 = "MCND03";

        /// <summary>
        /// MCND04.
        /// </summary>
        public const string MCND04 = "MCND04";

        /// <summary>
        /// MCND05.
        /// </summary>
        public const string MCND05 = "MCND05";

        /// <summary>
        /// MCND06.
        /// </summary>
        public const string MCND06 = "MCND06";

        /// <summary>
        /// MCND07.
        /// </summary>
        public const string MCND07 = "MCND07";

        /// <summary>
        /// MCND08.
        /// </summary>
        public const string MCND08 = "MCND08";

        /// <summary>
        /// MCND09.
        /// </summary>
        public const string MCND09 = "MCND09";

        /// <summary>
        /// MCND10.
        /// </summary>
        public const string MCND10 = "MCND10";

        /// <summary>
        /// MCCC01.
        /// </summary>
        public const string MCCC01 = "MCCC01";

        /// <summary>
        /// MCCC02.
        /// </summary>
        public const string MCCC02 = "MCCC02";

        /// <summary>
        /// MCCC03.
        /// </summary>
        public const string MCCC03 = "MCCC03";

        /// <summary>
        /// MCCC04.
        /// </summary>
        public const string MCCC04 = "MCCC04";

        /// <summary>
        /// MCCC05.
        /// </summary>
        public const string MCCC05 = "MCCC05";

        /// <summary>
        /// MCCC06.
        /// </summary>
        public const string MCCC06 = "MCCC06";

        /// <summary>
        /// MCCC07.
        /// </summary>
        public const string MCCC07 = "MCCC07";

        /// <summary>
        /// MCCC08.
        /// </summary>
        public const string MCCC08 = "MCCC08";

        /// <summary>
        /// MCCC09.
        /// </summary>
        public const string MCCC09 = "MCCC09";

        /// <summary>
        /// MCCC10.
        /// </summary>
        public const string MCCC10 = "MCCC10";

        /// <summary>
        /// MCPECC.
        /// </summary>
        public const string MCPECC = "MCPECC";

        /// <summary>
        /// MCALS.
        /// </summary>
        public const string MCALS = "MCALS";

        /// <summary>
        /// MCISS.
        /// </summary>
        public const string MCISS = "MCISS";

        /// <summary>
        /// MCGLBA.
        /// </summary>
        public const string MCGLBA = "MCGLBA";

        /// <summary>
        /// MCALCL.
        /// </summary>
        public const string MCALCL = "MCALCL";

        /// <summary>
        /// MCLMTH.
        /// </summary>
        public const string MCLMTH = "MCLMTH";

        /// <summary>
        /// MCLF.
        /// </summary>
        public const string MCLF = "MCLF";

        /// <summary>
        /// MCOBJ1.
        /// </summary>
        public const string MCOBJ1 = "MCOBJ1";

        /// <summary>
        /// MCOBJ2.
        /// </summary>
        public const string MCOBJ2 = "MCOBJ2";

        /// <summary>
        /// MCOBJ3.
        /// </summary>
        public const string MCOBJ3 = "MCOBJ3";

        /// <summary>
        /// MCSUB1.
        /// </summary>
        public const string MCSUB1 = "MCSUB1";

        /// <summary>
        /// MCTOU.
        /// </summary>
        public const string MCTOU = "MCTOU";

        /// <summary>
        /// MCSBLI.
        /// </summary>
        public const string MCSBLI = "MCSBLI";

        /// <summary>
        /// MCANPA.
        /// </summary>
        public const string MCANPA = "MCANPA";

        /// <summary>
        /// MCCT.
        /// </summary>
        public const string MCCT = "MCCT";

        /// <summary>
        /// MCCERT.
        /// </summary>
        public const string MCCERT = "MCCERT";

        /// <summary>
        /// MCMCUS.
        /// </summary>
        public const string MCMCUS = "MCMCUS";

        /// <summary>
        /// MCBTYP.
        /// </summary>
        public const string MCBTYP = "MCBTYP";

        /// <summary>
        /// MCPC.
        /// </summary>
        public const string MCPC = "MCPC";

        /// <summary>
        /// MCPCA.
        /// </summary>
        public const string MCPCA = "MCPCA";

        /// <summary>
        /// MCPCC.
        /// </summary>
        public const string MCPCC = "MCPCC";

        /// <summary>
        /// MCINTA.
        /// </summary>
        public const string MCINTA = "MCINTA";

        /// <summary>
        /// MCINTL.
        /// </summary>
        public const string MCINTL = "MCINTL";

        /// <summary>
        /// MCD1J.
        /// </summary>
        public const string MCD1J = "MCD1J";

        /// <summary>
        /// MCD2J.
        /// </summary>
        public const string MCD2J = "MCD2J";

        /// <summary>
        /// MCD3J.
        /// </summary>
        public const string MCD3J = "MCD3J";

        /// <summary>
        /// MCD4J.
        /// </summary>
        public const string MCD4J = "MCD4J";

        /// <summary>
        /// MCD5J.
        /// </summary>
        public const string MCD5J = "MCD5J";

        /// <summary>
        /// MCD6J.
        /// </summary>
        public const string MCD6J = "MCD6J";

        /// <summary>
        /// MCFPDJ.
        /// </summary>
        public const string MCFPDJ = "MCFPDJ";

        /// <summary>
        /// MCCAC.
        /// </summary>
        public const string MCCAC = "MCCAC";

        /// <summary>
        /// MCPAC.
        /// </summary>
        public const string MCPAC = "MCPAC";

        /// <summary>
        /// MCEEO.
        /// </summary>
        public const string MCEEO = "MCEEO";

        /// <summary>
        /// MCERC.
        /// </summary>
        public const string MCERC = "MCERC";

        /// <summary>
        /// MCUSER.
        /// </summary>
        public const string MCUSER = "MCUSER";

        /// <summary>
        /// MCPID.
        /// </summary>
        public const string MCPID = "MCPID";

        /// <summary>
        /// MCUPMJ.
        /// </summary>
        public const string MCUPMJ = "MCUPMJ";

        /// <summary>
        /// MCJOBN.
        /// </summary>
        public const string MCJOBN = "MCJOBN";

        /// <summary>
        /// MCUPMT.
        /// </summary>
        public const string MCUPMT = "MCUPMT";

        /// <summary>
        /// MCBPTP.
        /// </summary>
        public const string MCBPTP = "MCBPTP";

        /// <summary>
        /// MCAPSB.
        /// </summary>
        public const string MCAPSB = "MCAPSB";

        /// <summary>
        /// MCTSBU.
        /// </summary>
        public const string MCTSBU = "MCTSBU";

        /// <summary>
        /// MCRP31.
        /// </summary>
        public const string MCRP31 = "MCRP31";

        /// <summary>
        /// MCRP32.
        /// </summary>
        public const string MCRP32 = "MCRP32";

        /// <summary>
        /// MCRP33.
        /// </summary>
        public const string MCRP33 = "MCRP33";

        /// <summary>
        /// MCRP34.
        /// </summary>
        public const string MCRP34 = "MCRP34";

        /// <summary>
        /// MCRP35.
        /// </summary>
        public const string MCRP35 = "MCRP35";

        /// <summary>
        /// MCRP36.
        /// </summary>
        public const string MCRP36 = "MCRP36";

        /// <summary>
        /// MCRP37.
        /// </summary>
        public const string MCRP37 = "MCRP37";

        /// <summary>
        /// MCRP38.
        /// </summary>
        public const string MCRP38 = "MCRP38";

        /// <summary>
        /// MCRP39.
        /// </summary>
        public const string MCRP39 = "MCRP39";

        /// <summary>
        /// MCRP40.
        /// </summary>
        public const string MCRP40 = "MCRP40";

        /// <summary>
        /// MCRP41.
        /// </summary>
        public const string MCRP41 = "MCRP41";

        /// <summary>
        /// MCRP42.
        /// </summary>
        public const string MCRP42 = "MCRP42";

        /// <summary>
        /// MCRP43.
        /// </summary>
        public const string MCRP43 = "MCRP43";

        /// <summary>
        /// MCRP44.
        /// </summary>
        public const string MCRP44 = "MCRP44";

        /// <summary>
        /// MCRP45.
        /// </summary>
        public const string MCRP45 = "MCRP45";

        /// <summary>
        /// MCRP46.
        /// </summary>
        public const string MCRP46 = "MCRP46";

        /// <summary>
        /// MCRP47.
        /// </summary>
        public const string MCRP47 = "MCRP47";

        /// <summary>
        /// MCRP48.
        /// </summary>
        public const string MCRP48 = "MCRP48";

        /// <summary>
        /// MCRP49.
        /// </summary>
        public const string MCRP49 = "MCRP49";

        /// <summary>
        /// MCRP50.
        /// </summary>
        public const string MCRP50 = "MCRP50";

        /// <summary>
        /// MCAN8GCA1.
        /// </summary>
        public const string MCAN8GCA1 = "MCAN8GCA1";

        /// <summary>
        /// MCAN8GCA2.
        /// </summary>
        public const string MCAN8GCA2 = "MCAN8GCA2";

        /// <summary>
        /// MCAN8GCA3.
        /// </summary>
        public const string MCAN8GCA3 = "MCAN8GCA3";

        /// <summary>
        /// MCAN8GCA4.
        /// </summary>
        public const string MCAN8GCA4 = "MCAN8GCA4";

        /// <summary>
        /// MCAN8GCA5.
        /// </summary>
        public const string MCAN8GCA5 = "MCAN8GCA5";

        /// <summary>
        /// MCRMCU1.
        /// </summary>
        public const string MCRMCU1 = "MCRMCU1";

        /// <summary>
        /// MCDOCO.
        /// </summary>
        public const string MCDOCO = "MCDOCO";

        /// <summary>
        /// MCPCTN.
        /// </summary>
        public const string MCPCTN = "MCPCTN";

        /// <summary>
        /// MCCLNU.
        /// </summary>
        public const string MCCLNU = "MCCLNU";

        /// <summary>
        /// MCBUCA.
        /// </summary>
        public const string MCBUCA = "MCBUCA";

        /// <summary>
        /// MCADJENT.
        /// </summary>
        public const string MCADJENT = "MCADJENT";

        /// <summary>
        /// MCUAFL.
        /// </summary>
        public const string MCUAFL = "MCUAFL";
    }

    /// <inheritdoc />
    public override string TableName => "F0006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MCMCU", "MCMCU", JdeDataType.String, 24, true, true),
        new JdeField("MCSTYL", "MCSTYL", JdeDataType.String, 4),
        new JdeField("MCDC", "MCDC", JdeDataType.String, 80),
        new JdeField("MCLDM", "MCLDM", JdeDataType.String, 2),
        new JdeField("MCCO", "MCCO", JdeDataType.String, 10),
        new JdeField("MCAN8", "MCAN8", JdeDataType.Numeric),
        new JdeField("MCAN8O", "MCAN8O", JdeDataType.Numeric),
        new JdeField("MCCNTY", "MCCNTY", JdeDataType.String, 6),
        new JdeField("MCADDS", "MCADDS", JdeDataType.String, 6),
        new JdeField("MCFMOD", "MCFMOD", JdeDataType.String, 2),
        new JdeField("MCDL01", "MCDL01", JdeDataType.String, 60),
        new JdeField("MCDL02", "MCDL02", JdeDataType.String, 60),
        new JdeField("MCDL03", "MCDL03", JdeDataType.String, 60),
        new JdeField("MCDL04", "MCDL04", JdeDataType.String, 60),
        new JdeField("MCRP01", "MCRP01", JdeDataType.String, 6),
        new JdeField("MCRP02", "MCRP02", JdeDataType.String, 6),
        new JdeField("MCRP03", "MCRP03", JdeDataType.String, 6),
        new JdeField("MCRP04", "MCRP04", JdeDataType.String, 6),
        new JdeField("MCRP05", "MCRP05", JdeDataType.String, 6),
        new JdeField("MCRP06", "MCRP06", JdeDataType.String, 6),
        new JdeField("MCRP07", "MCRP07", JdeDataType.String, 6),
        new JdeField("MCRP08", "MCRP08", JdeDataType.String, 6),
        new JdeField("MCRP09", "MCRP09", JdeDataType.String, 6),
        new JdeField("MCRP10", "MCRP10", JdeDataType.String, 6),
        new JdeField("MCRP11", "MCRP11", JdeDataType.String, 6),
        new JdeField("MCRP12", "MCRP12", JdeDataType.String, 6),
        new JdeField("MCRP13", "MCRP13", JdeDataType.String, 6),
        new JdeField("MCRP14", "MCRP14", JdeDataType.String, 6),
        new JdeField("MCRP15", "MCRP15", JdeDataType.String, 6),
        new JdeField("MCRP16", "MCRP16", JdeDataType.String, 6),
        new JdeField("MCRP17", "MCRP17", JdeDataType.String, 6),
        new JdeField("MCRP18", "MCRP18", JdeDataType.String, 6),
        new JdeField("MCRP19", "MCRP19", JdeDataType.String, 6),
        new JdeField("MCRP20", "MCRP20", JdeDataType.String, 6),
        new JdeField("MCRP21", "MCRP21", JdeDataType.String, 20),
        new JdeField("MCRP22", "MCRP22", JdeDataType.String, 20),
        new JdeField("MCRP23", "MCRP23", JdeDataType.String, 20),
        new JdeField("MCRP24", "MCRP24", JdeDataType.String, 20),
        new JdeField("MCRP25", "MCRP25", JdeDataType.String, 20),
        new JdeField("MCRP26", "MCRP26", JdeDataType.String, 20),
        new JdeField("MCRP27", "MCRP27", JdeDataType.String, 20),
        new JdeField("MCRP28", "MCRP28", JdeDataType.String, 20),
        new JdeField("MCRP29", "MCRP29", JdeDataType.String, 20),
        new JdeField("MCRP30", "MCRP30", JdeDataType.String, 20),
        new JdeField("MCTA", "MCTA", JdeDataType.String, 20),
        new JdeField("MCTXJS", "MCTXJS", JdeDataType.Numeric),
        new JdeField("MCTXA1", "MCTXA1", JdeDataType.String, 20),
        new JdeField("MCEXR1", "MCEXR1", JdeDataType.String, 4),
        new JdeField("MCTC01", "MCTC01", JdeDataType.String, 8),
        new JdeField("MCTC02", "MCTC02", JdeDataType.String, 8),
        new JdeField("MCTC03", "MCTC03", JdeDataType.String, 8),
        new JdeField("MCTC04", "MCTC04", JdeDataType.String, 8),
        new JdeField("MCTC05", "MCTC05", JdeDataType.String, 8),
        new JdeField("MCTC06", "MCTC06", JdeDataType.String, 8),
        new JdeField("MCTC07", "MCTC07", JdeDataType.String, 8),
        new JdeField("MCTC08", "MCTC08", JdeDataType.String, 8),
        new JdeField("MCTC09", "MCTC09", JdeDataType.String, 8),
        new JdeField("MCTC10", "MCTC10", JdeDataType.String, 8),
        new JdeField("MCND01", "MCND01", JdeDataType.String, 2),
        new JdeField("MCND02", "MCND02", JdeDataType.String, 2),
        new JdeField("MCND03", "MCND03", JdeDataType.String, 2),
        new JdeField("MCND04", "MCND04", JdeDataType.String, 2),
        new JdeField("MCND05", "MCND05", JdeDataType.String, 2),
        new JdeField("MCND06", "MCND06", JdeDataType.String, 2),
        new JdeField("MCND07", "MCND07", JdeDataType.String, 2),
        new JdeField("MCND08", "MCND08", JdeDataType.String, 2),
        new JdeField("MCND09", "MCND09", JdeDataType.String, 2),
        new JdeField("MCND10", "MCND10", JdeDataType.String, 2),
        new JdeField("MCCC01", "MCCC01", JdeDataType.String, 2),
        new JdeField("MCCC02", "MCCC02", JdeDataType.String, 2),
        new JdeField("MCCC03", "MCCC03", JdeDataType.String, 2),
        new JdeField("MCCC04", "MCCC04", JdeDataType.String, 2),
        new JdeField("MCCC05", "MCCC05", JdeDataType.String, 2),
        new JdeField("MCCC06", "MCCC06", JdeDataType.String, 2),
        new JdeField("MCCC07", "MCCC07", JdeDataType.String, 2),
        new JdeField("MCCC08", "MCCC08", JdeDataType.String, 2),
        new JdeField("MCCC09", "MCCC09", JdeDataType.String, 2),
        new JdeField("MCCC10", "MCCC10", JdeDataType.String, 2),
        new JdeField("MCPECC", "MCPECC", JdeDataType.String, 2),
        new JdeField("MCALS", "MCALS", JdeDataType.String, 2),
        new JdeField("MCISS", "MCISS", JdeDataType.String, 2),
        new JdeField("MCGLBA", "MCGLBA", JdeDataType.String, 16),
        new JdeField("MCALCL", "MCALCL", JdeDataType.String, 4),
        new JdeField("MCLMTH", "MCLMTH", JdeDataType.String, 2),
        new JdeField("MCLF", "MCLF", JdeDataType.Numeric),
        new JdeField("MCOBJ1", "MCOBJ1", JdeDataType.String, 12),
        new JdeField("MCOBJ2", "MCOBJ2", JdeDataType.String, 12),
        new JdeField("MCOBJ3", "MCOBJ3", JdeDataType.String, 12),
        new JdeField("MCSUB1", "MCSUB1", JdeDataType.String, 16),
        new JdeField("MCTOU", "MCTOU", JdeDataType.Numeric),
        new JdeField("MCSBLI", "MCSBLI", JdeDataType.String, 2),
        new JdeField("MCANPA", "MCANPA", JdeDataType.Numeric),
        new JdeField("MCCT", "MCCT", JdeDataType.String, 8),
        new JdeField("MCCERT", "MCCERT", JdeDataType.String, 2),
        new JdeField("MCMCUS", "MCMCUS", JdeDataType.String, 24),
        new JdeField("MCBTYP", "MCBTYP", JdeDataType.String, 2),
        new JdeField("MCPC", "MCPC", JdeDataType.Numeric),
        new JdeField("MCPCA", "MCPCA", JdeDataType.Numeric),
        new JdeField("MCPCC", "MCPCC", JdeDataType.Numeric),
        new JdeField("MCINTA", "MCINTA", JdeDataType.String, 8),
        new JdeField("MCINTL", "MCINTL", JdeDataType.String, 8),
        new JdeField("MCD1J", "MCD1J", JdeDataType.Numeric),
        new JdeField("MCD2J", "MCD2J", JdeDataType.Numeric),
        new JdeField("MCD3J", "MCD3J", JdeDataType.Numeric),
        new JdeField("MCD4J", "MCD4J", JdeDataType.Numeric),
        new JdeField("MCD5J", "MCD5J", JdeDataType.Numeric),
        new JdeField("MCD6J", "MCD6J", JdeDataType.Numeric),
        new JdeField("MCFPDJ", "MCFPDJ", JdeDataType.Numeric),
        new JdeField("MCCAC", "MCCAC", JdeDataType.Numeric),
        new JdeField("MCPAC", "MCPAC", JdeDataType.Numeric),
        new JdeField("MCEEO", "MCEEO", JdeDataType.String, 2),
        new JdeField("MCERC", "MCERC", JdeDataType.String, 4),
        new JdeField("MCUSER", "MCUSER", JdeDataType.String, 20),
        new JdeField("MCPID", "MCPID", JdeDataType.String, 20),
        new JdeField("MCUPMJ", "MCUPMJ", JdeDataType.Numeric),
        new JdeField("MCJOBN", "MCJOBN", JdeDataType.String, 20),
        new JdeField("MCUPMT", "MCUPMT", JdeDataType.Numeric),
        new JdeField("MCBPTP", "MCBPTP", JdeDataType.String, 30),
        new JdeField("MCAPSB", "MCAPSB", JdeDataType.String, 2),
        new JdeField("MCTSBU", "MCTSBU", JdeDataType.String, 24),
        new JdeField("MCRP31", "MCRP31", JdeDataType.String, 20),
        new JdeField("MCRP32", "MCRP32", JdeDataType.String, 20),
        new JdeField("MCRP33", "MCRP33", JdeDataType.String, 20),
        new JdeField("MCRP34", "MCRP34", JdeDataType.String, 20),
        new JdeField("MCRP35", "MCRP35", JdeDataType.String, 20),
        new JdeField("MCRP36", "MCRP36", JdeDataType.String, 20),
        new JdeField("MCRP37", "MCRP37", JdeDataType.String, 20),
        new JdeField("MCRP38", "MCRP38", JdeDataType.String, 20),
        new JdeField("MCRP39", "MCRP39", JdeDataType.String, 20),
        new JdeField("MCRP40", "MCRP40", JdeDataType.String, 20),
        new JdeField("MCRP41", "MCRP41", JdeDataType.String, 20),
        new JdeField("MCRP42", "MCRP42", JdeDataType.String, 20),
        new JdeField("MCRP43", "MCRP43", JdeDataType.String, 20),
        new JdeField("MCRP44", "MCRP44", JdeDataType.String, 20),
        new JdeField("MCRP45", "MCRP45", JdeDataType.String, 20),
        new JdeField("MCRP46", "MCRP46", JdeDataType.String, 20),
        new JdeField("MCRP47", "MCRP47", JdeDataType.String, 20),
        new JdeField("MCRP48", "MCRP48", JdeDataType.String, 20),
        new JdeField("MCRP49", "MCRP49", JdeDataType.String, 20),
        new JdeField("MCRP50", "MCRP50", JdeDataType.String, 20),
        new JdeField("MCAN8GCA1", "MCAN8GCA1", JdeDataType.Numeric),
        new JdeField("MCAN8GCA2", "MCAN8GCA2", JdeDataType.Numeric),
        new JdeField("MCAN8GCA3", "MCAN8GCA3", JdeDataType.Numeric),
        new JdeField("MCAN8GCA4", "MCAN8GCA4", JdeDataType.Numeric),
        new JdeField("MCAN8GCA5", "MCAN8GCA5", JdeDataType.Numeric),
        new JdeField("MCRMCU1", "MCRMCU1", JdeDataType.String, 24),
        new JdeField("MCDOCO", "MCDOCO", JdeDataType.Numeric),
        new JdeField("MCPCTN", "MCPCTN", JdeDataType.Numeric),
        new JdeField("MCCLNU", "MCCLNU", JdeDataType.Numeric),
        new JdeField("MCBUCA", "MCBUCA", JdeDataType.String, 10),
        new JdeField("MCADJENT", "MCADJENT", JdeDataType.String, 2),
        new JdeField("MCUAFL", "MCUAFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0006_0", "Primary Key on MCMCU", new[] { "MCMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0006_2", "Index on MCCO", new[] { "MCCO" }),
        new JdeIndex("F0006_4", "Index on MCSTYL, MCCO", new[] { "MCSTYL", "MCCO" }),
        new JdeIndex("F0006_5", "Index on MCSTYL, MCFMOD", new[] { "MCSTYL", "MCFMOD" }),
        new JdeIndex("F0006_6", "Index on SYS_NC00153$", new[] { "SYS_NC00153$" }),
        new JdeIndex("F0006_7", "Index on MCCLNU, MCPCTN, MCDOCO", new[] { "MCCLNU", "MCPCTN", "MCDOCO" }),
        new JdeIndex("F0006_8", "Index on MCDL01", new[] { "MCDL01" })
    };
}
