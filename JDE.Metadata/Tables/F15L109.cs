using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L109 - .
/// </summary>
public class F15L109 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRRVNB.
        /// </summary>
        public const string BRRVNB = "BRRVNB";

        /// <summary>
        /// BRAID.
        /// </summary>
        public const string BRAID = "BRAID";

        /// <summary>
        /// BRCTRY.
        /// </summary>
        public const string BRCTRY = "BRCTRY";

        /// <summary>
        /// BRFY.
        /// </summary>
        public const string BRFY = "BRFY";

        /// <summary>
        /// BRSBL.
        /// </summary>
        public const string BRSBL = "BRSBL";

        /// <summary>
        /// BRSBLT.
        /// </summary>
        public const string BRSBLT = "BRSBLT";

        /// <summary>
        /// BRCO.
        /// </summary>
        public const string BRCO = "BRCO";

        /// <summary>
        /// BRAPYC.
        /// </summary>
        public const string BRAPYC = "BRAPYC";

        /// <summary>
        /// BRAN01.
        /// </summary>
        public const string BRAN01 = "BRAN01";

        /// <summary>
        /// BRAN02.
        /// </summary>
        public const string BRAN02 = "BRAN02";

        /// <summary>
        /// BRAN03.
        /// </summary>
        public const string BRAN03 = "BRAN03";

        /// <summary>
        /// BRAN04.
        /// </summary>
        public const string BRAN04 = "BRAN04";

        /// <summary>
        /// BRAN05.
        /// </summary>
        public const string BRAN05 = "BRAN05";

        /// <summary>
        /// BRAN06.
        /// </summary>
        public const string BRAN06 = "BRAN06";

        /// <summary>
        /// BRAN07.
        /// </summary>
        public const string BRAN07 = "BRAN07";

        /// <summary>
        /// BRAN08.
        /// </summary>
        public const string BRAN08 = "BRAN08";

        /// <summary>
        /// BRAN09.
        /// </summary>
        public const string BRAN09 = "BRAN09";

        /// <summary>
        /// BRAN10.
        /// </summary>
        public const string BRAN10 = "BRAN10";

        /// <summary>
        /// BRAN11.
        /// </summary>
        public const string BRAN11 = "BRAN11";

        /// <summary>
        /// BRAN12.
        /// </summary>
        public const string BRAN12 = "BRAN12";

        /// <summary>
        /// BRMCU.
        /// </summary>
        public const string BRMCU = "BRMCU";

        /// <summary>
        /// BROBJ.
        /// </summary>
        public const string BROBJ = "BROBJ";

        /// <summary>
        /// BRSUB.
        /// </summary>
        public const string BRSUB = "BRSUB";

        /// <summary>
        /// BRBELK.
        /// </summary>
        public const string BRBELK = "BRBELK";

        /// <summary>
        /// BREFTB.
        /// </summary>
        public const string BREFTB = "BREFTB";

        /// <summary>
        /// BREFTE.
        /// </summary>
        public const string BREFTE = "BREFTE";

        /// <summary>
        /// BRURCD.
        /// </summary>
        public const string BRURCD = "BRURCD";

        /// <summary>
        /// BRURDT.
        /// </summary>
        public const string BRURDT = "BRURDT";

        /// <summary>
        /// BRURAT.
        /// </summary>
        public const string BRURAT = "BRURAT";

        /// <summary>
        /// BRURAB.
        /// </summary>
        public const string BRURAB = "BRURAB";

        /// <summary>
        /// BRURRF.
        /// </summary>
        public const string BRURRF = "BRURRF";

        /// <summary>
        /// BRTORG.
        /// </summary>
        public const string BRTORG = "BRTORG";

        /// <summary>
        /// BRENTJ.
        /// </summary>
        public const string BRENTJ = "BRENTJ";

        /// <summary>
        /// BRJOBN.
        /// </summary>
        public const string BRJOBN = "BRJOBN";

        /// <summary>
        /// BRUSER.
        /// </summary>
        public const string BRUSER = "BRUSER";

        /// <summary>
        /// BRPID.
        /// </summary>
        public const string BRPID = "BRPID";

        /// <summary>
        /// BRUPMJ.
        /// </summary>
        public const string BRUPMJ = "BRUPMJ";

        /// <summary>
        /// BRUPMT.
        /// </summary>
        public const string BRUPMT = "BRUPMT";

        /// <summary>
        /// BRMCU2.
        /// </summary>
        public const string BRMCU2 = "BRMCU2";
    }

    /// <inheritdoc />
    public override string TableName => "F15L109";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRRVNB", "BRRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("BRAID", "BRAID", JdeDataType.String, 16, true, true),
        new JdeField("BRCTRY", "BRCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("BRFY", "BRFY", JdeDataType.Numeric, null, true, true),
        new JdeField("BRSBL", "BRSBL", JdeDataType.String, 16, true, true),
        new JdeField("BRSBLT", "BRSBLT", JdeDataType.String, 2, true, true),
        new JdeField("BRCO", "BRCO", JdeDataType.String, 10),
        new JdeField("BRAPYC", "BRAPYC", JdeDataType.Numeric),
        new JdeField("BRAN01", "BRAN01", JdeDataType.Numeric),
        new JdeField("BRAN02", "BRAN02", JdeDataType.Numeric),
        new JdeField("BRAN03", "BRAN03", JdeDataType.Numeric),
        new JdeField("BRAN04", "BRAN04", JdeDataType.Numeric),
        new JdeField("BRAN05", "BRAN05", JdeDataType.Numeric),
        new JdeField("BRAN06", "BRAN06", JdeDataType.Numeric),
        new JdeField("BRAN07", "BRAN07", JdeDataType.Numeric),
        new JdeField("BRAN08", "BRAN08", JdeDataType.Numeric),
        new JdeField("BRAN09", "BRAN09", JdeDataType.Numeric),
        new JdeField("BRAN10", "BRAN10", JdeDataType.Numeric),
        new JdeField("BRAN11", "BRAN11", JdeDataType.Numeric),
        new JdeField("BRAN12", "BRAN12", JdeDataType.Numeric),
        new JdeField("BRMCU", "BRMCU", JdeDataType.String, 24, true, true),
        new JdeField("BROBJ", "BROBJ", JdeDataType.String, 12),
        new JdeField("BRSUB", "BRSUB", JdeDataType.String, 16),
        new JdeField("BRBELK", "BRBELK", JdeDataType.String, 2),
        new JdeField("BREFTB", "BREFTB", JdeDataType.Numeric),
        new JdeField("BREFTE", "BREFTE", JdeDataType.Numeric),
        new JdeField("BRURCD", "BRURCD", JdeDataType.String, 4),
        new JdeField("BRURDT", "BRURDT", JdeDataType.Numeric),
        new JdeField("BRURAT", "BRURAT", JdeDataType.Numeric),
        new JdeField("BRURAB", "BRURAB", JdeDataType.Numeric),
        new JdeField("BRURRF", "BRURRF", JdeDataType.String, 30),
        new JdeField("BRTORG", "BRTORG", JdeDataType.String, 20),
        new JdeField("BRENTJ", "BRENTJ", JdeDataType.Numeric),
        new JdeField("BRJOBN", "BRJOBN", JdeDataType.String, 20),
        new JdeField("BRUSER", "BRUSER", JdeDataType.String, 20),
        new JdeField("BRPID", "BRPID", JdeDataType.String, 20),
        new JdeField("BRUPMJ", "BRUPMJ", JdeDataType.Numeric),
        new JdeField("BRUPMT", "BRUPMT", JdeDataType.Numeric),
        new JdeField("BRMCU2", "BRMCU2", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L109_0", "Primary Key on BRMCU, BRRVNB, BRAID, BRCTRY, BRFY, BRSBL, BRSBLT", new[] { "BRMCU", "BRRVNB", "BRAID", "BRCTRY", "BRFY", "BRSBL", "BRSBLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L109_2", "Index on BRMCU, BRRVNB, BRSBL, BRAID, BRCTRY, BRFY", new[] { "BRMCU", "BRRVNB", "BRSBL", "BRAID", "BRCTRY", "BRFY" }),
        new JdeIndex("F15L109_3", "Index on BRMCU, BRRVNB, BRSBL, BRMCU2, BROBJ, BRSUB, BRCTRY, BRFY", new[] { "BRMCU", "BRRVNB", "BRSBL", "BRMCU2", "BROBJ", "BRSUB", "BRCTRY", "BRFY" })
    };
}
