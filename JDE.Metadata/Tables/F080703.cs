using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F080703 - .
/// </summary>
public class F080703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTLKUPTYP.
        /// </summary>
        public const string LTLKUPTYP = "LTLKUPTYP";

        /// <summary>
        /// LTINTTBL.
        /// </summary>
        public const string LTINTTBL = "LTINTTBL";

        /// <summary>
        /// LTENTNM.
        /// </summary>
        public const string LTENTNM = "LTENTNM";

        /// <summary>
        /// LTSY.
        /// </summary>
        public const string LTSY = "LTSY";

        /// <summary>
        /// LTRT.
        /// </summary>
        public const string LTRT = "LTRT";

        /// <summary>
        /// LTDTAI.
        /// </summary>
        public const string LTDTAI = "LTDTAI";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTUPMT.
        /// </summary>
        public const string LTUPMT = "LTUPMT";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";
    }

    /// <inheritdoc />
    public override string TableName => "F080703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTLKUPTYP", "LTLKUPTYP", JdeDataType.String, 2, true, true),
        new JdeField("LTINTTBL", "LTINTTBL", JdeDataType.String, 100, true, true),
        new JdeField("LTENTNM", "LTENTNM", JdeDataType.String, 80, true, true),
        new JdeField("LTSY", "LTSY", JdeDataType.String, 8),
        new JdeField("LTRT", "LTRT", JdeDataType.String, 4),
        new JdeField("LTDTAI", "LTDTAI", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTUPMT", "LTUPMT", JdeDataType.Numeric),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F080703_0", "Primary Key on LTLKUPTYP, LTINTTBL, LTENTNM", new[] { "LTLKUPTYP", "LTINTTBL", "LTENTNM" }, isUnique: true, isPrimaryKey: true)
    };
}
