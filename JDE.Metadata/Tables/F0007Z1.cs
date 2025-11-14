using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0007Z1 - .
/// </summary>
public class F0007Z1 : JdeTable
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
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZMT.
        /// </summary>
        public const string SZMT = "SZMT";

        /// <summary>
        /// SZYR.
        /// </summary>
        public const string SZYR = "SZYR";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZSHFT.
        /// </summary>
        public const string SZSHFT = "SZSHFT";

        /// <summary>
        /// SZTD01.
        /// </summary>
        public const string SZTD01 = "SZTD01";

        /// <summary>
        /// SZTD02.
        /// </summary>
        public const string SZTD02 = "SZTD02";

        /// <summary>
        /// SZTD03.
        /// </summary>
        public const string SZTD03 = "SZTD03";

        /// <summary>
        /// SZTD04.
        /// </summary>
        public const string SZTD04 = "SZTD04";

        /// <summary>
        /// SZTD05.
        /// </summary>
        public const string SZTD05 = "SZTD05";

        /// <summary>
        /// SZTD06.
        /// </summary>
        public const string SZTD06 = "SZTD06";

        /// <summary>
        /// SZTD07.
        /// </summary>
        public const string SZTD07 = "SZTD07";

        /// <summary>
        /// SZTD08.
        /// </summary>
        public const string SZTD08 = "SZTD08";

        /// <summary>
        /// SZTD09.
        /// </summary>
        public const string SZTD09 = "SZTD09";

        /// <summary>
        /// SZTD10.
        /// </summary>
        public const string SZTD10 = "SZTD10";

        /// <summary>
        /// SZTD11.
        /// </summary>
        public const string SZTD11 = "SZTD11";

        /// <summary>
        /// SZTD12.
        /// </summary>
        public const string SZTD12 = "SZTD12";

        /// <summary>
        /// SZTD13.
        /// </summary>
        public const string SZTD13 = "SZTD13";

        /// <summary>
        /// SZTD14.
        /// </summary>
        public const string SZTD14 = "SZTD14";

        /// <summary>
        /// SZTD15.
        /// </summary>
        public const string SZTD15 = "SZTD15";

        /// <summary>
        /// SZTD16.
        /// </summary>
        public const string SZTD16 = "SZTD16";

        /// <summary>
        /// SZTD17.
        /// </summary>
        public const string SZTD17 = "SZTD17";

        /// <summary>
        /// SZTD18.
        /// </summary>
        public const string SZTD18 = "SZTD18";

        /// <summary>
        /// SZTD19.
        /// </summary>
        public const string SZTD19 = "SZTD19";

        /// <summary>
        /// SZTD20.
        /// </summary>
        public const string SZTD20 = "SZTD20";

        /// <summary>
        /// SZTD21.
        /// </summary>
        public const string SZTD21 = "SZTD21";

        /// <summary>
        /// SZTD22.
        /// </summary>
        public const string SZTD22 = "SZTD22";

        /// <summary>
        /// SZTD23.
        /// </summary>
        public const string SZTD23 = "SZTD23";

        /// <summary>
        /// SZTD24.
        /// </summary>
        public const string SZTD24 = "SZTD24";

        /// <summary>
        /// SZTD25.
        /// </summary>
        public const string SZTD25 = "SZTD25";

        /// <summary>
        /// SZTD26.
        /// </summary>
        public const string SZTD26 = "SZTD26";

        /// <summary>
        /// SZTD27.
        /// </summary>
        public const string SZTD27 = "SZTD27";

        /// <summary>
        /// SZTD28.
        /// </summary>
        public const string SZTD28 = "SZTD28";

        /// <summary>
        /// SZTD29.
        /// </summary>
        public const string SZTD29 = "SZTD29";

        /// <summary>
        /// SZTD30.
        /// </summary>
        public const string SZTD30 = "SZTD30";

        /// <summary>
        /// SZTD31.
        /// </summary>
        public const string SZTD31 = "SZTD31";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZWDCT.
        /// </summary>
        public const string SZWDCT = "SZWDCT";

        /// <summary>
        /// SZWDCK.
        /// </summary>
        public const string SZWDCK = "SZWDCK";
    }

    /// <inheritdoc />
    public override string TableName => "F0007Z1";

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
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZMT", "SZMT", JdeDataType.Numeric),
        new JdeField("SZYR", "SZYR", JdeDataType.Numeric),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZSHFT", "SZSHFT", JdeDataType.String, 2),
        new JdeField("SZTD01", "SZTD01", JdeDataType.String, 2),
        new JdeField("SZTD02", "SZTD02", JdeDataType.String, 2),
        new JdeField("SZTD03", "SZTD03", JdeDataType.String, 2),
        new JdeField("SZTD04", "SZTD04", JdeDataType.String, 2),
        new JdeField("SZTD05", "SZTD05", JdeDataType.String, 2),
        new JdeField("SZTD06", "SZTD06", JdeDataType.String, 2),
        new JdeField("SZTD07", "SZTD07", JdeDataType.String, 2),
        new JdeField("SZTD08", "SZTD08", JdeDataType.String, 2),
        new JdeField("SZTD09", "SZTD09", JdeDataType.String, 2),
        new JdeField("SZTD10", "SZTD10", JdeDataType.String, 2),
        new JdeField("SZTD11", "SZTD11", JdeDataType.String, 2),
        new JdeField("SZTD12", "SZTD12", JdeDataType.String, 2),
        new JdeField("SZTD13", "SZTD13", JdeDataType.String, 2),
        new JdeField("SZTD14", "SZTD14", JdeDataType.String, 2),
        new JdeField("SZTD15", "SZTD15", JdeDataType.String, 2),
        new JdeField("SZTD16", "SZTD16", JdeDataType.String, 2),
        new JdeField("SZTD17", "SZTD17", JdeDataType.String, 2),
        new JdeField("SZTD18", "SZTD18", JdeDataType.String, 2),
        new JdeField("SZTD19", "SZTD19", JdeDataType.String, 2),
        new JdeField("SZTD20", "SZTD20", JdeDataType.String, 2),
        new JdeField("SZTD21", "SZTD21", JdeDataType.String, 2),
        new JdeField("SZTD22", "SZTD22", JdeDataType.String, 2),
        new JdeField("SZTD23", "SZTD23", JdeDataType.String, 2),
        new JdeField("SZTD24", "SZTD24", JdeDataType.String, 2),
        new JdeField("SZTD25", "SZTD25", JdeDataType.String, 2),
        new JdeField("SZTD26", "SZTD26", JdeDataType.String, 2),
        new JdeField("SZTD27", "SZTD27", JdeDataType.String, 2),
        new JdeField("SZTD28", "SZTD28", JdeDataType.String, 2),
        new JdeField("SZTD29", "SZTD29", JdeDataType.String, 2),
        new JdeField("SZTD30", "SZTD30", JdeDataType.String, 2),
        new JdeField("SZTD31", "SZTD31", JdeDataType.String, 2),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZWDCT", "SZWDCT", JdeDataType.String, 20),
        new JdeField("SZWDCK", "SZWDCK", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0007Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0007Z1_2", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDSP" }),
        new JdeIndex("F0007Z1_3", "Index on SZEDUS, SZEDBT, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDSP" }),
        new JdeIndex("F0007Z1_4", "Index on SZEDUS, SZEDBT, SZEDTN", new[] { "SZEDUS", "SZEDBT", "SZEDTN" }),
        new JdeIndex("F0007Z1_5", "Index on SZEDUS, SZEDBT, SZEDTN, SYS_NC00057$", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SYS_NC00057$" })
    };
}
