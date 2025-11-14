using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y101 - .
/// </summary>
public class F74Y101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INAN8.
        /// </summary>
        public const string INAN8 = "INAN8";

        /// <summary>
        /// INY74SEC.
        /// </summary>
        public const string INY74SEC = "INY74SEC";

        /// <summary>
        /// INY74MOS.
        /// </summary>
        public const string INY74MOS = "INY74MOS";

        /// <summary>
        /// INUSER.
        /// </summary>
        public const string INUSER = "INUSER";

        /// <summary>
        /// INPID.
        /// </summary>
        public const string INPID = "INPID";

        /// <summary>
        /// INJOBN.
        /// </summary>
        public const string INJOBN = "INJOBN";

        /// <summary>
        /// INUPMJ.
        /// </summary>
        public const string INUPMJ = "INUPMJ";

        /// <summary>
        /// INUPMT.
        /// </summary>
        public const string INUPMT = "INUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INAN8", "INAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("INY74SEC", "INY74SEC", JdeDataType.String, 20),
        new JdeField("INY74MOS", "INY74MOS", JdeDataType.String, 2),
        new JdeField("INUSER", "INUSER", JdeDataType.String, 20),
        new JdeField("INPID", "INPID", JdeDataType.String, 20),
        new JdeField("INJOBN", "INJOBN", JdeDataType.String, 20),
        new JdeField("INUPMJ", "INUPMJ", JdeDataType.Numeric),
        new JdeField("INUPMT", "INUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y101_0", "Primary Key on INAN8", new[] { "INAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
