using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4001ZTX - .
/// </summary>
public class F4001ZTX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTEKCO.
        /// </summary>
        public const string RTEKCO = "RTEKCO";

        /// <summary>
        /// RTEDOC.
        /// </summary>
        public const string RTEDOC = "RTEDOC";

        /// <summary>
        /// RTEDCT.
        /// </summary>
        public const string RTEDCT = "RTEDCT";

        /// <summary>
        /// RTUTP.
        /// </summary>
        public const string RTUTP = "RTUTP";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4001ZTX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTEKCO", "RTEKCO", JdeDataType.String, 10, true, true),
        new JdeField("RTEDOC", "RTEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RTEDCT", "RTEDCT", JdeDataType.String, 4, true, true),
        new JdeField("RTUTP", "RTUTP", JdeDataType.String, 2),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4001ZTX_0", "Primary Key on RTEDOC, RTEDCT, RTEKCO", new[] { "RTEDOC", "RTEDCT", "RTEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
