using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0805 - .
/// </summary>
public class F76B0805 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TNB76ATCT.
        /// </summary>
        public const string TNB76ATCT = "TNB76ATCT";

        /// <summary>
        /// TNJOBS.
        /// </summary>
        public const string TNJOBS = "TNJOBS";

        /// <summary>
        /// TNB76BLCK.
        /// </summary>
        public const string TNB76BLCK = "TNB76BLCK";

        /// <summary>
        /// TNBNOP.
        /// </summary>
        public const string TNBNOP = "TNBNOP";

        /// <summary>
        /// TNBSOP.
        /// </summary>
        public const string TNBSOP = "TNBSOP";

        /// <summary>
        /// TNB76URAB.
        /// </summary>
        public const string TNB76URAB = "TNB76URAB";

        /// <summary>
        /// TNB76URAT.
        /// </summary>
        public const string TNB76URAT = "TNB76URAT";

        /// <summary>
        /// TNB76URRF.
        /// </summary>
        public const string TNB76URRF = "TNB76URRF";

        /// <summary>
        /// TNB76URDT.
        /// </summary>
        public const string TNB76URDT = "TNB76URDT";

        /// <summary>
        /// TNB76URCD.
        /// </summary>
        public const string TNB76URCD = "TNB76URCD";

        /// <summary>
        /// TNUSER.
        /// </summary>
        public const string TNUSER = "TNUSER";

        /// <summary>
        /// TNPID.
        /// </summary>
        public const string TNPID = "TNPID";

        /// <summary>
        /// TNJOBN.
        /// </summary>
        public const string TNJOBN = "TNJOBN";

        /// <summary>
        /// TNUPMJ.
        /// </summary>
        public const string TNUPMJ = "TNUPMJ";

        /// <summary>
        /// TNUPMT.
        /// </summary>
        public const string TNUPMT = "TNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0805";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TNB76ATCT", "TNB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("TNJOBS", "TNJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TNB76BLCK", "TNB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("TNBNOP", "TNBNOP", JdeDataType.Numeric, null, true, true),
        new JdeField("TNBSOP", "TNBSOP", JdeDataType.String, 4, true, true),
        new JdeField("TNB76URAB", "TNB76URAB", JdeDataType.Numeric),
        new JdeField("TNB76URAT", "TNB76URAT", JdeDataType.Numeric),
        new JdeField("TNB76URRF", "TNB76URRF", JdeDataType.String, 30),
        new JdeField("TNB76URDT", "TNB76URDT", JdeDataType.Numeric),
        new JdeField("TNB76URCD", "TNB76URCD", JdeDataType.String, 4),
        new JdeField("TNUSER", "TNUSER", JdeDataType.String, 20),
        new JdeField("TNPID", "TNPID", JdeDataType.String, 20),
        new JdeField("TNJOBN", "TNJOBN", JdeDataType.String, 20),
        new JdeField("TNUPMJ", "TNUPMJ", JdeDataType.Numeric),
        new JdeField("TNUPMT", "TNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0805_0", "Primary Key on TNB76ATCT, TNJOBS, TNB76BLCK, TNBNOP, TNBSOP", new[] { "TNB76ATCT", "TNJOBS", "TNB76BLCK", "TNBNOP", "TNBSOP" }, isUnique: true, isPrimaryKey: true)
    };
}
