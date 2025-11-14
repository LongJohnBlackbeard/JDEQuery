using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05WMM01 - .
/// </summary>
public class F05WMM01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHOBNM.
        /// </summary>
        public const string DHOBNM = "DHOBNM";

        /// <summary>
        /// DHMD.
        /// </summary>
        public const string DHMD = "DHMD";

        /// <summary>
        /// DHMMDRN.
        /// </summary>
        public const string DHMMDRN = "DHMMDRN";

        /// <summary>
        /// DHJOBN.
        /// </summary>
        public const string DHJOBN = "DHJOBN";

        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHUPMJ.
        /// </summary>
        public const string DHUPMJ = "DHUPMJ";

        /// <summary>
        /// DHUPMT.
        /// </summary>
        public const string DHUPMT = "DHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05WMM01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHOBNM", "DHOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DHMD", "DHMD", JdeDataType.String, 120),
        new JdeField("DHMMDRN", "DHMMDRN", JdeDataType.Numeric),
        new JdeField("DHJOBN", "DHJOBN", JdeDataType.String, 20),
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20),
        new JdeField("DHUPMJ", "DHUPMJ", JdeDataType.Numeric),
        new JdeField("DHUPMT", "DHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05WMM01_0", "Primary Key on DHOBNM", new[] { "DHOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
