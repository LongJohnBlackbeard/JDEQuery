using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0743 - .
/// </summary>
public class F76B0743 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LVJOBS.
        /// </summary>
        public const string LVJOBS = "LVJOBS";

        /// <summary>
        /// LVB76FSLV.
        /// </summary>
        public const string LVB76FSLV = "LVB76FSLV";

        /// <summary>
        /// LVB76URAB.
        /// </summary>
        public const string LVB76URAB = "LVB76URAB";

        /// <summary>
        /// LVB76URAT.
        /// </summary>
        public const string LVB76URAT = "LVB76URAT";

        /// <summary>
        /// LVB76URRF.
        /// </summary>
        public const string LVB76URRF = "LVB76URRF";

        /// <summary>
        /// LVB76URDT.
        /// </summary>
        public const string LVB76URDT = "LVB76URDT";

        /// <summary>
        /// LVB76URCD.
        /// </summary>
        public const string LVB76URCD = "LVB76URCD";

        /// <summary>
        /// LVUSER.
        /// </summary>
        public const string LVUSER = "LVUSER";

        /// <summary>
        /// LVPID.
        /// </summary>
        public const string LVPID = "LVPID";

        /// <summary>
        /// LVJOBN.
        /// </summary>
        public const string LVJOBN = "LVJOBN";

        /// <summary>
        /// LVUPMJ.
        /// </summary>
        public const string LVUPMJ = "LVUPMJ";

        /// <summary>
        /// LVUPMT.
        /// </summary>
        public const string LVUPMT = "LVUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0743";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LVJOBS", "LVJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("LVB76FSLV", "LVB76FSLV", JdeDataType.String, 2),
        new JdeField("LVB76URAB", "LVB76URAB", JdeDataType.Numeric),
        new JdeField("LVB76URAT", "LVB76URAT", JdeDataType.Numeric),
        new JdeField("LVB76URRF", "LVB76URRF", JdeDataType.String, 30),
        new JdeField("LVB76URDT", "LVB76URDT", JdeDataType.Numeric),
        new JdeField("LVB76URCD", "LVB76URCD", JdeDataType.String, 4),
        new JdeField("LVUSER", "LVUSER", JdeDataType.String, 20),
        new JdeField("LVPID", "LVPID", JdeDataType.String, 20),
        new JdeField("LVJOBN", "LVJOBN", JdeDataType.String, 20),
        new JdeField("LVUPMJ", "LVUPMJ", JdeDataType.Numeric),
        new JdeField("LVUPMT", "LVUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0743_0", "Primary Key on LVJOBS", new[] { "LVJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
