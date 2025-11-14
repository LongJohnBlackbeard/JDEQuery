using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07300 - .
/// </summary>
public class F07300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YBAN8.
        /// </summary>
        public const string YBAN8 = "YBAN8";

        /// <summary>
        /// YBPAYD.
        /// </summary>
        public const string YBPAYD = "YBPAYD";

        /// <summary>
        /// YBUSR.
        /// </summary>
        public const string YBUSR = "YBUSR";

        /// <summary>
        /// YBGLCK.
        /// </summary>
        public const string YBGLCK = "YBGLCK";

        /// <summary>
        /// YBUFLG.
        /// </summary>
        public const string YBUFLG = "YBUFLG";

        /// <summary>
        /// YBPFRQ.
        /// </summary>
        public const string YBPFRQ = "YBPFRQ";

        /// <summary>
        /// YBUPMJ.
        /// </summary>
        public const string YBUPMJ = "YBUPMJ";

        /// <summary>
        /// YBUPMT.
        /// </summary>
        public const string YBUPMT = "YBUPMT";

        /// <summary>
        /// YBPID.
        /// </summary>
        public const string YBPID = "YBPID";

        /// <summary>
        /// YBJOBN.
        /// </summary>
        public const string YBJOBN = "YBJOBN";

        /// <summary>
        /// YBUSER.
        /// </summary>
        public const string YBUSER = "YBUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YBAN8", "YBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YBPAYD", "YBPAYD", JdeDataType.String, 20, true, true),
        new JdeField("YBUSR", "YBUSR", JdeDataType.String, 36),
        new JdeField("YBGLCK", "YBGLCK", JdeDataType.String, 2),
        new JdeField("YBUFLG", "YBUFLG", JdeDataType.String, 2),
        new JdeField("YBPFRQ", "YBPFRQ", JdeDataType.String, 2),
        new JdeField("YBUPMJ", "YBUPMJ", JdeDataType.Numeric),
        new JdeField("YBUPMT", "YBUPMT", JdeDataType.Numeric),
        new JdeField("YBPID", "YBPID", JdeDataType.String, 20),
        new JdeField("YBJOBN", "YBJOBN", JdeDataType.String, 20),
        new JdeField("YBUSER", "YBUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07300_0", "Primary Key on YBAN8, YBPAYD", new[] { "YBAN8", "YBPAYD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07300_2", "Index on YBPAYD", new[] { "YBPAYD" })
    };
}
