using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0803 - .
/// </summary>
public class F76B0803 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCB76ATCT.
        /// </summary>
        public const string FCB76ATCT = "FCB76ATCT";

        /// <summary>
        /// FCJOBS.
        /// </summary>
        public const string FCJOBS = "FCJOBS";

        /// <summary>
        /// FCB76BLCK.
        /// </summary>
        public const string FCB76BLCK = "FCB76BLCK";

        /// <summary>
        /// FCITM.
        /// </summary>
        public const string FCITM = "FCITM";

        /// <summary>
        /// FCUOM1.
        /// </summary>
        public const string FCUOM1 = "FCUOM1";

        /// <summary>
        /// FCUOM.
        /// </summary>
        public const string FCUOM = "FCUOM";

        /// <summary>
        /// FCB76URAB.
        /// </summary>
        public const string FCB76URAB = "FCB76URAB";

        /// <summary>
        /// FCB76URAT.
        /// </summary>
        public const string FCB76URAT = "FCB76URAT";

        /// <summary>
        /// FCB76URRF.
        /// </summary>
        public const string FCB76URRF = "FCB76URRF";

        /// <summary>
        /// FCB76URDT.
        /// </summary>
        public const string FCB76URDT = "FCB76URDT";

        /// <summary>
        /// FCB76URCD.
        /// </summary>
        public const string FCB76URCD = "FCB76URCD";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";

        /// <summary>
        /// FCJOBN.
        /// </summary>
        public const string FCJOBN = "FCJOBN";

        /// <summary>
        /// FCUPMJ.
        /// </summary>
        public const string FCUPMJ = "FCUPMJ";

        /// <summary>
        /// FCUPMT.
        /// </summary>
        public const string FCUPMT = "FCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0803";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCB76ATCT", "FCB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("FCJOBS", "FCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("FCB76BLCK", "FCB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("FCITM", "FCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("FCUOM1", "FCUOM1", JdeDataType.String, 4, true, true),
        new JdeField("FCUOM", "FCUOM", JdeDataType.String, 4, true, true),
        new JdeField("FCB76URAB", "FCB76URAB", JdeDataType.Numeric),
        new JdeField("FCB76URAT", "FCB76URAT", JdeDataType.Numeric),
        new JdeField("FCB76URRF", "FCB76URRF", JdeDataType.String, 30),
        new JdeField("FCB76URDT", "FCB76URDT", JdeDataType.Numeric),
        new JdeField("FCB76URCD", "FCB76URCD", JdeDataType.String, 4),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCUPMJ", "FCUPMJ", JdeDataType.Numeric),
        new JdeField("FCUPMT", "FCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0803_0", "Primary Key on FCB76ATCT, FCJOBS, FCB76BLCK, FCITM, FCUOM1, FCUOM", new[] { "FCB76ATCT", "FCJOBS", "FCB76BLCK", "FCITM", "FCUOM1", "FCUOM" }, isUnique: true, isPrimaryKey: true)
    };
}
