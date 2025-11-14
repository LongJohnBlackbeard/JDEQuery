using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L118 - .
/// </summary>
public class F15L118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDMCU.
        /// </summary>
        public const string DDMCU = "DDMCU";

        /// <summary>
        /// DDAID.
        /// </summary>
        public const string DDAID = "DDAID";

        /// <summary>
        /// DDRVNB.
        /// </summary>
        public const string DDRVNB = "DDRVNB";

        /// <summary>
        /// DDCTRY.
        /// </summary>
        public const string DDCTRY = "DDCTRY";

        /// <summary>
        /// DDFY.
        /// </summary>
        public const string DDFY = "DDFY";

        /// <summary>
        /// DDLNID.
        /// </summary>
        public const string DDLNID = "DDLNID";

        /// <summary>
        /// DDDESC.
        /// </summary>
        public const string DDDESC = "DDDESC";

        /// <summary>
        /// DDAN01.
        /// </summary>
        public const string DDAN01 = "DDAN01";

        /// <summary>
        /// DDAN02.
        /// </summary>
        public const string DDAN02 = "DDAN02";

        /// <summary>
        /// DDAN03.
        /// </summary>
        public const string DDAN03 = "DDAN03";

        /// <summary>
        /// DDAN04.
        /// </summary>
        public const string DDAN04 = "DDAN04";

        /// <summary>
        /// DDAN05.
        /// </summary>
        public const string DDAN05 = "DDAN05";

        /// <summary>
        /// DDAN06.
        /// </summary>
        public const string DDAN06 = "DDAN06";

        /// <summary>
        /// DDAN07.
        /// </summary>
        public const string DDAN07 = "DDAN07";

        /// <summary>
        /// DDAN08.
        /// </summary>
        public const string DDAN08 = "DDAN08";

        /// <summary>
        /// DDAN09.
        /// </summary>
        public const string DDAN09 = "DDAN09";

        /// <summary>
        /// DDAN10.
        /// </summary>
        public const string DDAN10 = "DDAN10";

        /// <summary>
        /// DDAN11.
        /// </summary>
        public const string DDAN11 = "DDAN11";

        /// <summary>
        /// DDAN12.
        /// </summary>
        public const string DDAN12 = "DDAN12";

        /// <summary>
        /// DDAA2.
        /// </summary>
        public const string DDAA2 = "DDAA2";

        /// <summary>
        /// DDBPC.
        /// </summary>
        public const string DDBPC = "DDBPC";

        /// <summary>
        /// DDURCD.
        /// </summary>
        public const string DDURCD = "DDURCD";

        /// <summary>
        /// DDURDT.
        /// </summary>
        public const string DDURDT = "DDURDT";

        /// <summary>
        /// DDURAT.
        /// </summary>
        public const string DDURAT = "DDURAT";

        /// <summary>
        /// DDURAB.
        /// </summary>
        public const string DDURAB = "DDURAB";

        /// <summary>
        /// DDURRF.
        /// </summary>
        public const string DDURRF = "DDURRF";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDJOBN.
        /// </summary>
        public const string DDJOBN = "DDJOBN";

        /// <summary>
        /// DDUPMJ.
        /// </summary>
        public const string DDUPMJ = "DDUPMJ";

        /// <summary>
        /// DDUPMT.
        /// </summary>
        public const string DDUPMT = "DDUPMT";

        /// <summary>
        /// DDTORG.
        /// </summary>
        public const string DDTORG = "DDTORG";

        /// <summary>
        /// DDENTJ.
        /// </summary>
        public const string DDENTJ = "DDENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDMCU", "DDMCU", JdeDataType.String, 24, true, true),
        new JdeField("DDAID", "DDAID", JdeDataType.String, 16, true, true),
        new JdeField("DDRVNB", "DDRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("DDCTRY", "DDCTRY", JdeDataType.Numeric),
        new JdeField("DDFY", "DDFY", JdeDataType.Numeric),
        new JdeField("DDLNID", "DDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DDDESC", "DDDESC", JdeDataType.String, 60),
        new JdeField("DDAN01", "DDAN01", JdeDataType.Numeric),
        new JdeField("DDAN02", "DDAN02", JdeDataType.Numeric),
        new JdeField("DDAN03", "DDAN03", JdeDataType.Numeric),
        new JdeField("DDAN04", "DDAN04", JdeDataType.Numeric),
        new JdeField("DDAN05", "DDAN05", JdeDataType.Numeric),
        new JdeField("DDAN06", "DDAN06", JdeDataType.Numeric),
        new JdeField("DDAN07", "DDAN07", JdeDataType.Numeric),
        new JdeField("DDAN08", "DDAN08", JdeDataType.Numeric),
        new JdeField("DDAN09", "DDAN09", JdeDataType.Numeric),
        new JdeField("DDAN10", "DDAN10", JdeDataType.Numeric),
        new JdeField("DDAN11", "DDAN11", JdeDataType.Numeric),
        new JdeField("DDAN12", "DDAN12", JdeDataType.Numeric),
        new JdeField("DDAA2", "DDAA2", JdeDataType.Numeric),
        new JdeField("DDBPC", "DDBPC", JdeDataType.String, 6),
        new JdeField("DDURCD", "DDURCD", JdeDataType.String, 4),
        new JdeField("DDURDT", "DDURDT", JdeDataType.Numeric),
        new JdeField("DDURAT", "DDURAT", JdeDataType.Numeric),
        new JdeField("DDURAB", "DDURAB", JdeDataType.Numeric),
        new JdeField("DDURRF", "DDURRF", JdeDataType.String, 30),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDJOBN", "DDJOBN", JdeDataType.String, 20),
        new JdeField("DDUPMJ", "DDUPMJ", JdeDataType.Numeric),
        new JdeField("DDUPMT", "DDUPMT", JdeDataType.Numeric),
        new JdeField("DDTORG", "DDTORG", JdeDataType.String, 20),
        new JdeField("DDENTJ", "DDENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L118_0", "Primary Key on DDMCU, DDAID, DDRVNB, DDLNID", new[] { "DDMCU", "DDAID", "DDRVNB", "DDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
