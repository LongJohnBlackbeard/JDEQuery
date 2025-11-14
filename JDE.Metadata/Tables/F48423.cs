using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48423 - .
/// </summary>
public class F48423 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDCO.
        /// </summary>
        public const string SDCO = "SDCO";

        /// <summary>
        /// SDSBCFDT.
        /// </summary>
        public const string SDSBCFDT = "SDSBCFDT";

        /// <summary>
        /// SDSBCMDT.
        /// </summary>
        public const string SDSBCMDT = "SDSBCMDT";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F48423";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDCO", "SDCO", JdeDataType.String, 10, true, true),
        new JdeField("SDSBCFDT", "SDSBCFDT", JdeDataType.String, 2),
        new JdeField("SDSBCMDT", "SDSBCMDT", JdeDataType.String, 2),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48423_0", "Primary Key on SDCO", new[] { "SDCO" }, isUnique: true, isPrimaryKey: true)
    };
}
