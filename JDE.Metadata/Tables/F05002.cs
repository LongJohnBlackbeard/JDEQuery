using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05002 - .
/// </summary>
public class F05002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EVVOECATE.
        /// </summary>
        public const string EVVOECATE = "EVVOECATE";

        /// <summary>
        /// EVPDBA.
        /// </summary>
        public const string EVPDBA = "EVPDBA";

        /// <summary>
        /// EVEFFFROM.
        /// </summary>
        public const string EVEFFFROM = "EVEFFFROM";

        /// <summary>
        /// EVEFFTHRU.
        /// </summary>
        public const string EVEFFTHRU = "EVEFFTHRU";

        /// <summary>
        /// EVUSER.
        /// </summary>
        public const string EVUSER = "EVUSER";

        /// <summary>
        /// EVJOBN.
        /// </summary>
        public const string EVJOBN = "EVJOBN";

        /// <summary>
        /// EVUPMJ.
        /// </summary>
        public const string EVUPMJ = "EVUPMJ";

        /// <summary>
        /// EVUPMT.
        /// </summary>
        public const string EVUPMT = "EVUPMT";

        /// <summary>
        /// EVPID.
        /// </summary>
        public const string EVPID = "EVPID";
    }

    /// <inheritdoc />
    public override string TableName => "F05002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EVVOECATE", "EVVOECATE", JdeDataType.String, 20, true, true),
        new JdeField("EVPDBA", "EVPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("EVEFFFROM", "EVEFFFROM", JdeDataType.Numeric, null, true, true),
        new JdeField("EVEFFTHRU", "EVEFFTHRU", JdeDataType.Numeric),
        new JdeField("EVUSER", "EVUSER", JdeDataType.String, 20),
        new JdeField("EVJOBN", "EVJOBN", JdeDataType.String, 20),
        new JdeField("EVUPMJ", "EVUPMJ", JdeDataType.Numeric),
        new JdeField("EVUPMT", "EVUPMT", JdeDataType.Numeric),
        new JdeField("EVPID", "EVPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05002_0", "Primary Key on EVVOECATE, EVPDBA, EVEFFFROM", new[] { "EVVOECATE", "EVPDBA", "EVEFFFROM" }, isUnique: true, isPrimaryKey: true)
    };
}
