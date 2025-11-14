using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA10B - .
/// </summary>
public class F90CA10B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IIITMHID.
        /// </summary>
        public const string IIITMHID = "IIITMHID";

        /// <summary>
        /// IIITM.
        /// </summary>
        public const string IIITM = "IIITM";

        /// <summary>
        /// IISTSUDT.
        /// </summary>
        public const string IISTSUDT = "IISTSUDT";

        /// <summary>
        /// IIACTIND.
        /// </summary>
        public const string IIACTIND = "IIACTIND";

        /// <summary>
        /// IIUSER.
        /// </summary>
        public const string IIUSER = "IIUSER";

        /// <summary>
        /// IIPID.
        /// </summary>
        public const string IIPID = "IIPID";

        /// <summary>
        /// IIVID.
        /// </summary>
        public const string IIVID = "IIVID";

        /// <summary>
        /// IIMKEY.
        /// </summary>
        public const string IIMKEY = "IIMKEY";

        /// <summary>
        /// IIUDTTM.
        /// </summary>
        public const string IIUDTTM = "IIUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA10B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IIITMHID", "IIITMHID", JdeDataType.Numeric, null, true, true),
        new JdeField("IIITM", "IIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IISTSUDT", "IISTSUDT", JdeDataType.Date),
        new JdeField("IIACTIND", "IIACTIND", JdeDataType.String, 2),
        new JdeField("IIUSER", "IIUSER", JdeDataType.String, 20),
        new JdeField("IIPID", "IIPID", JdeDataType.String, 20),
        new JdeField("IIVID", "IIVID", JdeDataType.String, 20),
        new JdeField("IIMKEY", "IIMKEY", JdeDataType.String, 30),
        new JdeField("IIUDTTM", "IIUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA10B_0", "Primary Key on IIITMHID, IIITM", new[] { "IIITMHID", "IIITM" }, isUnique: true, isPrimaryKey: true)
    };
}
