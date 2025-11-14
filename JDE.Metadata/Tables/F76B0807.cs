using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0807 - .
/// </summary>
public class F76B0807 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCB76ATCT.
        /// </summary>
        public const string CCB76ATCT = "CCB76ATCT";

        /// <summary>
        /// CCJOBS.
        /// </summary>
        public const string CCJOBS = "CCJOBS";

        /// <summary>
        /// CCB76BLCK.
        /// </summary>
        public const string CCB76BLCK = "CCB76BLCK";

        /// <summary>
        /// CCMCU.
        /// </summary>
        public const string CCMCU = "CCMCU";

        /// <summary>
        /// CCB76URAB.
        /// </summary>
        public const string CCB76URAB = "CCB76URAB";

        /// <summary>
        /// CCB76URAT.
        /// </summary>
        public const string CCB76URAT = "CCB76URAT";

        /// <summary>
        /// CCB76URRF.
        /// </summary>
        public const string CCB76URRF = "CCB76URRF";

        /// <summary>
        /// CCB76URDT.
        /// </summary>
        public const string CCB76URDT = "CCB76URDT";

        /// <summary>
        /// CCB76URCD.
        /// </summary>
        public const string CCB76URCD = "CCB76URCD";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0807";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCB76ATCT", "CCB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("CCJOBS", "CCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CCB76BLCK", "CCB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("CCMCU", "CCMCU", JdeDataType.String, 24, true, true),
        new JdeField("CCB76URAB", "CCB76URAB", JdeDataType.Numeric),
        new JdeField("CCB76URAT", "CCB76URAT", JdeDataType.Numeric),
        new JdeField("CCB76URRF", "CCB76URRF", JdeDataType.String, 30),
        new JdeField("CCB76URDT", "CCB76URDT", JdeDataType.Numeric),
        new JdeField("CCB76URCD", "CCB76URCD", JdeDataType.String, 4),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0807_0", "Primary Key on CCB76ATCT, CCJOBS, CCB76BLCK, CCMCU", new[] { "CCB76ATCT", "CCJOBS", "CCB76BLCK", "CCMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
