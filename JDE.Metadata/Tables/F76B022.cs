using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B022 - .
/// </summary>
public class F76B022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDB76IDOC.
        /// </summary>
        public const string IDB76IDOC = "IDB76IDOC";

        /// <summary>
        /// IDB76IDCT.
        /// </summary>
        public const string IDB76IDCT = "IDB76IDCT";

        /// <summary>
        /// IDB76IDLN.
        /// </summary>
        public const string IDB76IDLN = "IDB76IDLN";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDPID.
        /// </summary>
        public const string IDPID = "IDPID";

        /// <summary>
        /// IDJOBN.
        /// </summary>
        public const string IDJOBN = "IDJOBN";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDUPMT.
        /// </summary>
        public const string IDUPMT = "IDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDB76IDOC", "IDB76IDOC", JdeDataType.String, 20, true, true),
        new JdeField("IDB76IDCT", "IDB76IDCT", JdeDataType.String, 6, true, true),
        new JdeField("IDB76IDLN", "IDB76IDLN", JdeDataType.String, 50),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDPID", "IDPID", JdeDataType.String, 20),
        new JdeField("IDJOBN", "IDJOBN", JdeDataType.String, 20),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDUPMT", "IDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B022_0", "Primary Key on IDB76IDOC, IDB76IDCT", new[] { "IDB76IDOC", "IDB76IDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B022_2", "Index on IDB76IDLN, IDB76IDCT", new[] { "IDB76IDLN", "IDB76IDCT" })
    };
}
