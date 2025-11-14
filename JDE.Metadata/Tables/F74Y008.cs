using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y008 - .
/// </summary>
public class F74Y008 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// INTXA1.
        /// </summary>
        public const string INTXA1 = "INTXA1";

        /// <summary>
        /// INITM.
        /// </summary>
        public const string INITM = "INITM";

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
    public override string TableName => "F74Y008";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("INTXA1", "INTXA1", JdeDataType.String, 20, true, true),
        new JdeField("INITM", "INITM", JdeDataType.Numeric, null, true, true),
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
        new JdeIndex("F74Y008_0", "Primary Key on INTXA1, INITM", new[] { "INTXA1", "INITM" }, isUnique: true, isPrimaryKey: true)
    };
}
