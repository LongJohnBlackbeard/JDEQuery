using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0741 - .
/// </summary>
public class F76B0741 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PBJOBS.
        /// </summary>
        public const string PBJOBS = "PBJOBS";

        /// <summary>
        /// PBB76BLCK.
        /// </summary>
        public const string PBB76BLCK = "PBB76BLCK";

        /// <summary>
        /// PBB76BLSQ.
        /// </summary>
        public const string PBB76BLSQ = "PBB76BLSQ";

        /// <summary>
        /// PBFTRC.
        /// </summary>
        public const string PBFTRC = "PBFTRC";

        /// <summary>
        /// PBB76BLST.
        /// </summary>
        public const string PBB76BLST = "PBB76BLST";

        /// <summary>
        /// PBURCD.
        /// </summary>
        public const string PBURCD = "PBURCD";

        /// <summary>
        /// PBURDT.
        /// </summary>
        public const string PBURDT = "PBURDT";

        /// <summary>
        /// PBURAT.
        /// </summary>
        public const string PBURAT = "PBURAT";

        /// <summary>
        /// PBURAB.
        /// </summary>
        public const string PBURAB = "PBURAB";

        /// <summary>
        /// PBURRF.
        /// </summary>
        public const string PBURRF = "PBURRF";

        /// <summary>
        /// PBUSER.
        /// </summary>
        public const string PBUSER = "PBUSER";

        /// <summary>
        /// PBPID.
        /// </summary>
        public const string PBPID = "PBPID";

        /// <summary>
        /// PBJOBN.
        /// </summary>
        public const string PBJOBN = "PBJOBN";

        /// <summary>
        /// PBUPMJ.
        /// </summary>
        public const string PBUPMJ = "PBUPMJ";

        /// <summary>
        /// PBUPMT.
        /// </summary>
        public const string PBUPMT = "PBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0741";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PBJOBS", "PBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PBB76BLCK", "PBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("PBB76BLSQ", "PBB76BLSQ", JdeDataType.Numeric),
        new JdeField("PBFTRC", "PBFTRC", JdeDataType.String, 2),
        new JdeField("PBB76BLST", "PBB76BLST", JdeDataType.String, 2),
        new JdeField("PBURCD", "PBURCD", JdeDataType.String, 4),
        new JdeField("PBURDT", "PBURDT", JdeDataType.Numeric),
        new JdeField("PBURAT", "PBURAT", JdeDataType.Numeric),
        new JdeField("PBURAB", "PBURAB", JdeDataType.Numeric),
        new JdeField("PBURRF", "PBURRF", JdeDataType.String, 30),
        new JdeField("PBUSER", "PBUSER", JdeDataType.String, 20),
        new JdeField("PBPID", "PBPID", JdeDataType.String, 20),
        new JdeField("PBJOBN", "PBJOBN", JdeDataType.String, 20),
        new JdeField("PBUPMJ", "PBUPMJ", JdeDataType.Numeric),
        new JdeField("PBUPMT", "PBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0741_0", "Primary Key on PBJOBS, PBB76BLCK", new[] { "PBJOBS", "PBB76BLCK" }, isUnique: true, isPrimaryKey: true)
    };
}
