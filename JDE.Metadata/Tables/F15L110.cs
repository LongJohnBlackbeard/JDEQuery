using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L110 - .
/// </summary>
public class F15L110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASMCU.
        /// </summary>
        public const string ASMCU = "ASMCU";

        /// <summary>
        /// ASRVNB.
        /// </summary>
        public const string ASRVNB = "ASRVNB";

        /// <summary>
        /// ASAID.
        /// </summary>
        public const string ASAID = "ASAID";

        /// <summary>
        /// ASCTRY.
        /// </summary>
        public const string ASCTRY = "ASCTRY";

        /// <summary>
        /// ASFY.
        /// </summary>
        public const string ASFY = "ASFY";

        /// <summary>
        /// ASSBL.
        /// </summary>
        public const string ASSBL = "ASSBL";

        /// <summary>
        /// ASSBLT.
        /// </summary>
        public const string ASSBLT = "ASSBLT";

        /// <summary>
        /// ASAN01.
        /// </summary>
        public const string ASAN01 = "ASAN01";

        /// <summary>
        /// ASAN02.
        /// </summary>
        public const string ASAN02 = "ASAN02";

        /// <summary>
        /// ASAN03.
        /// </summary>
        public const string ASAN03 = "ASAN03";

        /// <summary>
        /// ASAN04.
        /// </summary>
        public const string ASAN04 = "ASAN04";

        /// <summary>
        /// ASAN05.
        /// </summary>
        public const string ASAN05 = "ASAN05";

        /// <summary>
        /// ASAN06.
        /// </summary>
        public const string ASAN06 = "ASAN06";

        /// <summary>
        /// ASAN07.
        /// </summary>
        public const string ASAN07 = "ASAN07";

        /// <summary>
        /// ASAN08.
        /// </summary>
        public const string ASAN08 = "ASAN08";

        /// <summary>
        /// ASAN09.
        /// </summary>
        public const string ASAN09 = "ASAN09";

        /// <summary>
        /// ASAN10.
        /// </summary>
        public const string ASAN10 = "ASAN10";

        /// <summary>
        /// ASAN11.
        /// </summary>
        public const string ASAN11 = "ASAN11";

        /// <summary>
        /// ASAN12.
        /// </summary>
        public const string ASAN12 = "ASAN12";

        /// <summary>
        /// ASLPN01.
        /// </summary>
        public const string ASLPN01 = "ASLPN01";

        /// <summary>
        /// ASLPN02.
        /// </summary>
        public const string ASLPN02 = "ASLPN02";

        /// <summary>
        /// ASLPN03.
        /// </summary>
        public const string ASLPN03 = "ASLPN03";

        /// <summary>
        /// ASLPN04.
        /// </summary>
        public const string ASLPN04 = "ASLPN04";

        /// <summary>
        /// ASLPN05.
        /// </summary>
        public const string ASLPN05 = "ASLPN05";

        /// <summary>
        /// ASLPN06.
        /// </summary>
        public const string ASLPN06 = "ASLPN06";

        /// <summary>
        /// ASLPN07.
        /// </summary>
        public const string ASLPN07 = "ASLPN07";

        /// <summary>
        /// ASLPN08.
        /// </summary>
        public const string ASLPN08 = "ASLPN08";

        /// <summary>
        /// ASLPN09.
        /// </summary>
        public const string ASLPN09 = "ASLPN09";

        /// <summary>
        /// ASLPN10.
        /// </summary>
        public const string ASLPN10 = "ASLPN10";

        /// <summary>
        /// ASLPN11.
        /// </summary>
        public const string ASLPN11 = "ASLPN11";

        /// <summary>
        /// ASLPN12.
        /// </summary>
        public const string ASLPN12 = "ASLPN12";

        /// <summary>
        /// ASOBJ.
        /// </summary>
        public const string ASOBJ = "ASOBJ";

        /// <summary>
        /// ASMCU2.
        /// </summary>
        public const string ASMCU2 = "ASMCU2";

        /// <summary>
        /// ASDL01.
        /// </summary>
        public const string ASDL01 = "ASDL01";

        /// <summary>
        /// ASSUB.
        /// </summary>
        public const string ASSUB = "ASSUB";

        /// <summary>
        /// ASCO.
        /// </summary>
        public const string ASCO = "ASCO";

        /// <summary>
        /// ASFLRE.
        /// </summary>
        public const string ASFLRE = "ASFLRE";

        /// <summary>
        /// ASAA2.
        /// </summary>
        public const string ASAA2 = "ASAA2";

        /// <summary>
        /// ASBPC.
        /// </summary>
        public const string ASBPC = "ASBPC";

        /// <summary>
        /// ASGRWU.
        /// </summary>
        public const string ASGRWU = "ASGRWU";

        /// <summary>
        /// ASGRPA.
        /// </summary>
        public const string ASGRPA = "ASGRPA";

        /// <summary>
        /// ASURAB.
        /// </summary>
        public const string ASURAB = "ASURAB";

        /// <summary>
        /// ASURAT.
        /// </summary>
        public const string ASURAT = "ASURAT";

        /// <summary>
        /// ASURCD.
        /// </summary>
        public const string ASURCD = "ASURCD";

        /// <summary>
        /// ASURDT.
        /// </summary>
        public const string ASURDT = "ASURDT";

        /// <summary>
        /// ASURRF.
        /// </summary>
        public const string ASURRF = "ASURRF";

        /// <summary>
        /// ASMKEY.
        /// </summary>
        public const string ASMKEY = "ASMKEY";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASUPMJ.
        /// </summary>
        public const string ASUPMJ = "ASUPMJ";

        /// <summary>
        /// ASUPMT.
        /// </summary>
        public const string ASUPMT = "ASUPMT";

        /// <summary>
        /// ASTORG.
        /// </summary>
        public const string ASTORG = "ASTORG";

        /// <summary>
        /// ASENTJ.
        /// </summary>
        public const string ASENTJ = "ASENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASMCU", "ASMCU", JdeDataType.String, 24, true, true),
        new JdeField("ASRVNB", "ASRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("ASAID", "ASAID", JdeDataType.String, 16, true, true),
        new JdeField("ASCTRY", "ASCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ASFY", "ASFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ASSBL", "ASSBL", JdeDataType.String, 16, true, true),
        new JdeField("ASSBLT", "ASSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ASAN01", "ASAN01", JdeDataType.Numeric),
        new JdeField("ASAN02", "ASAN02", JdeDataType.Numeric),
        new JdeField("ASAN03", "ASAN03", JdeDataType.Numeric),
        new JdeField("ASAN04", "ASAN04", JdeDataType.Numeric),
        new JdeField("ASAN05", "ASAN05", JdeDataType.Numeric),
        new JdeField("ASAN06", "ASAN06", JdeDataType.Numeric),
        new JdeField("ASAN07", "ASAN07", JdeDataType.Numeric),
        new JdeField("ASAN08", "ASAN08", JdeDataType.Numeric),
        new JdeField("ASAN09", "ASAN09", JdeDataType.Numeric),
        new JdeField("ASAN10", "ASAN10", JdeDataType.Numeric),
        new JdeField("ASAN11", "ASAN11", JdeDataType.Numeric),
        new JdeField("ASAN12", "ASAN12", JdeDataType.Numeric),
        new JdeField("ASLPN01", "ASLPN01", JdeDataType.String, 2),
        new JdeField("ASLPN02", "ASLPN02", JdeDataType.String, 2),
        new JdeField("ASLPN03", "ASLPN03", JdeDataType.String, 2),
        new JdeField("ASLPN04", "ASLPN04", JdeDataType.String, 2),
        new JdeField("ASLPN05", "ASLPN05", JdeDataType.String, 2),
        new JdeField("ASLPN06", "ASLPN06", JdeDataType.String, 2),
        new JdeField("ASLPN07", "ASLPN07", JdeDataType.String, 2),
        new JdeField("ASLPN08", "ASLPN08", JdeDataType.String, 2),
        new JdeField("ASLPN09", "ASLPN09", JdeDataType.String, 2),
        new JdeField("ASLPN10", "ASLPN10", JdeDataType.String, 2),
        new JdeField("ASLPN11", "ASLPN11", JdeDataType.String, 2),
        new JdeField("ASLPN12", "ASLPN12", JdeDataType.String, 2),
        new JdeField("ASOBJ", "ASOBJ", JdeDataType.String, 12),
        new JdeField("ASMCU2", "ASMCU2", JdeDataType.String, 24),
        new JdeField("ASDL01", "ASDL01", JdeDataType.String, 60),
        new JdeField("ASSUB", "ASSUB", JdeDataType.String, 16),
        new JdeField("ASCO", "ASCO", JdeDataType.String, 10),
        new JdeField("ASFLRE", "ASFLRE", JdeDataType.String, 2),
        new JdeField("ASAA2", "ASAA2", JdeDataType.Numeric),
        new JdeField("ASBPC", "ASBPC", JdeDataType.String, 6),
        new JdeField("ASGRWU", "ASGRWU", JdeDataType.String, 2),
        new JdeField("ASGRPA", "ASGRPA", JdeDataType.String, 20),
        new JdeField("ASURAB", "ASURAB", JdeDataType.Numeric),
        new JdeField("ASURAT", "ASURAT", JdeDataType.Numeric),
        new JdeField("ASURCD", "ASURCD", JdeDataType.String, 4),
        new JdeField("ASURDT", "ASURDT", JdeDataType.Numeric),
        new JdeField("ASURRF", "ASURRF", JdeDataType.String, 30),
        new JdeField("ASMKEY", "ASMKEY", JdeDataType.String, 30),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASUPMJ", "ASUPMJ", JdeDataType.Numeric),
        new JdeField("ASUPMT", "ASUPMT", JdeDataType.Numeric),
        new JdeField("ASTORG", "ASTORG", JdeDataType.String, 20),
        new JdeField("ASENTJ", "ASENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L110_0", "Primary Key on ASMCU, ASRVNB, ASAID, ASCTRY, ASFY, ASSBL, ASSBLT", new[] { "ASMCU", "ASRVNB", "ASAID", "ASCTRY", "ASFY", "ASSBL", "ASSBLT" }, isUnique: true, isPrimaryKey: true)
    };
}
