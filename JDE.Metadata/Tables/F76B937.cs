using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B937 - .
/// </summary>
public class F76B937 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTB76SBON.
        /// </summary>
        public const string LTB76SBON = "LTB76SBON";

        /// <summary>
        /// LTLT.
        /// </summary>
        public const string LTLT = "LTLT";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTUPMT.
        /// </summary>
        public const string LTUPMT = "LTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B937";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTB76SBON", "LTB76SBON", JdeDataType.Numeric, null, true, true),
        new JdeField("LTLT", "LTLT", JdeDataType.String, 4, true, true),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTUPMT", "LTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B937_0", "Primary Key on LTB76SBON, LTLT", new[] { "LTB76SBON", "LTLT" }, isUnique: true, isPrimaryKey: true)
    };
}
