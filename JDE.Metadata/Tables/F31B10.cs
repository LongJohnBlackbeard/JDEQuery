using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B10 - .
/// </summary>
public class F31B10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VBVBTID.
        /// </summary>
        public const string VBVBTID = "VBVBTID";

        /// <summary>
        /// VBMCU.
        /// </summary>
        public const string VBMCU = "VBMCU";

        /// <summary>
        /// VBVBTN.
        /// </summary>
        public const string VBVBTN = "VBVBTN";

        /// <summary>
        /// VBBATP.
        /// </summary>
        public const string VBBATP = "VBBATP";

        /// <summary>
        /// VBCAPTYP.
        /// </summary>
        public const string VBCAPTYP = "VBCAPTYP";

        /// <summary>
        /// VBCUSE.
        /// </summary>
        public const string VBCUSE = "VBCUSE";

        /// <summary>
        /// VBBAVC.
        /// </summary>
        public const string VBBAVC = "VBBAVC";

        /// <summary>
        /// VBVBTTYPE.
        /// </summary>
        public const string VBVBTTYPE = "VBVBTTYPE";

        /// <summary>
        /// VBPID.
        /// </summary>
        public const string VBPID = "VBPID";

        /// <summary>
        /// VBMKEY.
        /// </summary>
        public const string VBMKEY = "VBMKEY";

        /// <summary>
        /// VBUPMT.
        /// </summary>
        public const string VBUPMT = "VBUPMT";

        /// <summary>
        /// VBUPMJ.
        /// </summary>
        public const string VBUPMJ = "VBUPMJ";

        /// <summary>
        /// VBURAT.
        /// </summary>
        public const string VBURAT = "VBURAT";

        /// <summary>
        /// VBURCD.
        /// </summary>
        public const string VBURCD = "VBURCD";

        /// <summary>
        /// VBURDT.
        /// </summary>
        public const string VBURDT = "VBURDT";

        /// <summary>
        /// VBURAB.
        /// </summary>
        public const string VBURAB = "VBURAB";

        /// <summary>
        /// VBURRF.
        /// </summary>
        public const string VBURRF = "VBURRF";

        /// <summary>
        /// VBBIDSEQ.
        /// </summary>
        public const string VBBIDSEQ = "VBBIDSEQ";

        /// <summary>
        /// VBVBTUSEF.
        /// </summary>
        public const string VBVBTUSEF = "VBVBTUSEF";

        /// <summary>
        /// VBEMPTYVBT.
        /// </summary>
        public const string VBEMPTYVBT = "VBEMPTYVBT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VBVBTID", "VBVBTID", JdeDataType.Numeric, null, true, true),
        new JdeField("VBMCU", "VBMCU", JdeDataType.String, 24, true, true),
        new JdeField("VBVBTN", "VBVBTN", JdeDataType.String, 60),
        new JdeField("VBBATP", "VBBATP", JdeDataType.String, 8),
        new JdeField("VBCAPTYP", "VBCAPTYP", JdeDataType.String, 2),
        new JdeField("VBCUSE", "VBCUSE", JdeDataType.String, 8),
        new JdeField("VBBAVC", "VBBAVC", JdeDataType.String, 8),
        new JdeField("VBVBTTYPE", "VBVBTTYPE", JdeDataType.String, 2),
        new JdeField("VBPID", "VBPID", JdeDataType.String, 20),
        new JdeField("VBMKEY", "VBMKEY", JdeDataType.String, 30),
        new JdeField("VBUPMT", "VBUPMT", JdeDataType.Numeric),
        new JdeField("VBUPMJ", "VBUPMJ", JdeDataType.Numeric),
        new JdeField("VBURAT", "VBURAT", JdeDataType.Numeric),
        new JdeField("VBURCD", "VBURCD", JdeDataType.String, 4),
        new JdeField("VBURDT", "VBURDT", JdeDataType.Numeric),
        new JdeField("VBURAB", "VBURAB", JdeDataType.Numeric),
        new JdeField("VBURRF", "VBURRF", JdeDataType.String, 30),
        new JdeField("VBBIDSEQ", "VBBIDSEQ", JdeDataType.Numeric),
        new JdeField("VBVBTUSEF", "VBVBTUSEF", JdeDataType.String, 2),
        new JdeField("VBEMPTYVBT", "VBEMPTYVBT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B10_0", "Primary Key on VBVBTID, VBMCU", new[] { "VBVBTID", "VBMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B10_2", "Index on VBVBTN, VBMCU", new[] { "VBVBTN", "VBMCU" })
    };
}
